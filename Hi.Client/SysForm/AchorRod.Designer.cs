namespace Hi.Client
{
    partial class FrmTrail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 3.5D);
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tb_SysInfo = new System.Windows.Forms.TextBox();
            this.tb_RealTime = new System.Windows.Forms.TextBox();
            this.bt_ClearInfo = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.bt_ConnectDevice = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_CheckAutoWave = new System.Windows.Forms.Button();
            this.bt_DeleteCheckedAutoData = new System.Windows.Forms.Button();
            this.bt_ClearAutoData = new System.Windows.Forms.Button();
            this.bt_Check = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bt_ClearHandData = new System.Windows.Forms.Button();
            this.bt_DeleteCheckedHandData = new System.Windows.Forms.Button();
            this.bt_CheckHandWave = new System.Windows.Forms.Button();
            this.dg_AutoData = new System.Windows.Forms.DataGridView();
            this.dg_HandData = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_ReadAutoData = new System.Windows.Forms.Button();
            this.bt_ReadHandData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_MaxDistance = new System.Windows.Forms.ComboBox();
            this.cb_MaxPower = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart_HandAutoData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HandData_StoreTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HandData_StoreDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HandData_StorePower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HandData_StoreType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoData_StoreTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoData_DataNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoData_StoreType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_AutoData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_HandData)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_HandAutoData)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_SysInfo
            // 
            this.tb_SysInfo.Location = new System.Drawing.Point(12, 423);
            this.tb_SysInfo.Multiline = true;
            this.tb_SysInfo.Name = "tb_SysInfo";
            this.tb_SysInfo.Size = new System.Drawing.Size(761, 115);
            this.tb_SysInfo.TabIndex = 13;
            // 
            // tb_RealTime
            // 
            this.tb_RealTime.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_RealTime.Location = new System.Drawing.Point(779, 423);
            this.tb_RealTime.Name = "tb_RealTime";
            this.tb_RealTime.ReadOnly = true;
            this.tb_RealTime.Size = new System.Drawing.Size(166, 26);
            this.tb_RealTime.TabIndex = 14;
            this.tb_RealTime.Text = "20130518 20:36:10";
            // 
            // bt_ClearInfo
            // 
            this.bt_ClearInfo.Location = new System.Drawing.Point(779, 460);
            this.bt_ClearInfo.Name = "bt_ClearInfo";
            this.bt_ClearInfo.Size = new System.Drawing.Size(84, 33);
            this.bt_ClearInfo.TabIndex = 15;
            this.bt_ClearInfo.Text = "清空信息";
            this.bt_ClearInfo.UseVisualStyleBackColor = false;
            this.bt_ClearInfo.Click += new System.EventHandler(this.bt_ClearInfo_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Location = new System.Drawing.Point(779, 505);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(84, 33);
            this.bt_Exit.TabIndex = 16;
            this.bt_Exit.Text = "退出系统";
            this.bt_Exit.UseVisualStyleBackColor = false;
            // 
            // bt_ConnectDevice
            // 
            this.bt_ConnectDevice.Location = new System.Drawing.Point(877, 460);
            this.bt_ConnectDevice.Name = "bt_ConnectDevice";
            this.bt_ConnectDevice.Size = new System.Drawing.Size(68, 78);
            this.bt_ConnectDevice.TabIndex = 17;
            this.bt_ConnectDevice.Text = "连接设备";
            this.bt_ConnectDevice.UseVisualStyleBackColor = false;
            this.bt_ConnectDevice.Click += new System.EventHandler(this.bt_ConnectDevice_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(950, 386);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "关于";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(950, 386);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.dg_AutoData);
            this.tabPage2.Controls.Add(this.dg_HandData);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(950, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "数据操作";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.bt_CheckAutoWave);
            this.groupBox3.Controls.Add(this.bt_DeleteCheckedAutoData);
            this.groupBox3.Controls.Add(this.bt_ClearAutoData);
            this.groupBox3.Controls.Add(this.bt_Check);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.comboBox4);
            this.groupBox3.Location = new System.Drawing.Point(508, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 105);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "自动数据操作";
            // 
            // bt_CheckAutoWave
            // 
            this.bt_CheckAutoWave.Location = new System.Drawing.Point(290, 73);
            this.bt_CheckAutoWave.Name = "bt_CheckAutoWave";
            this.bt_CheckAutoWave.Size = new System.Drawing.Size(96, 23);
            this.bt_CheckAutoWave.TabIndex = 22;
            this.bt_CheckAutoWave.Text = "查看波形";
            this.bt_CheckAutoWave.UseVisualStyleBackColor = true;
            // 
            // bt_DeleteCheckedAutoData
            // 
            this.bt_DeleteCheckedAutoData.Location = new System.Drawing.Point(168, 73);
            this.bt_DeleteCheckedAutoData.Name = "bt_DeleteCheckedAutoData";
            this.bt_DeleteCheckedAutoData.Size = new System.Drawing.Size(96, 23);
            this.bt_DeleteCheckedAutoData.TabIndex = 21;
            this.bt_DeleteCheckedAutoData.Text = "删除数据";
            this.bt_DeleteCheckedAutoData.UseVisualStyleBackColor = true;
            // 
            // bt_ClearAutoData
            // 
            this.bt_ClearAutoData.Location = new System.Drawing.Point(32, 73);
            this.bt_ClearAutoData.Name = "bt_ClearAutoData";
            this.bt_ClearAutoData.Size = new System.Drawing.Size(96, 23);
            this.bt_ClearAutoData.TabIndex = 20;
            this.bt_ClearAutoData.Text = "清空数据";
            this.bt_ClearAutoData.UseVisualStyleBackColor = true;
            // 
            // bt_Check
            // 
            this.bt_Check.Location = new System.Drawing.Point(311, 18);
            this.bt_Check.Name = "bt_Check";
            this.bt_Check.Size = new System.Drawing.Size(75, 23);
            this.bt_Check.TabIndex = 19;
            this.bt_Check.Text = "确定选择";
            this.bt_Check.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "选择日期：";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(101, 20);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(204, 20);
            this.comboBox4.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.bt_ClearHandData);
            this.groupBox4.Controls.Add(this.bt_DeleteCheckedHandData);
            this.groupBox4.Controls.Add(this.bt_CheckHandWave);
            this.groupBox4.Location = new System.Drawing.Point(27, 275);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(422, 105);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "手动数据操作";
            // 
            // bt_ClearHandData
            // 
            this.bt_ClearHandData.Location = new System.Drawing.Point(224, 70);
            this.bt_ClearHandData.Name = "bt_ClearHandData";
            this.bt_ClearHandData.Size = new System.Drawing.Size(143, 28);
            this.bt_ClearHandData.TabIndex = 22;
            this.bt_ClearHandData.Text = "清空所有数据";
            this.bt_ClearHandData.UseVisualStyleBackColor = true;
            // 
            // bt_DeleteCheckedHandData
            // 
            this.bt_DeleteCheckedHandData.Location = new System.Drawing.Point(29, 70);
            this.bt_DeleteCheckedHandData.Name = "bt_DeleteCheckedHandData";
            this.bt_DeleteCheckedHandData.Size = new System.Drawing.Size(143, 28);
            this.bt_DeleteCheckedHandData.TabIndex = 21;
            this.bt_DeleteCheckedHandData.Text = "删除选中数据";
            this.bt_DeleteCheckedHandData.UseVisualStyleBackColor = true;
            // 
            // bt_CheckHandWave
            // 
            this.bt_CheckHandWave.Location = new System.Drawing.Point(29, 25);
            this.bt_CheckHandWave.Name = "bt_CheckHandWave";
            this.bt_CheckHandWave.Size = new System.Drawing.Size(143, 28);
            this.bt_CheckHandWave.TabIndex = 20;
            this.bt_CheckHandWave.Text = "查看手动波形";
            this.bt_CheckHandWave.UseVisualStyleBackColor = true;
            // 
            // dg_AutoData
            // 
            this.dg_AutoData.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dg_AutoData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_AutoData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_AutoData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dg_AutoData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_AutoData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StoreIndex,
            this.AutoData_StoreTime,
            this.AutoData_DataNumber,
            this.AutoData_StoreType});
            this.dg_AutoData.Location = new System.Drawing.Point(478, 0);
            this.dg_AutoData.Name = "dg_AutoData";
            this.dg_AutoData.RowHeadersVisible = false;
            this.dg_AutoData.RowHeadersWidth = 40;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dg_AutoData.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dg_AutoData.RowTemplate.Height = 23;
            this.dg_AutoData.Size = new System.Drawing.Size(472, 269);
            this.dg_AutoData.TabIndex = 1;
            // 
            // dg_HandData
            // 
            this.dg_HandData.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dg_HandData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_HandData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_HandData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dg_HandData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_HandData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HandData_StoreTime,
            this.HandData_StoreDistance,
            this.HandData_StorePower,
            this.HandData_StoreType});
            this.dg_HandData.Location = new System.Drawing.Point(0, 0);
            this.dg_HandData.Name = "dg_HandData";
            this.dg_HandData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dg_HandData.RowHeadersVisible = false;
            this.dg_HandData.RowHeadersWidth = 40;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dg_HandData.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dg_HandData.RowTemplate.Height = 23;
            this.dg_HandData.Size = new System.Drawing.Size(472, 269);
            this.dg_HandData.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(958, 412);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.chart_HandAutoData);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(950, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "波形操作";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.bt_ReadAutoData);
            this.groupBox2.Controls.Add(this.bt_ReadHandData);
            this.groupBox2.Location = new System.Drawing.Point(742, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 96);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据读取";
            // 
            // bt_ReadAutoData
            // 
            this.bt_ReadAutoData.Location = new System.Drawing.Point(32, 59);
            this.bt_ReadAutoData.Name = "bt_ReadAutoData";
            this.bt_ReadAutoData.Size = new System.Drawing.Size(136, 33);
            this.bt_ReadAutoData.TabIndex = 18;
            this.bt_ReadAutoData.Text = "读取自动存储数据";
            this.bt_ReadAutoData.UseVisualStyleBackColor = false;
            // 
            // bt_ReadHandData
            // 
            this.bt_ReadHandData.Location = new System.Drawing.Point(32, 20);
            this.bt_ReadHandData.Name = "bt_ReadHandData";
            this.bt_ReadHandData.Size = new System.Drawing.Size(136, 33);
            this.bt_ReadHandData.TabIndex = 17;
            this.bt_ReadHandData.Text = "读取手动存储数据";
            this.bt_ReadHandData.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_MaxDistance);
            this.groupBox1.Controls.Add(this.cb_MaxPower);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(742, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "量程选择";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "MM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "KN";
            // 
            // cb_MaxDistance
            // 
            this.cb_MaxDistance.FormattingEnabled = true;
            this.cb_MaxDistance.Location = new System.Drawing.Point(64, 58);
            this.cb_MaxDistance.Name = "cb_MaxDistance";
            this.cb_MaxDistance.Size = new System.Drawing.Size(94, 20);
            this.cb_MaxDistance.TabIndex = 3;
            // 
            // cb_MaxPower
            // 
            this.cb_MaxPower.FormattingEnabled = true;
            this.cb_MaxPower.Location = new System.Drawing.Point(63, 27);
            this.cb_MaxPower.Name = "cb_MaxPower";
            this.cb_MaxPower.Size = new System.Drawing.Size(95, 20);
            this.cb_MaxPower.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "位移：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "拉力：";
            // 
            // chart_HandAutoData
            // 
            this.chart_HandAutoData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.chart_HandAutoData.BackColor = System.Drawing.Color.LightSteelBlue;
            chartArea3.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea3.Name = "ChartArea1";
            this.chart_HandAutoData.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_HandAutoData.Legends.Add(legend3);
            this.chart_HandAutoData.Location = new System.Drawing.Point(0, 6);
            this.chart_HandAutoData.Name = "chart_HandAutoData";
            series5.BorderColor = System.Drawing.Color.Lime;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Blue;
            series5.Legend = "Legend1";
            series5.Name = "自动数据";
            series5.Points.Add(dataPoint3);
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.Red;
            series6.Legend = "Legend1";
            series6.Name = "手动数据";
            this.chart_HandAutoData.Series.Add(series5);
            this.chart_HandAutoData.Series.Add(series6);
            this.chart_HandAutoData.Size = new System.Drawing.Size(715, 373);
            this.chart_HandAutoData.TabIndex = 0;
            this.chart_HandAutoData.Text = "chart1";
            // 
            // HandData_StoreTime
            // 
            this.HandData_StoreTime.HeaderText = "存储时间";
            this.HandData_StoreTime.Name = "HandData_StoreTime";
            this.HandData_StoreTime.Width = 110;
            // 
            // HandData_StoreDistance
            // 
            this.HandData_StoreDistance.HeaderText = "位移值(MM)";
            this.HandData_StoreDistance.Name = "HandData_StoreDistance";
            this.HandData_StoreDistance.Width = 120;
            // 
            // HandData_StorePower
            // 
            this.HandData_StorePower.HeaderText = "力值(KN)";
            this.HandData_StorePower.Name = "HandData_StorePower";
            this.HandData_StorePower.Width = 120;
            // 
            // HandData_StoreType
            // 
            this.HandData_StoreType.HeaderText = "存储方式";
            this.HandData_StoreType.Name = "HandData_StoreType";
            this.HandData_StoreType.Width = 120;
            // 
            // StoreIndex
            // 
            this.StoreIndex.HeaderText = "序号";
            this.StoreIndex.Name = "StoreIndex";
            this.StoreIndex.Width = 110;
            // 
            // AutoData_StoreTime
            // 
            this.AutoData_StoreTime.HeaderText = "存储时间";
            this.AutoData_StoreTime.Name = "AutoData_StoreTime";
            this.AutoData_StoreTime.Width = 120;
            // 
            // AutoData_DataNumber
            // 
            this.AutoData_DataNumber.HeaderText = "数据量";
            this.AutoData_DataNumber.Name = "AutoData_DataNumber";
            this.AutoData_DataNumber.Width = 120;
            // 
            // AutoData_StoreType
            // 
            this.AutoData_StoreType.HeaderText = "存储方式";
            this.AutoData_StoreType.Name = "AutoData_StoreType";
            this.AutoData_StoreType.Width = 120;
            // 
            // FrmTrail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(960, 541);
            this.Controls.Add(this.bt_ConnectDevice);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_ClearInfo);
            this.Controls.Add(this.tb_RealTime);
            this.Controls.Add(this.tb_SysInfo);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "FrmTrail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "锚杆拉力测试系统";
            this.Load += new System.EventHandler(this.FrmTrail_Load);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_AutoData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_HandData)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_HandAutoData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_SysInfo;
        private System.Windows.Forms.TextBox tb_RealTime;
        private System.Windows.Forms.Button bt_ClearInfo;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button bt_ConnectDevice;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_ReadAutoData;
        private System.Windows.Forms.Button bt_ReadHandData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_MaxDistance;
        private System.Windows.Forms.ComboBox cb_MaxPower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_HandAutoData;
        private System.Windows.Forms.DataGridView dg_HandData;
        private System.Windows.Forms.DataGridView dg_AutoData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_CheckAutoWave;
        private System.Windows.Forms.Button bt_DeleteCheckedAutoData;
        private System.Windows.Forms.Button bt_ClearAutoData;
        private System.Windows.Forms.Button bt_Check;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bt_ClearHandData;
        private System.Windows.Forms.Button bt_DeleteCheckedHandData;
        private System.Windows.Forms.Button bt_CheckHandWave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutoData_StoreTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutoData_DataNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutoData_StoreType;
        private System.Windows.Forms.DataGridViewTextBoxColumn HandData_StoreTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn HandData_StoreDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn HandData_StorePower;
        private System.Windows.Forms.DataGridViewTextBoxColumn HandData_StoreType;
    }
}