using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tolotu_Web.Models.Objetos;
using Tolotu_Web.Models.Servicios;

namespace Tolotu_Web.Controllers {

  // Estado: Activo
  // Creado por Miguel Bogota - 15.11.2019
  // Controlador de toda las paginas de la carpeta Inicio
  public class InicioController : Controller {

    // Estado: Activo
    // Creado por Miguel Bogota - 16.11.2019
    // Redirige a la pagina principal.
    public IActionResult Index() {
      // Si hay una sesion activa enviar a inicio
      if(HttpContext.User.Claims.FirstOrDefault(c => c.Type == "NombreUsuario") != null) { return RedirectToAction("/Inicio"); }
      return View();
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 16.11.2019
    // Redirige a la pagina de privacidad.
    public IActionResult Privacidad() {
      // Si hay una sesion activa no eviar informacion
      if (HttpContext.User.Claims.FirstOrDefault(c => c.Type == "NombreUsuario") == null) { return View(); }
      // Guardar Usuario desde la sesion y buscar informacion en la base de datos
      Usuario UsuarioLogin = new UsuarioServicio().IniciarSesion(
        HttpContext.User.Claims.First(c => c.Type == "NombreUsuario").Value,
        HttpContext.User.Claims.First(c => c.Type == "Contrasenia").Value
      );
      return View(UsuarioLogin);
    }

  }
}
