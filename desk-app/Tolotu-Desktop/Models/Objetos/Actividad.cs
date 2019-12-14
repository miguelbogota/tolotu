﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tolotu_Desktop.Models.Objetos {

  // Estado: Activo
  // Creado por Miguel Bogota - 06.12.2019
  // Clase es un objeto que representa una actividad.
  public class Actividad {

    public string Nombre { get; set; } // Nombre de la actividad
    public string Localizacion { get; set; } // Localizacion de la actividad
    public string Clasificacion { get; set; } // Clasificacion de la actividad
    public string Imagen { get; set; } // URL imagen de la actividad

    // Constructor
    public Actividad(string nombre, string localizacion, string clasificacion, string imagen) {
      Nombre = nombre;
      Localizacion = localizacion;
      Clasificacion = clasificacion;
      Imagen = imagen;
    }

    public Actividad(string nombre) {
      Nombre = nombre;
    }

  }
}
