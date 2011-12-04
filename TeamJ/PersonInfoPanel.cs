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
        public void setPerson(Person p)
        {
            this.person = p;

            this.textBoxFirstName.Text = p.FirstName;
            this.textBoxMiddleName.Text = p.MiddleName;
            this.textBoxLastName.Text = p.LastName;

            this.textBoxEmail.Text = p.Email;
            this.textBoxPhone.Text = p.Phone;

            Address addr = p.Address;
            this.textBoxAddress.Text = addr.Street;
            this.textBoxCity.Text = addr.City;
            this.textBoxState.Text = addr.State;
            this.textBoxZip.Text = addr.Zipcode;
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
            person.FirstName = textBoxFirstName.Text;
            person.MiddleName = textBoxMiddleName.Text;
            person.LastName = textBoxLastName.Text;
            person.Email = textBoxEmail.Text;
            person.Phone = textBoxPhone.Text;

            Address addr = person.Address;
            addr.Street = textBoxAddress.Text;
            addr.City = textBoxCity.Text;
            addr.State = textBoxState.Text;
            addr.Zipcode = textBoxZip.Text;
        }

        #endregion

        #endregion
    }
}
