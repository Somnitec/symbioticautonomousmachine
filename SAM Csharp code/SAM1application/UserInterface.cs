using System;
using System.Drawing;
using System.Windows.Forms;


namespace SAM1application
{
    public partial class UserInterface : Form
    {
        
        Image image1 = new Bitmap(Properties.Resources.sam3gif);
        Image image2 = new Bitmap(Properties.Resources.sam3p1);
        Image image3 = new Bitmap(Properties.Resources.samp2);



        String[] text = {
            "NL:\nHallo, mijn naam is SAM, Symbiotic Autonomous Machine. Ik ben een machine-ondernemer! Druk op de knop hierboven om de Kombucha-thee te proberen die ik maak.\n\n\n" +
                "EN:\nHello, my name is SAM, the\nSymbiotic Autonomous Machine.\nI am a machine business owner!\nPress the button to try the kombucha tea I make.",
            "NL:\nBedankt voor je bestelling. \nPlaats de beker onder de kraan en volg de instructies op de betaalterminal aan de rechterkant. Het kan een tijdje duren om uw betaling te verwerken.\n\n\n" +
                "EN:\nThank you for your order. Please place a cup under the tap and follow the instructions on the payment terminal on the right. It can take a few moments to process the payment.",
            "NL:\nDe betaling is geaccepteerd, uw Kombucha-thee wordt meteen geserveerd.\n\n\n" +
                "EN:\nPayment is being processed, your kombucha tea will be served right away.",
            "NL:\nEr is iets misgegaan.\nProbeer het opnieuw.\n\n\n" +
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
            priceLabel.Hide();
            currentAmount.Hide();


        }

        public int _setAmount
        {
            set
            {
                currentAmount.Text = value.ToString() + " 元";
            }
        }

        public int _setPrice
        {
            set
            {
                priceLabel.Text = "the price is "+ value.ToString() + " 元";
            }
        }

        public int _changeInterface
        {
            set {

                //Image oldImage = interfaceImage.Image;
                //if (oldImage != null) oldImage.Dispose();


                if (value % text.Length == 0)
                    {
                    interfaceImage.Image = image1;
                    }
                 if (value % text.Length == 1)
                {
                    interfaceImage.Image = image2;
                }
                   if (value % text.Length == 2)
                {
                    interfaceImage.Image = image3;
                }
                
                
                //arrowBox.Image = RotateImage(image, arrowPos[value % text.Length, 1]);
                //arrowBox.Top = arrowPos[value % text.Length, 0];

                //interfaceText.Text = text[value % text.Length];

                //if(value % text.Length == 1) priceLabel.Show();
                //else priceLabel.Hide();
                
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
