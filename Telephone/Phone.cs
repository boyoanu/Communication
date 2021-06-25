using System;
namespace CommunicationSystem.Telephone
{
	public abstract class Phone : IPhone

	{
		private string _manufacturer;
		private string _model;
        

        public void MakeCall() 
		{

			Console.WriteLine("All Phone can Make Calls ");
		}
		public void ReceiveCall() 
		{
			Console.WriteLine("All Phone can  Calls ");

		}

 

        public Phone(string manufacturer, string model)
		{
			_manufacturer = manufacturer;
			_model = model;
		}

		public string Manufacturer
		{
			get => _manufacturer;
		}

		public string Model

		{
			get => _model;
		}
	}


}
