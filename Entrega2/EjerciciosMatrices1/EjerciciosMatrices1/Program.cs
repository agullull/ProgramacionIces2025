//  // Crear una matriz de 3x3. Solicitar al usuario que ingrese todos los elementos y luego
//  mostrar la suma de cada fila.


int[,] MatrizA = new int[3, 3];
int[,] MatrizB = new int[3, 3];
int[,] MatrizC = new int[3, 3]; //Aca tendremos la suma de las anteriores, a y b.

Console.WriteLine("Ingresa los valores de la matriz A: ");

for (int i = 0; i < MatrizA.Length; i++) 
{
    for (int j = 0; j < MatrizA.Length; i++) 
    {
        Console.WriteLine("Ingrese los valores para [" + i + "]" + "[" + j + "] ");
        MatrizA[i,j]= Convert.ToInt32(Console.ReadLine());
    }
}
for (int i = 0; i < MatrizB.Length; i++)
{
    for (int j = 0; j < MatrizB.Length; i++)
    {
        Console.WriteLine("Ingrese los valores para [" + i + "]" + "[" + j + "] ");
        MatrizB[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

//SUMAMOS LAS MATRICES

for (int i = 0; i < MatrizC.Length; i++)
{
    for (int j = 0; j < MatrizC.Length; i++)
    {
        MatrizC[i, j] = MatrizA[i,j] + MatrizB[i,j];
    }
}

for (int i = 0; i < MatrizC.Length; i ++)
{
    for (int j = 0; j < MatrizC.Length; j++)
    {
        Console.WriteLine($"La suma de las matrices es MatrizC}");
    }
}