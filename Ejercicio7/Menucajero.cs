
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//** Autor:Ráúl Fernando Medina Sandoval
//** Fecha: 28/11/2023

namespace Ejercicio7
{
    public partial class Menucajero : Form
    // Propiedades de la clase Menucajero
    {
        Cuenta cuenta = new Cuenta();
        Banco banco = null;

        // Constructor de la clase Menucajero
        public Menucajero(Banco banco)
        {
            // Inicialización de la cuenta del cajero y del banco
            cuenta = banco.cuentaLogeada();
            this.banco = banco;
            InitializeComponent();
            // Actualización del texto del groupBox1 con información l Naco, cuenta y  titular
            this.groupBox1.Text = banco.name + " Número de cuenta " + cuenta.cuenta + "\nTitular " + cuenta.usuario + "\nMovimientos ";
        }


        // Evento para el clic en el botón de cerrar la aplicación
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
                                               

        }

        // Evento donde se realiza la accion de retiro de dinero
        private void button4_Click(object sender, EventArgs e)
        {
            if (valorretiro == null || "".Equals(valorretiro.Text))
            {
                System.Windows.Forms.MessageBox.Show("Debe registar el valor del retiro");
                return;
            }
            if (!Util.validarNumeroPositivo(valorretiro.Text))
            {
                System.Windows.Forms.MessageBox.Show("Debe registar un numero valido para el retiro");
                return;
            }
            double cantidad = double.Parse(valorretiro.Text);
            // Verifica el tope de retiros diarios
          
            if (banco.validarTope(cantidad))
            {
                System.Windows.Forms.MessageBox.Show("El movimiento supera el tope de retiros de: $" + banco.topeRetiro + "  diarios: ");
            }
            else
            {
                // Realiza el retiro si es válido
                if (cuenta.retiro(cantidad))
                {
                    listBox1.Items.Add("El monto Retirado fue: " + " $" + cantidad);
                    valorretiro.Clear();
                }
                else
                {
                    listBox1.Items.Add("-/ Operación no valida Saldo Insuficiente /-");
                    valorretiro.Clear();
                }
            }
        }

        //Evento para Generar el estado de Cuenta
        private void button5_Click(object sender, EventArgs e)
        {
            // Muestra un cuadro de mensaje con el saldo actual de la cuenta y la fecha actual
            System.Windows.Forms.MessageBox.Show("El Saldo de la cuenta Número " + cuenta.cuenta + " es: $ "+ cuenta.saldo.ToString() + "\n" + "\n" + DateTime.Now.ToString());

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
        // Eventos para el clic en el botón de consulta de puntos acumulado
        private void button3_Click_1(object sender, EventArgs e)
        {
            // Muestra un cuadro de mensaje con la cantidad de puntos acumulados
            System.Windows.Forms.MessageBox.Show(" El saldo de puntos Acumulados es : " + cuenta.puntos.ToString() + "\n" + "\n" + DateTime.Now.ToString());

        }
        // Abre el formulario CanjearPuntos para realizar el proceso redimir  de puntos
        private void button6_Click_1(object sender, EventArgs e)
        {
            CanjearPuntos Form = new CanjearPuntos(cuenta,banco.pesosPuntos);
            Form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // Evento para el clic en el botón de realizar transferencia
        private void button7_Click(object sender, EventArgs e)
        {
            if (!Util.validarNumeroPositivo(Valortransferencia.Text))
            {
                System.Windows.Forms.MessageBox.Show("Debe registar un numero valido para la transferencia");
                return;
            }

            if (Valortransferencia ==null || "".Equals (Valortransferencia.Text)) 
            {
                System.Windows.Forms.MessageBox.Show("Debe registar el valor de la transferencia");
                return;
            }

            if (CuentaTrasferencia == null || "".Equals(CuentaTrasferencia.Text))
            {
                System.Windows.Forms.MessageBox.Show("Debe registar el numero mde cuenta destino de la transferencia");
                return;
            }
            string cuentra = CuentaTrasferencia.Text;
            double cantidad = double.Parse(Valortransferencia.Text);
            Cuenta cuentadest = banco.obtenerCuenta(cuentra);

            if (!cuentra.Equals (cuentadest.cuenta))
            // Verifica la existencia de la cuenta destino
            {
                System.Windows.Forms.MessageBox.Show("Operación no valida Cuenta Destino de la Transferencia no Existe o no es del mismo Banco ");
                CuentaTrasferencia.Clear();
            }
            else
            {
                // Realiza la transferencia si es válida
                if (banco.transferencia(cuenta.cuenta, cuentra, cantidad))
                {
                    listBox1.Items.Add("Se realizo trasnferencia a la cuenta: " + cuentra + "\n" + " por valor de : " + " $" + cantidad);
                    Valortransferencia.Clear();
                    CuentaTrasferencia.Clear();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("--/ Operación no valida Saldo Insuficiente /--");
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
