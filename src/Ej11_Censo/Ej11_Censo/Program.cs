/*Censo exprés: ¿cuántos son mayores?
Lea la cantidad de personas y luego la edad de cada una.
Cuente cuántas son mayores de edad y muestre también cuántas son menores.*/

int cPersonas, edad, menores=0, mayores=0;
Console.Write("Manito cuantas personas son?: ");
cPersonas=Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= cPersonas; i++)
{
    Console.WriteLine($"Ingrese la edad de la persona {i}");
    edad = Convert.ToInt32(Console.ReadLine());

    if (edad>=18)
    {
        mayores++;
    }
    if (edad<18)
    {
        menores++;
    }
}
Console.WriteLine($"Hay {mayores} mayores - hay {menores} menores");