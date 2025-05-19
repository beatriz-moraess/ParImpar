Console.Clear();

Console.Write("Digite um número para descobrir se ele é par ou ímpar: ");
int numero = Convert.ToInt32(Console.ReadLine()!);

    if (numero % 2 == 0)
    {
    Console.WriteLine("O número é par!");
    }
    else
    {
    Console.WriteLine("O número é ímpar");
    }