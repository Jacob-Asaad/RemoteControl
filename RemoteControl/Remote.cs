using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Threading;
using System.Runtime.CompilerServices;


public interface IRemote //remote interface 
{
    void powerCommand(string command);
    void sourceCommand(string command);
    void channelCommand(string command);
    void infoCommand(string command);
    void volumeCommand(string command);
}

public class Remote 
{

	
    public Remote()
    {
	}

}


