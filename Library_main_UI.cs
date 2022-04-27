using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Library_main_UI : Form
    {
        public Library_main_UI()
        {
            InitializeComponent();
            loadData();
        }

        DataClasses1DataContext context = new DataClasses1DataContext();

        private void studentMenagerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_UI student_UI = new Student_UI();
            student_UI.Tag = this;
            student_UI.Show(this);
            Hide();

          

          
        }

        private void Library_main_UI_Load(object sender, EventArgs e)
        {

        }



        void loadData()
        {
            var st = from b in context.borrower_details
                     join s in context.student_details
                     on b.borrower_id equals s.borrower_id
                     join bo in context.book_details
                     on b.id_book equals bo.id
                     select  new { 
                         b.id_book,
                         b.borrowed_from,
                         b.borrowed_to, 
                         b.returned, 
                         b.borrower_id,
                         s.student_name,
                         s.contact_number,
                         bo.book_title,
                         bo.category
                     };
            
            dataGridView1.DataSource = st;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //  borrower_details.id_book = dataGridView1.CurrentRow.Cells[0].Value.ToString();

        }

        private void SelectById_Click(object sender, EventArgs e)
        {
            try
            {
                var st = from s in context.borrower_details where s.borrower_id == int.Parse(textBox3.Text) select s;
                dataGridView1.DataSource = st;

                comboBox1.Text = st.First().returned;

            }
            catch (Exception)
            {
                MessageBox.Show("BOOK id not valide");
            }
        }

        private void bookManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            Book book_UI = new Book();
            book_UI.Tag = this;
            book_UI.Show(this);
            Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

              int borrower_id = int.Parse(borrowerIdTextBox.Text);
                int book_id = int.Parse(bookIdTextBox.Text);
                DateTime borrowed_from = DateTime.Parse(FromTimePicker.Text);
                DateTime borrowed_to = DateTime.Parse(ToTimePicker.Text);

                var st = new borrower_detail
                {
                    id_book = book_id,
                    borrowed_from = borrowed_from,
                    borrowed_to = borrowed_to,
                    returned = "NO",
                    borrower_id = borrower_id,
                };

                context.borrower_details.InsertOnSubmit(st);
                context.SubmitChanges();
                MessageBox.Show("Successfully Inserted bro");
                loadData();
               }
           catch (Exception ex)
             {
                 MessageBox.Show("collone vide ou (borrower id)/(book id) nexist pas , eseyer de remplire tout les colone correctement");
             }


        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            
            string returned = comboBox1.Text;

            var st = (from s in context.student_details where s.borrower_id == int.Parse(textBox3.Text) select s).First();


            st.borrower_details.First().returned = returned;
            
            context.SubmitChanges();

            MessageBox.Show("Student Successfully Updated");
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            var LoginForm = (LoginForm)Tag;
            LoginForm.Show();
            Close();
        }
    }
}

