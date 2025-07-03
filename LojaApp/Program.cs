using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using MinhaLoja.Client;
using MinhaLoja.Client.Models;
using System.Text;
using System.Text.Json;

Console.OutputEncoding = Encoding.UTF8;
var authProvider = new AnonymousAuthenticationProvider();
var adapter = new HttpClientRequestAdapter(authProvider)
{
    BaseUrl = "http://localhost:3001" // Altere conforme seu mock ou serviço real
};

var client = new LojaClient(adapter); 

try
{
    Console.WriteLine("🔍 Buscando produtos...");

    var produtos = await client.Produtos.GetAsync();

    if (produtos == null || produtos.Count == 0)
    {
        Console.WriteLine("Nenhum produto encontrado.");
        return;
    }

    Console.WriteLine("📦 Produtos disponíveis:");
    foreach (var p in produtos)
    {
        Console.WriteLine($"- {p.Id}: {p.Nome} - R$ {p.Preco}");
    }

    // Criar um novo pedido com 2 unidades do primeiro produto
    var novoPedido = new Pedido
    {
        Id = 101,

        Data = new Date(DateTime.UtcNow.Date),
        Itens = new List<ItemPedido>
        {
            new ItemPedido
            {
                ProdutoId = produtos[0].Id,
                Quantidade = 2
            }
        }
    };

    await client.Pedidos.PostAsync(novoPedido);
    // Salvar o pedido em um arquivo JSON
    var json = JsonSerializer.Serialize(novoPedido);
    File.WriteAllText("pedido.json", json);

    Console.WriteLine("✅ Pedido enviado com sucesso!");
}
catch (ApiException apiEx) when (apiEx.ResponseStatusCode == 404)
{
    Console.WriteLine("⚠️ Recurso não encontrado.");
}
catch (ApiException apiEx) when (apiEx.ResponseStatusCode == 500)
{
    Console.WriteLine("🔥 Erro interno no servidor.");
}