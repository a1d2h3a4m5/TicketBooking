namespace QWC221
{
    partial class Customer
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
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbrithDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnationalidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ticketbookingDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ticketbookingDataSet = new QWC221.TicketbookingDataSet();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new QWC221.TicketbookingDataSetTableAdapters.customerTableAdapter();
            this.ticketbookingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketbookingDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketbookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketbookingDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn,
            this.cbrithDataGridViewTextBoxColumn,
            this.cnationalidDataGridViewTextBoxColumn,
            this.cemailDataGridViewTextBoxColumn,
            this.cpassDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(882, 314);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "c_id";
            this.cidDataGridViewTextBoxColumn.HeaderText = "c_id";
            this.cidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            this.cidDataGridViewTextBoxColumn.Width = 125;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "c_name";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "c_name";
            this.cnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            this.cnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // cbrithDataGridViewTextBoxColumn
            // 
            this.cbrithDataGridViewTextBoxColumn.DataPropertyName = "c_brith";
            this.cbrithDataGridViewTextBoxColumn.HeaderText = "c_brith";
            this.cbrithDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cbrithDataGridViewTextBoxColumn.Name = "cbrithDataGridViewTextBoxColumn";
            this.cbrithDataGridViewTextBoxColumn.Width = 125;
            // 
            // cnationalidDataGridViewTextBoxColumn
            // 
            this.cnationalidDataGridViewTextBoxColumn.DataPropertyName = "c_national_id";
            this.cnationalidDataGridViewTextBoxColumn.HeaderText = "c_national_id";
            this.cnationalidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cnationalidDataGridViewTextBoxColumn.Name = "cnationalidDataGridViewTextBoxColumn";
            this.cnationalidDataGridViewTextBoxColumn.Width = 125;
            // 
            // cemailDataGridViewTextBoxColumn
            // 
            this.cemailDataGridViewTextBoxColumn.DataPropertyName = "c_email";
            this.cemailDataGridViewTextBoxColumn.HeaderText = "c_email";
            this.cemailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cemailDataGridViewTextBoxColumn.Name = "cemailDataGridViewTextBoxColumn";
            this.cemailDataGridViewTextBoxColumn.Width = 125;
            // 
            // cpassDataGridViewTextBoxColumn
            // 
            this.cpassDataGridViewTextBoxColumn.DataPropertyName = "c_pass";
            this.cpassDataGridViewTextBoxColumn.HeaderText = "c_pass";
            this.cpassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cpassDataGridViewTextBoxColumn.Name = "cpassDataGridViewTextBoxColumn";
            this.cpassDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource2
            // 
            this.customerBindingSource2.DataMember = "customer";
            this.customerBindingSource2.DataSource = this.ticketbookingDataSetBindingSource1;
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
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "customer";
            this.customerBindingSource1.DataSource = this.ticketbookingDataSet;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.ticketbookingDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // ticketbookingDataSetBindingSource
            // 
            this.ticketbookingDataSetBindingSource.DataSource = this.ticketbookingDataSet;
            this.ticketbookingDataSetBindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 41);
            this.button1.TabIndex = 1;
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
            this.linkLabel2.Location = new System.Drawing.Point(879, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(15, 16);
            this.linkLabel2.TabIndex = 26;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "X";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QWC221.Properties.Resources.d7b20c142069201_625ffbdb35502;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 492);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketbookingDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketbookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketbookingDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TicketbookingDataSet ticketbookingDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private TicketbookingDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.BindingSource ticketbookingDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbrithDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnationalidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpassDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerBindingSource2;
        private System.Windows.Forms.BindingSource ticketbookingDataSetBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}