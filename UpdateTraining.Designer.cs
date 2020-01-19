namespace Session4
{
    partial class UpdateTraining
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
            this.skill_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.name_combo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_check = new System.Windows.Forms.CheckBox();
            this.date_check = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.progress_box = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.search_box = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // skill_combo
            // 
            this.skill_combo.FormattingEnabled = true;
            this.skill_combo.Location = new System.Drawing.Point(325, 80);
            this.skill_combo.Margin = new System.Windows.Forms.Padding(2);
            this.skill_combo.Name = "skill_combo";
            this.skill_combo.Size = new System.Drawing.Size(151, 21);
            this.skill_combo.TabIndex = 13;
            this.skill_combo.SelectedIndexChanged += new System.EventHandler(this.skill_combo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Skill :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(190, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Update Competitor Training Records";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 48);
            this.panel1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(3, 438);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 48);
            this.panel2.TabIndex = 16;
            // 
            // name_combo
            // 
            this.name_combo.FormattingEnabled = true;
            this.name_combo.Location = new System.Drawing.Point(325, 105);
            this.name_combo.Margin = new System.Windows.Forms.Padding(2);
            this.name_combo.Name = "name_combo";
            this.name_combo.Size = new System.Drawing.Size(151, 21);
            this.name_combo.TabIndex = 18;
            this.name_combo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 108);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Competitor\'s Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Search By Module Name :";
            // 
            // name_check
            // 
            this.name_check.AutoSize = true;
            this.name_check.Location = new System.Drawing.Point(326, 130);
            this.name_check.Name = "name_check";
            this.name_check.Size = new System.Drawing.Size(54, 17);
            this.name_check.TabIndex = 21;
            this.name_check.Text = "Name";
            this.name_check.UseVisualStyleBackColor = true;
            this.name_check.CheckedChanged += new System.EventHandler(this.name_check_CheckedChanged);
            // 
            // date_check
            // 
            this.date_check.AutoSize = true;
            this.date_check.Location = new System.Drawing.Point(386, 130);
            this.date_check.Name = "date_check";
            this.date_check.Size = new System.Drawing.Size(71, 17);
            this.date_check.TabIndex = 22;
            this.date_check.Text = "End Date";
            this.date_check.UseVisualStyleBackColor = true;
            this.date_check.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Sort By :";
            // 
            // progress_box
            // 
            this.progress_box.FormattingEnabled = true;
            this.progress_box.Location = new System.Drawing.Point(326, 178);
            this.progress_box.Margin = new System.Windows.Forms.Padding(2);
            this.progress_box.Name = "progress_box";
            this.progress_box.Size = new System.Drawing.Size(151, 21);
            this.progress_box.TabIndex = 25;
            this.progress_box.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Search By Progress :";
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(325, 153);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(151, 20);
            this.search_box.TabIndex = 26;
            this.search_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(792, 186);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.Yellow;
            this.update_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.update_button.Location = new System.Drawing.Point(710, 396);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(88, 36);
            this.update_button.TabIndex = 28;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(570, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 26);
            this.label6.TabIndex = 29;
            this.label6.Text = "ASEAN Skills 2020";
            // 
            // UpdateTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.progress_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.date_check);
            this.Controls.Add(this.name_check);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.name_combo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.skill_combo);
            this.Controls.Add(this.label1);
            this.Name = "UpdateTraining";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox skill_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox name_combo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox name_check;
        private System.Windows.Forms.CheckBox date_check;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox progress_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label label6;
    }
}