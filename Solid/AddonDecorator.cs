namespace Solid
{
    public abstract class AddonDecorator : Machine
    {
        protected Machine _machine;

        protected AddonDecorator(Machine machine)
        {
            _machine = machine;
        }

        public override double Price
        {
            get
            {
                return base.Price + _machine.Price;
            }
            set
            {
                base.Price = value;
            }
        }
    }
}