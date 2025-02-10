//Exercicio 1

/*
for(int i = 0; i < 9; i++)
{
    for (int j = 1; j < i; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}
*/

//Exercicio 2

/*
for (int i = 0; i < 9; i++)
{
    for (int j = 1; j < i; j++)
    {
        Console.Write(j);
    }
    for (int k = 0; k < 8-i ; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
*/

//Exercicio 3

/*
int num1, num2;
double resultado;
Console.Write("Escreva o primeiro número: ");
num1 = int.Parse(Console.ReadLine());
do
{
    Console.Write("Escreva o segundo número: ");
    num2 = int.Parse(Console.ReadLine());
    if (num2 == 0)
    {
        Console.WriteLine("Escreva outro número");
    }
}
while (num2 == 0);
resultado = (double)num1 / num2;
Console.WriteLine("O resultado é: "+ resultado);
*/


//Exercicio 4

/*
int numero, resultado; 
Console.Write("Escreva um número: ");
numero = int.Parse(Console.ReadLine());
for(int i = 1; i < numero; i+= 2)
{
    for(int j = 1; j < 11; j++)
    {
        resultado = i * j;
        Console.WriteLine(i +" x "+ j +" = "+ resultado);
    }
    Console.WriteLine();
}
*/


//Exercicio 5

/*
int[] idade = new int[4];
int[] altura = new int[4];

for (int i = 0; i < 5; i++)
{
    Console.Write("Escreva a idade do "+ (i + 1) +"° individuo: ");
    idade[i] = int.Parse(Console.ReadLine());
    Console.Write("Escreva a altura do " + (i + 1) + "° individuo: ");
    altura[i] = int.Parse(Console.ReadLine());
}
*/


//Exercicio 6

//Exercicio 7

//Jeito 1
/*string frase;

Console.WriteLine("Informe uma frase ou palavra: ");
frase = Console.ReadLine();

//Limpar os espaços em branco

frase = frase.Replace(" ", "");

char[] textoInvertido = frase.ToCharArray();
Array.Reverse(textoInvertido);
if(new string(textoInvertido) == frase)
{
    Console.WriteLine("É um palindromo!");
}
else
{
    Console.WriteLine("Não é um palindromo");
}
*/

//Jeito 2
/*
static bool Palindromo(string texto)
{
    char[] textoInvertido = texto.ToCharArray();
    Array.Reverse(textoInvertido);
    return (new string(textoInvertido) == texto);
}
*/

//Exercicio 8
/*
static string criptografar(string texto, int deslocamento)
{
    char[] resultado = new char[texto.Length];
    for (int pos = 0; pos < texto.Length; pos++)
    {
        char caractere = texto[pos];
        if (char.IsLetter(caractere))
        {
            char charbase =  char.IsUpper(caractere) ? 'A' : 'a';
            resultado[pos]=(char)(
                (caractere - charbase + deslocamento) % 26 + charbase
                );

        }
        else
        {

        }
    }
    return new string( resultado );
}

string mensagem;
int deslocamento;
Console.Write("Informe uma mensagem: ");
mensagem = Console.ReadLine();

Console.WriteLine("Informe o deslocamento: ");
deslocamento =int.Parse(Console.ReadLine());

string msgCriptografada = criptografar(mensagem, deslocamento);
Console.WriteLine("Mensagem criptografada: " + msgCriptografada);
*/