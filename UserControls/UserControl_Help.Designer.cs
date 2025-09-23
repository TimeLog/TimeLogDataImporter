namespace TimeLog.DataImporter.UserControls
{
    partial class UserControl_Help
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Glossary", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(" 1. Select the delimiter type used in the desired CSV file from the delimiter list.");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("  ");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(" 2. Press \"Select File\" to choose the desired CSV file to be imported. File of other extension types will not be accepted.");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("  ");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(" 3. Map each neccessary column of the file content to the columns in the data table below by choosing from the drop down list of each column.");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("  ");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(" 4. After mapping, press \"Validate\" to validate the mapped input data. The validation results will be shown in the center container.");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("  ");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(" 5. If there is error in the mapped input data, the invalid data input row count will not be zero.");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("  ");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(" 6. The user has to recheck and modify the input data by referring to the center validation results container and then repeat Step 4.");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("  ");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(" 7. If the validation passes without any error, the user can press the \"Import\" button to start the data import process.");
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Glossary", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(" Customer > Import customer data from CSV file");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("  ");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(" Project > Import project data from CSV file");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("  ");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem(" Delimiter > The separator used in the CSV file to separate each field");
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("  ");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem(" Select File > Select a CSV data source file ");
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("  ");
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem(" Reset All > Reset all the data in the input area and data table below");
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("  ");
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem(" Validate > Validate the input data mapped into the data table");
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem("  ");
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem(" Import > Import input data (will be disabled if validation is not done properly)");
            panel_helpPage = new System.Windows.Forms.Panel();
            listView_instruction = new System.Windows.Forms.ListView();
            label_instruction = new System.Windows.Forms.Label();
            label_glossary = new System.Windows.Forms.Label();
            listView_glossary = new System.Windows.Forms.ListView();
            label_helpPage = new System.Windows.Forms.Label();
            panel_helpPage.SuspendLayout();
            SuspendLayout();
            // 
            // panel_helpPage
            // 
            panel_helpPage.AutoScroll = true;
            panel_helpPage.Controls.Add(listView_instruction);
            panel_helpPage.Controls.Add(label_instruction);
            panel_helpPage.Controls.Add(label_glossary);
            panel_helpPage.Controls.Add(listView_glossary);
            panel_helpPage.Controls.Add(label_helpPage);
            panel_helpPage.Dock = System.Windows.Forms.DockStyle.Fill;
            panel_helpPage.Location = new System.Drawing.Point(0, 0);
            panel_helpPage.Name = "panel_helpPage";
            panel_helpPage.Size = new System.Drawing.Size(1006, 942);
            panel_helpPage.TabIndex = 13;
            // 
            // listView_instruction
            // 
            listView_instruction.AutoArrange = false;
            listView_instruction.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            listView_instruction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listView_instruction.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            listView_instruction.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            listView_instruction.FullRowSelect = true;
            listViewGroup1.Header = "Glossary";
            listViewGroup1.Name = "listViewGroup_glossary";
            listView_instruction.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] { listViewGroup1 });
            listViewItem2.IndentCount = 1;
            listViewItem3.IndentCount = 2;
            listViewItem4.IndentCount = 3;
            listViewItem5.IndentCount = 4;
            listViewItem6.IndentCount = 5;
            listViewItem7.IndentCount = 6;
            listViewItem8.IndentCount = 7;
            listViewItem9.IndentCount = 8;
            listViewItem10.IndentCount = 9;
            listViewItem11.IndentCount = 10;
            listViewItem12.IndentCount = 11;
            listViewItem13.IndentCount = 12;
            listView_instruction.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7, listViewItem8, listViewItem9, listViewItem10, listViewItem11, listViewItem12, listViewItem13 });
            listView_instruction.Location = new System.Drawing.Point(13, 475);
            listView_instruction.MultiSelect = false;
            listView_instruction.Name = "listView_instruction";
            listView_instruction.Size = new System.Drawing.Size(977, 302);
            listView_instruction.TabIndex = 1;
            listView_instruction.TileSize = new System.Drawing.Size(977, 40);
            listView_instruction.UseCompatibleStateImageBehavior = false;
            listView_instruction.View = System.Windows.Forms.View.List;
            // 
            // label_instruction
            // 
            label_instruction.AutoSize = true;
            label_instruction.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline);
            label_instruction.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label_instruction.Location = new System.Drawing.Point(9, 437);
            label_instruction.Name = "label_instruction";
            label_instruction.Size = new System.Drawing.Size(324, 25);
            label_instruction.TabIndex = 2;
            label_instruction.Text = "Instructions to Using Data Importer";
            // 
            // label_glossary
            // 
            label_glossary.AutoSize = true;
            label_glossary.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline);
            label_glossary.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label_glossary.Location = new System.Drawing.Point(9, 75);
            label_glossary.Name = "label_glossary";
            label_glossary.Size = new System.Drawing.Size(87, 25);
            label_glossary.TabIndex = 2;
            label_glossary.Text = "Glossary";
            // 
            // listView_glossary
            // 
            listView_glossary.AutoArrange = false;
            listView_glossary.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            listView_glossary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            listView_glossary.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            listView_glossary.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            listView_glossary.FullRowSelect = true;
            listViewGroup2.Header = "Glossary";
            listViewGroup2.Name = "listViewGroup_glossary";
            listView_glossary.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] { listViewGroup2 });
            listViewItem15.IndentCount = 1;
            listViewItem16.IndentCount = 2;
            listViewItem17.IndentCount = 3;
            listViewItem18.IndentCount = 4;
            listViewItem19.IndentCount = 5;
            listViewItem20.IndentCount = 6;
            listViewItem21.IndentCount = 7;
            listViewItem22.IndentCount = 8;
            listViewItem23.IndentCount = 9;
            listViewItem24.IndentCount = 10;
            listViewItem25.IndentCount = 11;
            listViewItem26.IndentCount = 12;
            listView_glossary.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem14, listViewItem15, listViewItem16, listViewItem17, listViewItem18, listViewItem19, listViewItem20, listViewItem21, listViewItem22, listViewItem23, listViewItem24, listViewItem25, listViewItem26 });
            listView_glossary.Location = new System.Drawing.Point(13, 113);
            listView_glossary.MultiSelect = false;
            listView_glossary.Name = "listView_glossary";
            listView_glossary.Size = new System.Drawing.Size(977, 292);
            listView_glossary.TabIndex = 1;
            listView_glossary.TileSize = new System.Drawing.Size(977, 40);
            listView_glossary.UseCompatibleStateImageBehavior = false;
            listView_glossary.View = System.Windows.Forms.View.List;
            // 
            // label_helpPage
            // 
            label_helpPage.AutoSize = true;
            label_helpPage.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            label_helpPage.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            label_helpPage.Location = new System.Drawing.Point(7, 16);
            label_helpPage.Name = "label_helpPage";
            label_helpPage.Size = new System.Drawing.Size(65, 32);
            label_helpPage.TabIndex = 0;
            label_helpPage.Text = "Help";
            // 
            // UserControl_Help
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel_helpPage);
            Name = "UserControl_Help";
            Size = new System.Drawing.Size(1006, 942);
            Load += UserControl1_Load;
            panel_helpPage.ResumeLayout(false);
            panel_helpPage.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_helpPage;
        private System.Windows.Forms.Label label_helpPage;
        private System.Windows.Forms.Label label_glossary;
        private System.Windows.Forms.ListView listView_glossary;
        private System.Windows.Forms.ListView listView_instruction;
        private System.Windows.Forms.Label label_instruction;
    }
}
