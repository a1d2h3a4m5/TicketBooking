namespace QWC221
{
    partial class matches
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
            this.matchnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stadiumnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ticketbookingDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ticketbookingDataSet = new QWC221.TicketbookingDataSet();
            this.matchesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.matchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matchesTableAdapter = new QWC221.TicketbookingDataSetTableAdapters.matchesTableAdapter();
            this.ticketbookingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matchesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketbookingDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketbookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketbookingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matchnameDataGridViewTextBoxColumn,
            this.matchdateDataGridViewTextBoxColumn,
            this.stadiumnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.matchesBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 303);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // matchnameDataGridViewTextBoxColumn
            // 
            this.matchnameDataGridViewTextBoxColumn.DataPropertyName = "match_name";
            this.matchnameDataGridViewTextBoxColumn.HeaderText = "match_name";
            this.matchnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matchnameDataGridViewTextBoxColumn.Name = "matchnameDataGridViewTextBoxColumn";
            this.matchnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // matchdateDataGridViewTextBoxColumn
            // 
            this.matchdateDataGridViewTextBoxColumn.DataPropertyName = "match_date";
            this.matchdateDataGridViewTextBoxColumn.HeaderText = "match_date";
            this.matchdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matchdateDataGridViewTextBoxColumn.Name = "matchdateDataGridViewTextBoxColumn";
            this.matchdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // stadiumnameDataGridViewTextBoxColumn
            // 
            this.stadiumnameDataGridViewTextBoxColumn.DataPropertyName = "stadium_name";
            this.stadiumnameDataGridViewTextBoxColumn.HeaderText = "stadium_name";
            this.stadiumnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stadiumnameDataGridViewTextBoxColumn.Name = "stadiumnameDataGridViewTextBoxColumn";
            this.stadiumnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // matchesBindingSource3
            // 
            this.matchesBindingSource3.DataMember = "matches";
            this.matchesBindingSource3.DataSource = this.ticketbookingDataSetBindingSource1;
            // 
            // ticketbookingDataSetBindingSource1
            // 
            this.ticketbookingDataSetBindingSource1.DataSource = this.ticketbookingDataSet;
            this.ticketbookingDataSetBindingSource1.Position = 0;
            // 
            // ticketbookingDataSet
            // 
            this.ticketbookingDataSet.DataSetName = "TicketbookingDataSet";
            this.ticketbookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matchesBindingSource1
            // 
            this.matchesBindingSource1.DataMember = "matches";
            this.matchesBindingSource1.DataSource = this.ticketbookingDataSet;
            // 
            // matchesBindingSource
            // 
            this.matchesBindingSource.DataMember = "matches";
            this.matchesBindingSource.DataSource = this.ticketbookingDataSet;
            // 
            // matchesTableAdapter
            // 
            this.matchesTableAdapter.ClearBeforeFill = true;
            // 
            // ticketbookingDataSetBindingSource
            // 
            this.ticketbookingDataSetBindingSource.DataSource = this.ticketbookingDataSet;
            this.ticketbookingDataSetBindingSource.Position = 0;
            // 
            // matchesBindingSource2
            // 
            this.matchesBindingSource2.DataMember = "matches";
            this.matchesBindingSource2.DataSource = this.ticketbookingDataSetBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel2.Location = new System.Drawing.Point(773, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(15, 16);
            this.linkLabel2.TabIndex = 25;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "X";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // matches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QWC221.Properties.Resources.d7b20c142069201_625ffbdb35502;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "matches";
            this.Text = "matches";
            this.Load += new System.EventHandler(this.matches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketbookingDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketbookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketbookingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TicketbookingDataSet ticketbookingDataSet;
        private System.Windows.Forms.BindingSource matchesBindingSource;
        private TicketbookingDataSetTableAdapters.matchesTableAdapter matchesTableAdapter;
        private System.Windows.Forms.BindingSource matchesBindingSource1;
        private System.Windows.Forms.BindingSource matchesBindingSource2;
        private System.Windows.Forms.BindingSource ticketbookingDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stadiumnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource matchesBindingSource3;
        private System.Windows.Forms.BindingSource ticketbookingDataSetBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}