
    static void introMenu(Boolean ctrlIntroMenu) {
        Boolean introCheck = ctrlIntroMenu; //set to true to let menu run
        int modelSelect;
        do
        {
            Console.WriteLine("[1] UN43  [2] UN50  [3] UN55  [4] UN58  [5] UN65  [6] UN70  [7] UN75");
            Console.Write("Select A TU7000 TV Model: ");
            modelSelect = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (modelSelect) {
                case 1:
                    Console.Clear();
                    Console.WriteLine("\n\n                 UN43TU7000 Selected");
                    Un43Model un43 = new Un43Model("43", "UN43TU7000"); //create a new screen and introduce a new menu              
                  //  un43.DisplayScreen("hello"); //temporary output to display
                    un43.VolumeCommand("vol+");
                un43.DisplayScreen("Volume");
                // un43.PowerCommand("he");
                DisplayRemote();
                    introCheck = false;
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("UN50TU7000 Selected");
                    introCheck = false;
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("UN55TU7000 Selected");
                    introCheck = false;
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("UN58TU7000 Selected");
                    introCheck = false;
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("UN65TU7000 Selected");
                    introCheck = false;
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("UN70TU7000 Selected");
                    introCheck = false;
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("UN75TU7000 Selected\n\n");
                    introCheck = false;
                    break;
                default:
                    Console.WriteLine("Invalid Model ID\n");
                    Console.Clear();
                    continue;
            }
        }
        while (introCheck);
    }

    //create remote 
    static void DisplayRemote()
    {
        Console.WriteLine("[PWR]   [SRC]");
        Console.WriteLine(" [1] [2] [3] ");
        Console.WriteLine(" [4] [5] [6] ");
        Console.WriteLine(" [7] [8] [9] ");
        Console.WriteLine("[-]        [PRE-CH]");
        Console.WriteLine(" [+] [MUTE] [↑]");
        Console.WriteLine("[VOL]      [Ch]");
        Console.WriteLine(" [+]        [↓]");
        Console.WriteLine("[Settings][Menu]");
    }
    

    // ============================Main=================================
    
        introMenu(true);
    
