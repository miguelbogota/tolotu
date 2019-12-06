using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tolotu_Web.Models {

  // Estado: Activo
  // Creado por Miguel Bogota - 23.11.2019
  // Objeto que trae a un usuario
  public class Usuario {

    public string usuario { get; set; } // Propiedad para el usuario
    public string email { get; set; } // Propiedad para el correo electronico
    public string nombre { get; set; } // Propiedad para el nombre
    public string contrasena { get; set; } // Propiedad para la contraseña

    // Constructor
    public Usuario() {

    }
    public Boolean validar()
    {

            return true;
    }

    // Mostrar información de forma organizada
    public override string ToString() {
      return "{ usuario: " + usuario + ", email: " + email + ", nombre: " + nombre + ", contrasena: " + contrasena + " }";
    }

  }
}
