using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContatosBD.Dados
{
    public class Contato
    {
        public string Nome { get; set; }
        public string? Telefone { get; set;}
        public string? Celular { get; set;}
        public string? Email { get; set;}
        public string Tipo { get; set;}

        public Contato(string Nome, string tipo) 
        {
            this.Nome = Nome;
            this.Tipo = tipo;
        }

        public Contato(string Nome,string telefone, string celular, string email,  string tipo)
        {
            this.Nome = Nome;
            this.Telefone = telefone;
            this.Celular = celular;
            this.Email = email;
            this.Tipo = tipo;
        }
    }
}
