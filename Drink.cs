
namespace Assignment1App
{
    class Drink
    {
        public string Name { get; set; }
        public string ImageName { get; set; }
        public string Recipe { get; set; }
        public string Mix { get; set; }

        public Drink()
        {
            Name = "";
            ImageName = "";
            Recipe = "";
            Mix = "";
        }

        public Drink(string inputName, string inputImageName, string inputRecipe, string inputMix)
        {
            Name = inputName;
            ImageName = inputImageName;
            Recipe = inputRecipe;
            Mix = inputMix;
        }
    }
}
