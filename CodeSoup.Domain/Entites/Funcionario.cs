using CodeSoup.Domain.Entites._Base;
using CodeSoup.Domain.Enums;
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
        public TipoFuncionario TipoFuncionario { get; set; } // Coluna discriminadora
    }
}
