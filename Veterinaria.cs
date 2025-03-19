using System;
using System.Collections.Generic;

public class Veterinaria{
       // Inicializa la lista para evitar NullReferenceException.
    private List<string> Mascoticas = new List<string>();

    public void RegistrarMascota(){

        Console.WriteLine("¿cuantas mascotas desea ingresar al sistema?");  
        int pets = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < pets; i++){

        Console.WriteLine($"Ingrese el nombre de cada mascota {i + 1}:");
        string name = Console.ReadLine();

        Console.WriteLine($"Especie {i + 1}:");
        string species = Console.ReadLine();

        Console.WriteLine($"Edad {i + 1}:");
        int age = int.Parse(Console.ReadLine());

        Mascoticas.Add(name);
        Console.WriteLine("mascota agregada correctamente");
        }

    }

    public void BuscarMascota(){
        Console.WriteLine("Ingrese el nombre de la mascota que desea buscar: ");
        string buscar_mascota = Console.ReadLine();

        string buscar = buscar_mascota;
        bool encontrado = false; //Se inicia con false porque, al comenzar, aún no se ha encontrado el elemento que buscas.

        foreach (string masco in Mascoticas)
        {
            if (masco == buscar)
            {
                Console.WriteLine("Se encontró: " + masco);
                encontrado = true;
                //Esto indica que el elemento ya se encontró, por lo que no es necesario seguir recorriendo la lista (de ahí el uso de break
                break; // Salimos del ciclo al encontrar el elemento
            }
        }
        if (!encontrado) //operador de negacion falso/verdadero, verdadero/falso
        {
            Console.WriteLine("No se encontró el nombre: " + buscar);
        }

    }

    public void MostrarMascotas(){

        foreach (string mascota in Mascoticas) {
            Console.WriteLine(mascota);
        }
    }
}














