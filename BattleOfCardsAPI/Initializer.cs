using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace BattleOfCardsAPI
{
    public class Initializer
    {
        private string filePathCardGame = "CardGame.xml";
        

        public Initializer()
        {
            DeserializerCards();
        }
        // Deserializes Cards from XML
        public List<Card> DeserializerCards()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Card>), new XmlRootAttribute("Cards"));

            if (File.Exists(filePathCardGame) && new FileInfo(filePathCardGame).Length > 0)
            {
                using (FileStream fs = File.OpenRead(filePathCardGame))
                {
                    return (List<Card>)serializer.Deserialize(fs);
                }
            }
            else
            {
                throw new FileNotFoundException("The file is doesn't exist");
            }

        }
    }
}
