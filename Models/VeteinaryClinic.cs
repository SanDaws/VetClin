using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

    



    public static int IdGenereatorDog(List<Animal>Dogs){
        //this method will look in the vehicle list, look for the lenght, add +1, lok if that number is alredy, and give aditional number untill finds a non number
        int IdNew = Dogs.Count + 1;// based on the vehicle lenght he will give a number
        do
        {//search for the existance of newid, if alredy exist, increase the number untill there is no id in the list
            object? res = Dogs.FirstOrDefault(p => p.Id == IdNew);
            if (res != null)
            {
                IdNew += 1;
            }
            else if (res == null)
            {
                break;
            }
        } while (true);
        
        return IdNew;
    }
    
     public static int IdGenereatorCat(List<Cat> Cats){
        //this method will look in the vehicle list, look for the lenght, add +1, lok if that number is alredy, and give aditional number untill finds a non number
        int IdNew = Cats.Count + 1;// based on the vehicle lenght he will give a number
        do
        {//search for the existance of newid, if alredy exist, increase the number untill there is no id in the list
            object? res = Cats.FirstOrDefault(p => p.Id == IdNew);
            if (res != null)
            {
                IdNew += 1;
            }
            else if (res == null)
            {
                break;
            }
        } while (true);
        
        return IdNew;
    }
    
    
}


    /*
    https://www.gleek.io/blog/aggregation-vs-composition
    Basic explanation of why the graphyc is wrong
    */
