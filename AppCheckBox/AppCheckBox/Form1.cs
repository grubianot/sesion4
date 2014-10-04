using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            string texto=" ";

            if (chkingles.Checked == true)
            {
                texto = texto + "Ingles"+" ";
            }
            if (chkfrances.Checked == true)
            {
                texto = texto + "Frances" + " ";
            }
            if (chkaleman.Checked == true)
            {
                texto = texto + "Aleman" + " ";
            }
            Text = texto;
        }
    }
}
