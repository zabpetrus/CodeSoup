using CodeSoup.Domain.Entites._Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSoup.Domain.Entites
{
    //Exemplo TPH
    public abstract class Funcionario : Entity
    {
        public string Nome { get; set; }
        public string TipoFuncionario { get; set; } // Coluna discriminadora
    }
}
