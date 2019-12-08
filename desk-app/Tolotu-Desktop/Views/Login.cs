﻿using System;
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
  public partial class Login : Form {

    Control.LoginController contLog = new Control.LoginController();
    vista.Registro reg = new vista.Registro();

    // Constructor
    public Login() {
      InitializeComponent();
    }

        // Estado: DESACTIVO
        // Creado por Juan Castro - 13.11.2019
        // Evento para crear un placeholder
        private void txtUsuario_MouseClick(object sender, MouseEventArgs e) {
      //// Evento para visualizar mensages predeterminados cuando el usuario no ha introducido un valor
      //// en el campo de texto
      //if (txtUsuario.Text == "Ingresa tu usuario") {
      //  txtUsuario.Text = "";
      //}
      //if (txtContraseña.Text == "") {
      //  txtContraseña.Text = "Ingresa tu contraseña";
      //}
    }
    // Estado: DESACTIVO
    // Creado por Juan Castro - 13.11.2019
    // Evento para crear un placeholder
    private void txtContraseña_MouseClick(object sender, MouseEventArgs e) {
    //  // Evento para visualizar mensages predeterminados cuando el usuario no ha introducido un valor
    //  // en el campo de texto
    //  if (txtContraseña.Text == "Ingresa tu contraseña") {
    //    txtContraseña.Text = "";
    //  }
    //  if (txtUsuario.Text == "") {
    //    txtUsuario.Text = "Ingresa tu usuario";
    //  }
    }
        //SE 

    // Estado: Activo
    // Creado por Juan Miguel Castro rojas - 13.11.2019
    // Evento al dar click en el botón de entrar
    private void btnEntrar_Click(object sender, EventArgs e) {

      if (contLog.entradaDatos(txtUsuario.Text, txtContraseña.Text)) {
        MessageBox.Show("Bienvenido", "Tolotu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        new Vista.Menu().Show();
        this.Hide();
      }
    }

    // Estado: Activo
    // Creado por Juan Miguel Castro rojas - 22.11.2019
    // boton para volver al login
    private void btnCrearCuenta_Click(object sender, EventArgs e) {
      reg.Show();
      this.Hide();
    }
        // Estado: ACTIVO
        // Creado por Juan Castro - 8.12.2019
        // Evento para focus
        private void txtUsuario_Enter(object sender, EventArgs e) {
            // Evento para limpiar el campo de texto al momento de hacer focus
                txtUsuario.Text = ""; 
        }
        // Estado: ACTIVO
        // Creado por Juan Castro - 8.12.2019
        //  Evento para focus
        private void txtContraseña_Enter(object sender, EventArgs e){
            // Evento para limpiar el campo de texto al momento de hacer focus
            txtContraseña.Text = "";
        }
        // Estado: ACTIVO
        // Creado por Juan Castro - 8.12.2019
        //  Evento para lost_focus
        private void txtUsuario_Leave(object sender, EventArgs e){
            //evento para volver a imprimir la frase predeterminada para el campo de texto en caso de que no se haya insertado nada
            if (txtUsuario.Text == "") {
                txtUsuario.Text = "Ingresa tu contraseña";
            }
        }
        // Estado: ACTIVO
        // Creado por Juan Castro - 8.12.2019
        //  Evento para lost_focus
        private void txtContraseña_Leave(object sender, EventArgs e){
            //evento para volver a imprimir la frase predeterminada para el campo de texto en caso de que no se haya insertado nada
            if (txtContraseña.Text == "") {
                txtContraseña.Text = "Ingresa tu contraseña";
            }
        }
    }
}
