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
using System.Data;
using System.Data.SqlClient;
using Capa_Entidad;
using Capa_Datos;

namespace WindowsFormsApp1
{

    public partial class Articulos : Form
    {
        D_Users Objd = new D_Users();
        public Articulos()
        {
            InitializeComponent();
        }

        int costo, cantidad, costos;

        private void Articulos_Load(object sender, EventArgs e)
        {

            Conexion.Conectar();
            dataGridView1.DataSource = Llenado();
            Listar_provedores();
            Listar_departamentos();
            //admin
            LlbUsuario.Text = Login.usuario_nombre;
            if (Login.area == "A0001")

            {


                LblCargo.Text = "Administrador";
            }

            //Ventas
            else if (Login.area == "A0002")

            {


                LblCargo.Text = "Almacenista";
            }
            //Compras
            else if (Login.area == "A0003")

            {


                LblCargo.Text = "Gerente Almacenista";
            }
            if (Login.area == "A0004")
            {
                LblCargo.Text = "Invitado";
                agregarToolStripMenuItem.Enabled = false;
                eliminiarToolStripMenuItem.Enabled = false;
                modificarToolStripMenuItem.Enabled = false;
            }
            LlbUsuario.Text = Login.usuario_nombre;


            dataGridView1.DataSource = Llenado();

        }

        public DataTable Llenado()
        {
            Conexion.Conectar();
            DataTable Dt = new DataTable();
            string consulta = "SELECT* FROM PRODUCTOS1";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(Dt);
            return Dt;
        }

        public DataTable consulta2()
        {
            int suma = Convert.ToInt32(TxtC_Producto.Text);
            DataTable Dt = new DataTable();
            string consulta = "select sum(COSTO_PRODUCTOS*CANTIDAD) from PRODUCTOS where N_PRODUCTO =@N_PRODUCTO";
            SqlCommand cm = new SqlCommand(consulta, Conexion.Conectar());
            cm.Parameters.AddWithValue("@N_PRODUCTO", TxtN_Producto.Text);
            cm.Parameters.AddWithValue("@COSTO_PRODUCTOS", costo);
            cm.Parameters.AddWithValue("@CANTIDAD", cantidad);
            SqlDataAdapter DA = new SqlDataAdapter(cm);
            DA.Fill(Dt);
            return Dt;

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                TxtN_Producto.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Txt_ID_Articulo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TxtN_Departamento.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBox1.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                TxtC_Producto.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Txt_Cantidad.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();


                Conexion.Conectar();
                DataTable dt = new DataTable();
                DateTime Hoy = DateTime.Now;



                if (dateTimePicker1.Value.CompareTo(Hoy) <= 0)
                {
                    Caducidad.Text = "Producto caducado";
                    agregarToolStripMenuItem.Enabled = false;
                    modificarToolStripMenuItem.Enabled = false;

                }
                else
                {
                    Hoy = Hoy.AddDays(-dateTimePicker1.Value.Day);
                    Caducidad.Text = "Quedan " + Hoy.Month + "dias de uso";
                    agregarToolStripMenuItem.Enabled = true;
                    modificarToolStripMenuItem.Enabled = true;
                }
                costo = Convert.ToInt32(TxtC_Producto.Text);
                cantidad = Convert.ToInt32(Txt_Cantidad.Text);
                costos = costo * cantidad;


                label4.Text = costos.ToString();
            }
            catch (Exception)
            {



            }
        }


        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int costo = Convert.ToInt32(TxtC_Producto.Text);
            int cantidad = Convert.ToInt32(Txt_Cantidad.Text);
            Conexion.Conectar();
            
            SqlCommand CMD = new SqlCommand("sp_insertar_articulos1", Conexion.Conectar());
            CMD.CommandType = CommandType.StoredProcedure;
            CMD.Parameters.AddWithValue("@N_PRODUCTO", TxtN_Producto.Text);
            CMD.Parameters.AddWithValue("@CODIGO_ARTICULO", Txt_ID_Articulo.Text);
            CMD.Parameters.AddWithValue("@NOM_DEPARTAMENTO", comboBox2.SelectedValue);
            CMD.Parameters.AddWithValue("@PROVEDOR", comboBox1.SelectedValue);
            CMD.Parameters.AddWithValue("@COSTO_PRODUCTOS", costo);
            CMD.Parameters.AddWithValue("@CANTIDAD", cantidad);
            CMD.Parameters.AddWithValue("@CADUCIDAD", dateTimePicker1.Value);
            CMD.ExecuteNonQuery();
            int costos = costo * cantidad;
            SqlCommand cmd = new SqlCommand("SP_Bitacoras" + "", Conexion.Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@1", TxtN_Departamento.Text);
            cmd.Parameters.AddWithValue("@2", LlbUsuario.Text);
            cmd.Parameters.AddWithValue("@3", "Registro producto");
            cmd.Parameters.AddWithValue("@4", TxtN_Producto.Text);
            cmd.Parameters.AddWithValue("@5", dateTimePicker1.Value);
            cmd.ExecuteNonQuery();

            label4.Text = costos.ToString();

            MessageBox.Show("Insertado");
            if (MessageBox.Show("Desea imprimir ticket?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Impresion");
                Factura.CreaTicket Ticket1 = new Factura.CreaTicket();

                Ticket1.TextoCentro("Empresa xxxxx "); //imprime una linea de descripcion
                Ticket1.TextoCentro("**********************************");

                Ticket1.TextoIzquierda("");
                Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
                Ticket1.TextoIzquierda("No Fac: 0120102");
                Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                Ticket1.TextoIzquierda("Usuario: " + LlbUsuario.Text);
                Ticket1.TextoIzquierda("");
                Factura.CreaTicket.LineasGuion();

                Factura.CreaTicket.EncabezadoVenta();
                Factura.CreaTicket.LineasGuion();
                // PROD                                   //PrECIO                              CANT                                          TOTAL
                Ticket1.AgregaArticulo(TxtN_Producto.Text, double.Parse(TxtC_Producto.Text.ToString()), int.Parse(Txt_Cantidad.Text.ToString()), double.Parse(label4.Text.ToString())); //imprime una linea de descripcion

                Factura.CreaTicket.LineasGuion();
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Total", int.Parse(label4.Text)); // imprime linea con total
                Ticket1.TextoIzquierda(" ");



                // Ticket1.LineasTotales(); // imprime linea 

                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoCentro("*     Gracias por preferirnos    *");

                Ticket1.TextoCentro("**********************************");
                Ticket1.TextoIzquierda(" ");
                string impresora = "Microsoft XPS Document Writer";
                Ticket1.ImprimirTiket(impresora);

                MessageBox.Show("Gracias por preferirnos");

                this.Close();
            }

            dataGridView1.DataSource = Llenado();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int costoss = Convert.ToInt32(TxtC_Producto.Text);
            int cantidadess = Convert.ToInt32(Txt_Cantidad.Text);
            Conexion.Conectar();
            string modificar = "UPDATE PRODUCTOS SET N_PRODUCTO=@N_PRODUCTO,NOM_DEPARTAMENTO=@NOM_DEPARTAMENTO,PROVEDOR=@PROVEDOR,COSTO_PRODUCTOS=@COSTO_PRODUCTOS,CANTIDAD=@CANTIDAD,CADUCIDAD=@CADUCIDAD WHERE N_PRODUCTO=@N_PRODUCTO";
            SqlCommand cmd = new SqlCommand("sp_modificar_articulos1", Conexion.Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@N_PRODUCTO", TxtN_Producto.Text);
            cmd.Parameters.AddWithValue("@CODIGO_ARTICULO", Txt_ID_Articulo.Text);
            cmd.Parameters.AddWithValue("@NOM_DEPARTAMENTO", comboBox2.SelectedValue);
            cmd.Parameters.AddWithValue("@PROVEDOR", comboBox1.SelectedValue);
            cmd.Parameters.AddWithValue("@COSTO_PRODUCTOS", costoss);
            cmd.Parameters.AddWithValue("@CANTIDAD", cantidadess);
            cmd.Parameters.AddWithValue("@CADUCIDAD", dateTimePicker1.Value);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("SP_Bitacoras2" + "", Conexion.Conectar());
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@1", TxtN_Departamento.Text);
            cmd1.Parameters.AddWithValue("@2", LlbUsuario.Text);
            cmd1.Parameters.AddWithValue("@3", "Modificar producto");
            cmd1.Parameters.AddWithValue("@4", TxtC_Producto.Text);
            cmd1.Parameters.AddWithValue("@5", dateTimePicker1.Value);
            cmd1.ExecuteNonQuery();
            int costos = costoss * cantidadess;
            label4.Text = costos.ToString();
            MessageBox.Show("Datos Modificados");
            dataGridView1.DataSource = Llenado();
        }

        private void eliminiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string eliminar = "DELETE FROM PRODUCTOS WHERE N_PRODUCTO=@N_PRODUCTO";
            SqlCommand cmd = new SqlCommand("sp_eliminar_articulos1", Conexion.Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CODIGO_ARTICULO", Txt_ID_Articulo.Text);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand("SP_Bitacoras2" + "", Conexion.Conectar());
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@1", TxtN_Departamento.Text);
            cmd1.Parameters.AddWithValue("@2", LlbUsuario.Text);
            cmd1.Parameters.AddWithValue("@3", "Eliminar producto");
            cmd1.Parameters.AddWithValue("@4", TxtC_Producto.Text);
            cmd1.Parameters.AddWithValue("@5", dateTimePicker1.Value);
            cmd1.ExecuteNonQuery();
            dataGridView1.DataSource = Llenado();
        }

        private void LblUs_Click(object sender, EventArgs e)
        {

        }

        private void btnbarra_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw codigodebarra = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            imgbarra.Image = codigodebarra.Draw(Txt_ID_Articulo.Text, 10);

            var imagentemporal = codigodebarra.Draw(Txt_ID_Articulo.Text, 40);
            var imagenconcodigo = new Bitmap(imagentemporal.Width, imagentemporal.Height + 20);

            var x = imagenconcodigo.Width / 2;
            var y = imagenconcodigo.Height;

            using (var vargrafico = Graphics.FromImage(imagenconcodigo))
            using (var varformato = new StringFormat()
            { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Far })
            {
                vargrafico.Clear(Color.White);
                vargrafico.DrawImage(imagentemporal, 2, 2);
                vargrafico.DrawString(Txt_ID_Articulo.Text, new Font("", 10), new SolidBrush(Color.Black), x, y, varformato);
            }

            imgbarra.Image = imagenconcodigo;
        }

        private void btnguardarbarra_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "JPEG|*.jpeg";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string varimg = saveFileDialog1.FileName;
                Bitmap varbmp = new Bitmap(imgbarra.Image);
                varbmp.Save(varimg, ImageFormat.Jpeg);
            }
        }

        private void Listar_provedores()
        {
            Departamentos dp = new Departamentos();
            comboBox1.DataSource = Objd.D_listar_provedores();
            comboBox1.DisplayMember = "NOM_PROVEDOR";
            comboBox1.ValueMember = "NOM_PROVEDOR";


        }

        private void Listar_departamentos()
        {
            Departamentos dp = new Departamentos();
            comboBox2.DataSource = Objd.D_lista_departamentos();
            comboBox2.DisplayMember = "NOM_DEPARTAMENTO";
            comboBox2.ValueMember = "NOM_DEPARTAMENTO";
        }
    }
}
