using System;
using System.Runtime.Serialization;


namespace BattleOfCardsAPI
{
    [Serializable]
    public class Card : ISerializable
    {
        public string Name { get; private set; }
        public int Coding { get; private set; }
        public int Gaming { get; private set; }
        public int SoftSkills { get; private set; }
        public double CoffeeConsumption { get; private set; }

        // Initializes Card
        public Card(string name, int coding, int gaming, int softSkills, double coffeeConsumption)
        {
            Name = name;
            Coding = coding;
            Gaming = gaming;
            SoftSkills = softSkills;
            CoffeeConsumption = coffeeConsumption;
        }
        public Card()
        {

        }

        // Helper method for serialization
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Coding", Coding);
            info.AddValue("Gaming", Gaming);
            info.AddValue("SoftSkills", SoftSkills);
            info.AddValue("CoffeeConsumption", CoffeeConsumption);

        }

        // Helper method for serialization
        public Card(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Coding = (int)info.GetValue("Coding", typeof(int));
            Gaming = (int)info.GetValue("Gaming", typeof(int));
            SoftSkills = (int)info.GetValue("SoftSkills", typeof(int));
            CoffeeConsumption = (double)info.GetValue("CoffeeConsumption", typeof(double));
        }
    }
}
