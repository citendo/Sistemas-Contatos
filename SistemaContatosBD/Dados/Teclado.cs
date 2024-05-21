using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContatosBD.Dados
{
    public class Player
    {
        public string nome;
        public int Vida;
        public int Mp;


        public Player(string nome)
        {
            Console.WriteLine("Criando Jogador");

            this.nome = nome;
        }
    }
}
