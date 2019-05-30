using System;
using System.Drawing;
using System.Windows.Forms;


namespace SAM4application
{


    public partial class UserInterface : Form
    {

        
        Image idleimage = new Bitmap(Properties.Resources.idle);
        Image priceimage = new Bitmap(Properties.Resources.price);
        Image wiatingtotapimage = new Bitmap(Properties.Resources.waitingtotap);
        Image thankyouimage = new Bitmap(Properties.Resources.thankyou);

        int interfaceState = 0;

      
        public UserInterface()
        {
            InitializeComponent();

            priceLabel.Hide();
        }

        public int _setPrice
        {
            set
            {
                float amount = value / 100;
                priceLabel.Text = "€ " + (amount ).ToString("0.00") + " ≈  kr " + (amount *7.5).ToString("0.00");
            }
        }

      


        public int _changeInterface
        {
            set
            {
                if (value == 2) value = 3;
                //Image oldImage = interfaceImage.Image;
                //if (oldImage != null) oldImage.Dispose();
                interfaceState = value;

                priceLabel.Hide();
                if (value  == 0)
                {
                    interfaceImage.Image = idleimage;

                }
                if (value == 1)
                {
                    interfaceImage.Image = priceimage;
                    //priceLabel.Show();
                }
                if (value == 2)
                {
                    interfaceImage.Image = wiatingtotapimage;
                }
                if (value == 3)
                {
                    interfaceImage.Image = thankyouimage;
                    System.Threading.Thread.Sleep(5000);
                    interfaceState = 0;
                    interfaceImage.Image = idleimage;
                }
            
            }
        }

       
        private void InterfaceImage_Click(object sender, EventArgs e)
        {
            if (interfaceState == 0)
            {

                MainForm master = (MainForm)Application.OpenForms["MainForm"];
                master.FakeSodaButton.PerformClick();

                
                //MainForm.startClick();
                //click sodabutton
            }

            if (interfaceState == 1)
            {
                //wait for payment
            }
            if (interfaceState == 2)
            {
                MainForm.pumpClick();
                //wait for tapping
            }
            if (interfaceState == 3)
            {
                //thank you
            }
        }
    }

    
}
