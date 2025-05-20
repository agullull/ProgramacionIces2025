//  Pedir al usuario que ingrese 7 números y guardarlos en una lista.
//  Luego pedir otro número y verificar si está en la lista. Mostrar un mensaje informando si se encontró o no.

using System.ComponentModel.Design;

List<decimal> numeros = new List<decimal>();


Console.WriteLine("ingrese 7 numeros:");

    for (int i = 0; i < 7; i++)
    {
        Console.WriteLine($"numero {i + 1}: ");
        decimal num = Convert.ToDecimal(Console.ReadLine());
        numeros.Add( num );
    }
Console.WriteLine("Ingrese otro número para verificar si está en la lista: ");
decimal numverificar = Convert.ToDecimal(Console.ReadLine());


    if (numeros.Contains(numverificar))
    {
    Console.WriteLine("El número está en la lista: ");
    }
    else
    {
    Console.WriteLine("El número no está en la lista");
    }









  








