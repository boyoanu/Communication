namespace CommunicationSystem.Telephone
{
    public abstract class PhoneBase
    {


        public abstract void MakeCall() { }




        public void ReceiveCall()
        {
            Console.WriteLine("All Phone can  Calls ");

        }
    }
}