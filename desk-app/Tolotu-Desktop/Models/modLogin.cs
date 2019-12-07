using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Tolotu_Desktop.modelo;

namespace Tolotu_Desktop.modelo
{
    class modLogin
    {
        // Estado: Activo
        // Creado por Juan Miguel Castro rojas - 13.11.2019
        // clase para realizar consulta y devolver la validacion de al control de login


        private modelo.Conexion con = new modelo.Conexion();
        Boolean res = false;
        public Boolean validacion(string nombre, string clave){
            con.abrirConx();
            Console.WriteLine(con.conecta.State);
            if (con.conecta.State != ConnectionState.Closed) {
                
                SqlCommand com = new SqlCommand();
                com.Connection = con.conecta;
                com.CommandType = CommandType.Text;
                com.CommandText = "SELECT * FROM usuario WHERE [usuario] = '" + nombre + "' AND [contrasenia] = '" + clave + "';";
                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read()){
                    res = true;
                }
                else{
                    res = false;
                }
            }
            else{
                Console.WriteLine("fallo");
            }
            con.cerrarConx();
            return res;
        }
    }

}