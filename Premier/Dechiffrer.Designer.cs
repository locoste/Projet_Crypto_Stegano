
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
            this.Image_encode.Location = new System.Drawing.Point(18, 66);
            this.Image_encode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Image_encode.Name = "Image_encode";
            this.Image_encode.Size = new System.Drawing.Size(502, 354);
            this.Image_encode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image_encode.TabIndex = 0;
            this.Image_encode.TabStop = false;
            // 
            // ouvrir_image
            // 
            this.ouvrir_image.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ouvrir_image.Location = new System.Drawing.Point(33, 20);
            this.ouvrir_image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ouvrir_image.Name = "ouvrir_image";
            this.ouvrir_image.Size = new System.Drawing.Size(113, 33);
            this.ouvrir_image.TabIndex = 1;
            this.ouvrir_image.Text = "Ouvrir image";
            this.ouvrir_image.UseVisualStyleBackColor = true;
            this.ouvrir_image.Click += new System.EventHandler(this.ouvrir_image_Click);
            // 
            // dechiffrer_button
            // 
            this.dechiffrer_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dechiffrer_button.Location = new System.Drawing.Point(590, 227);
            this.dechiffrer_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dechiffrer_button.Name = "dechiffrer_button";
            this.dechiffrer_button.Size = new System.Drawing.Size(178, 33);
            this.dechiffrer_button.TabIndex = 2;
            this.dechiffrer_button.Text = "Dechiffrer message";
            this.dechiffrer_button.UseVisualStyleBackColor = true;
            this.dechiffrer_button.Click += new System.EventHandler(this.dechiffrer_button_Click);
            // 
            // message
            // 
            this.message.AcceptsReturn = true;
            this.message.AcceptsTab = true;
            this.message.Location = new System.Drawing.Point(553, 89);
            this.message.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.message.Size = new System.Drawing.Size(252, 117);
            this.message.TabIndex = 3;
            // 
            // Dechiffrer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(831, 460);
            this.Controls.Add(this.message);
            this.Controls.Add(this.dechiffrer_button);
            this.Controls.Add(this.ouvrir_image);
            this.Controls.Add(this.Image_encode);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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