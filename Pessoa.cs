using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Conceitos
{
    internal class Pessoa
    {
        public string nome;
        public char sexo;

        public void Mensagem()
        {
            Console.WriteLine($"O seu nome e: {nome}\nO seu sexo e: {sexo}");
        }
    }
}
