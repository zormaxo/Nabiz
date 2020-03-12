﻿using BigSoft.Framework.Util;
using Nabiz.Business;
using System;
using System.Windows.Forms;

namespace Nabiz.UI
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OUserSave save = new OUserSave(Guid.NewGuid().ToString());
            var result = save.Execute();
            BsMessageBox.Show(result);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            OUserGet get = new OUserGet();
            var result = get.Execute();
            dgvUser.BsDataSourceList(result.Value);

            //advancedDataGridView1.DataSource = result.Value;
            bsAdvDataGridView1.DataSource = result.Value;
        }
    }
}