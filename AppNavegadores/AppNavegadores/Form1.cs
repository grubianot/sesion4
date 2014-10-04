using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNavegadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String texto = " ";
            if (checkBox1.Checked == true)
            {
                texto = texto + "MOZILLA" + " ";
            }
            if (checkBox2.Checked == true)
            {
                texto=texto+"GOOGLE CHROME"+" ";
            }
            if (checkBox3.Checked == true)
            {
                texto=texto+"INTERNET EXPLORER"+" ";
            }
            label1.Text = texto.ToString();
        }
    }
}
