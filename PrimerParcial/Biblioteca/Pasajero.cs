﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Pasajero : Persona
    {
        int edad;
        int dni;
        float equipaje;
        string clase;
        string menuElegido;
        float precioBoleto;
        bool bolsoMano;
        int cantidadDeVuelos; 

        public Pasajero(string nombre, string apellido, int edad, int dni, float equipaje, string clase, string menuElegido, float precioBoleto, bool bolsoMano) : base(nombre, apellido)
        {
            this.edad = edad;
            this.dni = dni;
            this.equipaje = equipaje;
            this.clase = clase;
            this.menuElegido = menuElegido;
            this.precioBoleto = precioBoleto;
            this.bolsoMano = bolsoMano;
        }

        public string Clase
        {
            get { return clase; }
        }

        public int Edad
        {
            get { return edad; }
        }

        public int Dni
        {
            get { return dni; }
        }

        public string MenuElegido
        {
            get { return menuElegido; }
        }

        public float Equipaje
        {
            get { return equipaje; }
        }

        public float PrecioBoleto
        {
            get { return precioBoleto; }
            set { precioBoleto = value; }
        }

        public bool BolsoMano
        {
            get { return bolsoMano; }
        }

        public int CantidadDeVuelos
        {
            get { return cantidadDeVuelos; }
            set { cantidadDeVuelos = value; }
        }

        public override bool Equals(object? obj)
        {
            Pasajero pasajero = obj as Pasajero;
            if(pasajero is not null)
            {
                return this.dni == pasajero.Dni;
            }
            return false;
        }

        public override string ToString()
        {
            return "Nombre completo: " + this.nombre + " " + this.apellido + "  Cantidad de vuelos: " + this.cantidadDeVuelos + "\n";
        }

        public static float CalcularPrecio(bool esNacional, int duracion, string clase)
        {
            float precioHora;

            if (esNacional)
            {
                precioHora = 50f;
            }
            else
            {
                precioHora = 100f;
            }
            if (clase == "Premium")
            {
                precioHora *= 1.15f;
            }
            if(duracion > 0)
                precioHora *= duracion;

            return precioHora;
        }

    }
}
