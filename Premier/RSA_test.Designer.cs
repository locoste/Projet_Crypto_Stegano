
namespace Project
{
    partial class RSA_test
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
            this.button1 = new System.Windows.Forms.Button();
            this.private_key = new System.Windows.Forms.Label();
            this.public_key = new System.Windows.Forms.Label();
            this.nb_premier = new System.Windows.Forms.NumericUpDown();
            this.message_to_encode = new System.Windows.Forms.TextBox();
            this.get_rsa_button = new System.Windows.Forms.Button();
            this.rsa_code = new System.Windows.Forms.Label();
            this.get_message_button = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.code_ascii = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nb_premier)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get public & private keys";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // private_key
            // 
            this.private_key.AutoSize = true;
            this.private_key.Location = new System.Drawing.Point(390, 56);
            this.private_key.Name = "private_key";
            this.private_key.Size = new System.Drawing.Size(82, 20);
            this.private_key.TabIndex = 1;
            this.private_key.Text = "Private Key";
            // 
            // public_key
            // 
            this.public_key.AutoSize = true;
            this.public_key.Location = new System.Drawing.Point(390, 106);
            this.public_key.Name = "public_key";
            this.public_key.Size = new System.Drawing.Size(77, 20);
            this.public_key.TabIndex = 2;
            this.public_key.Text = "Public Key";
            // 
            // nb_premier
            // 
            this.nb_premier.Location = new System.Drawing.Point(87, 158);
            this.nb_premier.Name = "nb_premier";
            this.nb_premier.Size = new System.Drawing.Size(150, 27);
            this.nb_premier.TabIndex = 4;
            // 
            // message_to_encode
            // 
            this.message_to_encode.Location = new System.Drawing.Point(390, 169);
            this.message_to_encode.Name = "message_to_encode";
            this.message_to_encode.Size = new System.Drawing.Size(125, 27);
            this.message_to_encode.TabIndex = 5;
            // 
            // get_rsa_button
            // 
            this.get_rsa_button.Location = new System.Drawing.Point(390, 213);
            this.get_rsa_button.Name = "get_rsa_button";
            this.get_rsa_button.Size = new System.Drawing.Size(94, 29);
            this.get_rsa_button.TabIndex = 6;
            this.get_rsa_button.Text = "Get code RSA";
            this.get_rsa_button.UseVisualStyleBackColor = true;
            this.get_rsa_button.Click += new System.EventHandler(this.get_rsa_button_Click);
            // 
            // rsa_code
            // 
            this.rsa_code.AutoSize = true;
            this.rsa_code.Location = new System.Drawing.Point(390, 254);
            this.rsa_code.Name = "rsa_code";
            this.rsa_code.Size = new System.Drawing.Size(50, 20);
            this.rsa_code.TabIndex = 7;
            this.rsa_code.Text = "label1";
            // 
            // get_message_button
            // 
            this.get_message_button.Location = new System.Drawing.Point(390, 303);
            this.get_message_button.Name = "get_message_button";
            this.get_message_button.Size = new System.Drawing.Size(125, 29);
            this.get_message_button.TabIndex = 8;
            this.get_message_button.Text = "Get message";
            this.get_message_button.UseVisualStyleBackColor = true;
            this.get_message_button.Click += new System.EventHandler(this.get_message_button_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(390, 352);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(50, 20);
            this.message.TabIndex = 9;
            this.message.Text = "label2";
            // 
            // code_ascii
            // 
            this.code_ascii.AutoSize = true;
            this.code_ascii.Location = new System.Drawing.Point(551, 172);
            this.code_ascii.Name = "code_ascii";
            this.code_ascii.Size = new System.Drawing.Size(50, 20);
            this.code_ascii.TabIndex = 10;
            this.code_ascii.Text = "label1";
            // 
            // RSA_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.code_ascii);
            this.Controls.Add(this.message);
            this.Controls.Add(this.get_message_button);
            this.Controls.Add(this.rsa_code);
            this.Controls.Add(this.get_rsa_button);
            this.Controls.Add(this.message_to_encode);
            this.Controls.Add(this.nb_premier);
            this.Controls.Add(this.public_key);
            this.Controls.Add(this.private_key);
            this.Controls.Add(this.button1);
            this.Name = "RSA_test";
            this.Text = "RSA_test";
            ((System.ComponentModel.ISupportInitialize)(this.nb_premier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label private_key;
        private System.Windows.Forms.Label public_key;
        private System.Windows.Forms.NumericUpDown nb_premier;
        private System.Windows.Forms.TextBox message_to_encode;
        private System.Windows.Forms.Button get_rsa_button;
        private System.Windows.Forms.Label rsa_code;
        private System.Windows.Forms.Button get_message_button;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label code_ascii;
    }
}