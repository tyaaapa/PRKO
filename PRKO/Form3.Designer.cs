namespace PRKO
{
    partial class UristForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRKODataSet = new PRKO.PRKODataSet();
            this.pRKODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.абитуриентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.абитуриентTableAdapter = new PRKO.PRKODataSetTableAdapters.АбитуриентTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гражданствоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серияИНомерПаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.улицаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.домDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.факультетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.специальностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.учебноеЗаведениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годОкончанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типДокументаОбОбразованииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерДокументаОбОбразованииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иностранныйЯзыкDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.среднийБаллАттестатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.результатЕГЭDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRKODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRKODataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.абитуриентBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1019, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.полDataGridViewTextBoxColumn,
            this.гражданствоDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.серияИНомерПаспортаDataGridViewTextBoxColumn,
            this.городDataGridViewTextBoxColumn,
            this.улицаDataGridViewTextBoxColumn,
            this.домDataGridViewTextBoxColumn,
            this.факультетDataGridViewTextBoxColumn,
            this.специальностьDataGridViewTextBoxColumn,
            this.учебноеЗаведениеDataGridViewTextBoxColumn,
            this.годОкончанияDataGridViewTextBoxColumn,
            this.типДокументаОбОбразованииDataGridViewTextBoxColumn,
            this.номерДокументаОбОбразованииDataGridViewTextBoxColumn,
            this.иностранныйЯзыкDataGridViewTextBoxColumn,
            this.среднийБаллАттестатаDataGridViewTextBoxColumn,
            this.результатЕГЭDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.абитуриентBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1046, 190);
            this.dataGridView1.TabIndex = 1;
            // 
            // pRKODataSet
            // 
            this.pRKODataSet.DataSetName = "PRKODataSet";
            this.pRKODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRKODataSetBindingSource
            // 
            this.pRKODataSetBindingSource.DataSource = this.pRKODataSet;
            this.pRKODataSetBindingSource.Position = 0;
            // 
            // абитуриентBindingSource
            // 
            this.абитуриентBindingSource.DataMember = "Абитуриент";
            this.абитуриентBindingSource.DataSource = this.pRKODataSetBindingSource;
            // 
            // абитуриентTableAdapter
            // 
            this.абитуриентTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // полDataGridViewTextBoxColumn
            // 
            this.полDataGridViewTextBoxColumn.DataPropertyName = "Пол";
            this.полDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn.Name = "полDataGridViewTextBoxColumn";
            // 
            // гражданствоDataGridViewTextBoxColumn
            // 
            this.гражданствоDataGridViewTextBoxColumn.DataPropertyName = "Гражданство";
            this.гражданствоDataGridViewTextBoxColumn.HeaderText = "Гражданство";
            this.гражданствоDataGridViewTextBoxColumn.Name = "гражданствоDataGridViewTextBoxColumn";
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            // 
            // серияИНомерПаспортаDataGridViewTextBoxColumn
            // 
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.DataPropertyName = "Серия и номер паспорта";
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.HeaderText = "Серия и номер паспорта";
            this.серияИНомерПаспортаDataGridViewTextBoxColumn.Name = "серияИНомерПаспортаDataGridViewTextBoxColumn";
            // 
            // городDataGridViewTextBoxColumn
            // 
            this.городDataGridViewTextBoxColumn.DataPropertyName = "Город";
            this.городDataGridViewTextBoxColumn.HeaderText = "Город";
            this.городDataGridViewTextBoxColumn.Name = "городDataGridViewTextBoxColumn";
            // 
            // улицаDataGridViewTextBoxColumn
            // 
            this.улицаDataGridViewTextBoxColumn.DataPropertyName = "Улица";
            this.улицаDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.улицаDataGridViewTextBoxColumn.Name = "улицаDataGridViewTextBoxColumn";
            // 
            // домDataGridViewTextBoxColumn
            // 
            this.домDataGridViewTextBoxColumn.DataPropertyName = "Дом";
            this.домDataGridViewTextBoxColumn.HeaderText = "Дом";
            this.домDataGridViewTextBoxColumn.Name = "домDataGridViewTextBoxColumn";
            // 
            // факультетDataGridViewTextBoxColumn
            // 
            this.факультетDataGridViewTextBoxColumn.DataPropertyName = "Факультет";
            this.факультетDataGridViewTextBoxColumn.HeaderText = "Факультет";
            this.факультетDataGridViewTextBoxColumn.Name = "факультетDataGridViewTextBoxColumn";
            // 
            // специальностьDataGridViewTextBoxColumn
            // 
            this.специальностьDataGridViewTextBoxColumn.DataPropertyName = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.HeaderText = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.Name = "специальностьDataGridViewTextBoxColumn";
            // 
            // учебноеЗаведениеDataGridViewTextBoxColumn
            // 
            this.учебноеЗаведениеDataGridViewTextBoxColumn.DataPropertyName = "Учебное заведение";
            this.учебноеЗаведениеDataGridViewTextBoxColumn.HeaderText = "Учебное заведение";
            this.учебноеЗаведениеDataGridViewTextBoxColumn.Name = "учебноеЗаведениеDataGridViewTextBoxColumn";
            // 
            // годОкончанияDataGridViewTextBoxColumn
            // 
            this.годОкончанияDataGridViewTextBoxColumn.DataPropertyName = "Год окончания";
            this.годОкончанияDataGridViewTextBoxColumn.HeaderText = "Год окончания";
            this.годОкончанияDataGridViewTextBoxColumn.Name = "годОкончанияDataGridViewTextBoxColumn";
            // 
            // типДокументаОбОбразованииDataGridViewTextBoxColumn
            // 
            this.типДокументаОбОбразованииDataGridViewTextBoxColumn.DataPropertyName = "Тип документа об образовании";
            this.типДокументаОбОбразованииDataGridViewTextBoxColumn.HeaderText = "Тип документа об образовании";
            this.типДокументаОбОбразованииDataGridViewTextBoxColumn.Name = "типДокументаОбОбразованииDataGridViewTextBoxColumn";
            // 
            // номерДокументаОбОбразованииDataGridViewTextBoxColumn
            // 
            this.номерДокументаОбОбразованииDataGridViewTextBoxColumn.DataPropertyName = "Номер документа об образовании";
            this.номерДокументаОбОбразованииDataGridViewTextBoxColumn.HeaderText = "Номер документа об образовании";
            this.номерДокументаОбОбразованииDataGridViewTextBoxColumn.Name = "номерДокументаОбОбразованииDataGridViewTextBoxColumn";
            // 
            // иностранныйЯзыкDataGridViewTextBoxColumn
            // 
            this.иностранныйЯзыкDataGridViewTextBoxColumn.DataPropertyName = "Иностранный язык";
            this.иностранныйЯзыкDataGridViewTextBoxColumn.HeaderText = "Иностранный язык";
            this.иностранныйЯзыкDataGridViewTextBoxColumn.Name = "иностранныйЯзыкDataGridViewTextBoxColumn";
            // 
            // среднийБаллАттестатаDataGridViewTextBoxColumn
            // 
            this.среднийБаллАттестатаDataGridViewTextBoxColumn.DataPropertyName = "Средний балл аттестата";
            this.среднийБаллАттестатаDataGridViewTextBoxColumn.HeaderText = "Средний балл аттестата";
            this.среднийБаллАттестатаDataGridViewTextBoxColumn.Name = "среднийБаллАттестатаDataGridViewTextBoxColumn";
            // 
            // результатЕГЭDataGridViewTextBoxColumn
            // 
            this.результатЕГЭDataGridViewTextBoxColumn.DataPropertyName = "Результат ЕГЭ";
            this.результатЕГЭDataGridViewTextBoxColumn.HeaderText = "Результат ЕГЭ";
            this.результатЕГЭDataGridViewTextBoxColumn.Name = "результатЕГЭDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(115, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(219, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 33);
            this.button4.TabIndex = 4;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // UristForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 447);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "UristForm";
            this.Text = "UristForm";
            this.Load += new System.EventHandler(this.UristForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRKODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRKODataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.абитуриентBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PRKODataSet pRKODataSet;
        private System.Windows.Forms.BindingSource pRKODataSetBindingSource;
        private System.Windows.Forms.BindingSource абитуриентBindingSource;
        private PRKODataSetTableAdapters.АбитуриентTableAdapter абитуриентTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn гражданствоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серияИНомерПаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn улицаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn домDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn факультетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn специальностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn учебноеЗаведениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годОкончанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типДокументаОбОбразованииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДокументаОбОбразованииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иностранныйЯзыкDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn среднийБаллАттестатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn результатЕГЭDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}