using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ShellShock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int enemyXCor, enemyYCor, myXCor, myYCor = 0;
        int XCorValue, YCorValue = 0;
        bool firstClick, secondClick = false;
        string path = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\ShellShock.csv";

        protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseMove(e);
            XCorValue = Cursor.Position.X;
            YCorValue = Cursor.Position.Y;

            XCorLabel.Text = XCorValue.ToString();
            YCorLabel.Text = YCorValue.ToString();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (firstClick == false && secondClick == false)
            {
                firstClick = true;
                myXCor = Cursor.Position.X;
                myYCor = Cursor.Position.Y;
                ClickStatus.Text = "Your position registered!";
                MyPosLabel.Text = "My pos: (" + myXCor.ToString() + ", " + myYCor.ToString() + ")";
            }
            else if (firstClick == true && secondClick == false)
            {
                secondClick = true;
                enemyXCor = Cursor.Position.X;
                enemyYCor = Cursor.Position.Y;
                ClickStatus.Text = "Your and enemey position registered!";
                EnPosLabel.Text = "En. pos: (" + enemyXCor.ToString() + ", " + enemyYCor.ToString() + ")";
            }
            else if (firstClick == true && secondClick == true)
            {
                firstClick = false;
                secondClick = false;
                ClickStatus.Text = "Ready.";
                MyPosLabel.Text = "My pos:";
                EnPosLabel.Text = "En. Pos:";
            }
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            if (firstClick == true && secondClick == true)
            {
                string[] lines = File.ReadAllLines(path);
                List<int> distances = new List<int>();
                List<int> angles = new List<int>();
                int posdiff = Math.Abs(myXCor - enemyXCor);
                int mindiff = 1000;
                int minindex = 0;
                string moveinfo = "";

                for (int i = 0; i <= lines.Length - 1; i++)
                {
                    distances.Add(Int32.Parse(lines[i].Split(',')[2]));
                }

                for (int i = 0; i <= lines.Length - 1; i++)
                {
                    angles.Add(Int32.Parse(lines[i].Split(',')[1]));
                }

                for (int i = 0; i <= lines.Length - 1; i++)
                {
                    if ((Math.Abs(distances.ElementAt(i) - posdiff)) < mindiff)
                    {
                        mindiff = Math.Abs(distances.ElementAt(i) - posdiff);
                        minindex = i;
                    }
                }

                if ((distances.ElementAt(minindex) - posdiff) < 0)
                {
                    moveinfo = "move " + mindiff.ToString() + " pixels closer.";
                }
                else
                {
                    moveinfo = "move " + mindiff.ToString() + " pixels away.";
                }

                ResultLabel.Text = "Use angle of " + angles.ElementAt(minindex) + " and " + moveinfo;

            } 
        }
    }

}
