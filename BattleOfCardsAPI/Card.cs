using System;
using System.Text;
using System.Runtime.Serialization;


namespace BattleOfCardsAPI
{
    [Serializable]
    public class Card : ISerializable
    {
        public string Name { get; set; }
        public int Coding { get; set; }
        public int Gaming { get; set; }
        public int SoftSkills { get; set; }
        public double CoffeeConsumption { get; set; }

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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name : {Name},Coding skill : {Coding},Gaming skill : {Gaming},Soft Skills : {SoftSkills}, Coffee Consuption : {CoffeeConsumption}");
            return sb.ToString();
        }
    }
    
}
