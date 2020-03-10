using AnimalsHierarchy.Interfaces;

namespace AnimalsHierarchy.Animals.Mammals
{
    public abstract class Predator : Mammal, IDangerous
    {
        protected Predator(string pictureUrl) : base(pictureUrl)
        {
        }
    }
}
