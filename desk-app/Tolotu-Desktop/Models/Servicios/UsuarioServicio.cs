using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tolotu_Desktop.Models.Objetos;

namespace Tolotu_Desktop.Models.Servicios {

  // Estado: Activo
  // Creado por Miguel Bogota - 09.12.2019
  // Clase de funciones de la base de datos del objeton usuario.
  public class UsuarioServicio {

    private DBServicio DB { get; set; } // Base de datos
    private List<Usuario> Usuarios { get; set; } // Lista de usuarios de la base de datos

    // Constructor
    public UsuarioServicio() {
      this.DB = new DBServicio(); // Iniciar la base de datos
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 09.12.2019
    // Funcion agrega un usuario en la base de datos
    public void Agregar(Usuario usuario) {
      // Agregar usaurio a la base de datos
      this.DB.ProcedimientoNoReturn(
        "AgregarUsuario", // Nombre de procedimiento almacenado
        "@Numero_Documento, " + usuario.Documento + ", int", // Numero de documento
        // Convertir tipo de documento a int para la base de datos
        "@tipo_documento, " + this.DB.ProcedimientoReturn("HayTipoDocumento", "@nombre_documento, " + usuario.TipoDocuemnto + ", varchar", "out, @result, int, 5")[0] + ", tinyint", // Tipo de documento
        "@usuario, " + usuario.NombreUsuario + ", varchar", // Nombre de usuario
        "@primer_nombre, " + usuario.PrimerNombre + ", varchar", // Primer nombre
        "@segundo_nombre, " + usuario.SegundoNombre + ", varchar", // Segundo nombre
        "@primer_apellido, " + usuario.PrimerApellido + ", varchar", // Primer apellido
        "@segundo_apellido, " + usuario.SegundoApellido + ", varchar", // Segundo apellido
        "@correo, " + usuario.Correo + ", varchar", // Correo electronico
        "@tel, " + usuario.Telefono + ", varchar", // Telefono
        // Convertir genero a int para la base de datos
        "@genero, " + this.DB.ProcedimientoReturn("HayGenero", "@nombre_genero, " + usuario.Genero + ", varchar", "out, @result, int, 5")[0] + ", tinyint", // Genero
        "@fecha_nacimiento, " + usuario.Nacimiento.ToString("yyyy-MM-dd HH:mm:ss") + ", datetime", // Fecha de nacimiento
        "@edad, " + usuario.Edad + ", tinyint",
        // Convertir estado a int para la base de datos
        "@estado, " + this.DB.ProcedimientoReturn("HayEstado", "@nombre_estado, " + usuario.Estado + ", varchar", "out, @result, int, 5")[0] + ", tinyint", // Estado
        "@contrasenia, " + usuario.Contrasenia + ", varchar", // Contraseña
        // Convertir rol a int para la base de datos
        "@rol, " + this.DB.ProcedimientoReturn("HayRol", "@nombre_rol, " + usuario.Rol + ", varchar", "out, @result, int, 5")[0] + ", tinyint", // Rol
        "@imagen, " + usuario.Imagen + ", varchar" // URL de la imagen
      );
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 09.12.2019
    // Funcion valida si un usuario esta en la base de datos
    public bool UsuarioExiste(string usuario) {
      bool check = false; // Variable para validar si existe record en la base de datos del documento del usuario
      // Hacer validacion de la base de datos
      if (this.DB.ProcedimientoReturn("HayUsuario", "@usuario, " + usuario + ", varchar", "out, @result, tinyint, 5")[0].Equals("1")) {
        check = true; // Cambiar estado ya que se encontro
      }
      return check;
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 15.12.2019
    // Funcion valida si un usuario esta en la base de datos
    public bool DocumentoExiste(string documento) {
      bool check = false; // Variable para validar si existe record en la base de datos del documento del usuario
      // Hacer validacion de la base de datos
      if (this.DB.ProcedimientoReturn("HayDocumento", "@documento, " + documento + ", varchar", "out, @result, tinyint, 5")[0].Equals("1")) {
        check = true; // Cambiar estado ya que se encontro
      }
      return check;
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 09.12.2019
    // Funcion para iniciar sesion a un usuario, si returna el usuario inicio sesion corectamente, de lo contrario no
    public Usuario IniciarSesion(string usuario, string contrasenia) {
      Usuario usuarioTemp = null; // Usuario a devolver
      // Buscar en la base de datos informacion y guardarla
      string[] usuarioArray = this.DB.ProcedimientoReturn(
        "IniciarSesion", // Nombre procedimiento almacenado
        "@usuario, " + usuario + ", varchar", // Usuario a validar
        "@contrasenia, " + contrasenia + ", varchar", // Contraseña a validar
        // Outputs
        "out, @result, int, 5", // Validacion si usuario y contraseña correcta
        "out, @Numero_Documento, int, 50", // Numero de documento
        "out, @tipo_documento, varchar, 50", // Tipo de documento
        "out, @primer_nombre, varchar, 50", // Primer nombre
        "out, @segundo_nombre, varchar, 50", // Segundo nombre
        "out, @primer_apellido, varchar, 50", // Primer apellido
        "out, @segundo_apellido, varchar, 50", // Segundo apellido
        "out, @correo, varchar, 50", // Correo electronico
        "out, @tel, varchar, 50", // Telefono
        "out, @genero, varchar, 50", // Genero
        "out, @fecha_nacimiento, datetime, 50", // Fecha de nacimiento
        "out, @edad, tinyint, 0", // Edad
        "out, @estado, varchar, 50", // Estado
        "out, @rol, varchar, 50", // Rol
        "out, @imagen, varchar, 50" // URL imagen de perfil
      );
      // Hacer validacion de la base de datos, si el primer output devuelve 1 el usuario y contraseña es correcto
      if (usuarioArray[0].Equals("1")) {
        // Guardar datos de la base de datos en usuario
        usuarioTemp = new Usuario(
          Convert.ToInt32(usuarioArray[1]), // Documento
          usuarioArray[2], // Tipo documento
          usuario, // Usuario
          usuarioArray[3], // Primero nombre
          usuarioArray[4], // Segundo nombre
          usuarioArray[5], // Primer apellido
          usuarioArray[6], // Segundo apellido
          usuarioArray[7], // Correo electronico
          usuarioArray[8], // Telefono
          usuarioArray[9], // Genero
          Convert.ToDateTime(usuarioArray[10]), // Fecha de nacimiento
          Convert.ToInt32(usuarioArray[11]), // Edad
          usuarioArray[12], // Estado
          contrasenia, // Constraseña
          usuarioArray[13], // Rol
          usuarioArray[14] // URL Imagen
        );
      }
      return usuarioTemp;
    }

  }
}
