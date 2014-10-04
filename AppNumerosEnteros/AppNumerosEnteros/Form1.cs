using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNumerosEnteros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int numero1, numero2, sumar;
            numero1 = int.Parse(txtnumero1.Text);
            numero2 = int.Parse(txtnumero2.Text); 

            
            sumar=numero1+numero2;
            lblresultado.Text="Resualtado:"+sumar.ToString();
        }
    }
}
