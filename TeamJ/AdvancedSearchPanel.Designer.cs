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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.donorFNLabel = new System.Windows.Forms.Label();
            this.donorFNTextBox = new System.Windows.Forms.TextBox();
            this.donorMILabel = new System.Windows.Forms.Label();
            this.donorMITextBox = new System.Windows.Forms.TextBox();
            this.donorLNLabel = new System.Windows.Forms.Label();
            this.donorLNTextBox = new System.Windows.Forms.TextBox();
            this.donorLabel = new System.Windows.Forms.Label();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.sectionComboBox = new System.Windows.Forms.ComboBox();
            this.itemLabel = new System.Windows.Forms.Label();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.startLabel1 = new System.Windows.Forms.Label();
            this.endLabel1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.purchaseStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.purchaseEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.rangeCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBoxSearchFilters = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelFilters = new System.Windows.Forms.TableLayoutPanel(); 
            this.tableLayoutPanelGroupBox = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();       
            this.addressLabel = new System.Windows.Forms.Label();                       
            this.addressTextBox = new System.Windows.Forms.TextBox();                   
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();       
            this.cityLabel = new System.Windows.Forms.Label();                          
            this.cityTextBox = new System.Windows.Forms.TextBox();                      
            this.stateLabel = new System.Windows.Forms.Label();                         
            this.stateTextBox = new System.Windows.Forms.TextBox();                     
            this.zipLabel = new System.Windows.Forms.Label();                           
            this.zipTextBox = new System.Windows.Forms.TextBox();                       
            //this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxSection = new System.Windows.Forms.GroupBox();
            this.panelSectionImage = new System.Windows.Forms.Panel();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelSearchResults = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelSearchResultButtons = new System.Windows.Forms.TableLayoutPanel(); 
            this.buttonSelect = new System.Windows.Forms.Button();                                  
            this.buttonNew = new System.Windows.Forms.Button();                                     
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel(); 
            //this.backButton = new System.Windows.Forms.Button();                  
            //this.selectButton = new System.Windows.Forms.Button();                
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBoxSearchFilters.SuspendLayout();
            this.tableLayoutPanelFilters.SuspendLayout(); 
            this.tableLayoutPanelGroupBox.SuspendLayout(); 
            this.tableLayoutPanel7.SuspendLayout();        
            this.tableLayoutPanel8.SuspendLayout();        
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelBottom.SuspendLayout();
            this.groupBoxSection.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.tableLayoutPanelSearchResults.SuspendLayout();       
            this.tableLayoutPanelSearchResultButtons.SuspendLayout(); 
            this.tableLayoutPanel4.SuspendLayout(); 
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel1.Controls.Add(this.donorFNLabel);
            this.tableLayoutPanel1.Controls.Add(this.donorFNTextBox);
            this.tableLayoutPanel1.Controls.Add(this.donorMILabel);
            this.tableLayoutPanel1.Controls.Add(this.donorMITextBox);
            this.tableLayoutPanel1.Controls.Add(this.donorLNLabel);
            this.tableLayoutPanel1.Controls.Add(this.donorLNTextBox);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(182, 24);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // donorFNLabel
            // 
            this.donorFNLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.donorFNLabel.AutoSize = true;
            this.donorFNLabel.Location = new System.Drawing.Point(3, 0);
            this.donorFNLabel.Name = "donorFNLabel";
            this.donorFNLabel.Size = new System.Drawing.Size(21, 24);
            this.donorFNLabel.TabIndex = 0;
            this.donorFNLabel.Text = "First Name:";
            this.donorFNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // donorFNTextBox
            // 
            this.donorFNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.donorFNTextBox.Location = new System.Drawing.Point(30, 3);
            this.donorFNTextBox.Name = "donorFNTextBox";
            this.donorFNTextBox.Size = new System.Drawing.Size(34, 20);
            this.donorFNTextBox.TabIndex = 0;
            // 
            // donorMILabel
            // 
            this.donorMILabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.donorMILabel.AutoSize = true;
            this.donorMILabel.Location = new System.Drawing.Point(70, 0);
            this.donorMILabel.Name = "donorMILabel";
            this.donorMILabel.Size = new System.Drawing.Size(12, 24);
            this.donorMILabel.TabIndex = 0;
            this.donorMILabel.Text = "M. I.:";
            this.donorMILabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // donorMITextBox
            // 
            this.donorMITextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.donorMITextBox.Location = new System.Drawing.Point(88, 3);
            this.donorMITextBox.Name = "donorMITextBox";
            this.donorMITextBox.Size = new System.Drawing.Size(21, 20);
            this.donorMITextBox.TabIndex = 0;
            // 
            // donorLNLabel
            // 
            this.donorLNLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.donorLNLabel.AutoSize = true;
            this.donorLNLabel.Location = new System.Drawing.Point(115, 0);
            this.donorLNLabel.Name = "donorLNLabel";
            this.donorLNLabel.Size = new System.Drawing.Size(21, 24);
            this.donorLNLabel.TabIndex = 0;
            this.donorLNLabel.Text = "Last Name:";
            this.donorLNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // donorLNTextBox
            // 
            this.donorLNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.donorLNTextBox.Location = new System.Drawing.Point(142, 3);
            this.donorLNTextBox.Name = "donorLNTextBox";
            this.donorLNTextBox.Size = new System.Drawing.Size(37, 20);
            this.donorLNTextBox.TabIndex = 0;
            // 
            // donorLabel
            // 
            this.donorLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.sectionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Location = new System.Drawing.Point(4, 0);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(20, 24);
            this.sectionLabel.TabIndex = 0;
            this.sectionLabel.Text = "Section:";
            this.sectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sectionComboBox
            // 
            this.sectionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sectionComboBox.FormattingEnabled = true;
            this.sectionComboBox.Location = new System.Drawing.Point(30, 3);
            this.sectionComboBox.Name = "sectionComboBox";
            this.sectionComboBox.Size = new System.Drawing.Size(48, 21);
            this.sectionComboBox.TabIndex = 0;
            // 
            // itemLabel
            // 
            this.itemLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(86, 0);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(19, 24);
            this.itemLabel.TabIndex = 0;
            this.itemLabel.Text = "Item:";
            this.itemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemComboBox
            // 
            this.itemComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(111, 3);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(48, 21);
            this.itemComboBox.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.sectionLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.sectionComboBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.itemLabel, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.itemComboBox, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 93);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(182, 24);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // startLabel1
            // 
            this.startLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.startLabel1.AutoSize = true;
            this.startLabel1.Location = new System.Drawing.Point(4, 0);
            this.startLabel1.Name = "startLabel1";
            this.startLabel1.Size = new System.Drawing.Size(20, 24);
            this.startLabel1.TabIndex = 0;
            this.startLabel1.Text = "Purchase Start:";
            this.startLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endLabel1
            // 
            this.endLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.endLabel1.AutoSize = true;
            this.endLabel1.Location = new System.Drawing.Point(85, 0);
            this.endLabel1.Name = "endLabel1";
            this.endLabel1.Size = new System.Drawing.Size(20, 24);
            this.endLabel1.TabIndex = 0;
            this.endLabel1.Text = "Purchase End:";
            this.endLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.Controls.Add(this.startLabel1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.purchaseStartDatePicker, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.endLabel1, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.purchaseEndDatePicker, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.rangeCheckBox, 4, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 123);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(182, 24);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // purchaseStartDatePicker
            // 
            this.purchaseStartDatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseStartDatePicker.Location = new System.Drawing.Point(30, 3);
            this.purchaseStartDatePicker.Name = "purchaseStartDatePicker";
            this.purchaseStartDatePicker.Size = new System.Drawing.Size(48, 20);
            this.purchaseStartDatePicker.TabIndex = 0;
            // 
            // purchaseEndDatePicker
            // 
            this.purchaseEndDatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseEndDatePicker.Location = new System.Drawing.Point(111, 3);
            this.purchaseEndDatePicker.Name = "purchaseEndDatePicker";
            this.purchaseEndDatePicker.Size = new System.Drawing.Size(48, 20);
            this.purchaseEndDatePicker.TabIndex = 0;
            // 
            // rangeCheckBox
            // 
            this.rangeCheckBox.AutoSize = true;
            this.rangeCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rangeCheckBox.Location = new System.Drawing.Point(165, 3);
            this.rangeCheckBox.Name = "rangeCheckBox";
            this.rangeCheckBox.Size = new System.Drawing.Size(14, 18);
            this.rangeCheckBox.TabIndex = 0;
            this.rangeCheckBox.Text = "Range";
            this.rangeCheckBox.UseVisualStyleBackColor = true;
            this.rangeCheckBox.CheckedChanged += new System.EventHandler(this.rangeCheckBox_CheckedChanged);
            // 
            // tableLayoutPanel6
            // 
            //this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            //this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.searchButton, 1, 0);
            //this.tableLayoutPanel6.Controls.Add(this.cancelButton, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 153);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(182, 35);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Location = new System.Drawing.Point(34, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(114, 29);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            //this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.cancelButton.Location = new System.Drawing.Point(94, 3);
            //this.cancelButton.Name = "cancelButton";
            //this.cancelButton.Size = new System.Drawing.Size(114, 29);
            // this.cancelButton.TabIndex = 0;
            //this.cancelButton.Text = "Cancel";
            //this.cancelButton.UseVisualStyleBackColor = true;
            //
            // groupBoxSearchFilters
            // 
            this.groupBoxSearchFilters.Controls.Add(this.tableLayoutPanelGroupBox);
            this.groupBoxSearchFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSearchFilters.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSearchFilters.Name = "groupBoxSearchFilters";
            this.groupBoxSearchFilters.Size = new System.Drawing.Size(194, 214);
            this.groupBoxSearchFilters.TabIndex = 0;
            this.groupBoxSearchFilters.TabStop = false;
            this.groupBoxSearchFilters.Text = "Enter Search Filters:  ";
            //
            // tableLayoutPanelFilters
            // 
            this.tableLayoutPanelFilters.ColumnCount = 1;
            this.tableLayoutPanelFilters.RowCount = 6;
            this.tableLayoutPanelFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F)); 
            this.tableLayoutPanelFilters.Dock = System.Windows.Forms.DockStyle.Fill;                                                          
            this.tableLayoutPanelFilters.Location = new System.Drawing.Point(3, 16);                                                          
            this.tableLayoutPanelFilters.Name = "tableLayoutPanelFilters";
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));       
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));       
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));       
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));       
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));       
            this.tableLayoutPanelFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));       
            this.tableLayoutPanelFilters.Controls.Add(this.tableLayoutPanel1, 0, 0);                                                          
            this.tableLayoutPanelFilters.Controls.Add(this.tableLayoutPanel3, 0, 2);                                                          
            this.tableLayoutPanelFilters.Controls.Add(this.tableLayoutPanel4, 0, 3);                                                          
            this.tableLayoutPanelFilters.Controls.Add(this.tableLayoutPanel5, 0, 4);                                                          
            this.tableLayoutPanelFilters.Controls.Add(this.tableLayoutPanel6, 0, 5);
            this.tableLayoutPanelFilters.Size = new System.Drawing.Size(188, 195);                                                            
            this.tableLayoutPanelFilters.TabIndex = 0;                                                                                        
            //
            // tableLayoutPanelGroupBox
            // 
            this.tableLayoutPanelGroupBox.ColumnCount = 1;                                                                                     
            this.tableLayoutPanelGroupBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));                                                           
            this.tableLayoutPanelGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;                                                          
            this.tableLayoutPanelGroupBox.Location = new System.Drawing.Point(3, 16);                                                          
            this.tableLayoutPanelGroupBox.Name = "tableLayoutPanelGroupBox";                                                                   
            this.tableLayoutPanelGroupBox.RowCount = 6;                                                                                        
            this.tableLayoutPanelGroupBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));       
            this.tableLayoutPanelGroupBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));       
            this.tableLayoutPanelGroupBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));       
            this.tableLayoutPanelGroupBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));       
            this.tableLayoutPanelGroupBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));       
            this.tableLayoutPanelGroupBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));       
            this.tableLayoutPanelGroupBox.Controls.Add(this.tableLayoutPanel1, 0, 0);                                                          
            this.tableLayoutPanelGroupBox.Controls.Add(this.tableLayoutPanel7, 0, 1);                                                          
            this.tableLayoutPanelGroupBox.Controls.Add(this.tableLayoutPanel8, 0, 2);                                                          
            this.tableLayoutPanelGroupBox.Controls.Add(this.tableLayoutPanel3, 0, 3);                                                          
            this.tableLayoutPanelGroupBox.Controls.Add(this.tableLayoutPanel5, 0, 4);                                                          
            this.tableLayoutPanelGroupBox.Controls.Add(this.tableLayoutPanel6, 0, 5);
            this.tableLayoutPanelGroupBox.Size = new System.Drawing.Size(188, 195);                                                            
            this.tableLayoutPanelGroupBox.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel7.Controls.Add(this.addressLabel);
            this.tableLayoutPanel7.Controls.Add(this.addressTextBox);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(182, 24);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressLabel.Location = new System.Drawing.Point(3, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(21, 24);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "Address:";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressTextBox.Location = new System.Drawing.Point(30, 3);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(149, 20);
            this.addressTextBox.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 6;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel8.Controls.Add(this.cityLabel, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.cityTextBox, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.stateLabel, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.stateTextBox, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.zipLabel, 4, 0);
            this.tableLayoutPanel8.Controls.Add(this.zipTextBox, 5, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(182, 24);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityLabel.Location = new System.Drawing.Point(3, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(21, 24);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "City:";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityTextBox.Location = new System.Drawing.Point(30, 3);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(34, 20);
            this.cityTextBox.TabIndex = 0;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateLabel.Location = new System.Drawing.Point(70, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(12, 24);
            this.stateLabel.TabIndex = 0;
            this.stateLabel.Text = "State:";
            this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stateTextBox
            // 
            this.stateTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateTextBox.Location = new System.Drawing.Point(88, 3);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(21, 20);
            this.stateTextBox.TabIndex = 0;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zipLabel.Location = new System.Drawing.Point(115, 0);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(21, 24);
            this.zipLabel.TabIndex = 0;
            this.zipLabel.Text = "Zip:";
            this.zipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // zipTextBox
            // 
            this.zipTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zipTextBox.Location = new System.Drawing.Point(142, 3);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(37, 20);
            this.zipTextBox.TabIndex = 0;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxSearchFilters);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelBottom);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.ColumnCount = 2;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottom.Controls.Add(this.groupBoxSection);
            this.tableLayoutPanelBottom.Controls.Add(this.groupBoxResults);
            this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(3, 223);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.RowCount = 1;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(194, 1);
            this.tableLayoutPanelBottom.TabIndex = 0;
            // 
            // groupBoxSection
            // 
            this.groupBoxSection.Controls.Add(this.panelSectionImage);
            this.groupBoxSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSection.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSection.Name = "groupBoxSection";
            this.groupBoxSection.Size = new System.Drawing.Size(244, 1);
            this.groupBoxSection.TabIndex = 0;
            this.groupBoxSection.TabStop = false;
            this.groupBoxSection.Text = "Section Legend:";
            // 
            // panelSectionImage
            // 
            this.panelSectionImage.BackgroundImage = global::TeamJ.Properties.Resources.Plaza;
            this.panelSectionImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSectionImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSectionImage.Location = new System.Drawing.Point(3, 16);
            this.panelSectionImage.Name = "panelSectionImage";
            this.panelSectionImage.Size = new System.Drawing.Size(238, 0);
            this.panelSectionImage.TabIndex = 0;
            // 
            // groupBoxResults
            //
            this.groupBoxResults.Controls.Add(this.tableLayoutPanelSearchResults);
            this.groupBoxResults.Controls.Add(this.listBoxResults);
            //this.groupBoxResults.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResults.Location = new System.Drawing.Point(253, 3);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(1, 1);
            this.groupBoxResults.TabIndex = 0;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Search Results:";
            // 
            // tableLayoutPanelSearchResults
            // 
            this.tableLayoutPanelSearchResults.ColumnCount = 1;
            this.tableLayoutPanelSearchResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSearchResults.Controls.Add(this.listBoxResults);
            this.tableLayoutPanelSearchResults.Controls.Add(this.tableLayoutPanelSearchResultButtons);
            this.tableLayoutPanelSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSearchResults.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelSearchResults.Name = "tableLayoutPanelSearchResults";
            this.tableLayoutPanelSearchResults.RowCount = 2;
            this.tableLayoutPanelSearchResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSearchResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelSearchResults.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanelSearchResults.TabIndex = 0;
            // 
            // listBoxResults
            // 
            this.listBoxResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.Location = new System.Drawing.Point(3, 3);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(1, 1);
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
            this.tableLayoutPanelSearchResultButtons.Location = new System.Drawing.Point(3, -46);
            this.tableLayoutPanelSearchResultButtons.Name = "tableLayoutPanelSearchResultButtons";
            this.tableLayoutPanelSearchResultButtons.RowCount = 1;
            this.tableLayoutPanelSearchResultButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSearchResultButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSearchResultButtons.Size = new System.Drawing.Size(1, 44);
            this.tableLayoutPanelSearchResultButtons.TabIndex = 0;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelect.Location = new System.Drawing.Point(-96, 3);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(94, 38);
            this.buttonSelect.TabIndex = 0;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            // 
            // buttonNew
            // 
            this.buttonNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNew.Location = new System.Drawing.Point(4, 3);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(94, 38);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "Add New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.listBoxResults.Size = new System.Drawing.Size(188, -35);
            this.listBoxResults.TabIndex = 0;
            //
            // tableLayoutPanel4
            // 
            //this.tableLayoutPanel4.ColumnCount = 4;
            //this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            //this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            //this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            //this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            //this.tableLayoutPanel4.Controls.Add(this.backButton, 0, 0);
            //this.tableLayoutPanel4.Controls.Add(this.selectButton, 3, 0);
            //this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            //this.tableLayoutPanel4.Location = new System.Drawing.Point(3, -19);
            //this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            //this.tableLayoutPanel4.RowCount = 1;
            //this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            //this.tableLayoutPanel4.Size = new System.Drawing.Size(188, 35);
            //this.tableLayoutPanel4.TabIndex = 0;
            // 
            // backButton
            // 
            //this.backButton.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.backButton.Location = new System.Drawing.Point(3, 3);
            //this.backButton.Name = "backButton";
            //this.backButton.Size = new System.Drawing.Size(114, 29);
            //this.backButton.TabIndex = 0;
            //this.backButton.Text = "Back";
            //this.backButton.UseVisualStyleBackColor = true;
            //
            // selectButton
            // 
            //this.selectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.selectButton.Location = new System.Drawing.Point(71, 3);
            //this.selectButton.Name = "selectButton";
            //this.selectButton.Size = new System.Drawing.Size(114, 29);
            //this.selectButton.TabIndex = 0;
            //this.selectButton.Text = "Select";
            //this.selectButton.UseVisualStyleBackColor = true;
            // 
            // AdvancedSearchPanel
            // 
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Size = new System.Drawing.Size(200, 50);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBoxSearchFilters.ResumeLayout(false);
            this.tableLayoutPanelFilters.ResumeLayout(false);
            this.tableLayoutPanelGroupBox.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelBottom.ResumeLayout(false);
            this.groupBoxSection.ResumeLayout(false);
            this.groupBoxResults.ResumeLayout(false);
            this.tableLayoutPanelSearchResults.ResumeLayout(false);
            this.tableLayoutPanelSearchResultButtons.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Label donorLabel;
        private Label donorFNLabel;
        private Label donorMILabel;
        private Label donorLNLabel;
        private TextBox donorFNTextBox;
        private TextBox donorMITextBox;
        private TextBox donorLNTextBox;
        private Label sectionLabel;
        private ComboBox sectionComboBox;
        private Label itemLabel;
        private ComboBox itemComboBox;
        private TableLayoutPanel tableLayoutPanel3;
        private Label endLabel1;
        private TableLayoutPanel tableLayoutPanel5;
        private Label startLabel1;
        private TableLayoutPanel tableLayoutPanel6;
        private Button searchButton;
        private GroupBox groupBoxSearchFilters;
        private TableLayoutPanel tableLayoutPanelFilters;
        private TableLayoutPanel tableLayoutPanelMain;
        private GroupBox groupBoxResults;
        private ListBox listBoxResults;
        private TableLayoutPanel tableLayoutPanelSearchResultButtons;
        private Button buttonSelect;
        private Button buttonNew;
        private TableLayoutPanel tableLayoutPanelGroupBox;
        private TableLayoutPanel tableLayoutPanelBottom;
        private GroupBox groupBoxSection;
        private Panel panelSectionImage;
        private TableLayoutPanel tableLayoutPanelSearchResults;
        //private Button cancelButton;
        //private Button backButton;
        //private Button selectButton;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel7;
        private Label addressLabel;
        private TextBox addressTextBox;
        private TableLayoutPanel tableLayoutPanel8;
        private Label cityLabel;
        private Label stateLabel;
        private Label zipLabel;
        private TextBox cityTextBox;
        private TextBox stateTextBox;
        private TextBox zipTextBox;
        private DateTimePicker purchaseStartDatePicker;
        private DateTimePicker purchaseEndDatePicker;
        private CheckBox rangeCheckBox;
    }
}
