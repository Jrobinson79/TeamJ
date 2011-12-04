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
    public partial class ShowDonorPanel : UserControl
    {
        #region Private Variables
        private Boolean addingSale = false;
        #endregion

        #region Constructors

        #region ShowDonorPanel()
        /// <summary>
        ///     Constructs a ShowDonorPanel object
        /// </summary>
        public ShowDonorPanel()
        {
            InitializeComponent();
            initialize();

            addingSale = true;

            this.buttonUpdate.Text = "Create";

            this.tableLayoutPanelMainBottom.Controls.Clear();

            this.tableLayoutPanelMainBottom.ColumnStyles.Clear();
            this.tableLayoutPanelMainBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelMainBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            clearAndSetTables();
            selectSectionImageForAddingSale(null);

            this.tableLayoutPanelMainBottom.Controls.Add(tableLayoutPanelImage, 0, 0);
            this.tableLayoutPanelMainBottom.Controls.Add(tableLayoutPanelBottomRight, 1, 0);
        }

        #endregion

        public ShowDonorPanel(List<TransactionItem> list, int selectedIndex)
        {
            InitializeComponent();
            initialize();

            listBoxResults.DataSource = list;

            listBoxResults.SelectedIndexChanged += (s, e) =>
            {
                updateChanges();
            };

            listBoxResults.SelectedIndex = selectedIndex;
            updateChanges();
        }

        #endregion

        #region Private Methods

        //  Assuming the listbox has a list of sale objects;
        private void updateChanges()
        {
            int saleid = ((TransactionItem)listBoxResults.SelectedItem).getSale().SaleID;

            using (var context = new Context())
            {
                Sale sale = context.Sales.Where(i => i.SaleID == saleid).ToList().First();
                Item item = sale.Items.First();

                personInfoPanelDonor.setPerson(sale.Donor, true);
                personInfoPanelRecipient.setPerson(sale.Recipient, true);
                transactionPanel1.SetSale(sale);

                checkBoxSameAsDonor.Checked = (sale.DonorID == sale.RecipientID);

                selectImage();
            }
        }

        #region initialize();

        private void initialize()
        {
            this.Dock = DockStyle.Fill;

            TextBox textBox1, textBox2, textBox3;

            textBox1 = transactionPanel1.getTextBox1();
            textBox2 = transactionPanel1.getTextBox2();
            textBox3 = transactionPanel1.getTextBox3();

            textBox1.TextChanged += (s, e) =>
            {
                labelBrickTextLine1.Text = textBox1.Text;
            };

            textBox2.TextChanged += (s, e) =>
            {
                if (textBox2.Text.Trim().Equals("") || !tableLayoutPanelBrickText2.Contains(labelBrickTextLine2))
                    selectBrickImage();
                else
                    labelBrickTextLine2.Text = textBox2.Text;
            };

            textBox3.TextChanged += (s, e) =>
            {
                if (textBox3.Text.Trim().Equals("") || !tableLayoutPanelBrickText.Contains(labelBrickTextLine3))
                    selectBrickImage();
                else
                    labelBrickTextLine3.Text = textBox3.Text;
            };
        }

        #endregion
        
        private void selectBrickImage()
        {
            String lineText1, lineText2, lineText3;

            lineText1 = transactionPanel1.getTextBox1().Text;
            lineText2 = transactionPanel1.getTextBox2().Text;
            lineText3 = transactionPanel1.getTextBox3().Text;

            tableLayoutPanelImageBorder.Controls.Remove(panelSectionImage);

            this.tableLayoutPanelImage.ColumnStyles.Clear();
            this.tableLayoutPanelImage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelImage.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            this.tableLayoutPanelImage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            this.tableLayoutPanelImageBorder.RowStyles.Clear();
            this.tableLayoutPanelImageBorder.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelImageBorder.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            this.tableLayoutPanelImageBorder.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            this.tableLayoutPanelImageBorder.Controls.Add(panelBrickImage, 0, 1);
            panelBrickImage.Controls.Remove(tableLayoutPanelBrickText);
            panelBrickImage.Controls.Remove(tableLayoutPanelBrickText2);

            tableLayoutPanelBrickText.Controls.Remove(labelBrickTextLine1);
            tableLayoutPanelBrickText.Controls.Remove(labelBrickTextLine2);
            tableLayoutPanelBrickText.Controls.Remove(labelBrickTextLine3);
            tableLayoutPanelBrickText2.Controls.Remove(labelBrickTextLine1);
            tableLayoutPanelBrickText2.Controls.Remove(labelBrickTextLine2);

            if (lineText3.Trim().Equals(""))
            {
                // Only one line of text
                if (lineText2.Trim().Equals(""))
                {
                    this.tableLayoutPanelBrickText.RowStyles.Clear();
                    this.tableLayoutPanelBrickText.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                    this.tableLayoutPanelBrickText.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
                    this.tableLayoutPanelBrickText.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
                    this.tableLayoutPanelBrickText.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
                    this.tableLayoutPanelBrickText.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

                    this.tableLayoutPanelBrickText.Controls.Add(labelBrickTextLine1, 0, 2);

                    labelBrickTextLine1.Text = lineText1;

                    panelBrickImage.Controls.Add(tableLayoutPanelBrickText);
                }
                //  Two lines of text
                else
                {
                    this.tableLayoutPanelBrickText2.RowStyles.Clear();
                    this.tableLayoutPanelBrickText2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                    this.tableLayoutPanelBrickText2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
                    this.tableLayoutPanelBrickText2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
                    this.tableLayoutPanelBrickText2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

                    this.tableLayoutPanelBrickText2.Controls.Add(labelBrickTextLine1, 0, 1);
                    this.tableLayoutPanelBrickText2.Controls.Add(labelBrickTextLine2, 0, 2);

                    labelBrickTextLine1.Text = lineText1;
                    labelBrickTextLine2.Text = lineText2;
                    panelBrickImage.Controls.Add(tableLayoutPanelBrickText2);
                }
            }
            // Three lines of text
            else
            {
                this.tableLayoutPanelBrickText.RowStyles.Clear();
                this.tableLayoutPanelBrickText.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
                this.tableLayoutPanelBrickText.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
                this.tableLayoutPanelBrickText.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
                this.tableLayoutPanelBrickText.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
                this.tableLayoutPanelBrickText.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

                this.tableLayoutPanelBrickText.Controls.Add(labelBrickTextLine1, 0, 1);
                this.tableLayoutPanelBrickText.Controls.Add(labelBrickTextLine2, 0, 2);
                this.tableLayoutPanelBrickText.Controls.Add(labelBrickTextLine3, 0, 3);

                labelBrickTextLine1.Text = lineText1;
                labelBrickTextLine2.Text = lineText2;
                labelBrickTextLine3.Text = lineText3;
                panelBrickImage.Controls.Add(tableLayoutPanelBrickText);
            }
        }

        #region selectSectionImage()
        /// <summary>
        /// This method shows the section image.  Passing in a null value 
        /// will show the default section image.
        /// </summary>
        /// <param name="section"></param>
        private void selectSectionImage()
        {
            Section section;
            int saleid = ((TransactionItem)listBoxResults.SelectedItem).getSale().SaleID;

            using (var context = new Context())
            {
                Item item = context.Sales
                    .Where(i => i.SaleID == saleid)
                    .ToList()
                    .First() // get sale
                    .Items
                    .First(); // get item

                section = item.Section;
            }

            clearAndSetTables();

            panelSectionImage.BackgroundImage = getSectionImage(section.Location);
                
            this.tableLayoutPanelImageBorder.Controls.Add(panelSectionImage, 0, 1);
        }

        #endregion

        private void clearAndSetTables()
        {
            float size;

            if (addingSale)
                size = 450F;
            else
                size = 300F;

            tableLayoutPanelImageBorder.Controls.Remove(panelBrickImage);

            this.tableLayoutPanelImage.ColumnStyles.Clear();
            this.tableLayoutPanelImage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelImage.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, size));
            this.tableLayoutPanelImage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            this.tableLayoutPanelImageBorder.RowStyles.Clear();
            this.tableLayoutPanelImageBorder.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.tableLayoutPanelImageBorder.RowStyles.Add(new RowStyle(SizeType.Absolute, size));
            this.tableLayoutPanelImageBorder.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        }

        private Image getSectionImage(String location)
        {
            switch (location)
            {
                case "A":
                    return Properties.Resources.Plaza_A;
                case "B":
                    return Properties.Resources.Plaza_B;
                case "C":
                    return Properties.Resources.Plaza_C;
                case "D":
                    return Properties.Resources.Plaza_D;
                case "E":
                    return Properties.Resources.Plaza_E;
                case "F":
                    return Properties.Resources.Plaza_F;
                case "G":
                    return Properties.Resources.Plaza_G;
                case "H":
                    return Properties.Resources.Plaza_H;
                default:
                    return Properties.Resources.Plaza;
            }
        }

        private void selectSectionImageForAddingSale(Section s)
        {
            if (s == null)
                panelSectionImage.BackgroundImage = getSectionImage("");
            else
                panelSectionImage.BackgroundImage = getSectionImage(s.Location);

            groupBoxResults.Text = null;
            groupBoxResults.Controls.Clear();
            groupBoxResults.Controls.Add(panelSectionImage);
            this.tableLayoutPanelImageBorder.Controls.Add(groupBoxResults, 0, 1);
        }

        private void selectImage()
        {
            if (radioButtonBrick.Checked)
                selectBrickImage();
            else
                selectSectionImage();
        }

        #endregion

        #region Events

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectImage();
        }

        #region buttonUpdate_Click(object sender, MouseEventArgs e)
        /// <summary>
        ///     Loads data entered into the database, enforcing mappings
        /// </summary>
        /// <param name="sender">The object that is calling the method</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int saleid = ((TransactionItem)listBoxResults.SelectedItem).getSale().SaleID;

            using (var context = new Context())
            {
                // TODO: save the person on update, add the person on addingSale
                personInfoPanelDonor.savePerson();
                personInfoPanelRecipient.savePerson();
                transactionPanel1.SaveSale();

                Sale sale = context.Sales.Where(i => i.SaleID == saleid).ToList().First();
            }
        }

        #endregion

        private void buttonInvoice_Click(object sender, EventArgs e)
        {

        }

        Person bufferPerson;
        Address bufferAddress;
        private void checkBoxSameAsDonor_CheckedChanged(object sender, EventArgs e)
        {
            personInfoPanelDonor.savePerson();
            personInfoPanelRecipient.savePerson();

            if (checkBoxSameAsDonor.Checked)
            {
                bufferPerson = personInfoPanelRecipient.getPerson();
                bufferAddress = personInfoPanelRecipient.getAddress();
                personInfoPanelRecipient.setPerson(personInfoPanelDonor.getPerson(), !addingSale);
            }
            else if (bufferPerson != null)
            {
                bufferPerson.Address = bufferAddress;
                personInfoPanelRecipient.setPerson(bufferPerson, !addingSale);
            }
            else
            {
                Person p = new Person();
                p.Address = new Address();
                personInfoPanelRecipient.setPerson(p, !addingSale);
            }
        }

        #endregion
    }
}
