using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Tolotu_Web {

  // Estado: Activo
  // Creado por Miguel Bogota - 15.11.2019
  // Programa.
  public class Program {

    // Main
    public static void Main(string[] args) {
      CreateHostBuilder(args).Build().Run();
    }

    // Configurar y crear web
    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => {
              webBuilder.UseStartup<Startup>();
            });
  }
}
