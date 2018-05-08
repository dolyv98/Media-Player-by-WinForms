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

namespace WindowsFormsApp1
{
    public partial class ListeningHistory : Form
    {
        int Top;
        int MoveX;
        int MoveY;
        string connectionString = @"Data Source=DESKTOP-I4B3D6Q\SQLEXPRESS;Initial Catalog=Music_Player;Integrated Security=True";
        public ListeningHistory()
        {
            InitializeComponent();
        }
        //Display the history
        private void History_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Recent order by History DESC", connect);
                DataTable dttb = new DataTable();
                adapter.Fill(dttb);
                MusicDB.DataSource = dttb;
                MusicDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                connect.Close();
            }
        }
        // Delete history
        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Delete from Recent", con);
                DataTable dttb = new DataTable();
                adapter.Fill(dttb);
                MusicDB.DataSource = dttb;
                con.Close();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Top = 1;
            MoveX = e.X;
            MoveY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Top = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Top == 1)
            { this.SetDesktopLocation(MousePosition.X - MoveX, MousePosition.Y - MoveY); }
        }

        private void ExitBtn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
