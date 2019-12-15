using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tolotu_Desktop.Controllers;
using Tolotu_Desktop.Models.Objetos;

namespace Tolotu_Desktop.Views {

  // Estado: Activo
  // Creado por Miguel Bogota - 08.12.2019
  // Vista del inicio
  public partial class Inicio : Form {

    public InicioController inicioController { get; set; } // Controlador del inicio

    public int margin;
    public int size;
    public int distance;
    public int i;

    // Constructor
    public Inicio(Usuario usuario) {
      inicioController = new InicioController(usuario);
      InitializeComponent();

      this.margin = 30;
      this.size = 200;
      this.distance = 40;
      this.i = 0;
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 08.12.2019
    // Funcion para esconder o mostrar el panel
    private void PanelToogle_Click(object sender, EventArgs e) {
      // Funcion para esconder o mostrar el panel lateral
      inicioController.TooglePanel(panel, MeneOption, container);
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 15.12.2019
    // Funcion cargar la informacion cuando se inicie el inicio
    public void Inicio_Load(object sender, EventArgs e) {
      inicioController.LoadActividades(container);
    }

    // Estado: Activo
    // Creado por Juan Castro - 8.12.2019
    // Boton para cerrar sesion y volver a login
    private void CerrarSesion_Click(object sender, EventArgs e) {
      new FuncionesController().CambiarVentana(this, new Login());
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 14.12.2019
    // Finalizar Menu cuando se cierra la ventana
    protected override void OnFormClosing(FormClosingEventArgs e) {
      base.OnFormClosing(e);
      new FuncionesController().Finalizar();
    }

  }
}
