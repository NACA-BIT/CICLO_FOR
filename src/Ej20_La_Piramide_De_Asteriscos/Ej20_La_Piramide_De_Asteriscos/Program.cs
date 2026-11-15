/*La pirámide de asteriscos (jefe final)
Imprima una pirámide de altura 5 centrada:
    * ·   *** ·  ***** · ******* · *********
Cada fila combina espacios y asteriscos: 
necesita un ciclo externo y dos internos.*/

//Un ciclo controla las filas (i)  otro los espacios (j) y otros los asteriscos (k) 
for (int i = 1; i <= 5; i++)
{

    for (int j = 4; j >= i; j=j-1)
    {
        Console.Write(" ");

    }
    for (int k = 1; k <= 2*i-1; k++)
    {
        Console.Write("*");

    }

    Console.WriteLine();

}