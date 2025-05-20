//  Generar una lista con 10 números aleatorios entre 1 y 100.
//  Luego pedir al usuario un valor límite y eliminar todos los elementos menores a ese valor.
//  Mostrar la lista resultante.


List<int> random = new List<int> ();
Random aleatorios   = new Random ();

for (int i = 0; i < 10; i++)
{
    int num = aleatorios.Next(1, 101); // 101 para incluir el 100
    random.Add(num);
}
Console.WriteLine("Lista generada: " + string.Join(", ", random));

Console.WriteLine("Ingrese un valor límite para elimitar los números menores a ese valor: ");
int limite = Convert.ToInt32(Console.ReadLine());

random.RemoveAll((n => n < limite));
Console.WriteLine("Los números mayores al límite ingresado son");
Console.WriteLine(string.Join(", ", random));







