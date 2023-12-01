
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//** Autor:Ráúl Fernando Medina Sandoval
//** Fecha: 28/11/2023
namespace Ejercicio7
{
    public partial class CanjearPuntos : Form
    // Propiedades de la clase CanjearPuntos
    {
        Cuenta cuenta = new Cuenta();  // Representa la cuenta asociada al canjeo de puntos
        int pesosPuntos = 0;       // Valor en pesos asociado a cada punto

        // Constructor de la clase CanjearPuntos
        public CanjearPuntos(Cuenta cuenta,int pesosPuntos)
        {
            // Inicialización de la cuenta y el valor en pesos por punto
            this.cuenta= cuenta;   
            this.pesosPuntos = pesosPuntos;
            InitializeComponent();
        }
        // Eventos para el clic en el botón de redimir  puntos
        private void button1_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(numpuntos.Text);
            // Verifica si la cuenta tiene suficientes puntos para redimir
            if (cuenta.puedeRedimir(cantidad))
            {
                // Realiza el canjeo de puntos y muestra un mensaje con la cantidad redimida  
                Double result =cuenta.redimirPuntos(cantidad,pesosPuntos);
                System.Windows.Forms.MessageBox.Show("La cantidad de puntos Redimidos fue de: " + cantidad + " por  un valor de $" + result.ToString());
                numpuntos.Clear();
            }
            else
            { // Muestra un mensaje si el saldo de puntos es insuficiente
                System.Windows.Forms.MessageBox.Show("-/ Operación no valida Saldo de Puntos Insuficiente /-");
                numpuntos.Clear();
            }
        }

        private void CanjearPuntos_Load(object sender, EventArgs e)
        {

        }
    }
}
