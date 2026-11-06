//Lea N números uno por uno y al final reporte el mayor y el menor.
//El reto: ¿con qué valores arranca la comparación?
int nNumeros, Numeros,Mayor,Menor;
Console.WriteLine("Manito, cuantos numeros vas a comparar?");
nNumeros=Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= nNumeros; i++)
{
    
    Console.WriteLine($"Digite el Numero {i}");
    Numeros=Convert.ToInt32(Console.ReadLine());
    if (i==1)
    {
        Menor = Numeros;
        Mayor = Numeros;

    }
    else if (Numeros<Menor)
    {
        Menor = Numeros;
    }
    else if (Numeros>Mayor)
    {
        Mayor = Numeros;
    }
}
Console.WriteLine($"El mayor es {Mayor} y el menor es {Menor}");