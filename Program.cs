using System;
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        { 
        Console.WriteLine("Ingrese información de su mascota:");
        Console.WriteLine("Nombre de la mascota:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Edad:");
        int edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Especie:");
        string especie = Console.ReadLine();

        Mascotas mascota1 = new Mascotas(nombre, edad, especie);
            mascota1.MostrarInformacion();
            mascota1.Vacunar();

        Veterinaria veterinaria1 = new  Veterinaria();
        veterinaria1.RegistrarMascota();
        veterinaria1.BuscarMascota();
        veterinaria1.MostrarMascotas();

        Console.ReadKey(); 
        }
    }

