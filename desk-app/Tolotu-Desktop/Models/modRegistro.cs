using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tolotu_Desktop.Modelo
{
    class modRegistro
    {
        // Estado: Activo
        // Creado por Juan Miguel Castro rojas - 24.11.2019
        // modelo para registro
        private modelo.Conexion con = new modelo.Conexion();

       
        private Boolean res =false;
        // Estado: Activo
        // Creado por Juan Miguel Castro rojas - 08.12.2019
        // validacion con la base de datos para documento
        public Boolean doc(int documento){
            con.abrirConx();
            SqlCommand cmd = new SqlCommand();
            try {
               
                if (con.conecta.State != ConnectionState.Closed){
                    SqlCommand com = new SqlCommand();
                    com.Connection = con.conecta;
                    com.CommandType = CommandType.Text;
                    com.CommandText = "SELECT * FROM usuario WHERE [documento] = '" + documento + "';";
                    SqlDataReader reader = com.ExecuteReader();
                    if (reader.Read())
                    {
                        res = true;
                    } else{
                        res = false;
                    }
                }
            }catch (Exception ex) {
                MessageBox.Show("ha habido un error al conectar a la base de datos" + ex, "Tolotu - Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.cerrarConx();
            return res;
        }
        // Estado: Activo
        // Creado por Juan Miguel Castro rojas - 24.11.2019
        // validacion con la base de datos para usuarios nuevos
        public Boolean val (String usuario){
            con.abrirConx();
            SqlCommand cmd = new SqlCommand();
            try {
                //if (con.State != ConnectionState.Closed){
                // se reemplazo la linea anterior por que la conexion llegaba cerrada y no daba paso al codigo dentro de la estructura
                if (con.conecta.State != ConnectionState.Closed){
                SqlCommand com = new SqlCommand();
                    com.Connection = con.conecta;
                    com.CommandType = CommandType.Text;
                    com.CommandText = "SELECT * FROM usuario WHERE [usuario] = '" + usuario + "';";
                    SqlDataReader reader = com.ExecuteReader();
                    if (reader.Read()){
                        res = true;
                    }else{
                        res = false;
                    }
                }
            }catch (Exception ex) {
                MessageBox.Show("ha habido un error al conectar a la base de datos" + ex, "Tolotu - Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.cerrarConx();
            return res;
        }
        // Estado: Activo
        // Creado por Juan Miguel Castro rojas - 26.11.2019
        // insersion de valores a la base de datos para usuarios nuevos
        public Boolean registro(String usu, String pass, String Pnombre, String Snombre, String Papellido, String Sapellido, String correo, int genero, DateTime fecha, int edad, String tel, int Doc, int TDoc, String img){
            //Console.WriteLine(usu);
            //Console.WriteLine(pass);
            //Console.WriteLine(Pnombre);
            //Console.WriteLine(Snombre);
            //Console.WriteLine(Papellido);
            //Console.WriteLine(Sapellido);
            //Console.WriteLine(correo);
            //Console.WriteLine(genero);
            //Console.WriteLine(fecha);
            //Console.WriteLine(edad);
            //Console.WriteLine(tel);
            //Console.WriteLine(Doc);
            //Console.WriteLine(img);
            try {
                String query = "insert into usuario VALUES (" + Doc + "," + TDoc + ",'" + usu + "','" + Pnombre + "','" + Snombre + "','" + Papellido + "','" + Sapellido + "','" + correo + "','" + tel + "'," + genero + ",'" + fecha.ToString("yyyy-MM-dd HH:mm:ss") + "'," + edad + "," + 1 + ",'" + pass + "'," + 2 + ",'" + img + "');";
                //String query = "insert into usuario ([documento],[tipo_documento],[usuario],[primer_nombre],[segundo_nombre],[primer_apellido],[segundo_apellido],[correo],[tel],[genero],[fecha_nacimiento],[edad],[estado],[contrasenia],[rol],[imagen]) VALUES (@[documento],@[tipo_documento],@[usuario],@[primer_nombre],@[segundo_nombre],@[primer_apellido],@[segundo_apellido],@[correo],@[tel],@[genero],@[fecha_nacimiento],@[edad],@[estado],@[contrasenia],@[rol],@[imagen])";
                
                con.abrirConx();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.conecta;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.cerrarConx();
                return true;
            }catch (Exception ex){
                MessageBox.Show("ha habido un inconveniente con el registro, Por favor vuelva a intentar. " + ex, "Tolotu - Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return true;
        }
    }
}
