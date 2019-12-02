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
            this.SuspendLayout();
            // 
            // ViewsListBox
            // 
            this.ViewsListBox.FormattingEnabled = true;
            this.ViewsListBox.HorizontalScrollbar = true;
            this.ViewsListBox.Location = new System.Drawing.Point(12, 98);
            this.ViewsListBox.Name = "ViewsListBox";
            this.ViewsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ViewsListBox.Size = new System.Drawing.Size(312, 238);
            this.ViewsListBox.Sorted = true;
            this.ViewsListBox.TabIndex = 0;
            this.ViewsListBox.TabStop = false;
            // 
            // MasterViewDropDown
            // 
            this.MasterViewDropDown.FormattingEnabled = true;
            this.MasterViewDropDown.Location = new System.Drawing.Point(12, 40);
            this.MasterViewDropDown.Name = "MasterViewDropDown";
            this.MasterViewDropDown.Size = new System.Drawing.Size(312, 21);
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
            this.AlignmentPointDropDown.FormattingEnabled = true;
            this.AlignmentPointDropDown.Items.AddRange(new object[] {
            "Center",
            "Top Left",
            "Top Right",
            "Bottom Left",
            "Bottom Right"});
            this.AlignmentPointDropDown.Location = new System.Drawing.Point(12, 369);
            this.AlignmentPointDropDown.MaxDropDownItems = 5;
            this.AlignmentPointDropDown.Name = "AlignmentPointDropDown";
            this.AlignmentPointDropDown.Size = new System.Drawing.Size(312, 21);
            this.AlignmentPointDropDown.TabIndex = 2;
            this.AlignmentPointDropDown.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "View to align to:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Views to align:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alignment point:";
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OKButton.FlatAppearance.BorderSize = 0;
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButton.Location = new System.Drawing.Point(12, 408);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(312, 37);
            this.OKButton.TabIndex = 6;
            this.OKButton.TabStop = false;
            this.OKButton.Text = "ALIGN";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // AlignDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(336, 457);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AlignmentPointDropDown);
            this.Controls.Add(this.MasterViewDropDown);
            this.Controls.Add(this.ViewsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlignDialog";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Allign Views";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OKButton;
        public System.Windows.Forms.ListBox ViewsListBox;
        public System.Windows.Forms.ComboBox MasterViewDropDown;
        public System.Windows.Forms.ComboBox AlignmentPointDropDown;
    }
}