using CommunicationSystem.Telephone;
using System;
namespace CommunicationSystem
{

    public class WirelessPhone : Phone
	{
		private int _imei;
        // public string _manufacturer;
        // public string _model;


        public WirelessPhone(string manufacturer, string model, int imei) : base(manufacturer, model)
        {
            // _manufacturer = manufacturer;
            // _model = model;
            _imei = imei;
        }

        public new void SendText()
        {

            Console.WriteLine("All Wireless Phone can Send Text ");
        }
		public void ReceiveText() 
        {

            Console.WriteLine("All Wireless Phone can Receive Text ");

        }

		public int GetImei
		{
            get => _imei;
		}
       
    }
}
