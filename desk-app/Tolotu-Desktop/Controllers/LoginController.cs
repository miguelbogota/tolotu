using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tolotu_Desktop.Models.Objetos;
using Tolotu_Desktop.Models.Servicios;

namespace Tolotu_Desktop.Controllers {

  // Estado: Activo
  // Creado por Juan Castro - 20.11.2019
  // Controlador del Login
  public class LoginController {

    public int Contador { get; set; } // Contador de veces que se intenta loguear fallidamente

    // Constructor
    public LoginController() {
      Contador = 0;
    }

    // Estado: Cambiado
    // Creado por Juan Castro - 20.11.2019
    // Cambiado por Miguel Bogota - 15.12.2019
    // Funcion toma la informacion del login y valida si es correcta y devuelve la informacion del usuario
    public Usuario LoginDatos(String usuario, String contrasenia) {
      // Se declaran variables locales para guardar los valores prevenientes de la vista y se validan en la base de datos
      Usuario usuarioLogin = new UsuarioServicio().IniciarSesion(usuario, contrasenia);
      // Se valida si la consulta trajo algun valor
      if (usuarioLogin != null) { return usuarioLogin; }
      // De lo contrario sumar a contador
      else {
        //contador para ingresos errorneos
        Contador++;
        MessageBox.Show("Ha introducido erroneamente usuario o contraseña, por favor vuelva a intentar", "error - numero de intentos" + Contador, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //en caso de 3 intentos erroneos lanza mensaje y cierra aplicacion
        if (Contador == 3) {
          MessageBox.Show("Ha intentado ingresar erronamente en 3 ocaciones. Por cuestiones de seguridad se cerrará la aplicacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
          new FuncionesController().Finalizar();
        }
        return null;
      }
    }

  }
}
