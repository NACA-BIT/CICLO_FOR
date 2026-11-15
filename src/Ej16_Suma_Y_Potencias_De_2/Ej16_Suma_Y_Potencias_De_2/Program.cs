/*Potencias de 2 (y su suma)
Imprima las potencias de 2 desde 2¹ hasta 2¹⁰ y acumule la suma de todas. 
¿Nota el patrón entre un resultado y el siguiente?*/

double potencias, sumaPotencias = 0;
for (int i = 1; i <= 10; i++)
{
    potencias=Math.Pow(2,i);
    Console.WriteLine($"2^{i} = {potencias}");
    sumaPotencias=sumaPotencias+potencias;
    Console.WriteLine($"La suma de las potencias es {sumaPotencias}");

}