/*La escalera numérica
Imprima esta figura usando ciclos anidados, 
donde cada fila repite su propio número:
1 / 22 / 333 / 4444 / 55555*/

for (int i = 1; i <= 5; i++)
{
    //Console.Write(i);
    for (int j = 1; j <= i; j++)
    {
        Console.Write(i);

    }
    Console.WriteLine();

}