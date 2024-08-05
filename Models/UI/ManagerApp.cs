using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro.Models;

namespace VetClin.Models.UI;

public static class ManagerApp
{
    public static Dog CreateDog(){
        Util.Title("Nuevo Perro",ConsoleColor.DarkGreen);
        //Name
        Console.Write("Nombre del Conductor: ");
        string name= Exceptions.SafeEMptyorNull();
        //b-day
        DateOnly birthDate= Exceptions.SafeDateonly();
        //breed
        Console.Write("Raza: ");
        string breed=Exceptions.SafeEMptyorNull();
        //color
        Console.Write("Color: ");
        string color= Exceptions.SafeEMptyorNull();
        //weight
        double weightInKg= Exceptions.SafeDouble("Peso en Kilogramos(Kg)");
        //Microchip
        Console.Write("Numero de Microchip: ");
        string MicrochipNumber= Exceptions.SafeEMptyorNull();
        //Bark volume
        Console.Write("Ladrido: ");
        string BarkVolume= Exceptions.SafeEMptyorNull();




        

        Dog newDog= new Dog(0,name,birthDate,breed,color,weightInKg,MicrochipNumber,BarkVolume); 
        return newDog;
    }
    public static Cat CreateCat(){
        Util.Title("Nuevo Gato",ConsoleColor.DarkGreen);
        //Name
        Console.Write("Nombre del Conductor: ");
        string name= Exceptions.SafeEMptyorNull();
        //b-day
        DateOnly birthDate= Exceptions.SafeDateonly();
        //breed
        Console.Write("Raza: ");
        string breed=Exceptions.SafeEMptyorNull();
        //color
        Console.Write("Color: ");
        string color= Exceptions.SafeEMptyorNull();
        //weight
        double weightInKg= Exceptions.SafeDouble("Peso en Kilogramos(Kg)");

        Cat NewCat= new Cat(0,name,birthDate,breed,color,weightInKg);
        return NewCat;


    }  
}
