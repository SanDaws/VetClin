using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro.Models;

namespace VetClin.Models;

public class Dog:Animal
{
    //atributes
    bool BreedingStatus;//an animal is castrated == true
    string Temperament;
    string MicrochipNumber;
    string BarkVolume;
    string CoatType;

    //Method
    //constructor
    public Dog(string Name,DateOnly BirthDate,string Breed,string Color,double WeightInKg,string MicrochipNumber,string BarkVolume, string CoatType):base(Name,BirthDate,Breed,Color,WeightInKg){
        this.MicrochipNumber=MicrochipNumber;
        this.BarkVolume=BarkVolume;
        this.CoatType=CoatType;
        BredingStatusSwitch();
        TemperamentSwitch();

    }
    //util breeding switch
    public void BredingStatusSwitch(){
        //establish a the breading status
        Console.WriteLine($@"{Name} se encuetra :
        1: Castrado
        2: Sin Castrar");
        ConsoleKeyInfo response=Console.ReadKey();
        switch (response.Key)
        {
            case ConsoleKey.D1:
            BreedingStatus= true;

            break;
            case ConsoleKey.D2:
            BreedingStatus= false;
            break;
            
            
            default:
            Util.RedText("Opcion no Existente");
            BredingStatusSwitch();
            break;
        }


    }
    public void TemperamentSwitch(){
        //Establish the Temperament of the animal
        Console.WriteLine($@"{Name} tiene temperamento :
        1:Timido
        2:Normal
        3:Agresivo");
        ConsoleKeyInfo response=Console.ReadKey();
        switch (response.Key)
        {
            case ConsoleKey.D1:
            Temperament= "Timido";
            break;
            case ConsoleKey.D2:
            Temperament= "Normal";
            break;
            case ConsoleKey.D3:
            Temperament= "Agresivo";
            break;
            default:
            Util.RedText("Opcion no Existente");
            TemperamentSwitch();
            break;
            
        }


    }

public override void ShowInformation()
{
    BasicReview();
    Console.WriteLine($"{MicrochipNumber,20}{BarkVolume,6},{CoatType,10}");
}

}
