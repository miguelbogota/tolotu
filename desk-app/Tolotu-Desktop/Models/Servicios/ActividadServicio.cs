using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tolotu_Desktop.Models.Objetos;

namespace Tolotu_Desktop.Models.Servicios {

  // Estado: Activo
  // Creado por Miguel Bogota - 11.12.2019
  // Clase de funciones de la base de datos del objeto actividad.
  class ActividadServicio {

    private DBServicio DB { get; set; } // Base de datos

    // Constructor
    public ActividadServicio() {
      this.DB = new DBServicio(); // Iniciar la base de datos
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 11.12.2019
    // Funcion para traer la informacion en una lista de las actividades de un usuario
    public List<Actividad> getActividadesByusuario(int documento) {
      List<Actividad> actividades = new List<Actividad>(); // Instanciar lista de actividades
      // Consulta a la base de datos para traer las actividades de un usuario
      SqlDataReader reader = this.DB.Consulta("SELECT eve.* FROM [participantes] par JOIN [evento] eve ON par.[eventoID] = eve.[eventoId] WHERE [usuarioID] = " + documento.ToString() + ";");
      // If para validar si la consulta tiene filas
      if (reader.HasRows) {
        // While para agregar cada una de las actividades a la lista
        while (reader.Read()) {
          // Agregar a la lista
          actividades.Add(new Actividad(reader.GetInt32(0),reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
        }
      }
      reader.Close(); // Cerrar conexion a la base de datos
      return actividades;
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 11.12.2019
    // Funcion para traer la informacion en una lista de las actividades de la base de datos
    public List<Actividad> getActividades() {
      List<Actividad> actividades = new List<Actividad>(); // Instanciar lista de actividades
      // Consulta a la base de datos para traer todas las actividades
      SqlDataReader reader = this.DB.Consulta("SELECT * FROM evento");
      // If para validar si la consulta tiene filas
      if (reader.HasRows) {
        // While para agregar cada una de las actividades a la lista
        while (reader.Read()) {
          // Agregar a la lista
          actividades.Add(new Actividad(reader.GetInt32(0),reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
        }
      }
      reader.Close(); // Cerrar conexion a la base de datos
      return actividades;
    }
        DBServicio serv = new DBServicio();
        public int participantes(int id){
            int reader = this.DB.ConsultaScalar("select count(eventoID) from participantes where eventoID=" + id + "");
            return reader;
        }

    }

}
