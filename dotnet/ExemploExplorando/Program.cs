using ExemploExplorando.Models;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("Files/vendas.json");

List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda item in listaVendas)
{
    Console.Write($"\n Id: {item.Id},\n Produto: {item.Produto}, \n Preço: {item.Preco},\n Data: {item.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}
