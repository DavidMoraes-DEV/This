using System;
using System.Globalization;

namespace PalavraThis
{
    class Produto
    {
        CultureInfo CI = CultureInfo.InstalledUICulture;

            public string Nome;
            public double Preco;
            public int Quantidade;
            public Produto()
            {
                Quantidade = 0;
            }
            public Produto(string nome, double preco) : this() //A palavra This possibilita utilizar outro construtor já declarado para complementar o novo construtor sem a necessidade de utilizar todos os parâmetros repetidos de outro construtor.
            {
                Nome = nome;
                Preco = preco;
            }
            public Produto(string nome, double preco, int quantidade) : this(nome, preco) //Aqui puxou o construtor acima e precisou declarar apenas o outro parâmetro que não tinha no construtor anterior(Quantidade) evitando a repetição de código.
            {
                Quantidade = quantidade;
            }
        }
}
