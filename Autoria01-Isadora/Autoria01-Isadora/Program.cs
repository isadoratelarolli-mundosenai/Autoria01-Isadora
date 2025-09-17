using System.ComponentModel.Design;

Console.WriteLine("=== ORÁCULO DO FUTURO ===");
Console.WriteLine("Olá, seja bem-vindo! O que deseja saber?");
Console.WriteLine("1. Prever minha tarde");
Console.WriteLine("2. Dar um conselho");
Console.Write("Escolha (1 ou 2): ");

string escolha = Console.ReadLine();
Random rnd = new Random();

if (escolha == "1")
{
    int clima = rnd.Next(1, 4);
    if (clima == 1) Console.WriteLine("À tarde, o sol brilhará forte. Aproveite um passeio!");
    else if (clima == 2) Console.WriteLine("Chuva à vista! Fique em casa com um bom livro.");
    else Console.WriteLine("Ventos misteriosos trarão surpresas. Esteja pronto para o inesperado!");
    Console.WriteLine("\nMuito obrigada pela colaboração, tenha um execelnte dia!!!");
}
else if (escolha == "2")
{
    int conselho = rnd.Next(1, 4);
    if (conselho == 1) Console.WriteLine("Confie na sua intuição hoje; ela te guiará.");
    else if (conselho == 2) Console.WriteLine("Tente algo novo esta tarde, o universo recompensa a coragem.");
    else Console.WriteLine("Descanse agora, pois grandes coisas virão amanhã.");
    Console.WriteLine("\nMuito obrigada pela colaboração, tenha um execelnte dia!!!");
}
else
{
    Console.WriteLine("Escolha inválida! Tente novamente.");
    Console.WriteLine("\nVolte mais tarde!!!");
}

