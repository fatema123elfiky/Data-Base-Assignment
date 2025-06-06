﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Managment.Student.Adds
{
    public partial class AddEnroll : Form
    {
        Student previous;
        int id;
        public AddEnroll(Student form,int id)
        {
            InitializeComponent();
            previous = form;
            this.id = id;
        }

        private void AddEnroll_Load(object sender, EventArgs e)
        {
        }

        private void View_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ENROLL_IN WHERE SID = '" + id
                 + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, "Data Source=(local);Initial Catalog=CrsManagement;Integrated Security=True");
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            previous.Show();
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=CrsManagement;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlCommand validation =new SqlCommand();
            validation.Connection = connection;
            cmd.Connection = connection;
           
            connection.Open();

            ////validation for sid
            
            
            if (string.IsNullOrEmpty(CrsIDText.Text.Trim())||
                string.IsNullOrEmpty(SemesterText.Text.Trim())||
                string.IsNullOrEmpty(YearText.Text.Trim()))
            {
                MessageBox.Show("There are empty fields !!");
                return;
            }
         

 

            validation.CommandText = "SELECT COUNT(*) FROM COURSE WHERE CID = '" + CrsIDText.Text + "'AND ISHIDDEN = 0";
            int courseExists = (int)validation.ExecuteScalar();

            if (courseExists == 0)
            {
                MessageBox.Show("Course ID does not exist.");
                return;
            }

            validation.CommandText = "SELECT COUNT(*) FROM ENROLL_IN WHERE CID = '" + CrsIDText.Text + "' AND SID = '"+id+"'";
            int registerd = (int)validation.ExecuteScalar();

            if (registerd != 0)
            {
                MessageBox.Show("That Registeration exists.");
                return;
            }
            ////


            cmd.CommandText = "Insert into ENROLL_IN (SID,CID,SEMESTER ,YEAR ) values (" + id + "," + CrsIDText.Text.Trim() + ",'"
                              + SemesterText.Text.Trim() + "','" + YearText.Text.Trim() + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("You enrolled now");



        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Year_Click(object sender, EventArgs e)
        {

        }
    }
}
