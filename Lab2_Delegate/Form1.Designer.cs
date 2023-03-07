namespace Lab2_Delegate
{
    partial class NotificationManagementForm
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
            this.mana_sub_button = new System.Windows.Forms.Button();
            this.publishNotButton = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mana_sub_button
            // 
            this.mana_sub_button.Location = new System.Drawing.Point(38, 75);
            this.mana_sub_button.Name = "mana_sub_button";
            this.mana_sub_button.Size = new System.Drawing.Size(214, 103);
            this.mana_sub_button.TabIndex = 0;
            this.mana_sub_button.Text = "Manage Subscription";
            this.mana_sub_button.UseVisualStyleBackColor = true;
            this.mana_sub_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // publishNotButton
            // 
            this.publishNotButton.Enabled = false;
            this.publishNotButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.publishNotButton.Location = new System.Drawing.Point(284, 77);
            this.publishNotButton.Name = "publishNotButton";
            this.publishNotButton.Size = new System.Drawing.Size(233, 100);
            this.publishNotButton.TabIndex = 1;
            this.publishNotButton.Text = "Publish Notofication";
            this.publishNotButton.UseVisualStyleBackColor = true;
            this.publishNotButton.Click += new System.EventHandler(this.PublishNotButtonClick);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(557, 77);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(198, 100);
            this.exit_button.TabIndex = 2;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exitButtonClick);
            // 
            // NotificationManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 242);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.publishNotButton);
            this.Controls.Add(this.mana_sub_button);
            this.Name = "NotificationManagementForm";
            this.Text = "Notification Management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mana_sub_button;
        private System.Windows.Forms.Button publishNotButton;
        private System.Windows.Forms.Button exit_button;
    }
}

