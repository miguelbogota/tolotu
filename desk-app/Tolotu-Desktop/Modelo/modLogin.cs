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

        public Boolean validacion(string nombre, string clave)
        {
            Boolean res = false;
            con.abrirConx();

            if (con.State != ConnectionState.Closed)
            {
                SqlCommand com = new SqlCommand();
                com.Connection = con.conecta;
                com.CommandType = CommandType.Text;
                com.CommandText = "SELECT * FROM usuario WHERE [usuario] = '" + nombre + "' AND [contrasenia] = '" + clave + "';";
                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    res = true;
                }
            }
            con.cerrarConx();
            return res;
        }
    }

}