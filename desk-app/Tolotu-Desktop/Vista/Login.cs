using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tolotu_Desktop.Control;

namespace Tolotu_Desktop {

  // Estado: Activo
  // Creado por Juan Castro - 13.11.2019
  // Crea la vista del login
  public partial class ventanaLogin : Form {

        Control.ContLogin contLog = new Control.ContLogin();
        vista.ventanaRegistro reg = new vista.ventanaRegistro();

        // Constructor
        public ventanaLogin() {
          InitializeComponent();
        }

        // Estado: Activo
        // Creado por Juan Castro - 13.11.2019
        // Evento para crear un placeholder
        private void txtUsuario_MouseClick(object sender, MouseEventArgs e) {
          // Evento para visualizar mensages predeterminados cuando el usuario no ha introducido un valor
          // en el campo de texto
          if (txtUsuario.Text == "Ingresa tu usuario") {
            txtUsuario.Text = "";
          }
          if (txtContraseña.Text == "") {
            txtContraseña.Text = "Ingresa tu contraseña";
          }
        }
        // Estado: Activo
        // Creado por Juan Castro - 13.11.2019
        // Evento para crear un placeholder
        private void txtContraseña_MouseClick(object sender, MouseEventArgs e) {
          // Evento para visualizar mensages predeterminados cuando el usuario no ha introducido un valor
          // en el campo de texto
          if (txtContraseña.Text == "Ingresa tu contraseña") {
            txtContraseña.Text = "";
          }
          if (txtUsuario.Text == "") {
            txtUsuario.Text = "Ingresa tu usuario";
          }
        }
 
        // Estado: Activo
        // Creado por Juan Miguel Castro rojas - 13.11.2019
        // Evento al dar click en el botón de entrar
        private void btnEntrar_Click(object sender, EventArgs e) {

          contLog.entradaDatos(txtUsuario.Text, txtContraseña.Text);
        }

        // Estado: Activo
        // Creado por Juan Miguel Castro rojas - 22.11.2019
        // boton para volver al login
        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            reg.Show();
            this.Hide();
        }
    }
}
