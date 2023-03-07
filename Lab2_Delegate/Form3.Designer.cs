namespace Lab2_Delegate
{
    partial class PublishNotForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.messageToPublish = new System.Windows.Forms.RichTextBox();
            this.publishButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notification Content";
            // 
            // messageToPublish
            // 
            this.messageToPublish.Location = new System.Drawing.Point(202, 110);
            this.messageToPublish.Name = "messageToPublish";
            this.messageToPublish.Size = new System.Drawing.Size(531, 40);
            this.messageToPublish.TabIndex = 1;
            this.messageToPublish.Text = "";
            this.messageToPublish.TextChanged += new System.EventHandler(this.messageToPublish_TextChanged);
            // 
            // publishButton
            // 
            this.publishButton.Location = new System.Drawing.Point(92, 307);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(207, 67);
            this.publishButton.TabIndex = 2;
            this.publishButton.Text = "Publish";
            this.publishButton.UseVisualStyleBackColor = true;
            this.publishButton.Click += new System.EventHandler(this.publishButton_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(501, 307);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(191, 67);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // PublishNotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.publishButton);
            this.Controls.Add(this.messageToPublish);
            this.Controls.Add(this.label1);
            this.Name = "PublishNotForm";
            this.Text = "Publish Notification";
            this.Load += new System.EventHandler(this.PublishNotForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox messageToPublish;
        private System.Windows.Forms.Button publishButton;
        private System.Windows.Forms.Button Exit;
    }
}