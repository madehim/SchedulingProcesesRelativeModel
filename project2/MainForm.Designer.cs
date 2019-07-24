namespace project2
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ReadyQuue = new System.Windows.Forms.ListView();
            this.ReadyQuueID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReadyQuueName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReadyQuuePriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReadyQuueStage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.WaitingQuue = new System.Windows.Forms.ListView();
            this.WaitingQuueID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WaitingQuueName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WaitingQuuePriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WaitingQuueStage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExecutedProcessId = new System.Windows.Forms.TextBox();
            this.ExecutedProcessName = new System.Windows.Forms.TextBox();
            this.ExecutedProcessTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AutoGenerateButton = new System.Windows.Forms.Button();
            this.LogView = new System.Windows.Forms.ListView();
            this.LogID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.AutoGenerateTimer = new System.Windows.Forms.Timer(this.components);
            this.ExecutedTimer = new System.Windows.Forms.Timer(this.components);
            this.StopGenerateButton = new System.Windows.Forms.Button();
            this.WaitingQuueTimer = new System.Windows.Forms.Timer(this.components);
            this.GenerateStageRangeMin = new System.Windows.Forms.NumericUpDown();
            this.GenerateStageRangeMax = new System.Windows.Forms.NumericUpDown();
            this.GenerateStageTimeRangeMin = new System.Windows.Forms.NumericUpDown();
            this.GenerateStageTimeRangeMax = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GenerateTaskTimeRange = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ProcessorTickK = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.ProgressView = new System.Windows.Forms.DataGridView();
            this.RefreshIDInfo = new System.Windows.Forms.Timer(this.components);
            this.IdInfo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.GenerateStageRangeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerateStageRangeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerateStageTimeRangeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerateStageTimeRangeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerateTaskTimeRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessorTickK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadyQuue
            // 
            this.ReadyQuue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ReadyQuueID,
            this.ReadyQuueName,
            this.ReadyQuuePriority,
            this.ReadyQuueStage});
            this.ReadyQuue.GridLines = true;
            this.ReadyQuue.Location = new System.Drawing.Point(2, 24);
            this.ReadyQuue.Name = "ReadyQuue";
            this.ReadyQuue.Size = new System.Drawing.Size(399, 226);
            this.ReadyQuue.TabIndex = 0;
            this.ReadyQuue.UseCompatibleStateImageBehavior = false;
            this.ReadyQuue.View = System.Windows.Forms.View.Details;
            // 
            // ReadyQuueID
            // 
            this.ReadyQuueID.Text = "ID";
            this.ReadyQuueID.Width = 54;
            // 
            // ReadyQuueName
            // 
            this.ReadyQuueName.Text = "Name";
            this.ReadyQuueName.Width = 146;
            // 
            // ReadyQuuePriority
            // 
            this.ReadyQuuePriority.Text = "Priority";
            this.ReadyQuuePriority.Width = 91;
            // 
            // ReadyQuueStage
            // 
            this.ReadyQuueStage.Text = "Stage";
            this.ReadyQuueStage.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ReadyQuue";
            // 
            // WaitingQuue
            // 
            this.WaitingQuue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.WaitingQuueID,
            this.WaitingQuueName,
            this.WaitingQuuePriority,
            this.WaitingQuueStage});
            this.WaitingQuue.GridLines = true;
            this.WaitingQuue.Location = new System.Drawing.Point(419, 24);
            this.WaitingQuue.Name = "WaitingQuue";
            this.WaitingQuue.Size = new System.Drawing.Size(399, 226);
            this.WaitingQuue.TabIndex = 2;
            this.WaitingQuue.UseCompatibleStateImageBehavior = false;
            this.WaitingQuue.View = System.Windows.Forms.View.Details;
            // 
            // WaitingQuueID
            // 
            this.WaitingQuueID.Text = "ID";
            // 
            // WaitingQuueName
            // 
            this.WaitingQuueName.Text = "Name";
            this.WaitingQuueName.Width = 149;
            // 
            // WaitingQuuePriority
            // 
            this.WaitingQuuePriority.Text = "Priority";
            this.WaitingQuuePriority.Width = 100;
            // 
            // WaitingQuueStage
            // 
            this.WaitingQuueStage.Text = "Stage";
            this.WaitingQuueStage.Width = 86;
            // 
            // ExecutedProcessId
            // 
            this.ExecutedProcessId.Location = new System.Drawing.Point(27, 280);
            this.ExecutedProcessId.Name = "ExecutedProcessId";
            this.ExecutedProcessId.ReadOnly = true;
            this.ExecutedProcessId.Size = new System.Drawing.Size(125, 20);
            this.ExecutedProcessId.TabIndex = 3;
            // 
            // ExecutedProcessName
            // 
            this.ExecutedProcessName.Location = new System.Drawing.Point(173, 280);
            this.ExecutedProcessName.Name = "ExecutedProcessName";
            this.ExecutedProcessName.ReadOnly = true;
            this.ExecutedProcessName.Size = new System.Drawing.Size(136, 20);
            this.ExecutedProcessName.TabIndex = 4;
            // 
            // ExecutedProcessTime
            // 
            this.ExecutedProcessTime.Location = new System.Drawing.Point(352, 279);
            this.ExecutedProcessTime.Name = "ExecutedProcessTime";
            this.ExecutedProcessTime.ReadOnly = true;
            this.ExecutedProcessTime.Size = new System.Drawing.Size(111, 20);
            this.ExecutedProcessTime.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "WaitingQuue";
            // 
            // AutoGenerateButton
            // 
            this.AutoGenerateButton.Location = new System.Drawing.Point(813, 277);
            this.AutoGenerateButton.Name = "AutoGenerateButton";
            this.AutoGenerateButton.Size = new System.Drawing.Size(83, 23);
            this.AutoGenerateButton.TabIndex = 7;
            this.AutoGenerateButton.Text = "AutoGenerate";
            this.AutoGenerateButton.UseVisualStyleBackColor = true;
            this.AutoGenerateButton.Click += new System.EventHandler(this.AutoGenerateButton_Click);
            // 
            // LogView
            // 
            this.LogView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LogID,
            this.LogName,
            this.LogStatus,
            this.LogTime});
            this.LogView.Location = new System.Drawing.Point(27, 331);
            this.LogView.Name = "LogView";
            this.LogView.Size = new System.Drawing.Size(970, 185);
            this.LogView.TabIndex = 8;
            this.LogView.UseCompatibleStateImageBehavior = false;
            this.LogView.View = System.Windows.Forms.View.Details;
            // 
            // LogID
            // 
            this.LogID.Text = "ID";
            this.LogID.Width = 73;
            // 
            // LogName
            // 
            this.LogName.Text = "Name";
            this.LogName.Width = 210;
            // 
            // LogStatus
            // 
            this.LogStatus.Text = "Status";
            this.LogStatus.Width = 502;
            // 
            // LogTime
            // 
            this.LogTime.Text = "Time";
            this.LogTime.Width = 167;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Log";
            // 
            // AutoGenerateTimer
            // 
            this.AutoGenerateTimer.Interval = 4000;
            this.AutoGenerateTimer.Tick += new System.EventHandler(this.AutoGenerateTimer_Tick);
            // 
            // ExecutedTimer
            // 
            this.ExecutedTimer.Tick += new System.EventHandler(this.ExecutedTimer_Tick);
            // 
            // StopGenerateButton
            // 
            this.StopGenerateButton.Enabled = false;
            this.StopGenerateButton.Location = new System.Drawing.Point(918, 277);
            this.StopGenerateButton.Name = "StopGenerateButton";
            this.StopGenerateButton.Size = new System.Drawing.Size(88, 23);
            this.StopGenerateButton.TabIndex = 10;
            this.StopGenerateButton.Text = "StopGenerate";
            this.StopGenerateButton.UseVisualStyleBackColor = true;
            this.StopGenerateButton.Click += new System.EventHandler(this.StopGenerateButton_Click);
            // 
            // WaitingQuueTimer
            // 
            this.WaitingQuueTimer.Interval = 1000;
            this.WaitingQuueTimer.Tick += new System.EventHandler(this.WaitingQuueTimer_Tick);
            // 
            // GenerateStageRangeMin
            // 
            this.GenerateStageRangeMin.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.GenerateStageRangeMin.Location = new System.Drawing.Point(833, 43);
            this.GenerateStageRangeMin.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.GenerateStageRangeMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GenerateStageRangeMin.Name = "GenerateStageRangeMin";
            this.GenerateStageRangeMin.Size = new System.Drawing.Size(79, 20);
            this.GenerateStageRangeMin.TabIndex = 11;
            this.GenerateStageRangeMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GenerateStageRangeMin.ValueChanged += new System.EventHandler(this.GenerateStageRangeMin_ValueChanged);
            this.GenerateStageRangeMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GenerateStageRangeMin_KeyPress);
            // 
            // GenerateStageRangeMax
            // 
            this.GenerateStageRangeMax.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.GenerateStageRangeMax.Location = new System.Drawing.Point(918, 43);
            this.GenerateStageRangeMax.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.GenerateStageRangeMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GenerateStageRangeMax.Name = "GenerateStageRangeMax";
            this.GenerateStageRangeMax.Size = new System.Drawing.Size(79, 20);
            this.GenerateStageRangeMax.TabIndex = 12;
            this.GenerateStageRangeMax.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.GenerateStageRangeMax.ValueChanged += new System.EventHandler(this.GenerateStageRangeMax_ValueChanged);
            this.GenerateStageRangeMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GenerateStageRangeMax_KeyPress);
            // 
            // GenerateStageTimeRangeMin
            // 
            this.GenerateStageTimeRangeMin.Location = new System.Drawing.Point(833, 95);
            this.GenerateStageTimeRangeMin.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.GenerateStageTimeRangeMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GenerateStageTimeRangeMin.Name = "GenerateStageTimeRangeMin";
            this.GenerateStageTimeRangeMin.Size = new System.Drawing.Size(79, 20);
            this.GenerateStageTimeRangeMin.TabIndex = 13;
            this.GenerateStageTimeRangeMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GenerateStageTimeRangeMin.ValueChanged += new System.EventHandler(this.GenerateStageTimeRangeMin_ValueChanged);
            // 
            // GenerateStageTimeRangeMax
            // 
            this.GenerateStageTimeRangeMax.Location = new System.Drawing.Point(918, 95);
            this.GenerateStageTimeRangeMax.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.GenerateStageTimeRangeMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GenerateStageTimeRangeMax.Name = "GenerateStageTimeRangeMax";
            this.GenerateStageTimeRangeMax.Size = new System.Drawing.Size(79, 20);
            this.GenerateStageTimeRangeMax.TabIndex = 14;
            this.GenerateStageTimeRangeMax.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.GenerateStageTimeRangeMax.ValueChanged += new System.EventHandler(this.GenerateStageTimeRangeMax_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(830, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "GenerateStageRange";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(830, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "GenerateStageTimeRange";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(830, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "GenerateTaskTimeRange";
            // 
            // GenerateTaskTimeRange
            // 
            this.GenerateTaskTimeRange.Location = new System.Drawing.Point(833, 145);
            this.GenerateTaskTimeRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GenerateTaskTimeRange.Name = "GenerateTaskTimeRange";
            this.GenerateTaskTimeRange.Size = new System.Drawing.Size(164, 20);
            this.GenerateTaskTimeRange.TabIndex = 18;
            this.GenerateTaskTimeRange.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.GenerateTaskTimeRange.ValueChanged += new System.EventHandler(this.GenerateTaskTimeRange_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "ExecuteTaskID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "ExecuteTaskName";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(349, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "ExecuteTaskTime";
            // 
            // ProcessorTickK
            // 
            this.ProcessorTickK.DecimalPlaces = 2;
            this.ProcessorTickK.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ProcessorTickK.Location = new System.Drawing.Point(833, 195);
            this.ProcessorTickK.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ProcessorTickK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ProcessorTickK.Name = "ProcessorTickK";
            this.ProcessorTickK.Size = new System.Drawing.Size(164, 20);
            this.ProcessorTickK.TabIndex = 22;
            this.ProcessorTickK.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ProcessorTickK.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(830, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "ProcessorTick";
            // 
            // ProgressView
            // 
            this.ProgressView.BackgroundColor = System.Drawing.Color.White;
            this.ProgressView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProgressView.Location = new System.Drawing.Point(501, 287);
            this.ProgressView.Name = "ProgressView";
            this.ProgressView.RowHeadersVisible = false;
            this.ProgressView.RowHeadersWidth = 4;
            this.ProgressView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProgressView.Size = new System.Drawing.Size(254, 38);
            this.ProgressView.TabIndex = 27;
            // 
            // RefreshIDInfo
            // 
            this.RefreshIDInfo.Enabled = true;
            this.RefreshIDInfo.Interval = 50;
            this.RefreshIDInfo.Tick += new System.EventHandler(this.RefreshIDInfo_Tick_1);
            // 
            // IdInfo
            // 
            this.IdInfo.Location = new System.Drawing.Point(501, 264);
            this.IdInfo.Name = "IdInfo";
            this.IdInfo.Size = new System.Drawing.Size(120, 20);
            this.IdInfo.TabIndex = 28;
            this.IdInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdInfo_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 518);
            this.Controls.Add(this.IdInfo);
            this.Controls.Add(this.ProgressView);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ProcessorTickK);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GenerateTaskTimeRange);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GenerateStageTimeRangeMax);
            this.Controls.Add(this.GenerateStageTimeRangeMin);
            this.Controls.Add(this.GenerateStageRangeMax);
            this.Controls.Add(this.GenerateStageRangeMin);
            this.Controls.Add(this.StopGenerateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LogView);
            this.Controls.Add(this.AutoGenerateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExecutedProcessTime);
            this.Controls.Add(this.ExecutedProcessName);
            this.Controls.Add(this.ExecutedProcessId);
            this.Controls.Add(this.WaitingQuue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReadyQuue);
            this.Name = "Form1";
            this.Text = "CourseWork";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.GenerateStageRangeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerateStageRangeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerateStageTimeRangeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerateStageTimeRangeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerateTaskTimeRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessorTickK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ReadyQuue;
        private System.Windows.Forms.ColumnHeader ReadyQuueID;
        private System.Windows.Forms.ColumnHeader ReadyQuueName;
        private System.Windows.Forms.ColumnHeader ReadyQuuePriority;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView WaitingQuue;
        private System.Windows.Forms.ColumnHeader WaitingQuueID;
        private System.Windows.Forms.ColumnHeader WaitingQuueName;
        private System.Windows.Forms.ColumnHeader WaitingQuuePriority;
        private System.Windows.Forms.TextBox ExecutedProcessId;
        private System.Windows.Forms.TextBox ExecutedProcessName;
        private System.Windows.Forms.TextBox ExecutedProcessTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AutoGenerateButton;
        private System.Windows.Forms.ListView LogView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader LogID;
        private System.Windows.Forms.ColumnHeader LogName;
        private System.Windows.Forms.ColumnHeader LogStatus;
        private System.Windows.Forms.ColumnHeader LogTime;
        private System.Windows.Forms.Timer AutoGenerateTimer;
        private System.Windows.Forms.Timer ExecutedTimer;
        private System.Windows.Forms.Button StopGenerateButton;
        private System.Windows.Forms.Timer WaitingQuueTimer;
        private System.Windows.Forms.ColumnHeader ReadyQuueStage;
        private System.Windows.Forms.ColumnHeader WaitingQuueStage;
        private System.Windows.Forms.NumericUpDown GenerateStageRangeMin;
        private System.Windows.Forms.NumericUpDown GenerateStageRangeMax;
        private System.Windows.Forms.NumericUpDown GenerateStageTimeRangeMin;
        private System.Windows.Forms.NumericUpDown GenerateStageTimeRangeMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown GenerateTaskTimeRange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown ProcessorTickK;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView ProgressView;
        private System.Windows.Forms.Timer RefreshIDInfo;
        private System.Windows.Forms.NumericUpDown IdInfo;
    }
}

