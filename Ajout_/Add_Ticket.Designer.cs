namespace GSBASSIST
{
    partial class Add_Ticket
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Textbox_Add_Ticket_Objet = new System.Windows.Forms.TextBox();
            this.Combo_Add_Ticket_Niveau = new System.Windows.Forms.ComboBox();
            this.niveauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gsbassistanceDataSet = new GSBASSIST.gsbassistanceDataSet();
            this.Combo_Add_Ticket_Equipement = new System.Windows.Forms.ComboBox();
            this.equipementBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gsbassistanceDataSet3 = new GSBASSIST.gsbassistanceDataSet3();
            this.Date_Add_Ticket_Time = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Textbox_Add_Ticket_Techcomm = new System.Windows.Forms.TextBox();
            this.Combo_Add_Ticket_Technicien = new System.Windows.Forms.ComboBox();
            this.utilisateurBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gsbassistanceDataSet2 = new GSBASSIST.gsbassistanceDataSet2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Textbox_Add_Ticket_Mess = new System.Windows.Forms.TextBox();
            this.equipementBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.equipementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipementTableAdapter = new GSBASSIST.gsbassistanceDataSetTableAdapters.equipementTableAdapter();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateurTableAdapter = new GSBASSIST.gsbassistanceDataSetTableAdapters.utilisateurTableAdapter();
            this.utilisateurTableAdapter1 = new GSBASSIST.gsbassistanceDataSet2TableAdapters.utilisateurTableAdapter();
            this.niveauTableAdapter = new GSBASSIST.gsbassistanceDataSetTableAdapters.niveauTableAdapter();
            this.equipementTableAdapter1 = new GSBASSIST.gsbassistanceDataSet3TableAdapters.equipementTableAdapter();
            this.gsbassistanceDataSet4 = new GSBASSIST.gsbassistanceDataSet4();
            this.utilisateurincidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateur_incidentTableAdapter = new GSBASSIST.gsbassistanceDataSet4TableAdapters.utilisateur_incidentTableAdapter();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.niveauBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbassistanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbassistanceDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbassistanceDataSet2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipementBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbassistanceDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurincidentBindingSource)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1148, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 657F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1148, 351);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Textbox_Add_Ticket_Objet);
            this.groupBox1.Controls.Add(this.Combo_Add_Ticket_Niveau);
            this.groupBox1.Controls.Add(this.Combo_Add_Ticket_Equipement);
            this.groupBox1.Controls.Add(this.Date_Add_Ticket_Time);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // Textbox_Add_Ticket_Objet
            // 
            this.Textbox_Add_Ticket_Objet.Location = new System.Drawing.Point(173, 196);
            this.Textbox_Add_Ticket_Objet.Name = "Textbox_Add_Ticket_Objet";
            this.Textbox_Add_Ticket_Objet.Size = new System.Drawing.Size(209, 20);
            this.Textbox_Add_Ticket_Objet.TabIndex = 3;
            // 
            // Combo_Add_Ticket_Niveau
            // 
            this.Combo_Add_Ticket_Niveau.DataSource = this.niveauBindingSource;
            this.Combo_Add_Ticket_Niveau.DisplayMember = "libelle";
            this.Combo_Add_Ticket_Niveau.FormattingEnabled = true;
            this.Combo_Add_Ticket_Niveau.Location = new System.Drawing.Point(173, 85);
            this.Combo_Add_Ticket_Niveau.Name = "Combo_Add_Ticket_Niveau";
            this.Combo_Add_Ticket_Niveau.Size = new System.Drawing.Size(209, 21);
            this.Combo_Add_Ticket_Niveau.TabIndex = 2;
            this.Combo_Add_Ticket_Niveau.ValueMember = "id";
            // 
            // niveauBindingSource
            // 
            this.niveauBindingSource.DataMember = "niveau";
            this.niveauBindingSource.DataSource = this.gsbassistanceDataSet;
            // 
            // gsbassistanceDataSet
            // 
            this.gsbassistanceDataSet.DataSetName = "gsbassistanceDataSet";
            this.gsbassistanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Combo_Add_Ticket_Equipement
            // 
            this.Combo_Add_Ticket_Equipement.DataSource = this.equipementBindingSource2;
            this.Combo_Add_Ticket_Equipement.DisplayMember = "NOM";
            this.Combo_Add_Ticket_Equipement.FormattingEnabled = true;
            this.Combo_Add_Ticket_Equipement.Location = new System.Drawing.Point(173, 140);
            this.Combo_Add_Ticket_Equipement.Name = "Combo_Add_Ticket_Equipement";
            this.Combo_Add_Ticket_Equipement.Size = new System.Drawing.Size(209, 21);
            this.Combo_Add_Ticket_Equipement.TabIndex = 1;
            this.Combo_Add_Ticket_Equipement.ValueMember = "id";
            // 
            // equipementBindingSource2
            // 
            this.equipementBindingSource2.DataMember = "equipement";
            this.equipementBindingSource2.DataSource = this.gsbassistanceDataSet3;
            // 
            // gsbassistanceDataSet3
            // 
            this.gsbassistanceDataSet3.DataSetName = "gsbassistanceDataSet3";
            this.gsbassistanceDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Date_Add_Ticket_Time
            // 
            this.Date_Add_Ticket_Time.Location = new System.Drawing.Point(173, 44);
            this.Date_Add_Ticket_Time.Name = "Date_Add_Ticket_Time";
            this.Date_Add_Ticket_Time.Size = new System.Drawing.Size(209, 20);
            this.Date_Add_Ticket_Time.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(494, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 345);
            this.panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.Textbox_Add_Ticket_Techcomm);
            this.groupBox3.Controls.Add(this.Combo_Add_Ticket_Technicien);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(651, 149);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // Textbox_Add_Ticket_Techcomm
            // 
            this.Textbox_Add_Ticket_Techcomm.Location = new System.Drawing.Point(156, 46);
            this.Textbox_Add_Ticket_Techcomm.Multiline = true;
            this.Textbox_Add_Ticket_Techcomm.Name = "Textbox_Add_Ticket_Techcomm";
            this.Textbox_Add_Ticket_Techcomm.Size = new System.Drawing.Size(446, 93);
            this.Textbox_Add_Ticket_Techcomm.TabIndex = 1;
            // 
            // Combo_Add_Ticket_Technicien
            // 
            this.Combo_Add_Ticket_Technicien.DataSource = this.utilisateurBindingSource1;
            this.Combo_Add_Ticket_Technicien.DisplayMember = "NOm";
            this.Combo_Add_Ticket_Technicien.FormattingEnabled = true;
            this.Combo_Add_Ticket_Technicien.Location = new System.Drawing.Point(156, 19);
            this.Combo_Add_Ticket_Technicien.Name = "Combo_Add_Ticket_Technicien";
            this.Combo_Add_Ticket_Technicien.Size = new System.Drawing.Size(446, 21);
            this.Combo_Add_Ticket_Technicien.TabIndex = 0;
            this.Combo_Add_Ticket_Technicien.ValueMember = "id";
            // 
            // utilisateurBindingSource1
            // 
            this.utilisateurBindingSource1.DataMember = "utilisateur";
            this.utilisateurBindingSource1.DataSource = this.gsbassistanceDataSet2;
            // 
            // gsbassistanceDataSet2
            // 
            this.gsbassistanceDataSet2.DataSetName = "gsbassistanceDataSet2";
            this.gsbassistanceDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Textbox_Add_Ticket_Mess);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 177);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message De L\'utilisateur";
            // 
            // Textbox_Add_Ticket_Mess
            // 
            this.Textbox_Add_Ticket_Mess.Location = new System.Drawing.Point(147, 44);
            this.Textbox_Add_Ticket_Mess.Multiline = true;
            this.Textbox_Add_Ticket_Mess.Name = "Textbox_Add_Ticket_Mess";
            this.Textbox_Add_Ticket_Mess.Size = new System.Drawing.Size(378, 117);
            this.Textbox_Add_Ticket_Mess.TabIndex = 0;
            // 
            // equipementBindingSource1
            // 
            this.equipementBindingSource1.DataMember = "equipement";
            this.equipementBindingSource1.DataSource = this.gsbassistanceDataSet3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // equipementBindingSource
            // 
            this.equipementBindingSource.DataMember = "equipement";
            this.equipementBindingSource.DataSource = this.gsbassistanceDataSet;
            // 
            // equipementTableAdapter
            // 
            this.equipementTableAdapter.ClearBeforeFill = true;
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "utilisateur";
            this.utilisateurBindingSource.DataSource = this.gsbassistanceDataSet;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // utilisateurTableAdapter1
            // 
            this.utilisateurTableAdapter1.ClearBeforeFill = true;
            // 
            // niveauTableAdapter
            // 
            this.niveauTableAdapter.ClearBeforeFill = true;
            // 
            // equipementTableAdapter1
            // 
            this.equipementTableAdapter1.ClearBeforeFill = true;
            // 
            // gsbassistanceDataSet4
            // 
            this.gsbassistanceDataSet4.DataSetName = "gsbassistanceDataSet4";
            this.gsbassistanceDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilisateurincidentBindingSource
            // 
            this.utilisateurincidentBindingSource.DataMember = "utilisateur_incident";
            this.utilisateurincidentBindingSource.DataSource = this.gsbassistanceDataSet4;
            // 
            // utilisateur_incidentTableAdapter
            // 
            this.utilisateur_incidentTableAdapter.ClearBeforeFill = true;
            // 
            // Add_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Add_Ticket";
            this.Text = "Add_Ticket";
            this.Load += new System.EventHandler(this.Add_Ticket_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.niveauBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbassistanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbassistanceDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbassistanceDataSet2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipementBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsbassistanceDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurincidentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Combo_Add_Ticket_Niveau;
        private System.Windows.Forms.ComboBox Combo_Add_Ticket_Equipement;
        private System.Windows.Forms.DateTimePicker Date_Add_Ticket_Time;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox Combo_Add_Ticket_Technicien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Textbox_Add_Ticket_Mess;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Textbox_Add_Ticket_Techcomm;
        private System.Windows.Forms.TextBox Textbox_Add_Ticket_Objet;
        private gsbassistanceDataSet gsbassistanceDataSet;
        private System.Windows.Forms.BindingSource equipementBindingSource;
        private gsbassistanceDataSetTableAdapters.equipementTableAdapter equipementTableAdapter;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private gsbassistanceDataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private gsbassistanceDataSet2 gsbassistanceDataSet2;
        private System.Windows.Forms.BindingSource utilisateurBindingSource1;
        private gsbassistanceDataSet2TableAdapters.utilisateurTableAdapter utilisateurTableAdapter1;
        private System.Windows.Forms.BindingSource niveauBindingSource;
        private gsbassistanceDataSetTableAdapters.niveauTableAdapter niveauTableAdapter;
        private gsbassistanceDataSet3 gsbassistanceDataSet3;
        private System.Windows.Forms.BindingSource equipementBindingSource1;
        private gsbassistanceDataSet3TableAdapters.equipementTableAdapter equipementTableAdapter1;
        private System.Windows.Forms.BindingSource equipementBindingSource2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private gsbassistanceDataSet4 gsbassistanceDataSet4;
        private System.Windows.Forms.BindingSource utilisateurincidentBindingSource;
        private gsbassistanceDataSet4TableAdapters.utilisateur_incidentTableAdapter utilisateur_incidentTableAdapter;
    }
}