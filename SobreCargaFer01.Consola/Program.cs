using SobreCargaFer01.Entidades;

namespace SobreCargaFer01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Overload!");
            var tiempo1 = new Tiempo(10, 10, 10);
            var tiempo2 = new Tiempo(12, 57);
            var tiempo3 = new Tiempo(19);
            var tiempo4= new Tiempo(2,2,2);
            Console.WriteLine(tiempo1.MostrarDatos(true));
            Console.WriteLine(tiempo2.MostrarDatos());
            Console.WriteLine(tiempo3.MostrarDatos());
            Console.WriteLine(tiempo4.MostrarDatos());
            Tiempo tiempo5 = tiempo1;
            Tiempo tiempo6 = new Tiempo(10, 10, 10);
            //tiempo1.SetHora(7);
            Console.WriteLine(tiempo5==tiempo1);
            Console.WriteLine(tiempo6==tiempo1);
            Console.WriteLine(tiempo1.MostrarDatos());
            Console.WriteLine(tiempo5.MostrarDatos());
            Console.WriteLine(tiempo6.MostrarDatos());


            int segundos = tiempo1;
            Console.WriteLine(segundos);

            Tiempo nuevoTiempo =(Tiempo) "23:15:07";
            Console.WriteLine(nuevoTiempo.MostrarDatos());
            Tiempo sumaTiempo = tiempo1 + tiempo2;
            Console.WriteLine(sumaTiempo.MostrarDatos());
        }
    }
}