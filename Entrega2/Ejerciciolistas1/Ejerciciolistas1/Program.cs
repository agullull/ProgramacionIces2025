// Solicitar al usuario que ingrese 5 números enteros y guardarlos en una lista.
// Luego calcular y mostrar la suma total de los elementos.

List<int> numeros = new List<int>();
int numero;
int suma = 0;

Console.WriteLine("Ingrese 5 números enteros:");

for (int i = 0; i < 5; i++)
{
    Console.Write($"Número {i + 1}: ");

    while (!int.TryParse(Console.ReadLine(), out numero))  //verificamos si es entero
    {
        Console.Write("Entrada no válida. Ingrese un número entero: ");
    }

    numeros.Add(numero);
    suma += numero;
}

Console.WriteLine($"La suma total de los números es: {suma}");
    






