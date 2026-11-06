//Dependiendo del usuario, diga una cuenta regresiva
int Numero;
Console.WriteLine("Manito, dime el numero al que le quieres sacar la cuenta regresiva");
Numero=Convert.ToInt16(Console.ReadLine());

for (int i = Numero; i >= 1; i--)
{
    Console.WriteLine($" {i} ");
}