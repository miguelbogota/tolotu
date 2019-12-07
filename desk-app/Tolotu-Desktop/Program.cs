using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tolotu_Desktop.Models.Servicios;
using Tolotu_Desktop.Vista;
using Menu = Tolotu_Desktop.Vista.Menu;

namespace Tolotu_Desktop {


  public static class Program {


    /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// </summary>
    [STAThread]
    static void Main() {

      Console.WriteLine(new ServicioDB().ProcedimientoReturn("Consulta", "@Res", System.Data.SqlDbType.Int, "@documento, Registro Civil"));

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Login());
    }
  }
}
