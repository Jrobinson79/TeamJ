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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.engravingLabel = new System.Windows.Forms.Label();
            this.engravingTextBox = new System.Windows.Forms.TextBox();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.sectionComboBox = new System.Windows.Forms.ComboBox();
            this.itemLabel = new System.Windows.Forms.Label();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.brickLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.graduationLabel = new System.Windows.Forms.Label();
            this.startLabel1 = new System.Windows.Forms.Label();
            this.graduationStartComboBox = new System.Windows.Forms.ComboBox();
            this.endLabel1 = new System.Windows.Forms.Label();
            this.graduationEndComboBox = new System.Windows.Forms.ComboBox();
            this.endLabel2 = new System.Windows.Forms.Label();
            this.purchaseStartComboBox = new System.Windows.Forms.ComboBox();
            this.purchaseEndComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.purchaseLabel = new System.Windows.Forms.Label();
            this.startLabel2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBoxSearchFilters = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelGroupBox = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBoxSearchFilters.SuspendLayout();
            this.tableLayoutPanelGroupBox.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
            this.donorFNLabel.Location = new System.Drawing.Point(37, 5);
            this.donorFNLabel.Name = "donorFNLabel";
            this.donorFNLabel.Size = new System.Drawing.Size(60, 13);
            this.donorFNLabel.TabIndex = 0;
            this.donorFNLabel.Text = "First Name:";
            this.donorFNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // donorFNTextBox
            // 
            this.donorFNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.donorFNTextBox.Location = new System.Drawing.Point(103, 3);
            this.donorFNTextBox.Name = "donorFNTextBox";
            this.donorFNTextBox.Size = new System.Drawing.Size(1, 20);
            this.donorFNTextBox.TabIndex = 0;
            // 
            // donorMILabel
            // 
            this.donorMILabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.donorMILabel.AutoSize = true;
            this.donorMILabel.Location = new System.Drawing.Point(47, 5);
            this.donorMILabel.Name = "donorMILabel";
            this.donorMILabel.Size = new System.Drawing.Size(31, 13);
            this.donorMILabel.TabIndex = 0;
            this.donorMILabel.Text = "M. I.:";
            this.donorMILabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // donorMITextBox
            // 
            this.donorMITextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.donorMITextBox.Location = new System.Drawing.Point(84, 3);
            this.donorMITextBox.Name = "donorMITextBox";
            this.donorMITextBox.Size = new System.Drawing.Size(54, 20);
            this.donorMITextBox.TabIndex = 0;
            // 
            // donorLNLabel
            // 
            this.donorLNLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.donorLNLabel.AutoSize = true;
            this.donorLNLabel.Location = new System.Drawing.Point(177, 5);
            this.donorLNLabel.Name = "donorLNLabel";
            this.donorLNLabel.Size = new System.Drawing.Size(61, 13);
            this.donorLNLabel.TabIndex = 0;
            this.donorLNLabel.Text = "Last Name:";
            this.donorLNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // donorLNTextBox
            // 
            this.donorLNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.donorLNTextBox.Location = new System.Drawing.Point(244, 3);
            this.donorLNTextBox.Name = "donorLNTextBox";
            this.donorLNTextBox.Size = new System.Drawing.Size(1, 20);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Controls.Add(this.engravingLabel);
            this.tableLayoutPanel2.Controls.Add(this.engravingTextBox);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(182, 24);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // engravingLabel
            // 
            this.engravingLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.engravingLabel.AutoSize = true;
            this.engravingLabel.Location = new System.Drawing.Point(3, 0);
            this.engravingLabel.Name = "engravingLabel";
            this.engravingLabel.Size = new System.Drawing.Size(21, 24);
            this.engravingLabel.TabIndex = 0;
            this.engravingLabel.Text = "Engraving:";
            this.engravingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // engravingTextBox
            // 
            this.engravingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.engravingTextBox.Location = new System.Drawing.Point(30, 3);
            this.engravingTextBox.Name = "engravingTextBox";
            this.engravingTextBox.Size = new System.Drawing.Size(149, 20);
            this.engravingTextBox.TabIndex = 0;
            // 
            // sectionLabel
            // 
            this.sectionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Location = new System.Drawing.Point(31, 0);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(29, 24);
            this.sectionLabel.TabIndex = 0;
            this.sectionLabel.Text = "Section:";
            this.sectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sectionComboBox
            // 
            this.sectionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sectionComboBox.FormattingEnabled = true;
            this.sectionComboBox.Location = new System.Drawing.Point(66, 3);
            this.sectionComboBox.Name = "sectionComboBox";
            this.sectionComboBox.Size = new System.Drawing.Size(34, 21);
            this.sectionComboBox.TabIndex = 0;
            // 
            // itemLabel
            // 
            this.itemLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(106, 5);
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
            this.itemComboBox.Location = new System.Drawing.Point(142, 3);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(37, 21);
            this.itemComboBox.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel3.Controls.Add(this.brickLabel);
            this.tableLayoutPanel3.Controls.Add(this.sectionLabel);
            this.tableLayoutPanel3.Controls.Add(this.sectionComboBox);
            this.tableLayoutPanel3.Controls.Add(this.itemLabel);
            this.tableLayoutPanel3.Controls.Add(this.itemComboBox);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(182, 24);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // brickLabel
            // 
            this.brickLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.brickLabel.AutoSize = true;
            this.brickLabel.Location = new System.Drawing.Point(5, 0);
            this.brickLabel.Name = "brickLabel";
            this.brickLabel.Size = new System.Drawing.Size(19, 24);
            this.brickLabel.TabIndex = 0;
            this.brickLabel.Text = "Brick:";
            this.brickLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel4.Controls.Add(this.graduationLabel);
            this.tableLayoutPanel4.Controls.Add(this.startLabel1);
            this.tableLayoutPanel4.Controls.Add(this.graduationStartComboBox);
            this.tableLayoutPanel4.Controls.Add(this.endLabel1);
            this.tableLayoutPanel4.Controls.Add(this.graduationEndComboBox);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 93);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(182, 24);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // graduationLabel
            // 
            this.graduationLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.graduationLabel.AutoSize = true;
            this.graduationLabel.Location = new System.Drawing.Point(5, 0);
            this.graduationLabel.Name = "graduationLabel";
            this.graduationLabel.Size = new System.Drawing.Size(19, 24);
            this.graduationLabel.TabIndex = 0;
            this.graduationLabel.Text = "Graduation:";
            this.graduationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startLabel1
            // 
            this.startLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.startLabel1.AutoSize = true;
            this.startLabel1.Location = new System.Drawing.Point(31, 0);
            this.startLabel1.Name = "startLabel1";
            this.startLabel1.Size = new System.Drawing.Size(29, 24);
            this.startLabel1.TabIndex = 0;
            this.startLabel1.Text = "Start:";
            this.startLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // graduationStartComboBox
            // 
            this.graduationStartComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.graduationStartComboBox.FormattingEnabled = true;
            this.graduationStartComboBox.Location = new System.Drawing.Point(66, 3);
            this.graduationStartComboBox.Name = "graduationStartComboBox";
            this.graduationStartComboBox.Size = new System.Drawing.Size(34, 21);
            this.graduationStartComboBox.TabIndex = 0;
            // 
            // endLabel1
            // 
            this.endLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.endLabel1.AutoSize = true;
            this.endLabel1.Location = new System.Drawing.Point(107, 5);
            this.endLabel1.Name = "endLabel1";
            this.endLabel1.Size = new System.Drawing.Size(29, 13);
            this.endLabel1.TabIndex = 0;
            this.endLabel1.Text = "End:";
            this.endLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // graduationEndComboBox
            // 
            this.graduationEndComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.graduationEndComboBox.FormattingEnabled = true;
            this.graduationEndComboBox.Location = new System.Drawing.Point(142, 3);
            this.graduationEndComboBox.Name = "graduationEndComboBox";
            this.graduationEndComboBox.Size = new System.Drawing.Size(37, 21);
            this.graduationEndComboBox.TabIndex = 0;
            // 
            // endLabel2
            // 
            this.endLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.endLabel2.AutoSize = true;
            this.endLabel2.Location = new System.Drawing.Point(107, 5);
            this.endLabel2.Name = "endLabel2";
            this.endLabel2.Size = new System.Drawing.Size(29, 13);
            this.endLabel2.TabIndex = 1;
            this.endLabel2.Text = "End:";
            this.endLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // purchaseStartComboBox
            // 
            this.purchaseStartComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseStartComboBox.FormattingEnabled = true;
            this.purchaseStartComboBox.Location = new System.Drawing.Point(66, 3);
            this.purchaseStartComboBox.Name = "purchaseStartComboBox";
            this.purchaseStartComboBox.Size = new System.Drawing.Size(34, 21);
            this.purchaseStartComboBox.TabIndex = 2;
            // 
            // purchaseEndComboBox
            // 
            this.purchaseEndComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseEndComboBox.FormattingEnabled = true;
            this.purchaseEndComboBox.Location = new System.Drawing.Point(142, 3);
            this.purchaseEndComboBox.Name = "purchaseEndComboBox";
            this.purchaseEndComboBox.Size = new System.Drawing.Size(37, 21);
            this.purchaseEndComboBox.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel5.Controls.Add(this.purchaseLabel);
            this.tableLayoutPanel5.Controls.Add(this.startLabel2);
            this.tableLayoutPanel5.Controls.Add(this.purchaseStartComboBox);
            this.tableLayoutPanel5.Controls.Add(this.endLabel2);
            this.tableLayoutPanel5.Controls.Add(this.purchaseEndComboBox);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 123);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(182, 24);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // purchaseLabel
            // 
            this.purchaseLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.purchaseLabel.AutoSize = true;
            this.purchaseLabel.Location = new System.Drawing.Point(3, 0);
            this.purchaseLabel.Name = "purchaseLabel";
            this.purchaseLabel.Size = new System.Drawing.Size(21, 24);
            this.purchaseLabel.TabIndex = 0;
            this.purchaseLabel.Text = "Purchase:";
            this.purchaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startLabel2
            // 
            this.startLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.startLabel2.AutoSize = true;
            this.startLabel2.Location = new System.Drawing.Point(31, 0);
            this.startLabel2.Name = "startLabel2";
            this.startLabel2.Size = new System.Drawing.Size(29, 24);
            this.startLabel2.TabIndex = 0;
            this.startLabel2.Text = "Start:";
            this.startLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.searchButton, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.cancelButton, 2, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 153);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(182, 39);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Location = new System.Drawing.Point(-26, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(114, 33);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(94, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 33);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
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
            // tableLayoutPanelGroupBox
            // 
            this.tableLayoutPanelGroupBox.ColumnCount = 1;
            this.tableLayoutPanelGroupBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGroupBox.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanelGroupBox.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanelGroupBox.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanelGroupBox.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanelGroupBox.Controls.Add(this.tableLayoutPanel5, 0, 4);
            this.tableLayoutPanelGroupBox.Controls.Add(this.tableLayoutPanel6, 0, 5);
            this.tableLayoutPanelGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGroupBox.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelGroupBox.Name = "tableLayoutPanelGroupBox";
            this.tableLayoutPanelGroupBox.RowCount = 6;
            this.tableLayoutPanelGroupBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelGroupBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelGroupBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelGroupBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelGroupBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelGroupBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGroupBox.Size = new System.Drawing.Size(188, 195);
            this.tableLayoutPanelGroupBox.TabIndex = 0;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxSearchFilters);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxResults);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.listBoxResults);
            this.groupBoxResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResults.Location = new System.Drawing.Point(3, 223);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(194, 1);
            this.groupBoxResults.TabIndex = 0;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Search Results:";
            // 
            // listBoxResults
            // 
            this.listBoxResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.Location = new System.Drawing.Point(3, 16);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(188, 0);
            this.listBoxResults.TabIndex = 0;
            // 
            // AdvancedSearchPanel
            // 
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Size = new System.Drawing.Size(200, 50);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBoxSearchFilters.ResumeLayout(false);
            this.tableLayoutPanelGroupBox.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.groupBoxResults.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel2;
        private Label engravingLabel;
        private TextBox engravingTextBox;
        private Label sectionLabel;
        private ComboBox sectionComboBox;
        private Label itemLabel;
        private ComboBox itemComboBox;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label graduationLabel;
        private Label endLabel1;
        private ComboBox graduationEndComboBox;
        private ComboBox graduationStartComboBox;
        private Label brickLabel;
        private TableLayoutPanel tableLayoutPanel5;
        private Label purchaseLabel;
        private Label startLabel1;
        private Label startLabel2;
        private Label endLabel2;
        private ComboBox purchaseStartComboBox;
        private ComboBox purchaseEndComboBox;
        private TableLayoutPanel tableLayoutPanel6;
        private Button searchButton;
        private Button cancelButton;
        private GroupBox groupBoxSearchFilters;
        private TableLayoutPanel tableLayoutPanelGroupBox;
        private TableLayoutPanel tableLayoutPanelMain;
        private GroupBox groupBoxResults;
        private ListBox listBoxResults;



    }
}
