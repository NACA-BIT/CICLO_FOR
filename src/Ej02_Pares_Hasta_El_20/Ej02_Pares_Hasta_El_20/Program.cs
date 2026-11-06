//Contar los pares hasta 20
//Metodo 1
for (int i = 2; i <= 20; i=i+2)
{
    Console.WriteLine(i);
}

//Metodo 2

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("METODO 2");
Console.WriteLine();
Console.WriteLine();

for (int i = 1; i <20 ; i++)
{
    if (i%2==0)
    {
        Console.WriteLine(i);
    }
    else
    {
        Console.WriteLine("IMPAR");
    }
}
//Se puede elimirar el else y solo quedarian los que son pares hasta el 20