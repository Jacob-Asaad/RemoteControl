
using System.Reflection;
public class Remote
{
    Screen screen;

    public Remote(Screen screenReference)
    {
        screen = screenReference;
    }

    public void changeChannel(string btnHandler)
    {
        screen.ChannelCommand(btnHandler);
    }
    public void powerCommand(string btnHandler)
    {
        screen.PowerCommand(btnHandler);
    }
    public void sourceCommand(string btnHandler)
    {
        screen.SourceCommand(btnHandler);
    }
    public void volumeCommand(string btnHandler)
    {
        screen.VolumeCommand(btnHandler);
    }
    public void muteCommand()
    {
        screen.MuteCommand();
    }
    public void channelCommand(string btnHandler)
    {
        screen.ChannelCommand(btnHandler);
    }

    public void lastChannelCommand(string btnHandler)
    {
        screen.LastChannel(btnHandler);
    }
 

    public void RemoteCommandHandler(string btnHandler)
    {
        
            switch (btnHandler) { 
            case "pwr" :
            powerCommand("pwr");      
            break;
            case "src":
            sourceCommand("src");
             break;
            case "mute":
                muteCommand();
            break;
            case "vol+":
            volumeCommand("vol+");
            break;
            case "vol-":
            volumeCommand("vol-");
            break;
            case "ch+":
            channelCommand("ch+");
            break;
            case "ch-":
            channelCommand("ch-");
            break;
            case "last":
               lastChannelCommand("last");
                break;
            default:
            Console.WriteLine("Invalid Model ID\n");
            Console.Clear();
            break;

             }

   }
    public void DisplayRemote()
    {
        Console.WriteLine("[PWR]   [SRC]");
        Console.WriteLine(" [1] [2] [3] ");
        Console.WriteLine(" [4] [5] [6] ");
        Console.WriteLine(" [7] [8] [9] ");
        Console.WriteLine("[-]        [PRE-CH]");
        Console.WriteLine(" [+] [MUTE] [↑]");
        Console.WriteLine("[VOL]      [Ch]");
        Console.WriteLine(" [-]        [↓]");
        Console.WriteLine("[Settings][Menu]");
    }












    /*
     public void RemoteCommandHandler(string btnHandler)
{
    do
    {
        switch{ btnHandler}
        if (btnHandler == "pwr")
        {
            powerCommand("pwr");
        }
        else if (btnHandler == "src")
        {
            sourceCommand("src");
        }
        else if (btnHandler == "ch")
        {

        }
        else if (btnHandler == "ch+")
        {
            //do channel+ command
        }
        else if (btnHandler == "ch-")
        {
            //do channel- command
        }
        else if (btnHandler == "last")
        {
            //do last channel  command
        }
        else if (btnHandler == "vol+" || btnHandler == "vol-")
        {
            volumeCommand(btnHandler);
        }
        else if (btnHandler == "menu")
        {
            //do menu command
        }
        else if (btnHandler == "settings")
        {
            //do settings command
        }
        else { return; }
    } 

    } while (btnHandler != "E");
}*/

}


