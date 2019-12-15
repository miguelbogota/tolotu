using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tolotu_Desktop.Controllers {


  public class FuncionesController {

    // Construcotr
    public FuncionesController() { }

    // Funcion para cambiar de ventana
    public void CambiarVentana(Form current, Form next) {
      current.Hide();
      next.Closed += (s, args) => current.Close();
      next.Show();
    }

    // Funcion para finalizar programa
    public void Finalizar() {
      Application.Exit();
    }

  }

}
