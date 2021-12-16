using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Projet
{
    public partial class SendEmailForm : Form
    {
        //Path of image 
        public string path = "";
        //Image Bitmap
        public Bitmap myImage;

        //Fonction vérifiant la validité d'une adresse mail
        public bool isValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public SendEmailForm(string path)
        {
            InitializeComponent();
            this.path = path;
            //Affichage de l'image en pièce jointe
            Bitmap myImage = new Bitmap(path); ;
            this.pictureBox.Image = (Image)myImage;
        }

        //Bouton envoi du mail
        private void btnSend_Click(object sender, EventArgs e)
        {
            //Verification des champs 
            if (String.IsNullOrEmpty(this.txtSrcName.Text) || String.IsNullOrEmpty(this.txtSrcEmail.Text) || String.IsNullOrEmpty(this.txtDstName.Text) ||
                String.IsNullOrEmpty(this.txtDstEmail.Text))
            {
                this.lblError.Text = "Attention, les champs Expéditeurs et Destinataires doivent être remplis !";
                this.lblError.ForeColor = Color.Red;
            }
            else if (rbGmail.Checked == false && rbOrange.Checked == false)
            {
                this.lblError.Text = "Attention, il faut choisir un client mail !";
                this.lblError.ForeColor = Color.Red;
            }
            else
            {
                if (isValidEmail(this.txtSrcEmail.Text) == false || isValidEmail(this.txtDstEmail.Text) == false)
                {
                    this.lblError.Text = "Attention, les adresses mail ne sont pas valides !";
                    this.lblError.ForeColor = Color.Red;
                }
                else
                {
                    //Creation du mail et du contenu
                    Mail mail = new Mail(this.txtSrcName.Text, this.txtSrcEmail.Text, this.txtDstName.Text, this.txtDstEmail.Text);
                    mail.contentMail(this.txtSubject.Text, this.txtContent.Text, this.path);

                    //Creation du form pour la connexion smtp
                    EmailCredentials frmEmailCredentials = new EmailCredentials();
                    //Ajout de l'adresse mail en champ username pour la connexion
                    frmEmailCredentials.txtUsername.Text = this.txtSrcEmail.Text;

                    //Affichage de la fenetre de connexion smtp
                    if (frmEmailCredentials.ShowDialog() == DialogResult.OK)
                    {
                        //Fenetre envoi en cours et envoi succes
                        EmailSending emailSending = new EmailSending();
                        EmailSent emailSent = new EmailSent();

                        //Choix du serveur mail gmail
                        if (rbGmail.Checked)
                        {
                            //Essai d'envoi du mail
                            try
                            {
                                emailSending.Show();
                                mail.sendGmail(frmEmailCredentials.txtUsername.Text, frmEmailCredentials.txtPassword.Text);
                                emailSending.Close();
                                //Affichage succes
                                if (emailSent.ShowDialog() == DialogResult.OK) ;
                            }
                            //Si erreur, notification à l'utilisateur
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                emailSending.lblSending.Text = "ERREUR !";
                            }

                        }
                        //Choix du serveur mail orange
                        else if (rbOrange.Checked)
                        {
                            //Essai d'envoi du mail
                            try
                            {
                                //Affichage fenetre envoi
                                emailSending.Show();
                                mail.sendOrange(frmEmailCredentials.txtUsername.Text, frmEmailCredentials.txtPassword.Text);
                                emailSending.Close();
                                //Affichage succes
                                if (emailSent.ShowDialog() == DialogResult.OK) ;
                            }
                            //Si erreur, notification à l'utilisateur
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                emailSending.lblSending.Text = "ERREUR !";
                            }
                        }
                    }
                }
            }
        }
    }
}
