using System;

public class Un75Model : Screen
{
    protected long upcNum;
    protected string orderCode;
    public Un75Model() 
	{
        orderCode = "UN75TU7000FXZA";
        upcNum = 887276400082;
        modelNumber = "UN75TU7000";
    }
    public override void SettingsCommand()
    {
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
