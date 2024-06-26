﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entitidades
{
    public class CursosEntidade
    {
        public string Nome { get; set; }
        public string Area { get; set; }
        public string HorarioInicio { get; set; }
        public string HorarioFim { get; set; }
        public int Duracao { get; set; }
        public object[] Linha()
        {
            return new object[] { Nome, Area, HorarioInicio, HorarioFim, Duracao };
        }
        public bool IsFull()
        {
            if (Linha().Contains(null)) { return false; }
            else { return true; }
        }
    }
}
