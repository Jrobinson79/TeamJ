namespace TeamJ
{
    partial class TestForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.showItemTypesButton = new System.Windows.Forms.Button();
            this.showAllSectionsButton = new System.Windows.Forms.Button();
            this.singleBrickSaleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showItemTypesButton
            // 
            this.showItemTypesButton.Location = new System.Drawing.Point(12, 12);
            this.showItemTypesButton.Name = "showItemTypesButton";
            this.showItemTypesButton.Size = new System.Drawing.Size(161, 23);
            this.showItemTypesButton.TabIndex = 0;
            this.showItemTypesButton.Text = "(Test) Show Item Types";
            this.showItemTypesButton.UseVisualStyleBackColor = true;
            this.showItemTypesButton.Click += new System.EventHandler(this.showItemTypesButton_Clicked);
            // 
            // showAllSectionsButton
            // 
            this.showAllSectionsButton.Location = new System.Drawing.Point(12, 41);
            this.showAllSectionsButton.Name = "showAllSectionsButton";
            this.showAllSectionsButton.Size = new System.Drawing.Size(161, 23);
            this.showAllSectionsButton.TabIndex = 1;
            this.showAllSectionsButton.Text = "(Test) Show All Sections";
            this.showAllSectionsButton.UseVisualStyleBackColor = true;
            this.showAllSectionsButton.Click += new System.EventHandler(this.showAllSectionsButton_Click);
            // 
            // singleBrickSaleButton
            // 
            this.singleBrickSaleButton.Location = new System.Drawing.Point(12, 70);
            this.singleBrickSaleButton.Name = "singleBrickSaleButton";
            this.singleBrickSaleButton.Size = new System.Drawing.Size(161, 23);
            this.singleBrickSaleButton.TabIndex = 2;
            this.singleBrickSaleButton.Text = "(Test) Single Brick Sale";
            this.singleBrickSaleButton.UseVisualStyleBackColor = true;
            this.singleBrickSaleButton.Click += new System.EventHandler(this.singleBrickSaleButton_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 378);
            this.Controls.Add(this.singleBrickSaleButton);
            this.Controls.Add(this.showAllSectionsButton);
            this.Controls.Add(this.showItemTypesButton);
            this.Name = "TestForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showItemTypesButton;
        private System.Windows.Forms.Button showAllSectionsButton;
        private System.Windows.Forms.Button singleBrickSaleButton;
    }
}

