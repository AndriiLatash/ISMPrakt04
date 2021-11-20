using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for1 form = new for1();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            For2 form = new For2();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for4 form = new for4();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for5 form = new for5();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            while1 form = new while1();
            form.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            while2 form = new while2();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            while3 form = new while3();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for3 form = new for3();
            form.ShowDialog();
        }
    }
}
