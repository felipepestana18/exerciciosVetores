

char[] gabarito = new char[10];
int[] matricula = new int[5];
char[] resposta = new char[10];
int[] mediaDeCadaAluno = new int[5];


for (int i = 0; i < gabarito.Length; i++)
{
    Console.WriteLine("Digite o a resposta do gabarito da questão" + i);
    gabarito[i] = Convert.ToChar(Console.ReadLine());
}

for (int i = 0; i < matricula.Length; i++)
{
    Console.WriteLine("Digite o numero de matricula");
    matricula[i] = Convert.ToInt32(Console.ReadLine());

    for (int j = 0; j < resposta.Length; j++)
    {
        Console.WriteLine("Digite a sua resposta");
        resposta[i] = Convert.ToChar(Console.ReadLine());

    }
}

int acerto = 0;

for (int i = 0; i < mediaDeCadaAluno.Length; i++)
{
    for (int j = 0; j < gabarito.Length; j++)
    {
        if (gabarito[j] == resposta[j])
        {
            acerto++;
        }
    }
    mediaDeCadaAluno[i] = acerto;
}

int porcentagemAprovados = mediaDeCadaAluno.Count() / mediaDeCadaAluno.Length * 100;

