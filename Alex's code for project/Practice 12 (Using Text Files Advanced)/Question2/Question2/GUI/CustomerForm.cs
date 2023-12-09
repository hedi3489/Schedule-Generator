using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Question2.BLL;
using Question2.Validation;
using System.IO;
using Question2.DAL;

namespace Question2.GUI
{
    public partial class CustomerForm : Form
    {
        List<Customer> listC = new List<Customer>();
        public CustomerForm()
        {
            InitializeComponent();
            buttonListCustomers.Enabled = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure to exit the application?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
           // buttonListCustomers.
                //buttonListCustomers.Enabled = false;
        }

        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            Customer aCustomer = new Customer();
                  if ((Validator.IsValidID(textBoxCustomerId)) && (Validator.IsValidName(textBoxFirstName)) && (Validator.IsValidName(textBoxLastName)) && Validator.IsUniqueID(listC, Convert.ToInt32(textBoxCustomerId.Text)))
            {
                aCustomer.CustomerId = Convert.ToInt32(textBoxCustomerId.Text);
                aCustomer.FirstName = textBoxFirstName.Text;
                aCustomer.LastName = textBoxLastName.Text;
                aCustomer.PhoneNumber = maskedTextBoxPhoneNumber.Text;
                //Add to the list
                listC.Add(aCustomer);
          //  MessageBox.Show("Customer Info has been added to the list.","Confirmation");
            buttonListCustomers.Enabled = true;
            ClearAll();
              
            }
                        
            
        }
        
        private void buttonListCustomers_Click(object sender, EventArgs e)
        {
            //listViewCustomer.Items.Clear();
            //foreach (Customer cus in listC)
            //{
            //    ListViewItem item = new ListViewItem(cus.CustomerId.ToString());
            //    item.SubItems.Add(cus.FirstName);
            //    item.SubItems.Add(cus.LastName);
            //    item.SubItems.Add(cus.PhoneNumber);
            //    listViewCustomer.Items.Add(item);
            //}

            //string filePath = Application.StartupPath + @"\Customers.dat";
            //StreamReader sReader = new StreamReader(filePath);
            //string line = sReader.ReadLine();
            //listViewCustomer.Items.Clear();
            //while (line != null)
            //{
            //    string[] fields = line.Split(',');
            //    ListViewItem item = new ListViewItem(fields[0]);
            //    item.SubItems.Add(fields[1]);
            //    item.SubItems.Add(fields[2]);
            //    item.SubItems.Add(fields[3]);
            //    listViewCustomer.Items.Add(item);
            //    line = sReader.ReadLine();
            //}
            //sReader.Close();
            listViewCustomer.Items.Clear();
            CustomerDA.ListCustomers(listViewCustomer);
           // List<Customer> listC = new List<Customer>();
            //listC = CustomerDA.ListCustomers();
            //foreach (Customer c in listC)
            //{
            //    MessageBox.Show(c.CustomerId + "  " + c.FirstName);
            //}
        }

        private void ClearAll()
        {
            textBoxCustomerId.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            maskedTextBoxPhoneNumber.Clear();
            textBoxCustomerId.Focus();
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if ((Validator.IsValidID(textBoxCustomerId)) && (Validator.IsValidName(textBoxFirstName)) && (Validator.IsValidName(textBoxLastName)) && Validator.IsUniqueID(listC, Convert.ToInt32(textBoxCustomerId.Text)))
            {
                Customer aCustomer = new Customer();
                //string FilePath = Application.StartupPath + @"\Customers.dat";
                //StreamWriter sWriter = new StreamWriter(FilePath,true);

                aCustomer.CustomerId = Convert.ToInt32(textBoxCustomerId.Text);
                aCustomer.FirstName = textBoxFirstName.Text;
                aCustomer.LastName = textBoxLastName.Text;
                aCustomer.PhoneNumber = maskedTextBoxPhoneNumber.Text;
                CustomerDA.Save(aCustomer);
                //sWriter.Write(aCustomer.CustomerId + "," + aCustomer.FirstName + ","+ aCustomer.LastName + ","+ aCustomer.PhoneNumber);
                //sWriter.Close();
                //MessageBox.Show("Customer Info has been Saved", "Confirmation");
                //buttonListCustomers.Enabled = true;
                ClearAll();

            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int choice = comboBoxChoice.SelectedIndex;
            switch (choice)
            {
                case -1: // The user didn't select any search option
                    MessageBox.Show("Please select the search option");
                    break;
                case 0: //The user selected the search by Customer ID
                    Customer cust = CustomerDA.Search(Convert.ToInt32(textBoxInput.Text));
                    if (cust != null)
                    {
                        textBoxCustomerId.Text = (cust.CustomerId).ToString();
                        textBoxFirstName.Text = cust.FirstName;
                        textBoxLastName.Text = cust.LastName;
                        maskedTextBoxPhoneNumber.Text = cust.PhoneNumber;

                    }

                    else
                    {
                        MessageBox.Show("Customer not Found!");
                        textBoxInput.Clear();
                        textBoxInput.Focus();
                    }
                    break;
                default:
                    break;
            }

        }

        private void comboBoxChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choice = comboBoxChoice.SelectedIndex;
            switch (choice)
            {
                case 0:
                    labelInfo.Text = "Please enter the Customer ID";
                    textBoxInput.Focus();
                    break;
                case 1:
                    labelInfo.Text = "Please enter the First Name";
                    textBoxInput.Focus();
                    break;
                case 2:
                    labelInfo.Text = "Please enter the Last Name";
                    textBoxInput.Focus();
                    break;
                default:
                    break;
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CustomerDA.Delete(Convert.ToInt32(textBoxCustomerId.Text));
            MessageBox.Show("Customer record has been deleted successfully","Confirmation");

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
