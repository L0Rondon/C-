//Exercicio 1
/*
static int[] GeraJogo()
{
    int[] mega = new int[6];
    Random r = new Random();
    for(int pos = 0; pos < 6; pos++)
    {
        int num = r.Next(1, 61);
        if(mega.Contains(num))
        {
            pos--;
        }
        else
            mega[pos] = num;
    }
    return mega;
}

//entradas

int qtdJogos;
int[,] jogos;

Console.Write("Informe quantos jogos você deseja: ");
qtdJogos = int.Parse(Console.ReadLine());

jogos = new int[qtdJogos,6];

//processamento
Console.WriteLine("Jogos gerados: ");
for(int jogo=0; jogo<qtdJogos;jogo++)
{
    int[] j = GeraJogo();
    for( int pos = 0;pos < 6; pos++)
    {
        jogos[jogo, pos] = j[pos];
        Console.Write(j[pos] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Sorteio Real:");
int[] mega = GeraJogo();
for (int pos = 0; pos<6; pos++)
{
    Console.Write(mega[pos] + "\t");
}
//saida
Console.WriteLine("\n Quantidade de acertos: ");
for(int jogo = 0; jogo<qtdJogos; jogo++)
{
    Console.Write("Jogo "+ (jogo+1) + ": ");
    int qtdAcertos = 0;
    for(int num = 0; num < 6; num++)
    {
        if (mega.Contains(jogos[jogo,num]))
            qtdAcertos++;
    }
    Console.WriteLine(qtdAcertos);
}
*/

//Exercicio 2

/*
string[] nome = new string[10];
string ultimoNome;

for (int i = 0; i < 10; i++)
{
    Console.Write("Escreva o " + (i + 1) + "° nome: ");
    nome[i] = Console.ReadLine();
}
Console.Write("Escreva o novo nome: ");
ultimoNome = Console.ReadLine();
for (int i = 0; i < 10; i++) {
    if (nome[i] == ultimoNome){
        Console.Write("O nome lido é igual ao "+(i+1) +"° nome");
    }
 }
*/

//Exercicio 3
