﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Estoque { get; set; }
        public float Valor { get; set; }
    }
}
