// Iniciando aula de Laços

// como repetir várias vezes

// string opção = "";

// while (opção != "1234")
// {
//     Console.WriteLine("Digite sua senha para entrar!");
//     Console.Write("Senha incorreta");
//     opção = Console.ReadLine()!.ToLower();
//     Thread.Sleep(200);


// }


// int n = -10;
// while (n <= 10)
// {
//     Console.WriteLine($"{n}");
//     n = n + 1;
// }

string opcao = "";
while (opcao != "s")
{
    Console.WriteLine("Deseja calcular a tabuada de qual número? ");
    int n = Convert.ToInt32(Console.ReadLine());

    int contador = 1;
    while (contador <= 10)
    {
        int produto = contador * n;
        Console.WriteLine($"{n} x {contador} = {produto} ");
        contador++;
    }
    Console.Write("Deseja sair?");
    opcao = Console.ReadLine()!;
}