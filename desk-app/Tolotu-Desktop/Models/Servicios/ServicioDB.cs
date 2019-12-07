using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tolotu_Desktop.Models.Servicios {

  // Estado: Activo
  // Creado por Miguel Bogota - 06.12.2019
  // Clase de funciones de la base de datos.
  public class ServicioDB {

    private string DBName { get; set; } // Nombre de conexión a base de datos
    private SqlConnection conn { get; set; } // Conexión a la base de datos
    public ConnectionState State { get; } // Estado de la conexción a la base de datos
    private SqlDataReader Reader { get; set; } // Consulta de lectura

    // Constructor con nombres
    public ServicioDB(string serverName, string dbName) {
      this.DBName = string.Format("Server={0}; Database={1}; Integrated Security=true", serverName, dbName); // Asignar base de datos y servidor
      this.conn = new SqlConnection(DBName); // Conectar con la base de datos
      this.State = this.conn.State; // Asignar el estado
    }

    // Constructor vacio
    public ServicioDB() {
      this.DBName = "Server=DESKTOP-6I0PPMD\\SQLINSTANCE; Database=TolotuDB; Integrated Security=True"; // Asignar base de datos y servidor determinados
      this.conn = new SqlConnection(DBName); // Conectar con la base de datos
      this.State = this.conn.State; // Asignar el estado
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 06.12.2019
    // Función abre la base de datos
    public Boolean Abrir() {
      Boolean check = false;
      try {
        this.conn.Open(); // Abrir conexión
        check = true;
      }
      catch(SqlException sqlEx) {
        Console.WriteLine("Error de conexión: " + sqlEx); // Mostrar mensaje
      }
      return check;
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 06.12.2019
    // Función cierra la base de datos
    private Boolean Cerrar() {
      Boolean check = false;
      try {
        this.conn.Close(); // Cerrar conexión
        check = true;
      }
      catch (SqlException sqlEx) {
        Console.WriteLine("Error de conexión: " + sqlEx); // Mostrar mensaje
      }
      return check;
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 06.12.2019
    // Función crea consultar de lectura a la base de datos
    public SqlDataReader Consulta(string Query) {
      try {
        this.Abrir(); // Abrir base de datos
        SqlCommand comando = new SqlCommand(Query, conn); // Crear comando con query
        comando.CommandType = CommandType.Text; // Texto
        Reader = comando.ExecuteReader(); // Ejecutar el comando y guardarlo
      }
      catch(Exception ex) {
        Console.WriteLine("Error de conexión: " + ex); // Mostrar mensaje
        Reader = null;
      }
      finally {
        this.Cerrar(); // Cerrar base de datos
      }
      return Reader; // Devolver el resultado
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 06.12.2019
    // Función crea consultar con procedimiento almacenado y devuelve el valor
    // PAra agregar parametros se tiene que usar sintaxis: "@Nombre_Parametro_SQL, Valor_Parametro" y para el return "@Nombre_Return".
    public string ProcedimientoReturn(string Query, string returnName, SqlDbType typeSQL, params string[] parametros) {
      string result = "";
      try {
        this.Abrir(); // Abrir base de datos
        SqlCommand comando = new SqlCommand(Query, this.conn); // Crear comando con query
        comando.CommandType = CommandType.StoredProcedure; // Procedimiento almacenado
        // Agregar cada parametro a el procedimiento almacenado
        foreach (string param in parametros) {
          string[] values = param.Split(',').Select(sValue => sValue.Trim()).ToArray(); // Divide el parametro y el valor
          Console.WriteLine(values[0] + " " + values[1] + " - " + parametros.Count());
          comando.Parameters.Add(values[0], SqlDbType.VarChar).Value = values[1]; // Asigna el parametro y el valor
        }
        SqlParameter parm = new SqlParameter(returnName, typeSQL); // Devuelve el dato del procedimiento
        comando.Parameters.Add(returnName, typeSQL).Direction = ParameterDirection.Output; // Returno
        comando.ExecuteNonQuery(); // Ejecutar el comando
        result = Convert.ToString(comando.Parameters[returnName].Value); // Guarda el resultado en texto
      }
      catch (Exception ex) {
        Console.WriteLine("Error de conexión: " + ex); // Mostrar mensaje
        Reader = null;
      }
      finally {
        this.Cerrar(); // Cerrar base de datos
      }
      return result; // Devolver el resultado
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 06.12.2019
    // Función crea consultar con procedimiento almacenado y no devuelve el valor
    public void ProcedimientoNoReturn(string Query, params string[] parametros) {

    }

  }
}
