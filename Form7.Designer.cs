
namespace Zaycev
{
    partial class Form7
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
            this.iDPosititelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posetitelfamiliyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posetitelimyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomertelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posetitelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zayDBDataSet = new Zaycev.zayDBDataSet();
            this.posetitel_TableAdapter = new Zaycev.zayDBDataSetTableAdapters.Posetitel_TableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDДанныеОбУслугеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerstolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vremyabroniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenayslygiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Naimenovanie_yslygi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.naimenovanieyslygiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dannieobyslygeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dannie_ob_yslygeTableAdapter = new Zaycev.zayDBDataSetTableAdapters.Dannie_ob_yslygeTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDNaimenovanieYslugiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanieyslygiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.naimenovanie_yslygiTableAdapter = new Zaycev.zayDBDataSetTableAdapters.Naimenovanie_yslygiTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posetitelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naimenovanieyslygiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dannieobyslygeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naimenovanieyslygiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPosititelDataGridViewTextBoxColumn,
            this.posetitelfamiliyaDataGridViewTextBoxColumn,
            this.posetitelimyaDataGridViewTextBoxColumn,
            this.nomertelefonaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.posetitelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDPosititelDataGridViewTextBoxColumn
            // 
            this.iDPosititelDataGridViewTextBoxColumn.DataPropertyName = "ID_Posititel\'";
            this.iDPosititelDataGridViewTextBoxColumn.HeaderText = "ID_Posititel\'";
            this.iDPosititelDataGridViewTextBoxColumn.Name = "iDPosititelDataGridViewTextBoxColumn";
            // 
            // posetitelfamiliyaDataGridViewTextBoxColumn
            // 
            this.posetitelfamiliyaDataGridViewTextBoxColumn.DataPropertyName = "Posetitel\'_familiya";
            this.posetitelfamiliyaDataGridViewTextBoxColumn.HeaderText = "Posetitel\'_familiya";
            this.posetitelfamiliyaDataGridViewTextBoxColumn.Name = "posetitelfamiliyaDataGridViewTextBoxColumn";
            // 
            // posetitelimyaDataGridViewTextBoxColumn
            // 
            this.posetitelimyaDataGridViewTextBoxColumn.DataPropertyName = "Posetitel\'_imya";
            this.posetitelimyaDataGridViewTextBoxColumn.HeaderText = "Posetitel\'_imya";
            this.posetitelimyaDataGridViewTextBoxColumn.Name = "posetitelimyaDataGridViewTextBoxColumn";
            // 
            // nomertelefonaDataGridViewTextBoxColumn
            // 
            this.nomertelefonaDataGridViewTextBoxColumn.DataPropertyName = "Nomer_telefona";
            this.nomertelefonaDataGridViewTextBoxColumn.HeaderText = "Nomer_telefona";
            this.nomertelefonaDataGridViewTextBoxColumn.Name = "nomertelefonaDataGridViewTextBoxColumn";
            // 
            // posetitelBindingSource
            // 
            this.posetitelBindingSource.DataMember = "Posetitel\'";
            this.posetitelBindingSource.DataSource = this.zayDBDataSet;
            // 
            // zayDBDataSet
            // 
            this.zayDBDataSet.DataSetName = "zayDBDataSet";
            this.zayDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // posetitel_TableAdapter
            // 
            this.posetitel_TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDДанныеОбУслугеDataGridViewTextBoxColumn,
            this.nomerstolaDataGridViewTextBoxColumn,
            this.vremyabroniDataGridViewTextBoxColumn,
            this.cenayslygiDataGridViewTextBoxColumn,
            this.ID_Naimenovanie_yslygi});
            this.dataGridView2.DataSource = this.dannieobyslygeBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 185);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(555, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // iDДанныеОбУслугеDataGridViewTextBoxColumn
            // 
            this.iDДанныеОбУслугеDataGridViewTextBoxColumn.DataPropertyName = "ID_Данные об услуге";
            this.iDДанныеОбУслугеDataGridViewTextBoxColumn.HeaderText = "ID_Данные об услуге";
            this.iDДанныеОбУслугеDataGridViewTextBoxColumn.Name = "iDДанныеОбУслугеDataGridViewTextBoxColumn";
            // 
            // nomerstolaDataGridViewTextBoxColumn
            // 
            this.nomerstolaDataGridViewTextBoxColumn.DataPropertyName = "Nomer_stola";
            this.nomerstolaDataGridViewTextBoxColumn.HeaderText = "Nomer_stola";
            this.nomerstolaDataGridViewTextBoxColumn.Name = "nomerstolaDataGridViewTextBoxColumn";
            // 
            // vremyabroniDataGridViewTextBoxColumn
            // 
            this.vremyabroniDataGridViewTextBoxColumn.DataPropertyName = "Vremya_broni";
            this.vremyabroniDataGridViewTextBoxColumn.HeaderText = "Vremya_broni";
            this.vremyabroniDataGridViewTextBoxColumn.Name = "vremyabroniDataGridViewTextBoxColumn";
            // 
            // cenayslygiDataGridViewTextBoxColumn
            // 
            this.cenayslygiDataGridViewTextBoxColumn.DataPropertyName = "Cena_yslygi";
            this.cenayslygiDataGridViewTextBoxColumn.HeaderText = "Cena_yslygi";
            this.cenayslygiDataGridViewTextBoxColumn.Name = "cenayslygiDataGridViewTextBoxColumn";
            // 
            // ID_Naimenovanie_yslygi
            // 
            this.ID_Naimenovanie_yslygi.DataPropertyName = "ID_Naimenovanie_yslygi";
            this.ID_Naimenovanie_yslygi.DataSource = this.naimenovanieyslygiBindingSource1;
            this.ID_Naimenovanie_yslygi.DisplayMember = "Vid";
            this.ID_Naimenovanie_yslygi.HeaderText = "ID_Naimenovanie_yslygi";
            this.ID_Naimenovanie_yslygi.Name = "ID_Naimenovanie_yslygi";
            this.ID_Naimenovanie_yslygi.ValueMember = "ID_Naimenovanie yslugi";
            // 
            // naimenovanieyslygiBindingSource1
            // 
            this.naimenovanieyslygiBindingSource1.DataMember = "Naimenovanie_yslygi";
            this.naimenovanieyslygiBindingSource1.DataSource = this.zayDBDataSet;
            // 
            // dannieobyslygeBindingSource
            // 
            this.dannieobyslygeBindingSource.DataMember = "Dannie_ob_yslyge";
            this.dannieobyslygeBindingSource.DataSource = this.zayDBDataSet;
            // 
            // dannie_ob_yslygeTableAdapter
            // 
            this.dannie_ob_yslygeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDNaimenovanieYslugiDataGridViewTextBoxColumn,
            this.vidDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.naimenovanieyslygiBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 13);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(252, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // iDNaimenovanieYslugiDataGridViewTextBoxColumn
            // 
            this.iDNaimenovanieYslugiDataGridViewTextBoxColumn.DataPropertyName = "ID_Naimenovanie yslugi";
            this.iDNaimenovanieYslugiDataGridViewTextBoxColumn.HeaderText = "ID_Naimenovanie yslugi";
            this.iDNaimenovanieYslugiDataGridViewTextBoxColumn.Name = "iDNaimenovanieYslugiDataGridViewTextBoxColumn";
            // 
            // vidDataGridViewTextBoxColumn
            // 
            this.vidDataGridViewTextBoxColumn.DataPropertyName = "Vid";
            this.vidDataGridViewTextBoxColumn.HeaderText = "Vid";
            this.vidDataGridViewTextBoxColumn.Name = "vidDataGridViewTextBoxColumn";
            // 
            // naimenovanieyslygiBindingSource
            // 
            this.naimenovanieyslygiBindingSource.DataMember = "Naimenovanie_yslygi";
            this.naimenovanieyslygiBindingSource.DataSource = this.zayDBDataSet;
            // 
            // naimenovanie_yslygiTableAdapter
            // 
            this.naimenovanie_yslygiTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(511, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(511, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(511, 412);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(583, 185);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(583, 215);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Найти";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(583, 244);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(270, 13);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "Добавить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(270, 42);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 11;
            this.button9.Text = "Найти";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(270, 71);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 12;
            this.button10.Text = "Сохранить";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(713, 433);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 46);
            this.button11.TabIndex = 13;
            this.button11.Text = "Следующая страница";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zaycev.Properties.Resources._2021_05_29_18_02_18;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form7";
            this.Text = "Все бизнеспроцессы";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posetitelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naimenovanieyslygiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dannieobyslygeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naimenovanieyslygiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public zayDBDataSet zayDBDataSet;
        public System.Windows.Forms.BindingSource posetitelBindingSource;
        public zayDBDataSetTableAdapters.Posetitel_TableAdapter posetitel_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPosititelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posetitelfamiliyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posetitelimyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomertelefonaDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.BindingSource dannieobyslygeBindingSource;
        public zayDBDataSetTableAdapters.Dannie_ob_yslygeTableAdapter dannie_ob_yslygeTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView3;
        public System.Windows.Forms.BindingSource naimenovanieyslygiBindingSource;
        public zayDBDataSetTableAdapters.Naimenovanie_yslygiTableAdapter naimenovanie_yslygiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDNaimenovanieYslugiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDДанныеОбУслугеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerstolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vremyabroniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenayslygiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Naimenovanie_yslygi;
        private System.Windows.Forms.BindingSource naimenovanieyslygiBindingSource1;
        private System.Windows.Forms.Button button11;
    }
}