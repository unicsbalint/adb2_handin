namespace adb2_handInProject
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Author = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_author_dummyData = new System.Windows.Forms.TextBox();
            this.bt_author_dummyData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_author_modify_authorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_author_modify_authorName = new System.Windows.Forms.TextBox();
            this.tb_author_add_authorName = new System.Windows.Forms.TextBox();
            this.tb_author_modify_booksWritten = new System.Windows.Forms.TextBox();
            this.tb_author_add_booksWritten = new System.Windows.Forms.TextBox();
            this.bt_author_modify = new System.Windows.Forms.Button();
            this.bt_author_Add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_author_List = new System.Windows.Forms.Button();
            this.author_List = new System.Windows.Forms.ListBox();
            this.tab_Books = new System.Windows.Forms.TabPage();
            this.tab_Borrows = new System.Windows.Forms.TabPage();
            this.borrows_List = new System.Windows.Forms.ListBox();
            this.tab_Students = new System.Windows.Forms.TabPage();
            this.students_List = new System.Windows.Forms.ListBox();
            this.tab_Users = new System.Windows.Forms.TabPage();
            this.users_List = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_books_N_Dummydata = new System.Windows.Forms.TextBox();
            this.bt_books_dummyData = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_books_bookId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_books_author_id = new System.Windows.Forms.TextBox();
            this.tb_books_authorId = new System.Windows.Forms.TextBox();
            this.tb_books_book_name = new System.Windows.Forms.TextBox();
            this.tb_books_bookName = new System.Windows.Forms.TextBox();
            this.bt_books_modify = new System.Windows.Forms.Button();
            this.bt_books_Add = new System.Windows.Forms.Button();
            this.bt_books_delete = new System.Windows.Forms.Button();
            this.bt_books_list = new System.Windows.Forms.Button();
            this.bookList = new System.Windows.Forms.ListBox();
            this.label_maxauthorID = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_maxBooksID = new System.Windows.Forms.Label();
            this.bt_usersList = new System.Windows.Forms.Button();
            this.bt_register = new System.Windows.Forms.Button();
            this.bt_user_list_delete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_Author.SuspendLayout();
            this.tab_Books.SuspendLayout();
            this.tab_Borrows.SuspendLayout();
            this.tab_Students.SuspendLayout();
            this.tab_Users.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Author);
            this.tabControl1.Controls.Add(this.tab_Books);
            this.tabControl1.Controls.Add(this.tab_Students);
            this.tabControl1.Controls.Add(this.tab_Borrows);
            this.tabControl1.Controls.Add(this.tab_Users);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tab_Author
            // 
            this.tab_Author.Controls.Add(this.label6);
            this.tab_Author.Controls.Add(this.tb_author_dummyData);
            this.tab_Author.Controls.Add(this.bt_author_dummyData);
            this.tab_Author.Controls.Add(this.label4);
            this.tab_Author.Controls.Add(this.label2);
            this.tab_Author.Controls.Add(this.label5);
            this.tab_Author.Controls.Add(this.label3);
            this.tab_Author.Controls.Add(this.tb_author_modify_authorID);
            this.tab_Author.Controls.Add(this.label1);
            this.tab_Author.Controls.Add(this.tb_author_modify_authorName);
            this.tab_Author.Controls.Add(this.tb_author_add_authorName);
            this.tab_Author.Controls.Add(this.tb_author_modify_booksWritten);
            this.tab_Author.Controls.Add(this.tb_author_add_booksWritten);
            this.tab_Author.Controls.Add(this.bt_author_modify);
            this.tab_Author.Controls.Add(this.bt_author_Add);
            this.tab_Author.Controls.Add(this.button2);
            this.tab_Author.Controls.Add(this.bt_author_List);
            this.tab_Author.Controls.Add(this.author_List);
            this.tab_Author.Location = new System.Drawing.Point(4, 22);
            this.tab_Author.Name = "tab_Author";
            this.tab_Author.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Author.Size = new System.Drawing.Size(792, 424);
            this.tab_Author.TabIndex = 0;
            this.tab_Author.Text = "Author";
            this.tab_Author.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "N:";
            // 
            // tb_author_dummyData
            // 
            this.tb_author_dummyData.Location = new System.Drawing.Point(304, 395);
            this.tb_author_dummyData.Name = "tb_author_dummyData";
            this.tb_author_dummyData.Size = new System.Drawing.Size(100, 20);
            this.tb_author_dummyData.TabIndex = 9;
            // 
            // bt_author_dummyData
            // 
            this.bt_author_dummyData.Location = new System.Drawing.Point(410, 393);
            this.bt_author_dummyData.Name = "bt_author_dummyData";
            this.bt_author_dummyData.Size = new System.Drawing.Size(161, 23);
            this.bt_author_dummyData.TabIndex = 8;
            this.bt_author_dummyData.Text = "Generate N dummy data";
            this.bt_author_dummyData.UseVisualStyleBackColor = true;
            this.bt_author_dummyData.Click += new System.EventHandler(this.bt_author_dummyData_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Books written:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Books written:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Author ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Author name:";
            // 
            // tb_author_modify_authorID
            // 
            this.tb_author_modify_authorID.Location = new System.Drawing.Point(96, 129);
            this.tb_author_modify_authorID.Name = "tb_author_modify_authorID";
            this.tb_author_modify_authorID.Size = new System.Drawing.Size(100, 20);
            this.tb_author_modify_authorID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Author name:";
            // 
            // tb_author_modify_authorName
            // 
            this.tb_author_modify_authorName.Location = new System.Drawing.Point(96, 154);
            this.tb_author_modify_authorName.Name = "tb_author_modify_authorName";
            this.tb_author_modify_authorName.Size = new System.Drawing.Size(100, 20);
            this.tb_author_modify_authorName.TabIndex = 5;
            // 
            // tb_author_add_authorName
            // 
            this.tb_author_add_authorName.Location = new System.Drawing.Point(96, 29);
            this.tb_author_add_authorName.Name = "tb_author_add_authorName";
            this.tb_author_add_authorName.Size = new System.Drawing.Size(100, 20);
            this.tb_author_add_authorName.TabIndex = 5;
            // 
            // tb_author_modify_booksWritten
            // 
            this.tb_author_modify_booksWritten.Location = new System.Drawing.Point(96, 180);
            this.tb_author_modify_booksWritten.Name = "tb_author_modify_booksWritten";
            this.tb_author_modify_booksWritten.Size = new System.Drawing.Size(100, 20);
            this.tb_author_modify_booksWritten.TabIndex = 4;
            // 
            // tb_author_add_booksWritten
            // 
            this.tb_author_add_booksWritten.Location = new System.Drawing.Point(96, 55);
            this.tb_author_add_booksWritten.Name = "tb_author_add_booksWritten";
            this.tb_author_add_booksWritten.Size = new System.Drawing.Size(100, 20);
            this.tb_author_add_booksWritten.TabIndex = 4;
            // 
            // bt_author_modify
            // 
            this.bt_author_modify.Location = new System.Drawing.Point(75, 206);
            this.bt_author_modify.Name = "bt_author_modify";
            this.bt_author_modify.Size = new System.Drawing.Size(121, 23);
            this.bt_author_modify.TabIndex = 3;
            this.bt_author_modify.Text = "Modify (through ID)";
            this.bt_author_modify.UseVisualStyleBackColor = true;
            this.bt_author_modify.Click += new System.EventHandler(this.bt_author_modify_Click);
            // 
            // bt_author_Add
            // 
            this.bt_author_Add.Location = new System.Drawing.Point(96, 81);
            this.bt_author_Add.Name = "bt_author_Add";
            this.bt_author_Add.Size = new System.Drawing.Size(75, 23);
            this.bt_author_Add.TabIndex = 3;
            this.bt_author_Add.Text = "Add";
            this.bt_author_Add.UseVisualStyleBackColor = true;
            this.bt_author_Add.Click += new System.EventHandler(this.bt_author_Add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(620, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_author_List
            // 
            this.bt_author_List.Location = new System.Drawing.Point(701, 393);
            this.bt_author_List.Name = "bt_author_List";
            this.bt_author_List.Size = new System.Drawing.Size(75, 23);
            this.bt_author_List.TabIndex = 1;
            this.bt_author_List.Text = "List";
            this.bt_author_List.UseVisualStyleBackColor = true;
            this.bt_author_List.Click += new System.EventHandler(this.bt_author_List_Click);
            // 
            // author_List
            // 
            this.author_List.FormattingEnabled = true;
            this.author_List.Location = new System.Drawing.Point(241, 6);
            this.author_List.Name = "author_List";
            this.author_List.Size = new System.Drawing.Size(535, 381);
            this.author_List.TabIndex = 0;
            // 
            // tab_Books
            // 
            this.tab_Books.Controls.Add(this.label14);
            this.tab_Books.Controls.Add(this.label13);
            this.tab_Books.Controls.Add(this.label_maxauthorID);
            this.tab_Books.Controls.Add(this.label7);
            this.tab_Books.Controls.Add(this.tb_books_N_Dummydata);
            this.tab_Books.Controls.Add(this.bt_books_dummyData);
            this.tab_Books.Controls.Add(this.label8);
            this.tab_Books.Controls.Add(this.label9);
            this.tab_Books.Controls.Add(this.label10);
            this.tab_Books.Controls.Add(this.label11);
            this.tab_Books.Controls.Add(this.tb_books_bookId);
            this.tab_Books.Controls.Add(this.label12);
            this.tab_Books.Controls.Add(this.tb_books_author_id);
            this.tab_Books.Controls.Add(this.tb_books_authorId);
            this.tab_Books.Controls.Add(this.tb_books_book_name);
            this.tab_Books.Controls.Add(this.tb_books_bookName);
            this.tab_Books.Controls.Add(this.bt_books_modify);
            this.tab_Books.Controls.Add(this.bt_books_Add);
            this.tab_Books.Controls.Add(this.bt_books_delete);
            this.tab_Books.Controls.Add(this.bt_books_list);
            this.tab_Books.Controls.Add(this.bookList);
            this.tab_Books.Location = new System.Drawing.Point(4, 22);
            this.tab_Books.Name = "tab_Books";
            this.tab_Books.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Books.Size = new System.Drawing.Size(792, 424);
            this.tab_Books.TabIndex = 1;
            this.tab_Books.Text = "Books";
            this.tab_Books.UseVisualStyleBackColor = true;
            // 
            // tab_Borrows
            // 
            this.tab_Borrows.Controls.Add(this.label_maxBooksID);
            this.tab_Borrows.Controls.Add(this.borrows_List);
            this.tab_Borrows.Location = new System.Drawing.Point(4, 22);
            this.tab_Borrows.Name = "tab_Borrows";
            this.tab_Borrows.Size = new System.Drawing.Size(792, 424);
            this.tab_Borrows.TabIndex = 2;
            this.tab_Borrows.Text = "Borrows";
            this.tab_Borrows.UseVisualStyleBackColor = true;
            // 
            // borrows_List
            // 
            this.borrows_List.FormattingEnabled = true;
            this.borrows_List.Location = new System.Drawing.Point(233, 3);
            this.borrows_List.Name = "borrows_List";
            this.borrows_List.Size = new System.Drawing.Size(556, 407);
            this.borrows_List.TabIndex = 0;
            // 
            // tab_Students
            // 
            this.tab_Students.Controls.Add(this.students_List);
            this.tab_Students.Location = new System.Drawing.Point(4, 22);
            this.tab_Students.Name = "tab_Students";
            this.tab_Students.Size = new System.Drawing.Size(792, 424);
            this.tab_Students.TabIndex = 3;
            this.tab_Students.Text = "Students";
            this.tab_Students.UseVisualStyleBackColor = true;
            // 
            // students_List
            // 
            this.students_List.FormattingEnabled = true;
            this.students_List.Location = new System.Drawing.Point(275, 14);
            this.students_List.Name = "students_List";
            this.students_List.Size = new System.Drawing.Size(498, 394);
            this.students_List.TabIndex = 0;
            // 
            // tab_Users
            // 
            this.tab_Users.Controls.Add(this.bt_user_list_delete);
            this.tab_Users.Controls.Add(this.bt_register);
            this.tab_Users.Controls.Add(this.bt_usersList);
            this.tab_Users.Controls.Add(this.users_List);
            this.tab_Users.Location = new System.Drawing.Point(4, 22);
            this.tab_Users.Name = "tab_Users";
            this.tab_Users.Size = new System.Drawing.Size(792, 424);
            this.tab_Users.TabIndex = 4;
            this.tab_Users.Text = "Users";
            this.tab_Users.UseVisualStyleBackColor = true;
            this.tab_Users.Click += new System.EventHandler(this.tab_Users_Click);
            // 
            // users_List
            // 
            this.users_List.FormattingEnabled = true;
            this.users_List.Location = new System.Drawing.Point(268, 3);
            this.users_List.Name = "users_List";
            this.users_List.Size = new System.Drawing.Size(516, 381);
            this.users_List.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "N:";
            // 
            // tb_books_N_Dummydata
            // 
            this.tb_books_N_Dummydata.Location = new System.Drawing.Point(302, 396);
            this.tb_books_N_Dummydata.Name = "tb_books_N_Dummydata";
            this.tb_books_N_Dummydata.Size = new System.Drawing.Size(100, 20);
            this.tb_books_N_Dummydata.TabIndex = 27;
            // 
            // bt_books_dummyData
            // 
            this.bt_books_dummyData.Location = new System.Drawing.Point(408, 394);
            this.bt_books_dummyData.Name = "bt_books_dummyData";
            this.bt_books_dummyData.Size = new System.Drawing.Size(161, 23);
            this.bt_books_dummyData.TabIndex = 26;
            this.bt_books_dummyData.Text = "Generate N dummy data";
            this.bt_books_dummyData.UseVisualStyleBackColor = true;
            this.bt_books_dummyData.Click += new System.EventHandler(this.bt_books_dummyData_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Book_name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Book_name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Book ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Author_id";
            // 
            // tb_books_bookId
            // 
            this.tb_books_bookId.Location = new System.Drawing.Point(94, 202);
            this.tb_books_bookId.Name = "tb_books_bookId";
            this.tb_books_bookId.Size = new System.Drawing.Size(100, 20);
            this.tb_books_bookId.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Author_id";
            // 
            // tb_books_author_id
            // 
            this.tb_books_author_id.Location = new System.Drawing.Point(94, 227);
            this.tb_books_author_id.Name = "tb_books_author_id";
            this.tb_books_author_id.Size = new System.Drawing.Size(100, 20);
            this.tb_books_author_id.TabIndex = 20;
            // 
            // tb_books_authorId
            // 
            this.tb_books_authorId.Location = new System.Drawing.Point(94, 48);
            this.tb_books_authorId.Name = "tb_books_authorId";
            this.tb_books_authorId.Size = new System.Drawing.Size(100, 20);
            this.tb_books_authorId.TabIndex = 18;
            // 
            // tb_books_book_name
            // 
            this.tb_books_book_name.Location = new System.Drawing.Point(94, 253);
            this.tb_books_book_name.Name = "tb_books_book_name";
            this.tb_books_book_name.Size = new System.Drawing.Size(100, 20);
            this.tb_books_book_name.TabIndex = 17;
            // 
            // tb_books_bookName
            // 
            this.tb_books_bookName.Location = new System.Drawing.Point(94, 74);
            this.tb_books_bookName.Name = "tb_books_bookName";
            this.tb_books_bookName.Size = new System.Drawing.Size(100, 20);
            this.tb_books_bookName.TabIndex = 16;
            // 
            // bt_books_modify
            // 
            this.bt_books_modify.Location = new System.Drawing.Point(73, 279);
            this.bt_books_modify.Name = "bt_books_modify";
            this.bt_books_modify.Size = new System.Drawing.Size(121, 23);
            this.bt_books_modify.TabIndex = 15;
            this.bt_books_modify.Text = "Modify (through ID)";
            this.bt_books_modify.UseVisualStyleBackColor = true;
            this.bt_books_modify.Click += new System.EventHandler(this.bt_books_modify_Click);
            // 
            // bt_books_Add
            // 
            this.bt_books_Add.Location = new System.Drawing.Point(94, 100);
            this.bt_books_Add.Name = "bt_books_Add";
            this.bt_books_Add.Size = new System.Drawing.Size(75, 23);
            this.bt_books_Add.TabIndex = 14;
            this.bt_books_Add.Text = "Add";
            this.bt_books_Add.UseVisualStyleBackColor = true;
            this.bt_books_Add.Click += new System.EventHandler(this.bt_books_Add_Click);
            // 
            // bt_books_delete
            // 
            this.bt_books_delete.Location = new System.Drawing.Point(618, 394);
            this.bt_books_delete.Name = "bt_books_delete";
            this.bt_books_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_books_delete.TabIndex = 13;
            this.bt_books_delete.Text = "Delete";
            this.bt_books_delete.UseVisualStyleBackColor = true;
            this.bt_books_delete.Click += new System.EventHandler(this.bt_books_delete_Click);
            // 
            // bt_books_list
            // 
            this.bt_books_list.Location = new System.Drawing.Point(699, 394);
            this.bt_books_list.Name = "bt_books_list";
            this.bt_books_list.Size = new System.Drawing.Size(75, 23);
            this.bt_books_list.TabIndex = 12;
            this.bt_books_list.Text = "List";
            this.bt_books_list.UseVisualStyleBackColor = true;
            this.bt_books_list.Click += new System.EventHandler(this.bt_books_list_Click);
            // 
            // bookList
            // 
            this.bookList.FormattingEnabled = true;
            this.bookList.Location = new System.Drawing.Point(239, 7);
            this.bookList.Name = "bookList";
            this.bookList.Size = new System.Drawing.Size(535, 381);
            this.bookList.TabIndex = 11;
            // 
            // label_maxauthorID
            // 
            this.label_maxauthorID.AutoSize = true;
            this.label_maxauthorID.Location = new System.Drawing.Point(70, 364);
            this.label_maxauthorID.Name = "label_maxauthorID";
            this.label_maxauthorID.Size = new System.Drawing.Size(95, 13);
            this.label_maxauthorID.TabIndex = 29;
            this.label_maxauthorID.Text = "label_maxauthorID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 351);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(232, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "A legnagyobb AUTHOR ID az author táblában: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-3, 386);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(265, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "(a hozzáadás, adat generálás miatt van  itt feltűntetve:)";
            // 
            // label_maxBooksID
            // 
            this.label_maxBooksID.AutoSize = true;
            this.label_maxBooksID.Location = new System.Drawing.Point(40, 369);
            this.label_maxBooksID.Name = "label_maxBooksID";
            this.label_maxBooksID.Size = new System.Drawing.Size(41, 13);
            this.label_maxBooksID.TabIndex = 1;
            this.label_maxBooksID.Text = "label15";
            // 
            // bt_usersList
            // 
            this.bt_usersList.Location = new System.Drawing.Point(709, 390);
            this.bt_usersList.Name = "bt_usersList";
            this.bt_usersList.Size = new System.Drawing.Size(75, 23);
            this.bt_usersList.TabIndex = 1;
            this.bt_usersList.Text = "List";
            this.bt_usersList.UseVisualStyleBackColor = true;
            this.bt_usersList.Click += new System.EventHandler(this.bt_usersList_Click);
            // 
            // bt_register
            // 
            this.bt_register.Location = new System.Drawing.Point(547, 390);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(75, 23);
            this.bt_register.TabIndex = 1;
            this.bt_register.Text = "Register";
            this.bt_register.UseVisualStyleBackColor = true;
            this.bt_register.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // bt_user_list_delete
            // 
            this.bt_user_list_delete.Location = new System.Drawing.Point(628, 390);
            this.bt_user_list_delete.Name = "bt_user_list_delete";
            this.bt_user_list_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_user_list_delete.TabIndex = 1;
            this.bt_user_list_delete.Text = "Delete";
            this.bt_user_list_delete.UseVisualStyleBackColor = true;
            this.bt_user_list_delete.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tab_Author.ResumeLayout(false);
            this.tab_Author.PerformLayout();
            this.tab_Books.ResumeLayout(false);
            this.tab_Books.PerformLayout();
            this.tab_Borrows.ResumeLayout(false);
            this.tab_Borrows.PerformLayout();
            this.tab_Students.ResumeLayout(false);
            this.tab_Users.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Author;
        private System.Windows.Forms.ListBox author_List;
        private System.Windows.Forms.TabPage tab_Books;
        private System.Windows.Forms.TabPage tab_Borrows;
        private System.Windows.Forms.ListBox borrows_List;
        private System.Windows.Forms.TabPage tab_Students;
        private System.Windows.Forms.ListBox students_List;
        private System.Windows.Forms.TabPage tab_Users;
        private System.Windows.Forms.ListBox users_List;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_author_List;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_author_add_authorName;
        private System.Windows.Forms.TextBox tb_author_add_booksWritten;
        private System.Windows.Forms.Button bt_author_Add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_author_modify_authorID;
        private System.Windows.Forms.TextBox tb_author_modify_authorName;
        private System.Windows.Forms.TextBox tb_author_modify_booksWritten;
        private System.Windows.Forms.Button bt_author_modify;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_author_dummyData;
        private System.Windows.Forms.Button bt_author_dummyData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_books_N_Dummydata;
        private System.Windows.Forms.Button bt_books_dummyData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_books_bookId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_books_author_id;
        private System.Windows.Forms.TextBox tb_books_authorId;
        private System.Windows.Forms.TextBox tb_books_book_name;
        private System.Windows.Forms.TextBox tb_books_bookName;
        private System.Windows.Forms.Button bt_books_modify;
        private System.Windows.Forms.Button bt_books_Add;
        private System.Windows.Forms.Button bt_books_delete;
        private System.Windows.Forms.Button bt_books_list;
        private System.Windows.Forms.ListBox bookList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_maxauthorID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_maxBooksID;
        private System.Windows.Forms.Button bt_register;
        private System.Windows.Forms.Button bt_usersList;
        private System.Windows.Forms.Button bt_user_list_delete;
    }
}

