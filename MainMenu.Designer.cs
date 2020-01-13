namespace Session4
{
    partial class MainMenu
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
            this.assign_update = new System.Windows.Forms.Button();
            this.progress_check = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adminstrator Main Menu";
            // 
            // assign_update
            // 
            this.assign_update.Location = new System.Drawing.Point(223, 46);
            this.assign_update.Name = "assign_update";
            this.assign_update.Size = new System.Drawing.Size(322, 93);
            this.assign_update.TabIndex = 3;
            this.assign_update.Text = "Assign Training";
            this.assign_update.UseVisualStyleBackColor = true;
            this.assign_update.Click += new System.EventHandler(this.assign_update_Click);
            // 
            // progress_check
            // 
            this.progress_check.Location = new System.Drawing.Point(223, 179);
            this.progress_check.Name = "progress_check";
            this.progress_check.Size = new System.Drawing.Size(322, 93);
            this.progress_check.TabIndex = 4;
            this.progress_check.Text = "Track Overall Training Progress";
            this.progress_check.UseVisualStyleBackColor = true;
            this.progress_check.Click += new System.EventHandler(this.progress_check_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 93);
            this.button1.TabIndex = 5;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progress_check);
            this.Controls.Add(this.assign_update);
            this.Controls.Add(this.label2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button assign_update;
        private System.Windows.Forms.Button progress_check;
        private System.Windows.Forms.Button button1;
    }
}