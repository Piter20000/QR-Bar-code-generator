using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generate_Button_Click(object sender, EventArgs e)
        {
            Classes.QR_And_Bar_Code_Generator Instance = new Classes.QR_And_Bar_Code_Generator();

            pictureBox1.Image = Instance.Generate_Bar_Code("Piotr Murdzia, test Barcode generator");

            pictureBox2.Image = Instance.Generate_QR_Code("Piotr Murdzia, test QR code generator");
        }
    }
}
