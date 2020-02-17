using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace BattleOfCardsAPI
{
    class Initializer
    {
        private string filePathCardGame = @"..\\..\\..\\CardGame.xml";
        private List<Card> listOfCards = new List<Card>();

        // Deserializes Cards from XML
        public void DeserializerCards()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Card>));

            if (File.Exists(filePathCardGame) && new FileInfo(filePathCardGame).Length > 0)
            {
                using (FileStream fs = File.OpenRead(filePathCardGame))
                {
                    listOfCards = (List<Card>)serializer.Deserialize(fs);
                }
            }

        }
    }
}
