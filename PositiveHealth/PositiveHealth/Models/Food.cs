﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PositiveHealth.Model
{
    public class Food
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Calories { get; set; }
    }
}
