//Faça um programa que leia e valide as seguintes informações:

// 1. Nome: diferente de vazio;

// 2. Idade: entre 0 e 100 anos;

// 3. Salário: maior que zero;

// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));

string nome = "";
int idade = 0;
double salario = 0;
char estadoCivil = ' ';

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

Console.Write("Informe o seu estado civil com 's' para solteiro(a), 'c' para casado, 'v' para viuvo ou 'd' para divorciado: ");
estadoCivil = char.Parse(Console.ReadLine());

while (estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd') 
{
Console.WriteLine("Seu estado civil é invalido. Digite 's' para solteiro(a), 'c' para casado(a), 'v' para viúvo(a) ou 'd' para divorciado(a).");
Console.Write("Informe o seu estado civil com 's' para solteiro(a), 'c' para casado, 'v' para viuvo ou 'd' para divorciado: ");
estadoCivil = char.Parse(Console.ReadLine());
}










//class Program {
   // static void Main(string[] args) {
   //     string nome = "";
 //       int idade = 0;
 //       double salario = 0;
 //       char estadoCivil = ' ';
//
     //   while (nome == "") {
    //        Console.Write("Digite o seu nome: ");
    //        nome = Console.ReadLine();
      //      if (nome == "") {
     //           Console.WriteLine("Nome não pode ser vazio.");
     //       }
    //    }

   //     while (idade < 0 || idade > 100) {
   //         Console.Write("Digite a sua idade: ");
     //       idade = Convert.ToInt32(Console.ReadLine());
  //          if (idade < 0 || idade > 100) {
      //          Console.WriteLine("Idade deve estar entre 0 e 100 anos.");
    //        }
    //    }

      //  while (salario <= 0) {
      //      Console.Write("Digite o seu salário: ");
 //           salario = Convert.ToDouble(Console.ReadLine());
       //     if (salario <= 0) {
     //           Console.WriteLine("Salário deve ser maior que zero.");
    //        }
    //    }

      //  while (estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd') {
      //      Console.Write("Digite o seu estado civil (s/c/v/d): ");
      //      estadoCivil = Convert.ToChar(Console.ReadLine());
      //      if (estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd') {
       //         Console.WriteLine("Estado civil inválido. Digite 's' para solteiro(a), 'c' para casado(a), 'v' para viúvo(a) ou 'd' para divorciado(a).");
    //        }
       // }

      //  Console.WriteLine("Informações válidas.");
      //  Console.ReadKey();
    //}
//}





















