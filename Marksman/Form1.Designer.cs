using WMPLib;

namespace Marksman
{
    partial class window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Digital-7 Mono", 20F, FontStyle.Bold);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 0;
            label1.Text = "Puntos = 30";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Digital-7 Mono", 20F, FontStyle.Bold);
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(207, 28);
            label2.TabIndex = 1;
            label2.Text = "Accuracy = 100%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Digital-7 Mono", 20F, FontStyle.Bold);
            label3.Location = new Point(1659, 9);
            label3.Name = "label3";
            label3.Size = new Size(129, 28);
            label3.TabIndex = 2;
            label3.Text = "tries = 0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Digital-7 Mono", 20F, FontStyle.Bold);
            label4.Location = new Point(1640, 93);
            label4.Name = "label4";
            label4.Size = new Size(142, 28);
            label4.TabIndex = 3;
            label4.Text = "Missed = 0";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\NSX\source\repos\Marksman\Marksman\Assets\sphere 2.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(727, 410);
            pictureBox1.MaximumSize = new Size(100, 100);
            pictureBox1.MinimumSize = new Size(15, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.LocationChanged += pictureBox1_LocationChanged;
            pictureBox1.SizeChanged += pictureBox1_SizeChanged;
            pictureBox1.VisibleChanged += pictureBox1_VisibleChanged;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // window
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Digital-7 Mono", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "window";
            Text = "Marksman";
            Click += window_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}
