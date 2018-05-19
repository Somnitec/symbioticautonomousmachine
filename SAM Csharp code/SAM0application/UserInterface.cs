using System;
using System.Drawing;
using System.Windows.Forms;


namespace SAM0application
{
    public partial class UserInterface : Form
    {
        String[] text = {
            "PL:\nDzień dobry, nazywam się SAM, Symbiotyczna Autonomiczna Maszyna. Jestem właścicielem firmy komputerowej! Naciśnij przycisk powyżej, aby wypróbować herbatę kombucha, którą wykonuję.\n\n\n" +
                "EN:\nHello, my name is SAM, the\nSymbiotic Autonomous Machine.\nI am a machine business owner!\nPress the button to try the kombucha tea I make.",
            "PL:\nDziękuję za Twoje zamówienie.\nUmieść filiżankę pod kranem i postępuj zgodnie z instrukcjami na terminalu płatniczym po prawej stronie. Przetworzenie płatności może chwilę potrwać.\n\n\n" +
                "EN:\nThank you for your order. Please place a cup under the tap and follow the instructions on the payment terminal on the right. It can take a few moments to process the payment.",
            "PL:\nPłatność jest akceptowana, Twoja herbata kombucha będzie serwowana od razu.\n\n\n" +
                "EN:\nPayment is being processed, your kombucha tea will be served right away.",
            "PL:\nCoś poszło nie tak.\nProszę spróbuj ponownie.\n\n\n" +
                "EN:\nSomething went wrong.\nPlease try again.",
            "just testing.",
        };


        int[,] arrowPos =
        {//y position,rotation (default left)
  
            {150,90 },
            {150 ,180},
            {900 ,0},            
            {-100,0},
            {-100,0},
        };

        public UserInterface()
        {
            InitializeComponent();
            
        }

        public int _changeInterface
        {
            set {
                Image image = new Bitmap(Properties.Resources.arrow);
                arrowBox.Image=(Bitmap)image.Clone();
                Image oldImage = arrowBox.Image;
                arrowBox.Image = RotateImage(image, arrowPos[value % text.Length, 1]);
                if (oldImage != null)oldImage.Dispose();
                arrowBox.Top = arrowPos[value % text.Length, 0];

                interfaceText.Text = text[value % text.Length];
            }
        }

        public static Bitmap RotateImage(Image image,  float angle)
        {
            if (image == null)
                throw new ArgumentNullException("image");

            //create a new empty bitmap to hold rotated image
            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            //make a graphics object from the empty bitmap
            Graphics g = Graphics.FromImage(rotatedBmp);

            //Put the rotation point in the center of the image
            g.TranslateTransform(image.Width/2, image.Height/2);

            //rotate the image
            g.RotateTransform(angle);

            //move the image back
            g.TranslateTransform(-image.Width / 2, -image.Height / 2);

            //draw passed in image onto graphics object
            g.DrawImage(image, new PointF(0, 0));

            return rotatedBmp;
        }


    }

    
}
