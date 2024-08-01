using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSoup.Domain.Entites
{
    public class Impressora : Equipamento
    {
        public bool EMultifuncional { get; set; }
        public string TipoDeImpressao { get; set; }
    }
}
