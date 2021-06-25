using System;
namespace CommunicationSystem
{

    interface IPhone
    {
        string Manufacturer { get; }
        string Model { get; }


        void MakeCall();
        void ReceiveCall();
       
    }
}