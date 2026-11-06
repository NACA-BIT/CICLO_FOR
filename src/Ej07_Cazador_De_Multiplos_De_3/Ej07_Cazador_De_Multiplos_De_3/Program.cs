/*Lea un número N. 
 * Recorra del 1 a N y cuente cuántos múltiplos de 3 hay, y además súmelos. 
 * Muestre ambas cosas.*/
int numero,acumulador=0;
Console.WriteLine("Porfavor dime un numero");
numero=Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= numero; i++)
{

    if (i%3==0)
    {
        acumulador = acumulador + i;
        Console.WriteLine($"I es = {i}");

    }
}
Console.WriteLine($"{acumulador}");

