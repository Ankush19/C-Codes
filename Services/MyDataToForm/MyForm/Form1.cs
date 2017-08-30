using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDataToForm;

namespace MyForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtok_Click(object sender, EventArgs e)
        {
            using (var Myobj = new MyDataEntities())
            {
                var obj1 = new MyTable();

                var obj2 = Myobj.MyTables.Where(i => i.Id == 1);
                foreach (var item in obj2)
                {
                    txtId.Text = item.Id.ToString();
                    txtName.Text = item.Name;
                    txtAge.Text = item.Age.ToString();
                }
                Myobj.SaveChanges();

            }
        }
    }
}
