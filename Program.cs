Console.WriteLine("Digite o primeiro numero: ");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero: ");

double num2 = double.Parse(Console.ReadLine());

double Soma = (num1 + num2);
double Subtração = (num1 - num2);
double Divisão = (num1 / num2);
double Multiplicação = (num1 * num2);
double Resto_divisão = (num1 % num2);

Console.WriteLine("O resultado soma é: " + Soma);
Console.WriteLine("O resultado da subtação é: " + Subtração);
Console.WriteLine("O resultado da divisãoé: " + Divisão);
Console.WriteLine("O resultado da multiplicação é: " + Multiplicação);
Console.WriteLine("O resto é: " + Resto_divisão);
