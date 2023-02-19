// See https://aka.ms/new-console-template for more information

List<string> listaProdutos = new List<string>() { "Carro", "Camera", "Capacete", "Caneta", "Cinzeiro", "Cebola", "Clipe", "Colchão", "Copo", "Chinelo", "Chupeta" };

Console.WriteLine("Digite o produto ou a letra inicial do produto que você deseja: ");
string produtoBuscado = Console.ReadLine();

List<string> resultadoBusca = retornaBusca(listaProdutos,produtoBuscado);

foreach (string produto in resultadoBusca)
{
    Console.WriteLine(produto);
}

static List<string>  retornaBusca(List<string> produtos, string valorDigitado)
{
    List<string> retornaBusca = new List<string>();

    int contInicial = valorDigitado.Length;

    foreach (string produto in produtos)
    {
        string comparacao = produto.Substring(0, contInicial);
        if(valorDigitado.ToUpper() == comparacao.ToUpper())
        {
            retornaBusca.Add(produto);
        }
    }

    return retornaBusca;
}
