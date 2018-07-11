using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Memory.Pages
{
    public class BoardCreator
    {
        private List<Card> ListOfAvailibleCards = new List<Card>();


        public string getJsonOfCards()
        {
            string jsonString="[";
            //var serialized = JsonConvert.SerializeObject(ListOfAvailibleCards[0]);
            
            for(int i = 0; i < ListOfAvailibleCards.Count; i++)
            {
                jsonString += JsonConvert.SerializeObject(ListOfAvailibleCards[i]);
                if (i != ListOfAvailibleCards.Count-1)
                {
                    jsonString += ", ";
                }
                else
                {
                    jsonString += "]";
                }
            }

            return jsonString;
        }

        public void AddCardToList(Card newCard)
        {
            ListOfAvailibleCards.Add(newCard);
        }

        public List<int> DrawCardsIds(int numberOfCards)
        {
            List<int> drawnCardsIds = new List<int>();

            for (int i = 0; i < numberOfCards; i++)
            {
                CheckIfCardIsAlreadyInDeck(drawnCardsIds);
            }

            return drawnCardsIds;
        }

        private void CheckIfCardIsAlreadyInDeck(List<int> list)
        {
            int numberToCheck = new Random().Next(0, ListOfAvailibleCards.Count);

            if (!(list.Contains(numberToCheck)))
            {
                list.Add(numberToCheck);
            }
            else
            {
                CheckIfCardIsAlreadyInDeck(list);
            }
        }
    }
}
