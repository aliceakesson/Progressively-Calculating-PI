using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progressively_Calculating_PI
{
    public partial class Form1 : Form
    {

        bool gameIsRunning = true;
        int width = 7;
        int height = 7;

        double amountOfDots = 0;
        double dotsInCircle = 0;

        int safetyMargin = 500; // change this to your liking, larger number = slower results but more precise ones 
        int index = 0;
        int k = 0;

        int currentFirstNumber = 0, prevFirstNumber = 0; 

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(50, 50);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcTimer_Tick(object sender, EventArgs e)
        {

            #region Preview of value

            Random rnd = new Random();
            int x = rnd.Next(-400, 400);
            int y = rnd.Next(-400, 400);

            amountOfDots++;

            double distance = x * x + y * y;
            if (distance <= 400 * 400)
                dotsInCircle++;

            double PI = 4 * (double)(dotsInCircle / amountOfDots);

            if (index > 0)
            {
                PI *= Math.Pow(10, index-1);
                PI -= (int)(PI);
                PI *= 10;
            }

            Console.WriteLine(PI);

            prevFirstNumber = currentFirstNumber;
            currentFirstNumber = (int)PI;

            if (currentFirstNumber == prevFirstNumber)
                k++;
            else
                k = 0;

            if (k == safetyMargin)
            {
                k = 0;
                pi_label.Text += currentFirstNumber;

                if(index == 0)
                   pi_label.Text += ",";

                index++;
            }

            #endregion

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            #region Graphic Simulation
            //Graphics g = e.Graphics;
            //Pen penSquare = new Pen(Color.Red);
            //Brush brushSquare = (Brush)Brushes.Red;

            //Pen penCircle = new Pen(Color.Green);
            //Brush brushCircle = (Brush)Brushes.Green;

            //pi_label.Visible = false; 
            //Random rnd = new Random();

            //while(gameIsRunning)
            //{
            //    int x = rnd.Next(-400, 400);
            //    int y = rnd.Next(-400, 400);

            //    amountOfDots++;

            //    double distance = x * x + y * y; 
            //    if(distance > 400*400)
            //    {
            //        g.DrawEllipse(penSquare, x + 400, y + 400, width, height);
            //        g.FillEllipse(brushSquare, x + 400, y + 400, width, height);
            //    }
            //    else
            //    {
            //        dotsInCircle++; 
            //        g.DrawEllipse(penCircle, x + 400, y + 400, width, height);
            //        g.FillEllipse(brushCircle, x + 400, y + 400, width, height);
            //    }

            //    double PI = 4 * (double)(dotsInCircle/amountOfDots);
            //    Console.WriteLine(PI);

            //}
            #endregion

        }
    }
}
