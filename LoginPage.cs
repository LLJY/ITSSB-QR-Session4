using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session4
{
    public partial class LoginPage : Form
    {
        List<User> CsvImported = new List<User>();
        public LoginPage()
        {
            InitializeComponent();
            var dt = (DateTime.Parse("July 26 2020 9am") - DateTime.Now);
        label6.Text = $"{Math.Floor(dt.TotalDays)} days {Math.Floor((dt - TimeSpan.FromDays(Math.Floor(dt.TotalDays))).TotalHours)} hours and {Math.Floor((dt - TimeSpan.FromHours(Math.Floor(dt.TotalHours))).TotalMinutes)} minutes until the event starts";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            using (var db = new Session4Entities()) {
                try
                {
                    var user = (from a in db.Users
                                where a.userId == user_box.Text
                                where a.passwd == password_box.Text
                                select a).First();
                    switch (user.userTypeIdFK)
                    {
                        case 1:
                            this.Hide();
                            var form = new MainMenu(user);
                            form.Closed += (s, args) => this.Close();
                            form.Show();
                            break;
                        case 2:
                            this.Hide();
                            var form1 = new MainMenu(user);
                            form1.Closed += (s, args) => this.Close();
                            form1.Show();
                            break;
                        case 3:
                            this.Hide();
                            var form2 = new UpdateTraining();
                            form2.Closed += (s, args) => this.Close();
                            form2.Show();
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid Login");
                }
            }
        }

        private void csv_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 1,
                CheckFileExists = true,
                CheckPathExists = true
            };
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = ofd.FileName;
                var list = File.ReadAllLines(ofd.FileName)
                    .Skip(1)
                    .Select(a => a.Split(','))
                    .Select(a => new User()
                    {
                        userId = a[0].Trim(),
                        skillIdFK = int.Parse(a[1]),
                        passwd = a[2].Trim(),
                        name = a[3].Trim(),
                        userTypeIdFK = int.Parse(a[4])
                    }
                    ).ToList();
                using (var db = new Session4Entities())
                {
                    foreach (var item in list)
                    {
                        db.Users.Add(item);
                    }
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("No file was selected, Aborting!");
            }
        }
    }
}
