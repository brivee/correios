using Correios.Demo;

var cepOrigem = "87560000";

var cepDestino = "35052854";

var itens = new List<Item>()
{
    new Item()
    {
        Nome = "Produto A",
        Altura = 12,
        Largura = 14,
        Comprimento = 16,
        Peso = 200
    },
    new Item()
    {
        Nome = "Produto B"
    }
};


var precoPrazoList = new CorreiosManager().CalcularPrecoPrazo(cepOrigem, cepDestino, itens);

foreach (var precoPrazo in precoPrazoList)
{
    Console.WriteLine(precoPrazo);
}

Console.ReadLine();
