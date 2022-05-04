using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Datos;
using Capa_Entidad;
using Capa_Negocio;

namespace WindowsFormsApp1
{
    public partial class Principal : Form
    {
        D_Users objn = new D_Users();

        bool x = false;
        public Principal()
        {
            InitializeComponent();
        }


        private void Principal_Load(object sender, EventArgs e)
        {
         
            

            //admin
            if (Login.area == "A0001") 
            
            {
                btnceunta.Enabled = true;
                btnProductos.Enabled = true;
                btnprovedores.Enabled = true;

                lblCargo.Text = "Administrador";
            }

            //Ventas
            else if (Login.area == "A0002")

            {
                btnceunta.Enabled = false;
                btnProductos.Enabled = true;
                btnprovedores.Enabled = true;
                BtnDepartamentos.Enabled = false;

                lblCargo.Text = "Almacenista";
            }
            //Compras
            else if (Login.area == "A0003")

            {
                btnceunta.Enabled = true;
                btnProductos.Enabled = true;
                btnprovedores.Enabled = true;
                BtnDepartamentos.Enabled = true;

                lblCargo.Text = "Compras";
            }
            if (Login.usuario_nombre=="CARLOS SALINAS")
            {
                label5.Text = "El mejor presidente que tuvo mexico jajaj";
            }

            if (Login.area=="A0004")
            {
                lblCargo.Text = "Invitado";
                btnceunta.Enabled = true;
                btnProductos.Enabled = true;
                btnprovedores.Enabled = true;
                BtnDepartamentos.Enabled = true;
            }

            lblnombre.Text = Login.usuario_nombre;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            Articulos art = new Articulos();
            art.Show();
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            Provedor pro = new Provedor();
            pro.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnalmacen_Click(object sender, EventArgs e)
        {
            Cuentas Cue = new Cuentas();
            Cue.Show();
        }

        private void BtnDepartamentos_Click(object sender, EventArgs e)
        {
            Departamentos dep = new Departamentos();
            dep.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button65_Click(object sender, EventArgs e)
        {
            

        }

        private void lblCargo_Click(object sender, EventArgs e)
        {

        }

        private void lblfecha_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora();
            bitacora.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form seguridad = new Copia_De_Seguridad();
            //seguridad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Login lo = new Login();
            lo.ShowDialog();
            this.Close();

        }
    }
}
