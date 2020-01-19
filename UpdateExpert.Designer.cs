namespace Session4
{
    partial class UpdateExpert
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.skill_combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name_combo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date_check = new System.Windows.Forms.CheckBox();
            this.name_check = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 48);
            this.panel1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(3, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 48);
            this.panel2.TabIndex = 17;
            // 
            // skill_combo
            // 
            this.skill_combo.FormattingEnabled = true;
            this.skill_combo.Location = new System.Drawing.Point(307, 80);
            this.skill_combo.Margin = new System.Windows.Forms.Padding(2);
            this.skill_combo.Name = "skill_combo";
            this.skill_combo.Size = new System.Drawing.Size(151, 21);
            this.skill_combo.TabIndex = 19;
            this.skill_combo.SelectedIndexChanged += new System.EventHandler(this.skill_combo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Skill :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Update Expert Training Records";
            // 
            // name_combo
            // 
            this.name_combo.FormattingEnabled = true;
            this.name_combo.Location = new System.Drawing.Point(307, 106);
            this.name_combo.Margin = new System.Windows.Forms.Padding(2);
            this.name_combo.Name = "name_combo";
            this.name_combo.Size = new System.Drawing.Size(151, 21);
            this.name_combo.TabIndex = 22;
            this.name_combo.SelectedIndexChanged += new System.EventHandler(this.name_combo_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(202, 109);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Competitor\'s Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Sort By :";
            // 
            // date_check
            // 
            this.date_check.AutoSize = true;
            this.date_check.Location = new System.Drawing.Point(368, 131);
            this.date_check.Name = "date_check";
            this.date_check.Size = new System.Drawing.Size(71, 17);
            this.date_check.TabIndex = 25;
            this.date_check.Text = "End Date";
            this.date_check.UseVisualStyleBackColor = true;
            this.date_check.CheckedChanged += new System.EventHandler(this.date_check_CheckedChanged);
            // 
            // name_check
            // 
            this.name_check.AutoSize = true;
            this.name_check.Location = new System.Drawing.Point(308, 131);
            this.name_check.Name = "name_check";
            this.name_check.Size = new System.Drawing.Size(54, 17);
            this.name_check.TabIndex = 24;
            this.name_check.Text = "Name";
            this.name_check.UseVisualStyleBackColor = true;
            this.name_check.CheckedChanged += new System.EventHandler(this.name_check_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(792, 199);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(710, 359);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(88, 36);
            this.update_button.TabIndex = 29;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(570, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "ASEAN Skills 2020";
            // 
            // UpdateExpert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.date_check);
            this.Controls.Add(this.name_check);
            this.Controls.Add(this.name_combo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.skill_combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateExpert";
            this.Text = "UpdateExpert";
            this.Load += new System.EventHandler(this.UpdateExpert_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox skill_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox name_combo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox date_check;
        private System.Windows.Forms.CheckBox name_check;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label label3;
    }
}