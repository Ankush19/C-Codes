using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Userinfo;

namespace UserForm
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNametoUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string oldname = txtNametoUpdate.Text;

            int newname = int.Parse(txtNewName.Text);

            ContextUser cu = new ContextUser();
            var users=cu.Users.Where(i => i.Name.Equals(oldname));
            foreach (var item in users)
            {
                item.Age = newname;
            }
            cu.SaveChanges();
        }
    }
}
