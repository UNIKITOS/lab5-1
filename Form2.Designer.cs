
namespace Zaycev
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDZakupkaTovarovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPostavkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symmaPostavkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaZakazaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolichestvotovaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Postavshik = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.postavshikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zayDBDataSet = new Zaycev.zayDBDataSet();
            this.ID_Sotrudnik = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID_Spisok_tovarov = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.spisokTovarovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakupkatovarovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakupka_tovarovTableAdapter = new Zaycev.zayDBDataSetTableAdapters.Zakupka_tovarovTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.postavshikTableAdapter = new Zaycev.zayDBDataSetTableAdapters.PostavshikTableAdapter();
            this.sotrudnikTableAdapter = new Zaycev.zayDBDataSetTableAdapters.SotrudnikTableAdapter();
            this.spisok_tovarovTableAdapter = new Zaycev.zayDBDataSetTableAdapters.Spisok_tovarovTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spisokTovarovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkatovarovBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDZakupkaTovarovDataGridViewTextBoxColumn,
            this.dataPostavkiDataGridViewTextBoxColumn,
            this.symmaPostavkiDataGridViewTextBoxColumn,
            this.summaZakazaDataGridViewTextBoxColumn,
            this.kolichestvotovaraDataGridViewTextBoxColumn,
            this.ID_Postavshik,
            this.ID_Sotrudnik,
            this.ID_Spisok_tovarov});
            this.dataGridView1.DataSource = this.zakupkatovarovBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 141);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDZakupkaTovarovDataGridViewTextBoxColumn
            // 
            this.iDZakupkaTovarovDataGridViewTextBoxColumn.DataPropertyName = "ID_Zakupka tovarov";
            this.iDZakupkaTovarovDataGridViewTextBoxColumn.HeaderText = "ID_Zakupka tovarov";
            this.iDZakupkaTovarovDataGridViewTextBoxColumn.Name = "iDZakupkaTovarovDataGridViewTextBoxColumn";
            // 
            // dataPostavkiDataGridViewTextBoxColumn
            // 
            this.dataPostavkiDataGridViewTextBoxColumn.DataPropertyName = "Data postavki";
            this.dataPostavkiDataGridViewTextBoxColumn.HeaderText = "Data postavki";
            this.dataPostavkiDataGridViewTextBoxColumn.Name = "dataPostavkiDataGridViewTextBoxColumn";
            // 
            // symmaPostavkiDataGridViewTextBoxColumn
            // 
            this.symmaPostavkiDataGridViewTextBoxColumn.DataPropertyName = "Symma postavki";
            this.symmaPostavkiDataGridViewTextBoxColumn.HeaderText = "Symma postavki";
            this.symmaPostavkiDataGridViewTextBoxColumn.Name = "symmaPostavkiDataGridViewTextBoxColumn";
            // 
            // summaZakazaDataGridViewTextBoxColumn
            // 
            this.summaZakazaDataGridViewTextBoxColumn.DataPropertyName = "Summa zakaza";
            this.summaZakazaDataGridViewTextBoxColumn.HeaderText = "Summa zakaza";
            this.summaZakazaDataGridViewTextBoxColumn.Name = "summaZakazaDataGridViewTextBoxColumn";
            // 
            // kolichestvotovaraDataGridViewTextBoxColumn
            // 
            this.kolichestvotovaraDataGridViewTextBoxColumn.DataPropertyName = "Kolichestvo_tovara";
            this.kolichestvotovaraDataGridViewTextBoxColumn.HeaderText = "Kolichestvo_tovara";
            this.kolichestvotovaraDataGridViewTextBoxColumn.Name = "kolichestvotovaraDataGridViewTextBoxColumn";
            // 
            // ID_Postavshik
            // 
            this.ID_Postavshik.DataPropertyName = "ID_Postavshik";
            this.ID_Postavshik.DataSource = this.postavshikBindingSource;
            this.ID_Postavshik.DisplayMember = "Nazvanie_postavshika";
            this.ID_Postavshik.HeaderText = "ID_Postavshik";
            this.ID_Postavshik.Name = "ID_Postavshik";
            this.ID_Postavshik.ValueMember = "ID_Postavshik";
            // 
            // postavshikBindingSource
            // 
            this.postavshikBindingSource.DataMember = "Postavshik";
            this.postavshikBindingSource.DataSource = this.zayDBDataSet;
            // 
            // zayDBDataSet
            // 
            this.zayDBDataSet.DataSetName = "zayDBDataSet";
            this.zayDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ID_Sotrudnik
            // 
            this.ID_Sotrudnik.DataPropertyName = "ID_Sotrudnik";
            this.ID_Sotrudnik.DataSource = this.sotrudnikBindingSource;
            this.ID_Sotrudnik.DisplayMember = "fam_sota";
            this.ID_Sotrudnik.HeaderText = "ID_Sotrudnik";
            this.ID_Sotrudnik.Name = "ID_Sotrudnik";
            this.ID_Sotrudnik.ValueMember = "ID_Sotrudnik";
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.zayDBDataSet;
            // 
            // ID_Spisok_tovarov
            // 
            this.ID_Spisok_tovarov.DataPropertyName = "ID_Spisok_tovarov";
            this.ID_Spisok_tovarov.DataSource = this.spisokTovarovBindingSource;
            this.ID_Spisok_tovarov.DisplayMember = "Kolichestvo tovara";
            this.ID_Spisok_tovarov.HeaderText = "ID_Spisok_tovarov";
            this.ID_Spisok_tovarov.Name = "ID_Spisok_tovarov";
            this.ID_Spisok_tovarov.ValueMember = "ID_Spisok tovarov";
            // 
            // spisokTovarovBindingSource
            // 
            this.spisokTovarovBindingSource.DataMember = "Spisok tovarov";
            this.spisokTovarovBindingSource.DataSource = this.zayDBDataSet;
            // 
            // zakupkatovarovBindingSource
            // 
            this.zakupkatovarovBindingSource.DataMember = "Zakupka_tovarov";
            this.zakupkatovarovBindingSource.DataSource = this.zayDBDataSet;
            // 
            // zakupka_tovarovTableAdapter
            // 
            this.zakupka_tovarovTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(869, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(869, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(869, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Закрыть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(961, 435);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 54);
            this.button4.TabIndex = 4;
            this.button4.Text = "Таблица: \"Приобретение услуги\"";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // postavshikTableAdapter
            // 
            this.postavshikTableAdapter.ClearBeforeFill = true;
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // spisok_tovarovTableAdapter
            // 
            this.spisok_tovarovTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(869, 89);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(961, 373);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 44);
            this.button6.TabIndex = 6;
            this.button6.Text = "Таблица: \"Бухгалтерия\"";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(961, 311);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 43);
            this.button7.TabIndex = 7;
            this.button7.Text = "Все бизнес процессы";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zaycev.Properties.Resources._2021_05_29_18_02_18;
            this.ClientSize = new System.Drawing.Size(1080, 501);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Закупка товаров";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spisokTovarovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupkatovarovBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public zayDBDataSet zayDBDataSet;
        public System.Windows.Forms.BindingSource zakupkatovarovBindingSource;
        public zayDBDataSetTableAdapters.Zakupka_tovarovTableAdapter zakupka_tovarovTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource postavshikBindingSource;
        private zayDBDataSetTableAdapters.PostavshikTableAdapter postavshikTableAdapter;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private zayDBDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.BindingSource spisokTovarovBindingSource;
        private zayDBDataSetTableAdapters.Spisok_tovarovTableAdapter spisok_tovarovTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDZakupkaTovarovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPostavkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn symmaPostavkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaZakazaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolichestvotovaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Postavshik;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Sotrudnik;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Spisok_tovarov;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}