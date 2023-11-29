
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Creado por German David Rojas Gonzalez

namespace Ejercicio7
{
    public partial class Menucajero : Form
    {
        Cuenta cuenta = new Cuenta();
        Banco banco = null;
        
        public Menucajero(Banco banco)
        {
            cuenta = banco.cuentaLogeada();
            this.banco = banco;
            InitializeComponent();
        }

        //BOTON REGISTRAR
        /*private void button1_Click(object sender, EventArgs e)
        {
            Form3 Form = new Form3(banco);
            Form.ShowDialog();
        }*/
        // BOTON PARA CERRAR
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
                                               

        }

        // BOTON DONDE SE REGISTRA LA INFORMACIÓN DEL RETIRO
        private void button4_Click(object sender, EventArgs e)
        {
            double cantidad = double.Parse(textBox5.Text);
            if (cuenta.retiro(cantidad))
            {
                listBox1.Items.Add("MONTO RETIRADO: " + " $" + cantidad);
                textBox5.Clear();
            }
            else
            {
                listBox1.Items.Add("-/ OPERACIÓN NO VÁLIDA (SALDO INSUFICIENTE) /-");
                textBox5.Clear();
            }
        }

        //BOTON PARA GENERAR EL ESTADO DE LA CUENTA
        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("SALDO DE LA CUENTA: " + cuenta.saldo.ToString() + "\n" + "\n" + DateTime.Now.ToString());

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

                    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("PUNTOS ACUMULADOS: " + cuenta.puntos.ToString() + "\n" + "\n" + DateTime.Now.ToString());

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            CanjearPuntos Form = new CanjearPuntos(cuenta,banco.pesosPuntos);
            Form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string cuentra = CuentaTrasferencia.Text;
            double cantidad = double.Parse(Valortransferencia.Text);
            Cuenta cuentadest = banco.obtenerCuenta(cuentra);
            if (!cuentadest.cuenta.Equals(cuentra))
            {
                System.Windows.Forms.MessageBox.Show("--/ OPERACIÓN NO VÁLIDA (CUENTA NO EXISTE) /--");
                CuentaTrasferencia.Clear();
            }
            else
            {

                if (banco.transferencia(cuenta.cuenta, cuentra, cantidad))
                {
                    listBox1.Items.Add("LA CUENTA A LA QUE HIZO LA TRANSFERENCIA ES: " + cuentra + "\n" + " MONTO TRANSFERIDO: " + " $" + cantidad);
                    Valortransferencia.Clear();
                    CuentaTrasferencia.Clear();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("--/ OPERACIÓN NO VÁLIDA (SALDO INSUFICIENTE) /--");
                    Valortransferencia.Clear();
                    CuentaTrasferencia.Clear();
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void CuentaTrasferencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
