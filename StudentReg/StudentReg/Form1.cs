using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentReg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadData();
        }

        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=StudentDB;Integrated Security=True");
        SqlCommand cmd;
        bool mode = true;
        SqlDataReader read;
        string sql;
        string id;

        private void loadData()
        {
            try
            {
                sql = "select * from Student";
                con.Open();
                cmd = new SqlCommand(sql, con);
                read = cmd.ExecuteReader();
                loadDetailsGV.Rows.Clear();
                while (read.Read())
                {
                    loadDetailsGV.Rows.Add(read[0], read[1], read[2], read[3]);
                }
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void getID(string id)
        {
            try
            {
                sql = "select * from Student where student_id='"+id+"'";
                con.Open();
                cmd = new SqlCommand(sql, con);
                read = cmd.ExecuteReader();
                while (read.Read())
                {
                    nameText.Text = read[1].ToString();
                    courceText.Text = read[2].ToString();
                    feesText.Text = read[3].ToString();
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string studentName = nameText.Text;
            string studnetCource = courceText.Text;
            string studentFees = feesText.Text;
            if (mode)
            {
                try
                {
                    if(studentFees !="" && studentName !="" && studnetCource != "")
                    {
                        sql = "insert into Student(student_name,student_cource,student_fees) values (@studentName,@studnetCource,@studentFees) ";
                        con.Open();
                        cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@studentName", studentName);
                        cmd.Parameters.AddWithValue("@studnetCource", studnetCource);
                        cmd.Parameters.AddWithValue("@studentFees", studentFees);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Added");
                        nameText.Clear();
                        courceText.Clear();
                        feesText.Clear();
                        nameText.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Plz Enter Data");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                try
                {
                    //sql = "insert into Student(student_name,student_cource,student_fees) values (@studentName,@studnetCource,@studentFees) ";
                    sql = "update Student set student_name=@studentName,student_cource=@studnetCource,student_fees=@studentFees where student_id=@id";
                    con.Open();
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@studentName", studentName);
                    cmd.Parameters.AddWithValue("@studnetCource", studnetCource);
                    cmd.Parameters.AddWithValue("@studentFees", studentFees);
                    cmd.Parameters.AddWithValue("@id",id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated");
                    nameText.Clear();
                    courceText.Clear();
                    feesText.Clear();
                    nameText.Focus();
                    mode = true;
                    saveButton.Text = "Save";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            con.Close();
            loadData();
        }

        private void loadDetailsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==loadDetailsGV.Columns["EditID"].Index && e.RowIndex >= 0)
            {
                mode = false;
                id = loadDetailsGV.CurrentRow.Cells[0].Value.ToString();
                getID(id);
                saveButton.Text = "Edit";
            }
            if(e.ColumnIndex == loadDetailsGV.Columns["DeleteID"].Index && e.RowIndex >= 0)
            {
                try
                {
                    //mode = false;
                    id = loadDetailsGV.CurrentRow.Cells[0].Value.ToString();
                    sql = "delete from student where student_id=@id";
                    con.Open();
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted");
                    loadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
             
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameText.Clear();
            courceText.Clear();
            feesText.Clear();
            nameText.Focus();
            mode = true;
            saveButton.Text = "Save";
        }
    }
}
