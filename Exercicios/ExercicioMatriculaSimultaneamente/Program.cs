
int[] matriculaCalculo = new int[5];
int[] matriculaProgramacao = new int[10];
int[] alunosMatriculadoNaDuasMaterias = new int[5];
int index = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite sua Mátricula de calculo: ");
    matriculaCalculo[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite sua Mátricula de Programação: ");
    matriculaProgramacao[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < 5; i++) {

    for (int j = 0; j < 10; j++)
    {
        if (matriculaCalculo[i] == matriculaProgramacao[j])
        {
            alunosMatriculadoNaDuasMaterias[index] = matriculaCalculo[i];
            index++;
        }
    }
}
for (int i = 0; i < 5; i++)
{

    if (alunosMatriculadoNaDuasMaterias[i]  != 0)
    {
        Console.WriteLine("Aluno com matricula: " +alunosMatriculadoNaDuasMaterias[i] + " está na duas materias de PO e Calculo");
    }
}