/*
    Custom panel used to visualize the particles positions
    Created while studying the CS373 course at UdaCity (www.udacity.com)
    Author: Moustafa Alzantot (m.alzantot@gmail.com)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace FastSLAM
{
   partial class MapControl : System.Windows.Forms.Panel
    {

        public static int Point_Width = 6;
        public double MapWidth;
        public ArrayList particles = null;
     
        public double pixels_per_meter
        {
            get
            {
                return this.Width / this.MapWidth;
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Random rnd = new Random();
            Graphics g = e.Graphics;
            if (this.BackgroundImage == null)
            {

                g.FillRectangle(Brushes.Azure, 0, 0, this.Width, this.Height);


            }
            if (particles != null)
            {
                for (int i = 0; i < particles.Count; i++)
                {
                    Particle p = (Particle) particles[i];
                    Brush b = Brushes.Black;
                    g.FillRectangle(b, (int) (p.X * Width), (int) ( p.Y * Height), 2, 2);
                }
            }
           
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapControl));
            this.SuspendLayout();


        }
    }
}
