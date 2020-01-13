namespace Session4
{
    partial class AssignTraining
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.skill_combo = new System.Windows.Forms.ComboBox();
            this.trainee_combo = new System.Windows.Forms.ComboBox();
            this.training_box = new System.Windows.Forms.ComboBox();
            this.startdate_picker = new System.Windows.Forms.DateTimePicker();
            this.add_button = new System.Windows.Forms.Button();
            this.remove_button = new System.Windows.Forms.Button();
            this.assign_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Assign Training";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Skill :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trainee Category :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Training Module :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Start Date :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(558, 215);
            this.dataGridView1.TabIndex = 8;
            // 
            // skill_combo
            // 
            this.skill_combo.FormattingEnabled = true;
            this.skill_combo.Location = new System.Drawing.Point(256, 63);
            this.skill_combo.Name = "skill_combo";
            this.skill_combo.Size = new System.Drawing.Size(200, 24);
            this.skill_combo.TabIndex = 9;
            this.skill_combo.SelectedIndexChanged += new System.EventHandler(this.skill_combo_SelectedIndexChanged);
            // 
            // trainee_combo
            // 
            this.trainee_combo.FormattingEnabled = true;
            this.trainee_combo.Location = new System.Drawing.Point(256, 103);
            this.trainee_combo.Name = "trainee_combo";
            this.trainee_combo.Size = new System.Drawing.Size(200, 24);
            this.trainee_combo.TabIndex = 10;
            this.trainee_combo.SelectedIndexChanged += new System.EventHandler(this.trainee_combo_SelectedIndexChanged);
            // 
            // training_box
            // 
            this.training_box.FormattingEnabled = true;
            this.training_box.Location = new System.Drawing.Point(256, 140);
            this.training_box.Name = "training_box";
            this.training_box.Size = new System.Drawing.Size(200, 24);
            this.training_box.TabIndex = 11;
            this.training_box.SelectedIndexChanged += new System.EventHandler(this.training_box_SelectedIndexChanged);
            // 
            // startdate_picker
            // 
            this.startdate_picker.Location = new System.Drawing.Point(256, 178);
            this.startdate_picker.Name = "startdate_picker";
            this.startdate_picker.Size = new System.Drawing.Size(200, 22);
            this.startdate_picker.TabIndex = 12;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(614, 190);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(174, 71);
            this.add_button.TabIndex = 13;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // remove_button
            // 
            this.remove_button.Location = new System.Drawing.Point(614, 267);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(174, 71);
            this.remove_button.TabIndex = 14;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // assign_button
            // 
            this.assign_button.Location = new System.Drawing.Point(614, 344);
            this.assign_button.Name = "assign_button";
            this.assign_button.Size = new System.Drawing.Size(174, 71);
            this.assign_button.TabIndex = 15;
            this.assign_button.Text = "Assign";
            this.assign_button.UseVisualStyleBackColor = true;
            this.assign_button.Click += new System.EventHandler(this.assign_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 61);
            this.button1.TabIndex = 16;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AssignTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.assign_button);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.startdate_picker);
            this.Controls.Add(this.training_box);
            this.Controls.Add(this.trainee_combo);
            this.Controls.Add(this.skill_combo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AssignTraining";
            this.Text = "AssignTraining";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox skill_combo;
        private System.Windows.Forms.ComboBox trainee_combo;
        private System.Windows.Forms.ComboBox training_box;
        private System.Windows.Forms.DateTimePicker startdate_picker;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button assign_button;
        private System.Windows.Forms.Button button1;
    }
}