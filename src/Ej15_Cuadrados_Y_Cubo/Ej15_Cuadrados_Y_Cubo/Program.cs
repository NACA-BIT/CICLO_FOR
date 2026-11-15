/*Cuadrados y cubos del 1 al 10
Imprima una tabla con tres columnas para los números del 1 al 10: 
el número, su cuadrado y su cubo. Una sola vuelta, tres resultados.*/
int sumaCuadrados=0;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i} - cuadrado {i*i} - cubo {i*i*i}");
    sumaCuadrados = (i * i) + sumaCuadrados;
    

}
Console.WriteLine($"La suma de los cuadrados es {sumaCuadrados}");
