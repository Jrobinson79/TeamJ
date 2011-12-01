using System.Windows.Forms;
using System.Drawing;
namespace TeamJ
{
    partial class AdvancedSearchPanel
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
            this.tableLayoutPanelName = new System.Windows.Forms.TableLayoutPanel();
            this.donorFNLabel = new System.Windows.Forms.Label();
            this.donorFNTextBox = new System.Windows.Forms.TextBox();
            this.donorMNLabel = new System.Windows.Forms.Label();
            this.donorMNTextBox = new System.Windows.Forms.TextBox();
            this.donorLNLabel = new System.Windows.Forms.Label();
            this.donorLNTextBox = new System.Windows.Forms.TextBox();
            this.donorLabel = new System.Windows.Forms.Label();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.sectionComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelSection = new System.Windows.Forms.TableLayoutPanel();
            this.itemLabel = new System.Windows.Forms.Label();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.startLabel1 = new System.Windows.Forms.Label();
            this.endLabel1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelPurchaseDate = new System.Windows.Forms.TableLayoutPanel();
            this.purchaseStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.purchaseEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.rangeCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanelSearch = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBoxSearchFilters = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelFilters = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelAddress = new System.Windows.Forms.TableLayoutPanel();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelLocation = new System.Windows.Forms.TableLayoutPanel();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxSection = new System.Windows.Forms.GroupBox();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelSearchResults = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelSearchResultButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRight = new System.Windows.Forms.TableLayoutPanel();
            this.panelSectionImage = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelName.SuspendLayout();
            this.tableLayoutPanelSection.SuspendLayout();
            this.tableLayoutPanelPurchaseDate.SuspendLayout();
            this.tableLayoutPanelSearch.SuspendLayout();
            this.groupBoxSearchFilters.SuspendLayout();
            this.tableLayoutPanelFilters.SuspendLayout();
            this.tableLayoutPanelAddress.SuspendLayout();
            this.tableLayoutPanelLocation.SuspendLayout();
            this.groupBoxSection.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.tableLayoutPanelSearchResults.SuspendLayout();
            this.tableLayoutPanelSearchResultButtons.SuspendLayout();
            this.tableLayoutPanelMain2.SuspendLayout();
            this.tableLayoutPanelLeft.SuspendLayout();
            this.tableLayoutPanelRight.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelName
            // 
            this.tableLayoutPanelName.ColumnCount = 2;
            this.tableLayoutPanelName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelName.Controls.Add(this.donorFNLabel, 0, 0);
            this.tableLayoutPanelName.Controls.Add(this.donorFNTextBox, 1, 0);
            this.tableLayoutPanelName.Controls.Add(this.donorMNLabel, 0, 1);
            this.tableLayoutPanelName.Controls.Add(this.donorMNTextBox, 1, 1);
            this.tableLayoutPanelName.Controls.Add(this.donorLNLabel, 0, 2);
            this.tableLayoutPanelName.Controls.Add(this.donorLNTextBox, 1, 2);
            this.tableLayoutPanelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelName.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelName.Name = "tableLayoutPanelName";
            this.tableLayoutPanelName.RowCount = 3;
            this.tableLayoutPanelName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tableLayoutPanelName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tableLayoutPanelName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.4F));
            this.tableLayoutPanelName.Size = new System.Drawing.Size(538, 94);
            this.tableLayoutPanelName.TabIndex = 0;
            // 
            // donorFNLabel
            // 
            this.donorFNLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.donorFNLabel.AutoSize = true;
            this.donorFNLabel.Location = new System.Drawing.Point(3, 9);
            this.donorFNLabel.Name = "donorFNLabel";
            this.donorFNLabel.Size = new System.Drawing.Size(60, 13);
            this.donorFNLabel.TabIndex = 0;
            this.donorFNLabel.Text = "First Name:";
            this.donorFNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // donorFNTextBox
            // 
            this.donorFNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.donorFNTextBox.Location = new System.Drawing.Point(83, 5);
            this.donorFNTextBox.Name = "donorFNTextBox";
            this.donorFNTextBox.Size = new System.Drawing.Size(452, 20);
            this.donorFNTextBox.TabIndex = 0;
            // 
            // donorMNLabel
            // 
            this.donorMNLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.donorMNLabel.AutoSize = true;
            this.donorMNLabel.Location = new System.Drawing.Point(3, 40);
            this.donorMNLabel.Name = "donorMNLabel";
            this.donorMNLabel.Size = new System.Drawing.Size(72, 13);
            this.donorMNLabel.TabIndex = 0;
            this.donorMNLabel.Text = "Middle Name:";
            this.donorMNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // donorMNTextBox
            // 
            this.donorMNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.donorMNTextBox.Location = new System.Drawing.Point(83, 36);
            this.donorMNTextBox.Name = "donorMNTextBox";
            this.donorMNTextBox.Size = new System.Drawing.Size(452, 20);
            this.donorMNTextBox.TabIndex = 0;
            // 
            // donorLNLabel
            // 
            this.donorLNLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.donorLNLabel.AutoSize = true;
            this.donorLNLabel.Location = new System.Drawing.Point(3, 71);
            this.donorLNLabel.Name = "donorLNLabel";
            this.donorLNLabel.Size = new System.Drawing.Size(61, 13);
            this.donorLNLabel.TabIndex = 0;
            this.donorLNLabel.Text = "Last Name:";
            this.donorLNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // donorLNTextBox
            // 
            this.donorLNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.donorLNTextBox.Location = new System.Drawing.Point(83, 68);
            this.donorLNTextBox.Name = "donorLNTextBox";
            this.donorLNTextBox.Size = new System.Drawing.Size(452, 20);
            this.donorLNTextBox.TabIndex = 0;
            // 
            // donorLabel
            // 
            this.donorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.donorLabel.AutoSize = true;
            this.donorLabel.Location = new System.Drawing.Point(3, 6);
            this.donorLabel.Name = "donorLabel";
            this.donorLabel.Size = new System.Drawing.Size(39, 13);
            this.donorLabel.TabIndex = 0;
            this.donorLabel.Text = "Donor:";
            this.donorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sectionLabel
            // 
            this.sectionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Location = new System.Drawing.Point(3, 6);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(46, 13);
            this.sectionLabel.TabIndex = 0;
            this.sectionLabel.Text = "Section:";
            this.sectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sectionComboBox
            // 
            this.sectionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sectionComboBox.FormattingEnabled = true;
            this.sectionComboBox.Location = new System.Drawing.Point(58, 3);
            this.sectionComboBox.Name = "sectionComboBox";
            this.sectionComboBox.Size = new System.Drawing.Size(94, 21);
            this.sectionComboBox.TabIndex = 0;
            // 
            // tableLayoutPanelSection
            // 
            this.tableLayoutPanelSection.ColumnCount = 5;
            this.tableLayoutPanelSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanelSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanelSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSection.Controls.Add(this.sectionLabel, 0, 0);
            this.tableLayoutPanelSection.Controls.Add(this.sectionComboBox, 1, 0);
            this.tableLayoutPanelSection.Controls.Add(this.itemLabel, 2, 0);
            this.tableLayoutPanelSection.Controls.Add(this.itemComboBox, 3, 0);
            this.tableLayoutPanelSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSection.Location = new System.Drawing.Point(3, 199);
            this.tableLayoutPanelSection.Name = "tableLayoutPanelSection";
            this.tableLayoutPanelSection.RowCount = 1;
            this.tableLayoutPanelSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSection.Size = new System.Drawing.Size(538, 26);
            this.tableLayoutPanelSection.TabIndex = 0;
            // 
            // itemLabel
            // 
            this.itemLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(188, 6);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(30, 13);
            this.itemLabel.TabIndex = 0;
            this.itemLabel.Text = "Item:";
            this.itemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemComboBox
            // 
            this.itemComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(224, 3);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(94, 21);
            this.itemComboBox.TabIndex = 0;
            // 
            // startLabel1
            // 
            this.startLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.startLabel1.AutoSize = true;
            this.startLabel1.Location = new System.Drawing.Point(3, 9);
            this.startLabel1.Name = "startLabel1";
            this.startLabel1.Size = new System.Drawing.Size(80, 13);
            this.startLabel1.TabIndex = 0;
            this.startLabel1.Text = "Purchase Start:";
            this.startLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endLabel1
            // 
            this.endLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.endLabel1.AutoSize = true;
            this.endLabel1.Location = new System.Drawing.Point(3, 41);
            this.endLabel1.Name = "endLabel1";
            this.endLabel1.Size = new System.Drawing.Size(77, 13);
            this.endLabel1.TabIndex = 0;
            this.endLabel1.Text = "Purchase End:";
            this.endLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelPurchaseDate
            // 
            this.tableLayoutPanelPurchaseDate.ColumnCount = 3;
            this.tableLayoutPanelPurchaseDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelPurchaseDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelPurchaseDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPurchaseDate.Controls.Add(this.startLabel1, 0, 0);
            this.tableLayoutPanelPurchaseDate.Controls.Add(this.purchaseStartDatePicker, 1, 0);
            this.tableLayoutPanelPurchaseDate.Controls.Add(this.endLabel1, 0, 1);
            this.tableLayoutPanelPurchaseDate.Controls.Add(this.purchaseEndDatePicker, 1, 1);
            this.tableLayoutPanelPurchaseDate.Controls.Add(this.rangeCheckBox, 2, 0);
            this.tableLayoutPanelPurchaseDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPurchaseDate.Location = new System.Drawing.Point(3, 231);
            this.tableLayoutPanelPurchaseDate.Name = "tableLayoutPanelPurchaseDate";
            this.tableLayoutPanelPurchaseDate.RowCount = 2;
            this.tableLayoutPanelPurchaseDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPurchaseDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPurchaseDate.Size = new System.Drawing.Size(538, 64);
            this.tableLayoutPanelPurchaseDate.TabIndex = 0;
            // 
            // purchaseStartDatePicker
            // 
            this.purchaseStartDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseStartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.purchaseStartDatePicker.Location = new System.Drawing.Point(103, 6);
            this.purchaseStartDatePicker.Name = "purchaseStartDatePicker";
            this.purchaseStartDatePicker.Size = new System.Drawing.Size(114, 20);
            this.purchaseStartDatePicker.TabIndex = 0;
            // 
            // purchaseEndDatePicker
            // 
            this.purchaseEndDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseEndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.purchaseEndDatePicker.Location = new System.Drawing.Point(103, 38);
            this.purchaseEndDatePicker.Name = "purchaseEndDatePicker";
            this.purchaseEndDatePicker.Size = new System.Drawing.Size(114, 20);
            this.purchaseEndDatePicker.TabIndex = 0;
            // 
            // rangeCheckBox
            // 
            this.rangeCheckBox.AutoSize = true;
            this.rangeCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rangeCheckBox.Location = new System.Drawing.Point(223, 3);
            this.rangeCheckBox.Name = "rangeCheckBox";
            this.rangeCheckBox.Size = new System.Drawing.Size(312, 26);
            this.rangeCheckBox.TabIndex = 0;
            this.rangeCheckBox.Text = "Set Range";
            this.rangeCheckBox.UseVisualStyleBackColor = true;
            this.rangeCheckBox.CheckedChanged += new System.EventHandler(this.rangeCheckBox_CheckedChanged);
            // 
            // tableLayoutPanelSearch
            // 
            this.tableLayoutPanelSearch.ColumnCount = 3;
            this.tableLayoutPanelSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSearch.Controls.Add(this.searchButton, 1, 0);
            this.tableLayoutPanelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSearch.Location = new System.Drawing.Point(3, 301);
            this.tableLayoutPanelSearch.Name = "tableLayoutPanelSearch";
            this.tableLayoutPanelSearch.RowCount = 1;
            this.tableLayoutPanelSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSearch.Size = new System.Drawing.Size(538, 41);
            this.tableLayoutPanelSearch.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Location = new System.Drawing.Point(172, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(194, 35);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearchFilters
            // 
            this.groupBoxSearchFilters.Controls.Add(this.tableLayoutPanelFilters);
            this.groupBoxSearchFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSearchFilters.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSearchFilters.Name = "groupBoxSearchFilters";
            this.groupBoxSearchFilters.Size = new System.Drawing.Size(550, 364);
            this.groupBoxSearchFilters.TabIndex = 0;
            this.groupBoxSearchFilters.TabStop = false;
            this.groupBoxSearchFilters.Text = "Enter Search Filters:  ";
            // 
            // tableLayoutPanelFilters
            // 
            this.tableLayoutPanelFilters.ColumnCount = 1;
            this.tableLayoutPanelFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFilters.Controls.Add(this.tableLayoutPanelName, 0, 0);
            this.tableLayoutPanelFilters.Controls.Add(this.tableLayoutPanelSearch, 0, 6);
            this.tableLayoutPanelFilters.Controls.Add(this.tableLayoutPanelPurchaseDate, 0, 5);
            this.tableLayoutPanelFilters.Controls.Add(this.tableLayoutPanelSection, 0, 4);
            this.tableLayoutPanelFilters.Controls.Add(this.tableLayoutPanelLocation, 0, 3);
            this.tableLayoutPanelFilters.Controls.Add(this.tableLayoutPanelAddress, 0, 2);
            this.tableLayoutPanelFilters.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanelFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFilters.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelFilters.Name = "tableLayoutPanelFilters";
            this.tableLayoutPanelFilters.RowCount = 7;
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelFilters.Size = new System.Drawing.Size(544, 345);
            this.tableLayoutPanelFilters.TabIndex = 0;
            // 
            // tableLayoutPanelAddress
            // 
            this.tableLayoutPanelAddress.ColumnCount = 2;
            this.tableLayoutPanelAddress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanelAddress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAddress.Controls.Add(this.addressLabel, 0, 0);
            this.tableLayoutPanelAddress.Controls.Add(this.addressTextBox, 1, 0);
            this.tableLayoutPanelAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAddress.Location = new System.Drawing.Point(3, 135);
            this.tableLayoutPanelAddress.Name = "tableLayoutPanelAddress";
            this.tableLayoutPanelAddress.RowCount = 1;
            this.tableLayoutPanelAddress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAddress.Size = new System.Drawing.Size(538, 26);
            this.tableLayoutPanelAddress.TabIndex = 0;
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(3, 6);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "Address:";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressTextBox.Location = new System.Drawing.Point(58, 3);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(477, 20);
            this.addressTextBox.TabIndex = 0;
            // 
            // tableLayoutPanelLocation
            // 
            this.tableLayoutPanelLocation.ColumnCount = 6;
            this.tableLayoutPanelLocation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanelLocation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLocation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelLocation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelLocation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLocation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelLocation.Controls.Add(this.cityLabel, 0, 0);
            this.tableLayoutPanelLocation.Controls.Add(this.cityTextBox, 1, 0);
            this.tableLayoutPanelLocation.Controls.Add(this.stateLabel, 2, 0);
            this.tableLayoutPanelLocation.Controls.Add(this.stateTextBox, 3, 0);
            this.tableLayoutPanelLocation.Controls.Add(this.zipLabel, 4, 0);
            this.tableLayoutPanelLocation.Controls.Add(this.zipTextBox, 5, 0);
            this.tableLayoutPanelLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLocation.Location = new System.Drawing.Point(3, 167);
            this.tableLayoutPanelLocation.Name = "tableLayoutPanelLocation";
            this.tableLayoutPanelLocation.RowCount = 1;
            this.tableLayoutPanelLocation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLocation.Size = new System.Drawing.Size(538, 26);
            this.tableLayoutPanelLocation.TabIndex = 0;
            // 
            // cityLabel
            // 
            this.cityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(3, 6);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "City:";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityTextBox.Location = new System.Drawing.Point(58, 3);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(190, 20);
            this.cityTextBox.TabIndex = 0;
            // 
            // stateLabel
            // 
            this.stateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(263, 6);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 0;
            this.stateLabel.Text = "State:";
            this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stateTextBox
            // 
            this.stateTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateTextBox.Location = new System.Drawing.Point(304, 3);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(111, 20);
            this.stateTextBox.TabIndex = 0;
            // 
            // zipLabel
            // 
            this.zipLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(430, 6);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(25, 13);
            this.zipLabel.TabIndex = 0;
            this.zipLabel.Text = "Zip:";
            this.zipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // zipTextBox
            // 
            this.zipTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zipTextBox.Location = new System.Drawing.Point(461, 3);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(74, 20);
            this.zipTextBox.TabIndex = 0;
            // 
            // groupBoxSection
            // 
            this.groupBoxSection.Controls.Add(this.panelSectionImage);
            this.groupBoxSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSection.Location = new System.Drawing.Point(3, 49);
            this.groupBoxSection.Name = "groupBoxSection";
            this.groupBoxSection.Size = new System.Drawing.Size(418, 469);
            this.groupBoxSection.TabIndex = 0;
            this.groupBoxSection.TabStop = false;
            this.groupBoxSection.Text = "Section Legend:";
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.tableLayoutPanelSearchResults);
            this.groupBoxResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResults.Location = new System.Drawing.Point(3, 373);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(550, 255);
            this.groupBoxResults.TabIndex = 0;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Search Results:";
            // 
            // tableLayoutPanelSearchResults
            // 
            this.tableLayoutPanelSearchResults.ColumnCount = 1;
            this.tableLayoutPanelSearchResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSearchResults.Controls.Add(this.listBoxResults, 0, 0);
            this.tableLayoutPanelSearchResults.Controls.Add(this.tableLayoutPanelSearchResultButtons, 0, 1);
            this.tableLayoutPanelSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSearchResults.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelSearchResults.Name = "tableLayoutPanelSearchResults";
            this.tableLayoutPanelSearchResults.RowCount = 2;
            this.tableLayoutPanelSearchResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSearchResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanelSearchResults.Size = new System.Drawing.Size(544, 236);
            this.tableLayoutPanelSearchResults.TabIndex = 0;
            // 
            // listBoxResults
            // 
            this.listBoxResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.Location = new System.Drawing.Point(3, 3);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(538, 188);
            this.listBoxResults.TabIndex = 0;
            // 
            // tableLayoutPanelSearchResultButtons
            // 
            this.tableLayoutPanelSearchResultButtons.ColumnCount = 4;
            this.tableLayoutPanelSearchResultButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSearchResultButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelSearchResultButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelSearchResultButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSearchResultButtons.Controls.Add(this.buttonSelect, 1, 0);
            this.tableLayoutPanelSearchResultButtons.Controls.Add(this.buttonNew, 2, 0);
            this.tableLayoutPanelSearchResultButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSearchResultButtons.Location = new System.Drawing.Point(3, 197);
            this.tableLayoutPanelSearchResultButtons.Name = "tableLayoutPanelSearchResultButtons";
            this.tableLayoutPanelSearchResultButtons.RowCount = 1;
            this.tableLayoutPanelSearchResultButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSearchResultButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSearchResultButtons.Size = new System.Drawing.Size(538, 36);
            this.tableLayoutPanelSearchResultButtons.TabIndex = 0;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelect.Location = new System.Drawing.Point(172, 3);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(94, 30);
            this.buttonSelect.TabIndex = 0;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            // 
            // buttonNew
            // 
            this.buttonNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNew.Location = new System.Drawing.Point(272, 3);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(94, 30);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "Add New";
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelMain2
            // 
            this.tableLayoutPanelMain2.ColumnCount = 2;
            this.tableLayoutPanelMain2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 430F));
            this.tableLayoutPanelMain2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain2.Controls.Add(this.tableLayoutPanelLeft, 0, 0);
            this.tableLayoutPanelMain2.Controls.Add(this.tableLayoutPanelRight, 1, 0);
            this.tableLayoutPanelMain2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain2.Name = "tableLayoutPanelMain2";
            this.tableLayoutPanelMain2.RowCount = 1;
            this.tableLayoutPanelMain2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain2.Size = new System.Drawing.Size(992, 637);
            this.tableLayoutPanelMain2.TabIndex = 0;
            // 
            // tableLayoutPanelLeft
            // 
            this.tableLayoutPanelLeft.ColumnCount = 1;
            this.tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeft.Controls.Add(this.groupBoxSection, 0, 1);
            this.tableLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeft.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            this.tableLayoutPanelLeft.RowCount = 3;
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 475F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelLeft.Size = new System.Drawing.Size(424, 631);
            this.tableLayoutPanelLeft.TabIndex = 0;
            // 
            // tableLayoutPanelRight
            // 
            this.tableLayoutPanelRight.ColumnCount = 1;
            this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRight.Controls.Add(this.groupBoxSearchFilters, 0, 0);
            this.tableLayoutPanelRight.Controls.Add(this.groupBoxResults, 0, 1);
            this.tableLayoutPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRight.Location = new System.Drawing.Point(433, 3);
            this.tableLayoutPanelRight.Name = "tableLayoutPanelRight";
            this.tableLayoutPanelRight.RowCount = 2;
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 370F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRight.Size = new System.Drawing.Size(556, 631);
            this.tableLayoutPanelRight.TabIndex = 0;
            // 
            // panelSectionImage
            // 
            this.panelSectionImage.BackgroundImage = global::TeamJ.Properties.Resources.Plaza;
            this.panelSectionImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSectionImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSectionImage.Location = new System.Drawing.Point(3, 16);
            this.panelSectionImage.Name = "panelSectionImage";
            this.panelSectionImage.Size = new System.Drawing.Size(412, 450);
            this.panelSectionImage.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelPhone, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelemail, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 26);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(3, 6);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(41, 13);
            this.labelPhone.TabIndex = 0;
            this.labelPhone.Text = "Phone:";
            // 
            // labelemail
            // 
            this.labelemail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelemail.AutoSize = true;
            this.labelemail.Location = new System.Drawing.Point(272, 6);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(35, 13);
            this.labelemail.TabIndex = 1;
            this.labelemail.Text = "Email:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(53, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(322, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 20);
            this.textBox2.TabIndex = 3;
            // 
            // AdvancedSearchPanel
            // 
            this.Controls.Add(this.tableLayoutPanelMain2);
            this.Name = "AdvancedSearchPanel";
            this.Size = new System.Drawing.Size(992, 637);
            this.tableLayoutPanelName.ResumeLayout(false);
            this.tableLayoutPanelName.PerformLayout();
            this.tableLayoutPanelSection.ResumeLayout(false);
            this.tableLayoutPanelSection.PerformLayout();
            this.tableLayoutPanelPurchaseDate.ResumeLayout(false);
            this.tableLayoutPanelPurchaseDate.PerformLayout();
            this.tableLayoutPanelSearch.ResumeLayout(false);
            this.groupBoxSearchFilters.ResumeLayout(false);
            this.tableLayoutPanelFilters.ResumeLayout(false);
            this.tableLayoutPanelAddress.ResumeLayout(false);
            this.tableLayoutPanelAddress.PerformLayout();
            this.tableLayoutPanelLocation.ResumeLayout(false);
            this.tableLayoutPanelLocation.PerformLayout();
            this.groupBoxSection.ResumeLayout(false);
            this.groupBoxResults.ResumeLayout(false);
            this.tableLayoutPanelSearchResults.ResumeLayout(false);
            this.tableLayoutPanelSearchResultButtons.ResumeLayout(false);
            this.tableLayoutPanelMain2.ResumeLayout(false);
            this.tableLayoutPanelLeft.ResumeLayout(false);
            this.tableLayoutPanelRight.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelName;
        private Label donorLabel;
        private Label donorFNLabel;
        private Label donorMNLabel;
        private Label donorLNLabel;
        private TextBox donorFNTextBox;
        private TextBox donorMNTextBox;
        private TextBox donorLNTextBox;
        private Label sectionLabel;
        private ComboBox sectionComboBox;
        private TableLayoutPanel tableLayoutPanelSection;
        private Label endLabel1;
        private TableLayoutPanel tableLayoutPanelPurchaseDate;
        private Label startLabel1;
        private TableLayoutPanel tableLayoutPanelSearch;
        private Button searchButton;
        private GroupBox groupBoxSearchFilters;
        private GroupBox groupBoxResults;
        private ListBox listBoxResults;
        private TableLayoutPanel tableLayoutPanelSearchResultButtons;
        private Button buttonSelect;
        private Button buttonNew;
        private TableLayoutPanel tableLayoutPanelFilters;
        private GroupBox groupBoxSection;
        private Panel panelSectionImage;
        private TableLayoutPanel tableLayoutPanelSearchResults;
        private TableLayoutPanel tableLayoutPanelAddress;
        private Label addressLabel;
        private TextBox addressTextBox;
        private TableLayoutPanel tableLayoutPanelLocation;
        private Label cityLabel;
        private Label stateLabel;
        private Label zipLabel;
        private TextBox cityTextBox;
        private TextBox stateTextBox;
        private TextBox zipTextBox;
        private DateTimePicker purchaseStartDatePicker;
        private DateTimePicker purchaseEndDatePicker;
        private CheckBox rangeCheckBox;
        private TableLayoutPanel tableLayoutPanelMain2;
        private TableLayoutPanel tableLayoutPanelLeft;
        private TableLayoutPanel tableLayoutPanelRight;
        private Label itemLabel;
        private ComboBox itemComboBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelPhone;
        private Label labelemail;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
