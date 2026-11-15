/*Positivos y negativos, por separado
Lea N números. Calcule por separado la suma y la cantidad de los positivos, 
y la suma y la cantidad de los negativos. El cero no cuenta para ningún lado.*/

int menor=0, mayor=0, sumaMenor=0, sumaMayor=0, nNumeros,Numeros;

Console.WriteLine("Cuantos numeros vas a calcular manito?");
nNumeros = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= nNumeros; i++)
{
    Console.WriteLine("Digite los numeros manito porfavor");
    Numeros = Convert.ToInt32(Console.ReadLine());

    if (Numeros>0)
    {
        sumaMayor = sumaMayor + Numeros;
        mayor++;
    }
    if (Numeros < 0)
    {
        menor++;
        sumaMenor = sumaMenor + Numeros;

    }
}

Console.WriteLine($"La cantidad de numeros mayores es: {mayor} \n La cantidad de numeros mayores es: {menor}");
Console.WriteLine($"La suma de los mayores es {sumaMayor} \n La suma de los menores es {sumaMenor}");
