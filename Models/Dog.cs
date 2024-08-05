using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro.Models;

namespace VetClin.Models;

public class Dog:Animal
{
    //atributes
    public bool BreedingStatus;//an animal is castrated == true
    public string Temperament;
    public string MicrochipNumber;
   public  string BarkVolume;
    public string CoatType;

    //Method
    //constructor
    public Dog(string Name,DateOnly BirthDate,string Breed,string Color,double WeightInKg,string MicrochipNumber,string BarkVolume)
    :base(Name,BirthDate,Breed,Color,WeightInKg){
 
        this.MicrochipNumber=MicrochipNumber;
        this.BarkVolume=BarkVolume;
        FurrOrCoatLenghtSwitch();
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
    public void FurrOrCoatLenghtSwitch(){
            //establish a the breading status
        Console.WriteLine($@"{Name} Tiene pelaje :
        1: Sin Pelo
        2: Pelo Corto
        3: Pelo Mediano
        4: Pelo Largo
        ");
        ConsoleKeyInfo response=Console.ReadKey();
        switch (response.Key)
        {
            case ConsoleKey.D1:
            CoatType= "Sin Pelo";

            break;
            case ConsoleKey.D2:
            CoatType= "Pelo Corto";
            break;
            case ConsoleKey.D3:
            CoatType= "Pelo Mediano";

            break;
            case ConsoleKey.D4:
            CoatType= "Pelo Largo";
            break;
            
            
            default:
            Util.RedText("Opcion no Existente");
            FurrOrCoatLenghtSwitch();
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
    Console.WriteLine($"|{MicrochipNumber,20}|{BarkVolume,6}|{CoatType,10}|{BreedStatusTOtext(BreedingStatus),12}");
}
public void CastrateAnimal(){
    
    Console.WriteLine($@"{Name} se encuetra :
        1: si
        2: No");
        ConsoleKeyInfo response=Console.ReadKey();
        switch (response.Key)
        {
            case ConsoleKey.D1:
            BreedingStatus=true;
        if (BreedingStatus== false)
        {
            Util.RedText("Animal previamente castrado");
        }

            break;
            case ConsoleKey.D2:
            BreedingStatus= false;
            break;
            
            
            default:
            Util.RedText("Opcion no Existente");
            CastrateAnimal();
            break;
        }
        
    }
    public void Hairdress(){
        if(CoatType == "Sin Pelo"|| CoatType== "Pelo Corto"){
            Util.RedText("Pelo Demasiado corto para la operacion");
        }else{
            FurrOrCoatLenghtSwitch();
        Util.GreenText("Pelo cortado");
        }

    }

}
