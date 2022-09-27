
    public abstract class Screen : IRemote
    {
        private string modelName;
        private string modelNumber;
        private bool settings;
        private int volume;
        private int channel;
        private int previousChannel;
        private bool powerOn;
        private bool mute;
        private bool smartMenu;
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

        public void PowerCommand(string remoteCommand)
        {
            if (remoteCommand == "power" && this.powerOn == true)
            {
                this.powerOn = false;
                Console.Write("Power: Off");
            }
            else
            {
                this.powerOn = true;
                Console.Write("Power: On");
            }

        }

        public void SourceCommand(string remoteCommand)
        {
            string sourceOptions = "[1]antenna [2][hdmi2] [3][hdmi2]";


            if (remoteCommand == "source" && this.powerOn == true)
            {

            }
        }

        public void ChannelCommand(string remoteCommand)
        {
            throw new NotImplementedException();
        }

        public void InfoCommand(string remoteCommand)
        {
            throw new NotImplementedException();
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
            Console.WriteLine("\t|      " + displayCommand + "\t\t\t      |");
            Console.WriteLine("\t|                                     |");
            Console.WriteLine("\t|                                     |");
            Console.WriteLine("\t|                                     |");
            Console.WriteLine("\t---------------------------------------");
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
            smartMenu = false;
        }
    /*
        public void RemoteCommandHandler()
        {
            string remoteCommand = "";
            do
            {
                Console.Write("Enter Command: ");
                //remoteCommand = Console.ReadLine();
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
            }
            while (remoteCommand != "quit");

        }

    */
    static void RemoteCommandHandler(string command)
    {
        if (command == "pwr")
        {
            //do power command
        }
        else if (command == "src")
        {
            //do source command
        }
        else if (command == "ch")
        {
            //do channel command
        }
        else if (command == "ch+")
        {
            //do channel+ command
        }
        else if (command == "ch-")
        {
            //do channel- command
        }
        else if (command == "last")
        {
            //do last channel  command
        }
        else if (command == "vol+" || command == "vol-")
        {
           // Screen.VolumeCommand(command);
        }
        else if (command == "menu")
        {
            //do menu command
        }
        else if (command == "settings")
        {
            //do settings command
        }
        else { return; }
    }




}

