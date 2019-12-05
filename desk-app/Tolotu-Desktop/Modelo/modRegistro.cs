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

        // Estado: Activo
        // Creado por Juan Miguel Castro rojas - 24.11.2019
        // validacion con la base de datos para usuarios nuevos
        public Boolean val (String usuario){
            Boolean res = false;
            con.abrirConx();
            SqlCommand cmd = new SqlCommand();
            try { 
                if (con.State != ConnectionState.Closed){
                SqlCommand com = new SqlCommand();
                com.Connection = con.conecta;
                com.CommandType = CommandType.Text;
                com.CommandText = "SELECT * FROM usuario WHERE [usuario] = '" + usuario + "';";
                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read()){
                    res = true;
                }
            }
            con.cerrarConx();
            return res;
            }
            catch (Exception ex) {
                MessageBox.Show("ha habido un error al conectar a la base de datos" + ex);
                return res;
            }
        }
        // Estado: Activo
        // Creado por Juan Miguel Castro rojas - 26.11.2019
        // insersion de valores a la base de datos para usuarios nuevos
        public Boolean registro(String usu, String pass, String Pnombre, String Snombre, String Papellido, String Sapellido, String correo, int genero, DateTime fecha, int edad, String tel, int Doc, int TDoc, String img){
            Console.WriteLine(usu);
            Console.WriteLine(pass);
            Console.WriteLine(Pnombre);
            Console.WriteLine(Snombre);
            Console.WriteLine(Papellido);
            Console.WriteLine(Sapellido);
            Console.WriteLine(correo);
            Console.WriteLine(genero);
            Console.WriteLine(fecha);
            Console.WriteLine(edad);
            Console.WriteLine(tel);
            Console.WriteLine(Doc);
            Console.WriteLine(img);



            try
            {
               // String query = "insrt into usuario([documento],[tipo_documento],[usuario],[primer_nombre],[segundo_nombre],[primer_apellido],[segundo_apellido],[correo],[tel],[genero],[fecha_nacimiento],[edad],[estado],[contrasenia],[rol],[imagen]) VALUES (" + Doc + "," + TDoc + ",'" + usu + "','" + Pnombre + "','" + Snombre + "','" + Papellido + "','" + Sapellido + "','" + correo + "','" + tel + "'," + genero + "," + fecha + "," + edad + "," + 1 + ",'" + pass + "'," + 2 + ",'" + img + "')";
                String query = "insert into usuario ([documento],[tipo_documento],[usuario],[primer_nombre],[segundo_nombre],[primer_apellido],[segundo_apellido],[correo],[tel],[genero],[fecha_nacimiento],[edad],[estado],[contrasenia],[rol],[imagen]) VALUES (@[documento],@[tipo_documento],@[usuario],@[primer_nombre],@[segundo_nombre],@[primer_apellido],@[segundo_apellido],@[correo],@[tel],@[genero],@[fecha_nacimiento],@[edad],@[estado],@[contrasenia],@[rol],@[imagen])";
                
                con.abrirConx();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con.conecta;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@[documento]", Doc);
                cmd.Parameters.AddWithValue("@[tipo_documento]", TDoc);
                cmd.Parameters.AddWithValue("@[usuario]", usu);
                cmd.Parameters.AddWithValue("@[primer_nombre]", Pnombre);
                cmd.Parameters.AddWithValue("@[segundo_nombre]", Snombre);
                cmd.Parameters.AddWithValue("@[primer_apellido]",Papellido);
                cmd.Parameters.AddWithValue("@[segundo_apellido]", Sapellido);
                cmd.Parameters.AddWithValue("@[correo]", correo);
                cmd.Parameters.AddWithValue("@[tel]", tel);
                cmd.Parameters.AddWithValue("@[genero]", genero);
                cmd.Parameters.AddWithValue("@[fecha_nacimiento]", fecha);
                cmd.Parameters.AddWithValue("@[edad]", edad);
                cmd.Parameters.AddWithValue("@[estado]", 1);
                cmd.Parameters.AddWithValue("@[contrasenia]", pass);
                cmd.Parameters.AddWithValue("@[rol]", 2);
                cmd.Parameters.AddWithValue("@[imagen]",img);

                //cmd.Parameters.Add("@[documento]",SqlDbType.Int);
                //cmd.Parameters.Add("@[tipo_documento]", SqlDbType.TinyInt);
                //cmd.Parameters.Add("@[usuario]", SqlDbType.VarChar);
                //cmd.Parameters.Add("@[primer_nombre]", SqlDbType.VarChar);
                //cmd.Parameters.Add("@[segundo_nombre]", SqlDbType.VarChar);
                //cmd.Parameters.Add("@[primer_apellido]", SqlDbType.VarChar);
                //cmd.Parameters.Add("@[segundo_apellido]", SqlDbType.VarChar);
                //cmd.Parameters.Add("@[correo]", SqlDbType.VarChar);
                //cmd.Parameters.Add("@[tel]", SqlDbType.VarChar);
                //cmd.Parameters.Add("@[genero]", SqlDbType.TinyInt);
                //cmd.Parameters.Add("@[fecha_nacimiento]", SqlDbType.Date);
                //cmd.Parameters.Add("@[edad]", SqlDbType.TinyInt);
                //cmd.Parameters.Add("@[estado]", SqlDbType.TinyInt);
                //cmd.Parameters.Add("@[contrasenia]", SqlDbType.VarChar);
                //cmd.Parameters.Add("@[rol]", SqlDbType.TinyInt);
                //cmd.Parameters.Add("@[imagen]", SqlDbType.Image);


                //cmd.Parameters["@[documento]"].Value = Doc;
                //cmd.Parameters["@[tipo_documento]"].Value = TDoc;
                //cmd.Parameters["@[usuario]"].Value = usu;
                //cmd.Parameters["@[primer_nombre]"].Value = Pnombre;
                //cmd.Parameters["@[segundo_nombre]"].Value = Snombre;
                //cmd.Parameters["@[primer_apellido]"].Value = Papellido;
                //cmd.Parameters["@[segundo_apellido]"].Value = Sapellido;
                //cmd.Parameters["@[correo]"].Value = correo;
                //cmd.Parameters["@[tel]"].Value = tel;
                //cmd.Parameters["@[genero]"].Value = genero;
                //cmd.Parameters["@[fecha_nacimiento]"].Value = fecha;
                //cmd.Parameters["@[edad]"].Value = edad;
                //cmd.Parameters["@[estado]"].Value = 1;
                //cmd.Parameters["@[contrasenia]"].Value = pass;
                //cmd.Parameters["@[rol]"].Value = 2;


                //System.IO.MemoryStream ms = new System.IO.MemoryStream();
                //img.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
                //cmd.Parameters["@[imagen]"].Value = ms.GetBuffer();
                cmd.ExecuteNonQuery();
              

                con.cerrarConx();
                return true;
            }
            catch (Exception ex){
                MessageBox.Show("ha habido un inconveniente con el registro, Por favor vuelva a insistir. " + ex);
            }
            return true;
        }
    }
}
