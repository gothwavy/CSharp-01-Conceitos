using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Conceitos
{
    internal class Sobrecarga
    {
        public void Mensagem()
        {
            Console.WriteLine("Hello World!");
        }

        public void Mensagem(string nome)
        {
            Console.WriteLine($"Hello, your name is {nome}");
        }

        public void Mensagem(string nome, char sexo)
        {
            Console.WriteLine($"Hello, your name is {nome} and your sexuality is {sexo}");
        }
    }
}
