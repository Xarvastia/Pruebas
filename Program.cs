using System;

namespace Trabajo_Práctico_.net
{
    class Program
    {

                
        static void Main(string[] args)
        {
                //Se declaran las variables
                double numero= 0, suma = 0, total = 0, iva = 0;
                //Se solicita la cantidad de numeros decimales a ingresar para configurar un corte
                Console.WriteLine("Ingrese un número (0 para salir)");
                numero=Convert.ToDouble(Console.ReadLine());
                //Se itera de acuerdo a la configuración previa, realizando el ingreso y la suma de los numeros decimales
                while (numero != 0)
                {
                    suma=suma+numero;
                    Console.WriteLine("Ingrese un numero (0 para salir)");                
                    numero=Convert.ToDouble(Console.ReadLine());                    
                }
              
                //Al corte, calculo el total con iva 
                iva = suma * 0.21;
                total = suma + iva;
                //Muestro por consola dichos valores
                Console.WriteLine("Sumatoria, IVA, Suma+IVA: {0} {1} {2}", suma, iva, total);
        }
        static void Parte3(string[] args)
        {  
            //Declaración de variables 
            //puedo suponer que numero 1 será el mayor y el 3, el menor. Reutilizo variables
            int numero1 = 1, numero2 = 5, numero3 =3, aux;
            //comparo los dos primeros
            if (numero1 < numero2)
            {
                aux = numero1;
                numero1 = numero2;
                numero2 = aux;
            }

            //comparo 2 y 3, si 3 es menor que 2, es menor que 1 y ya está. Si no lo es, hay que intercambiar, y cambiar después los 3 lugares si aplica

            if (numero2 < numero3)
            {
                aux = numero2;
                numero2 = numero3;
                numero3 = aux;
                //si entra acá, ya 3 es el menor y no hace falta volverlo a tocar.
            }

            if (numero1 < numero2)
            {
                //Vuelvo a hacer la primera comprobación.
                aux = numero1;
                numero1 = numero2;
                numero2 = aux;
            }

            //pongo un comentario para ver qué tal

          //Se muestran por consola los numeros ingresados ordenados de mayor a menor
          Console.WriteLine("Numero ingresados ordenados de mayor a menor {0} {1} {2}", numero1, numero2, numero3);
        
        }
    }
}

