﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tolotu_Desktop.modelo {

    // Estado: Activo
    // Creado por Juan Castro - 14.11.2019
    // metodos de apertura y cierre de conexion a base de datos
    public class Conexion {

        public SqlConnection conecta = new SqlConnection("Server=(local); Database=tolotuBD; Integrated Security=true");

        public ConnectionState State { get; internal set; }


        // Estado: Activo
        // Creado por Juan Castro - 14.11.2019
        // metodo de apertura de conexion a base de datos
        public SqlConnection abrirConx() {
          try {
            if (this.conecta.State == ConnectionState.Closed) {
              conecta.Open();
                    Console.WriteLine(conecta.State+"3");
                    return conecta;
            }
            else {
              return null;
            }
          }
          catch (SqlException e) {
            MessageBox.Show("no se pudo abrir la conexión" + e);
            return null;
          }
          catch (Exception x) {
            MessageBox.Show("no se puede ejecutar la conexión con el servidor" + x);
            return null;
          }
        }
        // Estado: Activo
        // Creado por Juan Castro - 14.11.2019
        // metodos de cierre de conexion a base de datos
        public SqlConnection cerrarConx() {
          try {
            if (this.conecta.State == ConnectionState.Open) {
              conecta.Close();
              return conecta;
            }
            else {
              return null;
            }
          }
          catch (SqlException e) {
            MessageBox.Show("no se pudo cerrar la conexión" + e);
            return null;
          }
          catch (Exception x) {
            MessageBox.Show("no se puede ejecutar la conexión con el servidor" + x);
            return null;
          }
        }
    }
}

