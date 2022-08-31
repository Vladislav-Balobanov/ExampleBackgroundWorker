namespace TestBackgroundWorker
{
    partial class ProgressDilog
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
            this.ProgressDialog_PB = new System.Windows.Forms.ProgressBar();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProgressDialog_PB
            // 
            this.ProgressDialog_PB.Location = new System.Drawing.Point(13, 13);
            this.ProgressDialog_PB.Name = "ProgressDialog_PB";
            this.ProgressDialog_PB.Size = new System.Drawing.Size(460, 23);
            this.ProgressDialog_PB.TabIndex = 0;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(379, 55);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(94, 26);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // ProgressDilog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 93);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.ProgressDialog_PB);
            this.Name = "ProgressDilog";
            this.Text = "ProgressDilog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressDialog_PB;
        private System.Windows.Forms.Button Cancel_Button;
    }
}