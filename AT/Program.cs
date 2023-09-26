
using AT;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Xml;


public class Program
{
    public static void Main()
    {
        IRepositorio repositorio;
        OperacoesMenu menu;
        RepositorioArquivo arquivo = new RepositorioArquivo();
        OperacoesMenu listaArquivo = new OperacoesMenu(arquivo);
        
     
        listaArquivo.MostrarLista();

        Console.WriteLine("Escolha se vc quer salvar em arquivo ou lista:");
        Console.WriteLine("1- Arquivo");
        Console.WriteLine("2- Lista");
        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                Console.WriteLine("Voce escolheu salvar em Arquivo");
                repositorio = new RepositorioArquivo();
                break;
            case "2":
                Console.WriteLine("Voce escolheu salvar em lista");
                repositorio = new RepositorioLista();
                break;
            default:
                Console.WriteLine("Opçaõ inválida, salvando em lista como padrão");
                repositorio = new RepositorioLista();
                break;
        }
        menu = new OperacoesMenu(repositorio);
        string sair = "0"; 
        do
        {
            Console.WriteLine("Oque você deseja no Consultorio?");
            Console.WriteLine("1-Adicionar Cliente");
            Console.WriteLine("2-Alterar dados de um Cliente");
            Console.WriteLine("3-Excluir Cliente");
            Console.WriteLine("4-Pesquisar Cliente");
            Console.WriteLine("5-Sair do programa");

            string opcao = Console.ReadLine();
            
            do
            {
                switch (opcao)
                {
                    case "1":
                        menu.SalvarPessoa(); break;
                    case "2":
                        menu.AlterarDadosCliente(); break;
                    case "3":
                        menu.ExcluirCliente(); break;
                    case "4":
                        menu.PesquisarCLiente(); break;
                    case "5":
                        Console.WriteLine("Obrigado por usar o programa!");
                        sair = opcao;
                        break;
                    default:
                        Console.WriteLine("Opção inválida, Escreva novamente");
                        break;
                }
            } while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5");
        } while (sair != "5");
        
       
      




    }
}