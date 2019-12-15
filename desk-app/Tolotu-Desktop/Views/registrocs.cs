using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tolotu_Desktop.Controllers;

namespace Tolotu_Desktop.Views {

  // Estado: Activo
  // Creado por Juan Castro - 22.11.2019
  // Vista para registro de usuarios nuevos
  public partial class Registro : Form {

    private RegistroController registroController { get; set; } // Controlador del Registro

    // Constructor
    public Registro() {
      registroController = new RegistroController();
      InitializeComponent();
    }

    // Estado: Activo
    // Creado por Juan Castro - 22.11.2019
    // Funcion valida si hay algun usuario igual
    private void Validar_CLick(object sender, EventArgs e) {
      // Validar si usuario existe para esconder el menu de validacion
      registroController.ValidarUsuario(txtusuario, btnValidar, panelInfoBasica);
    }

    // Estado: Activo
    // Creado por Juan Castro - 22.11.2019
    // Funcion activa el siguiente panel para continuar con el registro
    private void Siguiente_Click(object sender, EventArgs e) {
      // Activa el siguiente panel
      panel2.Enabled = true;
      panel2.Visible = true;
      panelInfoBasica.Visible = false;
    }

    // Estado: Activo
    // Creado por Juan Castro - 22.11.2019
    // Funcion importa la imagen seleccionada
    private void ImportImg_Click(object sender, EventArgs e) {
      try {
        this.openFileDialog1.ShowDialog();
        if (this.openFileDialog1.FileName.Equals("") == false) {
          imagen.Load(this.openFileDialog1.FileName);
        }
      }
      catch (Exception ex) {
        MessageBox.Show("No se ha podido cargar la imagen, por favor asegurese de seleccionar un archivo .PNG o .JPG" + ex);
      }
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 15.12.2019
    // Funcion cancela el registro y vuelve al login
    private void Cancelar_Click(object sender, EventArgs e) {
      new FuncionesController().CambiarVentana(this, new Login());
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 15.12.2019
    // Funcion carga la informacion de login al ser llamado
    private void Registro_Load(object sender, EventArgs e) {
      panelInfoBasica.Enabled = false;
      panel2.Enabled = false;
      panel2.Visible = false;
      panelInfoBasica.Visible = true;
      // Carga la imagen de usuario predefinida
      String FileName = Path.Combine(@"..\..\imagenes\default.PNG");
      imagen.Image = System.Drawing.Image.FromFile(FileName);
      imagen.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    // Estado: Cambiado
    // Creado por Juan Castro - 22.11.2019
    // Cambiado por Miguel Bogota - 15.12.2019
    // Funcion para el evento del boton de submit y registrar datos
    private void Login_Submit(object sender, EventArgs e) {
      // Guardar validacion en variable
      bool check = registroController.ValidacionCampos(
        txtusuario.Text, // Usuario
        txtPass.Text, // Contraseña
        txtConfPass.Text, // Confirmacion de contraseña
        txtPNombres.Text, // Primer Nombre
        txtSNombres.Text, // Segundo nombre
        txtPApellidos.Text, // Primer apellido
        txtSApellidos.Text, // Segundo apellido
        txtCorreos.Text, // Correo electronico
        combGen.SelectedItem.ToString(), // Genero
        dateTimePicker1.Value, // Fecha de nacimiento
        txtTel.Text, // Telefono
        txtNDoc.Text, // Numero de documento
        combTD.SelectedItem.ToString(), // Tipo de documento
        imagen // URL imagen del perfil
      );
      // Validar si los campos estan completos
      if (check) {
        new FuncionesController().CambiarVentana(this, new Login()); // Cambiar al login
      }

    }

    // Estado: Activo
    // Creado por Juan Castro - 22.11.2019
    // Funcion delvuelve atras en el proceso de registro
    private void Atras_Click(object sender, EventArgs e) {
      panel2.Visible = false;
      panelInfoBasica.Visible = true;
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 14.12.2019
    // Finalizar Registro cuando se cierra la ventana
    protected override void OnFormClosing(FormClosingEventArgs e) {
      base.OnFormClosing(e);
      new FuncionesController().Finalizar();
    }

  }
}
