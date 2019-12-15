using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tolotu_Web.Models.Servicios;

namespace Tolotu_Web.Models.Objetos {

  // Estado: Activo
  // Creado por Miguel Bogota - 13.12.2019
  // Clase es un objeto que representa un usuario.
  public class Usuario {

    [BindProperty]
    public int Documento { get; set; } // Numero de identidad del usuario
    [BindProperty]
    public string TipoDocuemnto { get; set; } // Tipo de documento
    [BindProperty]
    public string NombreUsuario { get; set; } // Nombre de usuario del usuario
    [BindProperty]
    public string PrimerNombre { get; set; } // Primer nombre del usuario
    [BindProperty]
    public string SegundoNombre { get; set; } // Segundo nombre del usuario
    [BindProperty]
    public string PrimerApellido { get; set; } // Primer apellido del usuario
    [BindProperty]
    public string SegundoApellido { get; set; } // Segundo apellido del usuario
    [BindProperty]
    public string Correo { get; set; } // Correo electronico del usuario
    [BindProperty]
    public string Telefono { get; set; } // Telefono del usuario
    [BindProperty]
    public string Genero { get; set; } // Genero del usuario
    [BindProperty]
    public DateTime Nacimiento { get; set; } // Fecha de nacimiento del usuario
    [BindProperty]
    public int Edad { get; set; } // Edad del usuario
    [BindProperty]
    public string Estado { get; set; } // Estado del usuario
    [BindProperty]
    public string Contrasenia { get; set; } // Contraseña del usuario
    [BindProperty]
    public string Rol { get; set; } // Rol del usuario
    [BindProperty]
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

    public Usuario() {

    }

  }

}
