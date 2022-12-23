using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_dotnet.Models;

    internal class Fornecedor: Pessoa
    {
        public string CNPJ { get; set; } = default!;
    }

