using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2.Shop
{
    /// <summary>
    /// Describe a client which is a user that buy product in a shop.
    /// </summary>
    public class Client : ShopUser
    {
        #region Attributes
        private Decimal money;
        private List<Product> products;
        #endregion
        #region Properties
        /// <summary>
        /// Money client have to buy stuff.
        /// </summary>
        public Decimal Money
        {
            get
            {
                return this.money;
            }

            set
            {
                this.money = value;
                this.OnPropertyChanged("Money");
            }
        }

        public List<Product> Products
        {
            get { return products; }
            set { products = value;
                this.OnPropertyChanged("Products");
            }
        }
        #endregion
        #region Constructors
        public Client()
        {
            this.products = new List<Product>();
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return base.ToString() + " " + this.money;
        }
        #endregion
    }
}