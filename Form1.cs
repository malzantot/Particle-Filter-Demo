/*
    Particle Filter Demo and Visualization tool
    Created while studying the CS373 course at UdaCity (www.udacity.com)
    Author: Moustafa Alzantot (m.alzantot@gmail.com)
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace FastSLAM
{
    public partial class Form1 : Form
    {
       
        int numParticles = 10000;
        double step_size = 0.15;
        double step_noise = 0.02;
        double theta = 0;
        double theta_noise = Math.PI / 2;
        private Boolean stop;
        private Random  rand=  new Random();
        public Form1()
        {
            InitializeComponent();
            txtNumParticles.Text = numParticles + "" ;
            txtStepSize.Text = step_size + "";
            txtOrientation.Text = (theta * 180.0 / Math.PI) + "";
            txtOrientationNoise.Text = (theta_noise * 180.0 / Math.PI) + "";
            txtStepNoise.Text = step_noise + "";
            particles_initialize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            particles_initialize();
        }

        void animate()
        {
            while (!stop)
            {
                step_forward();
                Thread.Sleep(50);
            }
            panel1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stop = false;
            new Thread(animate).Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stop = true;
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            step_forward();
           
        }

        private double get_weight(Particle p)
        {
            if (rbEqual.Checked)
            {
                // equal weights for all
                return 1.0;
            }

            if (rbRandom.Checked)
            {
                return rand.NextDouble();
            }
            if (rbRight.Checked)
            {
                return (1.0 / (1.0 - p.X));
            }

            if (rbTop.Checked)
                return (1 / p.Y);

            // diagonal
                return ( 1.0 / Math.Abs(p.X - p.Y));
        
        }

        private void step_forward()
        {
            ArrayList particles = new ArrayList();

            // Move
            for (int i = 0; i < numParticles; i++)
            {
                Particle p = (Particle)panel1.particles[i];
                double nr = step_size + gauss(0, step_noise);
                double ntheta = theta + gauss(0, theta_noise);
                double new_x = p.X + nr * Math.Cos(ntheta);
                new_x = new_x > 1.0 ? new_x - 1.0 : new_x;

                double new_y = p.Y + nr * Math.Sin(ntheta);
                new_y = new_y > 1.0 ? new_y - 1.0 : new_y;
                particles.Add(new Particle { X = new_x, Y = new_y });
            }
   
            // Assign Weights
            double [] weights  = new double[numParticles];
            for (int i  =0; i < numParticles; i++) {
                Particle p = (Particle) particles[i];
                weights[i] = get_weight(p);
            }
            double noramlizer = 0.0;
            for (int i = 0; i < numParticles; i++)
            {
                noramlizer += weights[i];
            }

            for (int i = 0; i < numParticles; i++)
            {
                weights[i] = weights[i] / noramlizer;
            }

           
            // resample
            ArrayList p2 = new ArrayList();
            double maxw = weights[0];
            for (int i = 1; i < numParticles; i++) {
                if (weights[i] > maxw)
                    maxw = weights[i];
            }

            int index = rand.Next(numParticles);
            double betta = 0;
            for (int i = 0; i < numParticles; i++)
            {
                betta += rand.NextDouble() * 2.0 * maxw; 
                while (betta > weights[index])
                {
                    betta -= weights[index];
                    index = (index + 1) % numParticles;
                }
                p2.Add(particles[index]);
            }
             particles = p2;
           

            panel1.particles = particles;
            panel1.Invalidate();
        }
        private double gauss(double mean, double stdDev)
        {
            double u1 = rand.NextDouble(); //these are uniform(0,1) random doubles
            double u2 = rand.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                         Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
            double randNormal =
                         mean + Math.Sqrt(stdDev)* randStdNormal; //random normal(mean,stdDev^2)
            return randNormal;
        }

        private void particles_initialize()
        {
            ArrayList particles = new ArrayList();
            Random rnd = new Random();
            for (int i = 0; i < numParticles; i++)
            {

                double x = 0.5;
                double y = 0.5;
                particles.Add(new Particle { X = x, Y = y });

            }
            // MessageBox.Show(particles.Count + " ");
            panel1.particles = particles;
            panel1.Invalidate();
        }

        private void re_initialize()
        {
            try{
             int numParticles = Int32.Parse(txtNumParticles.Text);
             double stepSize = double.Parse(txtStepSize.Text);
             double stepNoise = double.Parse(txtStepNoise.Text);
             double theta = double.Parse(txtOrientation.Text) * Math.PI / 180.0;
             double theta_noise = double.Parse(txtOrientationNoise.Text) * Math.PI / 180.0;

             this.numParticles = numParticles;
             this.step_size = stepSize;
             this.theta = theta;
             this.step_noise = stepNoise;
             this.theta_noise = theta_noise;
             particles_initialize();
              

            }catch( Exception ex) {
                MessageBox.Show("Error in data : " + ex.Message);
            }
        }

       

        private void text_configuration_updated(object sender, EventArgs e)
        {
            stop = true;
            
            re_initialize();
        }

    }
}

