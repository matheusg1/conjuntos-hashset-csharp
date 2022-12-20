using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conjuntos_hashset_csharp
{
    public class RegistroLogin
    {
        public string Nome { get; set; }
        public DateTime HoraLogin { get; set; }
        public RegistroLogin(string linha)
        {
            var reg = linha.Split(" ");
            Nome = reg[0];
            HoraLogin = DateTime.Parse(reg[1]);
        }

        
        public override bool Equals(object obj)
        {
            return obj is RegistroLogin login &&
                   Nome == login.Nome;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome);
        }
    }
}
