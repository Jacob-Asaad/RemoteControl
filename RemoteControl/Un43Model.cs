
using System.Threading.Channels;
using System.Threading;
using System.Net;
using System.Security.Cryptography.X509Certificates;

public class Un43Model : Screen
{
 
    protected long upcNum;
    protected string orderCode;
	public Un43Model() 
	{
        orderCode = "UN43TU7000FXZA ";
        upcNum = 887276400037;
        modelNumber = "UN43TU7000";
    }
    public override void SettingsCommand() {
        Console.Clear();
        Console.WriteLine("=====Current Information====");
        Console.WriteLine("Model #: " + this.modelNumber);
        Console.WriteLine("UPC #: " + this.upcNum);
        Console.WriteLine("Order Code: " + this.orderCode);
        Console.WriteLine("Current Volume: " + this.volume);
        Console.WriteLine("Current Channel: " + this.channel);
        Console.WriteLine("Power State: " + this.powerOn);
        Console.WriteLine("Mute State: " + this.mute);
        Console.WriteLine("Smart Menu State: " + this.smartMenu);
        Console.WriteLine("Current Source: " + this.source);
        Console.WriteLine("============================\n");

    }

}

