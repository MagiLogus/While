//1-Faça um programa que leia e valide as seguintes informações:
// 1. Nome: diferente de vazio;
// 2. Idade: entre 0 e 100 anos;
// 3. Salário: maior que zero;
// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));

string nome = "";
int idade = 0;
double salario = 0;
char estadoCivil = ' ';

Console.WriteLine($"Bem-vindo, informe seus dados: ");
Console.Write("Informe seu nome: ");
nome = Console.ReadLine();

while (nome == "")
{
Console.WriteLine("Seu nome não pode ser nulo.");
Console.Write("Informe seu nome: ");
nome = Console.ReadLine();
}

Console.Write("Informe sua idade: ");
idade = int.Parse(Console.ReadLine());

while (idade < 0 || idade > 100)
{
Console.WriteLine("A idade deve estar entre 0 e 100 anos.");
Console.Write("Informe sua idade: ");
idade = int.Parse(Console.ReadLine());
}

Console.Write("Informe o seu salário: ");
salario = double.Parse(Console.ReadLine());

while (salario <= 0) 
{
Console.WriteLine("Seu salário deve ser maior que zero.");
Console.Write("Informe o seu salário: ");
salario = double.Parse(Console.ReadLine());
}

Console.Write("Informe o seu estado civil com 's' para solteiro(a), 'c' para casado(a), 'v' para viuvo(a) ou 'd' para divorciado(a): ");
estadoCivil = char.Parse(Console.ReadLine());

while (estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd') 
{
Console.WriteLine("Seu estado civil é invalido. Digite 's' para solteiro(a), 'c' para casado(a), 'v' para viúvo(a) ou 'd' para divorciado(a).");
Console.Write("Informe o seu estado civil com 's' para solteiro(a), 'c' para casado(a), 'v' para viuvo(a) ou 'd' para divorciado(a): ");
estadoCivil = char.Parse(Console.ReadLine());
}

Console.WriteLine($"Olá, {nome}, você tem {idade} anos, seu estado civil é '{estadoCivil}' e possui um salário de R${salario} reais.");
