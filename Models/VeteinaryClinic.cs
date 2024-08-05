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
    public void SaveDog(Dog newDog){
        Dogs.Add(newDog);
        Util.GreenText("Registro Satisfactorio de Mascota");
        Menues.ReturnToMainMenu();
    }
    
     public void SaveCat(Cat newCat){
        Cats.Add(newCat);
        Util.GreenText("Registro Satisfactorio de Mascota");
        Menues.ReturnToMainMenu();
    }
    
    //Updating
    public void updateDog(Dog dog){}

    public void updateCat(Cat cat){}
    //deleting
    public void DeleteDog(int id){
    }
    public void Deletecat(int id){

    }
    //Show
    public void ShowAllPatients(){}
    public void ShowAnimals(string type){
        //List<Animal> dogRes= Dogs.Where(x=> x.)
    }
    public void ShowPatient(int idPatient){}


    
    
}


    /*
    https://www.gleek.io/blog/aggregation-vs-composition
    Basic explanation of why the graphyc is wrong
    */
