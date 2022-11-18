
namespace Zaycev
{
    partial class Form4
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
            this.dannieobyslygeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zayDBDataSet = new Zaycev.zayDBDataSet();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priobretenieYslygiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priobretenie_yslygiTableAdapter = new Zaycev.zayDBDataSetTableAdapters.Priobretenie_yslygiTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.sotrudnikTableAdapter = new Zaycev.zayDBDataSetTableAdapters.SotrudnikTableAdapter();
            this.dannie_ob_yslygeTableAdapter = new Zaycev.zayDBDataSetTableAdapters.Dannie_ob_yslygeTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.priobretenieYslygiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ID_Sotrudnik = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ID_Dannie_ob_yslyge = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDPosetitelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerYslygiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPriobretenieYslygiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dannieobyslygeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priobretenieYslygiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priobretenieYslygiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPriobretenieYslygiDataGridViewTextBoxColumn,
            this.nomerYslygiDataGridViewTextBoxColumn,
            this.iDPosetitelDataGridViewTextBoxColumn,
            this.ID_Dannie_ob_yslyge,
            this.ID_Sotrudnik});
            this.dataGridView1.DataSource = this.priobretenieYslygiBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(569, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dannieobyslygeBindingSource
            // 
            this.dannieobyslygeBindingSource.DataMember = "Dannie_ob_yslyge";
            this.dannieobyslygeBindingSource.DataSource = this.zayDBDataSet;
            // 
            // zayDBDataSet
            // 
            this.zayDBDataSet.DataSetName = "zayDBDataSet";
            this.zayDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.zayDBDataSet;
            // 
            // priobretenieYslygiBindingSource
            // 
            this.priobretenieYslygiBindingSource.DataMember = "Priobretenie yslygi";
            this.priobretenieYslygiBindingSource.DataSource = this.zayDBDataSet;
            // 
            // priobretenie_yslygiTableAdapter
            // 
            this.priobretenie_yslygiTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(598, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(598, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(598, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Закрыть";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // dannie_ob_yslygeTableAdapter
            // 
            this.dannie_ob_yslygeTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(836, 466);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 51);
            this.button5.TabIndex = 5;
            this.button5.Text = "Таблица: \"Закупка товаров\"";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(836, 390);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 49);
            this.button6.TabIndex = 6;
            this.button6.Text = "Таблица: \"Бухгалтерия\"";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(836, 330);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 45);
            this.button7.TabIndex = 7;
            this.button7.Text = "Все бизнес процессы";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // priobretenieYslygiBindingSource1
            // 
            this.priobretenieYslygiBindingSource1.DataMember = "Priobretenie yslygi";
            this.priobretenieYslygiBindingSource1.DataSource = this.zayDBDataSet;
            // 
            // ID_Sotrudnik
            // 
            this.ID_Sotrudnik.DataPropertyName = "ID_Sotrudnik";
            this.ID_Sotrudnik.DataSource = this.sotrudnikBindingSource;
            this.ID_Sotrudnik.DisplayMember = "Data_rojd\'";
            this.ID_Sotrudnik.HeaderText = "ID_Sotrudnik";
            this.ID_Sotrudnik.Name = "ID_Sotrudnik";
            this.ID_Sotrudnik.ValueMember = "ID_Sotrudnik";
            // 
            // ID_Dannie_ob_yslyge
            // 
            this.ID_Dannie_ob_yslyge.DataPropertyName = "ID_Dannie_ob_yslyge";
            this.ID_Dannie_ob_yslyge.DataSource = this.dannieobyslygeBindingSource;
            this.ID_Dannie_ob_yslyge.DisplayMember = "Cena_yslygi";
            this.ID_Dannie_ob_yslyge.HeaderText = "ID_Dannie_ob_yslyge";
            this.ID_Dannie_ob_yslyge.Name = "ID_Dannie_ob_yslyge";
            this.ID_Dannie_ob_yslyge.ValueMember = "ID_Данные об услуге";
            // 
            // iDPosetitelDataGridViewTextBoxColumn
            // 
            this.iDPosetitelDataGridViewTextBoxColumn.DataPropertyName = "ID_Posetitel\'";
            this.iDPosetitelDataGridViewTextBoxColumn.HeaderText = "ID_Posetitel\'";
            this.iDPosetitelDataGridViewTextBoxColumn.Name = "iDPosetitelDataGridViewTextBoxColumn";
            // 
            // nomerYslygiDataGridViewTextBoxColumn
            // 
            this.nomerYslygiDataGridViewTextBoxColumn.DataPropertyName = "Nomer yslygi";
            this.nomerYslygiDataGridViewTextBoxColumn.HeaderText = "Nomer yslygi";
            this.nomerYslygiDataGridViewTextBoxColumn.Name = "nomerYslygiDataGridViewTextBoxColumn";
            // 
            // iDPriobretenieYslygiDataGridViewTextBoxColumn
            // 
            this.iDPriobretenieYslygiDataGridViewTextBoxColumn.DataPropertyName = "ID_Priobretenie yslygi";
            this.iDPriobretenieYslygiDataGridViewTextBoxColumn.HeaderText = "ID_Priobretenie yslygi";
            this.iDPriobretenieYslygiDataGridViewTextBoxColumn.Name = "iDPriobretenieYslygiDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zaycev.Properties.Resources._2021_05_29_18_02_18;
            this.ClientSize = new System.Drawing.Size(963, 545);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Приобретение услуги";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dannieobyslygeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zayDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priobretenieYslygiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priobretenieYslygiBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public zayDBDataSet zayDBDataSet;
        public System.Windows.Forms.BindingSource priobretenieYslygiBindingSource;
        public zayDBDataSetTableAdapters.Priobretenie_yslygiTableAdapter priobretenie_yslygiTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private zayDBDataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.BindingSource dannieobyslygeBindingSource;
        private zayDBDataSetTableAdapters.Dannie_ob_yslygeTableAdapter dannie_ob_yslygeTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.BindingSource priobretenieYslygiBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPriobretenieYslygiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerYslygiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPosetitelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Dannie_ob_yslyge;
        private System.Windows.Forms.DataGridViewComboBoxColumn ID_Sotrudnik;
    }
}