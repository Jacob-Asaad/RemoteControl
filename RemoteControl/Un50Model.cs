using System;

public class Un50Model : Screen
{
    protected long upcNum;
    protected string orderCode;
    public Un50Model() 
	{
        orderCode = "UN50TU7000FXZA";
        upcNum = 887276402147;
        modelNumber = "UN50TU7000";
    }
    public override void SettingsCommand()
    {
        Console.Clear();
        Console.WriteLine("\n=====Current Information====");
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
