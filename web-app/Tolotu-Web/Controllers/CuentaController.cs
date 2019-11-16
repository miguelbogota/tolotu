using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tolotu_Web.Controllers {

  public class CuentaController : Controller {
    public IActionResult Login() {
      return View();
    }
  }
}