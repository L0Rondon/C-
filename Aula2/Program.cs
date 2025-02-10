//Exercicio 1

/*int numMaca;
Console.Write("Número de maçãs: ");
numMaca = int.Parse(Console.ReadLine());
if (numMaca < 12)
{
    Console.WriteLine("O valor total é: "+ (numMaca * 1.30));
}
else
{
    Console.WriteLine("O valor total é: " + (numMaca * 1));
}
*/

//Exercicio 2
/* int[] num = new int[3];
Console.Write("Informe o primeiro número: ");
num[0] = int.Parse (Console.ReadLine());
Console.Write("Informe o segundo número: ");
num[1] = int.Parse(Console.ReadLine());
Console.Write("Informe o terceiro número: ");
num[2] = int.Parse(Console.ReadLine());

//Teste de ordem 1
if (num[0] > num[1] && num[0] > num[2])
{
    Console.WriteLine(num[0] +" É o maior número");
    if (num[1] > num[2])
    {
        Console.WriteLine(num[1] + " É o segundo maior");
        Console.WriteLine(num[2] + " É o terceiro maior");
    }
    else
    {
        Console.WriteLine(num[2] + " É o segundo maior");
        Console.WriteLine(num[1] + " É o terceiro maior");
    }
}
//Teste de ordem 2
if (num[1] > num[0] && num[1] > num[2]) 
{
    Console.WriteLine(num[0] + " É o maior número");
    if (num[0] > num[2])
    {
        Console.WriteLine(num[0] + " É o segundo maior");
        Console.WriteLine(num[2] + " É o terceiro maior");
    }
    else
    {
        Console.WriteLine(num[2] + " É o segundo maior");
        Console.WriteLine(num[0] + " É o terceiro maior");
    }
}
if (num[2] > num[0] && num[2] > num[1])
{
    Console.WriteLine(num[2] + " É o maior número");
    if (num[0] > num[1]) {
        Console.WriteLine(num[0] + " É o segundo maior");
        Console.WriteLine(num[1] + " É o terceiro maior");
    }
    else
    {
        Console.WriteLine(num[1] + " É o segundo maior");
        Console.WriteLine(num[0] + " É o terceiro maior");
    }
}
*/

//Exercicio 3

/*
double salario, vendas;
Console.Write("Digite o valor do salário: ");
salario = double.Parse(Console.ReadLine());
Console.Write("Digite o valor das vendas: ");
vendas = double.Parse(Console.ReadLine());      

if (vendas <= 1500)
{
    Console.WriteLine("O valor que deve ser pago é R$ " + (salario + (vendas * 0.03)));
}
else
{
    Console.WriteLine("O valor que deve ser pago é R$ " + (((vendas - 1500) * 0.05) + salario + (1500 * 0.03)));
}
*/


//Exercicio 4

/*
int ano, resto4, resto100, resto400;
Console.Write("Digite o ano: ");
ano = int.Parse(Console.ReadLine());
resto4 = ano % 4;
resto100 = ano % 100;
resto400 = ano % 400;

if(resto4 == 0 && resto100 != 0)
{
    Console.WriteLine(ano +" É um ano bissexto");
}
else
{
    if (resto4 == 0 && resto100 == 0)
    {
        Console.WriteLine(ano + " Não é um ano bissexto");
    }
    else
    {
        Console.WriteLine(ano + " Não é um ano bissexto");
    }
}
if(resto400 == 0){
    Console.WriteLine(ano + " É um ano bissexto");
}
*/


//Exercicio 5

/*
double entrada;
int diaSemana;
string musicaAoVivo;
Console.Write("Informe o valor da entrada: ");
entrada = double.Parse(Console.ReadLine());
Console.WriteLine("Informe o número correspondente ao dia da semana :" +
    " \n-Domingo - 1; \n-Segunda - 2;" +
    " \n-Terça - 3; \n-Quarta - 4;" +
    " \n-Quinta - 5; \n-Sexta - 6; \n-Sabádo - 7;");
diaSemana = int.Parse(Console.ReadLine());
Console.Write("Terá música ao vivo (S/N): ");
musicaAoVivo = Console.ReadLine();

if (diaSemana == 2 || diaSemana == 3 || diaSemana == 5)
{
    entrada -= 10; //tira 10 da entrada
} 
if (musicaAoVivo.ToUpper() == "S")
{
    entrada += 7.50;
}
Console.WriteLine("O valor da entrada é: "+ entrada);
*/

