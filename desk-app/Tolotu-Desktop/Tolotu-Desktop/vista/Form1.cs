using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tolotu_Desktop.controlador;

namespace Tolotu_Desktop
{
    // Estado: Activo
    // Creado por Juan Miguel Castro rojas - 13.11.2019
    // Version 0.1
    
    public partial class Form1 : Form
    {
        controlador.contLogin contLog = new controlador.contLogin();
        public Form1()
        {
            InitializeComponent();
        }

        // Creado por Juan Miguel Castro rojas - 13.11.2019
        // Version 0.1
        private void txtUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            //evento para visualizar mensages predeterminados cuando el usuario no ha introducido un valor
            //en el campo de texto
            if (txtUsuario.Text == "Ingresa tu usuario")
            {
                txtUsuario.Text = "";
            }
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Ingresa tu contraseña";
            }
        }
        // Creado por Juan Miguel Castro rojas - 13.11.2019
        // Version 0.1
        private void txtContraseña_MouseClick(object sender, MouseEventArgs e)
        {
            //evento para visualizar mensages predeterminados cuando el usuario no ha introducido un valor
            //en el campo de texto
            if (txtContraseña.Text == "Ingresa tu contraseña")
            {
                txtContraseña.Text = "";
            }
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingresa tu usuario";
            }
        }
        // Creado por Juan Miguel Castro rojas - 13.11.2019
        // Version 0.1
        private void btnEntrar_Click(object sender, EventArgs e)
        {

            contLog.entradaDatos(txtUsuario.Text, txtContraseña.Text);
        }
    }
}
