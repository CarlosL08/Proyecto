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
using Capa_Negocio;

namespace WindowsFormsApp1
{
    public partial class Provedor : Form
    {
        E_Users Obje = new E_Users();
        N_Users objn = new N_Users();
        
        public Provedor()
        {
            InitializeComponent();
        }

        void mantenimiento(String accion)
        {
            int tam = Convert.ToInt32(TxtTamanoCredito.Text);
            Obje.CODIGO_PROVEDOR = TxtCodigo.Text;
            Obje.NOM_PROVEDOR = TxtNomP.Text;
            
            Obje.DIAS_DE_VISITA = TxtDias.Text;
            Obje.TAMANO_CREDITO = tam;
            Obje.ACCION = accion;

            String men = objn.MantenimentoP(Obje);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        void Limpiar()
        {
            
            TxtCodigo.Text = "";
            TxtDias.Text = "";
            TxtNomP.Text="";
            TxtTamanoCredito.Text = "";
            dataGridView1.DataSource = objn.ListarP();
        }

        private void Provedor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objn.ListarP();
            LlbUsuario.Text = Login.usuario_nombre;
            Label.Text = Login.area;

            LlbUsuario.Text = Login.usuario_nombre; ;
            Label.Text = Obje.id_areas;

            //admin
            LlbUsuario.Text = Login.usuario_nombre;
            if (Login.area == "A0001")

            {


                Label.Text = "Administrador";
            }

            //Ventas
            else if (Login.area == "A0002")

            {


                Label.Text = "Almacenista";
            }
            //Compras
            else if (Login.area == "A0003")

            {


                Label.Text = "Gerente Almacenista";
            }
            if (Login.area == "A0004")
            {
                Label.Text = "Invitado";
                nuevoToolStripMenuItem.Enabled = false;
                modificarToolStripMenuItem.Enabled = false;
                eliminarToolStripMenuItem.Enabled = false;
                registrarToolStripMenuItem.Enabled = false;
                
            }
            LlbUsuario.Text = Login.usuario_nombre;


        }


        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text != "")
            {
                if (MessageBox.Show("Desea elminar a " + TxtNomP.Text + " ?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("3");
                    SqlCommand cmd = new SqlCommand("SP_Bitacoras" + "", Conexion.Conectar());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@1", TxtCodigo);
                    cmd.Parameters.AddWithValue("@2", LlbUsuario.Text);
                    cmd.Parameters.AddWithValue("@3", "Eliminar provedor");
                    cmd.Parameters.AddWithValue("@4", TxtNomP.Text);
                    cmd.Parameters.AddWithValue("@5", dateTimePicker1.Value);
                    cmd.ExecuteNonQuery();
                    Limpiar();
                }
            }
        }

        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

       

        private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (TxtCodigo.Text != "")
            {
                if (MessageBox.Show("Desea elminar a " + TxtNomP.Text + " ?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("3");
                    SqlCommand cmd = new SqlCommand("SP_Bitacoras" + "", Conexion.Conectar());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@1", TxtCodigo);
                    cmd.Parameters.AddWithValue("@2", LlbUsuario.Text);
                    cmd.Parameters.AddWithValue("@3", "Eliminar provedor");
                    cmd.Parameters.AddWithValue("@4", TxtNomP.Text);
                    cmd.Parameters.AddWithValue("@5", dateTimePicker1.Value);
                    cmd.ExecuteNonQuery();

                    Limpiar();
                }
            }
        }

        private void modificarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (TxtCodigo.Text != "")
            {
                if (MessageBox.Show("Desea modificar a " + TxtNomP.Text + " ?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("2");
                    SqlCommand cmd = new SqlCommand("SP_Bitacoras" + "", Conexion.Conectar());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@1", TxtCodigo.Text);
                    cmd.Parameters.AddWithValue("@2", LlbUsuario.Text);
                    cmd.Parameters.AddWithValue("@3", "Modificar provedor");
                    cmd.Parameters.AddWithValue("@4", TxtNomP.Text);
                    cmd.Parameters.AddWithValue("@5", dateTimePicker1.Value);
                    cmd.ExecuteNonQuery();
                    Limpiar();
                }
            }
        }

        private void registrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (TxtCodigo.Text == "")
            {
                if (MessageBox.Show("Desea registrar a " + TxtNomP.Text + " ?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("1");
                    SqlCommand cmd = new SqlCommand("SP_Bitacoras" + "", Conexion.Conectar());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@1", TxtCodigo.Text);
                    cmd.Parameters.AddWithValue("@2", LlbUsuario.Text);
                    cmd.Parameters.AddWithValue("@3", "Registrar Provedor");
                    cmd.Parameters.AddWithValue("@4", TxtNomP.Text);
                    cmd.Parameters.AddWithValue("@5", dateTimePicker1.Value);
                    cmd.ExecuteNonQuery();
                    Limpiar();
                }
            }
        }

        private void nuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;
            
            TxtNomP.Text = dataGridView1[0, fila].Value.ToString();
            TxtCodigo.Text = dataGridView1[1, fila].Value.ToString();
            TxtDias.Text = dataGridView1[2, fila].Value.ToString();
           
            TxtTamanoCredito.Text = dataGridView1[3, fila].Value.ToString();
            DataTable dt = new DataTable();

            string hoy = TxtDias.Text;
            DateTime Hoy = DateTime.Today;
            Hoy.DayOfWeek.ToString();
            
            
            if (Hoy.ToString()== TxtDias.Text)
            {
                label7.Text = "Hoy llega el provedor";
            }
            else
            {
                label7.Text = "...";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
