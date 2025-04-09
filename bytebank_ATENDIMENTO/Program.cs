using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_ATENDIMENTO.bytebank.Exceptions;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Collections;
using System.ComponentModel.Design;
using System.Net.WebSockets;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento. Teste");

#region Exemplos Arrays em C#
//TestaArrayInt();
//TesteBuscaPalavra();

void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 15;
    idades[2] = 60;
    idades[3] = 45;
    idades[4] = 19;

    Console.WriteLine($"Tamanho total do Array: {idades.Length}");

    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"indice [{i}] = {idade}");
        acumulador += idade;
    }

    int media = acumulador / idades.Length;
    Console.WriteLine($"Média de idades = {media}");

}

void TesteBuscaPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i + 1} Palavra: ");
        arrayDePalavras[i] = Console.ReadLine()!;
    }

    Console.WriteLine("Digite palavra a ser encontrada: ");
    var busca = Console.ReadLine()!;

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}.");
            break;
        }
    }

}


Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

//[5,9][1,8][7,1][10][6,9]
//TestaMediana(amostra);

void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para calculo da mediana está vazio ou nulo.");
    }

    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);
    //[1,8][5,9][6,9][7,1][10]

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
                     (numerosOrdenados[meio - 1] + numerosOrdenados[meio]) / 2.0;

    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
}


//int[] valores = { 10, 58, 36, 47 };
//for (int i = 0; i < 5; i++) //definido a quantidade de elementos incorreto
//{
//    Console.WriteLine(valores[i]);
//}

void TesteArrayDeContasCorrentes()
{

    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "8899779-D"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));

    Console.WriteLine("\nConta do Andre adicionada: ");
    var contaDoAndre = new ContaCorrente(963, "4456668-B");
    listaDeContas.Adicionar(contaDoAndre);
    //listaDeContas.ExibeLista();
    //Console.WriteLine("\nRemovendo a conta do Andre e atualizando a lista de contas:");
    //listaDeContas.Remover(contaDoAndre);
    //listaDeContas.ExibeLista();

    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas.RecuperarContaIndice(i);
        Console.WriteLine($"Indice [{i}] = {conta.Conta} / {conta.Numero_agencia}");
    }

}

//TesteArrayDeContasCorrentes();
#endregion

#region Implementação de Classe Generica
//Implementação de Classe Generica
//Generica<int> teste1 = new Generica<int>();
//teste1.MostrarMensagem(10);

//Generica<string> teste2 = new Generica<string>();
//teste2.MostrarMensagem("string - Teste de Generics");

//public class Generica<T>
//{
//    public void MostrarMensagem(T t)
//    {
//        Console.WriteLine($"Exibindo: {t}");
//    }
//}
#endregion

#region Exemplos de uso do List
//List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
//{
//    new ContaCorrente(874, "5679787-A"),
//    new ContaCorrente(874, "4456668-B"),
//    new ContaCorrente(874, "7781438-C")
//};

//List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
//{
//    new ContaCorrente(951, "5679787-E"),
//    new ContaCorrente(321, "4456668-F"),
//    new ContaCorrente(719, "7781438-G")
//};

//_listaDeContas2.AddRange(_listaDeContas3);
//_listaDeContas2.Reverse();

//for (int i = 0; i < _listaDeContas2.Count; i++)
//{
//    Console.WriteLine($"Indice [{i}] = [{_listaDeContas2[i].Conta}]");
//}

//Console.WriteLine("\n\n");
//var range = _listaDeContas3.GetRange(0, 1);
//for (int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"Indice [{i}] = [{range[i].Conta}]");
//}

//Console.WriteLine("\n\n");

//_listaDeContas3.Clear();
//for (int i = 0; i < _listaDeContas3.Count; i++)
//{
//    Console.WriteLine($"Indice [{i}] = [{range[i].Conta}]");
//}
#endregion

new ByteBankAtendimento().AtendimentoCliente();