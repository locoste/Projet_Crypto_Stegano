
namespace Project
{
    partial class Chiffrage
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
            this.image_a_chiffrer = new System.Windows.Forms.PictureBox();
            this.charger_image_button = new System.Windows.Forms.Button();
            this.save_image = new System.Windows.Forms.Button();
            this.message_to_hide = new System.Windows.Forms.TextBox();
            this.cacher_message = new System.Windows.Forms.Button();
            this.send_mail = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.get_txt_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image_a_chiffrer)).BeginInit();
            this.SuspendLayout();
            // 
            // image_a_chiffrer
            // 
            this.image_a_chiffrer.Location = new System.Drawing.Point(27, 89);
            this.image_a_chiffrer.Name = "image_a_chiffrer";
            this.image_a_chiffrer.Size = new System.Drawing.Size(602, 511);
            this.image_a_chiffrer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_a_chiffrer.TabIndex = 0;
            this.image_a_chiffrer.TabStop = false;
            // 
            // charger_image_button
            // 
            this.charger_image_button.Location = new System.Drawing.Point(27, 34);
            this.charger_image_button.Name = "charger_image_button";
            this.charger_image_button.Size = new System.Drawing.Size(146, 29);
            this.charger_image_button.TabIndex = 1;
            this.charger_image_button.Text = "Charger image";
            this.charger_image_button.UseVisualStyleBackColor = true;
            this.charger_image_button.Click += new System.EventHandler(this.charger_image_Click);
            // 
            // save_image
            // 
            this.save_image.Location = new System.Drawing.Point(236, 34);
            this.save_image.Name = "save_image";
            this.save_image.Size = new System.Drawing.Size(146, 29);
            this.save_image.TabIndex = 2;
            this.save_image.Text = "Sauvegarder image";
            this.save_image.UseVisualStyleBackColor = true;
            this.save_image.Click += new System.EventHandler(this.save_image_Click);
            // 
            // message_to_hide
            // 
            this.message_to_hide.AcceptsReturn = true;
            this.message_to_hide.AcceptsTab = true;
            this.message_to_hide.Location = new System.Drawing.Point(660, 89);
            this.message_to_hide.Multiline = true;
            this.message_to_hide.Name = "message_to_hide";
            this.message_to_hide.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.message_to_hide.Size = new System.Drawing.Size(293, 189);
            this.message_to_hide.TabIndex = 3;
            // 
            // cacher_message
            // 
            this.cacher_message.Location = new System.Drawing.Point(775, 309);
            this.cacher_message.Name = "cacher_message";
            this.cacher_message.Size = new System.Drawing.Size(135, 29);
            this.cacher_message.TabIndex = 4;
            this.cacher_message.Text = "Cacher message";
            this.cacher_message.UseVisualStyleBackColor = true;
            this.cacher_message.Click += new System.EventHandler(this.cacher_message_Click);
            // 
            // send_mail
            // 
            this.send_mail.Location = new System.Drawing.Point(751, 396);
            this.send_mail.Name = "send_mail";
            this.send_mail.Size = new System.Drawing.Size(142, 78);
            this.send_mail.TabIndex = 5;
            this.send_mail.Text = "Envoie image par mail";
            this.send_mail.UseVisualStyleBackColor = true;
            this.send_mail.Click += new System.EventHandler(this.send_mail_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // get_txt_button
            // 
            this.get_txt_button.Location = new System.Drawing.Point(751, 34);
            this.get_txt_button.Name = "get_txt_button";
            this.get_txt_button.Size = new System.Drawing.Size(159, 29);
            this.get_txt_button.TabIndex = 6;
            this.get_txt_button.Text = "Charger fichier Texte";
            this.get_txt_button.UseVisualStyleBackColor = true;
            this.get_txt_button.Click += new System.EventHandler(this.get_txt_button_Click);
            // 
            // Chiffrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(965, 612);
            this.Controls.Add(this.get_txt_button);
            this.Controls.Add(this.send_mail);
            this.Controls.Add(this.cacher_message);
            this.Controls.Add(this.message_to_hide);
            this.Controls.Add(this.save_image);
            this.Controls.Add(this.charger_image_button);
            this.Controls.Add(this.image_a_chiffrer);
            this.Name = "Chiffrage";
            this.Text = "Chiffrage";
            ((System.ComponentModel.ISupportInitialize)(this.image_a_chiffrer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image_a_chiffrer;
        private System.Windows.Forms.Button charger_image_button;
        private System.Windows.Forms.Button save_image;
        private System.Windows.Forms.TextBox message_to_hide;
        private System.Windows.Forms.Button cacher_message;
        private System.Windows.Forms.Button send_mail;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button get_txt_button;
    }
}