namespace Libeary
{
    partial class AppBody
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
            this.components = new System.ComponentModel.Container();
            this.slidingpanel_timer = new System.Windows.Forms.Timer(this.components);
            this.contentpanel = new System.Windows.Forms.Panel();
            this.slidingpanel = new System.Windows.Forms.Panel();
            this.aboutabbutton = new System.Windows.Forms.Button();
            this.settingtabbutton = new System.Windows.Forms.Button();
            this.transactiontabbutton = new System.Windows.Forms.Button();
            this.borrowerstabbutton = new System.Windows.Forms.Button();
            this.bookstabbutton = new System.Windows.Forms.Button();
            this.slidingpanel_togglebutton = new System.Windows.Forms.Button();
            this.slidingpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // slidingpanel_timer
            // 
            this.slidingpanel_timer.Interval = 10;
            this.slidingpanel_timer.Tick += new System.EventHandler(this.slidingpanel_timer_Tick);
            // 
            // contentpanel
            // 
            this.contentpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.contentpanel.Location = new System.Drawing.Point(300, 0);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(691, 507);
            this.contentpanel.TabIndex = 1;
            // 
            // slidingpanel
            // 
            this.slidingpanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.slidingpanel.BackgroundImage = global::Libeary.Properties.Resources.images__1_;
            this.slidingpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slidingpanel.Controls.Add(this.aboutabbutton);
            this.slidingpanel.Controls.Add(this.settingtabbutton);
            this.slidingpanel.Controls.Add(this.transactiontabbutton);
            this.slidingpanel.Controls.Add(this.borrowerstabbutton);
            this.slidingpanel.Controls.Add(this.bookstabbutton);
            this.slidingpanel.Controls.Add(this.slidingpanel_togglebutton);
            this.slidingpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidingpanel.Location = new System.Drawing.Point(0, 0);
            this.slidingpanel.Name = "slidingpanel";
            this.slidingpanel.Size = new System.Drawing.Size(300, 507);
            this.slidingpanel.TabIndex = 0;
            this.slidingpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.slidingpanel_Paint);
            // 
            // aboutabbutton
            // 
            this.aboutabbutton.BackColor = System.Drawing.Color.Transparent;
            this.aboutabbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutabbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutabbutton.Image = global::Libeary.Properties.Resources.info;
            this.aboutabbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutabbutton.Location = new System.Drawing.Point(0, 281);
            this.aboutabbutton.Name = "aboutabbutton";
            this.aboutabbutton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.aboutabbutton.Size = new System.Drawing.Size(300, 60);
            this.aboutabbutton.TabIndex = 5;
            this.aboutabbutton.Text = "About";
            this.aboutabbutton.UseVisualStyleBackColor = false;
            this.aboutabbutton.Click += new System.EventHandler(this.aboutabbutton_Click);
            // 
            // settingtabbutton
            // 
            this.settingtabbutton.BackColor = System.Drawing.Color.Transparent;
            this.settingtabbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingtabbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingtabbutton.Image = global::Libeary.Properties.Resources.setting;
            this.settingtabbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingtabbutton.Location = new System.Drawing.Point(0, 224);
            this.settingtabbutton.Name = "settingtabbutton";
            this.settingtabbutton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.settingtabbutton.Size = new System.Drawing.Size(300, 60);
            this.settingtabbutton.TabIndex = 4;
            this.settingtabbutton.Text = "Setting";
            this.settingtabbutton.UseVisualStyleBackColor = false;
            this.settingtabbutton.Click += new System.EventHandler(this.settingtabbutton_Click);
            // 
            // transactiontabbutton
            // 
            this.transactiontabbutton.BackColor = System.Drawing.Color.Transparent;
            this.transactiontabbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactiontabbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactiontabbutton.Image = global::Libeary.Properties.Resources.transaction;
            this.transactiontabbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactiontabbutton.Location = new System.Drawing.Point(0, 168);
            this.transactiontabbutton.Name = "transactiontabbutton";
            this.transactiontabbutton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.transactiontabbutton.Size = new System.Drawing.Size(300, 60);
            this.transactiontabbutton.TabIndex = 3;
            this.transactiontabbutton.Text = "Transaction";
            this.transactiontabbutton.UseVisualStyleBackColor = false;
            this.transactiontabbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // borrowerstabbutton
            // 
            this.borrowerstabbutton.BackColor = System.Drawing.Color.Transparent;
            this.borrowerstabbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowerstabbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowerstabbutton.Image = global::Libeary.Properties.Resources.borrow;
            this.borrowerstabbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowerstabbutton.Location = new System.Drawing.Point(0, 113);
            this.borrowerstabbutton.Name = "borrowerstabbutton";
            this.borrowerstabbutton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.borrowerstabbutton.Size = new System.Drawing.Size(300, 60);
            this.borrowerstabbutton.TabIndex = 2;
            this.borrowerstabbutton.Text = "Borrowers";
            this.borrowerstabbutton.UseVisualStyleBackColor = false;
            this.borrowerstabbutton.Click += new System.EventHandler(this.borrowerstabbutton_Click);
            // 
            // bookstabbutton
            // 
            this.bookstabbutton.BackColor = System.Drawing.Color.Transparent;
            this.bookstabbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookstabbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookstabbutton.Image = global::Libeary.Properties.Resources.open_book__1_;
            this.bookstabbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookstabbutton.Location = new System.Drawing.Point(0, 56);
            this.bookstabbutton.Name = "bookstabbutton";
            this.bookstabbutton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bookstabbutton.Size = new System.Drawing.Size(300, 60);
            this.bookstabbutton.TabIndex = 1;
            this.bookstabbutton.Text = "Books";
            this.bookstabbutton.UseVisualStyleBackColor = false;
            this.bookstabbutton.Click += new System.EventHandler(this.bookstabbutton_Click);
            // 
            // slidingpanel_togglebutton
            // 
            this.slidingpanel_togglebutton.BackColor = System.Drawing.Color.Transparent;
            this.slidingpanel_togglebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slidingpanel_togglebutton.Location = new System.Drawing.Point(0, 0);
            this.slidingpanel_togglebutton.Name = "slidingpanel_togglebutton";
            this.slidingpanel_togglebutton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.slidingpanel_togglebutton.Size = new System.Drawing.Size(300, 60);
            this.slidingpanel_togglebutton.TabIndex = 0;
            this.slidingpanel_togglebutton.UseVisualStyleBackColor = false;
            this.slidingpanel_togglebutton.Click += new System.EventHandler(this.slidingpanel_togglebutton_Click);
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 507);
            this.Controls.Add(this.contentpanel);
            this.Controls.Add(this.slidingpanel);
            this.Name = "AppBody";
            this.Text = "AppBody";
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.slidingpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel slidingpanel;
        private System.Windows.Forms.Button slidingpanel_togglebutton;
        private System.Windows.Forms.Timer slidingpanel_timer;
        private System.Windows.Forms.Button aboutabbutton;
        private System.Windows.Forms.Button settingtabbutton;
        private System.Windows.Forms.Button transactiontabbutton;
        private System.Windows.Forms.Button borrowerstabbutton;
        private System.Windows.Forms.Button bookstabbutton;
        private System.Windows.Forms.Panel contentpanel;
    }
}