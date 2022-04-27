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
    public partial class Student_UI : Form
    {
        public Student_UI()
        {
            InitializeComponent();
            loadData();
        }
        DataClasses1DataContext context = new DataClasses1DataContext();

        private void insert_button_Click(object sender, EventArgs e)
        {
            try
            {

                string student_name = student_name_textBox.Text;
                int contact_number = int.Parse(contact_number_textBox.Text);
               
                DateTime date_of_birth = DateTime.Parse(dateTimePicker.Text);
                string departement = departement_comboBox.Text;
                string sex = sex_comboBox.Text;

                var st = new student_detail
                {

                    student_name = student_name,
                    contact_number = contact_number,
                    date_of_birth = date_of_birth,
                    departement = departement,
                    sex = sex,
              
                };





                context.student_details.InsertOnSubmit(st);
                context.SubmitChanges();
                MessageBox.Show("Successfully Inserted bro");

                loadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("collone vide ou borrower id deja existe, eseyer de remplire tout les colone correctement");
            }
            
        }
            
        

        void loadData()
        {
            

            var st = from s in context.student_details select s;
            dataGridView1.DataSource = st;
        }

        private void Ubdate_Click(object sender, EventArgs e)
        {
            try
            {
                int borrower_id = int.Parse(borrower_id_textBox.Text);
                string student_name = student_name_textBox.Text;
                int contact_number = int.Parse(contact_number_textBox.Text);
                DateTime date_of_birth = DateTime.Parse(dateTimePicker.Text);
                string departement = departement_comboBox.Text;
                string sex = sex_comboBox.Text;

                var st = (from s in context.student_details where s.borrower_id == borrower_id select s).First();


                st.student_name = student_name;
                st.contact_number = contact_number;
                st.date_of_birth = date_of_birth;
                st.departement = departement;
                st.sex = sex;
                st.borrower_id = borrower_id;
                context.SubmitChanges();

                MessageBox.Show("Student Successfully Updated");
            }catch(Exception ex)
            {
                MessageBox.Show("Borrower id alredy exist");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

      /*  var st = from s in context.student_details where s.borrower_id == int.Parse(borrower_id_textBox.Text) select s;

        dataGridView1.DataSource = st;
      */
        private void Student_UI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliothequeDataSet.book_details' table. You can move, or remove it, as needed.
        //    this.book_detailsTableAdapter.Fill(this.bibliothequeDataSet.book_details);
            // TODO: This line of code loads data into the 'bibliothequeDataSet.user_details' table. You can move, or remove it, as needed.
          //  this.user_detailsTableAdapter.Fill(this.bibliothequeDataSet.user_details);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                var st = from s in context.student_details where s.borrower_id == int.Parse(borrower_id_textBox.Text) select s;

                dataGridView1.DataSource = st;
            }catch (Exception ex)
            {
                MessageBox.Show("Student Borrow id not valide");
            }
            }

        private void Delete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to delete?", "Delete Student", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    var st = (from s in context.student_details where s.borrower_id == int.Parse(borrower_id_textBox.Text) select s).First();
                    context.student_details.DeleteOnSubmit(st);

                    context.SubmitChanges();
                    MessageBox.Show("Student Delete sucssesfully");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show("Student Borrow id not valide"); }
                
                
               
            }
        }

        private void borrower_id_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void libraryMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            var Library_main_UI = (Library_main_UI)Tag;
            Library_main_UI.Show();
            Close();
        }

        private void bookManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book book_UI = new Book();
            book_UI.Tag = this;
            book_UI.Show(this);
            Hide();
        }

        private void contact_number_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void borrower_id_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Resete_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
