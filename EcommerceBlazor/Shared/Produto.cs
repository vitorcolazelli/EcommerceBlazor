﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceBlazor.Shared
{
    public class Produto
    {
        public int Produto_ID { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string UrlImagem { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }
        public Categoria? Categoria { get; set; }
        public int CategoriaId { get; set; }
    }
}
