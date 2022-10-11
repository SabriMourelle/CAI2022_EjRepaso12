using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjRepaso12
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio XII
            //Crear una aplicación que, cuando el usuario ingrese dos fechas distintas, calcule la
            //diferencia entre éstas y la muestre por pantalla, indicando años, meses y días por
            //separado(en base 365).
            //Por ejemplo, si ingreso las fechas 23 / 09 / 1993 y 09 / 04 / 1997, la aplicación devolverá por
            //pantalla “La diferencia es de 3 años, 6 meses y 19 días”. 

            DateTime fecha1;
            DateTime fecha2;
            double diferencia;
            double totalDias;
            double dias;
            double meses;
            double años;
           


            Console.WriteLine("Ingrese una fecha");
            fecha1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otra fecha");
            fecha2 = DateTime.Parse(Console.ReadLine());
            totalDias = Math.Abs((fecha1 - fecha2).TotalDays);
            //30.6 días x mes

            años = Math.Floor(totalDias / 365);
            diferencia = Math.Floor(totalDias - (años * 365));
            meses = Math.Floor(diferencia / 31);
            diferencia = diferencia - (meses * 31);
            dias = diferencia;

            Console.WriteLine("La diferencia entre " + fecha1 + " y " + fecha2 + " es:");
            Console.WriteLine(años + " años");
            Console.WriteLine(meses + " meses");
            Console.WriteLine(dias + " días.");
            Console.ReadKey();
        }
    }
}
