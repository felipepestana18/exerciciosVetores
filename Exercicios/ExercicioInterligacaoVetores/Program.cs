
int[] arrayUm = new int[6];
int[] arrayDois = new int[6];


for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o valor do Primeiro Array posição: " + i );
    arrayUm[i] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o valor do Segundo Array: " + i );
    arrayDois[i] = Convert.ToInt32(Console.ReadLine());

}


// 10 20 30 40  
// 5 10 15 20 25
int[] interligacaoArray = new int[11];

int index = 0;
for (int i = 0; i < 6; i++)
{
    if (i < arrayUm.Length - 1)
    {
        interligacaoArray[index] = arrayUm[i + 1] + arrayDois[i];
    }
    if (i < arrayDois.Length - 1)
    {
        interligacaoArray[index + 1] = arrayDois[i + 1]  + arrayUm[i];
    }
    index += 2;
}

Console.WriteLine("Resultado: ");


for (int i = 0; i < interligacaoArray.Length; i++)
{
    Console.WriteLine(interligacaoArray[i]);
}

