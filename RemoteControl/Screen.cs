
    public class Screen 
    {
        protected string modelName;
        protected string modelNumber;
        protected bool settings;
        protected int volume;
        protected int channel;
        protected int previousChannel;
        protected bool powerOn;
        protected bool mute;
        protected bool smartMenu;
        protected string source;

    
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
    
        public void PowerCommand()
        {
            if (this.powerOn == true)
            {
                this.powerOn = false;
                this.DisplayScreen("Power: Off");
            }
            else
            {
                this.powerOn = true;
                this.DisplayScreen("Power: On");
                Console.Clear();
                this.DisplayScreen("");
            }

        }

        public void SourceCommand()
        {
            Console.Clear();
            string sourceOptions = "[1]ANTENNA [2]HDMI1 [3]HDMI2";
            this.DisplayScreen("Sources: " + sourceOptions);
        
            if (this.powerOn == true)
            {
            Console.Write("Choose Source: ");
             string UserInput = Console.ReadLine();
                switch(UserInput){
                case "1":
                    this.source = "ANTENNA";
                    Console.Clear();
                    this.DisplayScreen("Source: " + this.source);
                    break;
                case "2":
                    this.source = "HDMI1";
                    Console.Clear();
                    this.DisplayScreen("Source: " + this.source);
                    break;
                case "3":
                    this.source = "HDMI2";
                    Console.Clear();
                    this.DisplayScreen("Source: " + this.source);
                    break;
                default:
                    Console.Clear();
                    this.DisplayScreen("Invalid Source");
                    break;
                }
      
            }
            else {Console.Clear(); this.DisplayScreen("Power Is Off, Turn It On");}
        }

        public void MuteCommand()
        {
            if (this.powerOn == true)
            {
                if (this.mute == false)
                {
                    this.mute = true;
                    Console.Clear();
                    this.DisplayScreen("Audio Muted");
                }
                else { this.mute = false; this.DisplayScreen(""); }
            }
            else { Console.Clear(); this.DisplayScreen("Power Is Off, Turn It On"); }
        }

        public void ChannelChange(int channel)
        {
            if (this.powerOn == true)
            {
                this.channel = channel;
                Console.Clear();
                this.DisplayScreen("Channel: " + this.channel.ToString());
            }
            else { Console.Clear(); this.DisplayScreen("Power Is Off, Turn It On"); }
        }
        public void ChannelUpCommand()
            {
                int maxChannel = 999;

                if (this.powerOn == true)
                {
                    if (this.channel <= maxChannel)
                    {
                        previousChannel = this.channel;
                        ++this.channel;
                    }
                Console.Clear();
                this.DisplayScreen("Channel: " + this.channel.ToString());
            }
            else { Console.Clear(); this.DisplayScreen("Power Is Off, Turn It On"); }
        }

        public void ChannelDownCommand()
        {
            int minChannel = 1;
        
            if (this.powerOn == true)
            {
                if (this.channel >= minChannel)
                {
                    previousChannel = this.channel;
                    --this.channel;
                }
                Console.Clear();
                this.DisplayScreen("Channel: " + this.channel.ToString());
             }
             else
              {
                  Console.Clear(); this.DisplayScreen("Power Is Off, Turn It On");
              }
        }

           public void LastChannelCommand()
            {
                if (this.powerOn == true)
                {
                    int temp = this.channel;
                    this.channel = this.previousChannel;
                    this.previousChannel = temp;
                Console.Clear();
                this.DisplayScreen("Channel: " + this.channel.ToString());
                }
                else { this.DisplayScreen("Power Is Off, Turn It On"); }
            }

           public virtual void SettingsCommand()
            {

            }
           public void VolumeUp()
           {
                    int maxVol = 100;
                if (this.powerOn == true)
                {
                    if (this.volume <= maxVol)
                    {
                        ++this.volume;
                    }
                Console.Clear();
                this.DisplayScreen("Volume: " + this.volume.ToString());
                }
                else { Console.Clear(); this.DisplayScreen("Power Is Off, Turn It On"); }
           }
            public void VolumeDown()
            {
                int minVol = 1;
                if (this.powerOn == true)
                {
                    if (this.volume >= minVol)
                    {
                        --this.volume;
                    }
                Console.Clear();
                this.DisplayScreen("Volume: " + this.volume.ToString());
                }
                else { Console.Clear(); this.DisplayScreen("Power Is Off, Turn It On"); }
            }


    public void DisplayScreen(string displayCommand)
            {
                Console.WriteLine("\tPower Status: " + this.powerOn);
                Console.WriteLine("\t|" + displayCommand+ "|\n");
         
            }

        public Screen() // Screen constructor
            {
                modelName="";
                modelNumber="";
                settings = false;
                volume = 25;
                channel = 1;
                previousChannel = channel;
                powerOn = false;
                mute = false;
                smartMenu = false;
                source="Antenna";
            }

}

