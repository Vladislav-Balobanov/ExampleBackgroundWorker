namespace TestBackgroundWorker
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
            this.Progress_Label = new System.Windows.Forms.Label();
            this.Start_Button = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Result_Label = new System.Windows.Forms.Label();
            this.backgroundCounter = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Progress_Label
            // 
            this.Progress_Label.AutoSize = true;
            this.Progress_Label.Location = new System.Drawing.Point(9, 16);
            this.Progress_Label.Name = "Progress_Label";
            this.Progress_Label.Size = new System.Drawing.Size(65, 13);
            this.Progress_Label.TabIndex = 0;
            this.Progress_Label.Text = "Press start...";
            // 
            // Start_Button
            // 
            this.Start_Button.Location = new System.Drawing.Point(168, 123);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(107, 31);
            this.Start_Button.TabIndex = 2;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 66);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(263, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(12, 123);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(107, 31);
            this.Cancel_Button.TabIndex = 4;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Result_Label
            // 
            this.Result_Label.AutoSize = true;
            this.Result_Label.Location = new System.Drawing.Point(168, 16);
            this.Result_Label.Name = "Result_Label";
            this.Result_Label.Size = new System.Drawing.Size(96, 13);
            this.Result_Label.TabIndex = 5;
            this.Result_Label.Text = "Result will be hre...";
            // 
            // backgroundCounter
            // 
            this.backgroundCounter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundCounter_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 166);
            this.Controls.Add(this.Result_Label);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.Progress_Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Progress_Label;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label Result_Label;
        private System.ComponentModel.BackgroundWorker backgroundCounter;
    }
}

