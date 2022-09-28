
using System.Reflection;
public class Remote
{
    Screen screen;

    public Remote(Screen screenReference)
    {
        screen = screenReference;
    }

    public void changeChannel(int btnHandler)
    {
        screen.ChannelChange(btnHandler);
    }
    public void powerCommand()
    {
        screen.PowerCommand();
    }
    public void sourceCommand()
    {
        screen.SourceCommand();
    }
   
    public void volumeUp()
    {
        screen.VolumeUp();
    }
    public void volumeDown()
    {
        screen.VolumeDown();
    }

    public void muteCommand()
    {
       screen.MuteCommand();
    }
    public void channelUpCommand()
     {
       screen.ChannelUpCommand();
     }
    public void channelDownCommand()
     {
       screen.ChannelDownCommand();
     }
    public void lastChannelCommand()
    {
        screen.LastChannelCommand();
    }
    public void settingsCommand()
    {
        screen.SettingsCommand();
        screen.DisplayScreen("");
    }
    public void showCommands()
    {
        screen.ShowCommands();
    }

    public void RemoteCommandHandler(string btnHandler)
    {
       
            switch (btnHandler) { 
            case "pwr" :
            powerCommand();      
            break;

            case "help":
            showCommands();
            break;

            case "src":
            sourceCommand();
             break;

            case "mute":
            muteCommand();
            break;

            case "vol+":
            volumeUp();
            break;

            case "vol-":
            volumeDown();
            break;

            case "ch+":
            channelUpCommand();
            break;

            case "ch-":
            channelDownCommand();
            break;

            case "last":
            lastChannelCommand();
            break;

            case "settings":
            settingsCommand();
            break;

            default:
                int.TryParse(btnHandler, out int value); //used to allow user to enter numbers and automatically change the channel
                changeChannel(value);
            break;

             }
   }
    public void DisplayRemote()
    {
        Console.WriteLine("[pwr]   [src]");
        Console.WriteLine(" [1] [2] [3] ");
        Console.WriteLine(" [4] [5] [6] ");
        Console.WriteLine(" [7] [8] [9] ");
        Console.WriteLine(" [-] [0] [PRE-CH]");
        Console.WriteLine(" [+] [mute] [↑]");
        Console.WriteLine("[vol]      [ch]");
        Console.WriteLine(" [-] [help] [↓]");
        Console.WriteLine("[settings][exit]");
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


