using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Estado: Activo
// Creado por Juan Castro - 18.12.2019
// vista para mostrar detalladamente el evento

namespace Tolotu_Desktop.Views{
    public partial class EventoDetallado : Form{
        public EventoDetallado(String nombre,String descr, int participantes){
            InitializeComponent();
            //al cargar el form se visualiza la imagen del evento por default
            String FileName = Path.Combine(@"..\..\imagenes\Events\EventDefault.PNG");
            EventImagen.Image = System.Drawing.Image.FromFile(FileName);
            EventImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            //se imprime la informacion que llega como parametros
            LblEventNombre.Text = nombre;
            LblDescripcion.Text = descr;
            LblAsistentes.Text = participantes.ToString();

           //mantiene los labels centrados
            LblEventNombre.Left = (this.ClientSize.Width - LblEventNombre.Size.Width) / 2;
            LblDescripcion.Left = (this.ClientSize.Width - LblDescripcion.Size.Width) / 2;
          

        }

        private void BtnCerrar_Click(object sender, EventArgs e){
            this.Hide();
        }

        
        private void EventoDetallado_Load(object sender, EventArgs e){
           
        }
        public void Btn_Click(object sender, EventArgs e){
           
        }

        private void EventImagen_Click(object sender, EventArgs e)
        {

        }
    }
}
