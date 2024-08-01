using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSoup.Domain.Entites
{
    public class Freelancer : Funcionario
    {
        public double TarifaPorHora { get; set; }
        public string ProjetoAtual { get; set; }
    }
}
