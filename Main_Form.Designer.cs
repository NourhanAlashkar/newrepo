using System;

namespace Remote_SDS_Control_V1_0
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.MAP_Split_Container = new C1.Win.C1SplitContainer.C1SplitContainer();
            this.Details_Panel = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.grp_Site_Status = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grp_Site_Error_Message = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TETRA_Sites = new System.Windows.Forms.TextBox();
            this.grp_Site_Info = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_lon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_lat = new System.Windows.Forms.TextBox();
            this.lbl_Site_Name = new System.Windows.Forms.Label();
            this.lbl_Site_City = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.lbl_Site_Carriers = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Google_Earth_Panel = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.pnl_Map = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ribbonLabel1 = new C1.Win.C1Ribbon.RibbonLabel();
            this.c1StatusBar1 = new C1.Win.C1Ribbon.C1StatusBar();
            this.SP = new System.IO.Ports.SerialPort(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MAP_Split_Container)).BeginInit();
            this.MAP_Split_Container.SuspendLayout();
            this.Details_Panel.SuspendLayout();
            this.grp_Site_Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.grp_Site_Error_Message.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.grp_Site_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Google_Earth_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // MAP_Split_Container
            // 
            this.MAP_Split_Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.MAP_Split_Container.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.MAP_Split_Container.CollapsingAreaColor = System.Drawing.Color.LightCyan;
            this.MAP_Split_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MAP_Split_Container.EnlargeCollapsingHandle = true;
            this.MAP_Split_Container.FixedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(166)))), ((int)(((byte)(194)))));
            this.MAP_Split_Container.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.MAP_Split_Container.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.MAP_Split_Container.Location = new System.Drawing.Point(0, 0);
            this.MAP_Split_Container.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MAP_Split_Container.Name = "MAP_Split_Container";
            this.MAP_Split_Container.Panels.Add(this.Details_Panel);
            this.MAP_Split_Container.Panels.Add(this.Google_Earth_Panel);
            this.MAP_Split_Container.Size = new System.Drawing.Size(1344, 707);
            this.MAP_Split_Container.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(166)))), ((int)(((byte)(194)))));
            this.MAP_Split_Container.SplitterWidth = 7;
            this.MAP_Split_Container.TabIndex = 0;
            this.MAP_Split_Container.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue;
            this.MAP_Split_Container.UseParentVisualStyle = false;
            // 
            // Details_Panel
            // 
            this.Details_Panel.Collapsible = true;
            this.Details_Panel.Controls.Add(this.grp_Site_Status);
            this.Details_Panel.Controls.Add(this.grp_Site_Error_Message);
            this.Details_Panel.Controls.Add(this.grp_Site_Info);
            this.Details_Panel.Controls.Add(this.groupBox1);
            this.Details_Panel.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Left;
            this.Details_Panel.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.Details_Panel.Height = 168;
            this.Details_Panel.Location = new System.Drawing.Point(0, 21);
            this.Details_Panel.Name = "Details_Panel";
            this.Details_Panel.Resizable = false;
            this.Details_Panel.Size = new System.Drawing.Size(468, 686);
            this.Details_Panel.SizeRatio = 35.677D;
            this.Details_Panel.TabIndex = 0;
            this.Details_Panel.Text = "Details";
            this.Details_Panel.Width = 479;
            // 
            // grp_Site_Status
            // 
            this.grp_Site_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.grp_Site_Status.Controls.Add(this.pictureBox4);
            this.grp_Site_Status.Controls.Add(this.button5);
            this.grp_Site_Status.Controls.Add(this.button3);
            this.grp_Site_Status.Controls.Add(this.comboBox1);
            this.grp_Site_Status.Controls.Add(this.button2);
            this.grp_Site_Status.Controls.Add(this.label4);
            this.grp_Site_Status.Controls.Add(this.label2);
            this.grp_Site_Status.Controls.Add(this.textBox4);
            this.grp_Site_Status.Controls.Add(this.textBox5);
            this.grp_Site_Status.Controls.Add(this.label3);
            this.grp_Site_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_Site_Status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grp_Site_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.grp_Site_Status.Location = new System.Drawing.Point(0, 528);
            this.grp_Site_Status.Name = "grp_Site_Status";
            this.grp_Site_Status.Size = new System.Drawing.Size(468, 158);
            this.grp_Site_Status.TabIndex = 11;
            this.grp_Site_Status.TabStop = false;
            this.grp_Site_Status.Text = "Read and Set Radio TGs";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Remote_SDS_Control_V1_0.Properties.Resources.Offline;
            this.pictureBox4.Location = new System.Drawing.Point(440, 118);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.button5.Location = new System.Drawing.Point(162, 116);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "Read Current TG";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.button3.Location = new System.Drawing.Point(307, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Change TG";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(170, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.button2.Location = new System.Drawing.Point(17, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Read All TGs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "TGs :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Radio Pass. :";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.textBox4.Location = new System.Drawing.Point(170, 55);
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '*';
            this.textBox4.Size = new System.Drawing.Size(183, 16);
            this.textBox4.TabIndex = 16;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.textBox5.Location = new System.Drawing.Point(170, 33);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(183, 16);
            this.textBox5.TabIndex = 14;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Radio ISSI :";
            // 
            // grp_Site_Error_Message
            // 
            this.grp_Site_Error_Message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.grp_Site_Error_Message.Controls.Add(this.pictureBox3);
            this.grp_Site_Error_Message.Controls.Add(this.button4);
            this.grp_Site_Error_Message.Controls.Add(this.label9);
            this.grp_Site_Error_Message.Controls.Add(this.label7);
            this.grp_Site_Error_Message.Controls.Add(this.textBox7);
            this.grp_Site_Error_Message.Controls.Add(this.textBox8);
            this.grp_Site_Error_Message.Controls.Add(this.label8);
            this.grp_Site_Error_Message.Controls.Add(this.txt_TETRA_Sites);
            this.grp_Site_Error_Message.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_Site_Error_Message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.grp_Site_Error_Message.Location = new System.Drawing.Point(0, 306);
            this.grp_Site_Error_Message.Name = "grp_Site_Error_Message";
            this.grp_Site_Error_Message.Size = new System.Drawing.Size(468, 222);
            this.grp_Site_Error_Message.TabIndex = 10;
            this.grp_Site_Error_Message.TabStop = false;
            this.grp_Site_Error_Message.Text = "Radio TETRA Sites";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Remote_SDS_Control_V1_0.Properties.Resources.Offline;
            this.pictureBox3.Location = new System.Drawing.Point(264, 187);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.button4.Location = new System.Drawing.Point(128, 185);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Read Radio\'s Sites";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Sites :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Radio Pass. :";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.textBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.textBox7.Location = new System.Drawing.Point(128, 55);
            this.textBox7.Name = "textBox7";
            this.textBox7.PasswordChar = '*';
            this.textBox7.Size = new System.Drawing.Size(183, 16);
            this.textBox7.TabIndex = 27;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.textBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.textBox8.Location = new System.Drawing.Point(128, 33);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(183, 16);
            this.textBox8.TabIndex = 25;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Radio ISSI :";
            // 
            // txt_TETRA_Sites
            // 
            this.txt_TETRA_Sites.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_TETRA_Sites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TETRA_Sites.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.txt_TETRA_Sites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.txt_TETRA_Sites.Location = new System.Drawing.Point(128, 77);
            this.txt_TETRA_Sites.Multiline = true;
            this.txt_TETRA_Sites.Name = "txt_TETRA_Sites";
            this.txt_TETRA_Sites.ReadOnly = true;
            this.txt_TETRA_Sites.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_TETRA_Sites.Size = new System.Drawing.Size(303, 102);
            this.txt_TETRA_Sites.TabIndex = 12;
            // 
            // grp_Site_Info
            // 
            this.grp_Site_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.grp_Site_Info.Controls.Add(this.pictureBox2);
            this.grp_Site_Info.Controls.Add(this.button1);
            this.grp_Site_Info.Controls.Add(this.txt_lon);
            this.grp_Site_Info.Controls.Add(this.label1);
            this.grp_Site_Info.Controls.Add(this.textBox1);
            this.grp_Site_Info.Controls.Add(this.txt_lat);
            this.grp_Site_Info.Controls.Add(this.lbl_Site_Name);
            this.grp_Site_Info.Controls.Add(this.lbl_Site_City);
            this.grp_Site_Info.Controls.Add(this.textBox9);
            this.grp_Site_Info.Controls.Add(this.lbl_Site_Carriers);
            this.grp_Site_Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_Site_Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.grp_Site_Info.Location = new System.Drawing.Point(0, 162);
            this.grp_Site_Info.Name = "grp_Site_Info";
            this.grp_Site_Info.Size = new System.Drawing.Size(468, 144);
            this.grp_Site_Info.TabIndex = 11;
            this.grp_Site_Info.TabStop = false;
            this.grp_Site_Info.Text = "Get Radio GPS Location";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Remote_SDS_Control_V1_0.Properties.Resources.Offline;
            this.pictureBox2.Location = new System.Drawing.Point(306, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.button1.Location = new System.Drawing.Point(170, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Get GPS Location";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_lon
            // 
            this.txt_lon.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_lon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_lon.Enabled = false;
            this.txt_lon.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.txt_lon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.txt_lon.Location = new System.Drawing.Point(170, 92);
            this.txt_lon.Name = "txt_lon";
            this.txt_lon.ReadOnly = true;
            this.txt_lon.Size = new System.Drawing.Size(183, 16);
            this.txt_lon.TabIndex = 12;
            this.txt_lon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Radio Pass. :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.textBox1.Location = new System.Drawing.Point(170, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(183, 16);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_lat
            // 
            this.txt_lat.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_lat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_lat.Enabled = false;
            this.txt_lat.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.txt_lat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.txt_lat.Location = new System.Drawing.Point(170, 70);
            this.txt_lat.Name = "txt_lat";
            this.txt_lat.ReadOnly = true;
            this.txt_lat.Size = new System.Drawing.Size(183, 16);
            this.txt_lat.TabIndex = 8;
            this.txt_lat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Site_Name
            // 
            this.lbl_Site_Name.AutoSize = true;
            this.lbl_Site_Name.Location = new System.Drawing.Point(95, 25);
            this.lbl_Site_Name.Name = "lbl_Site_Name";
            this.lbl_Site_Name.Size = new System.Drawing.Size(71, 17);
            this.lbl_Site_Name.TabIndex = 0;
            this.lbl_Site_Name.Text = "Radio ISSI :";
            // 
            // lbl_Site_City
            // 
            this.lbl_Site_City.AutoSize = true;
            this.lbl_Site_City.Location = new System.Drawing.Point(122, 70);
            this.lbl_Site_City.Name = "lbl_Site_City";
            this.lbl_Site_City.Size = new System.Drawing.Size(35, 17);
            this.lbl_Site_City.TabIndex = 3;
            this.lbl_Site_City.Text = "Lat. :";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.textBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.textBox9.Location = new System.Drawing.Point(170, 26);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(183, 16);
            this.textBox9.TabIndex = 6;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Site_Carriers
            // 
            this.lbl_Site_Carriers.AutoSize = true;
            this.lbl_Site_Carriers.Location = new System.Drawing.Point(117, 91);
            this.lbl_Site_Carriers.Name = "lbl_Site_Carriers";
            this.lbl_Site_Carriers.Size = new System.Drawing.Size(42, 17);
            this.lbl_Site_Carriers.TabIndex = 4;
            this.lbl_Site_Carriers.Text = "Lon. : ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 162);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Settings";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Remote_SDS_Control_V1_0.Properties.Resources.Offline;
            this.pictureBox1.Location = new System.Drawing.Point(306, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "2400",
            "9600",
            "115200"});
            this.comboBox3.Location = new System.Drawing.Point(83, 79);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(107, 23);
            this.comboBox3.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "BaudRate:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(83, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(107, 23);
            this.comboBox2.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "COM Port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Esri Map";
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.button6.Location = new System.Drawing.Point(170, 133);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 23);
            this.button6.TabIndex = 24;
            this.button6.Text = "Connect";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.textBox2.Location = new System.Drawing.Point(85, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(370, 16);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Google_Earth_Panel
            // 
            this.Google_Earth_Panel.Collapsible = true;
            this.Google_Earth_Panel.Controls.Add(this.pnl_Map);
            this.Google_Earth_Panel.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Bottom;
            this.Google_Earth_Panel.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.Google_Earth_Panel.Height = 100;
            this.Google_Earth_Panel.Location = new System.Drawing.Point(480, 21);
            this.Google_Earth_Panel.Name = "Google_Earth_Panel";
            this.Google_Earth_Panel.Resizable = false;
            this.Google_Earth_Panel.Size = new System.Drawing.Size(864, 686);
            this.Google_Earth_Panel.TabIndex = 2;
            this.Google_Earth_Panel.Text = "GIS MAP";
            // 
            // pnl_Map
            // 
            this.pnl_Map.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Map.Location = new System.Drawing.Point(0, 0);
            this.pnl_Map.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Map.Name = "pnl_Map";
            this.pnl_Map.Size = new System.Drawing.Size(864, 686);
            this.pnl_Map.TabIndex = 6;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ribbonLabel1
            // 
            this.ribbonLabel1.Name = "ribbonLabel1";
            this.ribbonLabel1.Text = "© 2020 Systel Telecom, Inc. All rights reserved.";
            // 
            // c1StatusBar1
            // 
            this.c1StatusBar1.LeftPaneItems.Add(this.ribbonLabel1);
            this.c1StatusBar1.Location = new System.Drawing.Point(0, 707);
            this.c1StatusBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c1StatusBar1.Name = "c1StatusBar1";
            this.c1StatusBar1.Size = new System.Drawing.Size(1344, 22);
            this.c1StatusBar1.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2010Blue;
            // 
            // SP
            // 
            this.SP.DiscardNull = true;
            this.SP.Handshake = System.IO.Ports.Handshake.RequestToSend;
            this.SP.PortName = "COM2";
            this.SP.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SP_DataReceived);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "Password :";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.textBox3.Location = new System.Drawing.Point(83, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(107, 16);
            this.textBox3.TabIndex = 32;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 729);
            this.Controls.Add(this.MAP_Split_Container);
            this.Controls.Add(this.c1StatusBar1);
            this.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1360, 768);
            this.MinimumSize = new System.Drawing.Size(1358, 726);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Control TETRA Radios V1.0";
            ((System.ComponentModel.ISupportInitialize)(this.MAP_Split_Container)).EndInit();
            this.MAP_Split_Container.ResumeLayout(false);
            this.Details_Panel.ResumeLayout(false);
            this.grp_Site_Status.ResumeLayout(false);
            this.grp_Site_Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.grp_Site_Error_Message.ResumeLayout(false);
            this.grp_Site_Error_Message.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.grp_Site_Info.ResumeLayout(false);
            this.grp_Site_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Google_Earth_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1StatusBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void but_Show_Warning_Sites_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private C1.Win.C1SplitContainer.C1SplitContainer MAP_Split_Container;
        private C1.Win.C1SplitContainer.C1SplitterPanel Details_Panel;
        private C1.Win.C1SplitContainer.C1SplitterPanel Google_Earth_Panel;
        private System.Windows.Forms.Panel pnl_Map;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbl_Site_City;
        private System.Windows.Forms.GroupBox grp_Site_Error_Message;
        private System.Windows.Forms.GroupBox grp_Site_Info;
        private System.Windows.Forms.GroupBox grp_Site_Status;
        private C1.Win.C1Ribbon.RibbonLabel ribbonLabel1;
        private C1.Win.C1Ribbon.C1StatusBar c1StatusBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TETRA_Sites;
        private System.Windows.Forms.TextBox txt_lon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_lat;
        private System.Windows.Forms.Label lbl_Site_Name;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label lbl_Site_Carriers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.IO.Ports.SerialPort SP;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
    }
}

