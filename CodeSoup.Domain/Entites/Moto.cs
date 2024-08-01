using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSoup.Domain.Entites
{
    public class Moto : Veiculo
    {
        public bool TemTopCase { get; set; }
        public string TipoDeSuspensao { get; set; }
    }
}
