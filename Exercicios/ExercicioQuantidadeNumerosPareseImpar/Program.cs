




using System.Runtime.CompilerServices;

int quantidadeNumeroImpar = 0;
int quantidadeNumeroPares = 0;
int[] vetorDeNuemros = new int[6];
int[] vetorDeNumeroPares = new int[3];
int[] vetorDeNumeroImpar = new int[3];

int indexPar = 0;
int indexImpar = 0;


for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Digite o numero: ");
    vetorDeNuemros[i] = Convert.ToInt32(Console.ReadLine());
}


for (int i = 0; i < 6; i++)
{

    if (vetorDeNuemros[i] % 2 == 1)
    {
        vetorDeNumeroImpar[indexImpar] = vetorDeNuemros[i];
        quantidadeNumeroImpar++;
        indexImpar++;
    }
    else
    {
        vetorDeNumeroPares[indexPar] = vetorDeNuemros[i];
        quantidadeNumeroPares++;
        indexPar++;

    }
}


for (int i = 0; i < vetorDeNumeroImpar.Length; i++)
{

    Console.WriteLine("Esse não os numeros impars: " + vetorDeNumeroImpar[i]);

}
for (int i = 0; i < vetorDeNumeroImpar.Length; i++)
{

    Console.WriteLine("Esse não os numeros pares: " + vetorDeNumeroPares[i]);

}



Console.WriteLine("Quantidade de Numeros impar" + quantidadeNumeroImpar);
Console.WriteLine("Quantidade de numeros pares" + quantidadeNumeroPares);
