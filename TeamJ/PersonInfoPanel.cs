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
        private Person person;

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
    }
}
