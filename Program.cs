string opcaoDesejada;

Console.Clear();

Console.WriteLine("--- Calculadora 4 operações ---\n");

Console.WriteLine("[+] Soma");
Console.WriteLine("[-] Subtração");
Console.WriteLine("[*] Multiplicação");
Console.WriteLine("[/] Divisão");
Console.WriteLine("[^] Exponenciação");
Console.WriteLine("[v] radiciação");

Console.Write("\nSelecione a operação desejada: ");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "+":
        double w, y, resultado;
        Console.WriteLine("Você selecionou soma");
        Console.WriteLine("Digite um número: ");
        Console.Write("w = ");
        w = Convert.ToDouble(Console.ReadLine());
        Console.Write("y = ");
        y = Convert.ToDouble(Console.ReadLine());

        resultado = w + y;

        Console.WriteLine($"{w} somado por {y} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        break;
   
    case "-":
        double m, n, solução;
        Console.WriteLine("Você selecionou subtração");
        Console.WriteLine("Digite um número: ");
        Console.Write("m = ");
        m = Convert.ToDouble(Console.ReadLine());
        Console.Write("n = ");
        n = Convert.ToDouble(Console.ReadLine());

        solução = m - n;

        Console.WriteLine($"{m} subtraído por {n} é {solução}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
        break;

    case "*":
        double a, b, conclusão;

        Console.WriteLine("--- Multiplicação a*b ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("a = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        b = Convert.ToDouble(Console.ReadLine());

        conclusão = a * b;

        Console.WriteLine($"{a} multiplicado por {b} é {conclusão}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        break;

    case "/":
        double j, d, resolução;
        Console.WriteLine("Você selecionou divisão");
        Console.WriteLine("Digite os valores.");

        Console.Write("j = ");
        j = Convert.ToDouble(Console.ReadLine());
        Console.Write("d = ");
        d = Convert.ToDouble(Console.ReadLine());

        resolução = j / d;

        Console.WriteLine($"{j} dividido por {d} é {resolução}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
        break;

    default:

        Console.WriteLine("Opção inválida.");
        break;

    case "^":
        double o, p, resposta;
        Console.WriteLine("Você selecionou exponenciação\n");
        Console.WriteLine("Digite um número: ");
        
        Console.Write("o = ");
        o = Convert.ToDouble(Console.ReadLine());
        Console.Write("p = ");
        p = Convert.ToDouble(Console.ReadLine());

        resposta = Math.Pow(o, p);

        Console.WriteLine($"{o} exponenciado por {p} é {resposta}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();

        break;

    case "v":
        double u, q, restante;

        Console.WriteLine("Você selecionou radiciação");
        Console.WriteLine("Digite um número: ");
        Console.Write("u = ");
        u = Convert.ToDouble(Console.ReadLine());
        Console.Write("q = ");
        q = Convert.ToDouble(Console.ReadLine());

        restante = Math.Pow(u, q);

        Console.WriteLine($"{u} radiciado por {q} é {restante}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
        break;

}
        Console.WriteLine("\nObrigado por utilizar nosso programa.");