using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;


int numero = 15;
bool ehPar = false;

//if ternario

ehPar = numero.EhPar();

Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));














/* MeuArray<int> arrayInteiro = new MeuArray<int>();

arrayInteiro.AdicionarElementoArray(30);

Console.WriteLine(arrayInteiro[0]);

MeuArray<string> arrayString = new MeuArray<string>();

arrayString.AdicionarElementoArray("Testezada");

Console.WriteLine(arrayString[0]); */














/* var tipoAnonimo = new { Nome = "Vinicius", Sobrenome = "Lobo", Altura = 1.80, Idade = 19 }; //objeto anonimo

Console.WriteLine("Nome: " + tipoAnonimo.Nome);
Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
Console.WriteLine("Altura: " + tipoAnonimo.Altura);
Console.WriteLine("Idade: " + tipoAnonimo.Idade); */

















/* bool? desejaReceberEmail = true;

if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
{
    Console.WriteLine("O usuário optou por receber email");
}
else
{
    Console.WriteLine("O usuário não respondeu ou optou por não receber email");
} */













/* DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritorio", 25.00M, dataVenda: dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataVenda: dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado); */









/* if (numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é par");
}
else
{
    Console.WriteLine($"O número {numero} é ímpar");
} */




















/* Pessoa p1 = new Pessoa("Vinicius", "Lobo");

(string nome, string sobrenome) = p1;
 */


















/* LeituraArquivo arquivo = new LeituraArquivo();

var(sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    //Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadeLinhas}");
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
} */

















/* (int, string, string, decimal) tupla = (1, "Vinicius", "Lobo", 1.80M);

//essas outras maneiras de criar tuplas não deixam nomear os dados
ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Vinicius", "Lobo", 1.80M);
var outroExemploTuplaCreate = Tuple.Create(1, "Vinicius", "Lobo", 1.80M);

Console.WriteLine($"ID: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}"); */










//Dictionary<string, string> estados = new Dictionary<string, string>();

/* estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("---------");

estados.Remove("BA");
estados["SP"] = "São Paulo - Atualizado";

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
} */

/* string chave = "BA2";
Console.WriteLine($"Verificando o elemento: {chave}");

if(estados.ContainsKey (chave))
{
    Console.WriteLine($"Valor existente: {estados[chave]}");
}
else
{
    Console.WriteLine($"Valor não existe. É safe adicionar {chave}");
}
*/





















/* Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

pilha.Push(20);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}
 */














/* Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
fila.Enqueue(10);

foreach (int item in fila)
{
    Console.WriteLine(item);
} */








//new ExemploExcecao().Metodo1();


















/* try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não encontrado. {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Caminho da pasta não encontrado. {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
} finally
{
    Console.WriteLine("Chegou até aqui");
} */























/* string dataString = "19/05/2006 15:30:00";

DateTime.TryParseExact(dataString, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);


Console.WriteLine(data.ToShortTimeString());
 */






















/* CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1582.40M;

Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;

Console.WriteLine(numero.ToString("##-##-##")); */
























/* string numero1 = "10";
string numero2 = "20";
string resultado = numero1 + numero2;

Console.WriteLine(resultado);
 */




















/* Pessoa p1 = new Pessoa(nome: "Vinicius", sobrenome: "Lobo");

Pessoa p2 = new Pessoa(nome: "Maria", sobrenome: "Luiza");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos(); */






/* p1.Nome = "Lobonauta";
p1.Sobrenome = "Menino";
p1.Idade = 19;


p1.Apresentar(); */