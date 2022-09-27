using System;
using System.Threading.Channels;
using System.Threading;
using System.Xml.Schema;
using System.Runtime.CompilerServices;

public abstract class Screen : IRemote
{
    private String modelName;
    private String modelNumber;
    private Boolean settings;
    private int volume;
    private int channel;
    private int previousChannel;
    private Boolean powerOn;
    private Boolean mute;
    private Boolean smartMenu;
    private string source;

    protected string ModelName { get => modelName; set => modelName = value; }
    protected string ModelNumber { get => modelNumber; set => modelNumber = value; }
    protected bool Settings { get => settings; set => settings = value; }
    protected int Volume { get => volume; set => volume = value; }
    protected int Channel { get => channel; set => channel = value; }
    protected int PreviousChannel { get => previousChannel; set => previousChannel = value; }
    protected bool PowerOn { get => powerOn; set => powerOn = value; }
    protected bool SmartMenu { get => smartMenu; set => smartMenu = value; }
    protected bool Mute { get => mute; set => mute = value; }
    protected string Source { get => source; set => source = value; }

    void IRemote.Power(string remoteCommand)
    {
        if (remoteCommand == "power" && powerOn == true)
        {
            this.powerOn = false;
            Console.Write("Power: Off");
        }
        else {
            this.powerOn = true;
            Console.Write("Power: On");
        }

    }

     void IRemote.Source(string command)
    {
        string sourceOptions = "[1]antenna [2][hdmi2] [3][hdmi2]";


       if (command == "source" && this.powerOn == true)
        {

        }
    }

    void IRemote.Channel(string command)
    {
        throw new NotImplementedException();
    }

    void IRemote.Info(string command)
    {
        throw new NotImplementedException();
    }

    void IRemote.Volume(string command)
    {
        throw new NotImplementedException();
    }

     public void displayScreen(string displayCommand)
    {
        Console.WriteLine("\t---------------------------------------");       
        Console.WriteLine("\t|                                     |");
        Console.WriteLine("\t|                                     |");
        Console.WriteLine("\t|                                     |");
        Console.WriteLine("\t|      "+displayCommand+          "             |");
        Console.WriteLine("\t|                                     |");
        Console.WriteLine("\t|                                     |");
        Console.WriteLine("\t|                                     |");
        Console.WriteLine("\t---------------------------------------");
    }
    public void screenMenu(Boolean ctrlScreenMenu)
    {
        Boolean introCheck = ctrlScreenMenu; //set to true to let menu run
    }

    public Screen(String id, String name) // Screen constructor
	 {
         modelName = name;
         modelNumber = id;
         settings = false;
         volume = 25;
         channel = 1;
         previousChannel = channel;
         powerOn = false;
         mute = false;
         smartMenu = false ;
     }
    /*
    public void remoteCommandHandler() //String id, String name
    {
        string remoteCommand="";
        // this.ModelNumber = id;
        //  this.ModelName = name;
        do
        {
            Console.WriteLine("Enter command");
            remoteCommand = Console.ReadLine();  
                powerCommand(remoteCommand);
                switch (remoteCommand)
                {
                    case "pwr":

                        break;
                    case "src":
                        break;
                    case "vol":
                        break;
                    case "last":
                        break;
                    case "mute":
                        break;
                    case "ch":
                        break;
                    case "menu":
                        break;
                    case "settings":
                        break;

                    default:
                        Console.WriteLine("Invalid Command\n");
                        continue;
                }
             while (remoteCommand != "quit") ;
        
        }
    }
    */




    }
