﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewsAlign.Dialogs
{
    public partial class AlignDialog : Form
    {
        public AlignDialog()
        {
            InitializeComponent();

            AlignmentPointDropDown.SelectedItem = AlignmentPointDropDown.Items[0].ToString();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AlignDialog_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Developed by Mikael Santrolli\n\nmikael.santrolli@gmail.com", "Views Align");
        }
    }
}
