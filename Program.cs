using Console_App_Project_First_Year;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.IO.Pipes;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
public class Program
{

    public static void Main()
    {
        bool run = true;

        //Palagyan ulit dito nung parang laro na choices
        //yung nagkakahighlight ganun
        Print.InCenter("New reviewer or Load Preset? : ");
        string response = Console.ReadLine();

        if (response == "Load Preset")
        {
            Start.LoadPreset();
        }
        LoadingScreen.Animation();

        do {
            
            Start.Menu();
            Start.Choice();




        } while (run);
        Start.Exit();
    }
}

   


    