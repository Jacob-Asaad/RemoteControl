using System;

 interface IRemote //remote interface 
{
    void Power(string command);
    void Source(string command);
    void Channel(string command);
    void Info(string command);
    void Volume(string command);
}
