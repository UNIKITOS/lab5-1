
namespace Zaycev
{
    partial class AddForm3
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
            this.textData_postavki = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textSymma_postavki = new System.Windows.Forms.TextBox();
            this.textSymma_zakaza = new System.Windows.Forms.TextBox();
            this.textKolichestvo_tovara = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textKolichestvo_tovara);
            this.groupBox1.Controls.Add(this.textSymma_zakaza);
            this.groupBox1.Controls.Add(this.textSymma_postavki);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textData_postavki);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление записи";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textData_postavki
            // 
            this.textData_postavki.Location = new System.Drawing.Point(154, 34);
            this.textData_postavki.Name = "textData_postavki";
            this.textData_postavki.Size = new System.Drawing.Size(176, 20);
            this.textData_postavki.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата поставки";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(27, 232);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сумма поставки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Сумма заказа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Количество товара";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textSymma_postavki
            // 
            this.textSymma_postavki.Location = new System.Drawing.Point(154, 79);
            this.textSymma_postavki.Name = "textSymma_postavki";
            this.textSymma_postavki.Size = new System.Drawing.Size(176, 20);
            this.textSymma_postavki.TabIndex = 5;
            // 
            // textSymma_zakaza
            // 
            this.textSymma_zakaza.Location = new System.Drawing.Point(154, 113);
            this.textSymma_zakaza.Name = "textSymma_zakaza";
            this.textSymma_zakaza.Size = new System.Drawing.Size(176, 20);
            this.textSymma_zakaza.TabIndex = 6;
            // 
            // textKolichestvo_tovara
            // 
            this.textKolichestvo_tovara.Location = new System.Drawing.Point(154, 146);
            this.textKolichestvo_tovara.Name = "textKolichestvo_tovara";
            this.textKolichestvo_tovara.Size = new System.Drawing.Size(176, 20);
            this.textKolichestvo_tovara.TabIndex = 7;
            // 
            // AddForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 275);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddForm3";
            this.Text = "Добавление данных в таблицу \"Закупка товаров\"";
            this.Load += new System.EventHandler(this.AddForm3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textData_postavki;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox textKolichestvo_tovara;
        private System.Windows.Forms.TextBox textSymma_zakaza;
        private System.Windows.Forms.TextBox textSymma_postavki;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}