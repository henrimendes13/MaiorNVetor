/*Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida, 
mostrar na tela o maior número
do vetor (supor não haver empates). Mostrar também a posição do maior elemento.*/

int N;

N=int.Parse(Console.ReadLine());

int[] Vet = new int[N];

int maiornumero = 0;
int posicao = 0;

for (int i = 0; i < N; i++)
{
    Vet[i] = int.Parse(Console.ReadLine());


    if (Vet[i] >= maiornumero)
    {
        maiornumero = Vet[i];
        posicao = i;
    }
}

Console.WriteLine($"Maior número: {maiornumero}");
Console.WriteLine($"Posição do maior número dentro do vetor: {posicao}");