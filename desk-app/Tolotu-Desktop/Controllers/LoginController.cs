using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tolotu_Desktop.Controllers {

  // Estado: Activo
  // Creado por Juan Miguel Castro rojas - 20.11.2019
  // control de login
  class LoginController {
    modelo.modLogin modLog = new modelo.modLogin();

    private String vistaUsuario, vistaContraseña;
    private int cont = 0;


    public Boolean entradaDatos(String usuario, String contraseña) {

      // se declaran variables locales para guardar los valores prevenientes de la vista
      this.vistaUsuario = usuario;
      this.vistaContraseña = contraseña;

      //se valida el el metodo del consulta para el login
      if (modLog.validacion(usuario, contraseña) == true) {
        return true;
      }
      else {
        //contador para ingresos errorneos
        cont++;
        MessageBox.Show("Ha introducido erroneamente usuario o contraseña, por favor vuelva a intentar", "error - numero de intentos" + cont, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //en caso de 3 intentos erroneos lanza mensaje y cierra aplicacion
        if (cont == 3) {
          MessageBox.Show("Ha intentado ingresar erronamente en 3 ocaciones. Por cuestiones de seguridad se cerrará la aplicacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
          Environment.Exit(0);
        }
        return false;
      }
    }

  }
}
