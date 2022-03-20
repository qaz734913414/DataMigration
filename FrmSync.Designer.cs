namespace DataMigration
{
    partial class FrmSync
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSync));
            this.gbSource = new System.Windows.Forms.GroupBox();
            this.cbConn = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.gbTarget = new System.Windows.Forms.GroupBox();
            this.btnConnect2 = new System.Windows.Forms.Button();
            this.cbTarget = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSync = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbSetting = new System.Windows.Forms.GroupBox();
            this.btnDifferent = new System.Windows.Forms.Button();
            this.cbIgnoreError = new System.Windows.Forms.CheckBox();
            this.cbSyncSchema = new System.Windows.Forms.CheckBox();
            this.btnSelectOther = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.数据库配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox_log = new System.Windows.Forms.RichTextBox();
            this.gbSource.SuspendLayout();
            this.gbTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbSetting.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSource
            // 
            this.gbSource.Controls.Add(this.cbConn);
            this.gbSource.Controls.Add(this.label4);
            this.gbSource.Controls.Add(this.btnConnection);
            this.gbSource.ForeColor = System.Drawing.Color.DeepPink;
            this.gbSource.Location = new System.Drawing.Point(9, 35);
            this.gbSource.Name = "gbSource";
            this.gbSource.Size = new System.Drawing.Size(389, 54);
            this.gbSource.TabIndex = 9;
            this.gbSource.TabStop = false;
            this.gbSource.Text = "来源";
            // 
            // cbConn
            // 
            this.cbConn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbConn.ForeColor = System.Drawing.Color.DeepPink;
            this.cbConn.FormattingEnabled = true;
            this.cbConn.Location = new System.Drawing.Point(68, 15);
            this.cbConn.Name = "cbConn";
            this.cbConn.Size = new System.Drawing.Size(235, 27);
            this.cbConn.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "连接：";
            // 
            // btnConnection
            // 
            this.btnConnection.ForeColor = System.Drawing.Color.DeepPink;
            this.btnConnection.Location = new System.Drawing.Point(309, 13);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(61, 32);
            this.btnConnection.TabIndex = 8;
            this.btnConnection.Text = "连接";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // gbTarget
            // 
            this.gbTarget.Controls.Add(this.btnConnect2);
            this.gbTarget.Controls.Add(this.cbTarget);
            this.gbTarget.Controls.Add(this.label1);
            this.gbTarget.Enabled = false;
            this.gbTarget.ForeColor = System.Drawing.Color.DeepPink;
            this.gbTarget.Location = new System.Drawing.Point(434, 35);
            this.gbTarget.Name = "gbTarget";
            this.gbTarget.Size = new System.Drawing.Size(413, 54);
            this.gbTarget.TabIndex = 10;
            this.gbTarget.TabStop = false;
            this.gbTarget.Text = "目标";
            // 
            // btnConnect2
            // 
            this.btnConnect2.ForeColor = System.Drawing.Color.DeepPink;
            this.btnConnect2.Location = new System.Drawing.Point(346, 13);
            this.btnConnect2.Name = "btnConnect2";
            this.btnConnect2.Size = new System.Drawing.Size(61, 32);
            this.btnConnect2.TabIndex = 13;
            this.btnConnect2.Text = "连接";
            this.btnConnect2.UseVisualStyleBackColor = true;
            this.btnConnect2.Click += new System.EventHandler(this.btnConnect2_Click);
            // 
            // cbTarget
            // 
            this.cbTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTarget.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbTarget.ForeColor = System.Drawing.Color.DeepPink;
            this.cbTarget.FormattingEnabled = true;
            this.cbTarget.Location = new System.Drawing.Point(68, 17);
            this.cbTarget.Name = "cbTarget";
            this.cbTarget.Size = new System.Drawing.Size(272, 27);
            this.cbTarget.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "连接：";
            // 
            // btnSync
            // 
            this.btnSync.ForeColor = System.Drawing.Color.DeepPink;
            this.btnSync.Location = new System.Drawing.Point(770, 27);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(61, 32);
            this.btnSync.TabIndex = 14;
            this.btnSync.Text = "同步";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(823, 371);
            this.dataGridView1.TabIndex = 11;
            // 
            // gbSetting
            // 
            this.gbSetting.Controls.Add(this.btnDifferent);
            this.gbSetting.Controls.Add(this.btnSync);
            this.gbSetting.Controls.Add(this.cbIgnoreError);
            this.gbSetting.Controls.Add(this.cbSyncSchema);
            this.gbSetting.Controls.Add(this.btnSelectOther);
            this.gbSetting.Controls.Add(this.btnSelectAll);
            this.gbSetting.Enabled = false;
            this.gbSetting.ForeColor = System.Drawing.Color.DeepPink;
            this.gbSetting.Location = new System.Drawing.Point(9, 95);
            this.gbSetting.Name = "gbSetting";
            this.gbSetting.Size = new System.Drawing.Size(837, 72);
            this.gbSetting.TabIndex = 12;
            this.gbSetting.TabStop = false;
            this.gbSetting.Text = "参数";
            // 
            // btnDifferent
            // 
            this.btnDifferent.ForeColor = System.Drawing.Color.DeepPink;
            this.btnDifferent.Location = new System.Drawing.Point(141, 27);
            this.btnDifferent.Name = "btnDifferent";
            this.btnDifferent.Size = new System.Drawing.Size(61, 32);
            this.btnDifferent.TabIndex = 19;
            this.btnDifferent.Text = "选差异";
            this.btnDifferent.UseVisualStyleBackColor = true;
            this.btnDifferent.Click += new System.EventHandler(this.btnDifferent_Click);
            // 
            // cbIgnoreError
            // 
            this.cbIgnoreError.Location = new System.Drawing.Point(338, 35);
            this.cbIgnoreError.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbIgnoreError.Name = "cbIgnoreError";
            this.cbIgnoreError.Size = new System.Drawing.Size(89, 20);
            this.cbIgnoreError.TabIndex = 18;
            this.cbIgnoreError.Text = "忽略错误";
            this.cbIgnoreError.UseVisualStyleBackColor = true;
            // 
            // cbSyncSchema
            // 
            this.cbSyncSchema.Checked = true;
            this.cbSyncSchema.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSyncSchema.Location = new System.Drawing.Point(236, 35);
            this.cbSyncSchema.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbSyncSchema.Name = "cbSyncSchema";
            this.cbSyncSchema.Size = new System.Drawing.Size(89, 20);
            this.cbSyncSchema.TabIndex = 17;
            this.cbSyncSchema.Text = "同步架构";
            this.cbSyncSchema.UseVisualStyleBackColor = true;
            // 
            // btnSelectOther
            // 
            this.btnSelectOther.ForeColor = System.Drawing.Color.DeepPink;
            this.btnSelectOther.Location = new System.Drawing.Point(74, 27);
            this.btnSelectOther.Name = "btnSelectOther";
            this.btnSelectOther.Size = new System.Drawing.Size(61, 32);
            this.btnSelectOther.TabIndex = 16;
            this.btnSelectOther.Text = "反选";
            this.btnSelectOther.UseVisualStyleBackColor = true;
            this.btnSelectOther.Click += new System.EventHandler(this.btnSelectOther_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.ForeColor = System.Drawing.Color.DeepPink;
            this.btnSelectAll.Location = new System.Drawing.Point(7, 27);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(61, 32);
            this.btnSelectAll.TabIndex = 15;
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据库配置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 25);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 数据库配置ToolStripMenuItem
            // 
            this.数据库配置ToolStripMenuItem.Name = "数据库配置ToolStripMenuItem";
            this.数据库配置ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.数据库配置ToolStripMenuItem.Text = "数据库配置";
            this.数据库配置ToolStripMenuItem.Click += new System.EventHandler(this.数据库配置ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 399);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "表";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox_log);
            this.groupBox2.Location = new System.Drawing.Point(9, 578);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(834, 161);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "日志";
            // 
            // richTextBox_log
            // 
            this.richTextBox_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_log.Location = new System.Drawing.Point(6, 22);
            this.richTextBox_log.Name = "richTextBox_log";
            this.richTextBox_log.ReadOnly = true;
            this.richTextBox_log.Size = new System.Drawing.Size(822, 133);
            this.richTextBox_log.TabIndex = 0;
            this.richTextBox_log.Text = "";
            // 
            // FrmSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 751);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSetting);
            this.Controls.Add(this.gbTarget);
            this.Controls.Add(this.gbSource);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmSync";
            this.Text = "跨库数据同步";
            this.Load += new System.EventHandler(this.FrmSync_Load);
            this.gbSource.ResumeLayout(false);
            this.gbSource.PerformLayout();
            this.gbTarget.ResumeLayout(false);
            this.gbTarget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbSetting.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbSource;
        private ComboBox cbConn;
        private Label label4;
        private Button btnConnection;
        private GroupBox gbTarget;
        private ComboBox cbTarget;
        private Label label1;
        private Button btnSync;
        private DataGridView dataGridView1;
        private GroupBox gbSetting;
        private Button btnSelectOther;
        private Button btnSelectAll;
        private CheckBox cbIgnoreError;
        private CheckBox cbSyncSchema;
        private Button btnConnect2;
        private Button btnDifferent;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 数据库配置ToolStripMenuItem;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RichTextBox richTextBox_log;
    }
}