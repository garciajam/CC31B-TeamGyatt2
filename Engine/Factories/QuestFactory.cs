using Engine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static List<Quest> s_Quests = new List<Quest>();

        internal static Quest GetQuestByID(int id)
        {
            return s_Quests.FirstOrDefault(quest => quest.Id == id);
        }

        static QuestFactory()
        {
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();
            itemsToComplete.Add(new ItemQuantity(2001, 5));
            rewardItems.Add(new ItemQuantity(1001, 1));
            s_Quests.Add(new Quest(1,
                                  "Clear Enchanted Forest",
                                  "Defeat enemies in the enchanted forest",
                                  itemsToComplete,
                                  25, 10,
                                  rewardItems));
            //s_Quests= new List<Quest>();

            //s_Quests.Add(new Quest(
            //    1,
            //    "Quest 1",
            //    "Quest",
            //    new List<ItemQuantity> { new ItemQuantity(1001, 5) },
            //    10,
            //    10,
            //    new List<ItemQuantity> { new ItemQuantity(1001, 1 )}
            //    ));






        }
    }
}
