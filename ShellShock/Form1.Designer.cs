namespace ShellShock
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.XLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.XCorLabel = new System.Windows.Forms.Label();
            this.YCorLabel = new System.Windows.Forms.Label();
            this.ClickStatus = new System.Windows.Forms.Label();
            this.MyPosLabel = new System.Windows.Forms.Label();
            this.EnPosLabel = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(0, 0);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(17, 13);
            this.XLabel.TabIndex = 0;
            this.XLabel.Text = "X:";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(0, 23);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(17, 13);
            this.YLabel.TabIndex = 1;
            this.YLabel.Text = "Y:";
            // 
            // XCorLabel
            // 
            this.XCorLabel.AutoSize = true;
            this.XCorLabel.Location = new System.Drawing.Point(12, 0);
            this.XCorLabel.Name = "XCorLabel";
            this.XCorLabel.Size = new System.Drawing.Size(13, 13);
            this.XCorLabel.TabIndex = 2;
            this.XCorLabel.Text = "0";
            // 
            // YCorLabel
            // 
            this.YCorLabel.AutoSize = true;
            this.YCorLabel.Location = new System.Drawing.Point(12, 23);
            this.YCorLabel.Name = "YCorLabel";
            this.YCorLabel.Size = new System.Drawing.Size(13, 13);
            this.YCorLabel.TabIndex = 3;
            this.YCorLabel.Text = "0";
            // 
            // ClickStatus
            // 
            this.ClickStatus.AutoSize = true;
            this.ClickStatus.Location = new System.Drawing.Point(0, 46);
            this.ClickStatus.Name = "ClickStatus";
            this.ClickStatus.Size = new System.Drawing.Size(41, 13);
            this.ClickStatus.TabIndex = 4;
            this.ClickStatus.Text = "Ready.";
            // 
            // MyPosLabel
            // 
            this.MyPosLabel.AutoSize = true;
            this.MyPosLabel.Location = new System.Drawing.Point(0, 74);
            this.MyPosLabel.Name = "MyPosLabel";
            this.MyPosLabel.Size = new System.Drawing.Size(44, 13);
            this.MyPosLabel.TabIndex = 5;
            this.MyPosLabel.Text = "My pos:";
            // 
            // EnPosLabel
            // 
            this.EnPosLabel.AutoSize = true;
            this.EnPosLabel.Location = new System.Drawing.Point(0, 102);
            this.EnPosLabel.Name = "EnPosLabel";
            this.EnPosLabel.Size = new System.Drawing.Size(47, 13);
            this.EnPosLabel.TabIndex = 6;
            this.EnPosLabel.Text = "En. Pos:";
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(3, 128);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 7;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(0, 164);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(110, 13);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Text = "Waiting to calculate...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.EnPosLabel);
            this.Controls.Add(this.MyPosLabel);
            this.Controls.Add(this.ClickStatus);
            this.Controls.Add(this.YCorLabel);
            this.Controls.Add(this.XCorLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Name = "Form1";
            this.Opacity = 0.5D;
            this.Text = "ShellBot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label XCorLabel;
        private System.Windows.Forms.Label YCorLabel;
        private System.Windows.Forms.Label ClickStatus;
        private System.Windows.Forms.Label MyPosLabel;
        private System.Windows.Forms.Label EnPosLabel;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Label ResultLabel;
        
    }
}

