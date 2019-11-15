using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tolotu_Desktop.modelo {


  public class Conexion {

    private SqlConnection conecta = new SqlConnection("Server=(local); Database=x; Integrated Security=true");

    // Constructor
    public Conexion() {

    }

    public SqlConnection abrirConx() {
      try {
        if (this.conecta.State == ConnectionState.Closed) {
          conecta.Open();
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

