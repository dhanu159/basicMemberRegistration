using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace basicMemberRegistration
{
    public partial class addMembers : Form
    {
        public addMembers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            allMembers newAllMember = new allMembers();
            newAllMember.Visible = true;
        }

    }
}
