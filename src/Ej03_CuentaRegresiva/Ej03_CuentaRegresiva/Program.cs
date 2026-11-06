//Cuenta regresiva de 10 a 1 y al final despegue
int contador=0;
Console.WriteLine("CUENTA REGRESIVA PARA EL DESPEGUE");

for (int i = 10; i >= 1; i--)
{
    Console.WriteLine($"{i} .....");
    await Task.Delay(1000);
}

Console.WriteLine("DESPEGUE \nNOS FUIMOS MANITO");
await Task.Delay(3000);

while (true)
{
    contador++;
    if (contador==2000)
    {
        
        break;
    }
    else
    {
        Console.WriteLine(":DDDDDDDDDDDDDDDDDDDDDDD");
    }
}