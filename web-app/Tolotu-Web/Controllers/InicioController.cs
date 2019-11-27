using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Tolotu_Web.Controllers {

  // Estado: Activo
  // Creado por Miguel Bogota - 15.11.2019
  // Controlador de toda las paginas de la carpeta Inicio
  public class InicioController : Controller {

    // Estado: Activo
    // Creado por Miguel Bogota - 16.11.2019
    // Redirige a la pagina principal.
    public IActionResult Index() {
      return View();
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 16.11.2019
    // Redirige a la pagina de privacidad.
    public IActionResult Privacidad() {
      return View();
    }

  }
}
