using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whacka_mole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Mole m1 = new Mole(100, 200, Color.Red);
            Mole m2 = new Mole(300, 400, Color.Green);

            Console.WriteLine(m1);
            Console.WriteLine(m2);

            m1.DrawMole(paper);
            m2.DrawMole(paper);
        }
    }
}
