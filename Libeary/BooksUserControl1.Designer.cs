namespace Libeary
{
    partial class BooksUserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bookIdbox = new System.Windows.Forms.TextBox();
            this.clearbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.bookstabbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.accIdbox = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.isbnbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.authorbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.publisherbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dIDbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(601, 179);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acc No :";
            // 
            // bookIdbox
            // 
            this.bookIdbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bookIdbox.Location = new System.Drawing.Point(230, 27);
            this.bookIdbox.Name = "bookIdbox";
            this.bookIdbox.Size = new System.Drawing.Size(269, 22);
            this.bookIdbox.TabIndex = 2;
            this.bookIdbox.TextChanged += new System.EventHandler(this.bookIdbox_TextChanged);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.Image = global::Libeary.Properties.Resources.broom;
            this.clearbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearbutton.Location = new System.Drawing.Point(482, 287);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.clearbutton.Size = new System.Drawing.Size(145, 40);
            this.clearbutton.TabIndex = 7;
            this.clearbutton.Text = "Clean";
            this.clearbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.button4_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.Image = global::Libeary.Properties.Resources.delete;
            this.deletebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletebutton.Location = new System.Drawing.Point(331, 287);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.deletebutton.Size = new System.Drawing.Size(145, 38);
            this.deletebutton.TabIndex = 6;
            this.deletebutton.Text = "Delete";
            this.deletebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebutton.Image = global::Libeary.Properties.Resources.upload;
            this.updatebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updatebutton.Location = new System.Drawing.Point(180, 287);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.updatebutton.Size = new System.Drawing.Size(145, 38);
            this.updatebutton.TabIndex = 5;
            this.updatebutton.Text = "Update";
            this.updatebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updatebutton.UseVisualStyleBackColor = false;
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.Image = global::Libeary.Properties.Resources.add;
            this.addbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addbutton.Location = new System.Drawing.Point(29, 287);
            this.addbutton.Name = "addbutton";
            this.addbutton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.addbutton.Size = new System.Drawing.Size(145, 38);
            this.addbutton.TabIndex = 4;
            this.addbutton.Text = "Add New";
            this.addbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookstabbutton
            // 
            this.bookstabbutton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bookstabbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookstabbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookstabbutton.Image = global::Libeary.Properties.Resources.search;
            this.bookstabbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookstabbutton.Location = new System.Drawing.Point(254, 55);
            this.bookstabbutton.Name = "bookstabbutton";
            this.bookstabbutton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bookstabbutton.Size = new System.Drawing.Size(189, 32);
            this.bookstabbutton.TabIndex = 3;
            this.bookstabbutton.Text = "Search Book";
            this.bookstabbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bookstabbutton.UseVisualStyleBackColor = false;
            this.bookstabbutton.Click += new System.EventHandler(this.bookstabbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Acc No :";
            // 
            // accIdbox
            // 
            this.accIdbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.accIdbox.Location = new System.Drawing.Point(129, 362);
            this.accIdbox.Name = "accIdbox";
            this.accIdbox.Size = new System.Drawing.Size(177, 22);
            this.accIdbox.TabIndex = 9;
            // 
            // namebox
            // 
            this.namebox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.namebox.Location = new System.Drawing.Point(129, 405);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(177, 22);
            this.namebox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name :";
            // 
            // isbnbox
            // 
            this.isbnbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.isbnbox.Location = new System.Drawing.Point(447, 363);
            this.isbnbox.Name = "isbnbox";
            this.isbnbox.Size = new System.Drawing.Size(180, 22);
            this.isbnbox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "ISBN :";
            // 
            // authorbox
            // 
            this.authorbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.authorbox.Location = new System.Drawing.Point(447, 407);
            this.authorbox.Name = "authorbox";
            this.authorbox.Size = new System.Drawing.Size(180, 22);
            this.authorbox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(378, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Author :";
            // 
            // publisherbox
            // 
            this.publisherbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.publisherbox.Location = new System.Drawing.Point(129, 449);
            this.publisherbox.Name = "publisherbox";
            this.publisherbox.Size = new System.Drawing.Size(177, 22);
            this.publisherbox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Publisher :";
            // 
            // dIDbox
            // 
            this.dIDbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dIDbox.Location = new System.Drawing.Point(447, 449);
            this.dIDbox.Name = "dIDbox";
            this.dIDbox.Size = new System.Drawing.Size(180, 22);
            this.dIDbox.TabIndex = 19;
            this.dIDbox.TextChanged += new System.EventHandler(this.dIDbox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(396, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "dID :";
            // 
            // BooksUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dIDbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.authorbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.publisherbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.isbnbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accIdbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.bookstabbutton);
            this.Controls.Add(this.bookIdbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BooksUserControl1";
            this.Size = new System.Drawing.Size(691, 507);
            this.Load += new System.EventHandler(this.BooksUserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookIdbox;
        private System.Windows.Forms.Button bookstabbutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accIdbox;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox isbnbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox authorbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox publisherbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dIDbox;
        private System.Windows.Forms.Label label7;
    }
}
