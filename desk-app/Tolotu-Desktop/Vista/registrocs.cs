using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tolotu_Desktop.vista;

namespace Tolotu_Desktop.vista {

    // Estado: Activo
    // Creado por Juan Castro - 22.11.2019
    // vista para registro de usuarios nuevos

    public partial class ventanaRegistro : Form {

        Control.contRegistro contReg = new Control.contRegistro();

        public ventanaRegistro() {
          InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e){
            if (contReg.validar(txtusuario.Text)== false) {
                txtusuario.Enabled = false;
                btnValidar.Enabled = false;
                panelInfoBasica.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e){
            panel2.Enabled = true;
            panel2.Visible = true;
            panelInfoBasica.Visible = false;

        }

         private void importImg_Click(object sender, EventArgs e){
             try{
                 this.openFileDialog1.ShowDialog();
                 if (this.openFileDialog1.FileName.Equals("")==false){
                        imagen.Load(this.openFileDialog1.FileName);
                 }
             } catch(Exception ex){
                    MessageBox.Show("No se ha podido cargar la imagen, por favor asegurese de seleccionar un archivo .PNG o .JPG" + ex);
             }
         }

         private void btnCancelar_Click(object sender, EventArgs e){
            irLogin();
         }

         private void ventanaRegistro_Load(object sender, EventArgs e){
            panelInfoBasica.Enabled = false;
            panel2.Enabled = false;

            panel2.Visible = false;
            panelInfoBasica.Visible = true;
            //carga la imagen de usuario predefinida
           
            
            String FileName = Path.Combine(@"..\..\imagenes\default.PNG");
            imagen.Image = System.Drawing.Image.FromFile(FileName);

            imagen.SizeMode = PictureBoxSizeMode.StretchImage;

         }

        private void label10_Click(object sender, EventArgs e){

        }

        private void button2_Click_1(object sender, EventArgs e){
            irLogin();
        }
        private void irLogin(){
            ventanaLogin log = new ventanaLogin();
            this.Hide();
            log.Show();
        }

        private void button1_Click_1(object sender, EventArgs e){
            String date = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            if(contReg.tomaDatos(txtusuario.Text, txtPass.Text, txtConfPass.Text, txtPNombres.Text, txtSNombres.Text, txtPApellidos.Text, txtSApellidos.Text, txtCorreos.Text, combGen.SelectedItem.ToString(), dateTimePicker1.Value, txtTel.Text, txtNDoc.Text, combTD.SelectedItem.ToString(), imagen)){
                irLogin();
            }
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panelInfoBasica.Visible = true;
        }
    }
}
