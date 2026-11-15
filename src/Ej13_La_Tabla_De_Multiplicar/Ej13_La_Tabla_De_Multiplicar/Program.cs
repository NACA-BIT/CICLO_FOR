/*La tabla de multiplicar (el clásico)
Lea un número N e imprima su tabla de multiplicar 
completa del 1 al 10, con formato: "7 x 3 = 21".*/
int Numero;
Console.WriteLine("De cual numero quieres la tabla?");
Numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("_______________________\n");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{Numero} x {i} = {Numero * i}");
}
Console.WriteLine("_______________________");
