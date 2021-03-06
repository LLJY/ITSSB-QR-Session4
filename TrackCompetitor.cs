﻿using System;
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
    
    public partial class TrackCompetitor : Form
    {
        List<TrainingProgress> traininglist;
        User LoggedInUser;
        public TrackCompetitor(User user)
        {
            LoggedInUser = user;
            InitializeComponent();
            traininglist = new List<TrainingProgress>();
            using(var db = new Session4Entities())
            {
                skill_label.Text = (from s in db.Skills where s.skillId == LoggedInUser.skillIdFK select s.skillName).First().ToString();
                var users = (from b in db.Users
                             where b.skillIdFK == LoggedInUser.skillIdFK
                             select b);
                var trainings = (from l in db.Training_Module
                                 where l.skillIdFK == LoggedInUser.skillIdFK
                                 select l.moduleId);
                foreach (var item in users)
                {
                    List<int> complted = new List<int>();
                    foreach (var c in trainings)
                    {
                        try
                        {
                            var completion = (from a in db.Assign_Training
                                              where a.moduleIdFK == c
                                              where a.userIdFK == item.userId
                                              select a.progress).First();
                            complted.Add(completion);
                        }
                        catch
                        {
                            complted.Add(0);
                        }
                    }
                    var tp = new TrainingProgress()
                    {
                        NameofCompetitor = item.name,
                        TrainingModule1Progress = complted[0],
                        TrainingModule2Progress = complted[1],
                        TrainingModule3Progress = complted[2]
                    };
                    traininglist.Add(tp);
                }
            }
            dataGridView1.DataSource = traininglist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new MainMenu(LoggedInUser);
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if(int.Parse(item.Cells[1].Value.ToString()) == 0)
                {
                    item.Cells[1].Style.BackColor = Color.Red;
                }
                if (int.Parse(item.Cells[2].Value.ToString()) == 0)
                {
                    item.Cells[2].Style.BackColor = Color.Red;
                }
                if (int.Parse(item.Cells[3].Value.ToString()) == 0)
                {
                    item.Cells[3].Style.BackColor = Color.Red;
                }
            }

        }
    }
    public class TrainingProgress
    {
        public string NameofCompetitor { get; set; }
        public int TrainingModule1Progress { get; set; }
        public int TrainingModule2Progress { get; set; }
        public int TrainingModule3Progress { get; set; }
    }
}
