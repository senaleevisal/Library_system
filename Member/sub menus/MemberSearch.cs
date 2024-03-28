using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.Member.sub_menus
{
    public partial class MemberSearch : UserControl
    {
        public MemberSearch()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SQL sql = new SQL();
            using (SqlConnection conn = SQL.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Members WHERE member_id = @MemberID", conn))
                    {
                        // Use parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@MemberID", memberID.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // If there is at least one row
                            {
                                name.ResetText();
                                name.AppendText(reader[1].ToString());
                                age.ResetText();
                                age.AppendText(reader[2].ToString());
                                email.ResetText();
                                email.AppendText(reader[3].ToString());
                                number.ResetText();
                                number.AppendText(reader[4].ToString());
                            }
                            else
                            {
                                MessageBox.Show("No member found with the given ID.");
                                // Optionally, clear the text boxes here if no member is found
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while connecting to the database: " + ex.Message);
                }
                finally
                {
                    // Ensure the connection is closed even if an exception occurs
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void MemberSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
