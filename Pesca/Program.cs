int[] Lago = new int[50];
int qtdPeixes, qtdPessoas, qtdIscas;
string[] nomes;
Console.Write("Quantos Peixes tem no lago: ");
qtdPeixes = int.Parse(Console.ReadLine());
Console.Write("Número de Jogadores: ");
qtdPessoas = int.Parse(Console.ReadLine());
Console.Write("Numéro de Iscas/Tentativas: ");
qtdIscas = int.Parse(Console.ReadLine());
nomes = new string[qtdPessoas];
for(int i =0;i<qtdPessoas;i++)
{
    Console.Write("Escreva o nome da " + (i + 1) + "° pessoa: ");
    nomes[i] = Console.ReadLine();
}
Console.WriteLine("Escolha a posição:"); 
    for(int i = 1; i <= 25; i++)
{
    Console.Write("( "+i+")");
}
Console.WriteLine();
for (int i = 25; i <= 50; i++)
{
    Console.Write("(" + i + ")");
}


