using System.Media;
using System.Numerics;
using System.Security.Policy;
using WMPLib;
using System.Timers;





namespace Marksman
{
    public partial class window : Form
    {
        // timer test
        private System.Windows.Forms.Timer timer11;
        private int Ccounter = 60;
        
        // variables
        int puntos = 30;

        double tries = 0;

        double missed = 0;

        double acc = 0;

        double oks = 0;
       
        System.Windows.Forms.Timer timer1;
        int counter = 56;
        int counter2 = 0;   
        public void timer1_Tick_1(object sender, EventArgs e)
        {
            counter--;
            counter2++;
            if (counter == 0)
            {
                BGM();

                counter = 57;
            }

            if (counter2 == 2)
            {

                //hide target
                pictureBox1.Visible = false;

                //object new random location and size
                Random rnd = new Random();
                int num1 = rnd.Next(100, 1500);
                int num2 = rnd.Next(100, 800);
                int rndSize = rnd.Next(30, 100);

                //object relocation and resizing
                pictureBox1.Location = new System.Drawing.Point(num1, num2);
                pictureBox1.Width = rndSize;
                pictureBox1.Height = rndSize;

                target_Appear();

                counter2 = 0;

            }



        }                
        private void BGM()
        {
            WMPLib.WindowsMediaPlayer BGMplayer = new WMPLib.WindowsMediaPlayer();
            BGMplayer.URL = @"C:\Users\NSX\source\repos\Marksman\Marksman\bin\Assets\soundtrack.mp3";
            BGMplayer.settings.volume = 300;
            BGMplayer.controls.play();
            
            
        }
        public window()
        {
            InitializeComponent();

            BGM();            

            //Cursor.Current = new Cursor(@"C:\Users\NSX\source\repos\Marksman\Marksman\bin\Assets\cursor.cur");

            // initial rounded form
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;



        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            //shot sound

            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.settings.volume = 5;
            wplayer.URL = @"C:\Users\NSX\source\repos\Marksman\Marksman\bin\Assets\target.wav";
            wplayer.controls.play();

            //hide target
            pictureBox1.Visible = false;

            //object new random location and size
            Random rnd = new Random();
            int num1 = rnd.Next(100, 1500);
            int num2 = rnd.Next(100, 800);
            int rndSize = rnd.Next(30, 100);

            //object relocation and resizing
            pictureBox1.Location = new System.Drawing.Point(num1, num2);
            pictureBox1.Width = rndSize;
            pictureBox1.Height = rndSize;

            //score calculation
            puntos--;
            tries++;
            oks++;
            acc = Math.Round((oks * 100) / tries, 2);

            //display score
            label2.Text = " Accuracy =" + acc + "%";

            label3.Text = "tries =" + tries;

            label1.Text = "Puntos = " + puntos.ToString();

            counter2 = 0;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_LocationChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            target_Appear();

        }

        private void target_Appear()
        {

            //ramdon img selection
            Random rnd = new Random();
            int num3 = rnd.Next(1, 3);
            if (num3 == 1)
            {
                pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\NSX\source\repos\Marksman\Marksman\Assets\sphere3.png");
            }
            else
            {
                pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\NSX\source\repos\Marksman\Marksman\Assets\sphere 2.png");
            }
            //relocating delay
            System.Threading.Thread.Sleep(100);

            //show new target
            pictureBox1.Visible = true;

            // initial rounded form
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;

            //appear sound            
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.settings.volume = 5;
            wplayer.URL = @"C:\Users\NSX\source\repos\Marksman\Marksman\bin\Assets\appear.wav";
            wplayer.controls.play();

        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        private void window_Click(object sender, EventArgs e)
        {
            missed++;
            tries++;

            acc = Math.Round((oks * 100) / tries, 2);

            label2.Text = " Accuracy =" + acc + "%";

            label3.Text = "tries =" + tries;

            label4.Text = "Missed = " + missed;

            label1.Text = "Puntos = " + puntos.ToString();

            //shot sound            
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.settings.volume = 5;
            wplayer.URL = @"C:\Users\NSX\source\repos\Marksman\Marksman\bin\Assets\targethit.mp3";
            wplayer.controls.play();
        }

        
    }
}
