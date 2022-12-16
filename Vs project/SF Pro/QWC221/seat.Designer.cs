namespace QWC221
{
    partial class seat
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
            this.seatclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stadiumnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketbookingDataSet = new QWC221.TicketbookingDataSet();
            this.seatTableAdapter = new QWC221.TicketbookingDataSetTableAdapters.seatTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketbookingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seatclassDataGridViewTextBoxColumn,
            this.seatidDataGridViewTextBoxColumn,
            this.stadiumnameDataGridViewTextBoxColumn,
            this.seatnumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.seatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(673, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // seatclassDataGridViewTextBoxColumn
            // 
            this.seatclassDataGridViewTextBoxColumn.DataPropertyName = "seat_class";
            this.seatclassDataGridViewTextBoxColumn.HeaderText = "seat_class";
            this.seatclassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seatclassDataGridViewTextBoxColumn.Name = "seatclassDataGridViewTextBoxColumn";
            this.seatclassDataGridViewTextBoxColumn.Width = 125;
            // 
            // seatidDataGridViewTextBoxColumn
            // 
            this.seatidDataGridViewTextBoxColumn.DataPropertyName = "seat_id";
            this.seatidDataGridViewTextBoxColumn.HeaderText = "seat_id";
            this.seatidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seatidDataGridViewTextBoxColumn.Name = "seatidDataGridViewTextBoxColumn";
            this.seatidDataGridViewTextBoxColumn.Width = 125;
            // 
            // stadiumnameDataGridViewTextBoxColumn
            // 
            this.stadiumnameDataGridViewTextBoxColumn.DataPropertyName = "stadium_name";
            this.stadiumnameDataGridViewTextBoxColumn.HeaderText = "stadium_name";
            this.stadiumnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stadiumnameDataGridViewTextBoxColumn.Name = "stadiumnameDataGridViewTextBoxColumn";
            this.stadiumnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // seatnumberDataGridViewTextBoxColumn
            // 
            this.seatnumberDataGridViewTextBoxColumn.DataPropertyName = "seat_number";
            this.seatnumberDataGridViewTextBoxColumn.HeaderText = "seat_number";
            this.seatnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seatnumberDataGridViewTextBoxColumn.Name = "seatnumberDataGridViewTextBoxColumn";
            this.seatnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // seatBindingSource
            // 
            this.seatBindingSource.DataMember = "seat";
            this.seatBindingSource.DataSource = this.ticketbookingDataSet;
            // 
            // ticketbookingDataSet
            // 
            this.ticketbookingDataSet.DataSetName = "TicketbookingDataSet";
            this.ticketbookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seatTableAdapter
            // 
            this.seatTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 358);
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
            // seat
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
            this.Name = "seat";
            this.Text = "seat";
            this.Load += new System.EventHandler(this.seat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketbookingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TicketbookingDataSet ticketbookingDataSet;
        private System.Windows.Forms.BindingSource seatBindingSource;
        private TicketbookingDataSetTableAdapters.seatTableAdapter seatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stadiumnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}