using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetClin.Models;

public abstract class Animal
{
    //attributes
    protected Guid Id;
    protected string Name;
    protected DateOnly BirthDate;
    protected string Breed;
    protected string Color;
    protected double WeightInKg;
    //cosntructor
    public Animal(string Name,DateOnly BirthDate,string Breed,string Color,double WeightInKg){
        Id= Guid.NewGuid();
        this.Name=Name;
        this.BirthDate=BirthDate;
        this.Breed=Breed;
        this.Color=Color;
        this.WeightInKg=WeightInKg;

    }
    public abstract void ShowInformation();// this would be Virtual insted of abstract for an easy implementation and scalation

    protected void BasicReview(){//shows the basic data of the animal
        
        Console.Write($"{Id,30}|{Name,20}|{Breed,30}|{Color,20}|{WeightInKg,6}|{CalculateAgeInMonths(),15}");
    }
    


    protected int CalculateAgeInMonths(){ // returns a the total of months alive of the animal
        int months;
        DateOnly now=DateOnly.FromDateTime(DateTime.Now);
        months= (now.Year-BirthDate.Year)*12;
        months+=now.Month;
        return months;
    }

    protected string BreedStatusTOtext(bool condition){// String method for printing in the sons class
        return(condition== true)?"Castrado":"Sin Castrar";
    }
    
    

}
