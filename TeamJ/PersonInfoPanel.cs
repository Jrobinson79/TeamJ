using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataLayer;
using DomainClasses;

namespace TeamJ
{
    public partial class PersonInfoPanel : UserControl
    {
        #region Private Variables

        private Person person = new Person();
        private Address address = new Address();

        #endregion

        #region Constructors

        #region PersonInfoPanel()
        /// <summary>
        ///     Constructs a PersonInfoPanel object
        /// </summary>
        public PersonInfoPanel()
        {
            InitializeComponent();
            initialize();
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
            initialize();
        }

        #endregion

        #endregion

        #region Methods

        #region initialize()

        private void initialize()
        {
            this.Dock = DockStyle.Fill;
        }

        #endregion

        #region setPerson(Person p)
        /// <summary>
        ///     Sets the appropriate textbox fields with the information from the Person parameter.
        /// </summary>
        /// <param name="p">The Person object to load into the textbox fields</param>
        public void setPerson(Person p, bool requery)
        {
            if (requery)
            {
                using (var context = new Context()) // requery the database because passing the person drops
                //   the reference the the address object in the person
                {
                    person = context.People.Where(i => i.PersonID == p.PersonID).ToList().First();
                    address = person.Address;
                }
            }
            else
            {
                person = p;
                address = person.Address;
            }

            this.textBoxFirstName.Text = person.FirstName;
            this.textBoxMiddleName.Text = person.MiddleName;
            this.textBoxLastName.Text = person.LastName;

            this.textBoxEmail.Text = person.Email;
            this.textBoxPhone.Text = person.Phone;

            this.textBoxAddress.Text = address.Street;
            this.textBoxCity.Text = address.City;
            this.textBoxState.Text = address.State;
            this.textBoxZip.Text = address.Zipcode;
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

        public Address getAddress()
        {
            return address;
        }

        #region savePerson()
        /// <summary>
        ///     Save the information from the textbox fields into the Person object of the class.
        /// </summary>
        public void savePerson()
        {
            person.FirstName = textBoxFirstName.Text.Trim();
            person.MiddleName = textBoxMiddleName.Text.Trim();
            person.LastName = textBoxLastName.Text.Trim();
            person.Email = textBoxEmail.Text.Trim();
            person.Phone = textBoxPhone.Text.Trim();

            address.Street = textBoxAddress.Text.Trim();
            address.City = textBoxCity.Text.Trim();
            address.State = textBoxState.Text.Trim();
            address.Zipcode = textBoxZip.Text.Trim();

            person.Address = address;
        }

        #endregion

        #endregion
    }
}
