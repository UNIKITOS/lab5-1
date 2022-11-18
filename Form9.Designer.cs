
namespace Zaycev
{
    partial class Form9
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
            this.iDSpisokTovarovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaza1edinicyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolichestvoTovaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTovarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spisokTovarovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zayDBDataSet = new Zaycev.zayDBDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDTipDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanietipaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDTovarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanietovaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spisok_tovarovTableAdapter = new Zaycev.zayDBDataSetTableAdapters.Spisok_tovarovTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tipTableAdapter = new Zaycev.zayDBDataSetTableAdapters.TipTableAdapter();
            this.tovarTableAdapter = new Zaycev.zayDBDataSetTableAdapters.TovarTableAdapter();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.iDBrandDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovanieBrandaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandTableAdapter = new Zaycev.zayDBDataSetTableAdapters.BrandTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spisokTovarovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSpisokTovarovDataGridViewTextBoxColumn,
            this.cenaza1edinicyDataGridViewTextBoxColumn,
            this.kolichestvoTovaraDataGridViewTextBoxColumn,
            this.iDTovarDataGridViewTextBoxColumn,
            this.iDBrandDataGridViewTextBoxColumn,
            this.iDTipDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spisokTovarovBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDSpisokTovarovDataGridViewTextBoxColumn
            // 
            this.iDSpisokTovarovDataGridViewTextBoxColumn.DataPropertyName = "ID_Spisok tovarov";
            this.iDSpisokTovarovDataGridViewTextBoxColumn.HeaderText = "ID_Spisok tovarov";
            this.iDSpisokTovarovDataGridViewTextBoxColumn.Name = "iDSpisokTovarovDataGridViewTextBoxColumn";
            // 
            // cenaza1edinicyDataGridViewTextBoxColumn
            // 
            this.cenaza1edinicyDataGridViewTextBoxColumn.DataPropertyName = "Cena_za_1_edinicy";
            this.cenaza1edinicyDataGridViewTextBoxColumn.HeaderText = "Cena_za_1_edinicy";
            this.cenaza1edinicyDataGridViewTextBoxColumn.Name = "cenaza1edinicyDataGridViewTextBoxColumn";
            // 
            // kolichestvoTovaraDataGridViewTextBoxColumn
            // 
            this.kolichestvoTovaraDataGridViewTextBoxColumn.DataPropertyName = "Kolichestvo tovara";
            this.kolichestvoTovaraDataGridViewTextBoxColumn.HeaderText = "Kolichestvo tovara";
            this.kolichestvoTovaraDataGridViewTextBoxColumn.Name = "kolichestvoTovaraDataGridViewTextBoxColumn";
            // 
            // iDTovarDataGridViewTextBoxColumn
            // 
            this.iDTovarDataGridViewTextBoxColumn.DataPropertyName = "ID_Tovar";
            this.iDTovarDataGridViewTextBoxColumn.HeaderText = "ID_Tovar";
            this.iDTovarDataGridViewTextBoxColumn.Name = "iDTovarDataGridViewTextBoxColumn";
            // 
            // iDBrandDataGridViewTextBoxColumn
            // 
            this.iDBrandDataGridViewTextBoxColumn.DataPropertyName = "ID_Brand";
            this.iDBrandDataGridViewTextBoxColumn.HeaderText = "ID_Brand";
            this.iDBrandDataGridViewTextBoxColumn.Name = "iDBrandDataGridViewTextBoxColumn";
            // 
            // iDTipDataGridViewTextBoxColumn
            // 
            this.iDTipDataGridViewTextBoxColumn.DataPropertyName = "ID_Tip";
            this.iDTipDataGridViewTextBoxColumn.HeaderText = "ID_Tip";
            this.iDTipDataGridViewTextBoxColumn.Name = "iDTipDataGridViewTextBoxColumn";
            // 
            // spisokTovarovBindingSource
            // 
            this.spisokTovarovBindingSource.DataMember = "Spisok tovarov";
            this.spisokTovarovBindingSource.DataSource = this.zayDBDataSet;
            // 
            // zayDBDataSet
            // 
            this.zayDBDataSet.DataSetName = "zayDBDataSet";
            this.zayDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTipDataGridViewTextBoxColumn1,
            this.naimenovanietipaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tipBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 172);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(253, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // iDTipDataGridViewTextBoxColumn1
            // 
            this.iDTipDataGridViewTextBoxColumn1.DataPropertyName = "ID_Tip";
            this.iDTipDataGridViewTextBoxColumn1.HeaderText = "ID_Tip";
            this.iDTipDataGridViewTextBoxColumn1.Name = "iDTipDataGridViewTextBoxColumn1";
            // 
            // naimenovanietipaDataGridViewTextBoxColumn
            // 
            this.naimenovanietipaDataGridViewTextBoxColumn.DataPropertyName = "Naimenovanie_tipa";
            this.naimenovanietipaDataGridViewTextBoxColumn.HeaderText = "Naimenovanie_tipa";
            this.naimenovanietipaDataGridViewTextBoxColumn.Name = "naimenovanietipaDataGridViewTextBoxColumn";
            // 
            // tipBindingSource
            // 
            this.tipBindingSource.DataMember = "Tip";
            this.tipBindingSource.DataSource = this.zayDBDataSet;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTovarDataGridViewTextBoxColumn1,
            this.naimenovanietovaraDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.tovarBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 337);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(253, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // iDTovarDataGridViewTextBoxColumn1
            // 
            this.iDTovarDataGridViewTextBoxColumn1.DataPropertyName = "ID_Tovar";
            this.iDTovarDataGridViewTextBoxColumn1.HeaderText = "ID_Tovar";
            this.iDTovarDataGridViewTextBoxColumn1.Name = "iDTovarDataGridViewTextBoxColumn1";
            // 
            // naimenovanietovaraDataGridViewTextBoxColumn
            // 
            this.naimenovanietovaraDataGridViewTextBoxColumn.DataPropertyName = "Naimenovanie_tovara";
            this.naimenovanietovaraDataGridViewTextBoxColumn.HeaderText = "Naimenovanie_tovara";
            this.naimenovanietovaraDataGridViewTextBoxColumn.Name = "naimenovanietovaraDataGridViewTextBoxColumn";
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "Tovar";
            this.tovarBindingSource.DataSource = this.zayDBDataSet;
            // 
            // spisok_tovarovTableAdapter
            // 
            this.spisok_tovarovTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(671, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(672, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(671, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tipTableAdapter
            // 
            this.tipTableAdapter.ClearBeforeFill = true;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBrandDataGridViewTextBoxColumn1,
            this.naimenovanieBrandaDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.brandBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(412, 172);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(253, 150);
            this.dataGridView4.TabIndex = 7;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // iDBrandDataGridViewTextBoxColumn1
            // 
            this.iDBrandDataGridViewTextBoxColumn1.DataPropertyName = "ID_Brand";
            this.iDBrandDataGridViewTextBoxColumn1.HeaderText = "ID_Brand";
            this.iDBrandDataGridViewTextBoxColumn1.Name = "iDBrandDataGridViewTextBoxColumn1";
            // 
            // naimenovanieBrandaDataGridViewTextBoxColumn
            // 
            this.naimenovanieBrandaDataGridViewTextBoxColumn.DataPropertyName = "naimenovanie branda";
            this.naimenovanieBrandaDataGridViewTextBoxColumn.HeaderText = "naimenovanie branda";
            this.naimenovanieBrandaDataGridViewTextBoxColumn.Name = "naimenovanieBrandaDataGridViewTextBoxColumn";
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataMember = "Brand";
            this.brandBindingSource.DataSource = this.zayDBDataSet;
            // 
            // brandTableAdapter
            // 
            this.brandTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(286, 172);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(286, 201);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Найти";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(286, 230);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(286, 337);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "Добавить";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(286, 367);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 12;
            this.button9.Text = "Найти";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(286, 397);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 13;
            this.button10.Text = "сохранить";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(687, 172);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 14;
            this.button11.Text = "Добавить";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(988, 172);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 15;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(687, 201);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 16;
            this.button13.Text = "Найти";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(687, 229);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 17;
            this.button14.Text = "Сохранить";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zaycev.Properties.Resources._2021_05_29_18_02_18;
            this.ClientSize = new System.Drawing.Size(808, 531);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form9";
            this.Text = "Все бизнес процессы";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spisokTovarovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DataGridView dataGridView3;
        public zayDBDataSet zayDBDataSet;
        public System.Windows.Forms.BindingSource spisokTovarovBindingSource;
        public zayDBDataSetTableAdapters.Spisok_tovarovTableAdapter spisok_tovarovTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSpisokTovarovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaza1edinicyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolichestvoTovaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTovarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTipDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.BindingSource tipBindingSource;
        public zayDBDataSetTableAdapters.TipTableAdapter tipTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn iDTipDataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridViewTextBoxColumn naimenovanietipaDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource tovarBindingSource;
        public zayDBDataSetTableAdapters.TovarTableAdapter tovarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTovarDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanietovaraDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView4;
        public System.Windows.Forms.BindingSource brandBindingSource;
        public zayDBDataSetTableAdapters.BrandTableAdapter brandTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBrandDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovanieBrandaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
    }
}