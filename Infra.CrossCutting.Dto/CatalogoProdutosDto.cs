﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.CrossCutting.Dto
{
    public class CatalogoProdutosDto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string NomeFornecedor { get;  set; }
        public CategoriaDto Categoria { get; set; }
        public int CategoriaId { get;  set; }
        public int PrecoVenda { get;  set; }
    }
}
