using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace poo_dotnet.Models;

    internal class Pessoa
    {

        private const string CAMINHO_ARQUIVO = "Db/pessoas.json";

        public int Id { get; set; } = default!;
        public string Nome { get; set; } = default!;
        public string Documento { get; set; } = default!;
        public string Tipo { get; set; } = default!;

        public static void Cadastrar(Pessoa novaPessoa){
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas = Listar();
            pessoas.Add(novaPessoa);
            string jsonString = JsonSerializer.Serialize(pessoas);
            File.WriteAllText(CAMINHO_ARQUIVO, jsonString);
        }

        public static List<Pessoa> Listar(){
           List<Pessoa> pessoas = new List<Pessoa>();
           string jsonString = File.ReadAllText(CAMINHO_ARQUIVO);
           try
           {
                pessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString)!;
                return pessoas;
           }catch
           {
               return pessoas;
           }
        }
    }

