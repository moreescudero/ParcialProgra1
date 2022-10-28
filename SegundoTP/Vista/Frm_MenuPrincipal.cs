﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Frm_MenuPrincipal : Form
    {
        public Frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_AbirSala_Click(object sender, EventArgs e)
        {
            Partida partida = new Partida(Conexion.ObtenerUsuarios(), DateTime.Now);

            Frm_Sala frm_Sala = new Frm_Sala(partida);
            frm_Sala.ShowDialog();
        }
    }
}
