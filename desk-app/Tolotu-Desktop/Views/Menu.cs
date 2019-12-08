using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tolotu_Desktop.Models.Objetos;

namespace Tolotu_Desktop.Vista {


  public partial class Menu : Form {

    public int margin;
    public int size;
    public int distance;
    public int i;

    // Constructor
    public Menu() {
      InitializeComponent();

      this.margin = 30;
      this.size = 200;
      this.distance = 40;
      this.i = 0;
    }


    private void button1_Click(object sender, EventArgs e) {

      // Si el panel esta a la vista ocultarlo
      if (panel.Visible) {
        panel.Visible = false; // Ocultar panel
        MeneOption.Location = new System.Drawing.Point(5, 25); // Mover botón
        MeneOption.Text = ">"; // Cambiar flechita
        // Mover contenedor
        container.Location = new System.Drawing.Point(31, 0);
        container.Size = new System.Drawing.Size(1037, 635);
      }
      // Si esta escondido mostrarlo
      else {
        panel.Visible = true; // Mostrar panel
        MeneOption.Location = new System.Drawing.Point(273, 20); // Mover botón
        MeneOption.Text = "<"; // Cambiar flechita
        // Mover contenedor
        container.Location = new System.Drawing.Point(297, 0);
        container.Size = new System.Drawing.Size(771, 635);
      }


    }

    private void button1_Click_1(object sender, EventArgs e) {

      List<Actividad> actividades = new List<Actividad>();
      actividades.Add(new Actividad("Evento " + this.i));

      List<Panel> paneles = new List<Panel>();
      List<Button> botones = new List<Button>();
      List<Label> labels = new List<Label>();
      this.container.SuspendLayout();

      for (int es = 0; es < actividades.Count; es++) {
        paneles.Add(new Panel());
        botones.Add(new Button());
        labels.Add(new Label());

        paneles.ElementAt(es).SuspendLayout();

        labels.ElementAt(es).AutoSize = true;
        labels.ElementAt(es).Location = new System.Drawing.Point(28, 25);
        labels.ElementAt(es).Name = "label" + this.i;
        labels.ElementAt(es).Size = new System.Drawing.Size(35, 13);
        labels.ElementAt(es).TabIndex = 0;
        labels.ElementAt(es).Text = actividades.ElementAt(es).nombre;

        botones.ElementAt(es).Location = new System.Drawing.Point(124, 108);
        botones.ElementAt(es).Name = "button" + this.i;
        botones.ElementAt(es).Size = new System.Drawing.Size(75, 23);
        botones.ElementAt(es).TabIndex = 1;
        botones.ElementAt(es).Text = "button" + this.i;
        botones.ElementAt(es).UseVisualStyleBackColor = true;

        paneles.ElementAt(es).BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        paneles.ElementAt(es).Controls.Add(botones.ElementAt(es));
        paneles.ElementAt(es).Controls.Add(labels.ElementAt(es));
        paneles.ElementAt(es).Location = new System.Drawing.Point(40, distance);
        paneles.ElementAt(es).Name = "panel" + this.i;
        paneles.ElementAt(es).Size = new System.Drawing.Size(430, size);
        paneles.ElementAt(es).TabIndex = 0;

        this.container.Controls.Add(paneles.ElementAt(es));


        paneles.ElementAt(es).ResumeLayout(false);
        paneles.ElementAt(es).PerformLayout();

        distance = distance + margin + size;
      }
      this.container.AutoScrollMinSize = new System.Drawing.Size(600, distance);
      this.container.ResumeLayout(false);
      this.container.AutoScroll = true;
      this.i = this.i + 1;
    }

        // Estado: Activo
        // Creado por Juan Castro - 8.12.2019
        // boton para cerrar sesion y volver a login
        private void btnCerrarSesion_Click(object sender, EventArgs e){
            Login log = new Login();
            this.Hide();
            log.Show();
        }
    }
}
