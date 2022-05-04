using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Capa_Entidad;
using Capa_Datos;

namespace WindowsFormsApp1
{
    public partial class Departamentos : Form
    {

        D_Users Objd = new D_Users();
        public Departamentos()
        {
            InitializeComponent();
        }



        private void Departamentos_Load(object sender, EventArgs e)
        {

            Conexion.Conectar();
            dataGridView1.DataSource = Llenado();
            Llenado();
            //admin
            label8.Text = Login.usuario_nombre;
            if (Login.area == "A0001")

            {


                label7.Text = "Administrador";
            }

            //Ventas
            else if (Login.area == "A0002")

            {


                label7.Text = "Almacenista";
            }
            //Compras
            else if (Login.area == "A0003")

            {
                label7.Text = "Gerente Almacenista";
            }
            if (Login.area == "A0004")
            {
                label7.Text = "Invitado";
                agregarToolStripMenuItem.Enabled = false;
                eliminarToolStripMenuItem.Enabled = false;
                modificarToolStripMenuItem.Enabled = false;

            }


            Llenado();
        }

        public DataTable Llenado()
        {
            Conexion.Conectar();
            DataTable Dt = new DataTable();
            SqlCommand com = new SqlCommand("sp_listar_departamentos", Conexion.Conectar());
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(Dt);
            return Dt;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Txt_Codigo_DEPARTAMENTO.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                TxtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TxtManejo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                TxtRefrigeracion.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                

            }
            catch (Exception)
            {

                throw;
            }
            //TxtNombre.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //TxtCapacidad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //comboBox1.SelectedValue= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //TxtCapacidad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int manejo = Convert.ToInt32(TxtManejo.Text);
            Conexion.Conectar();
            SqlCommand com = new SqlCommand("sp_insertar_departamentos", Conexion.Conectar());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@NOM_DEPARTAMENTO", TxtNombre.Text);
            com.Parameters.AddWithValue("@REFRIGERACION", TxtRefrigeracion.Text);
            com.Parameters.AddWithValue("@COSTO_MANEJO",TxtManejo.Text);
            com.Parameters.AddWithValue("@CODIGO_DEPARTAMENTO",Txt_Codigo_DEPARTAMENTO.Text);
            com.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dataGridView1.DataSource = Llenado();

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int manejo = Convert.ToInt32(TxtManejo.Text);
            Conexion.Conectar();
            SqlCommand com = new SqlCommand("sp_modificar_departamentos", Conexion.Conectar());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@NOM_DEPARTAMENTO", TxtNombre.Text);
            com.Parameters.AddWithValue("@REFRIGERACION", TxtRefrigeracion.Text);
            com.Parameters.AddWithValue("@COSTO_MANEJO", TxtManejo.Text);
            com.Parameters.AddWithValue("@CODIGO_DEPARTAMENTO", Txt_Codigo_DEPARTAMENTO.Text);
            com.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dataGridView1.DataSource = Llenado();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Conexion.Conectar();
            SqlCommand com = new SqlCommand("sp_eliminar_departamentos1", Conexion.Conectar());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@NOM_DEPARTAMENTO", TxtNombre.Text);
            com.Parameters.AddWithValue("@REFRIGERACION", TxtRefrigeracion.Text);
            com.Parameters.AddWithValue("@COSTO_MANEJO", TxtManejo.Text);
            com.Parameters.AddWithValue("@CODIGO_DEPARTAMENTO", Txt_Codigo_DEPARTAMENTO.Text);
            com.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            dataGridView1.DataSource = Llenado();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtManejo.Text = "";
            TxtNombre.Text = "";
            TxtRefrigeracion.Text = "";
            Txt_Codigo_DEPARTAMENTO.Text = "";
        }

        private void TxtManejo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
