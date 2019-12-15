using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tolotu_Desktop.Controllers;
using Tolotu_Desktop.Models.Objetos;

namespace Tolotu_Desktop.Views {

  // Estado: Activo
  // Creado por Juan Castro - 13.11.2019
  // Crea la vista del login
  public partial class Login : Form {

    private LoginController loginController = new LoginController(); // Controlador del Login

    // Constructor
    public Login() {
      InitializeComponent();
    }

    // Estado: Activo
    // Creado por Juan Castro - 13.11.2019
    // Evento al dar click en el botón de entrar
    private void btnEntrar_Click(object sender, EventArgs e) {
      // Valida si se trae algun usuario, si lo trae se logue correctamente
      Usuario user = loginController.LoginDatos(txtUsuario.Text, txtContraseña.Text);
      if (user != null) {
        MessageBox.Show("Bienvenido", "Tolotu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        new FuncionesController().CambiarVentana(this, new Inicio());
      }
    }

    // Estado: Activo
    // Creado por Juan Castro - 22.11.2019
    // Boton para ir al registro
    private void btnCrearCuenta_Click(object sender, EventArgs e) {
      new FuncionesController().CambiarVentana(this, new Registro());
    }

    // Estado: Activo
    // Creado por Juan Castro - 8.12.2019
    // Evento para focus
    private void txtUsuario_Enter(object sender, EventArgs e) {
      // Evento para limpiar el campo de texto al momento de hacer focus
      txtUsuario.Text = "";
    }

    // Estado: Activo
    // Creado por Juan Castro - 8.12.2019
    // Evento para focus
    private void txtContraseña_Enter(object sender, EventArgs e) {
      // Evento para limpiar el campo de texto al momento de hacer focus
      txtContraseña.Text = "";
    }

    // Estado: Activo
    // Creado por Juan Castro - 8.12.2019
    // Evento para lost_focus
    private void txtUsuario_Leave(object sender, EventArgs e) {
      //evento para volver a imprimir la frase predeterminada para el campo de texto en caso de que no se haya insertado nada
      if (txtUsuario.Text == "") { txtUsuario.Text = "Ingresa tu contraseña"; }
    }
    // Estado: Activo
    // Creado por Juan Castro - 8.12.2019
    // Evento para lost_focus
    private void txtContraseña_Leave(object sender, EventArgs e) {
      //evento para volver a imprimir la frase predeterminada para el campo de texto en caso de que no se haya insertado nada
      if (txtContraseña.Text == "") { txtContraseña.Text = "Ingresa tu contraseña"; }
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 14.12.2019
    // Finalizar Login cuando se cierra la ventana
    protected override void OnFormClosing(FormClosingEventArgs e) {
      base.OnFormClosing(e);
      new FuncionesController().Finalizar();
    }

    // Estado: Inactivo
    // Creado por Juan Castro - 13.11.2019
    // Evento para crear un placeholder
    //private void txtUsuario_MouseClick(object sender, MouseEventArgs e) {
    //  // Evento para visualizar mensages predeterminados cuando el usuario no ha introducido un valor en el campo de texto
    //  if (txtUsuario.Text == "Ingresa tu usuario") { txtUsuario.Text = ""; }
    //  if (txtContraseña.Text == "") { txtContraseña.Text = "Ingresa tu contraseña"; }
    //}

    // Estado: Inactivo
    // Creado por Juan Castro - 13.11.2019
    // Evento para crear un placeholder
    //private void txtContraseña_MouseClick(object sender, MouseEventArgs e) {
    //  // Evento para visualizar mensages predeterminados cuando el usuario no ha introducido un valor en el campo de texto
    //  if (txtContraseña.Text == "Ingresa tu contraseña") { txtContraseña.Text = ""; }
    //  if (txtUsuario.Text == "") { txtUsuario.Text = "Ingresa tu usuario"; }
    //}

  }
}
