namespace Lab2_Delegate
{
    partial class ManageSubscriptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.subscribe_button = new System.Windows.Forms.Button();
            this.unsubscribeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.noteEmailCheckBox = new System.Windows.Forms.CheckBox();
            this.emailRichTextBox = new System.Windows.Forms.RichTextBox();
            this.noteSmsCheckBox = new System.Windows.Forms.CheckBox();
            this.phoneRichTextBox = new System.Windows.Forms.RichTextBox();
            this.emailAlertMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // subscribe_button
            // 
            this.subscribe_button.Location = new System.Drawing.Point(45, 320);
            this.subscribe_button.Name = "subscribe_button";
            this.subscribe_button.Size = new System.Drawing.Size(235, 89);
            this.subscribe_button.TabIndex = 0;
            this.subscribe_button.Text = "Subscribe";
            this.subscribe_button.UseVisualStyleBackColor = true;
            this.subscribe_button.Click += new System.EventHandler(this.subscribeButtOnClick);
            // 
            // unsubscribeButton
            // 
            this.unsubscribeButton.Location = new System.Drawing.Point(313, 318);
            this.unsubscribeButton.Name = "unsubscribeButton";
            this.unsubscribeButton.Size = new System.Drawing.Size(219, 90);
            this.unsubscribeButton.TabIndex = 1;
            this.unsubscribeButton.Text = "Unsubscribe";
            this.unsubscribeButton.UseVisualStyleBackColor = true;
            this.unsubscribeButton.Click += new System.EventHandler(this.unsubscribeButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(557, 318);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(198, 89);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButtonClick);
            // 
            // noteEmailCheckBox
            // 
            this.noteEmailCheckBox.AutoSize = true;
            this.noteEmailCheckBox.Location = new System.Drawing.Point(95, 76);
            this.noteEmailCheckBox.Name = "noteEmailCheckBox";
            this.noteEmailCheckBox.Size = new System.Drawing.Size(180, 20);
            this.noteEmailCheckBox.TabIndex = 3;
            this.noteEmailCheckBox.Text = "Notification Sent by Email";
            this.noteEmailCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailRichTextBox
            // 
            this.emailRichTextBox.Location = new System.Drawing.Point(296, 65);
            this.emailRichTextBox.Name = "emailRichTextBox";
            this.emailRichTextBox.Size = new System.Drawing.Size(418, 31);
            this.emailRichTextBox.TabIndex = 5;
            this.emailRichTextBox.Text = "";
            this.emailRichTextBox.TextChanged += new System.EventHandler(this.email_richTextBox_TextChanged);
            // 
            // noteSmsCheckBox
            // 
            this.noteSmsCheckBox.AutoSize = true;
            this.noteSmsCheckBox.Location = new System.Drawing.Point(95, 179);
            this.noteSmsCheckBox.Name = "noteSmsCheckBox";
            this.noteSmsCheckBox.Size = new System.Drawing.Size(173, 20);
            this.noteSmsCheckBox.TabIndex = 6;
            this.noteSmsCheckBox.Text = "Notification sent by SMS";
            this.noteSmsCheckBox.UseVisualStyleBackColor = true;
            // 
            // phoneRichTextBox
            // 
            this.phoneRichTextBox.Location = new System.Drawing.Point(296, 177);
            this.phoneRichTextBox.Name = "phoneRichTextBox";
            this.phoneRichTextBox.Size = new System.Drawing.Size(418, 31);
            this.phoneRichTextBox.TabIndex = 7;
            this.phoneRichTextBox.Text = "";
            // 
            // emailAlertMessage
            // 
            this.emailAlertMessage.Location = new System.Drawing.Point(297, 117);
            this.emailAlertMessage.Name = "emailAlertMessage";
            this.emailAlertMessage.ReadOnly = true;
            this.emailAlertMessage.Size = new System.Drawing.Size(417, 22);
            this.emailAlertMessage.TabIndex = 8;
            this.emailAlertMessage.TextChanged += new System.EventHandler(this.emailAlertMessage_TextChanged);
            // 
            // ManageSubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.emailAlertMessage);
            this.Controls.Add(this.phoneRichTextBox);
            this.Controls.Add(this.noteSmsCheckBox);
            this.Controls.Add(this.emailRichTextBox);
            this.Controls.Add(this.noteEmailCheckBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.unsubscribeButton);
            this.Controls.Add(this.subscribe_button);
            this.Name = "ManageSubscriptionForm";
            this.Text = "Manage Subscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button subscribe_button;
        private System.Windows.Forms.Button unsubscribeButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox noteEmailCheckBox;
        private System.Windows.Forms.RichTextBox emailRichTextBox;
        private System.Windows.Forms.CheckBox noteSmsCheckBox;
        private System.Windows.Forms.RichTextBox phoneRichTextBox;
        private System.Windows.Forms.TextBox emailAlertMessage;
    }
}