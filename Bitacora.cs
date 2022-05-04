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
namespace WindowsFormsApp1
{
    public partial class Bitacora : Form
    {
        public Bitacora()
        {
            InitializeComponent();
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Llenado();
        }

        public DataTable Llenado()
        {
            SqlCommand cmd = new SqlCommand("SP_Visualizar_Bi", Conexion.Conectar());
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            DataTable Dt = new DataTable();
            Da.Fill(Dt);
            return Dt;
        }
    }
}
