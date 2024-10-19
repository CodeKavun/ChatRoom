namespace MulticastUltraFun
{
    partial class Form1
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
            this.chatViewer = new System.Windows.Forms.TextBox();
            this.messageField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userField = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chatViewer
            // 
            this.chatViewer.Location = new System.Drawing.Point(12, 12);
            this.chatViewer.Multiline = true;
            this.chatViewer.Name = "chatViewer";
            this.chatViewer.ReadOnly = true;
            this.chatViewer.Size = new System.Drawing.Size(775, 324);
            this.chatViewer.TabIndex = 0;
            // 
            // messageField
            // 
            this.messageField.Location = new System.Drawing.Point(13, 380);
            this.messageField.Multiline = true;
            this.messageField.Name = "messageField";
            this.messageField.Size = new System.Drawing.Size(612, 58);
            this.messageField.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User:";
            // 
            // userField
            // 
            this.userField.Location = new System.Drawing.Point(52, 344);
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(100, 20);
            this.userField.TabIndex = 6;
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendButton.Location = new System.Drawing.Point(632, 380);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(155, 58);
            this.sendButton.TabIndex = 10;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.userField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageField);
            this.Controls.Add(this.chatViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ULTRA CHAT ROOM!!!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox chatViewer;
        private System.Windows.Forms.TextBox messageField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.Button sendButton;
    }
}

