﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab15._1ConsumingAnApi.Models
{
    public class CardSet
    {
        public bool success { get; set; }
        public List<Card> cards { get; set; }
        public string deck_id { get; set; }
        public int remaining { get; set; }
    }
    public class Card
    {
        
            public string image { get; set; }
            public string value { get; set; }
            public string suit { get; set; }
            public string code { get; set; }

        
    }
}
