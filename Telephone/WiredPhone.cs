using CommunicationSystem.Telephone;
using System;
namespace CommunicationSystem
{
    public class WiredPhone : Phone
    {

        
        public string keyType;

        public WiredPhone(string manufacturer, string model) : base(manufacturer, model)
        {
            keyType = KeyType;
        }


        public static string KeyType
        {
            get
            {
                return KeyType;
            }
        }
    }
}
