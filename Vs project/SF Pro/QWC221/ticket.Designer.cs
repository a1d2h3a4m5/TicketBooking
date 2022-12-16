namespace QWC221
{
    partial class ticket
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
            this.ticketbookingDataSet = new QWC221.TicketbookingDataSet();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTableAdapter = new QWC221.TicketbookingDataSetTableAdapters.ticketTableAdapter();
            this.ticketbookingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stadiumnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ticketBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ticketbookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketbookingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketbookingDataSet
            // 
            this.ticketbookingDataSet.DataSetName = "TicketbookingDataSet";
            this.ticketbookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.CurrentChanged += new System.EventHandler(this.ticketBindingSource_CurrentChanged);
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // ticketbookingDataSetBindingSource
            // 
            this.ticketbookingDataSetBindingSource.DataSource = this.ticketbookingDataSet;
            this.ticketbookingDataSetBindingSource.Position = 0;
            // 
            // ticketBindingSource1
            // 
            this.ticketBindingSource1.DataMember = "ticket";
            this.ticketBindingSource1.DataSource = this.ticketbookingDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tidDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.stadiumnameDataGridViewTextBoxColumn,
            this.matchnameDataGridViewTextBoxColumn,
            this.seatidDataGridViewTextBoxColumn,
            this.cidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ticketBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(811, 270);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_3);
            // 
            // tidDataGridViewTextBoxColumn
            // 
            this.tidDataGridViewTextBoxColumn.DataPropertyName = "t_id";
            this.tidDataGridViewTextBoxColumn.HeaderText = "t_id";
            this.tidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tidDataGridViewTextBoxColumn.Name = "tidDataGridViewTextBoxColumn";
            this.tidDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // stadiumnameDataGridViewTextBoxColumn
            // 
            this.stadiumnameDataGridViewTextBoxColumn.DataPropertyName = "stadium_name";
            this.stadiumnameDataGridViewTextBoxColumn.HeaderText = "stadium_name";
            this.stadiumnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stadiumnameDataGridViewTextBoxColumn.Name = "stadiumnameDataGridViewTextBoxColumn";
            this.stadiumnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // matchnameDataGridViewTextBoxColumn
            // 
            this.matchnameDataGridViewTextBoxColumn.DataPropertyName = "match_name";
            this.matchnameDataGridViewTextBoxColumn.HeaderText = "match_name";
            this.matchnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matchnameDataGridViewTextBoxColumn.Name = "matchnameDataGridViewTextBoxColumn";
            this.matchnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // seatidDataGridViewTextBoxColumn
            // 
            this.seatidDataGridViewTextBoxColumn.DataPropertyName = "seat_id";
            this.seatidDataGridViewTextBoxColumn.HeaderText = "seat_id";
            this.seatidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seatidDataGridViewTextBoxColumn.Name = "seatidDataGridViewTextBoxColumn";
            this.seatidDataGridViewTextBoxColumn.Width = 125;
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "c_id";
            this.cidDataGridViewTextBoxColumn.HeaderText = "c_id";
            this.cidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            this.cidDataGridViewTextBoxColumn.Width = 125;
            // 
            // ticketBindingSource3
            // 
            this.ticketBindingSource3.DataMember = "ticket";
            this.ticketBindingSource3.DataSource = this.ticketbookingDataSet;
            // 
            // ticketBindingSource2
            // 
            this.ticketBindingSource2.DataMember = "ticket";
            this.ticketBindingSource2.DataSource = this.ticketbookingDataSetBindingSource;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(12, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel2.Location = new System.Drawing.Point(888, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(15, 16);
            this.linkLabel2.TabIndex = 25;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "X";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QWC221.Properties.Resources.d7b20c142069201_625ffbdb35502;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ticket";
            this.Text = "ticket";
            this.Load += new System.EventHandler(this.ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketbookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketbookingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TicketbookingDataSet ticketbookingDataSet;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private TicketbookingDataSetTableAdapters.ticketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.BindingSource ticketbookingDataSetBindingSource;
        private System.Windows.Forms.BindingSource ticketBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stadiumnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ticketBindingSource2;
        private System.Windows.Forms.BindingSource ticketBindingSource3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}