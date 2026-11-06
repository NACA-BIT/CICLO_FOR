/*Pregunte cuántas notas va a digitar el aprendiz. Luego, en un ciclo,
 * lea cada nota, acumúlelas y al final muestre el promedio. */
int nNotas, Notas, Acumulador=0;
Console.WriteLine("Manito, porfavor dime el numero de notas vas a digitar");
nNotas = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= nNotas; i++)
{
    Console.Write($"Inserta nota {i}: ");
    Notas= Convert.ToInt32(Console.ReadLine());
    Acumulador += Notas;
}
Console.WriteLine($"El promedio de las notas es igual a {Acumulador / nNotas}");
