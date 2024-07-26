using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace webEstudiantes
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnagregar_click(object sender, EventArgs e)
        {
            // metodo para registra estudiantes en la db //
            string connection = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("SP_RegistrarEstudiante", sqlConnection)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Connection.Open();
            cmd.Parameters.Add("@paramNombre",SqlDbType.VarChar, 50).Value = Textnombre.Text;
            cmd.Parameters.Add("@paramDireccion",SqlDbType.VarChar, 150).Value = Textdireccion.Text;

            int rows = cmd.ExecuteNonQuery();

            // LabelInfo.Text = rows.ToString();
            LabelInfo.Text = "Se agrego un nuevo estudiante";
        }

        protected void Btneditar_click(Object sender, EventArgs e)
        {
            // metodo para modificar datos de estudiantes en la db //
            string connection = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("SP_actualizarDatos", sqlConnection)
            {
                CommandType = CommandType.StoredProcedure
            };

            string carnet = Textcarnet.Text;
            int converCarnent = int.Parse(carnet);

            cmd.Connection.Open();
            cmd.Parameters.Add("@paramCarnet", SqlDbType.Int).Value = converCarnent;
            cmd.Parameters.Add("@paramNombre", SqlDbType.VarChar, 50).Value = Textnombre.Text;
            cmd.Parameters.Add("@paramDireccion", SqlDbType.VarChar, 150).Value = Textdireccion.Text;

            int rows = cmd.ExecuteNonQuery();

            LabelInfo.Text = "Se actualizaron los datos del estudiante";
        }

        protected void Btneliminar_click(object sender, EventArgs e)
        {
            // metodo para eliminar estudiantes de la db //
            string connection = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("SP_EliminarEstudiante", sqlConnection)
            {
                CommandType = CommandType.StoredProcedure
            };

            string carnet = Textcarnet.Text;
            int converCarnent = int.Parse(carnet);

            cmd.Connection.Open();
            cmd.Parameters.Add("@paramCarnet", SqlDbType.Int).Value = converCarnent;

            int rows = cmd.ExecuteNonQuery();

            LabelInfo.Text = "Se eliminaron los datos del estudiante";
        }

        protected void Btnconsultar_click(Object sender, EventArgs e)
        {
            // metodo para seleccionar un usuario de la db //
            string connection = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("SP_ConsultarEstudiante", sqlConnection)
            {
                CommandType = CommandType.StoredProcedure
            };

            string carnet = Textcarnet.Text;
            int converCarnent = int.Parse(carnet);

            cmd.Connection.Open();
            cmd.Parameters.Add("@paramCarnet", SqlDbType.Int).Value = converCarnent;

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string getCarnent = dr[0].ToString();
                string getNombre = dr[1].ToString();
                string getDireccion = dr[2].ToString();

                showCarnetTable.Text = getCarnent;
                showNombreTable.Text = getNombre;
                showDireccionTable.Text = getDireccion;
            }
        }

        protected void Btngeneral_click(Object sender, EventArgs e)
        {
            // metodo para seleccionar todos los usuarios de la db //
            string connection = ConfigurationManager.ConnectionStrings["connectionDB"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand("SP_ConsultaGeneral", sqlConnection)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dr.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}