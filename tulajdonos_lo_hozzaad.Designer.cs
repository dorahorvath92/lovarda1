namespace lovarda1
{
    partial class tulajdonos_lo_hozzaad
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
            this.nevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szuletesievDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fajtaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versenyekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadatokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginDataSet = new lovarda1.loginDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.loadatokTableAdapter = new lovarda1.loginDataSetTableAdapters.loadatokTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadatokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nevDataGridViewTextBoxColumn,
            this.szuletesievDataGridViewTextBoxColumn,
            this.fajtaDataGridViewTextBoxColumn,
            this.nemDataGridViewTextBoxColumn,
            this.versenyekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loadatokBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(57, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(702, 177);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nevDataGridViewTextBoxColumn
            // 
            this.nevDataGridViewTextBoxColumn.DataPropertyName = "nev";
            this.nevDataGridViewTextBoxColumn.HeaderText = "nev";
            this.nevDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            this.nevDataGridViewTextBoxColumn.Width = 125;
            // 
            // szuletesievDataGridViewTextBoxColumn
            // 
            this.szuletesievDataGridViewTextBoxColumn.DataPropertyName = "szuletesiev";
            this.szuletesievDataGridViewTextBoxColumn.HeaderText = "szuletesiev";
            this.szuletesievDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.szuletesievDataGridViewTextBoxColumn.Name = "szuletesievDataGridViewTextBoxColumn";
            this.szuletesievDataGridViewTextBoxColumn.Width = 125;
            // 
            // fajtaDataGridViewTextBoxColumn
            // 
            this.fajtaDataGridViewTextBoxColumn.DataPropertyName = "fajta";
            this.fajtaDataGridViewTextBoxColumn.HeaderText = "fajta";
            this.fajtaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fajtaDataGridViewTextBoxColumn.Name = "fajtaDataGridViewTextBoxColumn";
            this.fajtaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nemDataGridViewTextBoxColumn
            // 
            this.nemDataGridViewTextBoxColumn.DataPropertyName = "nem";
            this.nemDataGridViewTextBoxColumn.HeaderText = "nem";
            this.nemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nemDataGridViewTextBoxColumn.Name = "nemDataGridViewTextBoxColumn";
            this.nemDataGridViewTextBoxColumn.Width = 125;
            // 
            // versenyekDataGridViewTextBoxColumn
            // 
            this.versenyekDataGridViewTextBoxColumn.DataPropertyName = "versenyek";
            this.versenyekDataGridViewTextBoxColumn.HeaderText = "versenyek";
            this.versenyekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.versenyekDataGridViewTextBoxColumn.Name = "versenyekDataGridViewTextBoxColumn";
            this.versenyekDataGridViewTextBoxColumn.Width = 125;
            // 
            // loadatokBindingSource
            // 
            this.loadatokBindingSource.DataMember = "loadatok";
            this.loadatokBindingSource.DataSource = this.loginDataSet;
            // 
            // loginDataSet
            // 
            this.loginDataSet.DataSetName = "loginDataSet";
            this.loginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Roseritta", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(57, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ló hozzáadása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Roseritta", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(308, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ló törlése";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // loadatokTableAdapter
            // 
            this.loadatokTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Roseritta", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(568, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 53);
            this.button3.TabIndex = 3;
            this.button3.Text = "Mentés";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tulajdonos_lo_hozzaad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "tulajdonos_lo_hozzaad";
            this.Text = "tulajdonos_lo_hozzaad";
            this.Load += new System.EventHandler(this.tulajdonos_lo_hozzaad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadatokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private loginDataSet loginDataSet;
        private System.Windows.Forms.BindingSource loadatokBindingSource;
        private loginDataSetTableAdapters.loadatokTableAdapter loadatokTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szuletesievDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fajtaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versenyekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}