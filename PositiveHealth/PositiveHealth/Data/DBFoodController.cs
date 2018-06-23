using PositiveHealth.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PositiveHealth.Data
{
    // Class used to modify or retrieve data from database
    public class DBFoodController
    {

        private static object locker = new object();
        private SQLiteConnection database;

        // Connects to the SQLite database
        public DBFoodController()
            {
            this.database = DependencyService.Get<ISQLite>().GetConnection();
            this.database.CreateTable<Food>();
            }

        public IEnumerator<Food> GetDBFood()
        {
            lock(locker)
            {
                if(this.database.Table<Food>().Count() == 0)
                {
                    return null;
                }

                else
                {
                    return this.database.Table<Food>().GetEnumerator();

                }
            }
        }

        // Used for updating a new type of food
        public int SaveDBFood(Food food)
        {
            lock(locker)
            {
                if (food.ID != 0)
                {
                    this.database.Update(food);
                    return food.ID;
                }

                else
                    return this.database.Insert(food);


            }
        }

        public int DeleteDBFood(int id)
        {
            lock(locker)
            {
                return this.database.Delete<Food>(id);

            }

        }
    }
}
