   public abstract class Animal
    {
    private string name;
    private string food;

        protected Animal(string name, string food)
        {
            this.Name = name;
            this.Food = food;
        }

    private string Food
    {
      set { this.food = value; }
    }

    private string Name
    {
        set { this.name = value; }
    }

        public virtual string ExplainMyself()
        {
            return $"I am {this.name} and my fovourite food is {this.food}";
        }

}

