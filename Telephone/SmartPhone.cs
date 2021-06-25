using CommunicationSystem.Telephone;
using System;
namespace CommunicationSystem
{ 
public class SmartPhone : Phone
{
        private int _imei;
        

        public SmartPhone(string manufacturer, string model, int imei) : base(manufacturer, model)
        {
           _imei = imei;
        }


        public void Email() 
        
        {

            Console.WriteLine("All Smart Phone can Send and Receive E-mail ");
        }
		public void SurfWeb() 
        {
            Console.WriteLine("All Smart Phone can Surf the Web");
        }
		public void Multimedia() 
        {

            Console.WriteLine("All Smart Phone can Play Video and Audio");
        }

        public int GetImei
        {
            get => _imei;
        }



    }
}