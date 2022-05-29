﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;

namespace UI.Desktop
{
    public partial class formLogin : Form
    {
        public UsuarioLogic UsuarioLogico { get; set; }
        public formLogin()
        {
            InitializeComponent();
            UsuarioLogico = new UsuarioLogic();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //la propiedad Text de los TextBox contiene el texto escrito en ellos
            //if (this.txtUsuario.Text == "Admin" && this.txtPass.Text == "admin")
            if (UsuarioLogico.Ingreso(this.txtUsuario.Text, this.txtPass.Text))
            {
                //    MessageBox.Show("Usted ha ingresado al sistema correctamente."
                //    , "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Login"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkOlvidaPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Es Ud. un usuario muy descuidado, haga memoria", "Olvidé mi contraseña",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
