
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7
{
    static class Program
    {
        /// <summary>
        ///Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Habilita estilos visuales de la aplicación
            Application.EnableVisualStyles();

            // Establece la compatibilidad predeterminada para el rendimiento de texto

            Application.SetCompatibleTextRenderingDefault(false);
            // Inicia la aplicación y abre el formulario de autenticación como punto de entrada
            Application.Run(new Autenticacion());
        }
    }
}
