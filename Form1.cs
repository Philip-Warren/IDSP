using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDSP7_pw
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();

            //var t = new FolderSupplierOrder.FormSuppOrder();
            //t.Show();

            //var t = new FolderSuppOrderRecieve.FormSuppOrderRec();
            //t.Show();

            var t = new FolderBackOrder.FormBackOrder();
            t.Show();
        }

        private void buttonFormRecieveStoreOrder_Click(object sender, EventArgs e)
        {
            var t = new FolderRecStrOrd.FormRecieveStoreOrder();
            t.Show();
        }

        private void buttonFormSuppOrder_Click(object sender, EventArgs e)
        {
            var t = new FolderSupplierOrder.FormSuppOrder();
            t.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var t = new FolderSuppOrderRecieve.FormSuppOrderRec();
            t.Show();
        }

        private void buttonFormBackOrder_Click(object sender, EventArgs e)
        {
            var t = new FolderBackOrder.FormBackOrder();
            t.Show();
        }
    }
}
