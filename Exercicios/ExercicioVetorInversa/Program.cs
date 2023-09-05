
int [] vetorNumeros = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite 5 numeros");
    vetorNumeros[i] = Convert.ToInt32(Console.ReadLine());  
}

Console.WriteLine("Digite o Código");
int codigo = Convert.ToInt32(Console.ReadLine());  

if (codigo != 0)
{
    if(codigo == 1)
    {
        for (int i = 0; i < vetorNumeros.Length; i++)
        {
            Console.WriteLine(vetorNumeros[i]);
        }
    }

    if (codigo == 2)
    {
        Console.WriteLine("Numeros Inversos");
        for (int i = vetorNumeros.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(vetorNumeros[i]);
        }
    }

}