using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tolotu_Desktop.Control {


  class ContLogin {

    private String vistaUsuario, vistaContraseña, modeloUsuario, modeloContraseña;


    public void entradaDatos(String usuario, String contraseña) {
      this.vistaUsuario = usuario;
      this.vistaContraseña = contraseña;
      validar();
    }


    public void validar() {

    }

  }
}
