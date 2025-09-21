using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;

namespace E_Learning_system
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCourseID.Text))
                {
                    MessageBox.Show("Please enter Course ID");
                    return;
                }
                if (!int.TryParse(txtCredits.Text, out int creditsValue))
                {
                    MessageBox.Show("Please enter a valid number for Credits");
                    return;
                }

                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-UG1MIDI;Initial Catalog=ElearningDB;Integrated Security=True;Trust Server Certificate=True"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Courses SET CourseCode=@CourseCode, CourseName=@CourseName, Semester=@Semester, Credits=@Credits, Instructor=@Instructor, Description=@Description " +
                        "WHERE CourseID=@CourseID", con);

                    cmd.Parameters.AddWithValue("@CourseID", int.Parse(txtCourseID.Text));
                    cmd.Parameters.AddWithValue("@CourseCode", txtCourseCode.Text);
                    cmd.Parameters.AddWithValue("@CourseName", txtCourseName.Text);
                    cmd.Parameters.AddWithValue("@Semester", txtSemester.Text);
                    cmd.Parameters.Add("@Credits", SqlDbType.Int).Value = creditsValue;
                    cmd.Parameters.AddWithValue("@Instructor", txtInstructor.Text);
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Update Successfully");
                        button4_Click(null, null); 
                    }
                    else
                    {
                        MessageBox.Show("No record found to update");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtCourseID.Text))
                {
                    MessageBox.Show("Please enter Course ID");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtCourseCode.Text))
                {
                    MessageBox.Show("Please enter Course Code");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtCourseName.Text))
                {
                    MessageBox.Show("Please enter Course Name");
                    return;
                }
                if (!int.TryParse(txtCredits.Text, out int creditsValue))
                {
                    MessageBox.Show("Please enter a valid number for Credits");
                    return;
                }

                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-UG1MIDI;Initial Catalog=ElearningDB;Integrated Security=True;Trust Server Certificate=True"))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Courses (CourseID, CourseCode, CourseName, Semester, Credits, Instructor, Description) " +
                        "VALUES (@CourseID, @CourseCode, @CourseName, @Semester, @Credits, @Instructor, @Description)", con);

                  
                    cmd.Parameters.AddWithValue("@CourseID", int.Parse(txtCourseID.Text));
                    cmd.Parameters.AddWithValue("@CourseCode", txtCourseCode.Text);
                    cmd.Parameters.AddWithValue("@CourseName", txtCourseName.Text);
                    cmd.Parameters.AddWithValue("@Semester", txtSemester.Text);
                    cmd.Parameters.AddWithValue("@Credits", creditsValue);
                    cmd.Parameters.AddWithValue("@Instructor", txtInstructor.Text);
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text);

                    
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Insert Successfully");
                    button4_Click(null, null);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtCourseID.Text))
                {
                    MessageBox.Show("Please enter Course ID");
                    return;
                }

                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-UG1MIDI;Initial Catalog=ElearningDB;Integrated Security=True;Trust Server Certificate=True"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Courses WHERE CourseID=@CourseID", con);
                    cmd.Parameters.AddWithValue("@CourseID", int.Parse(txtCourseID.Text));

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        MessageBox.Show("Delete Successfully");
                    else
                        MessageBox.Show("No record found to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-UG1MIDI;Initial Catalog=ElearningDB;Integrated Security=True;Trust Server Certificate=True"))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Courses", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                   
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No courses found in database");
                        return;
                    }

                    
                    dataGridViewCourses = this.Controls.Find("dataGridViewCourses", true).FirstOrDefault() as DataGridView;

                    if (dataGridViewCourses != null)
                    {
                        dataGridViewCourses.DataSource = dt;
                        MessageBox.Show($"Loaded {dt.Rows.Count} courses successfully");
                    }
                    else
                    {
                        MessageBox.Show("DataGridView not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}