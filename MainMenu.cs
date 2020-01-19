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
    public partial class MainMenu : Form
    {
        User LoggedIn;
        public MainMenu(User user)
        {
            LoggedIn = user; 
            InitializeComponent();
            if (LoggedIn.userTypeIdFK == 2)
            {
                label2.Text = "Expert Main Menu";
                assign_update.Text = "Update Expert Training Records";
                progress_check.Text = "Track Competitor Training Progress";
            }
        }

        private void assign_update_Click(object sender, EventArgs e)
        {
            if (LoggedIn.userTypeIdFK == 1)
            {
                this.Hide();
                var form = new AssignTraining(LoggedIn);
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
            else
            {
            }
        }

        private void progress_check_Click(object sender, EventArgs e)
        {
            if (LoggedIn.userTypeIdFK == 2)
            {
                this.Hide();
                var form = new TrackCompetitor(LoggedIn);
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new LoginPage();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}
