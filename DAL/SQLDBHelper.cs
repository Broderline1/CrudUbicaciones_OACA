using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SQLDBHelper
    {
        DataTable tabla;
        SqlConnection strConexion = new SqlConnection("Data Source=DESKTOP-9LQUN2M\\HOLAMUNDO; Initial Catalog=BDUbicaciones; Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        
        public bool EjecutarComandoSQL (SqlCommand strSQLCommand)
        {
            // insertar, modificar, borrar

            bool Respuesta = true;

            cmd = strSQLCommand;
            cmd.Connection = strConexion;
            strConexion.Open();
            Respuesta = (cmd.ExecuteNonQuery() <= 0) ? false : true;
            strConexion.Close();
            return Respuesta;
        }

        public DataTable EjecutarSentenciaSQL(SqlCommand strSQLCommand)
        {
            //Seleccionar datos de la DB

            cmd = strSQLCommand;
            cmd.Connection = strConexion;
            strConexion.Open();
            tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            strConexion.Close();
            return tabla;
        }
    }
}
