namespace MenuApp.BusinessLogic
{
    public class Manager
    {
        internal List<Dish> dishes;
        internal List<Dish> selectedDishes;
        public Manager()
        {
            dishes = new List<Dish>();
            selectedDishes = new List<Dish>();

        }

        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }

        public void AddSelected(Dish dish)
        {
            selectedDishes.Add(dish);
        }

        public List<Dish> GetListDishes()
        {
            return dishes;
        }

        public List<Dish> GetSelectedDishes()
        {
            return selectedDishes;
        }

        public void RemoveDish(Dish dish)
        {
            selectedDishes.Remove(dish);
        }

    }

}
