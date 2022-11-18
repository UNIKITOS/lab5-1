
namespace Zaycev
{
    partial class Form6
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
            this.iDSotrudnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.famsotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imsotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otsotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datarojdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDoljnostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zayDBDataSet = new Zaycev.zayDBDataSet();
            this.sotrudnikTableAdapter = new Zaycev.zayDBDataSetTableAdapters.SotrudnikTableAdapter();
            this.AddBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDoljnostDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanieDoljnostiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.okladDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doljnostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doljnost_TableAdapter = new Zaycev.zayDBDataSetTableAdapters.Doljnost_TableAdapter();
            this.AddBtn2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDPostavshikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazvaniepostavshikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOpostavshikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomertelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adrespostavshikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavshikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postavshikTableAdapter = new Zaycev.zayDBDataSetTableAdapters.PostavshikTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doljnostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSotrudnikDataGridViewTextBoxColumn,
            this.famsotaDataGridViewTextBoxColumn,
            this.imsotaDataGridViewTextBoxColumn,
            this.otsotaDataGridViewTextBoxColumn,
            this.datarojdDataGridViewTextBoxColumn,
            this.iDDoljnostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sotrudnikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 139);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDSotrudnikDataGridViewTextBoxColumn
            // 
            this.iDSotrudnikDataGridViewTextBoxColumn.DataPropertyName = "ID_Sotrudnik";
            this.iDSotrudnikDataGridViewTextBoxColumn.HeaderText = "ID_Sotrudnik";
            this.iDSotrudnikDataGridViewTextBoxColumn.Name = "iDSotrudnikDataGridViewTextBoxColumn";
            // 
            // famsotaDataGridViewTextBoxColumn
            // 
            this.famsotaDataGridViewTextBoxColumn.DataPropertyName = "fam_sota";
            this.famsotaDataGridViewTextBoxColumn.HeaderText = "fam_sota";
            this.famsotaDataGridViewTextBoxColumn.Name = "famsotaDataGridViewTextBoxColumn";
            // 
            // imsotaDataGridViewTextBoxColumn
            // 
            this.imsotaDataGridViewTextBoxColumn.DataPropertyName = "Im_sota";
            this.imsotaDataGridViewTextBoxColumn.HeaderText = "Im_sota";
            this.imsotaDataGridViewTextBoxColumn.Name = "imsotaDataGridViewTextBoxColumn";
            // 
            // otsotaDataGridViewTextBoxColumn
            // 
            this.otsotaDataGridViewTextBoxColumn.DataPropertyName = "Ot_sota";
            this.otsotaDataGridViewTextBoxColumn.HeaderText = "Ot_sota";
            this.otsotaDataGridViewTextBoxColumn.Name = "otsotaDataGridViewTextBoxColumn";
            // 
            // datarojdDataGridViewTextBoxColumn
            // 
            this.datarojdDataGridViewTextBoxColumn.DataPropertyName = "Data_rojd\'";
            this.datarojdDataGridViewTextBoxColumn.HeaderText = "Data_rojd\'";
            this.datarojdDataGridViewTextBoxColumn.Name = "datarojdDataGridViewTextBoxColumn";
            // 
            // iDDoljnostDataGridViewTextBoxColumn
            // 
            this.iDDoljnostDataGridViewTextBoxColumn.DataPropertyName = "ID_Doljnost\'";
            this.iDDoljnostDataGridViewTextBoxColumn.HeaderText = "ID_Doljnost\'";
            this.iDDoljnostDataGridViewTextBoxColumn.Name = "iDDoljnostDataGridViewTextBoxColumn";
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.zayDBDataSet;
            // 
            // zayDBDataSet
            // 
            this.zayDBDataSet.DataSetName = "zayDBDataSet";
            this.zayDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(677, 13);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(677, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(677, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(718, 483);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Закрыть";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDoljnostDataGridViewTextBoxColumn1,
            this.naimenovanieDoljnostiDataGridViewTextBoxColumn,
            this.okladDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.doljnostBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 173);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(350, 148);
            this.dataGridView2.TabIndex = 5;
            // 
            // iDDoljnostDataGridViewTextBoxColumn1
            // 
            this.iDDoljnostDataGridViewTextBoxColumn1.DataPropertyName = "ID_Doljnost\'";
            this.iDDoljnostDataGridViewTextBoxColumn1.HeaderText = "ID_Doljnost\'";
            this.iDDoljnostDataGridViewTextBoxColumn1.Name = "iDDoljnostDataGridViewTextBoxColumn1";
            // 
            // naimenovanieDoljnostiDataGridViewTextBoxColumn
            // 
            this.naimenovanieDoljnostiDataGridViewTextBoxColumn.DataPropertyName = "Naimenovanie doljnosti";
            this.naimenovanieDoljnostiDataGridViewTextBoxColumn.HeaderText = "Naimenovanie doljnosti";
            this.naimenovanieDoljnostiDataGridViewTextBoxColumn.Name = "naimenovanieDoljnostiDataGridViewTextBoxColumn";
            // 
            // okladDataGridViewTextBoxColumn
            // 
            this.okladDataGridViewTextBoxColumn.DataPropertyName = "Oklad";
            this.okladDataGridViewTextBoxColumn.HeaderText = "Oklad";
            this.okladDataGridViewTextBoxColumn.Name = "okladDataGridViewTextBoxColumn";
            // 
            // doljnostBindingSource
            // 
            this.doljnostBindingSource.DataMember = "Doljnost\'";
            this.doljnostBindingSource.DataSource = this.zayDBDataSet;
            // 
            // doljnost_TableAdapter
            // 
            this.doljnost_TableAdapter.ClearBeforeFill = true;
            // 
            // AddBtn2
            // 
            this.AddBtn2.Location = new System.Drawing.Point(368, 173);
            this.AddBtn2.Name = "AddBtn2";
            this.AddBtn2.Size = new System.Drawing.Size(75, 23);
            this.AddBtn2.TabIndex = 6;
            this.AddBtn2.Text = "Добавить";
            this.AddBtn2.UseVisualStyleBackColor = true;
            this.AddBtn2.Click += new System.EventHandler(this.AddBtn2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(368, 202);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Найти";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(368, 231);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Сохранить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPostavshikDataGridViewTextBoxColumn,
            this.nazvaniepostavshikaDataGridViewTextBoxColumn,
            this.fIOpostavshikaDataGridViewTextBoxColumn,
            this.nomertelefonaDataGridViewTextBoxColumn,
            this.adrespostavshikaDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.postavshikBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 343);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(551, 150);
            this.dataGridView3.TabIndex = 9;
            // 
            // iDPostavshikDataGridViewTextBoxColumn
            // 
            this.iDPostavshikDataGridViewTextBoxColumn.DataPropertyName = "ID_Postavshik";
            this.iDPostavshikDataGridViewTextBoxColumn.HeaderText = "ID_Postavshik";
            this.iDPostavshikDataGridViewTextBoxColumn.Name = "iDPostavshikDataGridViewTextBoxColumn";
            // 
            // nazvaniepostavshikaDataGridViewTextBoxColumn
            // 
            this.nazvaniepostavshikaDataGridViewTextBoxColumn.DataPropertyName = "Nazvanie_postavshika";
            this.nazvaniepostavshikaDataGridViewTextBoxColumn.HeaderText = "Nazvanie_postavshika";
            this.nazvaniepostavshikaDataGridViewTextBoxColumn.Name = "nazvaniepostavshikaDataGridViewTextBoxColumn";
            // 
            // fIOpostavshikaDataGridViewTextBoxColumn
            // 
            this.fIOpostavshikaDataGridViewTextBoxColumn.DataPropertyName = "FIO_postavshika";
            this.fIOpostavshikaDataGridViewTextBoxColumn.HeaderText = "FIO_postavshika";
            this.fIOpostavshikaDataGridViewTextBoxColumn.Name = "fIOpostavshikaDataGridViewTextBoxColumn";
            // 
            // nomertelefonaDataGridViewTextBoxColumn
            // 
            this.nomertelefonaDataGridViewTextBoxColumn.DataPropertyName = "Nomer_telefona";
            this.nomertelefonaDataGridViewTextBoxColumn.HeaderText = "Nomer_telefona";
            this.nomertelefonaDataGridViewTextBoxColumn.Name = "nomertelefonaDataGridViewTextBoxColumn";
            // 
            // adrespostavshikaDataGridViewTextBoxColumn
            // 
            this.adrespostavshikaDataGridViewTextBoxColumn.DataPropertyName = "Adres_postavshika";
            this.adrespostavshikaDataGridViewTextBoxColumn.HeaderText = "Adres_postavshika";
            this.adrespostavshikaDataGridViewTextBoxColumn.Name = "adrespostavshikaDataGridViewTextBoxColumn";
            // 
            // postavshikBindingSource
            // 
            this.postavshikBindingSource.DataMember = "Postavshik";
            this.postavshikBindingSource.DataSource = this.zayDBDataSet;
            // 
            // postavshikTableAdapter
            // 
            this.postavshikTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(569, 372);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "Найти";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(569, 401);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "Сохранить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(718, 428);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 39);
            this.button9.TabIndex = 13;
            this.button9.Text = "Следующая страница";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zaycev.Properties.Resources._2021_05_29_18_02_18;
            this.ClientSize = new System.Drawing.Size(807, 532);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.AddBtn2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Бизнес процессы";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doljnostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavshikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public zayDBDataSet zayDBDataSet;
        public System.Windows.Forms.BindingSource sotrudnikBindingSource;
        public zayDBDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.BindingSource doljnostBindingSource;
        public zayDBDataSetTableAdapters.Doljnost_TableAdapter doljnost_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSotrudnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn famsotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imsotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otsotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datarojdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDoljnostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDoljnostDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanieDoljnostiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn okladDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddBtn2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.DataGridView dataGridView3;
        public System.Windows.Forms.BindingSource postavshikBindingSource;
        public zayDBDataSetTableAdapters.PostavshikTableAdapter postavshikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPostavshikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazvaniepostavshikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOpostavshikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomertelefonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adrespostavshikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}