using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeamJ
{
    public partial class PersonInfoPanel : UserControl
    {
        #region Private Variables

        private Person person = new Person();

        #endregion

        #region Constructors

        #region PersonInfoPanel()
        /// <summary>
        ///     Constructs a PersonInfoPanel object
        /// </summary>
        public PersonInfoPanel()
        {
            InitializeComponent();
        }

        #endregion

        #region PersonInfoPanel(IContainer container)
        /// <summary>
        ///     Constructs a PersonInfoPanel Object
        /// </summary>
        /// <param name="container"></param>
        public PersonInfoPanel(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        #endregion

        #endregion

        #region Public Methods

        #region setPerson(Person p)
        /// <summary>
        ///     Sets the appropriate textbox fields with the information from the Person parameter.
        /// </summary>
        /// <param name="p">The Person object to load into the textbox fields</param>
        public void setPerson(Person p)
        {
            this.person = p;

            this.textBoxFirstName.Text = p.FirstName;
            this.textBoxMiddleName.Text = p.MiddleName;
            this.textBoxLastName.Text = p.LastName;

            this.textBoxEmail.Text = p.Email;
            this.textBoxPhone.Text = p.Phone;

            this.textBoxAddress.Text = p.Addr;
            this.textBoxCity.Text = p.City;
            this.textBoxState.Text = p.State;
            this.textBoxZip.Text = p.Zip;
        }

        #endregion

        #region getPerson()
        /// <summary>
        ///     Gets the Person object from the class.
        /// </summary>
        /// <returns>person</returns>
        public Person getPerson()
        {
            return person;
        }

        #endregion

        #region savePerson()
        /// <summary>
        ///     Save the information from the textbox fields into the Person object of the class.
        /// </summary>
        public void savePerson()
        {
            person.PersonID = Guid.NewGuid();
            person.FirstName = textBoxFirstName.Text;
            person.MiddleName = textBoxMiddleName.Text;
            person.LastName = textBoxLastName.Text;
            person.Email = textBoxEmail.Text;
            person.Phone = textBoxPhone.Text;
            person.Addr = textBoxAddress.Text;
            person.City = textBoxCity.Text;
            person.State = textBoxState.Text;
            person.Zip = textBoxZip.Text;
        }

        #endregion

        #region HasPerson(Person person)
        /// <summary>
        ///     Checks to see if the person object is already contained in the database.
        /// </summary>
        /// <param name="sender">The Person object of the class</param>
        /// <returns> True if the object exists in the database, false otherwise.</returns>
        public Boolean HasPerson(Person person)
        {
            using (TeamJDBEntities context = new TeamJDBEntities())
            {
                var peopleQuery = from people in context.People
                                  where people.FirstName == person.FirstName
                                  && people.MiddleName == person.MiddleName
                                  && people.LastName == person.LastName
                                  && people.Addr == person.Addr
                                  && people.City == person.City
                                  && people.State == person.State
                                  && people.Zip == person.Zip
                                  && people.Phone == person.Phone
                                  && people.Email == person.Email
                                  select people;

                if (peopleQuery.Count() == 0)
                    return false;
                else
                    return true;
            }
        }

        #endregion

        #region GetID()
        /// <summary>
        ///     Gets the PersonID Guid of the Person object.
        /// </summary>
        /// <returns>The Guid ID of the person being searched for if it exists, null if it doesn't exist.</returns>
        public String GetID()
        {
            using (TeamJDBEntities context = new TeamJDBEntities())
            {
                var peopleQuery = from people in context.People
                                  where people.FirstName == person.FirstName
                                  && people.MiddleName == person.MiddleName
                                  && people.LastName == person.LastName
                                  && people.Addr == person.Addr
                                  && people.City == person.City
                                  && people.State == person.State
                                  && people.Zip == person.Zip
                                  && people.Phone == person.Phone
                                  && people.Email == person.Email
                                  select people;

                foreach (var result in peopleQuery)
                    return result.PersonID.ToString();

                return null;
            }
        }

        #endregion

        #endregion
    }
}
