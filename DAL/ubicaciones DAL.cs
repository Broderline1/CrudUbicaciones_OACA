using System.Data;
using System.Data.SqlClient;
using BLL;

namespace DAL
{
    public class ubicaciones_DAL
    {
        SQLDBHelper oConexion;
        //inicializar la conexion con la BD (Constructor)

        public ubicaciones_DAL() {
            oConexion = new SQLDBHelper();
        }

        public void Agregar() { }

        public void Eliminar() { }

        public void Modificar() { }

        //Seleccionar los registros de la tabla mediante un SELECT

        public DataTable Listar() {
            SqlCommand cmdComando = new SqlCommand();
            //Sentencia SQL para traer todos los registros de la tabla "Direcciones"
            cmdComando.CommandText = "SELECT * FROM Direcciones";
            // Tipo de comando, ya sea texto, SP, etc.
            cmdComando.CommandType = CommandType.Text;

            DataTable tablaResultante = oConexion.EjecutarSentenciaSQL(cmdComando);

            return tablaResultante;
        }

    }
}
