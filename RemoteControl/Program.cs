 //COMP 586 - Project 1 - Remote Control - Jacob Asaad
    //jacob push test
    //hi
    // vishnu
    static bool ErrorCheck(string input)
    {
        if (int.TryParse(input, out int result))
        {
            return true;
        }
         else
        {
            switch (input)
            {
            case "pwr":
                return true;
          
            case "src":
                return true;

            case "help":
                return true;

            case "mute":
                return true;

            case "vol+":
                return true;

            case "vol-":
                return true;

            case "ch+":
                return true;

            case "ch-":
                return true;

            case "last":
                return true;

            case "settings":
                return true;
            default:
                return false;    
            }
        }
    }
    

    static void introMenu(Boolean ctrlIntroMenu) {
        Boolean introCheck = ctrlIntroMenu; //set to true to let menu run
        int modelSelect;
        Remote remote;
      
    do
        {
            Console.WriteLine("[1] UN43  [2] UN50  [3] UN55  [4] UN58  [5] UN65  [6] UN70  [7] UN75");
            Console.Write("Select A TU7000 TV Model: ");
            modelSelect = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
       
        switch (modelSelect) {

             case 1:
                    Console.Clear();
                    Un43Model un43 = new Un43Model(); //create a new screen and introduce a new menu              
                    remote = new Remote(un43);
                    un43.DisplayScreen("");
                    string userInput;
                        remote.DisplayRemote();  
                     do
                        {
                        Console.WriteLine();
                        Console.Write("Enter Command: ");
                        userInput = Console.ReadLine();
                        Console.WriteLine();
                        bool isValid = ErrorCheck(userInput);
                        if (isValid)
                        {
                            remote.RemoteCommandHandler(userInput);
                            remote.DisplayRemote();
                        }
                        else { Console.WriteLine("Invalid Input"); }

                    } while (userInput != "exit");
               
                    introCheck = false;
                    break;

            case 2:
                Console.Clear();
                Un50Model un50 = new Un50Model(); //create a new screen and introduce a new menu              
                remote = new Remote(un50);
                un50.DisplayScreen("");
                string userInput2;
                remote.DisplayRemote();

                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enter Command");
                        userInput2 = Console.ReadLine();
                        bool isValid = ErrorCheck(userInput2);
                        if (isValid)
                        {
                            remote.RemoteCommandHandler(userInput2);
                            remote.DisplayRemote();
                        }
                    else { Console.WriteLine("Invalid Input"); }
                } while (userInput2 != "exit");

                introCheck = false;
                break;

            case 3:
                Console.Clear();
                Un55Model un55 = new Un55Model(); //create a new screen and introduce a new menu              
                remote = new Remote(un55);
                un55.DisplayScreen("");
                string userInput3;
                remote.DisplayRemote();

                    do
                    {
                        Console.WriteLine();
                        Console.Write("Enter Command: ");
                        userInput3 = Console.ReadLine();
                        Console.WriteLine();
                        bool isValid = ErrorCheck(userInput3);
                        if (isValid)
                        {
                            remote.RemoteCommandHandler(userInput3);
                            remote.DisplayRemote();
                        }
                        else { Console.WriteLine("Invalid Input"); }

                    } while (userInput3 != "exit");

                introCheck = false;
                break;

            case 4:
                Console.Clear();
                Un58Model un58 = new Un58Model(); //create a new screen and introduce a new menu              
                remote = new Remote(un58);
                un58.DisplayScreen("");
                string userInput4;
                remote.DisplayRemote();

                do
                {
                    Console.WriteLine();
                    Console.Write("Enter Command: ");
                    userInput4 = Console.ReadLine();
                    Console.WriteLine();
                    bool isValid = ErrorCheck(userInput4);
                    if (isValid)
                    {
                        remote.RemoteCommandHandler(userInput4);
                        remote.DisplayRemote();
                    }
                    else { Console.WriteLine("Invalid Input"); }

                } while (userInput4 != "exit");

                introCheck = false;
                break;

            case 5:
                Console.Clear();
                Un65Model un65 = new Un65Model(); //create a new screen and introduce a new menu              
                remote = new Remote(un65);
                un65.DisplayScreen("");
                string userInput5;
                remote.DisplayRemote();
                    do
                    {
                        Console.WriteLine();
                        Console.Write("Enter Command: ");
                        userInput5 = Console.ReadLine();
                        Console.WriteLine();
                        bool isValid = ErrorCheck(userInput5);
                        if (isValid)
                        {
                            remote.RemoteCommandHandler(userInput5);
                            remote.DisplayRemote();
                        }
                        else { Console.WriteLine("Invalid Input"); }

                    } while (userInput5 != "exit");

                introCheck = false;
                break;

             case 6:
                Console.Clear();
                Un70Model un70 = new Un70Model(); //create a new screen and introduce a new menu              
                remote = new Remote(un70);
                un70.DisplayScreen("");
                string userInput6;
                remote.DisplayRemote();
                    do
                    {
                        Console.WriteLine();
                        Console.Write("Enter Command: ");
                        userInput6 = Console.ReadLine();
                        Console.WriteLine();
                        bool isValid = ErrorCheck(userInput6);
                        if (isValid)
                        {
                            remote.RemoteCommandHandler(userInput6);
                            remote.DisplayRemote();
                        }
                        else { Console.WriteLine("Invalid Input"); }

                    } while (userInput6 != "exit");

                introCheck = false;
                break;

             case 7:
                Console.Clear();
                Un75Model un75 = new Un75Model(); //create a new screen and introduce a new menu              
                remote = new Remote(un75);
                un75.DisplayScreen("");
                string userInput7;
                remote.DisplayRemote();

                do
                    {
                        Console.WriteLine();
                        Console.Write("Enter Command: ");
                        userInput7 = Console.ReadLine();
                        Console.WriteLine();
                        bool isValid = ErrorCheck(userInput7);
                        if (isValid)
                        {
                            remote.RemoteCommandHandler(userInput7);
                            remote.DisplayRemote();
                        }
                        else { Console.WriteLine("Invalid Input"); }

                    } while (userInput7 != "exit");

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

// ============================Main=================================

introMenu(true);
    
