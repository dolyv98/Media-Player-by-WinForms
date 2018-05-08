namespace WindowsFormsApp1
{
    partial class ListeningHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeningHistory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitBtn1 = new System.Windows.Forms.Button();
            this.MusicDB = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusicDB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(139)))), ((int)(((byte)(115)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ExitBtn1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 29);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // ExitBtn1
            // 
            this.ExitBtn1.FlatAppearance.BorderSize = 0;
            this.ExitBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn1.Image = global::WindowsFormsApp1.Properties.Resources.cancel__2_;
            this.ExitBtn1.Location = new System.Drawing.Point(827, -1);
            this.ExitBtn1.Name = "ExitBtn1";
            this.ExitBtn1.Size = new System.Drawing.Size(29, 29);
            this.ExitBtn1.TabIndex = 9;
            this.ExitBtn1.UseVisualStyleBackColor = true;
            this.ExitBtn1.Click += new System.EventHandler(this.ExitBtn1_Click);
            // 
            // MusicDB
            // 
            this.MusicDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MusicDB.Location = new System.Drawing.Point(2, 29);
            this.MusicDB.Name = "MusicDB";
            this.MusicDB.Size = new System.Drawing.Size(861, 370);
            this.MusicDB.TabIndex = 2;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(139)))), ((int)(((byte)(115)))));
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            this.DeleteBtn.Location = new System.Drawing.Point(443, 405);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(276, 35);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "Delete History";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click_1);
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(139)))), ((int)(((byte)(115)))));
            this.History.FlatAppearance.BorderSize = 0;
            this.History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.History.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold);
            this.History.Location = new System.Drawing.Point(161, 405);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(276, 35);
            this.History.TabIndex = 10;
            this.History.Text = " History";
            this.History.UseVisualStyleBackColor = false;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // ListeningHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.History);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.MusicDB);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListeningHistory";
            this.Text = "Music";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MusicDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitBtn1;
        private System.Windows.Forms.DataGridView MusicDB;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button History;
    }
}