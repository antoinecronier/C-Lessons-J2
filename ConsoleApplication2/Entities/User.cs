using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.Entities
{ 
    /// <summary>
    /// Define a system user.
    /// </summary>
    public class User
    {
        #region Attributes
        private Int32 id;
        private String name;
        private String surname;
        private DateTime dateOfBirth;
        private Boolean isAdmin;
        private Int32 sold;
        #endregion

        #region Properties
        public Int32 Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (this.isAdmin == true)
                {
                    if (value < 11 && value >= 0)
                    {
                        this.id = value;
                    }
                }
                else
                {
                    if (value >= 11)
                    {
                        this.id = value;
                    }
                }
            }
        }

        public string Name
        {
            get
            {
                return /*" de la famille " + */name;
            }

            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return /*" s'appelant " + */surname;
            }

            set
            {
                surname = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }

            set
            {
                dateOfBirth = value;
            }
        }

        public bool IsAdmin
        {
            get
            {
                return isAdmin;
            }

            set
            {
                isAdmin = value;
            }
        }

        public Int32 Sold
        {
            get { return sold; }
            set { sold = value; }
        }

        #endregion

        #region Constructors
        public User()
        {
            this.IsAdmin = true;
            this.Id = 10;
            this.Name = "toto";
            this.Surname = "tata";
            this.DateOfBirth = new DateTime(2000, 7, 12);
        }

        public User(Int32 id, String name, String surname, DateTime dateOfBirth, Boolean isAdmin)
        {
            this.IsAdmin = isAdmin;
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.DateOfBirth = dateOfBirth;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Print user with all is informations.
        /// </summary>
        /// <returns>User string definition.</returns>
        public override string ToString()
        {
            return this.id + " " + this.Name + " " + this.Surname + " " + this.DateOfBirth + " " + this.IsAdmin;
        }
        #endregion
    }
}
