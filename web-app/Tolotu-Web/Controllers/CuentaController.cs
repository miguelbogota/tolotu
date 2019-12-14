using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tolotu_Web.Models.Objetos;
using Tolotu_Web.Models.Servicios;

namespace Tolotu_Web.Controllers {

  // Estado: Activo
  // Creado por Miguel Bogota - 24.11.2019
  // Controlador de toda las paginas de la carpeta Cuenta
  public class CuentaController : Controller {

    // Estado: Activo
    // Creado por Miguel Bogota - 24.11.2019
    // Redirige al login.
    public IActionResult Login() {
      return View();
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 24.11.2019
    // Redirige al registro.
    public IActionResult Registro() {
      return View();
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 24.11.2019
    // Redirige a la pagina de inicio si se esta logueado
    public IActionResult Inicio([Bind("NombreUsuario, Contrasenia")] Usuario login) {
      // Busca en la base de datos con usuario y contraseña, si no encuentra devuelve null
      Usuario UsuarioLogin = new UsuarioServicio().IniciarSesion(login.NombreUsuario, login.Contrasenia);
      // Valida si hay usuario, si no lo hay devuelve al login
      if (UsuarioLogin == null) { return RedirectToAction("Login"); }
      // Si encuentra devuelve a inicio con el usuario
      return View(UsuarioLogin);
    }

    // Estado: Inactivo - Se cambió por la funcion de Login
    // Creado por Miguel Bogota - 24.11.2019
    // Función para manejar el envio de datos cuando se de clic en registrarme.
    //public async Task<IActionResult> OnSubmitRegistro([Bind("usuario, email, nombre, contrasena")] Usuario UsuarioRegistro) {
    //  return Redirect("/Login");
    //}

    // Estado: Inactivo - Se cambió por la funcion de Inicio
    // Creado por Miguel Bogota - 13.12.2019
    // Función para iniciar sesion
    //public async Task<IActionResult> OnSubmitLogin([Bind("NombreUsuario, Contrasenia")] Usuario UsuarioLogin) {
    //  // Guardar la informacion si el logue es exitoso de lo contrario devolvera null
    //  Usuario userLogin = new UsuarioServicio().IniciarSesion(UsuarioLogin.NombreUsuario, UsuarioLogin.Contrasenia);
    //  UsuarioLogin = userLogin; // Guardar en propiedad publica
    //  // Validar si se logue correctamente
    //  if (UsuarioLogin != null) {
    //    return Redirect("/Inicio");
    //  }
    //  else {
    //    return Redirect("/Login");
    //  }
    //}

  }
}