using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlezuriSchoolManagement.Autenticacao
{
    public interface IAutenticador
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha);
    }
}
