
namespace Project
{
    partial class Dechiffrer
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
            this.Image_encode = new System.Windows.Forms.PictureBox();
            this.ouvrir_image = new System.Windows.Forms.Button();
            this.dechiffrer_button = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Image_encode)).BeginInit();
            this.SuspendLayout();
            // 
            // Image_encode
            // 
            this.Image_encode.Location = new System.Drawing.Point(12, 84);
            this.Image_encode.Name = "Image_encode";
            this.Image_encode.Size = new System.Drawing.Size(397, 344);
            this.Image_encode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Image_encode.TabIndex = 0;
            this.Image_encode.TabStop = false;
            // 
            // ouvrir_image
            // 
            this.ouvrir_image.Location = new System.Drawing.Point(12, 32);
            this.ouvrir_image.Name = "ouvrir_image";
            this.ouvrir_image.Size = new System.Drawing.Size(129, 29);
            this.ouvrir_image.TabIndex = 1;
            this.ouvrir_image.Text = "Ouvrir image";
            this.ouvrir_image.UseVisualStyleBackColor = true;
            this.ouvrir_image.Click += new System.EventHandler(this.ouvrir_image_Click);
            // 
            // dechiffrer_button
            // 
            this.dechiffrer_button.Location = new System.Drawing.Point(526, 32);
            this.dechiffrer_button.Name = "dechiffrer_button";
            this.dechiffrer_button.Size = new System.Drawing.Size(204, 29);
            this.dechiffrer_button.TabIndex = 2;
            this.dechiffrer_button.Text = "Dechiffrer message";
            this.dechiffrer_button.UseVisualStyleBackColor = true;
            this.dechiffrer_button.Click += new System.EventHandler(this.dechiffrer_button_Click);
            // 
            // message
            // 
            this.message.AcceptsReturn = true;
            this.message.AcceptsTab = true;
            this.message.Location = new System.Drawing.Point(480, 114);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.message.Size = new System.Drawing.Size(288, 155);
            this.message.TabIndex = 3;
            // 
            // Dechiffrer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.message);
            this.Controls.Add(this.dechiffrer_button);
            this.Controls.Add(this.ouvrir_image);
            this.Controls.Add(this.Image_encode);
            this.Name = "Dechiffrer";
            this.Text = "Dechiffrer";
            ((System.ComponentModel.ISupportInitialize)(this.Image_encode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Image_encode;
        private System.Windows.Forms.Button ouvrir_image;
        private System.Windows.Forms.Button dechiffrer_button;
        private System.Windows.Forms.TextBox message;
    }
}