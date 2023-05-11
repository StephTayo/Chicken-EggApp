namespace ChickenOrEgg
{
    partial class frmMain
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
            this.picAnswer = new System.Windows.Forms.PictureBox();
            this.cboAnswer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // picAnswer
            // 
            this.picAnswer.Location = new System.Drawing.Point(320, 37);
            this.picAnswer.Name = "picAnswer";
            this.picAnswer.Size = new System.Drawing.Size(220, 263);
            this.picAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnswer.TabIndex = 1;
            this.picAnswer.TabStop = false;
            // 
            // cboAnswer
            // 
            this.cboAnswer.FormattingEnabled = true;
            this.cboAnswer.Items.AddRange(new object[] {
            "Chicken",
            "Egg",
            "Neither"});
            this.cboAnswer.Location = new System.Drawing.Point(49, 127);
            this.cboAnswer.Name = "cboAnswer";
            this.cboAnswer.Size = new System.Drawing.Size(176, 28);
            this.cboAnswer.TabIndex = 2;
            this.cboAnswer.SelectedIndexChanged += new System.EventHandler(this.cboAnswer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "What was first?";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(594, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboAnswer);
            this.Controls.Add(this.picAnswer);
            this.Name = "frmMain";
            this.Text = "Important Question";
            ((System.ComponentModel.ISupportInitialize)(this.picAnswer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picAnswer;
        private System.Windows.Forms.ComboBox cboAnswer;
        private System.Windows.Forms.Label label1;
    } // end class
} // end namespace

