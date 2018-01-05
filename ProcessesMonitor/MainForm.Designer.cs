namespace ProcessesMonitor
{
    partial class MainForm
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
            this.LB_AllProcesses = new System.Windows.Forms.ListBox();
            this.GB_AllProcesses = new System.Windows.Forms.GroupBox();
            this.LB_AllProcessesInfo = new System.Windows.Forms.ListBox();
            this.GB_SelectedProcesses = new System.Windows.Forms.GroupBox();
            this.LB_SelectedActiveProcesses = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_SelectedNonActiveProcesses = new System.Windows.Forms.ListBox();
            this.TB_ProcessName = new System.Windows.Forms.TextBox();
            this.BUT_AddProcess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_ProcessID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BUT_Close = new System.Windows.Forms.Button();
            this.GB_AllProcesses.SuspendLayout();
            this.GB_SelectedProcesses.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_AllProcesses
            // 
            this.LB_AllProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_AllProcesses.BackColor = System.Drawing.Color.LightGray;
            this.LB_AllProcesses.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AllProcesses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LB_AllProcesses.FormattingEnabled = true;
            this.LB_AllProcesses.HorizontalScrollbar = true;
            this.LB_AllProcesses.ItemHeight = 19;
            this.LB_AllProcesses.Location = new System.Drawing.Point(8, 30);
            this.LB_AllProcesses.Margin = new System.Windows.Forms.Padding(4);
            this.LB_AllProcesses.Name = "LB_AllProcesses";
            this.LB_AllProcesses.Size = new System.Drawing.Size(296, 213);
            this.LB_AllProcesses.TabIndex = 0;
            // 
            // GB_AllProcesses
            // 
            this.GB_AllProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_AllProcesses.Controls.Add(this.LB_AllProcessesInfo);
            this.GB_AllProcesses.Controls.Add(this.LB_AllProcesses);
            this.GB_AllProcesses.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_AllProcesses.ForeColor = System.Drawing.Color.Black;
            this.GB_AllProcesses.Location = new System.Drawing.Point(16, 15);
            this.GB_AllProcesses.Margin = new System.Windows.Forms.Padding(4);
            this.GB_AllProcesses.Name = "GB_AllProcesses";
            this.GB_AllProcesses.Padding = new System.Windows.Forms.Padding(4);
            this.GB_AllProcesses.Size = new System.Drawing.Size(314, 512);
            this.GB_AllProcesses.TabIndex = 1;
            this.GB_AllProcesses.TabStop = false;
            this.GB_AllProcesses.Text = "All processes";
            // 
            // LB_AllProcessesInfo
            // 
            this.LB_AllProcessesInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_AllProcessesInfo.BackColor = System.Drawing.Color.LightGray;
            this.LB_AllProcessesInfo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AllProcessesInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LB_AllProcessesInfo.FormattingEnabled = true;
            this.LB_AllProcessesInfo.ItemHeight = 19;
            this.LB_AllProcessesInfo.Location = new System.Drawing.Point(8, 251);
            this.LB_AllProcessesInfo.Margin = new System.Windows.Forms.Padding(4);
            this.LB_AllProcessesInfo.Name = "LB_AllProcessesInfo";
            this.LB_AllProcessesInfo.Size = new System.Drawing.Size(296, 251);
            this.LB_AllProcessesInfo.TabIndex = 2;
            // 
            // GB_SelectedProcesses
            // 
            this.GB_SelectedProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_SelectedProcesses.Controls.Add(this.LB_SelectedActiveProcesses);
            this.GB_SelectedProcesses.Controls.Add(this.label4);
            this.GB_SelectedProcesses.Controls.Add(this.label3);
            this.GB_SelectedProcesses.Controls.Add(this.LB_SelectedNonActiveProcesses);
            this.GB_SelectedProcesses.Controls.Add(this.TB_ProcessName);
            this.GB_SelectedProcesses.Controls.Add(this.BUT_AddProcess);
            this.GB_SelectedProcesses.Controls.Add(this.label2);
            this.GB_SelectedProcesses.Controls.Add(this.CB_ProcessID);
            this.GB_SelectedProcesses.Controls.Add(this.label1);
            this.GB_SelectedProcesses.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_SelectedProcesses.Location = new System.Drawing.Point(338, 15);
            this.GB_SelectedProcesses.Margin = new System.Windows.Forms.Padding(4);
            this.GB_SelectedProcesses.Name = "GB_SelectedProcesses";
            this.GB_SelectedProcesses.Padding = new System.Windows.Forms.Padding(4);
            this.GB_SelectedProcesses.Size = new System.Drawing.Size(843, 512);
            this.GB_SelectedProcesses.TabIndex = 2;
            this.GB_SelectedProcesses.TabStop = false;
            this.GB_SelectedProcesses.Text = "Selected processes";
            // 
            // LB_SelectedActiveProcesses
            // 
            this.LB_SelectedActiveProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_SelectedActiveProcesses.BackColor = System.Drawing.Color.LightGray;
            this.LB_SelectedActiveProcesses.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_SelectedActiveProcesses.ForeColor = System.Drawing.Color.Green;
            this.LB_SelectedActiveProcesses.FormattingEnabled = true;
            this.LB_SelectedActiveProcesses.ItemHeight = 19;
            this.LB_SelectedActiveProcesses.Location = new System.Drawing.Point(21, 213);
            this.LB_SelectedActiveProcesses.Margin = new System.Windows.Forms.Padding(4);
            this.LB_SelectedActiveProcesses.Name = "LB_SelectedActiveProcesses";
            this.LB_SelectedActiveProcesses.Size = new System.Drawing.Size(401, 289);
            this.LB_SelectedActiveProcesses.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Non-active processes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Active processes:";
            // 
            // LB_SelectedNonActiveProcesses
            // 
            this.LB_SelectedNonActiveProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LB_SelectedNonActiveProcesses.BackColor = System.Drawing.Color.LightGray;
            this.LB_SelectedNonActiveProcesses.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_SelectedNonActiveProcesses.ForeColor = System.Drawing.Color.Red;
            this.LB_SelectedNonActiveProcesses.FormattingEnabled = true;
            this.LB_SelectedNonActiveProcesses.ItemHeight = 19;
            this.LB_SelectedNonActiveProcesses.Location = new System.Drawing.Point(432, 213);
            this.LB_SelectedNonActiveProcesses.Margin = new System.Windows.Forms.Padding(4);
            this.LB_SelectedNonActiveProcesses.Name = "LB_SelectedNonActiveProcesses";
            this.LB_SelectedNonActiveProcesses.Size = new System.Drawing.Size(401, 289);
            this.LB_SelectedNonActiveProcesses.TabIndex = 8;
            // 
            // TB_ProcessName
            // 
            this.TB_ProcessName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_ProcessName.BackColor = System.Drawing.Color.LightGray;
            this.TB_ProcessName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ProcessName.Location = new System.Drawing.Point(210, 75);
            this.TB_ProcessName.Margin = new System.Windows.Forms.Padding(4);
            this.TB_ProcessName.Name = "TB_ProcessName";
            this.TB_ProcessName.Size = new System.Drawing.Size(621, 27);
            this.TB_ProcessName.TabIndex = 7;
            // 
            // BUT_AddProcess
            // 
            this.BUT_AddProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_AddProcess.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BUT_AddProcess.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_AddProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BUT_AddProcess.Location = new System.Drawing.Point(19, 116);
            this.BUT_AddProcess.Margin = new System.Windows.Forms.Padding(4);
            this.BUT_AddProcess.Name = "BUT_AddProcess";
            this.BUT_AddProcess.Size = new System.Drawing.Size(814, 39);
            this.BUT_AddProcess.TabIndex = 6;
            this.BUT_AddProcess.Text = "Add process";
            this.BUT_AddProcess.UseVisualStyleBackColor = false;
            this.BUT_AddProcess.Click += new System.EventHandler(this.BUT_AddProcess_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Process Name";
            // 
            // CB_ProcessID
            // 
            this.CB_ProcessID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_ProcessID.BackColor = System.Drawing.Color.LightGray;
            this.CB_ProcessID.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ProcessID.FormattingEnabled = true;
            this.CB_ProcessID.Location = new System.Drawing.Point(210, 35);
            this.CB_ProcessID.Margin = new System.Windows.Forms.Padding(4);
            this.CB_ProcessID.Name = "CB_ProcessID";
            this.CB_ProcessID.Size = new System.Drawing.Size(621, 27);
            this.CB_ProcessID.TabIndex = 2;
            this.CB_ProcessID.SelectedIndexChanged += new System.EventHandler(this.CB_ProcessID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Process ID";
            // 
            // BUT_Close
            // 
            this.BUT_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BUT_Close.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BUT_Close.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BUT_Close.Location = new System.Drawing.Point(940, 531);
            this.BUT_Close.Margin = new System.Windows.Forms.Padding(4);
            this.BUT_Close.Name = "BUT_Close";
            this.BUT_Close.Size = new System.Drawing.Size(243, 33);
            this.BUT_Close.TabIndex = 4;
            this.BUT_Close.Text = "Close";
            this.BUT_Close.UseVisualStyleBackColor = false;
            this.BUT_Close.Click += new System.EventHandler(this.BUT_Close_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1191, 568);
            this.Controls.Add(this.BUT_Close);
            this.Controls.Add(this.GB_SelectedProcesses);
            this.Controls.Add(this.GB_AllProcesses);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Process Monitor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.GB_AllProcesses.ResumeLayout(false);
            this.GB_SelectedProcesses.ResumeLayout(false);
            this.GB_SelectedProcesses.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LB_AllProcesses;
        private System.Windows.Forms.GroupBox GB_AllProcesses;
        private System.Windows.Forms.ListBox LB_AllProcessesInfo;
        private System.Windows.Forms.GroupBox GB_SelectedProcesses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_ProcessID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BUT_AddProcess;
        private System.Windows.Forms.Button BUT_Close;
        private System.Windows.Forms.TextBox TB_ProcessName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LB_SelectedNonActiveProcesses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LB_SelectedActiveProcesses;
    }
}

