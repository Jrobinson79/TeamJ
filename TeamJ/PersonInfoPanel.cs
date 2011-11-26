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
    public partial class PersonInfoPanel : Panel
    {
        private Person person = new Person();
        TeamJDBEntities context = new TeamJDBEntities();

        public PersonInfoPanel()
        {
            InitializeComponent();
        }

        public PersonInfoPanel(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

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

        public Person getPerson()
        {
            return person;
        }

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

        public Boolean HasPerson(Person person)
        {
            var peopleQuery = from people in context.People
                              where people.FirstName  == person.FirstName
                              && people.MiddleName == person.MiddleName
                              && people.LastName  == person.LastName
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

        public String GetID()
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
}
