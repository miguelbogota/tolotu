using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tolotu_Web.Models;

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

    // Propiedad para guardar los datos del usuario en el registro.
    [BindProperty]
    public Usuario UsuarioRegistro { get; set; }

    // Estado: Activo
    // Creado por Miguel Bogota - 24.11.2019
    // Función para manejar el envio de datos cuando se de clic en registrarme.
    public async Task<IActionResult> OnSubmitRegistro([Bind("usuario, email, nombre, contrasena")] Usuario UsuarioRegistro) {

      System.Diagnostics.Debug.WriteLine(UsuarioRegistro.ToString());

      return Redirect("/Index");
    }

  }
}