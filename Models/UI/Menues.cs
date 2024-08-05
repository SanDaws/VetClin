using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VetClin.Models;

namespace Simulacro.Models;

public static class Menues
{
    /*important thig:
    this menues works by recursivness
    that means i got no loops in for the running of the menues, it will always iterate the same function by itself
    */

    //Main menu for the User interface
    public static void MainMenu(){
    Util.Title("VetClinc",ConsoleColor.Magenta);//fancy Tittles
    Console.Write($@"
    oprima el numero de opcion  a la que decea acceder
    1: General
    2: Perros
    3: Gatos

    0: Salir
    ");
    //all the menues works the same
        ConsoleKeyInfo response = Console.ReadKey();
        switch (response.Key)
        {
            case ConsoleKey.D1:// General Menu
                GeneralMenu();
                break;
            case ConsoleKey.D2:// Dog Menu
                DogMenu();
                break;
            case ConsoleKey.D3: // CAt Menu
                CatMenu();
            break;
            case ConsoleKey.D0:// exit

                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("opcion no valida");
                MainMenu();

                break;
        }
    }
    //Drivers Menue
    public static void GeneralMenu(){
        Util.Title("Menu General",ConsoleColor.Blue);
        Console.Write($@"
    oprima el numero de opcion  a la que decea acceder
    1: Lista Conductores
    2: Nuevo registro de Conductor
    3: eliminar registro de Conductor
    4: 

    0: Salir
    ");
        ConsoleKeyInfo response = Console.ReadKey();
        switch (response.Key)
        {
            case ConsoleKey.D1://case read
                break;
            case ConsoleKey.D2:// case create
                break;
            case ConsoleKey.D3:// case Delete
                
                break;
                case ConsoleKey.D4:// 
                
                break;
            case ConsoleKey.D0:// case Return Menu

                MainMenu();
                break;

            default:
                Console.WriteLine("opcion no valida");
                GeneralMenu();
                break;
        }
    }

    public static void DogMenu(){
        Util.Title("Perros",ConsoleColor.Blue);
        Console.Write($@"
    oprima el numero de opcion  a la que decea acceder
    1: Listar usuarios Pasajeros
    2: Nuevo Registro de pasajero
    3: eliminar Registro de pasajero
    4: 
    5: 

    0: Salir
    ");
        ConsoleKeyInfo response = Console.ReadKey();
        switch (response.Key)
        {
            case ConsoleKey.D1://case read
                
                break;
            case ConsoleKey.D2:// case create
        
                break;
            case ConsoleKey.D3:// case delete
                
                break;
            case ConsoleKey.D4:// 
                
                break;
            case ConsoleKey.D5:
                
            break;
            case ConsoleKey.D0:// case exit

                MainMenu();
                break;

            default:
                Console.WriteLine("opcion no valida");
                DogMenu();

                break;
        }
    }
    public static void CatMenu(){
        Util.Title("Gatos",ConsoleColor.Blue);
        Console.Write($@"
    oprima el numero de opcion  a la que decea acceder
    1: Lista Conductores
    2: Nuevo registro de Conductor
    3: eliminar registro de Conductor
    4: 

    0: Salir
    ");
        ConsoleKeyInfo response = Console.ReadKey();
        switch (response.Key)
        {
            case ConsoleKey.D1://case read
                break;
            case ConsoleKey.D2:// case create
                break;
            case ConsoleKey.D3:// case Delete
                
                break;
                case ConsoleKey.D4:// 
                
                break;
            case ConsoleKey.D0:// case Return Menu

                MainMenu();
                break;

            default:
                Console.WriteLine("opcion no valida");
                CatMenu();
                break;
        }
    }
    
    //generic function to create  returns to the main menu, used for user experience
    public static void ReturnToMainMenu(){
        Console.WriteLine(" oprima cualquier boton para volver al menu...");
        Console.ReadKey();
        Console.Clear();
        MainMenu();
    }
}
