/*Fibonacci: la secuencia de la naturaleza
Lea cuántos términos quiere e imprima la serie de Fibonacci: 0, 1, 1, 2, 3, 5, 8… 
Cada término es la suma de los dos anteriores. El truco vive en tres variables.*/
int Num,resultadoFuturo=0,resultadoAnterior=0, resultadoActual=0;

    Console.WriteLine("Porfavor dime cuantos terminos quieres de la serie de fibonacci");
Num = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < Num; i++)
    {
    if (i==1)
    {
        resultadoAnterior = 0;
        resultadoActual = 1;
        resultadoFuturo =  resultadoAnterior+ resultadoActual ;
    }
    else
    {
        resultadoAnterior = resultadoActual;
        resultadoActual = resultadoFuturo;
        resultadoFuturo = resultadoAnterior + resultadoActual;
       
    }
    

        Console.WriteLine($"soy fibonacci Futuro: {resultadoFuturo}");
       // Console.WriteLine($"soy fibonacci Pasado: {resultadoAnterior}");
        //Console.WriteLine($"soy fibonacci Actual: {resultadoActual}");
       
        Console.WriteLine($"Soy i {i}");
    }
