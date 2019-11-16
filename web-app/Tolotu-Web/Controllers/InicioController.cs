using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Tolotu_Web.Controllers {

  public class InicioController : Controller {
    private readonly ILogger<InicioController> _logger;

    public InicioController(ILogger<InicioController> logger) {
      _logger = logger;
    }

    public IActionResult Index() {
      return View();
    }

    public IActionResult Privacidad() {
      return View();
    }

  }
}
