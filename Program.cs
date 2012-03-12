/*
    Particle Filter Demo and Visualization tool
    Created while studying the CS373 course at UdaCity (www.udacity.com)
    Author: Moustafa Alzantot (m.alzantot@gmail.com)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FastSLAM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
