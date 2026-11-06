//Suma de numeros impares hasta N
int Numero, Acumulador=0;
Console.WriteLine("Escribe un numero");
Numero =Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= Numero; i++)
{
    if (i%2==1)
    {
        Acumulador = Acumulador + i;
        Console.WriteLine($"Impar = {i}");
    }
}
Console.WriteLine($"La suma de los numeros es {Acumulador}");