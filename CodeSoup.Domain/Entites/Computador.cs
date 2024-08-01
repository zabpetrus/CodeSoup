using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSoup.Domain.Entites
{
    public class Computador : Equipamento
    {
        public string Processador { get; set; }
        public int MemoriaRAM { get; set; }
    }
}
