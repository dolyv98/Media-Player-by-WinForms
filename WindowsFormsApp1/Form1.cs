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
	public partial class Form1 : Form
	{
		string connectionString = @"Data Source=DESKTOP-I4B3D6Q\SQLEXPRESS;Initial Catalog=Music_Player;Integrated Security=True";
		public Form1()
		{
			InitializeComponent();
		}
		string[] paths, files;
		int Top;
		int MoveX;
		int MoveY;

		// Open previous song
		private void PreBtn_Click(object sender, EventArgs e)
		{
			if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
			{ if (Playing.SelectedIndex == 0)
				{ Playing.SelectedIndex = 0;
					Playing.Update();
				}
				else { MediaPlayer.Ctlcontrols.previous();
					Playing.SelectedIndex -= 1;
					Playing.Update();
				}
			}
		}

		// Play the music
		private void PlayBtn_Click(object sender, EventArgs e)
		{
            if(MediaPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                MediaPlayer.Ctlcontrols.play();
            }
			Playing.SelectedIndex = 0;
			MediaPlayer.Ctlcontrols.play();

		}

		// Pause
		private void PauseBtn_Click(object sender, EventArgs e)
		{
			if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
			{ MediaPlayer.Ctlcontrols.play(); }
			else
			{ MediaPlayer.Ctlcontrols.pause(); }
		}

		// Stop the music
		private void StopBtn_Click(object sender, EventArgs e)
		{
			MediaPlayer.Ctlcontrols.stop();
		}

		// Open next song
		private void NextBtn_Click(object sender, EventArgs e)
		{
			if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
			{
				if (Playing.SelectedIndex < (Playing.Items.Count - 1))

				{
					MediaPlayer.Ctlcontrols.next();
					Playing.SelectedIndex += 1;
					Playing.Update();
				}
				else
				{
					Playing.SelectedIndex = 0;
					Playing.Update();
				}

			}
		}
		// Play the music when click play button
		private void Playing_SelectedIndexChanged(object sender, EventArgs e)
		{
			MediaPlayer.URL = paths[Playing.SelectedIndex];
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				string query = @"insert into Recent (Title, History) values (@ThamSo1,@Thamso2)";
				SqlCommand cmd = new SqlCommand(query, con);
				cmd.Parameters.Add("@ThamSo1", SqlDbType.NVarChar, 20).Value = MediaPlayer.URL;
                cmd.Parameters.Add("@ThamSo2", SqlDbType.DateTime, 50).Value = DateTime.Now.ToString();
                con.Open();
				cmd.ExecuteNonQuery();
                con.Close();
            }
            MediaPlayer.settings.volume = Volumspeed.Value;
        }
        // Set Mute Volume
        private void MuteVolumeBtn_Click(object sender, EventArgs e)
		{
			if (MediaPlayer.settings.volume != 0)
			{ MediaPlayer.settings.volume = 0; }
			else
			{ MediaPlayer.settings.volume = 100; }
		}

		// Full Screen
		private void FullScreenBtn_Click(object sender, EventArgs e)
		{
			if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
			{ MediaPlayer.fullScreen = true; }
			else
			{ MediaPlayer.fullScreen = false; }
		}
		
		// Move the app everywhere on the screen
		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			Top = 1;
			MoveX = e.X;
			MoveY = e.Y;
		}

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			if (Top == 1)
			{ this.SetDesktopLocation(MousePosition.X - MoveX, MousePosition.Y - MoveY); }
		}

		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			Top = 0;
		}

		// Minimized the app
		private void MinBtn_Click(object sender, EventArgs e)
		{
			FormBorderStyle = FormBorderStyle.None;
			WindowState = FormWindowState.Minimized;
		}
		// FullScreen
		private void MaxBtn_Click(object sender, EventArgs e)
		{
			if (MediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
			{ MediaPlayer.fullScreen = true; }
			else
			{ MediaPlayer.fullScreen = false; }
		}

		// Close the app
		private void ExitBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Move the app everywhere on the screen
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
		// Conennecting to database  SQL-Server by Windows Authentication
		private void recentbtn_Click(object sender, EventArgs e)
		{
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				con.Open();
				SqlDataAdapter adapter = new SqlDataAdapter("select * from Recent order by History DESC", con);
				DataTable dttb = new DataTable();
				adapter.Fill(dttb);
				MusicDB.DataSource = dttb;
			}
		}
        //Delete listening history
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Delete from Recent", con);
                DataTable dttb = new DataTable();
                adapter.Fill(dttb);
                MusicDB.DataSource = dttb;
            }

        }
        //Setting volume
        private void Volumspeed_Scroll(object sender, EventArgs e)
        {
            int rate = 100 * (Volumspeed.Value - 10);
            MediaPlayer.settings.volume = Volumspeed.Value;
        }


        // Browse new music
        private void OpenBtn_Click(object sender, EventArgs e)
        {
            string userName = System.Environment.UserName;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\" + userName + "\\Documents\\MyMusic";
            ofd.Filter = "(mp3.wav,mp4,mov,wmv,mog,avi,3gp,flv)|*.mp3;*.wav;*.3gp;*avi;*.mov;*flv;*.wmv;*.mpg| All files |*.*";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    Playing.Items.Add(files[i]);
                }
				
			}
			Playing.Update();
			PlayBtn_Click(null, null);	
		}
    }

}
