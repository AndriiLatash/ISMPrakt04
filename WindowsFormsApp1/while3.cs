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
    public partial class while3 : Form
    {
        public while3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = int.Parse(textBoxA.Text);
            double res = Class1.while3(p);
            double dob = Class1.while4(p);
            textBoxS.Text = res.ToString();
            textBoxB.Text = dob.ToString();
        }
    }
}
