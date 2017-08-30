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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
           }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
           }

        private void txtSubmit_Click(object sender, EventArgs e)
        {
            int age = int.Parse(txtAge.Text);
            string name = txtName.Text;

            using (var user = new ContextUser())
            {
                
                var userobj = new User { Name=name,Age=age };
                user.Users.Add(userobj);
                user.SaveChanges();
                //Console.WriteLine("record add");

            }
            // Console.ReadLine();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update obj = new Update();
            obj.ShowDialog();

        }
    }
}
