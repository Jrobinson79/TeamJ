namespace TeamJ
{
    partial class ShowDonorPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDonorPanel));
            this.tableLayoutPanelBorder = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelImage = new System.Windows.Forms.TableLayoutPanel();
            this.panelLogoImage = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMainBottom = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBottomLeft = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLabel = new System.Windows.Forms.TableLayoutPanel();
            this.labelDonor = new System.Windows.Forms.Label();
            this.labelDonorName = new System.Windows.Forms.Label();
            this.groupBoxRecipients = new System.Windows.Forms.GroupBox();
            this.listBoxRecipients = new System.Windows.Forms.ListBox();
            this.panelBrickImage = new System.Windows.Forms.Panel();
            this.tableLayoutPanelBottomLeftButtons = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonBrick = new System.Windows.Forms.RadioButton();
            this.radioButtonSection = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanelBottomRight = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlInfo = new System.Windows.Forms.TabControl();
            this.tabPageDonor = new System.Windows.Forms.TabPage();
            this.tabPageRecipient = new System.Windows.Forms.TabPage();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.personInfoPanelDonor = new TeamJ.PersonInfoPanel(this.components);
            this.personInfoPanelRecipient = new TeamJ.PersonInfoPanel(this.components);
            this.transactionPanel1 = new TeamJ.TransactionPanel(this.components);
            this.tableLayoutPanelBorder.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelImage.SuspendLayout();
            this.tableLayoutPanelMainBottom.SuspendLayout();
            this.tableLayoutPanelBottomLeft.SuspendLayout();
            this.tableLayoutPanelLabel.SuspendLayout();
            this.groupBoxRecipients.SuspendLayout();
            this.tableLayoutPanelBottomLeftButtons.SuspendLayout();
            this.tableLayoutPanelBottomRight.SuspendLayout();
            this.tabControlInfo.SuspendLayout();
            this.tabPageDonor.SuspendLayout();
            this.tabPageRecipient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBorder
            // 
            this.tableLayoutPanelBorder.AutoSize = true;
            this.tableLayoutPanelBorder.ColumnCount = 3;
            this.tableLayoutPanelBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelBorder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelBorder.Controls.Add(this.tableLayoutPanelMain, 1, 0);
            this.tableLayoutPanelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBorder.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanelBorder.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBorder.Name = "tableLayoutPanelBorder";
            this.tableLayoutPanelBorder.RowCount = 1;
            this.tableLayoutPanelBorder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBorder.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanelBorder.TabIndex = 0;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.AutoSize = true;
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelImage, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelMainBottom, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(13, 3);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(174, 94);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelImage
            // 
            this.tableLayoutPanelImage.AutoSize = true;
            this.tableLayoutPanelImage.ColumnCount = 3;
            this.tableLayoutPanelImage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanelImage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelImage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanelImage.Controls.Add(this.panelLogoImage, 1, 0);
            this.tableLayoutPanelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelImage.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanelImage.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelImage.Name = "tableLayoutPanelImage";
            this.tableLayoutPanelImage.RowCount = 1;
            this.tableLayoutPanelImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelImage.Size = new System.Drawing.Size(168, 94);
            this.tableLayoutPanelImage.TabIndex = 0;
            // 
            // panelLogoImage
            // 
            this.panelLogoImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelLogoImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogoImage.BackgroundImage")));
            this.panelLogoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogoImage.Location = new System.Drawing.Point(36, 3);
            this.panelLogoImage.Name = "panelLogoImage";
            this.panelLogoImage.Size = new System.Drawing.Size(96, 75);
            this.panelLogoImage.TabIndex = 0;
            // 
            // tableLayoutPanelMainBottom
            // 
            this.tableLayoutPanelMainBottom.AutoSize = true;
            this.tableLayoutPanelMainBottom.ColumnCount = 2;
            this.tableLayoutPanelMainBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMainBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMainBottom.Controls.Add(this.tableLayoutPanelBottomLeft, 0, 0);
            this.tableLayoutPanelMainBottom.Controls.Add(this.tableLayoutPanelBottomRight, 1, 0);
            this.tableLayoutPanelMainBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMainBottom.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanelMainBottom.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanelMainBottom.Name = "tableLayoutPanelMainBottom";
            this.tableLayoutPanelMainBottom.RowCount = 1;
            this.tableLayoutPanelMainBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMainBottom.Size = new System.Drawing.Size(168, 1);
            this.tableLayoutPanelMainBottom.TabIndex = 0;
            // 
            // tableLayoutPanelBottomLeft
            // 
            this.tableLayoutPanelBottomLeft.AutoSize = true;
            this.tableLayoutPanelBottomLeft.ColumnCount = 1;
            this.tableLayoutPanelBottomLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottomLeft.Controls.Add(this.tableLayoutPanelLabel, 0, 0);
            this.tableLayoutPanelBottomLeft.Controls.Add(this.groupBoxRecipients, 0, 1);
            this.tableLayoutPanelBottomLeft.Controls.Add(this.panelBrickImage, 0, 2);
            this.tableLayoutPanelBottomLeft.Controls.Add(this.tableLayoutPanelBottomLeftButtons, 0, 3);
            this.tableLayoutPanelBottomLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBottomLeft.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanelBottomLeft.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelBottomLeft.Name = "tableLayoutPanelBottomLeft";
            this.tableLayoutPanelBottomLeft.RowCount = 4;
            this.tableLayoutPanelBottomLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelBottomLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelBottomLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelBottomLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelBottomLeft.Size = new System.Drawing.Size(78, 1);
            this.tableLayoutPanelBottomLeft.TabIndex = 0;
            // 
            // tableLayoutPanelLabel
            // 
            this.tableLayoutPanelLabel.AutoSize = true;
            this.tableLayoutPanelLabel.ColumnCount = 2;
            this.tableLayoutPanelLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLabel.Controls.Add(this.labelDonor, 0, 0);
            this.tableLayoutPanelLabel.Controls.Add(this.labelDonorName, 1, 0);
            this.tableLayoutPanelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLabel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanelLabel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelLabel.Name = "tableLayoutPanelLabel";
            this.tableLayoutPanelLabel.RowCount = 1;
            this.tableLayoutPanelLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLabel.Size = new System.Drawing.Size(72, 24);
            this.tableLayoutPanelLabel.TabIndex = 0;
            // 
            // labelDonor
            // 
            this.labelDonor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDonor.AutoSize = true;
            this.labelDonor.Location = new System.Drawing.Point(3, 5);
            this.labelDonor.Name = "labelDonor";
            this.labelDonor.Size = new System.Drawing.Size(39, 13);
            this.labelDonor.TabIndex = 0;
            this.labelDonor.Text = "Donor:";
            this.labelDonor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDonorName
            // 
            this.labelDonorName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDonorName.AutoSize = true;
            this.labelDonorName.Location = new System.Drawing.Point(53, 0);
            this.labelDonorName.Name = "labelDonorName";
            this.labelDonorName.Size = new System.Drawing.Size(16, 24);
            this.labelDonorName.TabIndex = 0;
            this.labelDonorName.Text = "<Donor Name>";
            this.labelDonorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxRecipients
            // 
            this.groupBoxRecipients.Controls.Add(this.listBoxRecipients);
            this.groupBoxRecipients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRecipients.Location = new System.Drawing.Point(3, 33);
            this.groupBoxRecipients.Name = "groupBoxRecipients";
            this.groupBoxRecipients.Size = new System.Drawing.Size(72, 1);
            this.groupBoxRecipients.TabIndex = 0;
            this.groupBoxRecipients.TabStop = false;
            this.groupBoxRecipients.Text = "Recipients:";
            // 
            // listBoxRecipients
            // 
            this.listBoxRecipients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRecipients.FormattingEnabled = true;
            this.listBoxRecipients.Location = new System.Drawing.Point(3, 16);
            this.listBoxRecipients.Name = "listBoxRecipients";
            this.listBoxRecipients.Size = new System.Drawing.Size(66, 0);
            this.listBoxRecipients.TabIndex = 0;
            this.listBoxRecipients.SelectedIndexChanged += new System.EventHandler(this.listBoxRecipients_SelectedIndexChanged);
            // 
            // panelBrickImage
            // 
            this.panelBrickImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBrickImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBrickImage.Location = new System.Drawing.Point(3, 16);
            this.panelBrickImage.Name = "panelBrickImage";
            this.panelBrickImage.Size = new System.Drawing.Size(72, 1);
            this.panelBrickImage.TabIndex = 0;
            // 
            // tableLayoutPanelBottomLeftButtons
            // 
            this.tableLayoutPanelBottomLeftButtons.AutoSize = true;
            this.tableLayoutPanelBottomLeftButtons.ColumnCount = 2;
            this.tableLayoutPanelBottomLeftButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottomLeftButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottomLeftButtons.Controls.Add(this.radioButtonBrick, 0, 0);
            this.tableLayoutPanelBottomLeftButtons.Controls.Add(this.radioButtonSection, 1, 0);
            this.tableLayoutPanelBottomLeftButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBottomLeftButtons.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanelBottomLeftButtons.Location = new System.Drawing.Point(3, -25);
            this.tableLayoutPanelBottomLeftButtons.Name = "tableLayoutPanelBottomLeftButtons";
            this.tableLayoutPanelBottomLeftButtons.RowCount = 1;
            this.tableLayoutPanelBottomLeftButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottomLeftButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottomLeftButtons.Size = new System.Drawing.Size(72, 24);
            this.tableLayoutPanelBottomLeftButtons.TabIndex = 0;
            // 
            // radioButtonBrick
            // 
            this.radioButtonBrick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonBrick.AutoSize = true;
            this.radioButtonBrick.Checked = true;
            this.radioButtonBrick.Location = new System.Drawing.Point(3, 3);
            this.radioButtonBrick.Name = "radioButtonBrick";
            this.radioButtonBrick.Size = new System.Drawing.Size(30, 17);
            this.radioButtonBrick.TabIndex = 0;
            this.radioButtonBrick.TabStop = true;
            this.radioButtonBrick.Text = "Show Brick";
            this.radioButtonBrick.UseVisualStyleBackColor = true;
            this.radioButtonBrick.CheckedChanged += new System.EventHandler(this.radioButtonBrick_CheckedChanged);
            // 
            // radioButtonSection
            // 
            this.radioButtonSection.AutoSize = true;
            this.radioButtonSection.Location = new System.Drawing.Point(39, 3);
            this.radioButtonSection.Name = "radioButtonSection";
            this.radioButtonSection.Size = new System.Drawing.Size(30, 17);
            this.radioButtonSection.TabIndex = 0;
            this.radioButtonSection.TabStop = true;
            this.radioButtonSection.Text = "Show Section";
            this.radioButtonSection.UseVisualStyleBackColor = true;
            this.radioButtonSection.CheckedChanged += new System.EventHandler(this.radioButtonSection_CheckedChanged);
            // 
            // tableLayoutPanelBottomRight
            // 
            this.tableLayoutPanelBottomRight.AutoSize = true;
            this.tableLayoutPanelBottomRight.ColumnCount = 1;
            this.tableLayoutPanelBottomRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottomRight.Controls.Add(this.tabControlInfo, 0, 0);
            this.tableLayoutPanelBottomRight.Controls.Add(this.buttonUpdate, 0, 1);
            this.tableLayoutPanelBottomRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBottomRight.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanelBottomRight.Location = new System.Drawing.Point(87, 3);
            this.tableLayoutPanelBottomRight.Name = "tableLayoutPanelBottomRight";
            this.tableLayoutPanelBottomRight.RowCount = 2;
            this.tableLayoutPanelBottomRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottomRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelBottomRight.Size = new System.Drawing.Size(78, 1);
            this.tableLayoutPanelBottomRight.TabIndex = 0;
            // 
            // tabControlInfo
            // 
            this.tabControlInfo.Controls.Add(this.tabPageDonor);
            this.tabControlInfo.Controls.Add(this.tabPageRecipient);
            this.tabControlInfo.Controls.Add(this.tabPage1);
            this.tabControlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlInfo.Location = new System.Drawing.Point(3, 3);
            this.tabControlInfo.Name = "tabControlInfo";
            this.tabControlInfo.SelectedIndex = 0;
            this.tabControlInfo.Size = new System.Drawing.Size(72, 1);
            this.tabControlInfo.TabIndex = 0;
            // 
            // tabPageDonor
            // 
            this.tabPageDonor.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageDonor.Controls.Add(this.personInfoPanelDonor);
            this.tabPageDonor.Location = new System.Drawing.Point(4, 22);
            this.tabPageDonor.Name = "tabPageDonor";
            this.tabPageDonor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDonor.Size = new System.Drawing.Size(64, 0);
            this.tabPageDonor.TabIndex = 0;
            this.tabPageDonor.Text = "Donor Information";
            // 
            // tabPageRecipient
            // 
            this.tabPageRecipient.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageRecipient.Controls.Add(this.personInfoPanelRecipient);
            this.tabPageRecipient.Location = new System.Drawing.Point(4, 22);
            this.tabPageRecipient.Name = "tabPageRecipient";
            this.tabPageRecipient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecipient.Size = new System.Drawing.Size(64, 0);
            this.tabPageRecipient.TabIndex = 1;
            this.tabPageRecipient.Text = "Recipient Information";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonUpdate.Location = new System.Drawing.Point(3, -31);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(72, 29);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(64, 0);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Transaction";
            this.tabPage1.Controls.Add(transactionPanel1);
            // 
            // personInfoPanelDonor
            // 
            this.personInfoPanelDonor.AutoSize = true;
            this.personInfoPanelDonor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personInfoPanelDonor.Location = new System.Drawing.Point(3, 3);
            this.personInfoPanelDonor.Name = "personInfoPanelDonor";
            this.personInfoPanelDonor.Size = new System.Drawing.Size(58, 0);
            this.personInfoPanelDonor.TabIndex = 0;
            // 
            // personInfoPanelRecipient
            // 
            this.personInfoPanelRecipient.AutoSize = true;
            this.personInfoPanelRecipient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personInfoPanelRecipient.Location = new System.Drawing.Point(3, 3);
            this.personInfoPanelRecipient.Name = "personInfoPanelRecipient";
            this.personInfoPanelRecipient.Size = new System.Drawing.Size(58, -6);
            this.personInfoPanelRecipient.TabIndex = 0;
            // 
            // ShowDonorPanel
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanelBorder);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBorder.ResumeLayout(false);
            this.tableLayoutPanelBorder.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.tableLayoutPanelImage.ResumeLayout(false);
            this.tableLayoutPanelMainBottom.ResumeLayout(false);
            this.tableLayoutPanelMainBottom.PerformLayout();
            this.tableLayoutPanelBottomLeft.ResumeLayout(false);
            this.tableLayoutPanelBottomLeft.PerformLayout();
            this.tableLayoutPanelLabel.ResumeLayout(false);
            this.tableLayoutPanelLabel.PerformLayout();
            this.groupBoxRecipients.ResumeLayout(false);
            this.tableLayoutPanelBottomLeftButtons.ResumeLayout(false);
            this.tableLayoutPanelBottomLeftButtons.PerformLayout();
            this.tableLayoutPanelBottomRight.ResumeLayout(false);
            this.tabControlInfo.ResumeLayout(false);
            this.tabPageDonor.ResumeLayout(false);
            this.tabPageDonor.PerformLayout();
            this.tabPageRecipient.ResumeLayout(false);
            this.tabPageRecipient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBorder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelImage;
        private System.Windows.Forms.Panel panelLogoImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMainBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottomLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottomRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLabel;
        private System.Windows.Forms.Label labelDonor;
        private System.Windows.Forms.Label labelDonorName;
        private System.Windows.Forms.GroupBox groupBoxRecipients;
        private System.Windows.Forms.ListBox listBoxRecipients;
        private System.Windows.Forms.Panel panelBrickImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottomLeftButtons;
        private System.Windows.Forms.RadioButton radioButtonBrick;
        private System.Windows.Forms.RadioButton radioButtonSection;
        private System.Windows.Forms.TabControl tabControlInfo;
        private System.Windows.Forms.TabPage tabPageDonor;
        private System.Windows.Forms.TabPage tabPageRecipient;
        private System.Windows.Forms.Button buttonUpdate;
        private PersonInfoPanel personInfoPanelDonor;
        private PersonInfoPanel personInfoPanelRecipient;
        private System.Windows.Forms.TabPage tabPage1;
        private TransactionPanel transactionPanel1;
    }
}
