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
    public partial class PublishNotForm : Form
    {
        public PublishNotForm()
        {
            InitializeComponent();
        }

        private void publishButton_Click(object sender, EventArgs e)
        {
            Subscription.publisher.PublishMessage(this.messageToPublish.Text);
            MessageBox.Show("Notification sent.");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            NotificationManagementForm notificationManager = new NotificationManagementForm();
            notificationManager.Show();
            this.Hide();
        }

        private void PublishNotForm_Load(object sender, EventArgs e)
        {

        }

        private void messageToPublish_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
