
namespace Zaycev
{
    partial class AddForm6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textOt_sota = new System.Windows.Forms.TextBox();
            this.textData_rojd = new System.Windows.Forms.TextBox();
            this.textim_sota = new System.Windows.Forms.TextBox();
            this.textfam_sot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textOt_sota);
            this.groupBox1.Controls.Add(this.textData_rojd);
            this.groupBox1.Controls.Add(this.textim_sota);
            this.groupBox1.Controls.Add(this.textfam_sot);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление записи";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textOt_sota
            // 
            this.textOt_sota.Location = new System.Drawing.Point(218, 62);
            this.textOt_sota.Name = "textOt_sota";
            this.textOt_sota.Size = new System.Drawing.Size(100, 20);
            this.textOt_sota.TabIndex = 7;
            // 
            // textData_rojd
            // 
            this.textData_rojd.Location = new System.Drawing.Point(218, 84);
            this.textData_rojd.Name = "textData_rojd";
            this.textData_rojd.Size = new System.Drawing.Size(100, 20);
            this.textData_rojd.TabIndex = 6;
            // 
            // textim_sota
            // 
            this.textim_sota.Location = new System.Drawing.Point(218, 38);
            this.textim_sota.Name = "textim_sota";
            this.textim_sota.Size = new System.Drawing.Size(100, 20);
            this.textim_sota.TabIndex = 5;
            // 
            // textfam_sot
            // 
            this.textfam_sot.Location = new System.Drawing.Point(218, 13);
            this.textfam_sot.Name = "textfam_sot";
            this.textfam_sot.Size = new System.Drawing.Size(100, 20);
            this.textfam_sot.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата рождения сотрудника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество сотрудника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя сотрудника";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия сотрудника";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 140);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddForm6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 177);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddForm6";
            this.Text = "Добавление записи";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textOt_sota;
        private System.Windows.Forms.TextBox textData_rojd;
        private System.Windows.Forms.TextBox textim_sota;
        private System.Windows.Forms.TextBox textfam_sot;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button button2;
    }
}