﻿using Biblioteca;
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
    public partial class frm_EstadisticasHistoricas : Form
    {
        public frm_EstadisticasHistoricas()
        {
            InitializeComponent();
        }

        private void frm_EstadisticasHistoricas_Load(object sender, EventArgs e)
        {
            dgv_VuelosHistoricos.DataSource = null;
            dgv_VuelosHistoricos.DataSource = Aerolinea.listaVuelosFinalizados;

            cmb_Opciones.Items.Add("Recaudaciones");
            cmb_Opciones.Items.Add("Pasajeros totales");
            cmb_Opciones.Items.Add("Destinos por facturación");
            cmb_Opciones.Items.Add("Pasajeros frecuentes por cantidad de vuelos");
            cmb_Opciones.Items.Add("Horas de vuelo de cada avión");
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_VerEstadisticas_Click(object sender, EventArgs e)
        {
            pnl_VerEstadisticas.Visible = true;
            
        }

        private void btn_CerrarPanel_Click(object sender, EventArgs e)
        {
            pnl_VerEstadisticas.Visible = false;
        }

        private void MostrarRecaudaciones()
        {
            lbl_DestinoMasElegido.Visible = true;
            lbl_GananciasInternacionales.Visible = true;
            lbl_GananciasNacionales.Visible = true;
            lbl_RecaudacionTotal.Visible = true;
            txt_DestinoMasElegido.Visible = true;
            txt_GananciasInternacionales.Visible = true;
            txt_GananciasNacionales.Visible = true;
            txt_RecaudacionTotal.Visible = true;
            dgv_SegunOpcionElegida.Visible = false;
        }

        private void OcultarTodo()
        {
            lbl_DestinoMasElegido.Visible = false;
            lbl_GananciasInternacionales.Visible = false;
            lbl_GananciasNacionales.Visible = false;
            lbl_RecaudacionTotal.Visible = false;
            txt_DestinoMasElegido.Visible = false;
            txt_GananciasInternacionales.Visible = false;
            txt_GananciasNacionales.Visible = false;
            txt_RecaudacionTotal.Visible = false;
        }

        private void CalcularRecaudaciones()
        {
            txt_RecaudacionTotal.Text = Aerolinea.CalcularRecaudacionTotal().ToString();
            txt_GananciasInternacionales.Text = Aerolinea.CalcularGanancia(false).ToString();
            txt_GananciasNacionales.Text = Aerolinea.CalcularGanancia(true).ToString();
            //txt_DestinoMasElegido.Text = Aerolinea.BuscarDestinoMasPopular();
        }

        private void cmb_Opciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_SegunOpcionElegida.DataSource = null;
            dgv_SegunOpcionElegida.Visible = true;
            OcultarTodo();
            switch (cmb_Opciones.SelectedIndex)
            {
                case 0:
                    MostrarRecaudaciones();
                    CalcularRecaudaciones();
                    break;
                case 1:
                    dgv_SegunOpcionElegida.DataSource = Aerolinea.listaPasajeros;
                    break;
                case 2:
                    //dgv_SegunOpcionElegida.DataSource = ;
                    break;
                case 3:
                    dgv_SegunOpcionElegida.DataSource = Aerolinea.listaPasajeros; //otra lista
                    break;
                default:
                    dgv_SegunOpcionElegida.DataSource = Aerolinea.listaAviones;
                    break;
            }
        }
    }
}
