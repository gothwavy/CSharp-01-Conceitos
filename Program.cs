namespace _01Conceitos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pessoa pessoa = new Pessoa();
            pessoa.nome = "Ryan";
            pessoa.sexo = 'M';
            pessoa.Mensagem();

            Sobrecarga mensagem = new Sobrecarga();
            mensagem.Mensagem();
            mensagem.Mensagem("Ryan");
            mensagem.Mensagem("Esther", 'F');

        }
    }
}
