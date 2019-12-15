using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tolotu_Desktop.Views;
using System.Drawing.Imaging;
using System.IO;
using Tolotu_Desktop.Models.Servicios;
using Tolotu_Desktop.Models.Objetos;

namespace Tolotu_Desktop.Controllers {

  // Estado: Activo
  // Creado por Juan Miguel Castro rojas - 23.11.2019
  // control de registro
  public class RegistroController {

    private String URL { get; set; } // Propiedad de la URL de la imagen de perfil

    // Constructor
    public RegistroController() {

    }

    // Estado: Activo
    // Creado por Juan Castro - 21.11.2019
    // Metodo que muestra el resultado de la validacion de usuario
    public bool ValidarUsuario(TextBox text, Button btn, Panel panel) {
      // Validar si el usuario ya existe o esta en blanco
      bool val = (new UsuarioServicio().UsuarioExiste(text.Text) || text.Text.Equals(""));
      if (val) {
        MessageBox.Show("El nombre de usuario '" + text.Text + "' ya esta registrado, Ingrese otro por favor.", "Tolotu - Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        return true;
      }
      else {
        MessageBox.Show("El nombre de usuario '" + text.Text + "' es valido para su uso", "Tolotu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        // Esconder menu de validacion
        text.Enabled = false;
        btn.Enabled = false;
        panel.Enabled = true;
        return false;
      }
    }

    // Estado: Activo
    // Creado por Juan Castro - 23.11.2019
    // Cambiado por Miguel Bogota - 15.12.2019
    // Metodo que valida que ningun campo falte por llenar y redirige a la base de datos
    public bool ValidacionCampos(String usu, String pass, String confPass, String Pnombres, String Snombres, String Papellidos, String Sapellidos, String correo, String genero, DateTime fecha, String tel, String Doc, String TDoc, PictureBox img) {
      // Validacion de campos en blanco
      if (usu == "" || pass == "" || confPass == "" || Pnombres == "" || Papellidos == "" || correo == "" || genero == "" || tel == "" || Doc == "" || TDoc == "") {
        MessageBox.Show("Ha dejado algun campo sin llenar. Por favor verifique que que no haya dejado un campo vacio", "Tolotu - Falta informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
      }
      // Validacion de contraseña sean iguales
      else if (!pass.Equals(confPass)) {
        MessageBox.Show("No son iguales las contraseñas insertadas en los campos, por favor vuelva a intentarlo", "Tolotu - Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        return false;
      }
      // Validar documento sea numero
      else if (!convertInt(Doc)) {
        MessageBox.Show("Ingrese un documento valido", "Tolotu - Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        return false;
      }
      // Se valida si la conversion de edad es valida
      if (IdentificarEdad(fecha) > 0) {
        // Guardar imagen con nombre de usuario
        imagen(img, usu);
        if (new UsuarioServicio().DocumentoExiste(Doc)) {
          MessageBox.Show("Numero de documento ya se encuentra en la base datos", "Tolotu - Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
          return false;
        }
        // Guardar informacion en instancia de usuario
        Usuario usuarioRegistro = new Usuario(
          Convert.ToInt32(Doc), // Documento
          TDoc, // Tipo documento
          usu, // Usuario
          Pnombres, // Primero nombre
          Snombres, // Segundo nombre
          Papellidos, // Primer apellido
          Sapellidos, // Segundo apellido
          correo, // Correo electronico
          tel, // Telefono
          genero, // Genero
          fecha, // Fecha de nacimiento
          IdentificarEdad(fecha), // Edad
          "Activo", // Estado
          pass, // Constraseña
          "Usuario", // Rol
          URL // URL Imagen
        );
        // Agragr usuario a la base de datos
        new UsuarioServicio().Agregar(usuarioRegistro);
        MessageBox.Show("Se ha registrado exitosamente!", "Tolotu - Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      return true;
    }

    // Estado: Activo
    // Creado por Juan Castro - 4.12.2019
    // Guarda la imagen en los archivos locales de la aplicacion
    public void imagen(PictureBox img, String usu) {
      //direccion exacta de donde se uubica la imagen dentro de la carpeta del proyecto
      String FileName = Path.Combine(@"..\..\imagenes\");
      this.URL = @"" + FileName + "Img-" + usu + ".Jpeg";
      img.Image.Save(URL, ImageFormat.Jpeg);
    }


    // Estado: Activo
    // Creado por Juan Castro - 26.11.2019
    // Metodo para identificar la edad a base de la fecha de nacimiento
    public int IdentificarEdad(DateTime fecha) {
      int edad = System.DateTime.Now.Year - fecha.Year;
      if (System.DateTime.Now.Subtract(fecha.AddYears(edad)).TotalDays > 0) { return edad; }
      else {
        MessageBox.Show("la fecha de nacimiento que ha introducido es invaldia", "Tolotu - Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        return 0;
      }
    }

    // Estado: Activo
    // Creado por Juan Castro - 23.11.2019
    // Metodo para validar si el numero de documento es valido
    public bool convertInt(String Docum) {
      int document = 0;
      return Int32.TryParse(Docum, out document);
    }
  }
}


