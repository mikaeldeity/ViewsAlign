namespace ViewsAlign.Dialogs
{
    partial class AlignDialog
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
            this.ViewsListBox = new System.Windows.Forms.ListBox();
            this.MasterViewDropDown = new System.Windows.Forms.ComboBox();
            this.AlignmentPointDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.Table_Main = new System.Windows.Forms.TableLayoutPanel();
            this.Table_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.Table_Main.SuspendLayout();
            this.Table_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewsListBox
            // 
            this.ViewsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewsListBox.FormattingEnabled = true;
            this.ViewsListBox.HorizontalScrollbar = true;
            this.ViewsListBox.Location = new System.Drawing.Point(3, 104);
            this.ViewsListBox.Name = "ViewsListBox";
            this.ViewsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ViewsListBox.Size = new System.Drawing.Size(328, 191);
            this.ViewsListBox.Sorted = true;
            this.ViewsListBox.TabIndex = 0;
            this.ViewsListBox.TabStop = false;
            // 
            // MasterViewDropDown
            // 
            this.MasterViewDropDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MasterViewDropDown.FormattingEnabled = true;
            this.MasterViewDropDown.Location = new System.Drawing.Point(3, 42);
            this.MasterViewDropDown.Name = "MasterViewDropDown";
            this.MasterViewDropDown.Size = new System.Drawing.Size(328, 21);
            this.MasterViewDropDown.TabIndex = 1;
            this.MasterViewDropDown.TabStop = false;
            // 
            // AlignmentPointDropDown
            // 
            this.AlignmentPointDropDown.AutoCompleteCustomSource.AddRange(new string[] {
            "Center",
            "Top Left",
            "Top Right",
            "Bottom Left",
            "Bottom Right"});
            this.AlignmentPointDropDown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.AlignmentPointDropDown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AlignmentPointDropDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlignmentPointDropDown.FormattingEnabled = true;
            this.AlignmentPointDropDown.Items.AddRange(new object[] {
            "Center",
            "Top Left",
            "Top Right",
            "Bottom Left",
            "Bottom Right"});
            this.AlignmentPointDropDown.Location = new System.Drawing.Point(3, 329);
            this.AlignmentPointDropDown.MaxDropDownItems = 5;
            this.AlignmentPointDropDown.Name = "AlignmentPointDropDown";
            this.AlignmentPointDropDown.Size = new System.Drawing.Size(328, 21);
            this.AlignmentPointDropDown.TabIndex = 2;
            this.AlignmentPointDropDown.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "View to align to:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Views to align:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 308);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alignment point:";
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OKButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OKButton.FlatAppearance.BorderSize = 0;
            this.OKButton.Location = new System.Drawing.Point(181, 3);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(144, 28);
            this.OKButton.TabIndex = 6;
            this.OKButton.TabStop = false;
            this.OKButton.Text = "Align Views";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // Table_Main
            // 
            this.Table_Main.ColumnCount = 1;
            this.Table_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table_Main.Controls.Add(this.Table_Buttons, 0, 6);
            this.Table_Main.Controls.Add(this.label1, 0, 0);
            this.Table_Main.Controls.Add(this.AlignmentPointDropDown, 0, 5);
            this.Table_Main.Controls.Add(this.label3, 0, 4);
            this.Table_Main.Controls.Add(this.MasterViewDropDown, 0, 1);
            this.Table_Main.Controls.Add(this.label2, 0, 2);
            this.Table_Main.Controls.Add(this.ViewsListBox, 0, 3);
            this.Table_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table_Main.Location = new System.Drawing.Point(0, 0);
            this.Table_Main.Name = "Table_Main";
            this.Table_Main.RowCount = 7;
            this.Table_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.Table_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.Table_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.Table_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.Table_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.Table_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Table_Main.Size = new System.Drawing.Size(334, 411);
            this.Table_Main.TabIndex = 7;
            // 
            // Table_Buttons
            // 
            this.Table_Buttons.ColumnCount = 2;
            this.Table_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.Table_Buttons.Controls.Add(this.OKButton, 1, 0);
            this.Table_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table_Buttons.Location = new System.Drawing.Point(3, 374);
            this.Table_Buttons.Name = "Table_Buttons";
            this.Table_Buttons.RowCount = 1;
            this.Table_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table_Buttons.Size = new System.Drawing.Size(328, 34);
            this.Table_Buttons.TabIndex = 0;
            // 
            // AlignDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.Table_Main);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 450);
            this.Name = "AlignDialog";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Allign Views";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.AlignDialog_HelpButtonClicked);
            this.Table_Main.ResumeLayout(false);
            this.Table_Main.PerformLayout();
            this.Table_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OKButton;
        public System.Windows.Forms.ListBox ViewsListBox;
        public System.Windows.Forms.ComboBox MasterViewDropDown;
        public System.Windows.Forms.ComboBox AlignmentPointDropDown;
        private System.Windows.Forms.TableLayoutPanel Table_Main;
        private System.Windows.Forms.TableLayoutPanel Table_Buttons;
    }
}