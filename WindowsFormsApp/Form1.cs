using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private ServiceReference1.Service1Client client;

        public Form1()
        {
            InitializeComponent();
            client = new ServiceReference1.Service1Client();
        }


        private void buttonTransferMachine_Click(object sender, EventArgs e)
        {
            double amount = client.TransferAmountFromMachine(int.Parse(fieldUID.Text),double.Parse(fieldAmountLeft.Text));
            labelConfirmation1.Text = "Le compte a été crédité de CHF " + amount.ToString();
        }

        private void buttonTransferOnline_Click(object sender, EventArgs e)
        {
            double amount = client.TransferAmountFromOnline((fieldUsername1.Text), double.Parse(fieldAmountRight.Text));
            labelConfirmation2.Text = "Le compte a été crédité de CHF " + amount.ToString() + " via Online";
        }

        private void buttonTransferFaculties_Click(object sender, EventArgs e)
        {
            double amount = client.TransferAmountFromFaculties((fieldUsername1.Text), double.Parse(fieldAmountRight.Text));
            labelConfirmation2.Text = "Le compte a été crédité de CHF " + amount.ToString() + " via Faculties";
        }

        private void buttonGetNbCopies_Click(object sender, EventArgs e)
        {
            int nbCopies = client.GetNbOfCopies((fieldUsername2.Text));
            labelResult.Text = "Le crédit disponible permet de faire " + nbCopies.ToString() + " copies.";
        }

        private void buttonShowTransactions_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            var transactions = client.GetTransactions(int.Parse(fieldUID2.Text));

            foreach (var transaction in transactions)
            {
                listView1.Items.Add(new ListViewItem(new string[] { 
                    transaction.montant.ToString(),
                    transaction.type.ToString(),
                    transaction.date.ToString(),
                }));
            }
        }

 
    }
}
