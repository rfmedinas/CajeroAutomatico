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
    public partial class Autenticacion : Form

    {
        Banco banco = new Banco(1, "Banco Financo ", 2000000, 7);
        Banco banco1 = new Banco(2, "Money Bank", 3000000, 7);
        public Autenticacion()
        {
            inicializarBanco();
            InitializeComponent();
        }
        private void inicializarBanco()
        {
            Cuenta cuenta1 = new Cuenta(20000000,1000,"Raul Medina","1234","987654321");
            Cuenta cuenta2 = new Cuenta(10000000, 500, "Angela Pedraza", "4321", "123456789");
            Cuenta cuenta3 = new Cuenta(8000000, 350, "Gabriela Medina", "4038", "852963741");
            Cuenta cuenta4 = new Cuenta(12000000, 1200, "Jacobo Medina", "1452", "741085296");
            banco.agregarCuenta(cuenta1);
            banco.agregarCuenta(cuenta2);
            banco.agregarCuenta(cuenta3);
            banco.agregarCuenta(cuenta4);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if(banco.autenticar(numerocuenta.Text, Clave.Text))
            {
                numerocuenta.Clear();
                Clave.Clear();
                Menucajero Form = new Menucajero(banco);
                Form.ShowDialog();
            }else
            {
                MessageBox.Show("Autenticacion no valida");
                numerocuenta.Clear();
                Clave.Clear();
                numerocuenta.Focus();
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
