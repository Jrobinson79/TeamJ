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
                /*
                //string image = "./Images/logo1.jpg";
                object missing = Type.Missing;

                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document doc;
                word.Visible = true;
                doc = word.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                doc.Activate();

                Microsoft.Office.Interop.Word.Paragraph paragraph = doc.Content.Paragraphs.Add(ref missing);
                //paragraph.Range.InlineShapes.AddPicture(image, ref missing, ref missing, ref missing);

                paragraph.Range.Font.Bold = 5;
                paragraph.Range.Font.Size = 18;
                paragraph.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdViolet;
                paragraph.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                word.Selection.TypeText("Section Report" + "\n");

                for(int i = 0; i <= listBoxSections.CheckedItems.Count - 1; i++)
                {
                    if (listBoxSections.CheckedItems[i].ToString() != "Select All")
                    {
                        string nextCheckedItem = listBoxSections.CheckedItems[i].ToString();

                        var sectionQuery = from section in context.Sections
                                           join item in context.Items on section.SectionID equals item.SectionID
                                           join sale in context.Sales on item.SaleID equals sale.SaleID
                                           join owner in context.People on sale.RecipientID equals owner.PersonID
                                           where section.Location == nextCheckedItem
                                           select new { owner.FirstName, owner.LastName, item.Line1, item.Line2, item.Line3 };

                        int count = sectionQuery.Count();

                        if (count != 0)
                        {
                            paragraph.Range.Font.Bold = 1;
                            paragraph.Range.Font.Size = 14;
                            paragraph.Range.Font.Underline = Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineThick;
                            paragraph.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
                            paragraph.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                            word.Selection.TypeText("Section: " + nextCheckedItem + "\n");

                            foreach (var results in sectionQuery)
                            {
                                paragraph.Range.Font.Size = 12;
                                paragraph.Range.Font.Bold = 0;
                                paragraph.Range.Font.Underline = Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineNone;
                                word.Selection.TypeText("\t" + results.FirstName + " " + results.LastName + " - " + results.Line1 + " " + results.Line2 + " " + results.Line3 + "\n");
                            }
                        }
                    }
                }

                word.Selection.ParagraphFormat.SpaceAfter = 2;
                word.Selection.ParagraphFormat.SpaceBefore = 2;
                 */
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
