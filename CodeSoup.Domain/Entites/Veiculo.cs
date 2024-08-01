using CodeSoup.Domain.Entites._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSoup.Domain.Entites
{
    //Exemplo TPT
    public abstract class Veiculo  : Entity
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
    }
}
