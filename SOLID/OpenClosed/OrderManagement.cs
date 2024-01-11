using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{

    //public enum CardType
    //{
    //    Standard,
    //    Silver,
    //    Gold,
    //    Premium
    //}

    public abstract class CardType
    {
        public abstract double GetDiscountedPrice(double price);

    }

    public class StandardType : CardType
    {
        public override double GetDiscountedPrice(double price)
        {
            return price * .95;
        }
    }

    public class SilverType : CardType
    {
        public override double GetDiscountedPrice(double price)
        {
            return price * .90;
        }
    }

    public class GoldType : CardType
    {
        public override double GetDiscountedPrice(double price)
        {
            return price * .85;
        }
    }

    public class PremiumType : CardType
    {
        public override double GetDiscountedPrice(double price)
        {
            return price * .80;
        }
    }
    public class Customer
    {
        public CardType Card { get; set; }
    }
    public class OrderManagement
    {
        public Customer Customer { get; set; }
        public double GetDiscountedPrice(double price)
        {
            //switch (Customer.Card)
            //{
            //    case CardType.Standard:

            //        return price * .95;
            //    case CardType.Silver:
            //        return price * .90;

            //    case CardType.Gold:
            //        return price * .85;
            //    case CardType.Premium:
            //        return price * .80;

            //    default:
            //        return price;

            //}

            return Customer.Card.GetDiscountedPrice(price);

        }
    }
}
