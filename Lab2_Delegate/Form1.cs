using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Delegate
{
    public partial class NotificationManagementForm : Form
    {
        public NotificationManagementForm()
        {
            InitializeComponent();
            if(Subscription.mobilelSubscription.Count > 0 || Subscription.emailSubscription.Count >0)
            {
                this.publishNotButton.Enabled = true;
            } else
            {
                this.publishNotButton.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageSubscriptionForm manageSubscriptionForm = new ManageSubscriptionForm();
            manageSubscriptionForm.Show();
            this.Hide();
        }

        private void PublishNotButtonClick(object sender, EventArgs e)
        {
            PublishNotForm publishNotForm = new PublishNotForm();
            publishNotForm.Show();
            this.Hide();
        }

        private void exitButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
