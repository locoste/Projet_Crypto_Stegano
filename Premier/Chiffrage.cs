using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    public partial class Chiffrage : Form
    {
        // contient l'image bitmap à encoder.
        private Bitmap encoded_image = null;
        private Boolean is_saved = false;
        private string path;

        // Constructeur de la classe
        public Chiffrage()
        {
            InitializeComponent();
        }

        /*
         * <summary>Cette fonction récupère le message renseigné dans le champs "message_to_hide" et 
         * cache le message dans l'image via la fonction hide_message() si l'utilisateur a renseigner un message et qu'il a charger une image.
         * Si le message est trop grand pour l'image, une fenetre s'ouvre pour en informer l'utilisateur.</summary>
         */
        private void cacher_message_Click(object sender, EventArgs e)
        {
            Message message = new Message(this.message_to_hide.Text);

            if (this.image_a_chiffrer.Image != null && message.get_message() != "")
            {
                if (message.get_message().Length - 3 > this.image_a_chiffrer.Image.Height)
                {
                    Message_Trop_Grand m_err = new Message_Trop_Grand();

                    m_err.ShowDialog();

                    if (m_err.DialogResult == DialogResult.OK)
                    {
                        m_err.Close();
                    }
                }
                else
                {
                    Bitmap imagebmp = new Bitmap(this.image_a_chiffrer.Image);
                    Image_Encode img_encode = new Image_Encode(imagebmp);

                    img_encode.set_message(message);

                    img_encode.hide_message_better();

                    this.encoded_image = img_encode.get_image();

                    this.image_a_chiffrer.Image = img_encode.get_image();
                    this.is_saved = false;
                }
            } 
            else
            {
                Erreur_chiffrement err = new Erreur_chiffrement();

                err.ShowDialog();

                if (err.DialogResult == DialogResult.OK)
                {
                    err.Close();
                }
            }
        }

        /* 
         * <summary>Appel la classe SendEmailForm pour afficher l'interface d'envoie de mail</summary>
         */
        private void send_mail_Click(object sender, EventArgs e)
        {
            if(this.encoded_image != null)
            {
                if (!this.is_saved)
                {
                    save_image_bitmap();
                  
                }
                if (this.is_saved)
                {
                    var sendemailform = new SendEmailForm(this.path);

                    sendemailform.ShowDialog();
                }
            }
            
        }

        private void save_image_bitmap()
        {
            if(this.encoded_image != null)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Bitmap Image|*.bmp";

                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if(this.path == Path.GetFullPath(saveFileDialog1.FileName))
                    {
                        saveFileDialog1.FileName += "_1";
                    }
                    FileStream fs = (FileStream)saveFileDialog1.OpenFile();

                    Bitmap clone = new Bitmap(this.encoded_image.Width, this.encoded_image.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                    using (Graphics gr = Graphics.FromImage(clone))
                    {
                        gr.DrawImage(this.encoded_image, new Rectangle(0, 0, clone.Width, clone.Height));
                    }
                    clone.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                    this.path = Path.GetFullPath(saveFileDialog1.FileName);
                    fs.Close();
                    this.is_saved = true;
                }
            }
        }

        /* 
         * <summary>Cette fonction est appellé pour charger une image dans l'application via l'explorateur Windows. 
         * Une fois chargé, il affiche l'image dans l'interface et la sauvegarde dans l'attribut "encoded_image" de la classe.</summary>
         */
        private void charger_image_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    System.Drawing.Image image1 = System.Drawing.Image.FromFile(filePath);

                    this.image_a_chiffrer.Image = image1;

                    this.encoded_image = new Bitmap(image1);

                    this.is_saved = false;

                    this.path = filePath;
                }
            }
        }

        /* 
         * <summary>Cette fonction est appellé pour sauvegarder l'image sur l'ordinateur de l'utilisateur via l'explorateur Windows</summary>
         */
        private void save_image_Click(object sender, EventArgs e)
        {
            if (this.encoded_image != null)
            {
                save_image_bitmap();
            }
        }

        /* 
         * <summary>Cette fonction est appellé pour charger un fichier texte qui contient le message à chiffrer et cacher dans l'image.
         * Celui-ci est affiché dans le champs "message_to_hide" de l'interface.</summary>
         */
        private void get_txt_button_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    string text = System.IO.File.ReadAllText(filePath);
                    this.message_to_hide.Text = text;
                }
            }
        }
    }
}
