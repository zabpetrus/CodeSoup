using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSoup.Domain.Entites
{
    public class Carro: Veiculo
    {
        public int NumeroDePortas { get; set; }
        public bool TemArCondicionado { get; set; }
    }
}
