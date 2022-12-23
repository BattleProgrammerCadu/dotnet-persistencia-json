using poo_dotnet.Models;

namespace poo_dotnet;

public class Program
{
    public static void Main(string[] args)
    {
        int escolha = 0;

        do{
            Console.WriteLine("""
            1 - Cadastrar Usuario
            2 - Cadastrar Fornecedor
            3 - Listar Pessoas
            4 - Sair
            """);
            escolha = Convert.ToInt32(Console.ReadLine());
            

            switch(escolha)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("""
                    -------------------Novo Usuario--------------------
                    Informe o id do usuario
                    """);
                    int id =  Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o nome do usuario");
                    var nome = Console.ReadLine();
                    Console.WriteLine("Informe o cpf do usuario");
                    var cpf = Console.ReadLine();

                    Usuario usuario = new Usuario(){Id = id, Nome= nome!=null? nome : "", CPF = cpf!=null? cpf : ""};
                    Pessoa.Cadastrar(new Pessoa(){Id = usuario.Id, Nome = usuario.Nome, Documento = usuario.CPF, Tipo= "f"});
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("-------------------Pessoas--------------------");
                    Console.WriteLine("{0,-2} {1,10} {2,20} {3,10}\n", "Id", "Nome", "Documento", "Tipo");
                    List<Pessoa> pessoasCadastradas = Pessoa.Listar();
                    foreach(var pessoa in pessoasCadastradas)
                    {
                        Console.WriteLine("{0,-2} {1,10} {2,20} {3,10}", pessoa.Id, pessoa.Nome, pessoa.Documento, pessoa.Tipo);
                    }
                    Console.WriteLine("\n");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("""
                    -------------------Novo Fornecedor--------------------
                    Informe o id do fornecedor
                    """);
                    id =  Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Informe o nome do fornecedor");
                    nome = Console.ReadLine();
                    Console.WriteLine("Informe o cpf do fornecedor");
                    var cnpj = Console.ReadLine();
                    Fornecedor fornecedor = new Fornecedor(){Id = id, Nome= nome!=null? nome : "", CNPJ = cnpj!=null? cnpj : ""};
                    Pessoa.Cadastrar(new Pessoa(){Id = fornecedor.Id, Nome = fornecedor.Nome, Documento = fornecedor.CNPJ, Tipo= "J"});
                    break;
                case 4:
                    Console.Clear();
                    break;
            }
        }while(escolha!=4);
    }


}