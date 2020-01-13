using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session4
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            label6.Text = $"{ (DateTime.Parse("July 26 2020 9am")- DateTime.Now).TotalDays.ToString()} Days to go.";
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
                            //fdfg
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid Login");
                }
            }
        }
    }
}
