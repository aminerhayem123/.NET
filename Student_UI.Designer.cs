namespace Library
{
    partial class Student_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_UI));
            this.student_name_textBox = new System.Windows.Forms.TextBox();
            this.contact_number_textBox = new System.Windows.Forms.TextBox();
            this.borrower_id_textBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.insert_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sex_comboBox = new System.Windows.Forms.ComboBox();
            this.departement_comboBox = new System.Windows.Forms.ComboBox();
            this.Ubdate = new System.Windows.Forms.Button();
            this.student_id = new System.Windows.Forms.TextBox();
            this.bibliothequeDataSet = new Library.BibliothequeDataSet();
            this.userdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_detailsTableAdapter = new Library.BibliothequeDataSetTableAdapters.user_detailsTableAdapter();
            this.bibliothequeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book_detailsTableAdapter = new Library.BibliothequeDataSetTableAdapters.book_detailsTableAdapter();
            this.search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.libraryMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Resete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookdetailsBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // student_name_textBox
            // 
            this.student_name_textBox.Location = new System.Drawing.Point(186, 135);
            this.student_name_textBox.Name = "student_name_textBox";
            this.student_name_textBox.Size = new System.Drawing.Size(100, 20);
            this.student_name_textBox.TabIndex = 8;
            // 
            // contact_number_textBox
            // 
            this.contact_number_textBox.Location = new System.Drawing.Point(186, 173);
            this.contact_number_textBox.MaxLength = 8;
            this.contact_number_textBox.Name = "contact_number_textBox";
            this.contact_number_textBox.Size = new System.Drawing.Size(100, 20);
            this.contact_number_textBox.TabIndex = 9;
            this.contact_number_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contact_number_textBox_KeyPress);
            // 
            // borrower_id_textBox
            // 
            this.borrower_id_textBox.Location = new System.Drawing.Point(601, 214);
            this.borrower_id_textBox.MaxLength = 9;
            this.borrower_id_textBox.Name = "borrower_id_textBox";
            this.borrower_id_textBox.Size = new System.Drawing.Size(100, 20);
            this.borrower_id_textBox.TabIndex = 14;
            this.borrower_id_textBox.TextChanged += new System.EventHandler(this.borrower_id_textBox_TextChanged);
            this.borrower_id_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.borrower_id_textBox_KeyPress);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(186, 214);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.dateTimePicker.TabIndex = 15;
            // 
            // insert_button
            // 
            this.insert_button.Location = new System.Drawing.Point(28, 269);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(75, 23);
            this.insert_button.TabIndex = 16;
            this.insert_button.Text = "Insert";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 150);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sex_comboBox
            // 
            this.sex_comboBox.FormattingEnabled = true;
            this.sex_comboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.sex_comboBox.Location = new System.Drawing.Point(601, 173);
            this.sex_comboBox.Name = "sex_comboBox";
            this.sex_comboBox.Size = new System.Drawing.Size(121, 21);
            this.sex_comboBox.TabIndex = 18;
            // 
            // departement_comboBox
            // 
            this.departement_comboBox.FormattingEnabled = true;
            this.departement_comboBox.Items.AddRange(new object[] {
            "Informatique",
            "Club"});
            this.departement_comboBox.Location = new System.Drawing.Point(601, 130);
            this.departement_comboBox.Name = "departement_comboBox";
            this.departement_comboBox.Size = new System.Drawing.Size(121, 21);
            this.departement_comboBox.TabIndex = 19;
            // 
            // Ubdate
            // 
            this.Ubdate.Location = new System.Drawing.Point(156, 269);
            this.Ubdate.Name = "Ubdate";
            this.Ubdate.Size = new System.Drawing.Size(75, 23);
            this.Ubdate.TabIndex = 20;
            this.Ubdate.Text = "Ubdate";
            this.Ubdate.UseVisualStyleBackColor = true;
            this.Ubdate.Click += new System.EventHandler(this.Ubdate_Click);
            // 
            // student_id
            // 
            this.student_id.Location = new System.Drawing.Point(76, 308);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(100, 20);
            this.student_id.TabIndex = 21;
            this.student_id.Visible = false;
            // 
            // bibliothequeDataSet
            // 
            this.bibliothequeDataSet.DataSetName = "BibliothequeDataSet";
            this.bibliothequeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userdetailsBindingSource
            // 
            this.userdetailsBindingSource.DataMember = "user_details";
            this.userdetailsBindingSource.DataSource = this.bibliothequeDataSet;
            // 
            // user_detailsTableAdapter
            // 
            this.user_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // bibliothequeDataSetBindingSource
            // 
            this.bibliothequeDataSetBindingSource.DataSource = this.bibliothequeDataSet;
            this.bibliothequeDataSetBindingSource.Position = 0;
            // 
            // bookdetailsBindingSource
            // 
            this.bookdetailsBindingSource.DataMember = "book_details";
            this.bookdetailsBindingSource.DataSource = this.bibliothequeDataSetBindingSource;
            // 
            // book_detailsTableAdapter
            // 
            this.book_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(720, 212);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 22;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(286, 269);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 23;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text", 19.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(303, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 35);
            this.label2.TabIndex = 24;
            this.label2.Text = "Student Manager";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(18, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Student name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(18, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Contact number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(18, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "Date of birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(431, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 28);
            this.label5.TabIndex = 28;
            this.label5.Text = "Departement";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(431, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 28);
            this.label6.TabIndex = 29;
            this.label6.Text = "Sexe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Text", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(431, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 28);
            this.label7.TabIndex = 30;
            this.label7.Text = "Borrower id";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libraryMainToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // libraryMainToolStripMenuItem
            // 
            this.libraryMainToolStripMenuItem.Name = "libraryMainToolStripMenuItem";
            this.libraryMainToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.libraryMainToolStripMenuItem.Text = "Library Main";
            this.libraryMainToolStripMenuItem.Click += new System.EventHandler(this.libraryMainToolStripMenuItem_Click);
            // 
            // Resete
            // 
            this.Resete.Location = new System.Drawing.Point(28, 490);
            this.Resete.Name = "Resete";
            this.Resete.Size = new System.Drawing.Size(75, 23);
            this.Resete.TabIndex = 32;
            this.Resete.Text = "Resete";
            this.Resete.UseVisualStyleBackColor = true;
            this.Resete.Click += new System.EventHandler(this.Resete_Click);
            // 
            // Student_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.istockphoto_543350202_612x612;
            this.ClientSize = new System.Drawing.Size(838, 574);
            this.Controls.Add(this.Resete);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.search);
            this.Controls.Add(this.student_id);
            this.Controls.Add(this.Ubdate);
            this.Controls.Add(this.departement_comboBox);
            this.Controls.Add(this.sex_comboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.borrower_id_textBox);
            this.Controls.Add(this.contact_number_textBox);
            this.Controls.Add(this.student_name_textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Student_UI";
            this.Text = "Student UI";
            this.Load += new System.EventHandler(this.Student_UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookdetailsBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox student_name_textBox;
        private System.Windows.Forms.TextBox contact_number_textBox;
        private System.Windows.Forms.TextBox borrower_id_textBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox sex_comboBox;
        private System.Windows.Forms.ComboBox departement_comboBox;
        private System.Windows.Forms.Button Ubdate;
        private System.Windows.Forms.TextBox student_id;
        private BibliothequeDataSet bibliothequeDataSet;
        private System.Windows.Forms.BindingSource userdetailsBindingSource;
        private BibliothequeDataSetTableAdapters.user_detailsTableAdapter user_detailsTableAdapter;
        private System.Windows.Forms.BindingSource bibliothequeDataSetBindingSource;
        private System.Windows.Forms.BindingSource bookdetailsBindingSource;
        private BibliothequeDataSetTableAdapters.book_detailsTableAdapter book_detailsTableAdapter;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem libraryMainToolStripMenuItem;
        private System.Windows.Forms.Button Resete;
    }
}