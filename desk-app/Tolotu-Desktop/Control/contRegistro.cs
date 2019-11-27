using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tolotu_Desktop.vista;
namespace Tolotu_Desktop.Control
{
    // Estado: Activo
    // Creado por Juan Miguel Castro rojas - 23.11.2019
    // control de registro
    class contRegistro
    {
        // Estado: Activo
        // Creado por Juan Miguel Castro rojas - 23.11.2019
        // metodo para validacion de nuevo usuario
        private int gen, document, TDocu,edad;
        
        Modelo.modRegistro modReg = new Modelo.modRegistro();

        // Estado: Activo
        // Creado por Juan Miguel Castro rojas - 21.11.2019
        //  metodo que muestra el resultado de la validacion de usuario
        public Boolean validar(String usu){
            if (modReg.val(usu) == true){
                MessageBox.Show("El nombre de usuario '"+usu+"' ya esta registrado, Ingrese otro por favor.");
                return true;
            }else{
                MessageBox.Show("El nombre de usuario '" + usu + "' es valido para su uso");
                return false;
            }
        }
        // Estado: Activo
        // Creado por Juan Miguel Castro rojas - 23.11.2019
        //  metodo que valida que ningun campo falte por llenar y redirige a la base de datos
        public void tomaDatos(String usu, String pass, String confPass, String nombres, String apellidos, String correo,String genero, DateTime fecha, String tel,String Doc,String TDoc, PictureBox img ){
            if(usu == "" || pass =="" ||  confPass == "" || nombres == "" || apellidos == "" || correo == "" || genero == "" || tel == "" || Doc == "" || TDoc == ""){
                MessageBox.Show("Ha dejado algun campo sin llenar. Por favor verifique que que no haya dejado un campo vacio");
            }
            else{
                if (pass.Equals(confPass) && convertInt(Doc)){
                    converGen(genero, TDoc);
                    usu = "";
                    // se valida si la conversion de numero de documento y la edad son validos
                    if (convertInt(Doc) ==true && IdentificarEdad(fecha)==true){
                        // se hace separacion de nombres y apellidos
                        string[] n1n2 = nombres.Split(' ');
                        string[] p1p2 = apellidos.Split(' ');
                        
                        modReg.registro(usu, pass,n1n2[0],n1n2[1],p1p2[0],p1p2[1], correo, gen, fecha,edad,tel,document,TDocu,img);                    }
                }
                else {
                    MessageBox.Show("No son iguales las contraseñas insertadas en los campos, por favor vuelva a intentarlo");
                }
            }     
        }
        // Estado: Activo
        // Creado por Juan Miguel Castro rojas - 26.11.2019
        // metodo para identificar la edad a base de la fecha de nacimiento
        public Boolean IdentificarEdad(DateTime fecha){
            
             this.edad = System.DateTime.Now.Year - fecha.Year;
            if (System.DateTime.Now.Subtract(fecha.AddYears(edad)).TotalDays < 0){
                
                return true;    
            }
            else{
                MessageBox.Show("la fecha de nacimiento que ha introducido es invaldia");
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
        public Boolean convertInt(String Docum)
        {
            Boolean confirmar =  Int32.TryParse(Docum, out document);
            return confirmar;
        }
    }
}


