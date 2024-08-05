using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro.Models;

namespace VetClin.Models;

public class Cat:Animal
{
    //attributes
    public bool BreedingStatus;
    public string FurLength;
    //cosntructor
    public Cat(string Name,DateOnly BirthDate,string Breed,string Color,double WeightInKg)
    :base(Name,BirthDate,Breed,Color,WeightInKg){
        BredingStatusSwitch();
        FurrOrCoatLenghtSwitch();

    }


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
            FurLength= "Sin Pelo";

            break;
            case ConsoleKey.D2:
            FurLength= "Pelo Corto";
            break;
            case ConsoleKey.D3:
            FurLength= "Pelo Mediano";

            break;
            case ConsoleKey.D4:
            FurLength= "Pelo Largo";
            break;
            
            
            default:
            Util.RedText("Opcion no Existente");
            FurrOrCoatLenghtSwitch();
            break;
        }

    }

    public override void ShowInformation()
    {
       BasicReview();
    Console.WriteLine($"{FurLength,20}|{BreedStatusTOtext(BreedingStatus),12}");
    }

    public void CastrateAnimal(){
        BreedingStatus=true;
        if (BreedingStatus== false)
        {
            Util.RedText("Animal previamente castrado");
        }
        Menues.ReturnToMainMenu();
    }
    public void Hairdress(){
        if(FurLength == "Sin Pelo"|| FurLength== "Pelo Corto"){
            Util.RedText("Pelo Demasiado corto para la operacion");
        }else{
            FurLength= "Pelo Corto";
        }
    }

}

