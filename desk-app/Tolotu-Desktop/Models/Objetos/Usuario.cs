using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tolotu_Desktop.Models.Servicios;

namespace Tolotu_Desktop.Models.Objetos {

  // Estado: Activo
  // Creado por Miguel Bogota - 08.12.2019
  // Clase es un objeto que representa un usuario.
  public class Usuario {

    public int Documento { get; set; } // Numero de identidad del usuario
    public string TipoDocuemnto { get; set; } // Tipo de documento
    public string NombreUsuario { get; set; } // Nombre de usuario del usuario
    public string PrimerNombre { get; set; } // Primer nombre del usuario
    public string SegundoNombre { get; set; } // Segundo nombre del usuario
    public string PrimerApellido { get; set; } // Primer apellido del usuario
    public string SegundoApellido { get; set; } // Segundo apellido del usuario
    public string Correo { get; set; } // Correo electronico del usuario
    public string Telefono { get; set; } // Telefono del usuario
    public string Genero { get; set; } // Genero del usuario
    public DateTime Nacimiento { get; set; } // Fecha de nacimiento del usuario
    public int Edad { get; set; } // Edad del usuario
    public string Estado { get; set; } // Estado del usuario
    public string Contrasenia { get; set; } // Contraseña del usuario
    public string Rol { get; set; } // Rol del usuario
    public string Imagen { get; set; } // Link de la imagen del usuario
    public List<Actividad> Actividades { get; set; } // Lista de actividades del usuario
  

    // Constructor
    public Usuario(int documento, string tipoDocuemnto, string nombreUsuario, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string correo, string telefono, string genero, DateTime nacimiento, int edad, string estado, string contrasenia, string rol, string imagen) {
      Documento = documento;
      TipoDocuemnto = tipoDocuemnto;
      NombreUsuario = nombreUsuario;
      PrimerNombre = primerNombre;
      SegundoNombre = segundoNombre;
      PrimerApellido = primerApellido;
      SegundoApellido = segundoApellido;
      Correo = correo;
      Telefono = telefono;
      Genero = genero;
      Nacimiento = nacimiento;
      Edad = edad;
      Estado = estado;
      Contrasenia = contrasenia;
      Rol = rol;
      Imagen = imagen;
      Actividades = new ActividadServicio().getActividadesByusuario(Documento);
    }

        public void arr(Boolean a)
        {
            Actividades.Clear();
            if (a){
                Actividades = new ActividadServicio().getActividadesByusuario(Documento);
                
            }
            else {

                Actividades = new ActividadServicio().getActividades();
            }
        }

  }

}
