﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Entidad;
using Capa_Negocio;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {

        E_Users objeuser = new E_Users();
        N_Users objnuser = new N_Users();
        Principal frm1 = new Principal();

        public static string usuario_nombre;
        public static string area;


        void p_logueo()
        {

            DataTable dt = new DataTable();
            objeuser.usuario = comboBox1.SelectedValue.ToString();
            objeuser.clave = txtpass.Text;

            dt = objnuser.N_user(objeuser);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + dt.Rows[0][1].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nombre = dt.Rows[0][1].ToString();
                area = dt.Rows[0][0].ToString();

                frm1.ShowDialog();
                this.Close();

                Login login = new Login();
                login.ShowDialog();
                this.Close();

                if (login.DialogResult == DialogResult.OK)
                {
                    Application.Run(new Principal());
                    this.Close();
                }





            
                //txtusuario.Clear();
                txtpass.Clear();


            }
            else 
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }


        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Listar_usuarios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p_logueo();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            p_logueo();
        }

        private void Listar_usuarios()
        {
            Departamentos dp = new Departamentos();
            comboBox1.DataSource = objnuser.ListarU();
            comboBox1.DisplayMember = "usuario";
            comboBox1.ValueMember = "usuario";
        }
    }
}
