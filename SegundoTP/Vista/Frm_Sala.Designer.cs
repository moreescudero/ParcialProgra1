﻿namespace Vista
{
    partial class Frm_Sala
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Comenzar = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.lbl_Jugador2 = new System.Windows.Forms.Label();
            this.lbl_Jugador1 = new System.Windows.Forms.Label();
            this.lbl_CartasJugador2 = new System.Windows.Forms.Label();
            this.lbl_CartasJugador1 = new System.Windows.Forms.Label();
            this.tmr_Partida = new System.Windows.Forms.Timer(this.components);
            this.lbl_Ganador = new System.Windows.Forms.Label();
            this.lbl_PuntosJug1 = new System.Windows.Forms.Label();
            this.lbl_PuntosJug2 = new System.Windows.Forms.Label();
            this.lbl_ChatJug1 = new System.Windows.Forms.Label();
            this.lbl_ChatJug2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Comenzar
            // 
            this.btn_Comenzar.Location = new System.Drawing.Point(460, 402);
            this.btn_Comenzar.Name = "btn_Comenzar";
            this.btn_Comenzar.Size = new System.Drawing.Size(75, 23);
            this.btn_Comenzar.TabIndex = 0;
            this.btn_Comenzar.Text = "Comenzar";
            this.btn_Comenzar.UseVisualStyleBackColor = true;
            this.btn_Comenzar.Click += new System.EventHandler(this.btn_Comenzar_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(328, 402);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 23);
            this.btn_Volver.TabIndex = 1;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // lbl_Jugador2
            // 
            this.lbl_Jugador2.AutoSize = true;
            this.lbl_Jugador2.Location = new System.Drawing.Point(132, 50);
            this.lbl_Jugador2.Name = "lbl_Jugador2";
            this.lbl_Jugador2.Size = new System.Drawing.Size(61, 15);
            this.lbl_Jugador2.TabIndex = 2;
            this.lbl_Jugador2.Text = "Jugador 2:";
            // 
            // lbl_Jugador1
            // 
            this.lbl_Jugador1.AutoSize = true;
            this.lbl_Jugador1.Location = new System.Drawing.Point(133, 334);
            this.lbl_Jugador1.Name = "lbl_Jugador1";
            this.lbl_Jugador1.Size = new System.Drawing.Size(61, 15);
            this.lbl_Jugador1.TabIndex = 3;
            this.lbl_Jugador1.Text = "Jugador 1:";
            // 
            // lbl_CartasJugador2
            // 
            this.lbl_CartasJugador2.AutoSize = true;
            this.lbl_CartasJugador2.Location = new System.Drawing.Point(311, 116);
            this.lbl_CartasJugador2.Name = "lbl_CartasJugador2";
            this.lbl_CartasJugador2.Size = new System.Drawing.Size(0, 15);
            this.lbl_CartasJugador2.TabIndex = 4;
            // 
            // lbl_CartasJugador1
            // 
            this.lbl_CartasJugador1.AutoSize = true;
            this.lbl_CartasJugador1.Location = new System.Drawing.Point(311, 217);
            this.lbl_CartasJugador1.Name = "lbl_CartasJugador1";
            this.lbl_CartasJugador1.Size = new System.Drawing.Size(0, 15);
            this.lbl_CartasJugador1.TabIndex = 5;
            // 
            // tmr_Partida
            // 
            this.tmr_Partida.Interval = 1000;
            this.tmr_Partida.Tick += new System.EventHandler(this.tmr_Partida_Tick);
            // 
            // lbl_Ganador
            // 
            this.lbl_Ganador.AutoSize = true;
            this.lbl_Ganador.Location = new System.Drawing.Point(549, 166);
            this.lbl_Ganador.Name = "lbl_Ganador";
            this.lbl_Ganador.Size = new System.Drawing.Size(38, 15);
            this.lbl_Ganador.TabIndex = 6;
            this.lbl_Ganador.Text = "label1";
            // 
            // lbl_PuntosJug1
            // 
            this.lbl_PuntosJug1.AutoSize = true;
            this.lbl_PuntosJug1.Location = new System.Drawing.Point(549, 290);
            this.lbl_PuntosJug1.Name = "lbl_PuntosJug1";
            this.lbl_PuntosJug1.Size = new System.Drawing.Size(38, 15);
            this.lbl_PuntosJug1.TabIndex = 7;
            this.lbl_PuntosJug1.Text = "label1";
            // 
            // lbl_PuntosJug2
            // 
            this.lbl_PuntosJug2.AutoSize = true;
            this.lbl_PuntosJug2.Location = new System.Drawing.Point(549, 50);
            this.lbl_PuntosJug2.Name = "lbl_PuntosJug2";
            this.lbl_PuntosJug2.Size = new System.Drawing.Size(38, 15);
            this.lbl_PuntosJug2.TabIndex = 8;
            this.lbl_PuntosJug2.Text = "label1";
            // 
            // lbl_ChatJug1
            // 
            this.lbl_ChatJug1.AutoSize = true;
            this.lbl_ChatJug1.Location = new System.Drawing.Point(70, 257);
            this.lbl_ChatJug1.Name = "lbl_ChatJug1";
            this.lbl_ChatJug1.Size = new System.Drawing.Size(0, 15);
            this.lbl_ChatJug1.TabIndex = 9;
            // 
            // lbl_ChatJug2
            // 
            this.lbl_ChatJug2.AutoSize = true;
            this.lbl_ChatJug2.Location = new System.Drawing.Point(70, 97);
            this.lbl_ChatJug2.Name = "lbl_ChatJug2";
            this.lbl_ChatJug2.Size = new System.Drawing.Size(0, 15);
            this.lbl_ChatJug2.TabIndex = 10;
            // 
            // Frm_Sala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_ChatJug2);
            this.Controls.Add(this.lbl_ChatJug1);
            this.Controls.Add(this.lbl_PuntosJug2);
            this.Controls.Add(this.lbl_PuntosJug1);
            this.Controls.Add(this.lbl_Ganador);
            this.Controls.Add(this.lbl_CartasJugador1);
            this.Controls.Add(this.lbl_CartasJugador2);
            this.Controls.Add(this.lbl_Jugador1);
            this.Controls.Add(this.lbl_Jugador2);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Comenzar);
            this.Name = "Frm_Sala";
            this.Text = "Sala";
            this.Load += new System.EventHandler(this.Frm_Sala_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Comenzar;
        private Button btn_Volver;
        private Label lbl_Jugador2;
        private Label lbl_Jugador1;
        private Label lbl_CartasJugador2;
        private Label lbl_CartasJugador1;
        private System.Windows.Forms.Timer tmr_Partida;
        private Label lbl_Ganador;
        private Label lbl_PuntosJug1;
        private Label lbl_PuntosJug2;
        private Label lbl_ChatJug1;
        private Label lbl_ChatJug2;
    }
}