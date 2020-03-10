using AnimalsHierarchy.Interfaces;

namespace AnimalsHierarchy.Animals
{
    public class Tarantula : Animal, IDangerous
    {
        public Tarantula(string pictureUrl) : base(pictureUrl)
        {
        }

        public override void Act()
        {
            // Building webs
        }
    }
}
