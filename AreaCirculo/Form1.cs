using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaCirculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtValor.Text);
            double area = 0;

            area = Math.PI * Math.Pow(numero1, 2);

            lblArea.Text = Convert.ToString(area);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValor.Text = String.Empty;
            lblArea.Text = "0";
            txtValor.Focus(); 
        }
    }
}
