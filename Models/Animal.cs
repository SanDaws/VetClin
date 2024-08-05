using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetClin.Models;

public abstract class Animal
{
    //attributes
    protected int id;
    protected string Name;
    protected DateOnly BirthDate;
    protected string Breed;
    protected string Color;
    protected double WeightInKg;
    //cosntructor
    public Animal(string Name,DateOnly BirthDate,string Breed,string Color,double WeightInKg){
        //id=VeteinaryClinic.VehicleIdGenerator();
        this.Name=Name;
        this.BirthDate=BirthDate;
        this.Breed=Breed;
        this.Color=Color;
        this.WeightInKg=WeightInKg;

    }
    public abstract void ShowInformation();// this should be Virtual insted of abstract for an easy implementation and scalation

    protected void BasicReview(){
        
        Console.Write($"{id,20}|{Name,20}|{Breed,30}|{Color,20}|{WeightInKg,6}|{CalculateAgeInMonths(),15}");
    }
    


    protected int CalculateAgeInMonths(){
        int months;
        DateOnly now=DateOnly.FromDateTime(DateTime.Now);
        months= (BirthDate.Year-now.Year)*12;
        months+=now.Month;
        return months;
    }

    protected string BreedStatusTOtext(bool condition){
        return(condition== true)?"Castrado":"Sin Castrar";
    }
    
    

}
