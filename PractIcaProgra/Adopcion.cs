using System;
using System.Collections.Generic;
using System.Text;

namespace PractIcaProgra
{
    class Adopcion
    {

        string nombreUsuario, tipo, nombreMascota;

        public Adopcion(Mascota mascota, Persona persona) {

            nombreUsuario = persona.nombre;
            tipo = mascota.tipo;
            nombreMascota = mascota.nombre;



            realizarAdopcion(nombreUsuario, tipo, nombreMascota);

        }

        


        public void realizarAdopcion(string nombreUsuario, string tipo, string nombreMascota)
        {
            if (tipo == "1")
            {
                tipo = "Perro";
            }
            else
            {
                tipo = "Gato";
            }
            Console.WriteLine("Hola: "+ nombreUsuario);
            Console.WriteLine("Felicidades adoptaste un: "+ tipo+ " Con el nombre de: "+ nombreMascota);
            Console.ReadLine();
        }
    }
}


