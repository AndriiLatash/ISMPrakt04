using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp1
{
    public partial class for1 : Form
    {
        public for1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = int.Parse(textBoxA.Text);
            int B = int.Parse(textBoxB.Text);
            double res = Class1.SolveTask(A, B);
            textBoxS.Text = res.ToString();
        }
    }
}
