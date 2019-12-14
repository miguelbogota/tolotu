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
  // vista para registro de usuarios nuevos
  public partial class Registro : Form {

    private RegistroController RegistroController = new RegistroController();

    public Registro() {
      InitializeComponent();
    }

    private void btnValidar_CLick(object sender, EventArgs e) {
      // Validar si usuario existe para esconder el menu de validacion
      bool val = RegistroController.ValidarUsuario(txtusuario, btnValidar, panelInfoBasica);
    }

    private void btnSiguiente_Click(object sender, EventArgs e) {
      // Activa el siguiente panel
      panel2.Enabled = true;
      panel2.Visible = true;
      panelInfoBasica.Visible = false;
    }

    private void importImg_Click(object sender, EventArgs e) {
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

    private void btnCancelar_Click(object sender, EventArgs e) {
      new FuncionesController().CambiarVentana(this, new Login());
    }

    private void ventanaRegistro_Load(object sender, EventArgs e) {
      panelInfoBasica.Enabled = false;
      panel2.Enabled = false;
      panel2.Visible = false;
      panelInfoBasica.Visible = true;
      //carga la imagen de usuario predefinida
      String FileName = Path.Combine(@"..\..\imagenes\default.PNG");
      imagen.Image = System.Drawing.Image.FromFile(FileName);
      imagen.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void button2_Click_1(object sender, EventArgs e) {
      new FuncionesController().CambiarVentana(this, new Login());
    }

    private void button1_Click_1(object sender, EventArgs e) {
      String date = dateTimePicker1.Value.ToString("dd/MM/yyyy");
      if (RegistroController.tomaDatos(txtusuario.Text, txtPass.Text, txtConfPass.Text, txtPNombres.Text, txtSNombres.Text, txtPApellidos.Text, txtSApellidos.Text, txtCorreos.Text, combGen.SelectedItem.ToString(), dateTimePicker1.Value, txtTel.Text, txtNDoc.Text, combTD.SelectedItem.ToString(), imagen)) {
        new FuncionesController().CambiarVentana(this, new Login());
      }

    }

    private void btnAtras_Click(object sender, EventArgs e) {
      panel2.Visible = false;
      panelInfoBasica.Visible = true;
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 14.12.2019
    // Finalizar Registro cuando se cierra la ventana
    protected override void OnFormClosing(FormClosingEventArgs e) {
      base.OnFormClosing(e);
      Application.Exit();
    }

  }
}
