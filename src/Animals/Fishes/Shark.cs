using AnimalsHierarchy.Interfaces;

namespace AnimalsHierarchy.Animals.Fishes
{
    public class Shark : Fish, IDangerous
    {
        public Shark(string pictureUrl) : base(pictureUrl)
        {
        }

        public override void Act()
        {
            // Swimming
        }
    }
}
