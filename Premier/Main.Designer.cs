﻿
namespace Project
{
    partial class Main
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
            this.chiffrer = new System.Windows.Forms.Button();
            this.dechiffrer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chiffrer
            // 
            this.chiffrer.Location = new System.Drawing.Point(107, 106);
            this.chiffrer.Name = "chiffrer";
            this.chiffrer.Size = new System.Drawing.Size(230, 81);
            this.chiffrer.TabIndex = 0;
            this.chiffrer.Text = "Cacher message";
            this.chiffrer.UseVisualStyleBackColor = true;
            this.chiffrer.Click += new System.EventHandler(this.chiffrer_Click);
            // 
            // dechiffrer
            // 
            this.dechiffrer.Location = new System.Drawing.Point(107, 243);
            this.dechiffrer.Name = "dechiffrer";
            this.dechiffrer.Size = new System.Drawing.Size(230, 91);
            this.dechiffrer.TabIndex = 1;
            this.dechiffrer.Text = "Déchiffrer message";
            this.dechiffrer.UseVisualStyleBackColor = true;
            this.dechiffrer.Click += new System.EventHandler(this.dechiffrer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chiffrage dechiffrage RSA Stéganographie";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 386);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dechiffrer);
            this.Controls.Add(this.chiffrer);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chiffrer;
        private System.Windows.Forms.Button dechiffrer;
        private System.Windows.Forms.Label label1;
    }
}