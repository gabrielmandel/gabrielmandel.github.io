﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPubli.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public int CodigoCliente { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string DataInclusao { get; set; }
    }
}
