using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tolotu_Desktop.Models.Servicios;
using Tolotu_Desktop.Views;

namespace Tolotu_Desktop {

  public static class Program {

    /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// </summary>
    [STAThread]
    static void Main() {

      //new UsuarioServicio().Agregar(new Models.Objetos.Usuario(12321356, "Pasaporte", "Migue", "Miguel", "Angel", "Bogota", "Rico", "miguel@gmail.com", "3197029889", "Hombre", new DateTime(1996, 11, 09), 23, "Activo", "1234", "Admin", "../imagenes"));

      //Console.WriteLine(new UsuarioServicio().IniciarSesion("Migu", "1234"));

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Login());
    }
  }
}
