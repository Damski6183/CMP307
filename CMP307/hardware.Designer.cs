namespace CMP307
{
    partial class hardware
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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warranty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.hardwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sql1802193DataSet = new CMP307.sql1802193DataSet();
            this.hardwareTableAdapter = new CMP307.sql1802193DataSetTableAdapters.hardwareTableAdapter();
            this.hardwareBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.unameN = new System.Windows.Forms.TextBox();
            this.typeN = new System.Windows.Forms.TextBox();
            this.descN = new System.Windows.Forms.TextBox();
            this.modelN = new System.Windows.Forms.TextBox();
            this.manuN = new System.Windows.Forms.TextBox();
            this.macN = new System.Windows.Forms.TextBox();
            this.ipN = new System.Windows.Forms.TextBox();
            this.locN = new System.Windows.Forms.TextBox();
            this.warrantyN = new System.Windows.Forms.TextBox();
            this.notesN = new System.Windows.Forms.TextBox();
            this.idE = new System.Windows.Forms.TextBox();
            this.purchN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.notesE = new System.Windows.Forms.TextBox();
            this.warrantyE = new System.Windows.Forms.TextBox();
            this.purchE = new System.Windows.Forms.TextBox();
            this.locE = new System.Windows.Forms.TextBox();
            this.ipE = new System.Windows.Forms.TextBox();
            this.macE = new System.Windows.Forms.TextBox();
            this.manuE = new System.Windows.Forms.TextBox();
            this.modelE = new System.Windows.Forms.TextBox();
            this.descE = new System.Windows.Forms.TextBox();
            this.typeE = new System.Windows.Forms.TextBox();
            this.nameE = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.idD = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sql1802193DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.hname,
            this.Type,
            this.Description,
            this.Model,
            this.Manufacturer,
            this.MAC,
            this.IP,
            this.Location,
            this.PurchaseDate,
            this.Warranty,
            this.Notes});
            this.dataGridView1.Location = new System.Drawing.Point(41, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1240, 294);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // hname
            // 
            this.hname.HeaderText = "Name";
            this.hname.Name = "hname";
            this.hname.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Manufacturer
            // 
            this.Manufacturer.HeaderText = "Manufacturer";
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            // 
            // MAC
            // 
            this.MAC.HeaderText = "MAC";
            this.MAC.Name = "MAC";
            this.MAC.ReadOnly = true;
            // 
            // IP
            // 
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            this.IP.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.HeaderText = "Purchase Date";
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.ReadOnly = true;
            // 
            // Warranty
            // 
            this.Warranty.HeaderText = "Warranty";
            this.Warranty.Name = "Warranty";
            this.Warranty.ReadOnly = true;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1219, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hardwareBindingSource
            // 
            this.hardwareBindingSource.DataMember = "hardware";
            this.hardwareBindingSource.DataSource = this.sql1802193DataSet;
            // 
            // sql1802193DataSet
            // 
            this.sql1802193DataSet.DataSetName = "sql1802193DataSet";
            this.sql1802193DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hardwareTableAdapter
            // 
            this.hardwareTableAdapter.ClearBeforeFill = true;
            // 
            // hardwareBindingSource1
            // 
            this.hardwareBindingSource1.DataMember = "hardware";
            this.hardwareBindingSource1.DataSource = this.sql1802193DataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(620, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete Entry";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(620, 439);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Edit Entry";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(620, 355);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 32);
            this.button4.TabIndex = 4;
            this.button4.Text = "New Entry";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // unameN
            // 
            this.unameN.Location = new System.Drawing.Point(87, 312);
            this.unameN.Name = "unameN";
            this.unameN.Size = new System.Drawing.Size(100, 20);
            this.unameN.TabIndex = 5;
            // 
            // typeN
            // 
            this.typeN.Location = new System.Drawing.Point(193, 312);
            this.typeN.Name = "typeN";
            this.typeN.Size = new System.Drawing.Size(100, 20);
            this.typeN.TabIndex = 6;
            // 
            // descN
            // 
            this.descN.Location = new System.Drawing.Point(299, 312);
            this.descN.Name = "descN";
            this.descN.Size = new System.Drawing.Size(100, 20);
            this.descN.TabIndex = 7;
            // 
            // modelN
            // 
            this.modelN.Location = new System.Drawing.Point(405, 312);
            this.modelN.Name = "modelN";
            this.modelN.Size = new System.Drawing.Size(100, 20);
            this.modelN.TabIndex = 8;
            // 
            // manuN
            // 
            this.manuN.Location = new System.Drawing.Point(511, 312);
            this.manuN.Name = "manuN";
            this.manuN.Size = new System.Drawing.Size(100, 20);
            this.manuN.TabIndex = 9;
            // 
            // macN
            // 
            this.macN.Location = new System.Drawing.Point(617, 312);
            this.macN.Name = "macN";
            this.macN.Size = new System.Drawing.Size(100, 20);
            this.macN.TabIndex = 10;
            // 
            // ipN
            // 
            this.ipN.Location = new System.Drawing.Point(723, 312);
            this.ipN.Name = "ipN";
            this.ipN.Size = new System.Drawing.Size(100, 20);
            this.ipN.TabIndex = 11;
            // 
            // locN
            // 
            this.locN.Location = new System.Drawing.Point(829, 312);
            this.locN.Name = "locN";
            this.locN.Size = new System.Drawing.Size(100, 20);
            this.locN.TabIndex = 12;
            // 
            // warrantyN
            // 
            this.warrantyN.Location = new System.Drawing.Point(1041, 312);
            this.warrantyN.Name = "warrantyN";
            this.warrantyN.Size = new System.Drawing.Size(100, 20);
            this.warrantyN.TabIndex = 13;
            // 
            // notesN
            // 
            this.notesN.Location = new System.Drawing.Point(1147, 312);
            this.notesN.Name = "notesN";
            this.notesN.Size = new System.Drawing.Size(100, 20);
            this.notesN.TabIndex = 14;
            // 
            // idE
            // 
            this.idE.Location = new System.Drawing.Point(28, 400);
            this.idE.Name = "idE";
            this.idE.Size = new System.Drawing.Size(100, 20);
            this.idE.TabIndex = 15;
            // 
            // purchN
            // 
            this.purchN.Location = new System.Drawing.Point(935, 312);
            this.purchN.Name = "purchN";
            this.purchN.Size = new System.Drawing.Size(100, 20);
            this.purchN.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Manufacturer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(635, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "MAC Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(744, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "IP Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(856, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Location";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(947, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Purchase Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1065, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Warranty";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1179, 339);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Notes";
            // 
            // notesE
            // 
            this.notesE.Location = new System.Drawing.Point(1194, 400);
            this.notesE.Name = "notesE";
            this.notesE.Size = new System.Drawing.Size(100, 20);
            this.notesE.TabIndex = 28;
            // 
            // warrantyE
            // 
            this.warrantyE.Location = new System.Drawing.Point(1088, 400);
            this.warrantyE.Name = "warrantyE";
            this.warrantyE.Size = new System.Drawing.Size(100, 20);
            this.warrantyE.TabIndex = 29;
            // 
            // purchE
            // 
            this.purchE.Location = new System.Drawing.Point(982, 400);
            this.purchE.Name = "purchE";
            this.purchE.Size = new System.Drawing.Size(100, 20);
            this.purchE.TabIndex = 30;
            // 
            // locE
            // 
            this.locE.Location = new System.Drawing.Point(876, 400);
            this.locE.Name = "locE";
            this.locE.Size = new System.Drawing.Size(100, 20);
            this.locE.TabIndex = 31;
            // 
            // ipE
            // 
            this.ipE.Location = new System.Drawing.Point(770, 400);
            this.ipE.Name = "ipE";
            this.ipE.Size = new System.Drawing.Size(100, 20);
            this.ipE.TabIndex = 32;
            // 
            // macE
            // 
            this.macE.Location = new System.Drawing.Point(664, 400);
            this.macE.Name = "macE";
            this.macE.Size = new System.Drawing.Size(100, 20);
            this.macE.TabIndex = 33;
            // 
            // manuE
            // 
            this.manuE.Location = new System.Drawing.Point(558, 400);
            this.manuE.Name = "manuE";
            this.manuE.Size = new System.Drawing.Size(100, 20);
            this.manuE.TabIndex = 34;
            // 
            // modelE
            // 
            this.modelE.Location = new System.Drawing.Point(452, 400);
            this.modelE.Name = "modelE";
            this.modelE.Size = new System.Drawing.Size(100, 20);
            this.modelE.TabIndex = 35;
            // 
            // descE
            // 
            this.descE.Location = new System.Drawing.Point(346, 400);
            this.descE.Name = "descE";
            this.descE.Size = new System.Drawing.Size(100, 20);
            this.descE.TabIndex = 36;
            // 
            // typeE
            // 
            this.typeE.Location = new System.Drawing.Point(240, 400);
            this.typeE.Name = "typeE";
            this.typeE.Size = new System.Drawing.Size(100, 20);
            this.typeE.TabIndex = 37;
            // 
            // nameE
            // 
            this.nameE.Location = new System.Drawing.Point(134, 400);
            this.nameE.Name = "nameE";
            this.nameE.Size = new System.Drawing.Size(100, 20);
            this.nameE.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(165, 423);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(273, 423);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Type";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(360, 423);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Description";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(479, 423);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "Model";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(572, 423);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Manufacturer";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(679, 423);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "MAC Address";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(789, 423);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "IP Address";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(897, 423);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 46;
            this.label19.Text = "Location";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(994, 423);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "Purchase Date";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1112, 423);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 13);
            this.label21.TabIndex = 48;
            this.label21.Text = "Warranty";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1224, 423);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 49;
            this.label22.Text = "Notes";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(60, 423);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(18, 13);
            this.label23.TabIndex = 50;
            this.label23.Text = "ID";
            // 
            // idD
            // 
            this.idD.Location = new System.Drawing.Point(617, 484);
            this.idD.Name = "idD";
            this.idD.Size = new System.Drawing.Size(100, 20);
            this.idD.TabIndex = 51;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(652, 507);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(18, 13);
            this.label24.TabIndex = 52;
            this.label24.Text = "ID";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1115, 548);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 53;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // hardware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 579);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.idD);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nameE);
            this.Controls.Add(this.typeE);
            this.Controls.Add(this.descE);
            this.Controls.Add(this.modelE);
            this.Controls.Add(this.manuE);
            this.Controls.Add(this.macE);
            this.Controls.Add(this.ipE);
            this.Controls.Add(this.locE);
            this.Controls.Add(this.purchE);
            this.Controls.Add(this.warrantyE);
            this.Controls.Add(this.notesE);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.purchN);
            this.Controls.Add(this.idE);
            this.Controls.Add(this.notesN);
            this.Controls.Add(this.warrantyN);
            this.Controls.Add(this.locN);
            this.Controls.Add(this.ipN);
            this.Controls.Add(this.macN);
            this.Controls.Add(this.manuN);
            this.Controls.Add(this.modelN);
            this.Controls.Add(this.descN);
            this.Controls.Add(this.typeN);
            this.Controls.Add(this.unameN);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "hardware";
            this.Text = "hardware";
            this.Load += new System.EventHandler(this.hardware_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sql1802193DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource hardwareBindingSource;
        private sql1802193DataSetTableAdapters.hardwareTableAdapter hardwareTableAdapter;
        public sql1802193DataSet sql1802193DataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hardwareBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn hname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warranty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox unameN;
        private System.Windows.Forms.TextBox typeN;
        private System.Windows.Forms.TextBox descN;
        private System.Windows.Forms.TextBox modelN;
        private System.Windows.Forms.TextBox manuN;
        private System.Windows.Forms.TextBox macN;
        private System.Windows.Forms.TextBox ipN;
        private System.Windows.Forms.TextBox locN;
        private System.Windows.Forms.TextBox warrantyN;
        private System.Windows.Forms.TextBox notesN;
        private System.Windows.Forms.TextBox idE;
        private System.Windows.Forms.TextBox purchN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox notesE;
        private System.Windows.Forms.TextBox warrantyE;
        private System.Windows.Forms.TextBox purchE;
        private System.Windows.Forms.TextBox locE;
        private System.Windows.Forms.TextBox ipE;
        private System.Windows.Forms.TextBox macE;
        private System.Windows.Forms.TextBox manuE;
        private System.Windows.Forms.TextBox modelE;
        private System.Windows.Forms.TextBox descE;
        private System.Windows.Forms.TextBox typeE;
        private System.Windows.Forms.TextBox nameE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox idD;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button5;
    }
}