using PositiveHealth.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PositiveHealth.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListView : ContentPage
	{
        private ObservableCollection<Food> food = new ObservableCollection<Food>();
		public ListView ()
		{
			InitializeComponent ();
            Init();
		}

        public void Init()
        {
            var enumerator = App.Dbcontroller.GetDBFood();
            if(enumerator == null)
            {
                App.Dbcontroller.SaveDBFood(new Food { ID = 0, Name = "Orange", Description = "What a surprise, its orange too", Calories = 85 });
                App.Dbcontroller.SaveDBFood(new Food { ID = 0, Name = "Apple", Description = "A good gift for the teacher.", Calories = 90 });
                App.Dbcontroller.SaveDBFood(new Food { ID = 0, Name = "Cake", Description = "Yummy", Calories = 280 });
                App.Dbcontroller.SaveDBFood(new Food { ID = 0, Name = "Hamburger", Description = "MEATY", Calories = 350 });
                enumerator = App.Dbcontroller.GetDBFood();
            }
            while(enumerator.MoveNext())
            {
                this.food.Add(enumerator.Current);
            }
            ListViewItem.ItemsSource = this.food;
        }

        private void OnDelete(object sender, System.EventArgs e)
        {
            var item = (MenuItem)sender;
            var model = (Food)item.CommandParameter;
            this.food.Remove(model);
            App.Dbcontroller.DeleteDBFood(model.ID);
        }

        
    }
}