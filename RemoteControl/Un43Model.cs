
using System.Threading.Channels;
using System.Threading;
using System.Net;

public class Un43Model : Screen
{
    //add upc 
    //
    protected long upcNum;
    protected string orderCode;
	public Un43Model() 
	{
        orderCode = "UN43TU7000FXZA ";
        upcNum = 887276400037;
    }
   
}

