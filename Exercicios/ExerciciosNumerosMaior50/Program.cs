
int[] numeros = new int[10];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Digite o numéro: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());

}

for (int i = 0; i < numeros.Length; i++)
{

    if (Convert.ToInt32(numeros[i]) > 50 ) {
        Console.WriteLine("O numéro é maior que o 50" + numeros[i] + "está na posicição" + i);
    } else if (numeros[i]  <= 0)
    {
        Console.WriteLine("Não existe nenhum valor na posição: " + i);
    }

}

