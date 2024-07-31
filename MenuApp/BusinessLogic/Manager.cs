namespace MenuApp.BusinessLogic
{
    public class Manager
    {
        internal List<Dish> dishes;
        internal List<Dish> selectedDishes;
        public Manager()
        {
            dishes = new List<Dish>(); //list of dishes in the menu
            selectedDishes = new List<Dish>(); //list of selected dishes
        }
        public void AddDish(Dish dish) //adds dishes to the menu
        {
            dishes.Add(dish);
        }
        public void AddSelected(Dish dish) //adds the dishes to the order
        {
            selectedDishes.Add(dish);
        }
        public List<Dish> GetListDishes() //returns all dishes in the menu
        {
            return dishes;
        }
        public List<Dish> GetSelectedDishes() //returns all dishes in the order, whatever the use clicks on:)
        {
            return selectedDishes;
        }
        public void RemoveDish(Dish dish) //removes dish from order
        {
            selectedDishes.Remove(dish);
        }
    }

}
