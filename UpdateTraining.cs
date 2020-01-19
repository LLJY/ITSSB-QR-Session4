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
    public partial class UpdateTraining : Form
    {
        List<TrainingUpdate> dgvlist = new List<TrainingUpdate>();
        public UpdateTraining()
        {
            Initialize();
        }
        private async void Initialize()
        {
            var asynctask = GetSkills(); 
            InitializeComponent();
            skill_combo.DataSource = await asynctask;
            progress_box.Items.Add("Not Started");
            progress_box.Items.Add("In Progress");
            progress_box.Items.Add("Completed");
            //set default item
            progress_box.SelectedItem = "Not Started";
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
                                   where a.User.userTypeIdFK == 3
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
                    if (!string.IsNullOrWhiteSpace(search_box.Text))
                    {
                        dgvlist = (from m in dgvlist
                                   where m.TrainingModule.Contains(search_box.Text)
                                   select m).ToList();
                    }
                    if (progress_box.SelectedItem.ToString().Equals("Not Started"))
                    {
                        dgvlist = (from m in dgvlist
                                   where m.Progress == 0
                                   select m).ToList();
                    }
                    else if (progress_box.SelectedItem.ToString().Equals("In Progress"))
                    {
                        dgvlist = (from m in dgvlist
                                   where m.Progress > 0
                                   select m).ToList();
                    }
                    else if (progress_box.SelectedItem.ToString().Equals("Completed"))
                    {
                        dgvlist = (from m in dgvlist
                                   where m.Progress == 100
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
                        where c.userTypeIdFK == 3
                        select c.name).ToList();
            }
        }
        private void name_check_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private async void skill_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
            name_combo.DataSource = await GetCompetitors();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //searchbox
            UpdateUI();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new LoginPage();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
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
    }
    public class TrainingUpdate
    {
        public int ID { get; set; }
        public string TrainingModule { get; set; }
        public int Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EstimatedEndDate { get; set; }
        public int Progress { get; set; }
    }
}
