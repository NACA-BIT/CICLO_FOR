/*Matriz 3×4: llenar e imprimir
Cree una matriz de 3 filas y 4 columnas donde cada celda guarda fila × columna.
Llénela con un doble ciclo e imprímala con otro doble ciclo.*/
Console.WriteLine($"|-----------------------|");

for (int i = 1; i <= 3; i++)
{
    Console.WriteLine();

    for (int j = 1; j <= 4; j++)
    {
        Console.Write(i*j+" ");

    }
}
Console.WriteLine($"\n|-----------------------|");
