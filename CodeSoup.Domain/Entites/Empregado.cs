using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSoup.Domain.Entites
{
    public class Empregado : Funcionario
    {
        public string Departamento { get; set; }
        public double Salario { get; set; }
    }
}
