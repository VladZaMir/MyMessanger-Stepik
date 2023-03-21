using System;
using Newtonsoft.Json;

namespace MyMessanger_Stepik
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("RusAI", "Privet", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg);
            //{ "UserName":"RusAI","MessageText":"Privet","TimeStamp":"2023-03-21T11:23:35.8613075Z"}
            //RusAI < 21.03.2023 11:23:35 >: Privet
            
        }
    }
}