/*Las súper tablas (1 al 10)
Imprima todas las tablas de multiplicar, de la del 1 a la del 10, 
con una línea separadora entre tabla y tabla. Su primer ciclo dentro de otro ciclo.*/
Console.WriteLine($"|-----------------------|");

for (int i = 1; i <=10; i++)
{

    for (int j = 1; j <= 10; j++)
    {
        
        Console.WriteLine($"{i} * {j} = {i*j}|");
    }
    Console.WriteLine($"|-----------------------|");

}