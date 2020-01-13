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
    public partial class AssignTraining : Form
    {
        User UserType;
        List<AssignTrng> dgvlist;
        List<string> trainingds;
        public AssignTraining(User user)
        {
            UserType = user;
            Initialize();
        }
        public async void Initialize()
        {
            var asynctask1 = getSkills();
            InitializeComponent();
            skill_combo.DataSource = await asynctask1;
            trainee_combo.Items.Add("Expert");
            trainee_combo.Items.Add("Competitor");
            dgvlist = new List<AssignTrng>();
        }
        public async Task<List<string>> getSkills()
        {
            using (var db = new Session4Entities())
            {
                return (from s in db.Skills
                        orderby s.skillId
                        select s.skillName).ToList();
            }
        }
        public async Task<List<string>> getModule(int skillid, int usertype)
        {
            var returnlist = new List<string>();
            trainingds = new List<string>();
            using(var db = new Session4Entities())
            {
                var modules = (from m in db.Training_Module
                               where m.skillIdFK == skillid
                               where m.userTypeIdFK == usertype
                               select new { m.moduleId, m.moduleName, m.durationDays}).ToList();
                foreach (var item in modules)
                {
                    var stringa = item.moduleName;
                    returnlist.Add(stringa);
                    trainingds.Add(stringa);
                }
            }
            return returnlist;
        }

        private async void skill_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new Session4Entities())
            {
                training_box.DataSource = null;
                training_box.DataSource = await getModule((from a in db.Skills where a.skillId == skill_combo.SelectedIndex + 1 select a.skillId).First(), trainee_combo.SelectedIndex + 1);
            }
            
        }

        private void training_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private async void trainee_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new Session4Entities())
            {
                training_box.DataSource = null;
                training_box.DataSource = await getModule((from a in db.Skills where a.skillId == skill_combo.SelectedIndex + 1 select a.skillId).First(), trainee_combo.SelectedIndex + 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new MainMenu(UserType);
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
        private void updateDGV()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dgvlist;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (skill_combo.SelectedItem != null && trainee_combo.SelectedItem != null && training_box.SelectedItem != null)
            {


                using (var db = new Session4Entities())
                {
                    var ass = new AssignTrng()
                    {
                        Skill = skill_combo.SelectedItem.ToString(),
                        TraineeCategory = trainee_combo.SelectedItem.ToString(),
                        TrainingModule = training_box.SelectedItem.ToString()
                    };
                    if (!dgvlist.Contains(ass))
                    {
                        dgvlist.Add(ass);
                        updateDGV();
                    }
                }
            }
            else
            {
                MessageBox.Show("Error, One or more fields are empty. Failing to prepare is preparing to fail. Did you know that every 60 seconds in Africa a minute passes? Together we can stop this, just like the atrocity of this Session.");
            }
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            try
            {
                dgvlist.RemoveAt(dataGridView1.SelectedRows[0].Index);
                updateDGV();
            }
            catch
            {
                MessageBox.Show("Every 60 secods in Africa a Minute passes");
            }
        }

        private void assign_button_Click(object sender, EventArgs e)
        {
            using (var db = new Session4Entities()) {
                for (int i = 0; i < dgvlist.Count; i++)
                {
                    var currentmodule = dgvlist[i].TrainingModule;
                    var id = (from a in db.Training_Module
                              where a.moduleName == currentmodule
                              select a.moduleId).First();
                    var skill = dgvlist[i].Skill;
                    var currentskill = (from a in db.Skills where a.skillName == skill select a.skillId).First();
                    var people = (from b in db.Users
                                  where b.skillIdFK == currentskill
                                  select b.userId).ToList();
                    foreach (var item in people)
                    {

                        try
                        {

                            var ast = new Assign_Training()
                            {
                                moduleIdFK = id,
                                progress = 0,
                                startDate = DateTime.Now,
                                trainingId = (from a in db.Assign_Training orderby a.trainingId descending select a.trainingId).First() + 1,
                                userIdFK = item
                            };
                            db.Assign_Training.Add(ast);
                            db.SaveChanges();

                        }
                        catch
                        {
                            var ast = new Assign_Training()
                            {
                                moduleIdFK = id,
                                progress = 0,
                                startDate = DateTime.Now,
                                trainingId = 1,
                                userIdFK = item
                            };
                            db.Assign_Training.Add(ast);
                            db.SaveChanges();
                        }
                    }
                }
            }

        }
    }

    public class IDStringPair
    {
        public string aString { get; set; }
        public int aID { get; set; }
    }

    public class AssignTrng
    {
        public string Skill { get; set; }
        public string TraineeCategory { get; set; }
        public string TrainingModule { get; set; }
    }
       
    
}
