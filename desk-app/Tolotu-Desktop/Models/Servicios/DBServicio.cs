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
  public class DBServicio {

    private const string server = "(local)\\SQLINSTANCE"; // Nombre del servidor
    private const string database = "TolotuDB"; // Nombre de la base de datos

    private string DBName { get; set; } // Nombre de conexión a base de datos
    private SqlConnection conn { get; set; } // Conexión a la base de datos
    public ConnectionState State { get; } // Estado de la conexción a la base de datos
    private SqlDataReader Reader { get; set; } // Consulta de lectura

    // Constructor con nombres
    public DBServicio(string serverName, string dbName) {
      this.DBName = string.Format("Server={0}; Database={1}; Integrated Security=true", serverName, dbName); // Asignar base de datos y servidor
      this.conn = new SqlConnection(DBName); // Conectar con la base de datos
      this.State = this.conn.State; // Asignar el estado
    }

    // Constructor vacio
    public DBServicio() {
      this.DBName = string.Format("Server={0}; Database={1}; Integrated Security=true", server, database); // Asignar base de datos y servidor determinados
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
      catch (SqlException sqlEx) {
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
      catch (Exception ex) {
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
    // Para agregar parametros se tiene que usar sintaxis: "@Nombre_Parametro_SQL, Valor_Parametro, Tipo de parametro", si es un output "out, @Nombre_Parametro_SQL, Tipo de parametro, largo del tipo".
    public string[] ProcedimientoReturn(string Query, params string[] parametros) {
      string[] outputs; // Guardar outputs
      try {
        this.Abrir(); // Abrir base de datos
        SqlCommand comando = new SqlCommand(Query, this.conn); // Crear comando con query
        comando.CommandType = CommandType.StoredProcedure; // Procedimiento almacenado
        // Agregar cada parametro a el procedimiento almacenado
        int cont = 0; // Contador para saber el numero de outputs
        foreach (string param in parametros) {
          string[] values = param.Split(',').Select(sValue => sValue.Trim()).ToArray(); // Divide el parametro y el valor
          // Agregar si es input
          if (!values[0].Equals("out")) {
            comando.Parameters.Add(values[0], SqlDbType.VarChar).Value = values[1]; // Asigna el parametro y el valor
          }
          // Agregar si es ouyput
          else {
            comando.Parameters.Add(values[1], (SqlDbType)Enum.Parse(typeof(SqlDbType), values[2], true), Convert.ToInt32(values[3])).Direction = ParameterDirection.Output; // Agregar returno de informacion
            cont = cont + 1; // Contador de outputs
          }
        }
        comando.ExecuteNonQuery(); // Ejecutar el comando
        // Guardar todos los outputs
        outputs = new string[cont + 1]; // Asignar outputs con el contador
        cont = 0; // Reset para 
        foreach (string param in parametros) {
          string[] values = param.Split(',').Select(sValue => sValue.Trim()).ToArray(); // Divide el parametro y el valor
          // Agregar si es input
          if (values[0].Equals("out")) {
            outputs[cont] = Convert.ToString(comando.Parameters[values[1]].Value); // Guarda el resultado en texto
            cont = cont + 1; // guardar posicion del output
          }
        }
      }
      catch (Exception ex) {
        Console.WriteLine("Error de conexión: " + ex); // Mostrar mensaje
        outputs = null; // Si falla
      }
      finally {
        this.Cerrar(); // Cerrar base de datos
      }
      return outputs; // Devolver el resultado
    }

    // Estado: Activo
    // Creado por Miguel Bogota - 06.12.2019
    // Función crea consultar con procedimiento almacenado y no devuelve el valor
    public void ProcedimientoNoReturn(string Query, params string[] parametros) {
      try {
        this.Abrir(); // Abrir base de datos
        SqlCommand comando = new SqlCommand(Query, this.conn); // Crear comando con query
        comando.CommandType = CommandType.StoredProcedure; // Procedimiento almacenado
        // Agregar cada parametro a el procedimiento almacenado
        foreach (string param in parametros) {
          string[] values = param.Split(',').Select(sValue => sValue.Trim()).ToArray(); // Divide el parametro y el valor
          comando.Parameters.Add(values[0], SqlDbType.VarChar).Value = values[1]; // Asigna el parametro y el valor
        }
        comando.ExecuteNonQuery(); // Ejecutar el comando
      }
      catch (Exception ex) {
        Console.WriteLine("Error de conexión: " + ex); // Mostrar mensaje
      }
      finally {
        this.Cerrar(); // Cerrar base de datos
      }
    }

  }
}
