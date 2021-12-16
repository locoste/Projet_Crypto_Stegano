using System.IO;
using MailKit.Net.Smtp;
using MimeKit;

namespace Project
{
    //Classe pour l'envoi de mail contenant l'image avec le message chiffré
    public class Mail
    {
        //E-mail
        private MimeMessage mailMessage;

        //Constructeur avec paramètres
        /*Input
         *nom de l'expediteur, mail de l'expéditeur,
         *nom du destinataire, mail du destinataire
         */
        public Mail(string srcName, string srcEmail, string destName, string destEmail)
        {
            //Create new object MimeMessage
            mailMessage = new MimeMessage();
            //From
            mailMessage.From.Add(new MailboxAddress(srcName, srcEmail));
            //To
            mailMessage.To.Add(new MailboxAddress(destName, destEmail));
        }

        //Contenu du mail
        /* Input
         * Sujet du mail, contenu du mail, chemin vers l'image
         */
        public void contentMail(string subject, string content, string pathImage)
        {
            //Sujet du mail
            mailMessage.Subject = subject;
            //Texte dans le mail
            var body = new TextPart("plain")
            {
                Text = content
            };
            //Chemin de l'image
            string path = pathImage;
            //Créer un lien avec l'image
            var attachement = new MimePart("image", "bmp")
            {
                Content = new MimeContent(File.OpenRead(path), ContentEncoding.Default),
                ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                ContentTransferEncoding = ContentEncoding.Default,
                FileName = Path.GetFileName(path)
            };
            //Creation d'un multipart pour lier le contenu et la pièce jointe
            var multipart = new Multipart("mixed");
            multipart.Add(body);
            multipart.Add(attachement);
            
            //Ajout du multipart au contenu du mail 
            mailMessage.Body = multipart;
        }

        //Fonction pour envoyer depuis une adresse mail Orange
        public void sendOrange(string email, string pass)
        {
            //Création du client Smtp
            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect("smtp.orange.fr", 465, true);
                smtpClient.Authenticate(email, pass);
                smtpClient.Send(mailMessage);
                smtpClient.Disconnect(true);
            }
        }

        //Fonction pour envoyer depuis une adresse mail Gmail
        public void sendGmail(string email, string pass)
        {
            //Création du client Smtp
            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect("smtp.gmail.com", 465, true);
                smtpClient.Authenticate(email, pass);
                smtpClient.Send(mailMessage);
                smtpClient.Disconnect(true);
            }
        }

        //Fonction pour envoyer depuis une adresse mail Lyon 2
        public void sendLyon2(string email, string pass)
        {
            //Création du client Smtp
            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Connect("smtp.univ-lyon2.fr", 465, true);
                smtpClient.Authenticate(email, pass);
                smtpClient.Send(mailMessage);
                smtpClient.Disconnect(true);
            }
        }
    }
}