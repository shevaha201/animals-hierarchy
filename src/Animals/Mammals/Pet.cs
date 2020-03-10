using System;

namespace AnimalsHierarchy.Animals.Mammals
{
    public abstract class Pet : Mammal
    {
        private string _alias;
        public string Alias
        {
            get
            {
                return _alias;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Can't be null or empty", nameof(Alias));

                _alias = value;
            }
        }

        protected Pet(string pictureUrl, string alias)
            : base(pictureUrl)
        {
            Alias = alias;
        }

        public override string Name
        {
            get
            {
                return $"{base.Name}: {Alias}";
            }
        }
    }
}
