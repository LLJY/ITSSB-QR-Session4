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
    public partial class UpdateExpert : Form
    {
        List<TrainingUpdate> dgvlist = new List<TrainingUpdate>();
        User LoggedInUser;
        public UpdateExpert(User user)
        {
            LoggedInUser = user;
            Initialize();
        }
        private async void Initialize()
        {
            var asynctask = GetSkills();
            InitializeComponent();
            skill_combo.DataSource = await asynctask;
        }
        public async Task<List<string>> GetSkills()
        {
            using (var db = new Session4Entities())
            {
                return (from s in db.Skills
                        orderby s.skillId
                        select s.skillName).ToList();
            }
        }
        public async Task<List<string>> GetCompetitors()
        {
            using (var db = new Session4Entities())
            {
                var skillid = (from a in db.Skills where a.skillName == skill_combo.SelectedItem.ToString() select a.skillId).First();
                return (from c in db.Users
                        where c.skillIdFK == skillid
                        where c.userTypeIdFK == 2
                        select c.name).ToList();
            }
        }

        private void UpdateExpert_Load(object sender, EventArgs e)
        {

        }
        public async void UpdateUI()
        {
            try
            {
                using (var db = new Session4Entities())
                {

                    dgvlist.Clear();
                    var recordsid = (from a in db.Users where a.name == name_combo.SelectedItem.ToString() select a.userId).First();
                    var modules = (from a in db.Assign_Training
                                   where a.userIdFK == recordsid
                                   where a.User.userTypeIdFK == 2
                                   select a);
                    foreach (var item in modules)
                    {
                        var TU = new TrainingUpdate()
                        {
                            ID = item.trainingId,
                            TrainingModule = item.Training_Module.moduleName,
                            Duration = item.Training_Module.durationDays,
                            StartDate = item.startDate,
                            EstimatedEndDate = item.startDate + TimeSpan.FromDays(item.Training_Module.durationDays),
                            Progress = item.progress
                        };
                        dgvlist.Add(TU);
                    }
                    var skillid = (from a in db.Skills where a.skillName == skill_combo.SelectedItem.ToString() select a.skillId).First();

                    if (name_check.Checked)
                    {
                        dgvlist = (from m in dgvlist
                                   orderby m.TrainingModule
                                   select m).ToList();
                    }
                    if (date_check.Checked)
                    {
                        dgvlist = (from m in dgvlist
                                   orderby m.EstimatedEndDate ascending
                                   select m).ToList();
                    }
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = dgvlist;
                }
            }
            catch
            {

            }
        }

        private async void skill_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
            name_combo.DataSource = await GetCompetitors();
        }

        private void name_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void name_check_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void date_check_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            using (var db = new Session4Entities())
            {
                foreach (var item in dgvlist)
                {
                    var assign = (from a in db.Assign_Training
                                  where a.trainingId == item.ID
                                  select a).First();
                    assign.progress = item.Progress;
                }
                db.SaveChanges();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) > 100)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 100;
            }
            if (int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()) > dgvlist[e.RowIndex].Progress)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dgvlist[e.RowIndex].Progress;
            }
            else
            {
                dgvlist[e.RowIndex].Progress = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new MainMenu(LoggedInUser);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if(int.Parse(item.Cells[5].Value.ToString()) != 100){
                    if ((DateTime.Parse(item.Cells[4].Value.ToString()) - DateTime.Now) < TimeSpan.FromDays(5))
                    {
                        item.DefaultCellStyle.BackColor = Color.Red;
                    } else if ((DateTime.Parse(item.Cells[4].Value.ToString()) - DateTime.Now) <= TimeSpan.FromDays(14))
                    {
                        item.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
            }
        }
    }
}
