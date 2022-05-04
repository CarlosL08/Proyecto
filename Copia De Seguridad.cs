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
    public partial class Copia_De_Seguridad : Form
    {
        public Copia_De_Seguridad()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("SERVER=PC23-5E; DATABASE=PROYECTO_1");
        private void Btngenerar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_copias", Conexion.Conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                MessageBox.Show("correcto");
            }
            catch (Exception E)
            {
                MessageBox.Show(""+E);
            }
            
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = "USE [master]RESTORE DATABASE [PROYECTO] FROM  DISK = N'C:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS\\MSSQL\\Backup\\Copia_Seg' WITH  FILE = 2,  NOUNLOAD,  STATS = 5";
                SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());
                //cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                MessageBox.Show("correcto");

            }
            catch (Exception E)
            {
                MessageBox.Show("" + E);
            }


        }

        private void Copia_De_Seguridad_Load(object sender, EventArgs e)
        {

        }
    }
}
