//sacar el factorial de un numero dado por el usuario
int numero,factorial=1;
Console.WriteLine("Porfavor dime un numero");
numero = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= numero; i++)
{
    factorial *= i;
}
Console.WriteLine(factorial);

