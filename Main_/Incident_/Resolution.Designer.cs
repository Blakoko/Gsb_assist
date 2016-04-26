namespace GSBASSIST
{
    partial class Resolution
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Groupbox_Incident = new System.Windows.Forms.GroupBox();
            this.Label_Numero_Ticket = new System.Windows.Forms.Label();
            this.Date_Resolution = new System.Windows.Forms.DateTimePicker();
            this.Label_Solution = new System.Windows.Forms.Label();
            this.Label_Date = new System.Windows.Forms.Label();
            this.Label_Ticket = new System.Windows.Forms.Label();
            this.Textbox_Solution = new System.Windows.Forms.TextBox();
            this.Button_Resoudre_Incident = new System.Windows.Forms.Button();
            this.gsbassistanceDataSet4 = new GSBASSIST.gsbassistanceDataSet4();
            this.incidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidentTableAdapter = new GSBASSIST.gsbassistanceDataSet4TableAdapters.incidentTableAdapter();
            this.Groupbox_Incident.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gsbassistanceDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(524, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Groupbox_Incident
            // 
            this.Groupbox_Incident.Controls.Add(this.Label_Numero_Ticket);
            this.Groupbox_Incident.Controls.Add(this.Date_Resolution);
            this.Groupbox_Incident.Controls.Add(this.Label_Solution);
            this.Groupbox_Incident.Controls.Add(this.Label_Date);
            this.Groupbox_Incident.Controls.Add(this.Label_Ticket);
            this.Groupbox_Incident.Controls.Add(this.Textbox_Solution);
            this.Groupbox_Incident.Dock = System.Windows.Forms.DockStyle.Top;
            this.Groupbox_Incident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Groupbox_Incident.Location = new System.Drawing.Point(0, 100);
            this.Groupbox_Incident.Name = "Groupbox_Incident";
            this.Groupbox_Incident.Size = new System.Drawing.Size(524, 347);
            this.Groupbox_Incident.TabIndex = 1;
            this.Groupbox_Incident.TabStop = false;
            // 
            // Label_Numero_Ticket
            // 
            this.Label_Numero_Ticket.AutoSize = true;
            this.Label_Numero_Ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Numero_Ticket.ForeColor = System.Drawing.Color.Red;
            this.Label_Numero_Ticket.Location = new System.Drawing.Point(160, 27);
            this.Label_Numero_Ticket.Name = "Label_Numero_Ticket";
            this.Label_Numero_Ticket.Size = new System.Drawing.Size(104, 16);
            this.Label_Numero_Ticket.TabIndex = 5;
            this.Label_Numero_Ticket.Text = "numero_ticket";
            // 
            // Date_Resolution
            // 
            this.Date_Resolution.Location = new System.Drawing.Point(163, 72);
            this.Date_Resolution.Name = "Date_Resolution";
            this.Date_Resolution.Size = new System.Drawing.Size(277, 20);
            this.Date_Resolution.TabIndex = 4;
            // 
            // Label_Solution
            // 
            this.Label_Solution.AutoSize = true;
            this.Label_Solution.Location = new System.Drawing.Point(36, 129);
            this.Label_Solution.Name = "Label_Solution";
            this.Label_Solution.Size = new System.Drawing.Size(51, 13);
            this.Label_Solution.TabIndex = 3;
            this.Label_Solution.Text = "Solution :";
            // 
            // Label_Date
            // 
            this.Label_Date.AutoSize = true;
            this.Label_Date.Location = new System.Drawing.Point(36, 78);
            this.Label_Date.Name = "Label_Date";
            this.Label_Date.Size = new System.Drawing.Size(109, 13);
            this.Label_Date.TabIndex = 2;
            this.Label_Date.Text = "Date De Résolution : ";
            // 
            // Label_Ticket
            // 
            this.Label_Ticket.AutoSize = true;
            this.Label_Ticket.Location = new System.Drawing.Point(36, 30);
            this.Label_Ticket.Name = "Label_Ticket";
            this.Label_Ticket.Size = new System.Drawing.Size(66, 13);
            this.Label_Ticket.TabIndex = 1;
            this.Label_Ticket.Text = "N°TICKET : ";
            // 
            // Textbox_Solution
            // 
            this.Textbox_Solution.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Textbox_Solution.Location = new System.Drawing.Point(3, 164);
            this.Textbox_Solution.Multiline = true;
            this.Textbox_Solution.Name = "Textbox_Solution";
            this.Textbox_Solution.Size = new System.Drawing.Size(518, 180);
            this.Textbox_Solution.TabIndex = 0;
            // 
            // Button_Resoudre_Incident
            // 
            this.Button_Resoudre_Incident.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button_Resoudre_Incident.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Button_Resoudre_Incident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Resoudre_Incident.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Resoudre_Incident.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Resoudre_Incident.Location = new System.Drawing.Point(82, 459);
            this.Button_Resoudre_Incident.Name = "Button_Resoudre_Incident";
            this.Button_Resoudre_Incident.Size = new System.Drawing.Size(358, 48);
            this.Button_Resoudre_Incident.TabIndex = 2;
            this.Button_Resoudre_Incident.Text = "VALIDER";
            this.Button_Resoudre_Incident.UseVisualStyleBackColor = false;
            this.Button_Resoudre_Incident.Click += new System.EventHandler(this.Button_Resoudre_Incident_Click);
            // 
            // gsbassistanceDataSet4
            // 
            this.gsbassistanceDataSet4.DataSetName = "gsbassistanceDataSet4";
            this.gsbassistanceDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incidentBindingSource
            // 
            this.incidentBindingSource.DataMember = "incident";
            this.incidentBindingSource.DataSource = this.gsbassistanceDataSet4;
            // 
            // incidentTableAdapter
            // 
            this.incidentTableAdapter.ClearBeforeFill = true;
            // 
            // Resolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 519);
            this.Controls.Add(this.Button_Resoudre_Incident);
            this.Controls.Add(this.Groupbox_Incident);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Resolution";
            this.Text = "Resolution";
            this.Load += new System.EventHandler(this.Resolution_Load);
            this.Groupbox_Incident.ResumeLayout(false);
            this.Groupbox_Incident.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gsbassistanceDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox Groupbox_Incident;
        private System.Windows.Forms.TextBox Textbox_Solution;
        private System.Windows.Forms.Button Button_Resoudre_Incident;
        private System.Windows.Forms.Label Label_Numero_Ticket;
        private System.Windows.Forms.DateTimePicker Date_Resolution;
        private System.Windows.Forms.Label Label_Solution;
        private System.Windows.Forms.Label Label_Date;
        private System.Windows.Forms.Label Label_Ticket;
        private gsbassistanceDataSet4 gsbassistanceDataSet4;
        private System.Windows.Forms.BindingSource incidentBindingSource;
        private gsbassistanceDataSet4TableAdapters.incidentTableAdapter incidentTableAdapter;
    }
}