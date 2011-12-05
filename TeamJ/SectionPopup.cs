using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using DataLayer;
using DomainClasses;

namespace TeamJ
{
    public partial class SectionPopup : Form
    {
        public SectionPopup()
        {
            InitializeComponent();

            using (var context = new Context())
            {
                listBoxSections.Items.Add("Select All");

                foreach(var item in context.Sections)
                {
                    listBoxSections.Items.Add(item.Location.ToString());
                }
            }
        }

        private void CreateReport()
        {
            using (var context = new Context())
            {
                List<int> indexesToRemove = new List<int>();

                context.Sections.Load();

                List<Section> searchResults = new List<Section>();

                for(int i = 0; i <= listBoxSections.CheckedItems.Count - 1; i++)
                {
                    if (listBoxSections.CheckedItems[i].ToString() != "Select All")
                    {
                        string nextCheckedItem = listBoxSections.CheckedItems[i].ToString();
                        searchResults = searchResults
                            .Where(j => j.Location.Equals(nextCheckedItem))
                            .ToList();
                    }
                }

                MessageBox.Show(searchResults.Count.ToString());

                //string image = "./Images/logo1.jpg";
                //object missing = Type.Missing;

                //Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                //Microsoft.Office.Interop.Word.Document doc;
                //word.Visible = true;
                //doc = word.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                //doc.Activate();

                //Microsoft.Office.Interop.Word.Paragraph paragraph = doc.Content.Paragraphs.Add(ref missing);
                ////paragraph.Range.InlineShapes.AddPicture(image, ref missing, ref missing, ref missing);
                //paragraph.Range.Text = "Section Report";
                //paragraph.Range.Font.Bold = 1;
                //paragraph.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

                //word.Selection.ParagraphFormat.SpaceAfter = 2;
                //word.Selection.ParagraphFormat.SpaceBefore = 2;

                //word.Selection.TypeText("\n");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CreateReport();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSections.GetItemChecked(0))
            {
                for (int i = 0; i < listBoxSections.Items.Count; i++)
                {
                    listBoxSections.SetItemChecked(i, true);
                }
            }
            //else 
            //{
            //    for (int i = 0; i < listBoxSections.Items.Count; i++)
            //    {
            //        listBoxSections.SetItemChecked(i, false);
            //    }
            //}
        }
    }
}
