using System;
using System.Drawing;
using System.Windows.Forms;


namespace SAM0application
{
    public partial class UserInterface : Form
    {
        String[] text = {
            "Hello, my name is SAM the Symbiotic Autonomous Machine.I am a machine business owner!\nPress this button to try the komboucha tea I make.",
            "Thank you for your order. Pease place a cup under the tap and follow the instructions on the payment terminal",
            "Payment is being processed, your komboucha tea will be served in a few seconds.",
            "Something went wrong please try again",
            "just testing",
        };


        int[,] arrowPos =
        {//y position,rotation (default left)
  
            {200,90 },
            {400 ,180},
            {800 ,0},            
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
