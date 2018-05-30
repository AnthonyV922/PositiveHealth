using System;
using System.Collections.Generic;
using System.Text;

namespace PositiveHealth.Model
{
    public class Person
    {
        public String Name { get; set;}
        public Food FavoriteFood { get; set;}
        public int Age { get; set; }
        public double Weight { get; set; }

        public Person(String name, Food favorite, int age, double pounds)
        {
            this.Name = name;
            this.FavoriteFood = favorite;
            this.Age = age;
            this.Weight = pounds;
        }
    }
}
