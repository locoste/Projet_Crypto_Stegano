
namespace Project
{
    partial class SendEmailForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSrcName = new System.Windows.Forms.TextBox();
            this.lblNomSrc = new System.Windows.Forms.Label();
            this.lblEmailSrc = new System.Windows.Forms.Label();
            this.txtSrcEmail = new System.Windows.Forms.TextBox();
            this.lblNameDest = new System.Windows.Forms.Label();
            this.lblEmailDst = new System.Windows.Forms.Label();
            this.txtDstName = new System.Windows.Forms.TextBox();
            this.txtDstEmail = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblAttach = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rbGmail = new System.Windows.Forms.RadioButton();
            this.rbOrange = new System.Windows.Forms.RadioButton();
            this.lblClientMail = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSrcName
            // 
            this.txtSrcName.Location = new System.Drawing.Point(162, 30);
            this.txtSrcName.Name = "txtSrcName";
            this.txtSrcName.Size = new System.Drawing.Size(279, 23);
            this.txtSrcName.TabIndex = 0;
            // 
            // lblNomSrc
            // 
            this.lblNomSrc.AutoSize = true;
            this.lblNomSrc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomSrc.Location = new System.Drawing.Point(12, 28);
            this.lblNomSrc.Name = "lblNomSrc";
            this.lblNomSrc.Size = new System.Drawing.Size(129, 21);
            this.lblNomSrc.TabIndex = 1;
            this.lblNomSrc.Text = "Nom Expéditeur";
            // 
            // lblEmailSrc
            // 
            this.lblEmailSrc.AutoSize = true;
            this.lblEmailSrc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmailSrc.Location = new System.Drawing.Point(12, 71);
            this.lblEmailSrc.Name = "lblEmailSrc";
            this.lblEmailSrc.Size = new System.Drawing.Size(131, 21);
            this.lblEmailSrc.TabIndex = 2;
            this.lblEmailSrc.Text = "Email Expéditeur";
            // 
            // txtSrcEmail
            // 
            this.txtSrcEmail.Location = new System.Drawing.Point(162, 69);
            this.txtSrcEmail.Name = "txtSrcEmail";
            this.txtSrcEmail.Size = new System.Drawing.Size(279, 23);
            this.txtSrcEmail.TabIndex = 3;
            // 
            // lblNameDest
            // 
            this.lblNameDest.AutoSize = true;
            this.lblNameDest.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameDest.Location = new System.Drawing.Point(12, 109);
            this.lblNameDest.Name = "lblNameDest";
            this.lblNameDest.Size = new System.Drawing.Size(137, 21);
            this.lblNameDest.TabIndex = 4;
            this.lblNameDest.Text = "Nom Destinataire";
            // 
            // lblEmailDst
            // 
            this.lblEmailDst.AutoSize = true;
            this.lblEmailDst.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmailDst.Location = new System.Drawing.Point(12, 148);
            this.lblEmailDst.Name = "lblEmailDst";
            this.lblEmailDst.Size = new System.Drawing.Size(139, 21);
            this.lblEmailDst.TabIndex = 5;
            this.lblEmailDst.Text = "Email Destinataire";
            // 
            // txtDstName
            // 
            this.txtDstName.Location = new System.Drawing.Point(162, 111);
            this.txtDstName.Name = "txtDstName";
            this.txtDstName.Size = new System.Drawing.Size(279, 23);
            this.txtDstName.TabIndex = 6;
            // 
            // txtDstEmail
            // 
            this.txtDstEmail.Location = new System.Drawing.Point(162, 150);
            this.txtDstEmail.Name = "txtDstEmail";
            this.txtDstEmail.Size = new System.Drawing.Size(279, 23);
            this.txtDstEmail.TabIndex = 7;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(69, 199);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(372, 23);
            this.txtSubject.TabIndex = 8;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubject.Location = new System.Drawing.Point(12, 201);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(51, 21);
            this.lblSubject.TabIndex = 9;
            this.lblSubject.Text = "Objet";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(162, 286);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(91, 60);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // lblAttach
            // 
            this.lblAttach.AutoSize = true;
            this.lblAttach.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAttach.Location = new System.Drawing.Point(12, 306);
            this.lblAttach.Name = "lblAttach";
            this.lblAttach.Size = new System.Drawing.Size(95, 21);
            this.lblAttach.TabIndex = 11;
            this.lblAttach.Text = "Pièce jointe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Contenu du mail";
            // 
            // txtContent
            // 
            this.txtContent.AcceptsReturn = true;
            this.txtContent.AcceptsTab = true;
            this.txtContent.AllowDrop = true;
            this.txtContent.Location = new System.Drawing.Point(162, 366);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(279, 189);
            this.txtContent.TabIndex = 13;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSend.Location = new System.Drawing.Point(468, 14);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(83, 39);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Envoyer";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rbGmail
            // 
            this.rbGmail.AutoSize = true;
            this.rbGmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbGmail.Location = new System.Drawing.Point(162, 245);
            this.rbGmail.Name = "rbGmail";
            this.rbGmail.Size = new System.Drawing.Size(69, 25);
            this.rbGmail.TabIndex = 15;
            this.rbGmail.TabStop = true;
            this.rbGmail.Text = "Gmail";
            this.rbGmail.UseVisualStyleBackColor = true;
            // 
            // rbOrange
            // 
            this.rbOrange.AutoSize = true;
            this.rbOrange.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbOrange.Location = new System.Drawing.Point(248, 245);
            this.rbOrange.Name = "rbOrange";
            this.rbOrange.Size = new System.Drawing.Size(82, 25);
            this.rbOrange.TabIndex = 16;
            this.rbOrange.TabStop = true;
            this.rbOrange.Text = "Orange";
            this.rbOrange.UseVisualStyleBackColor = true;
            // 
            // lblClientMail
            // 
            this.lblClientMail.AutoSize = true;
            this.lblClientMail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClientMail.Location = new System.Drawing.Point(12, 245);
            this.lblClientMail.Name = "lblClientMail";
            this.lblClientMail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblClientMail.Size = new System.Drawing.Size(87, 21);
            this.lblClientMail.TabIndex = 17;
            this.lblClientMail.Text = "Client Mail";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.Location = new System.Drawing.Point(12, 567);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 21);
            this.lblError.TabIndex = 18;
            // 
            // SendEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 597);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblClientMail);
            this.Controls.Add(this.rbOrange);
            this.Controls.Add(this.rbGmail);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAttach);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtDstEmail);
            this.Controls.Add(this.txtDstName);
            this.Controls.Add(this.lblEmailDst);
            this.Controls.Add(this.lblNameDest);
            this.Controls.Add(this.txtSrcEmail);
            this.Controls.Add(this.lblEmailSrc);
            this.Controls.Add(this.lblNomSrc);
            this.Controls.Add(this.txtSrcName);
            this.Name = "SendEmailForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSrcName;
        private System.Windows.Forms.Label lblNomSrc;
        private System.Windows.Forms.Label lblEmailSrc;
        private System.Windows.Forms.TextBox txtSrcEmail;
        private System.Windows.Forms.Label lblNameDest;
        private System.Windows.Forms.Label lblEmailDst;
        private System.Windows.Forms.TextBox txtDstName;
        private System.Windows.Forms.TextBox txtDstEmail;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblAttach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RadioButton rbGmail;
        private System.Windows.Forms.RadioButton rbOrange;
        private System.Windows.Forms.Label lblClientMail;
        private System.Windows.Forms.Label lblError;
    }
}

