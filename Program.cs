Console.Write("Digite seu nome: ");
string name = Console.ReadLine();
Console.WriteLine(name);
Console.WriteLine("Olá " + name +"!");   //concatenar string
Console.WriteLine($"Olá {name}!");       //concatenar string $

Console.Write("Digite o ano do seu nascimento: ");
int year = int.Parse(Console.ReadLine());
int age = 2022 - year;
Console.WriteLine($"Voce tem {age} anos!");

if(age > 17){
    Console.WriteLine("Você é maior de idade");
 } else 
    Console.WriteLine("Voce é menor de idade");