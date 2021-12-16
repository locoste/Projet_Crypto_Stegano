namespace Project
{
    partial class EmailSending
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
            this.lblSending = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSending
            // 
            this.lblSending.AutoSize = true;
            this.lblSending.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSending.Location = new System.Drawing.Point(50, 45);
            this.lblSending.Name = "lblSending";
            this.lblSending.Size = new System.Drawing.Size(127, 21);
            this.lblSending.TabIndex = 0;
            this.lblSending.Text = "Envoi en cours...";
            // 
            // EmailSending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 113);
            this.Controls.Add(this.lblSending);
            this.Name = "EmailSending";
            this.Text = "EmailSending";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblSending;
    }
}