using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//** Autor:Ráúl Fernando Medina Sandoval
//** Fecha: 28/11/2023
//*  Descripcion Formulario Autenticacion 
namespace Ejercicio7
{
    public partial class Autenticacion : Form
    // Creación de instancias de la clase Banco
    {
        Banco banco = new Banco(1, "Money Bank", 2000000, 7);
        //Banco banco1 = new Banco(2, "Financo", 3000000, 7);
       
        
        // Constructor de la clase Autenticacion
        public Autenticacion()
        {
            // Inicialización del banco con cuentas predefinidas
            inicializarBanco();
            InitializeComponent();
        }
        // Método para inicializar el banco con cuentas predefinidas
        private void inicializarBanco()
        {
            // Creación de instancias de la clase Cuenta y su incorporación al banco
            Cuenta cuenta1 = new Cuenta(20000000,1000,"Raul Medina","1234","987654321");
            Cuenta cuenta2 = new Cuenta(10000000, 500, "Angela Pedraza", "4321", "123456789");
            Cuenta cuenta3 = new Cuenta(8000000, 350, "Gabriela Medina", "4038", "852963741");
            Cuenta cuenta4 = new Cuenta(12000000, 1200, "Jacobo Medina", "1452", "741085296");
           
            
            // Agregar cuentas al banco
            banco.agregarCuenta(cuenta1);
            banco.agregarCuenta(cuenta2);
            banco.agregarCuenta(cuenta3);
            banco.agregarCuenta(cuenta4);
        }
        //  Eventos para el clic en el botón de autenticación
        private void button1_Click(object sender, EventArgs e)
        {
          // Verificar la autenticación utilizando el método autenticar del banco
            if (banco.autenticar(numerocuenta.Text, Clave.Text))
            {
                // Limpiar campos de entrada
                numerocuenta.Clear();
                Clave.Clear();

                // Crear una instancia del formulario de menú del cajero y mostrarlo
                Menucajero Form = new Menucajero(banco);
                Form.ShowDialog();

            }else
            {
                // Mostrar mensaje de autenticación no válida y limpiar campos
                MessageBox.Show("Autenticacion no valida");
                numerocuenta.Clear();
                Clave.Clear();
                numerocuenta.Focus();
                return;
            }
        }
        //  Eventos para el clic en el botón de salida de la aplicación
        private void button2_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
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
