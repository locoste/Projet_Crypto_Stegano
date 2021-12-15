﻿using System;
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
                    catch(Exception ex)
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