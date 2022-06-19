Subtracao();

static void Soma() {

    Console.Clear();

    Console.WriteLine("Primeio Valor");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo Valor");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 + v2;
    Console.WriteLine($"O Resultado da soma é {resultado}");
}

static void Subtracao() {
    Console.Clear();

    Console.WriteLine("Primeiro Valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Primeiro Valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1-v2;
    Console.WriteLine($"O Resultado da Subtração é {resultado}");
    Console.ReadKey();
}