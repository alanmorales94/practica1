using System;

namespace PractIcaProgra
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            Mascota mascota = new Mascota();

            Console.WriteLine("Ingresa tu nombre:");
            persona.nombre = Console.ReadLine();
            Console.WriteLine("Que edad tienes?");
            persona.edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nonmbre de tu mascota");
            mascota.nombre = Console.ReadLine();
            Console.WriteLine("Que animal quieres perro o gato?");
            Console.WriteLine("1. Perro");
            Console.WriteLine("2. Gato");
            string opc = Console.ReadLine();

            Console.WriteLine("Que raza prefieres?");
            mascota.raza=Console.ReadLine();
            mascota.tipo = opc;

            
            Adopcion adopt = new Adopcion(mascota, persona);

        }
    }

    
}
