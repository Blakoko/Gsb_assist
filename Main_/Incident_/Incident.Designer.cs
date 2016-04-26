namespace GSBASSIST
{
    partial class Incident
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
            this.Groupbox_Ticket = new System.Windows.Forms.GroupBox();
            this.Label_Incident_Niveau = new System.Windows.Forms.Label();
            this.Label_Incident_Statut = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Label_Incident_Ticket = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Groupbox_Equipement = new System.Windows.Forms.GroupBox();
            this.Label_Incident_Utilisateur = new System.Windows.Forms.Label();
            this.Label_Incident_Equipement = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Groupbox_Date = new System.Windows.Forms.GroupBox();
            this.Label_Incident_Now = new System.Windows.Forms.Label();
            this.Label_Incident_Demande = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Groupbox_Technicien = new System.Windows.Forms.GroupBox();
            this.Textbox_Incident_Comm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Groupbox_Objet = new System.Windows.Forms.GroupBox();
            this.Textbox_Incident_Mess = new System.Windows.Forms.TextBox();
            this.Label_Incident_Objet = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Groupbox_Resolution = new System.Windows.Forms.GroupBox();
            this.Textbox_Incident_Solution = new System.Windows.Forms.TextBox();
            this.Label_Incident_Date = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Button_Incident_Prise = new System.Windows.Forms.Button();
            this.Button_Incident_Modif = new System.Windows.Forms.Button();
            this.Button_Incident_Resolution = new System.Windows.Forms.Button();
            this.gsbassistanceDataSet4 = new GSBASSIST.gsbassistanceDataSet4();
            this.incidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidentTableAdapter = new GSBASSIST.gsbassistanceDataSet4TableAdapters.incidentTableAdapter();
            this.Groupbox_Ticket.SuspendLayout();
            this.Groupbox_Equipement.SuspendLayout();
            this.Groupbox_Date.SuspendLayout();
            this.Groupbox_Technicien.SuspendLayout();
            this.Groupbox_Objet.SuspendLayout();
            this.Groupbox_Resolution.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Groupbox_Ticket
            // 
            this.Groupbox_Ticket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Groupbox_Ticket.Controls.Add(this.Label_Incident_Niveau);
            this.Groupbox_Ticket.Controls.Add(this.Label_Incident_Statut);
            this.Groupbox_Ticket.Controls.Add(this.label13);
            this.Groupbox_Ticket.Controls.Add(this.Label_Incident_Ticket);
            this.Groupbox_Ticket.Controls.Add(this.label2);
            this.Groupbox_Ticket.Controls.Add(this.label1);
            this.Groupbox_Ticket.Location = new System.Drawing.Point(12, 106);
            this.Groupbox_Ticket.Name = "Groupbox_Ticket";
            this.Groupbox_Ticket.Size = new System.Drawing.Size(200, 119);
            this.Groupbox_Ticket.TabIndex = 1;
            this.Groupbox_Ticket.TabStop = false;
            this.Groupbox_Ticket.Text = "Ticket";
            // 
            // Label_Incident_Niveau
            // 
            this.Label_Incident_Niveau.AutoSize = true;
            this.Label_Incident_Niveau.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label_Incident_Niveau.Location = new System.Drawing.Point(101, 75);
            this.Label_Incident_Niveau.Name = "Label_Incident_Niveau";
            this.Label_Incident_Niveau.Size = new System.Drawing.Size(27, 13);
            this.Label_Incident_Niveau.TabIndex = 5;
            this.Label_Incident_Niveau.Text = "N/A";
            // 
            // Label_Incident_Statut
            // 
            this.Label_Incident_Statut.AutoSize = true;
            this.Label_Incident_Statut.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label_Incident_Statut.Location = new System.Drawing.Point(101, 53);
            this.Label_Incident_Statut.Name = "Label_Incident_Statut";
            this.Label_Incident_Statut.Size = new System.Drawing.Size(27, 13);
            this.Label_Incident_Statut.TabIndex = 4;
            this.Label_Incident_Statut.Text = "N/A";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "NIVEAU";
            // 
            // Label_Incident_Ticket
            // 
            this.Label_Incident_Ticket.AutoSize = true;
            this.Label_Incident_Ticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Incident_Ticket.ForeColor = System.Drawing.Color.Red;
            this.Label_Incident_Ticket.Location = new System.Drawing.Point(98, 27);
            this.Label_Incident_Ticket.Name = "Label_Incident_Ticket";
            this.Label_Incident_Ticket.Size = new System.Drawing.Size(59, 16);
            this.Label_Incident_Ticket.TabIndex = 2;
            this.Label_Incident_Ticket.Text = "label12";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "STATUT :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N°TICKET :";
            // 
            // Groupbox_Equipement
            // 
            this.Groupbox_Equipement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Groupbox_Equipement.Controls.Add(this.Label_Incident_Utilisateur);
            this.Groupbox_Equipement.Controls.Add(this.Label_Incident_Equipement);
            this.Groupbox_Equipement.Controls.Add(this.label4);
            this.Groupbox_Equipement.Controls.Add(this.label3);
            this.Groupbox_Equipement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Groupbox_Equipement.Location = new System.Drawing.Point(240, 106);
            this.Groupbox_Equipement.Name = "Groupbox_Equipement";
            this.Groupbox_Equipement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Groupbox_Equipement.Size = new System.Drawing.Size(272, 119);
            this.Groupbox_Equipement.TabIndex = 2;
            this.Groupbox_Equipement.TabStop = false;
            this.Groupbox_Equipement.Text = "Equipement";
            // 
            // Label_Incident_Utilisateur
            // 
            this.Label_Incident_Utilisateur.AutoSize = true;
            this.Label_Incident_Utilisateur.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label_Incident_Utilisateur.Location = new System.Drawing.Point(130, 53);
            this.Label_Incident_Utilisateur.Name = "Label_Incident_Utilisateur";
            this.Label_Incident_Utilisateur.Size = new System.Drawing.Size(27, 13);
            this.Label_Incident_Utilisateur.TabIndex = 3;
            this.Label_Incident_Utilisateur.Text = "N/A";
            // 
            // Label_Incident_Equipement
            // 
            this.Label_Incident_Equipement.AutoSize = true;
            this.Label_Incident_Equipement.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label_Incident_Equipement.Location = new System.Drawing.Point(127, 30);
            this.Label_Incident_Equipement.Name = "Label_Incident_Equipement";
            this.Label_Incident_Equipement.Size = new System.Drawing.Size(27, 13);
            this.Label_Incident_Equipement.TabIndex = 2;
            this.Label_Incident_Equipement.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "UTILISATEUR :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "EQUIPEMENT :";
            // 
            // Groupbox_Date
            // 
            this.Groupbox_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Groupbox_Date.Controls.Add(this.Label_Incident_Now);
            this.Groupbox_Date.Controls.Add(this.Label_Incident_Demande);
            this.Groupbox_Date.Controls.Add(this.label6);
            this.Groupbox_Date.Controls.Add(this.label5);
            this.Groupbox_Date.Location = new System.Drawing.Point(538, 106);
            this.Groupbox_Date.Name = "Groupbox_Date";
            this.Groupbox_Date.Size = new System.Drawing.Size(214, 119);
            this.Groupbox_Date.TabIndex = 3;
            this.Groupbox_Date.TabStop = false;
            this.Groupbox_Date.Text = "Date";
            // 
            // Label_Incident_Now
            // 
            this.Label_Incident_Now.AutoSize = true;
            this.Label_Incident_Now.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label_Incident_Now.Location = new System.Drawing.Point(56, 75);
            this.Label_Incident_Now.Name = "Label_Incident_Now";
            this.Label_Incident_Now.Size = new System.Drawing.Size(41, 13);
            this.Label_Incident_Now.TabIndex = 3;
            this.Label_Incident_Now.Text = "label12";
            // 
            // Label_Incident_Demande
            // 
            this.Label_Incident_Demande.AutoSize = true;
            this.Label_Incident_Demande.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label_Incident_Demande.Location = new System.Drawing.Point(86, 30);
            this.Label_Incident_Demande.Name = "Label_Incident_Demande";
            this.Label_Incident_Demande.Size = new System.Drawing.Size(27, 13);
            this.Label_Incident_Demande.TabIndex = 2;
            this.Label_Incident_Demande.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "PRISE EN CHARGE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "DEMANDE :";
            // 
            // Groupbox_Technicien
            // 
            this.Groupbox_Technicien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Groupbox_Technicien.Controls.Add(this.Textbox_Incident_Comm);
            this.Groupbox_Technicien.Controls.Add(this.label7);
            this.Groupbox_Technicien.Location = new System.Drawing.Point(12, 240);
            this.Groupbox_Technicien.Name = "Groupbox_Technicien";
            this.Groupbox_Technicien.Size = new System.Drawing.Size(200, 153);
            this.Groupbox_Technicien.TabIndex = 4;
            this.Groupbox_Technicien.TabStop = false;
            this.Groupbox_Technicien.Text = "Technicien";
            // 
            // Textbox_Incident_Comm
            // 
            this.Textbox_Incident_Comm.CausesValidation = false;
            this.Textbox_Incident_Comm.Location = new System.Drawing.Point(6, 49);
            this.Textbox_Incident_Comm.Multiline = true;
            this.Textbox_Incident_Comm.Name = "Textbox_Incident_Comm";
            this.Textbox_Incident_Comm.ReadOnly = true;
            this.Textbox_Incident_Comm.Size = new System.Drawing.Size(188, 98);
            this.Textbox_Incident_Comm.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "COMMENTAIRE TECH :";
            // 
            // Groupbox_Objet
            // 
            this.Groupbox_Objet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Groupbox_Objet.Controls.Add(this.Textbox_Incident_Mess);
            this.Groupbox_Objet.Controls.Add(this.Label_Incident_Objet);
            this.Groupbox_Objet.Controls.Add(this.label9);
            this.Groupbox_Objet.Controls.Add(this.label8);
            this.Groupbox_Objet.Location = new System.Drawing.Point(240, 240);
            this.Groupbox_Objet.Name = "Groupbox_Objet";
            this.Groupbox_Objet.Size = new System.Drawing.Size(272, 153);
            this.Groupbox_Objet.TabIndex = 5;
            this.Groupbox_Objet.TabStop = false;
            this.Groupbox_Objet.Text = "Objet";
            // 
            // Textbox_Incident_Mess
            // 
            this.Textbox_Incident_Mess.Location = new System.Drawing.Point(6, 49);
            this.Textbox_Incident_Mess.Multiline = true;
            this.Textbox_Incident_Mess.Name = "Textbox_Incident_Mess";
            this.Textbox_Incident_Mess.ReadOnly = true;
            this.Textbox_Incident_Mess.Size = new System.Drawing.Size(260, 98);
            this.Textbox_Incident_Mess.TabIndex = 4;
            // 
            // Label_Incident_Objet
            // 
            this.Label_Incident_Objet.AutoSize = true;
            this.Label_Incident_Objet.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label_Incident_Objet.Location = new System.Drawing.Point(130, 15);
            this.Label_Incident_Objet.Name = "Label_Incident_Objet";
            this.Label_Incident_Objet.Size = new System.Drawing.Size(27, 13);
            this.Label_Incident_Objet.TabIndex = 2;
            this.Label_Incident_Objet.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "MESSAGE :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "OBJET :";
            // 
            // Groupbox_Resolution
            // 
            this.Groupbox_Resolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Groupbox_Resolution.Controls.Add(this.Textbox_Incident_Solution);
            this.Groupbox_Resolution.Controls.Add(this.Label_Incident_Date);
            this.Groupbox_Resolution.Controls.Add(this.label11);
            this.Groupbox_Resolution.Controls.Add(this.label10);
            this.Groupbox_Resolution.Location = new System.Drawing.Point(538, 240);
            this.Groupbox_Resolution.Name = "Groupbox_Resolution";
            this.Groupbox_Resolution.Size = new System.Drawing.Size(214, 153);
            this.Groupbox_Resolution.TabIndex = 6;
            this.Groupbox_Resolution.TabStop = false;
            this.Groupbox_Resolution.Text = "Resolution";
            // 
            // Textbox_Incident_Solution
            // 
            this.Textbox_Incident_Solution.Location = new System.Drawing.Point(6, 49);
            this.Textbox_Incident_Solution.Multiline = true;
            this.Textbox_Incident_Solution.Name = "Textbox_Incident_Solution";
            this.Textbox_Incident_Solution.ReadOnly = true;
            this.Textbox_Incident_Solution.Size = new System.Drawing.Size(202, 98);
            this.Textbox_Incident_Solution.TabIndex = 3;
            this.Textbox_Incident_Solution.Text = "Pas de Solution Pour Le Moment";
            // 
            // Label_Incident_Date
            // 
            this.Label_Incident_Date.AutoSize = true;
            this.Label_Incident_Date.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label_Incident_Date.Location = new System.Drawing.Point(119, 18);
            this.Label_Incident_Date.Name = "Label_Incident_Date";
            this.Label_Incident_Date.Size = new System.Drawing.Size(27, 13);
            this.Label_Incident_Date.TabIndex = 2;
            this.Label_Incident_Date.Text = "N/A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "SOLUTION : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "DATE : ";
            // 
            // Button_Incident_Prise
            // 
            this.Button_Incident_Prise.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button_Incident_Prise.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Button_Incident_Prise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Incident_Prise.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_Incident_Prise.Location = new System.Drawing.Point(12, 410);
            this.Button_Incident_Prise.Name = "Button_Incident_Prise";
            this.Button_Incident_Prise.Size = new System.Drawing.Size(200, 23);
            this.Button_Incident_Prise.TabIndex = 4;
            this.Button_Incident_Prise.Text = "PRISE EN CHARGE DU TICKET";
            this.Button_Incident_Prise.UseVisualStyleBackColor = false;
            this.Button_Incident_Prise.Click += new System.EventHandler(this.Button_Incident_Prise_Click);
            // 
            // Button_Incident_Modif
            // 
            this.Button_Incident_Modif.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button_Incident_Modif.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_Incident_Modif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Incident_Modif.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_Incident_Modif.Location = new System.Drawing.Point(240, 410);
            this.Button_Incident_Modif.Name = "Button_Incident_Modif";
            this.Button_Incident_Modif.Size = new System.Drawing.Size(272, 23);
            this.Button_Incident_Modif.TabIndex = 7;
            this.Button_Incident_Modif.Text = "MODIFIER LE TICKET";
            this.Button_Incident_Modif.UseVisualStyleBackColor = false;
            this.Button_Incident_Modif.Click += new System.EventHandler(this.Button_Incident_Modif_Click);
            // 
            // Button_Incident_Resolution
            // 
            this.Button_Incident_Resolution.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button_Incident_Resolution.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Button_Incident_Resolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Incident_Resolution.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_Incident_Resolution.Location = new System.Drawing.Point(538, 410);
            this.Button_Incident_Resolution.Name = "Button_Incident_Resolution";
            this.Button_Incident_Resolution.Size = new System.Drawing.Size(216, 23);
            this.Button_Incident_Resolution.TabIndex = 8;
            this.Button_Incident_Resolution.Text = "RESOUDRE";
            this.Button_Incident_Resolution.UseVisualStyleBackColor = false;
            this.Button_Incident_Resolution.Click += new System.EventHandler(this.Button_Incident_Resolution_Click);
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
            // Incident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 454);
            this.Controls.Add(this.Button_Incident_Resolution);
            this.Controls.Add(this.Button_Incident_Modif);
            this.Controls.Add(this.Button_Incident_Prise);
            this.Controls.Add(this.Groupbox_Resolution);
            this.Controls.Add(this.Groupbox_Objet);
            this.Controls.Add(this.Groupbox_Technicien);
            this.Controls.Add(this.Groupbox_Date);
            this.Controls.Add(this.Groupbox_Equipement);
            this.Controls.Add(this.Groupbox_Ticket);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Incident";
            this.Text = "Ticket Incident";
            this.Load += new System.EventHandler(this.Incident_Load);
            this.Groupbox_Ticket.ResumeLayout(false);
            this.Groupbox_Ticket.PerformLayout();
            this.Groupbox_Equipement.ResumeLayout(false);
            this.Groupbox_Equipement.PerformLayout();
            this.Groupbox_Date.ResumeLayout(false);
            this.Groupbox_Date.PerformLayout();
            this.Groupbox_Technicien.ResumeLayout(false);
            this.Groupbox_Technicien.PerformLayout();
            this.Groupbox_Objet.ResumeLayout(false);
            this.Groupbox_Objet.PerformLayout();
            this.Groupbox_Resolution.ResumeLayout(false);
            this.Groupbox_Resolution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gsbassistanceDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox Groupbox_Ticket;
        private System.Windows.Forms.GroupBox Groupbox_Equipement;
        private System.Windows.Forms.GroupBox Groupbox_Date;
        private System.Windows.Forms.GroupBox Groupbox_Technicien;
        private System.Windows.Forms.GroupBox Groupbox_Objet;
        private System.Windows.Forms.GroupBox Groupbox_Resolution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Label_Incident_Statut;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label Label_Incident_Ticket;
        private System.Windows.Forms.Label Label_Incident_Niveau;
        private System.Windows.Forms.Label Label_Incident_Utilisateur;
        private System.Windows.Forms.Label Label_Incident_Equipement;
        private System.Windows.Forms.Label Label_Incident_Now;
        private System.Windows.Forms.Label Label_Incident_Demande;
        private System.Windows.Forms.Label Label_Incident_Objet;
        private System.Windows.Forms.Label Label_Incident_Date;
        private System.Windows.Forms.Button Button_Incident_Prise;
        private System.Windows.Forms.Button Button_Incident_Modif;
        private System.Windows.Forms.Button Button_Incident_Resolution;
        private gsbassistanceDataSet4 gsbassistanceDataSet4;
        private System.Windows.Forms.BindingSource incidentBindingSource;
        private gsbassistanceDataSet4TableAdapters.incidentTableAdapter incidentTableAdapter;
        private System.Windows.Forms.TextBox Textbox_Incident_Solution;
        private System.Windows.Forms.TextBox Textbox_Incident_Comm;
        private System.Windows.Forms.TextBox Textbox_Incident_Mess;
    }
}