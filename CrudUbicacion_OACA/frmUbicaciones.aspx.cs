using System;
// Capas
using BLL;
using DAL;

namespace CrudUbicacion_OACA
{
    public partial class frmUbicaciones : System.Web.UI.Page
    {
        ubicaciones_BLL oUbicacionesBLL;
        ubicaciones_DAL oUbicacionesDAL;

        protected void Page_Load(object sender, EventArgs e)
        {
            ListarUbicaciones();
        }

        // Metodo envargado de listar los datos de la BD de un GRIDView

        public void ListarUbicaciones()
        {
            oUbicacionesDAL = new ubicaciones_DAL();

            gvUbicaciones.DataSource = oUbicacionesDAL.Listar();
            gvUbicaciones.DataBind();
        }
    }
}