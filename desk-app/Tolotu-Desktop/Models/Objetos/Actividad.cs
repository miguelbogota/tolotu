using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tolotu_Desktop.Models.Objetos {

  // Estado: Activo
  // Creado por Miguel Bogota - 06.12.2019
  // Clase es un objeto que representa una actividad.
  public class Actividad {

    public string nombre { get; set; } // Nombre de la actividad
    public string descripcion { get; set; } // Descripcion de la actividad

    // Constructor
    public Actividad(string nombre) {
      this.nombre = nombre;
    }

  }
}
