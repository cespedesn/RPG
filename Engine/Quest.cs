﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }

        public Item RewardItem { get; set; }
        //Lists are null or non-existent until you set them to an empty list
        public List<QuestCompletionItem> QuestCompletionItems { get; set; }

        public Quest(int id, string name, string description, int rewardExperiencePoints, int rewardGold)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            //Set value of new property to empty list. 
            //By setting to an empty list, you can add item to it later.
            //Being that list is null/nothing, now you can add items later 
            QuestCompletionItems = new List<QuestCompletionItem>();
        }
    }
}
