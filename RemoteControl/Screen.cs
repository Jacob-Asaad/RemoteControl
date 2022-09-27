
    public abstract class Screen 
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
    
        public void PowerCommand(string remoteCommand)
        {
            if (remoteCommand == "pwr" && this.powerOn == true)
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

        public void SourceCommand(string remoteCommand)
        {
            string sourceOptions = "[1]ANTENNA [2]HDMI1 [3]HDMI2";
            this.DisplayScreen("Sources: " + sourceOptions);
        
            if (remoteCommand == "src" && this.powerOn == true)
            {
                string UserInput = Console.ReadLine();
            switch(UserInput){
                case "1":
                    this.source = "ANTENNA";
                    this.DisplayScreen("Source: " + this.source);
                    Thread.Sleep(2500);
                    Console.Clear();
                    this.DisplayScreen("");
                    break;
                case "2":
                    this.source = "HDMI1";
                    this.DisplayScreen("Source: " + this.source);
                    Thread.Sleep(2500);
                    Console.Clear();
                    this.DisplayScreen("");
                    break;
                case "3":
                    this.source = "HDMI2";
                    this.DisplayScreen("Source: " + this.source);
                    Thread.Sleep(2500);
                    Console.Clear();
                    this.DisplayScreen("");
                    break;
                default:
                    this.DisplayScreen("Invalid Source");
                    Thread.Sleep(2500);
                    Console.Clear();
                    this.DisplayScreen("");
                    break;
            }
      
            }
       
        }
        public void MuteCommand()
        {
            if(this.mute == false)
            {
                this.mute = true;
                this.DisplayScreen("Audio Muted");
        }
            else { this.mute = false; this.DisplayScreen(""); }
        }
        public void ChannelCommand(string remoteCommand)
        {
        int maxChannel = 999;
        int minChannel = 1;
        if (remoteCommand == "ch+" && this.powerOn == true)
        {
            if (this.channel <= maxChannel)
            {
                previousChannel = this.channel;
                ++this.channel;
            }
            else { this.channel = this.channel; }
        }
        if (remoteCommand == "ch-" && this.powerOn == true)
        {
            if (this.channel >= minChannel)
            {
                previousChannel = this.channel;
                --this.channel;
            }
            else { this.channel = this.channel; }
        }
        this.DisplayScreen("Channel: " + this.channel.ToString());
    }

    public void LastChannel(string remoteCommand)
    {
        if (remoteCommand == "last" && this.powerOn == true)
        {
            this.channel = this.previousChannel;
            this.DisplayScreen("Channel: " + this.channel.ToString());
        }
    }

        public void InfoCommand(string remoteCommand)
       {
            Console.WriteLine("Model: " +this.modelName);
            Console.WriteLine("Model #: " +this.modelNumber);
            Console.WriteLine("Current Volume: " +this.volume);
            Console.WriteLine("Current Channel: " +this.channel);
            Console.WriteLine("Power State: " +this.powerOn);
            Console.WriteLine("Mute State: " +this.mute);
            Console.WriteLine("Smart Menu State: " +this.smartMenu);
        }

        public void VolumeCommand(string remoteCommand)
        {
            int maxVol = 100;
            int minVol = 1;
            if (remoteCommand == "vol+" && this.powerOn == true)
            {
                if (this.volume <= maxVol)
                {
                    ++this.volume;
                }
                else { this.volume = this.volume; }
            }
            if (remoteCommand == "vol-" && this.powerOn == true)
            {
                if (this.volume >= minVol)
                {
                    --this.volume;
                }
                else { this.volume = this.volume; }
            }
            this.DisplayScreen("Volume: " + this.volume.ToString());
        }

        public void DisplayScreen(string displayCommand)
        {
            Console.WriteLine("\t---------------------------------------");
            Console.WriteLine("\t|                                     |");
            Console.WriteLine("\t|                                     |");
            Console.WriteLine("\t|                                     |");
            Console.WriteLine("\t|                                     |");
            Console.Write("\t|" + displayCommand + "                   ");
            Console.WriteLine("        |");
            Console.WriteLine("\t|                                     |");
            Console.WriteLine("\t|                                     |");
            Console.WriteLine("\t|                                     |");
            Console.WriteLine("\t---------------------------------------");
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
        }
 
    







}

