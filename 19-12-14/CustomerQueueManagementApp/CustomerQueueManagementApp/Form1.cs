using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerQueueManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int i = 0;
        private Queue<Customer> customers = new Queue<Customer>();
        ListViewItem lvi = new ListViewItem();
        private void EnqueueButton_Click(object sender, EventArgs e)
        {
            i++;
            Customer aCustomer = new Customer();
            aCustomer.customerId = i;
            aCustomer.customerName = addCustomerNameTextBox.Text;
            aCustomer.customerComplaign = addComplaignTextBox.Text;
            customers.Enqueue(aCustomer);
            listView1.Items.Clear();
            
            foreach (Customer customer in customers)
            {
                string[] ssStrings = new string[3];
                ssStrings[0] = customer.customerId.ToString();
                ssStrings[1] = customer.customerName;
                ssStrings[2] = customer.customerComplaign;
                
                lvi = new ListViewItem(ssStrings);
                listView1.Items.Add(lvi);
            }
            MessageBox.Show(aCustomer.customerName+"'s serial number is "+i);

        }

        private void DequeueButton_Click(object sender, EventArgs e)
        {
            Customer aCustomers = new Customer();
            int count = customers.Count;
            if (count > 0)
            {
                aCustomers = customers.Dequeue();

                serialTextBox.Text = aCustomers.customerId.ToString();
                dequeueCustomerNameTextBox.Text = aCustomers.customerName;
                dequeueComplaignTextBox.Text = aCustomers.customerComplaign;
                listView1.Items.Clear();
                foreach (Customer customer in customers)
                {
                    string[] ssStrings = new string[3];
                    ssStrings[0] = customer.customerId.ToString();
                    ssStrings[1] = customer.customerName;
                    ssStrings[2] = customer.customerComplaign;

                    lvi = new ListViewItem(ssStrings);
                    listView1.Items.Add(lvi);
                }
            }
            else
            {
                MessageBox.Show("No Customer pending");
            }
        }
    }
}
