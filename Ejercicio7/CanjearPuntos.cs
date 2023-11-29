
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7
{
    public partial class CanjearPuntos : Form
    {
        Cuenta cuenta = new Cuenta();
        int pesosPuntos = 0;
        public CanjearPuntos(Cuenta cuenta,int pesosPuntos)
        {
            this.cuenta= cuenta;
            this.pesosPuntos = pesosPuntos;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(textBox1.Text);

            if (cuenta.puedeRedimir(cantidad))
            {
                
                Double result =cuenta.redimirPuntos(cantidad,pesosPuntos);
                System.Windows.Forms.MessageBox.Show("PUNTOS CAJEADOS: " + cantidad + " por $" + result.ToString());
                textBox1.Clear();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("-/ OPERACIÓN NO VÁLIDA (PUNTOS INSUFICIENTE) /-");
                textBox1.Clear();
            }
        }
    }
}
