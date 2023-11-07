//Variavel Camel case
using System.Diagnostics;

string mensagemDeBoasVindas = "Boas vindas ao screen sound";
//função pascal case
//List <string> ListasDasBandas = new List <string> ();
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("Avenged Sevenfold", new List<int>());
void MostrarLogo()
{
    //verbatim literal
    Console.WriteLine(@"
    
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
    Thread.Sleep(1000);
}
void ExibirOpcoesDoMenu()
{
    Console.Clear();
    MostrarLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 exibir a media de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMedia();
            break;
        case -1:
            FecharPrograma();
            break;
        default:
            Console.WriteLine("opção invalida!");
            break;
    }
}
void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpção("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    ExibirOpcoesDoMenu();

}
void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpção("Exibindo Bandas Registradas ...");
    //for (int i = 0; i < ListasDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"banda: {ListasDasBandas[i]}");
    //}
    //facilidade porem sem indice [i]
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite  uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}
void ExibirTituloDaOpção(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");

}
void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpção("Avaliar bandas");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"Qual a nota da banda {nomeDaBanda}, merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada ccom sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"\n{nomeDaBanda} a banda não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu");
        Console.ReadKey();
        ExibirOpcoesDoMenu();
    }
}
void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpção("Exibindo média da banda!");
    Console.WriteLine("Digite o nome da banda");
    string nomeDaBanda = Console.ReadLine();
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {

        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();


    }
    else
    {
        Console.WriteLine($"a banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu");
        Console.ReadKey();
        ExibirOpcoesDoMenu();
    }
}
void FecharPrograma()
{
    Console.Clear();
    Console.WriteLine("áte mais... <3 ");
    Thread.Sleep(1000);
}
MostrarLogo();
ExibirOpcoesDoMenu();



//if(opcaoEscolhidaNumerica == 1 )
//{
//    Console.WriteLine("Você digitou opção 1");
//}
//else if (opcaoEscolhidaNumerica == 2)
//{
//    Console.WriteLine("Você digitou opcao 2");
//}
