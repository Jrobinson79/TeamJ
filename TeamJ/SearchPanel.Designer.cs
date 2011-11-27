
using System.Windows.Forms;

namespace TeamJ
{
    partial class SearchPanel
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
            this.panelLSUSImage = new System.Windows.Forms.Panel();
            this.tableLayoutPanelSearch = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSelect = new System.Windows.Forms.Label();
            this.listBoxSelect = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelSearch.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanelMain.AutoSize = true;
            this.tableLayoutPanelMain.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.panelLSUSImage, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelSearch, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelSelect, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.listBoxSelect, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelButtons, 0, 4);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(69, 3);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 5;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(260, 94);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelLSUSImage
            // 
            this.panelLSUSImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLSUSImage.BackgroundImage = global::TeamJ.Properties.Resources.logo1;
            this.panelLSUSImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLSUSImage.Location = new System.Drawing.Point(3, 3);
            this.panelLSUSImage.Name = "panelLSUSImage";
            this.panelLSUSImage.Size = new System.Drawing.Size(250, 75);
            this.panelLSUSImage.TabIndex = 0;
            // 
            // tableLayoutPanelSearch
            // 
            this.tableLayoutPanelSearch.ColumnCount = 2;
            this.tableLayoutPanelSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanelSearch.Controls.Add(this.textBoxSearch, 0, 0);
            this.tableLayoutPanelSearch.Controls.Add(this.buttonSearch, 1, 0);
            this.tableLayoutPanelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSearch.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanelSearch.Name = "tableLayoutPanelSearch";
            this.tableLayoutPanelSearch.RowCount = 1;
            this.tableLayoutPanelSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSearch.Size = new System.Drawing.Size(254, 29);
            this.tableLayoutPanelSearch.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(3, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(173, 20);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.Text = "Enter Name Here";
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(182, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(69, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSelect
            // 
            this.labelSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSelect.AutoSize = true;
            this.labelSelect.Location = new System.Drawing.Point(3, 115);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(177, 30);
            this.labelSelect.TabIndex = 0;
            this.labelSelect.Text = "Select the Correct Donor/Recipient:";
            this.labelSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxSelect
            // 
            this.listBoxSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSelect.FormattingEnabled = true;
            this.listBoxSelect.Location = new System.Drawing.Point(3, 148);
            this.listBoxSelect.Name = "listBoxSelect";
            this.listBoxSelect.Size = new System.Drawing.Size(254, 1);
            this.listBoxSelect.TabIndex = 0;
            this.listBoxSelect.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxSelect_MouseDoubleClick);
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 2;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Controls.Add(this.buttonSelect, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonNew, 1, 0);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(3, 47);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 1;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(254, 44);
            this.tableLayoutPanelButtons.TabIndex = 0;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelect.Location = new System.Drawing.Point(44, 3);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(80, 38);
            this.buttonSelect.TabIndex = 0;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNew.Location = new System.Drawing.Point(130, 3);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(80, 38);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "Add New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelMain, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SearchPanel
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Size = new System.Drawing.Size(400, 100);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.tableLayoutPanelSearch.ResumeLayout(false);
            this.tableLayoutPanelSearch.PerformLayout();
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanelMain;
        private Panel panelLSUSImage;
        private TableLayoutPanel tableLayoutPanelSearch;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Label labelSelect;
        private ListBox listBoxSelect;
        private TableLayoutPanel tableLayoutPanelButtons;
        private Button buttonSelect;
        private Button buttonNew;
        private TableLayoutPanel tableLayoutPanel1;

    }
}
