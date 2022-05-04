using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Capa_Entidad;
using Capa_Negocio;
namespace WindowsFormsApp1
{
    public partial class Cuentas : Form
    {

        E_Users Obje = new E_Users();
        N_Users objn = new N_Users();
        public string ruta, path;

        public Cuentas()
        {
            InitializeComponent();
        }

        void Mantenimiento(String accions)
        {
            label7.Text = cmb_ID_Area.Text;
            string Area = cmb_ID_Area.ToString();
            Obje.id_areas = label7.Text;
            Obje.nombres = Txt_Nombre.Text;
            Obje.usuarioss = Txt_Usuario.Text;
            Obje.contrasenas = TxtContraseña.Text;
            Obje.id_empleados = Txt_ID_Empleado.Text;
            Obje.ACCIONN = accions;

            String men = objn.N_Mantenimiento_U(Obje);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void limpiar()
        {
            TxtContraseña.Text = "";
            Txt_Area.Text = "";
            Txt_ID_Empleado.Text = "";
            Txt_Nombre.Text = "";
            Txt_Usuario.Text = "";

            dataGridView1.DataSource = objn.ListarU();
        }

        private void Cuentas_Load(object sender, EventArgs e)
        {
            Us.Text = Login.usuario_nombre;
            if (Login.area == "A0001")

            {


                Car.Text = "Administrador";
            }

            
            else if (Login.area == "A0002")

            {


                Car.Text = "Almacenista";
            }
            
            else if (Login.area == "A0003")

            {


                Car.Text = "Gerente Almacenista";
            }
            if (Login.area == "A0004")
            {
                Car.Text = "Invitado";

            }
            Car.Text = Login.usuario_nombre;

            dataGridView1.DataSource = objn.ListarU();
            if (Login.area=="A0003")
            {
                Us.Text = Login.usuario_nombre;
                Car.Text = Login.usuario_nombre;
                eliminarToolStripMenuItem.Enabled = false;
            }

            if (Login.area == "A0004")
            {
                Us.Text = Login.usuario_nombre;
                Car.Text = Login.usuario_nombre;
                registrarToolStripMenuItem.Enabled = false;
                modificarToolStripMenuItem.Enabled = false;
                eliminarToolStripMenuItem.Enabled = false;
                nuevoToolStripMenuItem.Enabled = false;
            }
            
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Txt_ID_Empleado.Text == "")
            {
                if (MessageBox.Show("Desea registrar a " + Txt_Nombre.Text + " ?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    textBox1.Text = DateTime.Now.ToString("dd-MM-yyyy");
                    string fecha = textBox1.Text;
                    Mantenimiento("1");
                    SqlCommand cmd = new SqlCommand("SP_Bitacoras" + "", Conexion.Conectar()) ;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@1", Txt_ID_Empleado.Text);
                    cmd.Parameters.AddWithValue("@2", Us.Text);
                    cmd.Parameters.AddWithValue("@3", "Registro usuario");
                    cmd.Parameters.AddWithValue("@4", Txt_Nombre.Text);
                    cmd.Parameters.AddWithValue("@5", dateTimePicker1.Value);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    limpiar();
                    
                }
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Txt_ID_Empleado.Text != "")
            {
                if (MessageBox.Show("Desea modificar a " + Txt_Nombre.Text + " ?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Mantenimiento("2");
                    SqlCommand cmd = new SqlCommand("SP_Bitacoras" + "", Conexion.Conectar());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@1", Txt_ID_Empleado.Text);
                    cmd.Parameters.AddWithValue("@2", Us.Text);
                    cmd.Parameters.AddWithValue("@3", "Modificar usuario");
                    cmd.Parameters.AddWithValue("@4", Txt_Nombre.Text);
                    cmd.Parameters.AddWithValue("@5", dateTimePicker1.Value);
                    cmd.ExecuteNonQuery();

                    limpiar();
                }
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Txt_ID_Empleado.Text != "")
            {
                if (MessageBox.Show("Desea modificar a " + Txt_Nombre.Text + " ?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Mantenimiento("3");
                    SqlCommand cmd = new SqlCommand("SP_Bitacoras" + "", Conexion.Conectar());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@1", Txt_ID_Empleado.Text);
                    cmd.Parameters.AddWithValue("@2", Us.Text);
                    cmd.Parameters.AddWithValue("@3", "Eliminar usuario");
                    cmd.Parameters.AddWithValue("@4", Txt_Nombre.Text);
                    cmd.Parameters.AddWithValue("@5", dateTimePicker1.Value);
                    cmd.ExecuteNonQuery();

                    limpiar();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            Txt_Area.Text = dataGridView1[0, fila].Value.ToString();
            Txt_ID_Empleado.Text = dataGridView1[1, fila].Value.ToString();
            Txt_Nombre.Text = dataGridView1[2, fila].Value.ToString();
            Txt_Usuario.Text = dataGridView1[3, fila].Value.ToString();
            TxtContraseña.Text = dataGridView1[4, fila].Value.ToString();
        }

        private void Txt_Area_TextChanged(object sender, EventArgs e)
        {

        }

        private void btFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                pbFoto.Image = Image.FromFile(ruta);
                pbFoto.Image.Save(Application.StartupPath + ("\\Usuarios\\") + Txt_Nombre.Text + ".jpg", ImageFormat.Jpeg);
                this.ruta = openFileDialog1.FileName;
            }
        }
    }
}
