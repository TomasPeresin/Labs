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
    public partial class formListaUsuarios : Form
    {
        public formListaUsuarios()
        {
            InitializeComponent();
            this.oUsuarios = new UsuarioLogic();
            DataTable s = oUsuarios.GetAll();
            this.dgvUsuarios.DataSource = s;
        }

        public UsuarioLogic oUsuarios { get; set; }
    }
}
