using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lab2_Delegate
{
    public partial class ManageSubscriptionForm : Form
    {
        public ManageSubscriptionForm()
        {
            InitializeComponent();
        }

        //private void note_email_checkBox_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        private void subscribeButtOnClick(object sender, EventArgs e)
        {
            if (this.noteEmailCheckBox.Checked)
            {
                String email_richTextBox = this.emailRichTextBox.Text;

                SendViaEmail newEmailSubscriber = new SendViaEmail(email_richTextBox);

                var listOfEmail = Subscription.emailSubscription.FindIndex(
                    f => f.EmailAddr == newEmailSubscriber.EmailAddr
                    );
                if (listOfEmail == 0)
                {
                    MessageBox.Show("Email already added.");

                }
                else
                {
                    Subscription.emailSubscription.Add(newEmailSubscriber);
                    newEmailSubscriber.Subscribe(Subscription.publisher);
                    MessageBox.Show("Email added.");

                    noteEmailCheckBox.Checked = false;
                    emailRichTextBox.Text = "";
                }


            }

            if (noteSmsCheckBox.Checked)
            {
                SendViaMobile newMobileSubscriber = new SendViaMobile(phoneRichTextBox.Text);
                var listOfMobile = Subscription.mobilelSubscription.FindIndex(
                    f => f.CellPhone == newMobileSubscriber.CellPhone
                    );
                if (listOfMobile == 0)
                {
                    MessageBox.Show("Mobile already added.");

                }
                else
                {
                    Subscription.mobilelSubscription.Add(newMobileSubscriber);
                    newMobileSubscriber.Subscribe(Subscription.publisher);
                    MessageBox.Show("Mobile added.");

                    noteSmsCheckBox.Checked = false;
                    phoneRichTextBox.Text = "";
                }


            }

        }

        private void email_richTextBox_TextChanged(object sender, EventArgs e)
        {

            var validEmail = true;

            try
            {
               var emailAddress = new MailAddress(this.emailRichTextBox.Text);
            }
            catch
            {
                validEmail = false;
            }


            if (!validEmail && this.noteEmailCheckBox.Checked)
            {
                emailAlertMessage.Text = "Invalid email address";
            }
            else
            {
                emailAlertMessage.Text = "";
            }

            if (!emailAlertMessage.Text.Equals(""))
            {
                this.subscribe_button.Enabled = false;
                this.unsubscribeButton.Enabled = false;
            }
            else
            {
                this.subscribe_button.Enabled = true;
                this.unsubscribeButton.Enabled = true;
            }

        }

        private void cancelButtonClick(object sender, EventArgs e)
        {
            NotificationManagementForm notificationManager = new NotificationManagementForm();
            notificationManager.Show();
            this.Hide();
        }

        private void unsubscribeButtonClick(object sender, EventArgs e)
        {
            if (noteEmailCheckBox.Checked)
            {
                String email_richTextBox = this.emailRichTextBox.Text;

                SendViaEmail newEmailSubscriber = new SendViaEmail(email_richTextBox);

                var listOfEmail = Subscription.emailSubscription.FindIndex(
                    f => f.EmailAddr == newEmailSubscriber.EmailAddr
                    );


                if (listOfEmail != 0)
                {
                    MessageBox.Show("Email not found.");
                    noteEmailCheckBox.Checked = false;
                    emailRichTextBox.Text = "";
                }
                else
                {
                    for (int i = 0; i < Subscription.emailSubscription.Count; i++)
                    {
                        if (Subscription.emailSubscription[i].EmailAddr == newEmailSubscriber.EmailAddr)
                        {
                            Subscription.emailSubscription[i].UnSubscribe(Subscription.publisher);
                            Subscription.emailSubscription.RemoveAt(i);
                            MessageBox.Show("Email removed.");
                            break;
                        }
                    }
                    noteEmailCheckBox.Checked = false;
                    emailRichTextBox.Text = "";
                }
            }

            if (noteSmsCheckBox.Checked)
            {
                SendViaMobile newMobileSubscriber = new SendViaMobile(phoneRichTextBox.Text);
                var listOfMobile = Subscription.mobilelSubscription.FindIndex(
                    f => f.CellPhone == newMobileSubscriber.CellPhone
                    );


                if (listOfMobile == -1)
                {
                    MessageBox.Show("Mobile not found.");
                    noteSmsCheckBox.Checked = false;
                    phoneRichTextBox.Text = "";

                }
                else
                {
                    for (int i = 0; i < Subscription.mobilelSubscription.Count; i++)
                    {
                        if (Subscription.mobilelSubscription[i].CellPhone == newMobileSubscriber.CellPhone)
                        {
                            Subscription.mobilelSubscription[i].UnSubscribe(Subscription.publisher);
                            Subscription.mobilelSubscription.RemoveAt(i);
                            MessageBox.Show("Mobile removed.");
                            break;
                        }
                    }
                    noteSmsCheckBox.Checked = false;
                    phoneRichTextBox.Text = "";
                }
            }
        }

        private void emailAlertMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
