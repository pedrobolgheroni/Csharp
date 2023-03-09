double num1 = 0;
double num2 = 0;
char op;

do {
Console.WriteLine("Calculadora Console em C#\r");
Console.WriteLine("--------------------------\n");

Console.WriteLine("Digite um número, e pressione Enter");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite outro número, e pressione Enter");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escolha uma opção: ");

Console.WriteLine("\ta - Soma");

Console.WriteLine("\ts - Subtração");

Console.WriteLine("\tm - Multiplicação");

Console.WriteLine("\td - Divisão");

Console.Write("Qual sua opção? ");

switch(Console.ReadLine())
{
  case "a": 
   Console.WriteLine($"\nSeu resultado: {num1} + {num2} = " + (num1 + num2));
   break;

  case "s": 
   Console.WriteLine($"Seu resultado: {num1} - {num2} = " + (num1 - num2));
   break;

  case "m": 
   Console.WriteLine($"Seu resultado: {num1} * {num2} = " + (num1 * num2));
   break;

  case "d": 
   while (num2 == 0)
   {
    Console.WriteLine("Erro - Divisão por zero \nDigite outro número: ");
    num2 = Convert.ToDouble(Console.ReadLine());
   }
   Console.WriteLine($"Seu resultado: {num1} / {num2} = " + (num1 / num2));
   break;   

  default: Console.WriteLine("Opção inválida!");
  break;
}

Console.Write("\nDeseja continuar: \ns - sim \nn - não \n");
op = Console.ReadKey().KeyChar;
Console.WriteLine("");
}
while (op == 's');