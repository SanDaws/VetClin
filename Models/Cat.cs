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
        if(FurLength == "Sin Pelo"|| FurLength== "Pelo Corto"){
            Util.RedText("Pelo Demasiado corto para la operacion");
        }else{
            FurrOrCoatLenghtSwitch();
        Util.GreenText("Pelo cortado");
        }
    }
    public static Cat Searchcat(List<Cat> cats){
        Util.Title("Buscar Gato",ConsoleColor.DarkYellow);
        Console.Write("Id del gato");
        string id= Exceptions.SafeEMptyorNull();
        Cat? resultCat= cats.FirstOrDefault(p=> p.Id==Guid.Parse(id));
        if (resultCat!= null)
        {
            return resultCat;
        }
        else
        {
            Util.RedText("Cat not found");
            Searchcat(cats);
        }
        return null;//the loop before will avoid this, but hte program need it
        

    }
    public static Cat Searchcat(List<Cat> cats,string id){
        
        Cat? resultCat= cats.FirstOrDefault(p=> p.Id==Guid.Parse(id));
        if (resultCat!= null)
        {
            return resultCat;
        }
        else
        {
            Util.RedText("Cat not found");
            return null;//
        }
        
        

    }

}

