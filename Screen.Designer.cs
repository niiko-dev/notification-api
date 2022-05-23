
namespace Notifications_API
{
    partial class Screen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.notification_bg = new System.Windows.Forms.PictureBox();
            this.notification_bar = new System.Windows.Forms.PictureBox();
            this.notification_message = new System.Windows.Forms.Label();
            this.notification_title = new System.Windows.Forms.Label();
            this.notification = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.notification_bg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notification_bar)).BeginInit();
            this.notification.SuspendLayout();
            this.SuspendLayout();
            // 
            // notification_bg
            // 
            this.notification_bg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.notification_bg.Location = new System.Drawing.Point(16, 36);
            this.notification_bg.Name = "notification_bg";
            this.notification_bg.Size = new System.Drawing.Size(270, 98);
            this.notification_bg.TabIndex = 0;
            this.notification_bg.TabStop = false;
            // 
            // notification_bar
            // 
            this.notification_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.notification_bar.Location = new System.Drawing.Point(16, 36);
            this.notification_bar.Name = "notification_bar";
            this.notification_bar.Size = new System.Drawing.Size(270, 21);
            this.notification_bar.TabIndex = 1;
            this.notification_bar.TabStop = false;
            // 
            // notification_message
            // 
            this.notification_message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.notification_message.ForeColor = System.Drawing.Color.White;
            this.notification_message.Location = new System.Drawing.Point(22, 63);
            this.notification_message.Name = "notification_message";
            this.notification_message.Size = new System.Drawing.Size(257, 65);
            this.notification_message.TabIndex = 2;
            this.notification_message.Text = "Message";
            // 
            // notification_title
            // 
            this.notification_title.AutoSize = true;
            this.notification_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.notification_title.ForeColor = System.Drawing.Color.White;
            this.notification_title.Location = new System.Drawing.Point(18, 39);
            this.notification_title.Name = "notification_title";
            this.notification_title.Size = new System.Drawing.Size(29, 15);
            this.notification_title.TabIndex = 3;
            this.notification_title.Text = "Title";
            // 
            // notification
            // 
            this.notification.Controls.Add(this.notification_title);
            this.notification.Controls.Add(this.notification_message);
            this.notification.Controls.Add(this.notification_bar);
            this.notification.Controls.Add(this.notification_bg);
            this.notification.Location = new System.Drawing.Point(-4, -24);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(528, 242);
            this.notification.TabIndex = 4;
            this.notification.TabStop = false;
            this.notification.Text = "Notification";
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 0);
            this.Controls.Add(this.notification);
            this.Name = "Screen";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notification_bg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notification_bar)).EndInit();
            this.notification.ResumeLayout(false);
            this.notification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox notification_bg;
        private System.Windows.Forms.PictureBox notification_bar;
        private System.Windows.Forms.Label notification_message;
        private System.Windows.Forms.Label notification_title;
        private System.Windows.Forms.GroupBox notification;
    }
}

