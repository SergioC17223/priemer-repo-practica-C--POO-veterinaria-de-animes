using System;
using System.Collections.Generic;


public class Mascotas
{
    private string Nombre;
    private int Edad;
    private string Especie;
    private List<string> vacunas;

    public Mascotas(string nombre,int edad,  string especie  ){
        this.Nombre = nombre;
        this.Edad = edad;
        this.Especie = especie;
        vacunas = new List<string>();
    }

    public void Vacunar(){
        Console.WriteLine("su mascota tiene 3 vacunas, ¿desea agregar una nuva vacuna a su mascota?");
        Console.WriteLine(" selecione 1:Si");
        Console.WriteLine(" selecione 2:No");
        int x = int.Parse(Console.ReadLine());

        if( x == 1){
            vacunas.Add("Nueva vacuna");
        Console.WriteLine("Listo, vacuna agregada con exito");
        }
        else{
            Console.WriteLine("Vacuna negada");
        }
    }

    public void MostrarInformacion(){
        Console.WriteLine($"nombre: {Nombre}, edad: {Edad}, especie: {Especie} ");

    }
}