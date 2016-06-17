using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2.Shop
{
    /// <summary>
    /// Describe a place where we can buy product and hold by one or more owner.
    /// </summary>
    public class Shop : EntityBase
    {
        #region Attributes
        private Int32 id;
        private String name;
        private Decimal finance;
        private Decimal credit;
        private Address address;
        private List<Product> products;
        private List<Client> clients;
        private List<Owner> owners;

        #endregion

        #region Properties
        /// <summary>
        /// Database id.
        /// </summary>
        public Int32 Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
                this.OnPropertyChanged("Id");
            }
        }

        /// <summary>
        /// Shop can engage credit to have money quickly.
        /// </summary>
        public Decimal Credit
        {
            get
            {
                return this.credit;
            }

            set
            {
                this.credit = value;
                this.OnPropertyChanged("Credit");
            }
        }

        /// <summary>
        /// Money shop have to buy product, won from client.
        /// </summary>
        public Decimal Finance
        {
            get
            {
                return this.finance;
            }

            set
            {
                this.finance = value;
                this.OnPropertyChanged("Finance");
            }
        }

        /// <summary>
        /// Name of the shop.
        /// </summary>
        public String Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
                this.OnPropertyChanged("Name");
            }
        }

        public Address Address
        {
            get { return address; }
            set { address = value;
                this.OnPropertyChanged("Address");
            }
        }

        public List<Product> Products
        {
            get { return products; }
            set { products = value;
                this.OnPropertyChanged("Products");
            }
        }

        public List<Client> Clients
        {
            get { return clients; }
            set { clients = value;
                this.OnPropertyChanged("Clients");
            }
        }

        public List<Owner> Owners
        {
            get { return owners; }
            set { owners = value;
                this.OnPropertyChanged("Owners");
            }
        }
        #endregion
        #region Constructors
        public Shop()
        {
            this.products = new List<Product>();
            this.owners = new List<Owner>();
            this.clients = new List<Client>();
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            String result = "Shop name is : " + this.name + "\n  Finance : " + this.finance + "\n  Credit : " + this.credit + "\n";

            result += "  Owners :\n";
            foreach (var item in this.owners)
            {
                result += "    " + item.ToString() + "\n";
            }

            result += "  Products :\n";
            foreach (var item in this.products)
            {
                result += "    " + item.ToString() + "\n";
            }

            result += "  Clients :\n";
            foreach (var item in this.clients)
            {
                result += "    " + item.ToString() + "\n";
            }
            return result;
        }

        /// <summary>
        /// Print all items categories hierachy with numbers of items.
        /// </summary>
        public void PrintItemCategories()
        {
            String step0 = "Products (";
            String step11 = "   Drinkable (";
            String step12 = "   Eatable (";
            String step13 = "   Usable (";
            String step13Contant = "";
            String step111 = "      Consistant (";
            String step111Contant = "";
            String step112 = "      Fluide (";
            String step112Contant = "";
            String step121 = "      Cold (";
            String step121Contant = "";
            String step122 = "      Hot (";
            String step122Contant = "";
            String step131 = "      Usefull (";
            String step131Contant = "";
            String step132 = "      Useless (";
            String step132Contant = "";

            Int32 intStep0 = 0;
            Int32 intStep11 = 0;
            Int32 intStep12 = 0;
            Int32 intStep13 = 0;
            Int32 intStep111 = 0;
            Int32 intStep112 = 0;
            Int32 intStep121 = 0;
            Int32 intStep122 = 0;
            Int32 intStep131 = 0;
            Int32 intStep132 = 0;

            foreach (var item in this.products)
            {
                if (item is Drinkable)
                {
                    if (item is Consistant)
                    {
                        step111Contant += "         " + (item as Consistant) + "\n";
                        intStep111++;
                    }
                    else if (item is Fluid)
                    {
                        step112Contant += "         " + (item as Fluid) + "\n";
                        intStep112++;
                    }
                    intStep11++;
                }
                else if (item is Eatable)
                {
                    if (item is Cold)
                    {
                        step121Contant += "         " + (item as Cold) + "\n";
                        intStep121++;
                    }
                    else if (item is Hot)
                    {
                        step122Contant += "         " + (item as Hot) + "\n";
                        intStep122++;
                    }
                    intStep12++;
                }
                else if (item is Usable)
                {
                    if (item is Usefull)
                    {
                        step131Contant += "         " + (item as Usefull) + "\n";
                        intStep131++;
                    }
                    else if (item is Useless)
                    {
                        step132Contant += "         " + (item as Useless) + "\n";
                        intStep132++;
                    }
                    else if (!(item is Usefull) && !(item is Useless))
                    {
                        step13Contant += "      " + (item as Usable) + "\n";
                    }
                    intStep13++;
                }
                intStep0++;
            }
            Console.WriteLine("Grocery items classification :");
            step0 += intStep0 + ") :";
            step11 += intStep11 + ") :";
            step12 += intStep12 + ") :";
            step13 += intStep13 + ") :";
            step111 += intStep111 + ") :";
            step112 += intStep112 + ") :";
            step121 += intStep121 + ") :";
            step122 += intStep122 + ") :";
            step131 += intStep131 + ") :";
            step132 += intStep132 + ") :";
            Console.WriteLine(step0);
            Console.WriteLine(step11);
            Console.WriteLine(step111);
            Console.WriteLine(step111Contant);
            Console.WriteLine(step112);
            Console.WriteLine(step112Contant);
            Console.WriteLine(step12);
            Console.WriteLine(step121);
            Console.WriteLine(step121Contant);
            Console.WriteLine(step122);
            Console.WriteLine(step122Contant);
            Console.WriteLine(step13);
            Console.WriteLine(step13Contant);
            Console.WriteLine(step131);
            Console.WriteLine(step131Contant);
            Console.WriteLine(step132);
            Console.WriteLine(step132Contant);
        }

        public void PrintItemCategories1()
        {
            Console.WriteLine("Products (" + this.products.Count + ") :");
            Console.WriteLine(" Drinkables (" + this.products.OfType<Drinkable>().ToList().Count + ") :");
            Console.WriteLine("   Consistant (" + this.products.OfType<Consistant>().ToList().Count + ") :");
            foreach (var item in this.products.OfType<Consistant>().ToList())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(" Eatables (" + this.products.OfType<Eatable>().ToList().Count + ") :");

            Console.WriteLine(" Usables (" + this.products.OfType<Usable>().ToList().Count + ") :");
        }
        #endregion
    }
}