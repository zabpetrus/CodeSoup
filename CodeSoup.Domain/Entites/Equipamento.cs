using CodeSoup.Domain.Entites._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSoup.Domain.Entites
{
    //Exemplo TPC
    public abstract class Equipamento : Entity
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
    }
}
