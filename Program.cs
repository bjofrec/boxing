// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main()
    {
        List<object> listaDeObjetos = new List<object>();

        listaDeObjetos.Add(7);          
        listaDeObjetos.Add(28);         
        listaDeObjetos.Add(-1);           
        listaDeObjetos.Add(true);        
        listaDeObjetos.Add("chair");

         foreach (var objeto in listaDeObjetos)
        {
            Console.WriteLine(objeto);
        }

        int suma = 0; 

        foreach (var objeto in listaDeObjetos)
        {
            if (objeto is int)
            {
                suma += (int)objeto; 
            }
        }

        Console.WriteLine("La suma de los valores enteros es: " + suma);
    }
}