

namespace TeamJ
{
    partial class TransactionPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelItem = new System.Windows.Forms.TableLayoutPanel();
            this.labelItemType = new System.Windows.Forms.Label();
            this.comboBoxItemType = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanelSection = new System.Windows.Forms.TableLayoutPanel();
            this.labelSection = new System.Windows.Forms.Label();
            this.comboBoxSection = new System.Windows.Forms.ComboBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDescriptionVar = new System.Windows.Forms.Label();
            this.tableLayoutPanelBrickText = new System.Windows.Forms.TableLayoutPanel();
            this.labelLine1 = new System.Windows.Forms.Label();
            this.textBoxLine1 = new System.Windows.Forms.TextBox();
            this.labelLine2 = new System.Windows.Forms.Label();
            this.textBoxLine2 = new System.Windows.Forms.TextBox();
            this.labelLine3 = new System.Windows.Forms.Label();
            this.textBoxLine3 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelPrice = new System.Windows.Forms.TableLayoutPanel();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelDonation = new System.Windows.Forms.Label();
            this.textBoxDonation = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalCalc = new System.Windows.Forms.Label();
            this.labelSectionName = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelItem.SuspendLayout();
            this.tableLayoutPanelSection.SuspendLayout();
            this.tableLayoutPanelBrickText.SuspendLayout();
            this.tableLayoutPanelPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelItem, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelSection, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelBrickText, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelPrice, 0, 3);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 5;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelItem
            // 
            this.tableLayoutPanelItem.ColumnCount = 2;
            this.tableLayoutPanelItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanelItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelItem.Controls.Add(this.labelItemType, 0, 0);
            this.tableLayoutPanelItem.Controls.Add(this.comboBoxItemType, 1, 0);
            this.tableLayoutPanelItem.Controls.Add(this.labelDate, 0, 1);
            this.tableLayoutPanelItem.Controls.Add(this.dateTimePicker1, 1, 1);
            this.tableLayoutPanelItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelItem.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelItem.Name = "tableLayoutPanelItem";
            this.tableLayoutPanelItem.RowCount = 2;
            this.tableLayoutPanelItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelItem.Size = new System.Drawing.Size(194, 84);
            this.tableLayoutPanelItem.TabIndex = 0;
            // 
            // labelItemType
            // 
            this.labelItemType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelItemType.AutoSize = true;
            this.labelItemType.Location = new System.Drawing.Point(3, 14);
            this.labelItemType.Name = "labelItemType";
            this.labelItemType.Size = new System.Drawing.Size(57, 13);
            this.labelItemType.TabIndex = 0;
            this.labelItemType.Text = "Item Type:";
            this.labelItemType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxItemType
            // 
            this.comboBoxItemType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxItemType.FormattingEnabled = true;
            this.comboBoxItemType.Location = new System.Drawing.Point(68, 10);
            this.comboBoxItemType.Name = "comboBoxItemType";
            this.comboBoxItemType.Size = new System.Drawing.Size(123, 21);
            this.comboBoxItemType.TabIndex = 0;
            this.comboBoxItemType.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemType_SelectedIndexChanged);
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(3, 56);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 13);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date:";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(68, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // tableLayoutPanelSection
            // 
            this.tableLayoutPanelSection.ColumnCount = 2;
            this.tableLayoutPanelSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSection.Controls.Add(this.labelSection, 0, 0);
            this.tableLayoutPanelSection.Controls.Add(this.comboBoxSection, 1, 0);
            this.tableLayoutPanelSection.Controls.Add(this.labelDescription, 0, 1);
            this.tableLayoutPanelSection.Controls.Add(this.labelDescriptionVar, 1, 1);
            this.tableLayoutPanelSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSection.Location = new System.Drawing.Point(3, 93);
            this.tableLayoutPanelSection.Name = "tableLayoutPanelSection";
            this.tableLayoutPanelSection.RowCount = 2;
            this.tableLayoutPanelSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSection.Size = new System.Drawing.Size(194, 64);
            this.tableLayoutPanelSection.TabIndex = 1;
            // 
            // labelSection
            // 
            this.labelSection.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSection.AutoSize = true;
            this.labelSection.Location = new System.Drawing.Point(3, 9);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(46, 13);
            this.labelSection.TabIndex = 0;
            this.labelSection.Text = "Section:";
            this.labelSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Location = new System.Drawing.Point(73, 5);
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(118, 21);
            this.comboBoxSection.TabIndex = 0;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(3, 32);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Description:";
            // 
            // labelDescriptionVar
            // 
            this.labelDescriptionVar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDescriptionVar.AutoSize = true;
            this.labelDescriptionVar.Location = new System.Drawing.Point(73, 41);
            this.labelDescriptionVar.Name = "labelDescriptionVar";
            this.labelDescriptionVar.Size = new System.Drawing.Size(72, 13);
            this.labelDescriptionVar.TabIndex = 0;
            this.labelDescriptionVar.Text = "<Description>";
            // 
            // tableLayoutPanelBrickText
            // 
            this.tableLayoutPanelBrickText.ColumnCount = 2;
            this.tableLayoutPanelBrickText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelBrickText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBrickText.Controls.Add(this.labelLine1, 0, 0);
            this.tableLayoutPanelBrickText.Controls.Add(this.textBoxLine1, 1, 0);
            this.tableLayoutPanelBrickText.Controls.Add(this.labelLine2, 0, 1);
            this.tableLayoutPanelBrickText.Controls.Add(this.textBoxLine2, 1, 1);
            this.tableLayoutPanelBrickText.Controls.Add(this.labelLine3, 0, 2);
            this.tableLayoutPanelBrickText.Controls.Add(this.textBoxLine3, 1, 2);
            this.tableLayoutPanelBrickText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBrickText.Location = new System.Drawing.Point(3, 163);
            this.tableLayoutPanelBrickText.Name = "tableLayoutPanelBrickText";
            this.tableLayoutPanelBrickText.RowCount = 3;
            this.tableLayoutPanelBrickText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelBrickText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelBrickText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelBrickText.Size = new System.Drawing.Size(194, 64);
            this.tableLayoutPanelBrickText.TabIndex = 1;
            // 
            // labelLine1
            // 
            this.labelLine1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelLine1.AutoSize = true;
            this.labelLine1.Location = new System.Drawing.Point(3, 0);
            this.labelLine1.Name = "labelLine1";
            this.labelLine1.Size = new System.Drawing.Size(30, 21);
            this.labelLine1.TabIndex = 0;
            this.labelLine1.Text = "Line 1:";
            this.labelLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxLine1
            // 
            this.textBoxLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLine1.Location = new System.Drawing.Point(43, 3);
            this.textBoxLine1.Name = "textBoxLine1";
            this.textBoxLine1.Size = new System.Drawing.Size(148, 20);
            this.textBoxLine1.TabIndex = 0;
            // 
            // labelLine2
            // 
            this.labelLine2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelLine2.AutoSize = true;
            this.labelLine2.Location = new System.Drawing.Point(3, 21);
            this.labelLine2.Name = "labelLine2";
            this.labelLine2.Size = new System.Drawing.Size(30, 21);
            this.labelLine2.TabIndex = 0;
            this.labelLine2.Text = "Line 2:";
            this.labelLine2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxLine2
            // 
            this.textBoxLine2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLine2.Location = new System.Drawing.Point(43, 24);
            this.textBoxLine2.Name = "textBoxLine2";
            this.textBoxLine2.Size = new System.Drawing.Size(148, 20);
            this.textBoxLine2.TabIndex = 0;
            // 
            // labelLine3
            // 
            this.labelLine3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelLine3.AutoSize = true;
            this.labelLine3.Location = new System.Drawing.Point(3, 42);
            this.labelLine3.Name = "labelLine3";
            this.labelLine3.Size = new System.Drawing.Size(30, 22);
            this.labelLine3.TabIndex = 0;
            this.labelLine3.Text = "Line 3:";
            this.labelLine3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxLine3
            // 
            this.textBoxLine3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLine3.Location = new System.Drawing.Point(43, 45);
            this.textBoxLine3.Name = "textBoxLine3";
            this.textBoxLine3.Size = new System.Drawing.Size(148, 20);
            this.textBoxLine3.TabIndex = 0;
            // 
            // tableLayoutPanelPrice
            // 
            this.tableLayoutPanelPrice.ColumnCount = 2;
            this.tableLayoutPanelPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrice.Controls.Add(this.labelPrice, 0, 0);
            this.tableLayoutPanelPrice.Controls.Add(this.textBoxPrice, 1, 2);
            this.tableLayoutPanelPrice.Controls.Add(this.labelDonation, 0, 1);
            this.tableLayoutPanelPrice.Controls.Add(this.textBoxDonation, 1, 1);
            this.tableLayoutPanelPrice.Controls.Add(this.labelTotal, 0, 2);
            this.tableLayoutPanelPrice.Controls.Add(this.labelTotalCalc, 1, 2);
            this.tableLayoutPanelPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPrice.Location = new System.Drawing.Point(3, 233);
            this.tableLayoutPanelPrice.Name = "tableLayoutPanelPrice";
            this.tableLayoutPanelPrice.RowCount = 3;
            this.tableLayoutPanelPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrice.Size = new System.Drawing.Size(194, 84);
            this.tableLayoutPanelPrice.TabIndex = 1;
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(3, 3);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(34, 13);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "Price:";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrice.Location = new System.Drawing.Point(3, 60);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(64, 20);
            this.textBoxPrice.TabIndex = 0;
            // 
            // labelDonation
            // 
            this.labelDonation.AutoSize = true;
            this.labelDonation.Location = new System.Drawing.Point(3, 19);
            this.labelDonation.Name = "labelDonation";
            this.labelDonation.Size = new System.Drawing.Size(53, 13);
            this.labelDonation.TabIndex = 0;
            this.labelDonation.Text = "Donation:";
            // 
            // textBoxDonation
            // 
            this.textBoxDonation.Location = new System.Drawing.Point(73, 22);
            this.textBoxDonation.Name = "textBoxDonation";
            this.textBoxDonation.Size = new System.Drawing.Size(100, 20);
            this.textBoxDonation.TabIndex = 0;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(3, 38);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(34, 13);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Total:";
            // 
            // labelTotalCalc
            // 
            this.labelTotalCalc.AutoSize = true;
            this.labelTotalCalc.Location = new System.Drawing.Point(73, 38);
            this.labelTotalCalc.Name = "labelTotalCalc";
            this.labelTotalCalc.Size = new System.Drawing.Size(19, 13);
            this.labelTotalCalc.TabIndex = 0;
            this.labelTotalCalc.Text = "$0";
            // 
            // labelSectionName
            // 
            this.labelSectionName.AutoSize = true;
            this.labelSectionName.Location = new System.Drawing.Point(43, 0);
            this.labelSectionName.Name = "labelSectionName";
            this.labelSectionName.Size = new System.Drawing.Size(41, 13);
            this.labelSectionName.TabIndex = 0;
            this.labelSectionName.Text = "section";
            // 
            // TransactionPanel
            // 
            this.Controls.Add(this.tableLayoutPanelMain);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelItem.ResumeLayout(false);
            this.tableLayoutPanelItem.PerformLayout();
            this.tableLayoutPanelSection.ResumeLayout(false);
            this.tableLayoutPanelSection.PerformLayout();
            this.tableLayoutPanelBrickText.ResumeLayout(false);
            this.tableLayoutPanelBrickText.PerformLayout();
            this.tableLayoutPanelPrice.ResumeLayout(false);
            this.tableLayoutPanelPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPrice;
        //private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDate;
        //private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPurchasedBy;
        //private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPurchasedFor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBrickText;
        //private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLine2;
        //private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLine3;
        //private System.Windows.Forms.GroupBox groupBoxDescription;
        //private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelItemType;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDate;
        //private System.Windows.Forms.Label labelPurchasedBy;
        //private System.Windows.Forms.Label labelPurchasedFor;
        private System.Windows.Forms.Label labelSection;
        private System.Windows.Forms.Label labelLine1;
        private System.Windows.Forms.Label labelLine2;
        private System.Windows.Forms.Label labelLine3;
        private System.Windows.Forms.ComboBox comboBoxItemType;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        //private System.Windows.Forms.Label labelPurchasedByName;
        //private System.Windows.Forms.Label labelPurchasedForName;
        private System.Windows.Forms.Label labelSectionName;
        private System.Windows.Forms.TextBox textBoxLine1;
        private System.Windows.Forms.TextBox textBoxLine2;
        private System.Windows.Forms.TextBox textBoxLine3;
        private System.Windows.Forms.Label labelTotalCalc;
        private System.Windows.Forms.Label labelDonation;
        private System.Windows.Forms.TextBox textBoxDonation;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ComboBox comboBoxSection;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDescriptionVar;

    }
}
