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

namespace Course_Managment.Student.Upd_del
{
    public partial class DelEnroll : Form
    {
        Student previous;
        int STUDID;
        public DelEnroll(Student form,int STUDID)
        {
            InitializeComponent();
            previous = form;
            this.STUDID = STUDID;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DelEnroll_Load(object sender, EventArgs e)
        {
           
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=CrsManagement;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlCommand validation = new SqlCommand();
            validation.Connection = connection;
            cmd.Connection = connection;

            connection.Open();

            ////validation for sid


            if (string.IsNullOrEmpty(CrsIDText.Text.Trim())
               )
            {
                MessageBox.Show("There are empty fields !!");
                return;
            }
           
            validation.CommandText = "SELECT COUNT(*) FROM STUDENT WHERE SID = '" + STUDID + "'";
            int studentExists = (int)validation.ExecuteScalar();

            if (studentExists == 0)
            {
                MessageBox.Show("Student ID does not exist.");
                return;
            }

            validation.CommandText = "SELECT COUNT(*) FROM COURSE WHERE CID = '" + CrsIDText.Text + "' AND ISHIDDEN = 0";
            int courseExists = (int)validation.ExecuteScalar();

            if (courseExists == 0)
            {
                MessageBox.Show("Course ID does not exist.");
                return;
            }

            validation.CommandText = "SELECT COUNT(*) FROM ENROLL_IN WHERE CID = '" + CrsIDText.Text + "' AND SID = '" + STUDID + "'";
            int registerd = (int)validation.ExecuteScalar();

            if (registerd == 0)
            {
                MessageBox.Show("That Registeration does not exist !!");
                return;
            }
            ////


            cmd.CommandText = "DELETE FROM ENROLL_IN WHERE SID = '" + STUDID + "' AND CID = '" 
                + CrsIDText.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Crs is deleted now !!");



        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            previous.Show();
            this.Close();
        }

        private void View_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ENROLL_IN WHERE SID = '" + STUDID
                + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, "Data Source=(local);Initial Catalog=CrsManagement;Integrated Security=True");
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGrid.DataSource = table;
        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }
    }
}
