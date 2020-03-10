using System;

namespace AnimalsHierarchy.Animals
{
    public abstract class Animal
    {
        private string _pictureUrl;

        public virtual string Name { get { return this.GetType().Name; } }
        public virtual string PictureUrl
        {
            get
            {
                return _pictureUrl;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Value can't be null or empty", nameof(PictureUrl));

                _pictureUrl = value;
            }
        }

        protected Animal(string pictureUrl)
        {
            PictureUrl = pictureUrl;
        }

        public override string ToString()
        {
            return $"{Name} ({PictureUrl})";
        }

        public abstract void Act();
    }
}
