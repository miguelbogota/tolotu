using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tolotu_Desktop.vista;
using System.Drawing.Imaging;
using System.IO;

namespace Tolotu_Desktop.Control
{
    // Estado: Activo
    // Creado por Juan Miguel Castro rojas - 23.11.2019
    // control de registro
    class contRegistro{
        
        private int gen, document, TDocu,edad;
        private String URL;
        
        Modelo.modRegistro modReg = new Modelo.modRegistro();

        // Estado: Activo
        // Creado por Juan Miguel Castro rojas - 21.11.2019
        //  metodo que muestra el resultado de la validacion de usuario
        public Boolean validar(String usu){
            Console.WriteLine("mod2 " + modReg.val(usu));
            if (modReg.val(usu) == true){

                MessageBox.Show("El nombre de usuario '"+usu+"' ya esta registrado, Ingrese otro por favor.", "Tolotu - Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return true;
            }else{
                MessageBox.Show("El nombre de usuario '" + usu + "' es valido para su uso", "Tolotu - Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        // Estado: Activo
        // Creado por Juan Miguel Castro rojas - 23.11.2019
        //  metodo que valida que ningun campo falte por llenar y redirige a la base de datos
        public Boolean tomaDatos(String usu, String pass, String confPass, String Pnombres, String Snombres, String Papellidos, String Sapellidos, String correo,String genero, DateTime fecha, String tel,String Doc,String TDoc, PictureBox img ){
            Boolean vald = false;
            if(usu == "" || pass =="" ||  confPass == "" || Pnombres == "" ||Papellidos == "" || correo == "" || genero == "" || tel == "" || Doc == "" || TDoc == ""){
                MessageBox.Show("Ha dejado algun campo sin llenar. Por favor verifique que que no haya dejado un campo vacio", "Tolotu - Falta informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else{
                if (pass.Equals(confPass) && convertInt(Doc)==true){
                    converGen(genero, TDoc);
                    // se valida si la conversion de numero de documento y la edad son validos
                    if (convertInt(Doc) ==true && IdentificarEdad(fecha)==true){
                        imagen(img, usu);
                        if(modReg.registro(usu, pass, Pnombres, Snombres, Papellidos, Sapellidos, correo, gen, fecha, edad, tel, document, TDocu, URL)){
                            vald = true;
                            MessageBox.Show("Se ha registrado exitosamente!", "Tolotu - Registro",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        
                    }
                } else {
                    MessageBox.Show("No son iguales las contraseñas insertadas en los campos, por favor vuelva a intentarlo", "Tolotu - Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
            }
            return vald;
        }

        // Estado: Activo
        // Creado por Juan Miguel Castro rojas - 4.12.2019
        // guarda la imagen en los archivos locales de la aplicacion
        public void imagen(PictureBox img,String usu){
            //direccion exacta de donde se uubica la imagen dentro de la carpeta del proyecto
            String FileName = Path.Combine(@"..\..\imagenes\");
            this.URL = @""+FileName+"Img-" + usu + ".Jpeg";
            img.Image.Save(URL, ImageFormat.Jpeg);
        }


        // Estado: Activo
        // Creado por Juan Miguel Castro rojas - 26.11.2019
        // metodo para identificar la edad a base de la fecha de nacimiento

        public Boolean IdentificarEdad(DateTime fecha){
            
             this.edad = System.DateTime.Now.Year - fecha.Year;
           
            if (System.DateTime.Now.Subtract(fecha.AddYears(edad)).TotalDays > 0){
                return true;    
            } else{
                MessageBox.Show("la fecha de nacimiento que ha introducido es invaldia", "Tolotu - Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
        }
        public Boolean fechas(DateTime fecha){

            return false;
        }
        // Estado: Activo
        // Creado por Juan Miguel Castro rojas - 23.11.2019
        // metodo para validar genero y tipo de documento
        public void converGen(String genero,String TD){
            switch (genero){
                case "Hombre":
                    this.gen = 1;
                    break;
                case "Mujer":
                    this.gen = 2;
                    break;
                case "Otro":
                    this.gen = 3;
                    break;
            }
            switch (TD){
                case "Cedula de ciudadania":
                    this.TDocu = 1;
                    break;
                case "Pasaporte":
                    this.TDocu = 2;
                    break;
                case "Registro civil":
                    this.TDocu = 3;
                    break;
            }
        }
        // Estado: Activo
        // Creado por Juan Miguel Castro rojas - 23.11.2019
        //metodo para validar y convertir el nuemro de documento a entero
        public Boolean convertInt(String Docum){
            Boolean confirmar =  Int32.TryParse(Docum, out document);
            return confirmar;
        }
    }
}


