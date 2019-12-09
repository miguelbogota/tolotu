using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tolotu_Desktop.Models.Objetos {

  // Estado: Activo
  // Creado por Miguel Bogota - 08.12.2019
  // Clase es un objeto que representa un usuario.
  public class Usuario {

    public int Identidad { get; set; } // Numero de identidad del usuario
    public string nombre { get; set; } // Nombre del usuario
    public string usuario { get; set; } // Nombre de usuario del usuario
    public string email { get; set; } // Correo electronico del usuario
    public string clave { get; set; } // Contraseña del usuario


  }

}
