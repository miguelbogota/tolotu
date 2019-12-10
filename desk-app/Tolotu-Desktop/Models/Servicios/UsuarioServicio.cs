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

    private const string nombreTabla = ""; // Nombre de la tabla de la base de datos
    private const string query = ""; // Query para traer la informacion de la base de datos

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
    public Boolean UsuarioExiste(Usuario usuario) {
      Boolean check = false; // Variable para validar si existe record en la base de datos del documento del usuario
      // Hacer validacion de la base de datos
      if (this.DB.ProcedimientoReturn("HayUsuario", "@documento, " + usuario.Documento + ", int", "out, @result, int, 5")[0].Equals("1")) {
        check = true; // Cambiar estado ya que se encontro
      }
      return check;
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 09.12.2019
    // Funcion para iniciar sesion a un usuario, si returna el usuario inicio sesion corectamente, de lo contrario no
    public Usuario IniciarSesion(Usuario usuario) {
      Usuario usuarioTemp = null; // Usuario a devolver
      // Hacer validacion de la base de datos
      if (this.DB.ProcedimientoReturn("HayUsuario", "@documento, " + usuario.Documento + ", int", "out, @result, int, 5")[0].Equals("1")) {
        // En trabajo
      }
      return usuarioTemp;
    }

  }
}
