﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tolotu_Desktop.Models.Objetos;
using Tolotu_Desktop.Models.Servicios;

namespace Tolotu_Desktop.Controllers {

  // Estado: Activo
  // Creado por Miguel Bogota - 15.12.2019
  // Controlador del incio
  public class InicioController {

    public int margin = 30;
    public int size = 200;
    public int distance = 40;
    public String TempNom, TempDesC;

    public Usuario UsuarioActual { get; set; } // Usuario actualmente loggeado
    public static Boolean activ = true;

    // Constructor
    public InicioController(Usuario usuarioActual) {
      UsuarioActual = usuarioActual;
    }
    //cambia verdadero o falso segun si se requiere ver todas las actividades o solo las agregadas por el ususario
    public void estadoList(Boolean a) {
      activ = a;
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 15.12.2019
    // Funcion esconde y muestra el panel de la derecha
    public void TooglePanel(Panel panel, Button button, Panel container) {
      // Si el panel esta a la vista ocultarlo
      if (panel.Visible) {
        panel.Visible = false; // Ocultar panel
        button.Location = new System.Drawing.Point(5, 25); // Mover botón
        button.Text = ">"; // Cambiar flechita
        // Mover contenedor
        container.Location = new System.Drawing.Point(31, 0);
        container.Size = new System.Drawing.Size(1037, 635);
      }
      // Si esta escondido mostrarlo
      else {
        panel.Visible = true; // Mostrar panel
        button.Location = new System.Drawing.Point(273, 20); // Mover botón
        button.Text = "<"; // Cambiar flechita
        // Mover contenedor
        container.Location = new System.Drawing.Point(297, 0);
        container.Size = new System.Drawing.Size(771, 635);
      }
    }

    // Estado: Activo
    // Creado por Juan Castro - 19.12.2019
    // deja los objetos con propiedades predeterminaadas
    public void LimpiarControles() {
      //se vuelven a los valores predeterminados
      margin = 30;
      size = 200;
      distance = 40;
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 15.12.2019
    // Funcion carga y muestra las actividades en la pantalla de inicio
    public void LoadActividades(Panel container) {
      // Listas de elementos a pintar
      List<Panel> paneles = new List<Panel>();
      List<Button> botones = new List<Button>();
      List<Label> nombres = new List<Label>();
      List<Label> descripciones = new List<Label>();

      //Modificacion
      //Limpia los controles : Juan Castro - 19.12.2019
      container.Controls.Clear();
      paneles.Clear();
      botones.Clear();
      nombres.Clear();
      descripciones.Clear();
      LimpiarControles();

      // Suspender para actualizar
      container.SuspendLayout();
      // For para pasar por todas las actividades del usuario
      for (int i = 0; i < UsuarioActual.Actividades.Count; i++) {
        // Guardar actividad actual en el for
        Actividad actividad = UsuarioActual.Actividades.ElementAt(i);
        // Instanciar la primera informacion de las listas
        paneles.Add(new Panel());
        botones.Add(new Button());
        nombres.Add(new Label());
        descripciones.Add(new Label());
        // Suspender para actualizar
        paneles.ElementAt(i).SuspendLayout();
        // Modificar el label del nombre
        nombres.ElementAt(i).AutoSize = true;
        nombres.ElementAt(i).Location = new System.Drawing.Point(28, 25);
        nombres.ElementAt(i).Name = actividad.Nombre;
        nombres.ElementAt(i).Size = new System.Drawing.Size(35, 13);
        nombres.ElementAt(i).TabIndex = 0;
        nombres.ElementAt(i).Text = actividad.Nombre;



        // Modificar el label de la descripcion
        descripciones.ElementAt(i).AutoSize = true;
        descripciones.ElementAt(i).Location = new System.Drawing.Point(28, 60);
        descripciones.ElementAt(i).Name = actividad.Nombre;
        descripciones.ElementAt(i).Size = new System.Drawing.Size(35, 13);
        descripciones.ElementAt(i).TabIndex = 0;
        descripciones.ElementAt(i).Text = actividad.Descripcion;



        // Modificar el boton con el link
        botones.ElementAt(i).Location = new System.Drawing.Point(124, 108);
        botones.ElementAt(i).Name = "Btn" + actividad.Nombre + i;
        botones.ElementAt(i).Size = new System.Drawing.Size(75, 23);
        botones.ElementAt(i).TabIndex = 1;
        botones.ElementAt(i).Text = "Ver este evento";
        botones.ElementAt(i).UseVisualStyleBackColor = true;

        //hace referencia al evento :  juan castro 18-12-19
        botones.ElementAt(i).Click += new EventHandler(Btn_Click);


        // Modificar panel
        paneles.ElementAt(i).BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        paneles.ElementAt(i).Controls.Add(botones.ElementAt(i));
        paneles.ElementAt(i).Controls.Add(nombres.ElementAt(i));
        paneles.ElementAt(i).Controls.Add(descripciones.ElementAt(i));
        paneles.ElementAt(i).Location = new System.Drawing.Point(40, distance);
        paneles.ElementAt(i).Name = "panel" + actividad.Nombre;
        paneles.ElementAt(i).Size = new System.Drawing.Size(430, size);
        paneles.ElementAt(i).TabIndex = 0;
        // Agregar panel al container
        container.Controls.Add(paneles.ElementAt(i));
        // Actualizar nueva vista
        paneles.ElementAt(i).ResumeLayout(false);
        paneles.ElementAt(i).PerformLayout();
        // Re-calcular para siguiente panel
        distance = distance + margin + size;
      }
      // Actualizar container con nuevas vistas
      container.AutoScrollMinSize = new System.Drawing.Size(600, distance);
      container.ResumeLayout(false);
      container.AutoScroll = true;
    }

    // Estado: Activo
    // Creado por Juan Castro - 19.12.2019
    // abre la vista de detalle deactividades y envia toda la informacion del evento seleccionado
    public void Btn_Click(object sender, EventArgs e) {
      //se 
      Button tempBtn = sender as Button;
      //se toma el ultimo caracter de la cadena, correspondiente al indice del array list
      String ctn = tempBtn.Name.Substring(tempBtn.Name.Length - 1);
      int i = Int16.Parse(ctn);
      //se instancia el objeto
      Actividad actividad = new ActividadServicio().getActividad(i + 1);
      List<Actividad> actividades = UsuarioActual.Actividades;
      List<Actividad> todasActividades = new ActividadServicio().getActividades();

      activ = true;
      foreach (Actividad acts in actividades) {
        if (actividad != null) {
          if (actividad.Id == acts.Id) { activ = false; }
        }
      }

      Models.Servicios.ActividadServicio act = new Models.Servicios.ActividadServicio();
      int part = act.participantes(todasActividades.ElementAt(i).Id);
      //se instancia la nueva ventana
      Views.EventoDetallado eve = new Views.EventoDetallado(UsuarioActual.Documento, todasActividades.ElementAt(i).Id, todasActividades.ElementAt(i).Nombre, todasActividades.ElementAt(i).Descripcion, part, activ);
      //se visualiza sin minizar la actual ventana
      eve.Show();
    }


    public void LoadAllActividades(Panel container) {
      // Listas de elementos a pintar
      List<Panel> paneles = new List<Panel>();
      List<Button> botones = new List<Button>();
      List<Label> nombres = new List<Label>();
      List<Label> descripciones = new List<Label>();

      //Modificacion
      //Limpia los controles : Juan Castro - 19.12.2019
      container.Controls.Clear();
      paneles.Clear();
      botones.Clear();
      nombres.Clear();
      descripciones.Clear();
      LimpiarControles();

      // Suspender para actualizar
      container.SuspendLayout();
      List<Actividad> actividades = new ActividadServicio().getActividades();
      // For para pasar por todas las actividades del usuario
      for (int i = 0; i < actividades.Count; i++) {
        // Guardar actividad actual en el for
        Actividad actividad = actividades.ElementAt(i);
        // Instanciar la primera informacion de las listas
        paneles.Add(new Panel());
        botones.Add(new Button());
        nombres.Add(new Label());
        descripciones.Add(new Label());
        // Suspender para actualizar
        paneles.ElementAt(i).SuspendLayout();
        // Modificar el label del nombre
        nombres.ElementAt(i).AutoSize = true;
        nombres.ElementAt(i).Location = new System.Drawing.Point(28, 25);
        nombres.ElementAt(i).Name = actividad.Nombre;
        nombres.ElementAt(i).Size = new System.Drawing.Size(35, 13);
        nombres.ElementAt(i).TabIndex = 0;
        nombres.ElementAt(i).Text = actividad.Nombre;



        // Modificar el label de la descripcion
        descripciones.ElementAt(i).AutoSize = true;
        descripciones.ElementAt(i).Location = new System.Drawing.Point(28, 60);
        descripciones.ElementAt(i).Name = actividad.Nombre;
        descripciones.ElementAt(i).Size = new System.Drawing.Size(35, 13);
        descripciones.ElementAt(i).TabIndex = 0;
        descripciones.ElementAt(i).Text = actividad.Descripcion;



        // Modificar el boton con el link
        botones.ElementAt(i).Location = new System.Drawing.Point(124, 108);
        botones.ElementAt(i).Name = "Btn" + actividad.Nombre + i;
        botones.ElementAt(i).Size = new System.Drawing.Size(75, 23);
        botones.ElementAt(i).TabIndex = 1;
        botones.ElementAt(i).Text = "Ver este evento";
        botones.ElementAt(i).UseVisualStyleBackColor = true;

        //hace referencia al evento :  juan castro 18-12-19
        botones.ElementAt(i).Click += new EventHandler(Btn_Click);


        // Modificar panel
        paneles.ElementAt(i).BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        paneles.ElementAt(i).Controls.Add(botones.ElementAt(i));
        paneles.ElementAt(i).Controls.Add(nombres.ElementAt(i));
        paneles.ElementAt(i).Controls.Add(descripciones.ElementAt(i));
        paneles.ElementAt(i).Location = new System.Drawing.Point(40, distance);
        paneles.ElementAt(i).Name = "panel" + actividad.Nombre;
        paneles.ElementAt(i).Size = new System.Drawing.Size(430, size);
        paneles.ElementAt(i).TabIndex = 0;
        // Agregar panel al container
        container.Controls.Add(paneles.ElementAt(i));
        // Actualizar nueva vista
        paneles.ElementAt(i).ResumeLayout(false);
        paneles.ElementAt(i).PerformLayout();
        // Re-calcular para siguiente panel
        distance = distance + margin + size;
      }
      // Actualizar container con nuevas vistas
      container.AutoScrollMinSize = new System.Drawing.Size(600, distance);
      container.ResumeLayout(false);
      container.AutoScroll = true;
    }

  }

}
