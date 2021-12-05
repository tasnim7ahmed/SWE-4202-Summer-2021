namespace Library_Management_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.addBookButton = new System.Windows.Forms.Button();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.bookTitleTextBox = new System.Windows.Forms.TextBox();
            this.bookIDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bookIDBorrowTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.userIDBorrowTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.borrowButton = new System.Windows.Forms.Button();
            this.userHistoryButton = new System.Windows.Forms.Button();
            this.userIDShowTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bookHistoryButton = new System.Windows.Forms.Button();
            this.bookIDShowTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.bookTitleLabel = new System.Windows.Forms.Label();
            this.bookIDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.Location = new System.Drawing.Point(60, 10);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.userIDTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(60, 36);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(60, 62);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 5;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(85, 88);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(75, 23);
            this.addUserButton.TabIndex = 6;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserOnClick);
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(272, 140);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(75, 23);
            this.addBookButton.TabIndex = 13;
            this.addBookButton.Text = "Add Book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookOnClick);
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(247, 62);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(100, 20);
            this.authorTextBox.TabIndex = 12;
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.Location = new System.Drawing.Point(247, 36);
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.bookTitleTextBox.TabIndex = 11;
            // 
            // bookIDTextBox
            // 
            this.bookIDTextBox.Location = new System.Drawing.Point(247, 10);
            this.bookIDTextBox.Name = "bookIDTextBox";
            this.bookIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.bookIDTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Book Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "BookID";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(247, 114);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 17;
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Location = new System.Drawing.Point(247, 88);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(100, 20);
            this.publisherTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Publisher";
            // 
            // bookIDBorrowTextBox
            // 
            this.bookIDBorrowTextBox.Location = new System.Drawing.Point(60, 243);
            this.bookIDBorrowTextBox.Name = "bookIDBorrowTextBox";
            this.bookIDBorrowTextBox.Size = new System.Drawing.Size(100, 20);
            this.bookIDBorrowTextBox.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "BookID";
            // 
            // userIDBorrowTextBox
            // 
            this.userIDBorrowTextBox.Location = new System.Drawing.Point(60, 217);
            this.userIDBorrowTextBox.Name = "userIDBorrowTextBox";
            this.userIDBorrowTextBox.Size = new System.Drawing.Size(100, 20);
            this.userIDBorrowTextBox.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "UserID";
            // 
            // borrowButton
            // 
            this.borrowButton.Location = new System.Drawing.Point(85, 269);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(75, 23);
            this.borrowButton.TabIndex = 22;
            this.borrowButton.Text = "Borrow Book";
            this.borrowButton.UseVisualStyleBackColor = true;
            this.borrowButton.Click += new System.EventHandler(this.borrowOnClick);
            // 
            // userHistoryButton
            // 
            this.userHistoryButton.Location = new System.Drawing.Point(435, 34);
            this.userHistoryButton.Name = "userHistoryButton";
            this.userHistoryButton.Size = new System.Drawing.Size(100, 23);
            this.userHistoryButton.TabIndex = 25;
            this.userHistoryButton.Text = "Show History";
            this.userHistoryButton.UseVisualStyleBackColor = true;
            this.userHistoryButton.Click += new System.EventHandler(this.showUserHistoryOnClick);
            // 
            // userIDShowTextBox
            // 
            this.userIDShowTextBox.Location = new System.Drawing.Point(435, 8);
            this.userIDShowTextBox.Name = "userIDShowTextBox";
            this.userIDShowTextBox.Size = new System.Drawing.Size(100, 20);
            this.userIDShowTextBox.TabIndex = 24;
            this.userIDShowTextBox.Click += new System.EventHandler(this.showUserOnClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(389, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "UserID";
            // 
            // bookHistoryButton
            // 
            this.bookHistoryButton.Location = new System.Drawing.Point(628, 34);
            this.bookHistoryButton.Name = "bookHistoryButton";
            this.bookHistoryButton.Size = new System.Drawing.Size(100, 23);
            this.bookHistoryButton.TabIndex = 28;
            this.bookHistoryButton.Text = "Show History";
            this.bookHistoryButton.UseVisualStyleBackColor = true;
            this.bookHistoryButton.Click += new System.EventHandler(this.bookShowOnClick);
            // 
            // bookIDShowTextBox
            // 
            this.bookIDShowTextBox.Location = new System.Drawing.Point(628, 8);
            this.bookIDShowTextBox.Name = "bookIDShowTextBox";
            this.bookIDShowTextBox.Size = new System.Drawing.Size(100, 20);
            this.bookIDShowTextBox.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(582, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Book ID";
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(353, 88);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(182, 212);
            this.userListBox.TabIndex = 29;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(622, 192);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(49, 13);
            this.quantityLabel.TabIndex = 34;
            this.quantityLabel.Text = "Quantity:";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Location = new System.Drawing.Point(618, 164);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(53, 13);
            this.publisherLabel.TabIndex = 33;
            this.publisherLabel.Text = "Publisher:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(627, 136);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(41, 13);
            this.authorLabel.TabIndex = 32;
            this.authorLabel.Text = "Author:";
            // 
            // bookTitleLabel
            // 
            this.bookTitleLabel.AutoSize = true;
            this.bookTitleLabel.Location = new System.Drawing.Point(613, 114);
            this.bookTitleLabel.Name = "bookTitleLabel";
            this.bookTitleLabel.Size = new System.Drawing.Size(58, 13);
            this.bookTitleLabel.TabIndex = 31;
            this.bookTitleLabel.Text = "Book Title:";
            // 
            // bookIDLabel
            // 
            this.bookIDLabel.AutoSize = true;
            this.bookIDLabel.Location = new System.Drawing.Point(625, 88);
            this.bookIDLabel.Name = "bookIDLabel";
            this.bookIDLabel.Size = new System.Drawing.Size(49, 13);
            this.bookIDLabel.TabIndex = 30;
            this.bookIDLabel.Text = "BookID: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 310);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.bookTitleLabel);
            this.Controls.Add(this.bookIDLabel);
            this.Controls.Add(this.userListBox);
            this.Controls.Add(this.bookHistoryButton);
            this.Controls.Add(this.bookIDShowTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.userHistoryButton);
            this.Controls.Add(this.userIDShowTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.bookIDBorrowTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.userIDBorrowTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.publisherTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.bookTitleTextBox);
            this.Controls.Add(this.bookIDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Library Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox bookTitleTextBox;
        private System.Windows.Forms.TextBox bookIDTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bookIDBorrowTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox userIDBorrowTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.Button userHistoryButton;
        private System.Windows.Forms.TextBox userIDShowTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bookHistoryButton;
        private System.Windows.Forms.TextBox bookIDShowTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label bookTitleLabel;
        private System.Windows.Forms.Label bookIDLabel;
    }
}

