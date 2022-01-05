namespace Libeary
{
    partial class TransactionUserControl1
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
            this.borrowersearchtab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accnosearchbar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clearallbutton = new System.Windows.Forms.Button();
            this.returnbookbar = new System.Windows.Forms.Button();
            this.issuebooksearch = new System.Windows.Forms.Button();
            this.boocksearchbar = new System.Windows.Forms.Button();
            this.borrowersearchbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.borrowedbook1 = new System.Windows.Forms.TextBox();
            this.borrowerbook2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bookborrowedby = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // borrowersearchtab
            // 
            this.borrowersearchtab.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.borrowersearchtab.Location = new System.Drawing.Point(166, 58);
            this.borrowersearchtab.Name = "borrowersearchtab";
            this.borrowersearchtab.Size = new System.Drawing.Size(247, 22);
            this.borrowersearchtab.TabIndex = 5;
            this.borrowersearchtab.TextChanged += new System.EventHandler(this.borrowersearchtab_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Borrower\'s ID :";
            // 
            // accnosearchbar
            // 
            this.accnosearchbar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.accnosearchbar.Location = new System.Drawing.Point(117, 203);
            this.accnosearchbar.Name = "accnosearchbar";
            this.accnosearchbar.Size = new System.Drawing.Size(296, 22);
            this.accnosearchbar.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Acc No :";
            // 
            // clearallbutton
            // 
            this.clearallbutton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.clearallbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearallbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearallbutton.Image = global::Libeary.Properties.Resources.broom;
            this.clearallbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearallbutton.Location = new System.Drawing.Point(219, 368);
            this.clearallbutton.Name = "clearallbutton";
            this.clearallbutton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.clearallbutton.Size = new System.Drawing.Size(194, 38);
            this.clearallbutton.TabIndex = 12;
            this.clearallbutton.Text = "Clear All";
            this.clearallbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearallbutton.UseVisualStyleBackColor = false;
            // 
            // returnbookbar
            // 
            this.returnbookbar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.returnbookbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnbookbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbookbar.Image = global::Libeary.Properties.Resources.login;
            this.returnbookbar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnbookbar.Location = new System.Drawing.Point(363, 434);
            this.returnbookbar.Name = "returnbookbar";
            this.returnbookbar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.returnbookbar.Size = new System.Drawing.Size(194, 38);
            this.returnbookbar.TabIndex = 11;
            this.returnbookbar.Text = "Return Book";
            this.returnbookbar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.returnbookbar.UseVisualStyleBackColor = false;
            this.returnbookbar.Click += new System.EventHandler(this.returnbookbar_Click);
            // 
            // issuebooksearch
            // 
            this.issuebooksearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.issuebooksearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issuebooksearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuebooksearch.Image = global::Libeary.Properties.Resources.exit;
            this.issuebooksearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issuebooksearch.Location = new System.Drawing.Point(97, 434);
            this.issuebooksearch.Name = "issuebooksearch";
            this.issuebooksearch.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.issuebooksearch.Size = new System.Drawing.Size(194, 38);
            this.issuebooksearch.TabIndex = 10;
            this.issuebooksearch.Text = "Issue Book";
            this.issuebooksearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.issuebooksearch.UseVisualStyleBackColor = false;
            this.issuebooksearch.Click += new System.EventHandler(this.issuebooksearch_Click);
            // 
            // boocksearchbar
            // 
            this.boocksearchbar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.boocksearchbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boocksearchbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boocksearchbar.Image = global::Libeary.Properties.Resources.search;
            this.boocksearchbar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boocksearchbar.Location = new System.Drawing.Point(186, 249);
            this.boocksearchbar.Name = "boocksearchbar";
            this.boocksearchbar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.boocksearchbar.Size = new System.Drawing.Size(218, 38);
            this.boocksearchbar.TabIndex = 9;
            this.boocksearchbar.Text = "Search Book";
            this.boocksearchbar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.boocksearchbar.UseVisualStyleBackColor = false;
            this.boocksearchbar.Click += new System.EventHandler(this.boocksearchbar_Click);
            // 
            // borrowersearchbutton
            // 
            this.borrowersearchbutton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.borrowersearchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrowersearchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowersearchbutton.Image = global::Libeary.Properties.Resources.search;
            this.borrowersearchbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.borrowersearchbutton.Location = new System.Drawing.Point(186, 103);
            this.borrowersearchbutton.Name = "borrowersearchbutton";
            this.borrowersearchbutton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.borrowersearchbutton.Size = new System.Drawing.Size(218, 38);
            this.borrowersearchbutton.TabIndex = 6;
            this.borrowersearchbutton.Text = "      Search Borrower";
            this.borrowersearchbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.borrowersearchbutton.UseVisualStyleBackColor = false;
            this.borrowersearchbutton.Click += new System.EventHandler(this.borrowersearchbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(477, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Book 1 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(477, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Book 2 :";
            // 
            // borrowedbook1
            // 
            this.borrowedbook1.BackColor = System.Drawing.Color.White;
            this.borrowedbook1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borrowedbook1.Location = new System.Drawing.Point(554, 44);
            this.borrowedbook1.Name = "borrowedbook1";
            this.borrowedbook1.Size = new System.Drawing.Size(92, 15);
            this.borrowedbook1.TabIndex = 15;
            // 
            // borrowerbook2
            // 
            this.borrowerbook2.BackColor = System.Drawing.Color.White;
            this.borrowerbook2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.borrowerbook2.Location = new System.Drawing.Point(554, 78);
            this.borrowerbook2.Name = "borrowerbook2";
            this.borrowerbook2.Size = new System.Drawing.Size(92, 15);
            this.borrowerbook2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(432, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Borrowed By :";
            // 
            // bookborrowedby
            // 
            this.bookborrowedby.BackColor = System.Drawing.Color.White;
            this.bookborrowedby.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookborrowedby.Location = new System.Drawing.Point(554, 201);
            this.bookborrowedby.Name = "bookborrowedby";
            this.bookborrowedby.Size = new System.Drawing.Size(92, 15);
            this.bookborrowedby.TabIndex = 18;
            // 
            // TransactionUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bookborrowedby);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.borrowerbook2);
            this.Controls.Add(this.borrowedbook1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clearallbutton);
            this.Controls.Add(this.returnbookbar);
            this.Controls.Add(this.issuebooksearch);
            this.Controls.Add(this.boocksearchbar);
            this.Controls.Add(this.accnosearchbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.borrowersearchbutton);
            this.Controls.Add(this.borrowersearchtab);
            this.Controls.Add(this.label1);
            this.Name = "TransactionUserControl1";
            this.Size = new System.Drawing.Size(691, 507);
            this.Load += new System.EventHandler(this.TransactionUserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button borrowersearchbutton;
        private System.Windows.Forms.TextBox borrowersearchtab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boocksearchbar;
        private System.Windows.Forms.TextBox accnosearchbar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button issuebooksearch;
        private System.Windows.Forms.Button returnbookbar;
        private System.Windows.Forms.Button clearallbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox borrowedbook1;
        private System.Windows.Forms.TextBox borrowerbook2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bookborrowedby;
    }
}
