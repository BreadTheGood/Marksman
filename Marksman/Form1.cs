using System.Media;
using System.Numerics;
using System.Security.Policy;
using WMPLib;
using System.Timers;





namespace Marksman
{
    public partial class window : Form
    {
        
        

        // variables
        int puntos = 100;

        double tries = 0;

        double missed = 0;

        double acc = 0;

        double oks = 0;



        System.Windows.Forms.Timer timer1;
        int counter = 56;        
        public void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                BGM();

                timer1.Stop();
            }               
            
        }

        public void BGM()
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"C:\Users\NSX\source\repos\Marksman\Marksman\bin\Assets\soundtrack.mp3";
            wplayer.controls.play();

            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();

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
            wplayer.URL = @"C:\Users\NSX\source\repos\Marksman\Marksman\bin\Assets\shot.wav";
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
            //ramdon img selection
            Random rnd = new Random();
            int num3 = rnd.Next(1, 3);
            if (num3==1) {
                pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\NSX\source\repos\Marksman\Marksman\bin\Assets\sphere3.png");
            } else {
                pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\NSX\source\repos\Marksman\Marksman\bin\Assets\sphere 2.png");
            }
            //relocating delay
            System.Threading.Thread.Sleep(500);

            //show new target
            pictureBox1.Visible = true;

            // initial rounded form
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;

            //appear sound
            SoundPlayer appear = new SoundPlayer(@"C:\Users\NSX\source\repos\Marksman\Marksman\bin\Assets\target.wav");
            appear.Play();

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
            SoundPlayer shot = new SoundPlayer(@"C:\Users\NSX\source\repos\Marksman\Marksman\bin\Assets\shot.wav");
            shot.Play();
        }
    }
}
