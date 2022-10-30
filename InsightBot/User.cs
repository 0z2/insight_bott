﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insight_bott
{
    public class User
    {
        public List<String> Thoughts; 
        public int NumberOfLastThought { get; set; }
        public long UserTelegramId { get; set; }

        public User(long userTelegramId)
        {
            UserTelegramId = userTelegramId;
            Thoughts = new List<String>()
            {
                "Глаза боятся - руки делают!", "Тише едешь - дальше будешь!", "Утро вечера мудренее!"
            };
            NumberOfLastThought = 0;
        }

        public string GetCurrentThought()
        {
            string CurrentThought = Thoughts[NumberOfLastThought];

            // если мысль является последней, то начинаем сначала
            if (Thoughts.Count-1 == NumberOfLastThought)
            {
                NumberOfLastThought = 0;
            }
            else 
            {
                NumberOfLastThought++;
            }

            return CurrentThought;
        }

    }
}