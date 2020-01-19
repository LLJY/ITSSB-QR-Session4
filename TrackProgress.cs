using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session4
{
    public partial class TrackProgress : Form
    {
        User LoggedInUser;
        public TrackProgress(User user)
        {
            LoggedInUser = user;
            Initialize();
        }
        public async void Initialize()
        {
            var asynctask1 = GetSkills();
            InitializeComponent();
            skill_combo.DataSource = await asynctask1;
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
        private void GetInfo()
        {
            //clear everything first
            expert_dgv.Columns.Clear();
            trainee_dgv.Columns.Clear();
            completedtraining_dgv.Columns.Clear();
            chart1.Series.Clear();
            chart1.Series.Add($"Completed");
            chart1.Series[$"Completed"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series.Add($"In Progress");
            chart1.Series[$"In Progress"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series.Add($"Not Started");
            chart1.Series[$"Not Started"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            using (var db = new Session4Entities())
            {
                //get expert dgv first
                //get number of modules in total
                var selectedskill = skill_combo.SelectedItem.ToString();
                var skillid = (from a in db.Skills where a.skillName == selectedskill select a.skillId).First();
                var expmodules = (from m in db.Training_Module
                                  where m.skillIdFK == skillid
                                  where m.userTypeIdFK == 2
                                  select m);
                var expassigned = (from m in db.Assign_Training
                                   where m.Training_Module.skillIdFK == skillid
                                   where m.Training_Module.userTypeIdFK == 2
                                   group m by m.Training_Module.moduleName into u
                                   select new
                                   {
                                       keyword = u.Key,
                                       progress = u.Select(c => c.progress)
                                   });
                expert_dgv.Columns.Add("StatusCol", "Status (Experts)");
                expert_dgv.Rows.Add("Completed");
                expert_dgv.Rows.Add("InProgress");
                expert_dgv.Rows.Add("NotStarted");
                expert_dgv.Rows[0].Cells[0].Value = "Completed";
                expert_dgv.Rows[1].Cells[0].Value = "In Progress";
                expert_dgv.Rows[2].Cells[0].Value = "Not Started";
                trainee_dgv.Columns.Add("StatusCol", "Status (Competitiors)");
                trainee_dgv.Rows.Add("Completed");
                trainee_dgv.Rows.Add("InProgress");
                trainee_dgv.Rows.Add("NotStarted");
                trainee_dgv.Rows[0].Cells[0].Value = "Completed";
                trainee_dgv.Rows[1].Cells[0].Value = "In Progress";
                trainee_dgv.Rows[2].Cells[0].Value = "Not Started";
                completedtraining_dgv.Columns.Add("Category Column", "Trainee Category");
                completedtraining_dgv.Rows.Add("Competitor");
                completedtraining_dgv.Rows.Add("Expert");
                foreach (var item in expmodules)
                {
                    int completed = 0;
                    int inprog = 0;
                    int notstart = 0;
                    expert_dgv.Columns.Add($"Column{item.moduleId}", $"{item.moduleName}");
                    var module = (from e in expassigned
                                  where e.keyword == item.moduleName
                                  select e);
                    foreach (var item1 in module)
                    {
                        foreach (var item2 in item1.progress)
                        {
                            if (item2 == 100)
                            {
                                completed += 1;
                            }
                            else if (item2 > 0)
                            {
                                inprog += 1;
                            }
                            else if (item2 == 0)
                            {
                                notstart += 1;
                            }
                        }
                    }
                    var cellind = expert_dgv.Columns[$"Column{item.moduleId}"].Index;
                    expert_dgv.Rows[0].Cells[cellind].Value = completed;
                    expert_dgv.Rows[1].Cells[cellind].Value = inprog;
                    expert_dgv.Rows[2].Cells[cellind].Value = notstart;
                }
                var compmodules = (from m in db.Training_Module
                                   where m.skillIdFK == skillid
                                   where m.userTypeIdFK == 3
                                   select m);
                var compassigned = (from m in db.Assign_Training
                                    where m.Training_Module.skillIdFK == skillid
                                    where m.Training_Module.userTypeIdFK == 3
                                    group m by m.Training_Module.moduleName into u
                                    select new
                                    {
                                        keyword = u.Key,
                                        progress = u.Select(c => c.progress)
                                    });
                foreach (var item in compmodules)
                {
                    int completed = 0;
                    int inprog = 0;
                    int notstart = 0;
                    trainee_dgv.Columns.Add($"Column{item.moduleId}", $"{item.moduleName}");
                    var module = (from e in compassigned
                                  where e.keyword == item.moduleName
                                  select e);
                    foreach (var item1 in module)
                    {
                        foreach (var item2 in item1.progress)
                        {
                            if (item2 == 100)
                            {
                                completed += 1;
                            }
                            else if (item2 > 0)
                            {
                                inprog += 1;
                            }
                            else if (item2 == 0)
                            {
                                notstart += 1;
                            }
                        }
                    }
                    var cellind = trainee_dgv.Columns[$"Column{item.moduleId}"].Index;
                    trainee_dgv.Rows[0].Cells[cellind].Value = completed;
                    trainee_dgv.Rows[1].Cells[cellind].Value = inprog;
                    trainee_dgv.Rows[2].Cells[cellind].Value = notstart;
                    chart1.Series[$"Completed"].Points.AddXY($"{item.moduleName}", completed);
                    chart1.Series[$"In Progress"].Points.AddXY($"{item.moduleName}", inprog);
                    chart1.Series[$"Not Started"].Points.AddXY($"{item.moduleName}", notstart);
                }
                var modules = (from m in db.Assign_Training
                               where m.Training_Module.skillIdFK == skillid
                               select m);
                var modulesmonth = (from m in db.Assign_Training
                                    where m.Training_Module.skillIdFK == skillid
                                    group m by m.startDate.Month into u
                                    select new
                                    {
                                        date = u.Key,
                                        progress = u.Select(c => c.progress)
                                    });
                foreach (var item in modulesmonth)
                {
                    int compcompleted = 0;
                    int expcompleted = 0;
                    completedtraining_dgv.Columns.Add($"Column{item.date}", $"No of Training Modules start in {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(item.date)}");
                    var module = (from e in modules
                                  where e.startDate.Month == item.date
                                  select e);
                    foreach (var item1 in module)
                    {
                        if (item1.progress > 0 && item1.User.userTypeIdFK == 3)
                        {
                            compcompleted += 1;
                        }
                        else if (item1.progress > 0 && item1.User.userTypeIdFK == 2)
                        {
                            expcompleted += 1;
                        }
                    }
                    var cellind = completedtraining_dgv.Columns[$"Column{item.date}"].Index;
                    completedtraining_dgv.Rows[0].Cells[cellind].Value = compcompleted;
                    completedtraining_dgv.Rows[1].Cells[cellind].Value = expcompleted;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new MainMenu(LoggedInUser);
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void skill_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
                GetInfo();
         
        }
    }
}
