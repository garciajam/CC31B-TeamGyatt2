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
        private static List<Quest> s_Quests;

        internal static Quest GetQuestByID(int id)
        {
            foreach (Quest quest in s_Quests)
            {
                if (quest.Id == id)
                {
                    return quest;
                }
            }
            return null;
        }

        static QuestFactory()
        {
            s_Quests= new List<Quest>();
            //add quests here
            s_Quests.Add(new Quest(
                1,
                "Quest 1",
                "Quest",
                new List<ItemQuantity> { new ItemQuantity(1001, 5) },
                10,
                10,
                new List<ItemQuantity> { new ItemQuantity(1001, 1 )}
                ));
            
            
            
           


        }
    }
}
