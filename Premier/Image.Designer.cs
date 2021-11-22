
namespace Project
{
    partial class Image
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.get_image = new System.Windows.Forms.Button();
            this.file_name = new System.Windows.Forms.Label();
            this.message_to_hide = new System.Windows.Forms.TextBox();
            this.message_hide_label = new System.Windows.Forms.Label();
            this.hide_message = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.get_message = new System.Windows.Forms.Button();
            this.code_carac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(45, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 275);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // get_image
            // 
            this.get_image.Location = new System.Drawing.Point(45, 45);
            this.get_image.Name = "get_image";
            this.get_image.Size = new System.Drawing.Size(94, 29);
            this.get_image.TabIndex = 1;
            this.get_image.Text = "Get image";
            this.get_image.UseVisualStyleBackColor = true;
            this.get_image.Click += new System.EventHandler(this.get_image_Click);
            // 
            // file_name
            // 
            this.file_name.AutoSize = true;
            this.file_name.Location = new System.Drawing.Point(165, 49);
            this.file_name.Name = "file_name";
            this.file_name.Size = new System.Drawing.Size(71, 20);
            this.file_name.TabIndex = 2;
            this.file_name.Text = "file name";
            // 
            // message_to_hide
            // 
            this.message_to_hide.Location = new System.Drawing.Point(490, 99);
            this.message_to_hide.Name = "message_to_hide";
            this.message_to_hide.Size = new System.Drawing.Size(217, 27);
            this.message_to_hide.TabIndex = 3;
            // 
            // message_hide_label
            // 
            this.message_hide_label.AutoSize = true;
            this.message_hide_label.Location = new System.Drawing.Point(490, 67);
            this.message_hide_label.Name = "message_hide_label";
            this.message_hide_label.Size = new System.Drawing.Size(118, 20);
            this.message_hide_label.TabIndex = 4;
            this.message_hide_label.Text = "Message to hide";
            // 
            // hide_message
            // 
            this.hide_message.Location = new System.Drawing.Point(490, 153);
            this.hide_message.Name = "hide_message";
            this.hide_message.Size = new System.Drawing.Size(94, 29);
            this.hide_message.TabIndex = 5;
            this.hide_message.Text = "Hide";
            this.hide_message.UseVisualStyleBackColor = true;
            this.hide_message.Click += new System.EventHandler(this.hide_message_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(490, 315);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(67, 20);
            this.message.TabIndex = 6;
            this.message.Text = "message";
            // 
            // get_message
            // 
            this.get_message.Location = new System.Drawing.Point(490, 270);
            this.get_message.Name = "get_message";
            this.get_message.Size = new System.Drawing.Size(134, 29);
            this.get_message.TabIndex = 7;
            this.get_message.Text = "Get message";
            this.get_message.UseVisualStyleBackColor = true;
            this.get_message.Click += new System.EventHandler(this.get_message_Click);
            // 
            // code_carac
            // 
            this.code_carac.AutoSize = true;
            this.code_carac.Location = new System.Drawing.Point(490, 205);
            this.code_carac.Name = "code_carac";
            this.code_carac.Size = new System.Drawing.Size(50, 20);
            this.code_carac.TabIndex = 8;
            this.code_carac.Text = "label2";
            // 
            // Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.code_carac);
            this.Controls.Add(this.get_message);
            this.Controls.Add(this.message);
            this.Controls.Add(this.hide_message);
            this.Controls.Add(this.message_hide_label);
            this.Controls.Add(this.message_to_hide);
            this.Controls.Add(this.file_name);
            this.Controls.Add(this.get_image);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Image";
            this.Text = "Image";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button get_image;
        private System.Windows.Forms.Label file_name;
        private System.Windows.Forms.TextBox message_to_hide;
        private System.Windows.Forms.Label message_hide_label;
        private System.Windows.Forms.Button hide_message;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button get_message;
        private System.Windows.Forms.Label code_carac;
    }
}