
string[] mesTemperatura = new string [12];

mesTemperatura[0] = "Janeiro";
mesTemperatura[1] = "Fevereiro";
mesTemperatura[2] = "Março";
mesTemperatura[3] = "Abril";
mesTemperatura[4] = "Maio";
mesTemperatura[5] = "Julho";
mesTemperatura[6] = "Junho";
mesTemperatura[7] = "Agosto";
mesTemperatura[8] = "Setembro";
mesTemperatura[9] = "Outubro";
mesTemperatura[10] = "Novembro";
mesTemperatura[11] = "Dezembro";


int[] mediaTemperatura  = new int[12];


for (int i = 0; i < mesTemperatura.Length; i++)
{
    Console.WriteLine("Digite a Temperatura do Mês: " + mesTemperatura[i]);
    mediaTemperatura[i] = Convert.ToInt32(Console.ReadLine());
}

int maiorTemperatura = 0;
int menorTemperatura = 0;
int indexMaiorTemperatura = 0;
int indexMenorTemperatura = 0;

for (int i = 0; i < mediaTemperatura.Length; i++)
{
    if (mediaTemperatura[i] > maiorTemperatura)
    {
        maiorTemperatura = mediaTemperatura[i];
        indexMaiorTemperatura = i;
    }
    else if (mediaTemperatura[i] <= menorTemperatura)
    {
        menorTemperatura = mediaTemperatura[i];
        indexMenorTemperatura = i;
    }
}

Console.WriteLine("O Mês com a maior temperatura: " + mesTemperatura[indexMaiorTemperatura]);
Console.WriteLine("O Mês com a menor temperatura: " + mesTemperatura[indexMenorTemperatura]);