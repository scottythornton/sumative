using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace sumative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

            this.BackgroundImage = null;
            Refresh();

            SoundPlayer player = new SoundPlayer(Properties.Resources._154953__keykrusher__microwave_beep);

            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Font titleFont = new Font("Arial", 25, FontStyle.Bold);
            Font nameFont = new Font("Arial", 10, FontStyle.Bold);

            g.Clear(Color.Black);

            player.Play();
            g.FillEllipse(drawBrush, 457, 161, 10, 10);
            Thread.Sleep(500);
            player.Play();
            g.FillEllipse(drawBrush, 461, 533, 10, 10);
            Thread.Sleep(475);
            player.Play();
            g.FillEllipse(drawBrush, 335, 600, 10, 10);
            Thread.Sleep(450);
            player.Play();
            g.FillEllipse(drawBrush, 709, 630, 10, 10);  
            Thread.Sleep(425);

            g.DrawString("Cancer is one of twelve " +
                "\nconstellations in the zodiac." +
                "\nCancer is a medium sized" +
                "\nconstellation with an area" +
                "\nof 506 square degrees.", titleFont, drawBrush, 20, 20);

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush2 = new SolidBrush(Color.White);
            Font titleFont = new Font("Arial", 30, FontStyle.Bold);
            Font nameFont = new Font("Arial", 15, FontStyle.Bold);

            g.DrawString("Cancer", titleFont, drawBrush2, Width / 2 - 50, Height / 2 - 50);
            g.DrawString("By: Scotty Thornton", nameFont, drawBrush2, Width / 2 - 65, Height / 2);

        }
    }
}
