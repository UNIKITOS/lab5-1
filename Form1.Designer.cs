
namespace Zaycev
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDByhgalteriyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grafikrabotiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Spisok_tovarov = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.spisokTovarovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zayDBDataSet = new Zaycev.zayDBDataSet();
            this.ID_Sotrudnik = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.byhgalteriyaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.byhgalteriyaTableAdapter = new Zaycev.zayDBDataSetTableAdapters.ByhgalteriyaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.spisok_tovarovTableAdapter = new Zaycev.zayDBDataSetTableAdapters.Spisok_tovarovTableAdapter();
            this.sotrudnikTableAdapter = new Zaycev.zayDBDataSetTableAdapters.SotrudnikTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spisokTovarovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.byhgalteriyaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDByhgalteriyaDataGridViewTextBoxColumn,
            this.grafikrabotiDataGridViewTextBoxColumn,
            this.ID_Spisok_tovarov,
            this.ID_Sotrudnik});
            this.dataGridView1.DataSource = this.byhgalteriyaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(588, 129);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // iDByhgalteriyaDataGridViewTextBoxColumn
            // 
            this.iDByhgalteriyaDataGridViewTextBoxColumn.DataPropertyName = "ID_Byhgalteriya";
            this.iDByhgalteriyaDataGridViewTextBoxColumn.HeaderText = "ID_Byhgalteriya";
            this.iDByhgalteriyaDataGridViewTextBoxColumn.Name = "iDByhgalteriyaDataGridViewTextBoxColumn";
            this.iDByhgalteriyaDataGridViewTextBoxColumn.Width = 150;
            // 
            // grafikrabotiDataGridViewTextBoxColumn
            // 
            this.grafikrabotiDataGridViewTextBoxColumn.DataPropertyName = "Grafik_raboti";
            this.grafikrabotiDataGridViewTextBoxColumn.HeaderText = "Grafik_raboti";
            this.grafikrabotiDataGridViewTextBoxColumn.Name = "grafikrabotiDataGridViewTextBoxColumn";
            // 
            // ID_Spisok_tovarov
            // 
            this.ID_Spisok_tovarov.DataPropertyName = "ID_Spisok_tovarov";
            this.ID_Spisok_tovarov.DataSource = this.spisokTovarovBindingSource;
            this.ID_Spisok_tovarov.DisplayMember = "Cena_za_1_edinicy";
            this.ID_Spisok_tovarov.HeaderText = "ID_Spisok_tovarov";
            this.ID_Spisok_tovarov.Name = "ID_Spisok_tovarov";
            this.ID_Spisok_tovarov.ValueMember = "ID_Spisok tovarov";
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
            // byhgalteriyaBindingSource
            // 
            this.byhgalteriyaBindingSource.DataMember = "Byhgalteriya";
            this.byhgalteriyaBindingSource.DataSource = this.zayDBDataSet;
            // 
            // byhgalteriyaTableAdapter
            // 
            this.byhgalteriyaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(643, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(643, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Закрыть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(845, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "Таблица: \"Закупка товаров\"";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // spisok_tovarovTableAdapter
            // 
            this.spisok_tovarovTableAdapter.ClearBeforeFill = true;
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(643, 137);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(845, 331);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 58);
            this.button6.TabIndex = 6;
            this.button6.Text = "Таблица: \"Приобретение услуги\"";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(845, 281);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 44);
            this.button7.TabIndex = 7;
            this.button7.Text = "Все бизнес процессы";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zaycev.Properties.Resources._2021_05_29_18_02_18;
            this.ClientSize = new System.Drawing.Size(962, 457);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Бухгалтерия";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spisokTovarovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.byhgalteriyaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public zayDBDataSet zayDBDataSet;
        public System.Windows.Forms.BindingSource byhgalteriyaBindingSource;
        public zayDBDataSetTableAdapters.ByhgalteriyaTableAdapter byhgalteriyaTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource spisokTovarovBindingSource;
        private zayDBDataSetTableAdapters.Spisok_tovarovTableAdapter spisok_tovarovTableAdapter;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private zayDBDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDByhgalteriyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grafikrabotiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Spisok_tovarov;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Sotrudnik;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

