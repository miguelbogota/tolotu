using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
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
      // Si hay una sesion activa enviar a inicio
      if (HttpContext.User.Claims.FirstOrDefault(c => c.Type == "NombreUsuario") != null) { return RedirectToAction("/Inicio"); }
      return View();
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 24.11.2019
    // Redirige al registro.
    public IActionResult Registro() {
      // Si hay una sesion activa enviar a inicio
      if (HttpContext.User.Claims.FirstOrDefault(c => c.Type == "NombreUsuario") != null) { return RedirectToAction("/Inicio"); }
      return View();
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 24.11.2019
    // Hace autenticacion
    public IActionResult Auth([Bind("NombreUsuario, Contrasenia")] Usuario login) {
      // Si no hay usuario no se ha logueado
      if (login.NombreUsuario == null) { return RedirectToAction("/Login"); }
      // Busca en la base de datos con usuario y contraseña, si no encuentra devuelve null
      Usuario UsuarioLogin = new UsuarioServicio().IniciarSesion(login.NombreUsuario, login.Contrasenia);
      // Devolver al login si es incorrecto
      if (UsuarioLogin == null) { return RedirectToAction("/Login"); }

      var user = new List<Claim>() {
        new Claim("NombreUsuario", UsuarioLogin.NombreUsuario),
        new Claim("Contrasenia", UsuarioLogin.Contrasenia)
      };
      var userIte = new ClaimsIdentity(user, "Identi");
      var userPrincipal = new ClaimsPrincipal(new[] { userIte });
      HttpContext.SignInAsync(userPrincipal);

      return RedirectToAction("Inicio");
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 24.11.2019
    // Redirige a la pagina de inicio si se esta logueado
    [Authorize]
    public IActionResult Inicio() {
      // Guardar Usuario desde la sesion y buscar informacion en la base de datos
      Usuario UsuarioLogin = new UsuarioServicio().IniciarSesion(
        HttpContext.User.Claims.First(c => c.Type == "NombreUsuario").Value,
        HttpContext.User.Claims.First(c => c.Type == "Contrasenia").Value
      );
      // Devuelve la informacion a la vase de datosa
      return View(UsuarioLogin);
    }

    public IActionResult Logout() {
      HttpContext.SignOutAsync();
      return RedirectToAction("/");
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