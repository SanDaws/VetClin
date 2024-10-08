using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Simulacro.Models;

namespace VetClin.Models;

public class VeteinaryClinic
{
    //atributes
    public string Name;
    public string Address;
    public List<Dog> Dogs;
    public List<Cat> Cats;

    public VeteinaryClinic(){
        Dogs=new List<Dog>();
        Cats= new List<Cat>();   
    }
    public VeteinaryClinic(string name,string address){
        Name=name;
        Address=address;
    }
    //creating
    public void SaveDog(Dog newDog){//add a new dog to the list
        Dogs.Add(newDog);
        Util.GreenText("Registro Satisfactorio de Mascota");

        Menues.ReturnToMainMenu();
    }
    
     public void SaveCat(Cat newCat){//add a new cat to the list
        Cats.Add(newCat);
        Util.GreenText("Registro Satisfactorio de Mascota");

        Menues.ReturnToMainMenu();
    }

    
    //Updating
    public void updateDog(Dog dog){
        //change the public things dog got
        Util.Title("Modificacndo perro",ConsoleColor.Yellow);

        Console.Write($"{Name} tiene : {dog.BarkVolume} el nueevo valor seria:");
        dog.BarkVolume= Exceptions.SafeEMptyorNull();

        dog.CastrateAnimal();

        dog.Hairdress();

        Console.Write($"{Name} tiene : {dog.MicrochipNumber} el nueevo valor seria:");
        dog.MicrochipNumber= Exceptions.SafeEMptyorNull();


        Menues.DogMenu();


    }

    public void updateCat(Cat cat){
        //allow to change pulic attributes of cat
        cat.Hairdress();
        
        cat.CastrateAnimal();

        Menues.CatMenu();

    }
    //deleting
    public void DeleteDog(Dog dog){//because is a bad practice to mutate to public some protected attribute, i used the object itself insted of his id, that search will be make it in the class itself
        Dogs.Remove(dog);
        Util.GreenText($"registro Eliminado satisfactoriamente ");
        Console.ReadKey();
        Menues.DogMenu();
    }
    public void Deletecat(Cat cat){//because is a bad practice to mutate to public some protected attribute, i used the object itself insted of his id, that search will be make it in the class itself
        Cats.Remove(cat);
        Util.GreenText($"registro Eliminado satisfactoriamente ");
        Console.ReadKey();
        Menues.CatMenu();

    }
    //Show
    public void ShowAllPatients(){
        Util.Title("Todos los pacientes",ConsoleColor.Blue);
        foreach (var dog in Dogs)
        {
            dog.ShowInformation();
        }
        foreach (var cat in Cats)
        {
            cat.ShowInformation();
        }
         Menues.ReturnToMainMenu();
    }
    public void ShowAnimals(string type){// it was not specificate what Type was, so as used as generic printing for each list
         Util.Title($"{type}",ConsoleColor.Blue);
         if (type=="perro")
         {
            foreach (var dog in Dogs)
        {
            dog.ShowInformation();
        }
            
         }else if (type=="gato")
         {
            foreach (var cat in Cats)
        {
            cat.ShowInformation();
        }
         }

         Menues.ReturnToMainMenu();

       
    }
    public void ShowPatient(string idPatient){
         Util.Title("Todos los pacientes",ConsoleColor.Blue);
        
         Dog dg= Dog.SearchDog(Dogs,idPatient);
         Cat ct= Cat.Searchcat(Cats,idPatient);
         if (dg == null & ct== null )
         {
            Util.RedText("Animal no encotrontrado");
            Menues.ReturnToMainMenu();
         }else{
            if (dg!=null)
            {
                dg.ShowInformation();
            }
            if (ct!= null)
            {
                ct.ShowInformation();
            }
            Menues.ReturnToMainMenu();
         }

    }

    


    
    
}


    /*
    https://www.gleek.io/blog/aggregation-vs-composition
    Basic explanation of why the graphyc is wrong
    */
