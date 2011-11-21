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
            this.donorLabel = new System.Windows.Forms.Label();
            this.donorFNLabel = new System.Windows.Forms.Label();
            this.donorFNTextBox = new System.Windows.Forms.TextBox();
            this.donorMILabel = new System.Windows.Forms.Label();
            this.donorMITextBox = new System.Windows.Forms.TextBox();
            this.donorLNLabel = new System.Windows.Forms.Label();
            this.donorLNTextBox = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel1.Controls.Add(this.donorLabel);
            this.tableLayoutPanel1.Controls.Add(this.donorFNLabel);
            this.tableLayoutPanel1.Controls.Add(this.donorFNTextBox);
            this.tableLayoutPanel1.Controls.Add(this.donorMILabel);
            this.tableLayoutPanel1.Controls.Add(this.donorMITextBox);
            this.tableLayoutPanel1.Controls.Add(this.donorLNLabel);
            this.tableLayoutPanel1.Controls.Add(this.donorLNTextBox);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 25);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // donorLabel
            // 
            this.donorLabel.AutoSize = true;
            this.donorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.donorLabel.Location = new System.Drawing.Point(3, 0);
            this.donorLabel.Name = "donorLabel";
            this.donorLabel.Size = new System.Drawing.Size(24, 25);
            this.donorLabel.TabIndex = 0;
            this.donorLabel.Text = "Donor";
            this.donorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // donorFNLabel
            // 
            this.donorFNLabel.AutoSize = true;
            this.donorFNLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.donorFNLabel.Location = new System.Drawing.Point(33, 0);
            this.donorFNLabel.Name = "donorFNLabel";
            this.donorFNLabel.Size = new System.Drawing.Size(14, 25);
            this.donorFNLabel.TabIndex = 0;
            this.donorFNLabel.Text = "First Name";
            this.donorFNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // donorFNTextBox
            // 
            this.donorFNTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.donorFNTextBox.Location = new System.Drawing.Point(53, 3);
            this.donorFNTextBox.Name = "donorFNTextBox";
            this.donorFNTextBox.Size = new System.Drawing.Size(39, 20);
            this.donorFNTextBox.TabIndex = 0;
            // 
            // donorMILabel
            // 
            this.donorMILabel.AutoSize = true;
            this.donorMILabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.donorMILabel.Location = new System.Drawing.Point(98, 0);
            this.donorMILabel.Name = "donorMILabel";
            this.donorMILabel.Size = new System.Drawing.Size(14, 25);
            this.donorMILabel.TabIndex = 0;
            this.donorMILabel.Text = "M. I.";
            this.donorMILabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // donorMITextBox
            // 
            this.donorMITextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.donorMITextBox.Location = new System.Drawing.Point(118, 3);
            this.donorMITextBox.Name = "donorMITextBox";
            this.donorMITextBox.Size = new System.Drawing.Size(14, 20);
            this.donorMITextBox.TabIndex = 0;
            // 
            // donorLNLabel
            // 
            this.donorLNLabel.AutoSize = true;
            this.donorLNLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.donorLNLabel.Location = new System.Drawing.Point(138, 0);
            this.donorLNLabel.Name = "donorLNLabel";
            this.donorLNLabel.Size = new System.Drawing.Size(14, 25);
            this.donorLNLabel.TabIndex = 0;
            this.donorLNLabel.Text = "Last Name";
            this.donorLNLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // donorLNTextBox
            // 
            this.donorLNTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.donorLNTextBox.Location = new System.Drawing.Point(158, 3);
            this.donorLNTextBox.Name = "donorLNTextBox";
            this.donorLNTextBox.Size = new System.Drawing.Size(39, 20);
            this.donorLNTextBox.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Controls.Add(this.engravingLabel);
            this.tableLayoutPanel2.Controls.Add(this.engravingTextBox);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 25);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // engravingLabel
            // 
            this.engravingLabel.AutoSize = true;
            this.engravingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.engravingLabel.Location = new System.Drawing.Point(3, 0);
            this.engravingLabel.Name = "engravingLabel";
            this.engravingLabel.Size = new System.Drawing.Size(24, 25);
            this.engravingLabel.TabIndex = 0;
            this.engravingLabel.Text = "Engraving";
            this.engravingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // engravingTextBox
            // 
            this.engravingTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.engravingTextBox.Location = new System.Drawing.Point(33, 3);
            this.engravingTextBox.Name = "engravingTextBox";
            this.engravingTextBox.Size = new System.Drawing.Size(164, 20);
            this.engravingTextBox.TabIndex = 0;
            // 
            // sectionLabel
            // 
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sectionLabel.Location = new System.Drawing.Point(33, 0);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(34, 25);
            this.sectionLabel.TabIndex = 0;
            this.sectionLabel.Text = "Section";
            this.sectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sectionComboBox
            // 
            this.sectionComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sectionComboBox.FormattingEnabled = true;
            this.sectionComboBox.Location = new System.Drawing.Point(73, 3);
            this.sectionComboBox.Name = "sectionComboBox";
            this.sectionComboBox.Size = new System.Drawing.Size(39, 21);
            this.sectionComboBox.TabIndex = 0;
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemLabel.Location = new System.Drawing.Point(118, 0);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(34, 25);
            this.itemLabel.TabIndex = 0;
            this.itemLabel.Text = "Item";
            this.itemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemComboBox
            // 
            this.itemComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(158, 3);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(39, 21);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 25);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // brickLabel
            // 
            this.brickLabel.AutoSize = true;
            this.brickLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brickLabel.Location = new System.Drawing.Point(3, 0);
            this.brickLabel.Name = "brickLabel";
            this.brickLabel.Size = new System.Drawing.Size(24, 25);
            this.brickLabel.TabIndex = 0;
            this.brickLabel.Text = "Brick";
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 75);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 25);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // graduationLabel
            // 
            this.graduationLabel.AutoSize = true;
            this.graduationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graduationLabel.Location = new System.Drawing.Point(3, 0);
            this.graduationLabel.Name = "graduationLabel";
            this.graduationLabel.Size = new System.Drawing.Size(24, 25);
            this.graduationLabel.TabIndex = 0;
            this.graduationLabel.Text = "Graduation";
            this.graduationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startLabel1
            // 
            this.startLabel1.AutoSize = true;
            this.startLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startLabel1.Location = new System.Drawing.Point(33, 0);
            this.startLabel1.Name = "startLabel1";
            this.startLabel1.Size = new System.Drawing.Size(34, 25);
            this.startLabel1.TabIndex = 0;
            this.startLabel1.Text = "Start";
            this.startLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // graduationStartComboBox
            // 
            this.graduationStartComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graduationStartComboBox.FormattingEnabled = true;
            this.graduationStartComboBox.Location = new System.Drawing.Point(73, 3);
            this.graduationStartComboBox.Name = "graduationStartComboBox";
            this.graduationStartComboBox.Size = new System.Drawing.Size(39, 21);
            this.graduationStartComboBox.TabIndex = 0;
            // 
            // endLabel1
            // 
            this.endLabel1.AutoSize = true;
            this.endLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endLabel1.Location = new System.Drawing.Point(118, 0);
            this.endLabel1.Name = "endLabel1";
            this.endLabel1.Size = new System.Drawing.Size(34, 25);
            this.endLabel1.TabIndex = 0;
            this.endLabel1.Text = "End";
            this.endLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // graduationEndComboBox
            // 
            this.graduationEndComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graduationEndComboBox.FormattingEnabled = true;
            this.graduationEndComboBox.Location = new System.Drawing.Point(158, 3);
            this.graduationEndComboBox.Name = "graduationEndComboBox";
            this.graduationEndComboBox.Size = new System.Drawing.Size(39, 21);
            this.graduationEndComboBox.TabIndex = 0;
            // 
            // endLabel2
            // 
            this.endLabel2.AutoSize = true;
            this.endLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endLabel2.Location = new System.Drawing.Point(118, 0);
            this.endLabel2.Name = "endLabel2";
            this.endLabel2.Size = new System.Drawing.Size(34, 25);
            this.endLabel2.TabIndex = 1;
            this.endLabel2.Text = "End";
            this.endLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // purchaseStartComboBox
            // 
            this.purchaseStartComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseStartComboBox.FormattingEnabled = true;
            this.purchaseStartComboBox.Location = new System.Drawing.Point(73, 3);
            this.purchaseStartComboBox.Name = "purchaseStartComboBox";
            this.purchaseStartComboBox.Size = new System.Drawing.Size(39, 21);
            this.purchaseStartComboBox.TabIndex = 2;
            // 
            // purchaseEndComboBox
            // 
            this.purchaseEndComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseEndComboBox.FormattingEnabled = true;
            this.purchaseEndComboBox.Location = new System.Drawing.Point(158, 3);
            this.purchaseEndComboBox.Name = "purchaseEndComboBox";
            this.purchaseEndComboBox.Size = new System.Drawing.Size(39, 21);
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
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 25);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // purchaseLabel
            // 
            this.purchaseLabel.AutoSize = true;
            this.purchaseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseLabel.Location = new System.Drawing.Point(3, 0);
            this.purchaseLabel.Name = "purchaseLabel";
            this.purchaseLabel.Size = new System.Drawing.Size(24, 25);
            this.purchaseLabel.TabIndex = 0;
            this.purchaseLabel.Text = "Purchase";
            this.purchaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startLabel2
            // 
            this.startLabel2.AutoSize = true;
            this.startLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startLabel2.Location = new System.Drawing.Point(33, 0);
            this.startLabel2.Name = "startLabel2";
            this.startLabel2.Size = new System.Drawing.Size(34, 25);
            this.startLabel2.TabIndex = 0;
            this.startLabel2.Text = "Start";
            this.startLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Controls.Add(this.searchButton, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.cancelButton, 3, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 125);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(200, 40);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchButton.Location = new System.Drawing.Point(103, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(44, 34);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(153, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(44, 34);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AdvancedSearchPanel
            // 
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
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



    }
}
