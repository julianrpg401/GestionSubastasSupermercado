﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSubastasSupermercado
{
    internal class Espectador : Usuario
    {
        public Espectador(string nombre) : base(nombre)
        {
        }

        public override void RealizarOferta(double oferta)
        {

        }
    }
}