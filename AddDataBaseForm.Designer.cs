
namespace DataMigration
{
    partial class AddDataBaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDataBaseForm));
            this.DataBaseType = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectDataBase = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Host = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.PassWord = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.comboBox_list = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DataBaseType
            // 
            this.DataBaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBaseType.FormattingEnabled = true;
            this.DataBaseType.Items.AddRange(new object[] {
            "SqlServer",
            "Oracle",
            "MySql",
            "Sqlite",
            "PostgreSQL"});
            this.DataBaseType.Location = new System.Drawing.Point(211, 140);
            this.DataBaseType.Margin = new System.Windows.Forms.Padding(4);
            this.DataBaseType.Name = "DataBaseType";
            this.DataBaseType.Size = new System.Drawing.Size(244, 25);
            this.DataBaseType.TabIndex = 37;
            this.DataBaseType.SelectedIndexChanged += new System.EventHandler(this.DataBaseType_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(104, 144);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 17);
            this.label19.TabIndex = 36;
            this.label19.Text = "数据库类型：";
            // 
            // type
            // 
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Windows 身份认证",
            "SQL Server 身份认证"});
            this.type.Location = new System.Drawing.Point(211, 191);
            this.type.Margin = new System.Windows.Forms.Padding(4);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(244, 25);
            this.type.TabIndex = 39;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "身份认证：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "主机地址：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "用户名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 349);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "密码：";
            // 
            // SelectDataBase
            // 
            this.SelectDataBase.FormattingEnabled = true;
            this.SelectDataBase.Location = new System.Drawing.Point(211, 399);
            this.SelectDataBase.Margin = new System.Windows.Forms.Padding(4);
            this.SelectDataBase.Name = "SelectDataBase";
            this.SelectDataBase.Size = new System.Drawing.Size(244, 25);
            this.SelectDataBase.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 403);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "选择数据库：";
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(211, 242);
            this.Host.Margin = new System.Windows.Forms.Padding(4);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(244, 23);
            this.Host.TabIndex = 48;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(211, 294);
            this.UserName.Margin = new System.Windows.Forms.Padding(4);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(244, 23);
            this.UserName.TabIndex = 49;
            // 
            // PassWord
            // 
            this.PassWord.Location = new System.Drawing.Point(211, 345);
            this.PassWord.Margin = new System.Windows.Forms.Padding(4);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(244, 23);
            this.PassWord.TabIndex = 50;
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(211, 89);
            this.Title.Margin = new System.Windows.Forms.Padding(4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(244, 23);
            this.Title.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "配置名称：";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(273, 454);
            this.OK.Margin = new System.Windows.Forms.Padding(4);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(88, 33);
            this.OK.TabIndex = 53;
            this.OK.Text = "确定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(477, 396);
            this.load.Margin = new System.Windows.Forms.Padding(4);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(88, 33);
            this.load.TabIndex = 54;
            this.load.Text = "加载数据库";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // comboBox_list
            // 
            this.comboBox_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_list.FormattingEnabled = true;
            this.comboBox_list.Items.AddRange(new object[] {
            "SqlServer",
            "Oracle",
            "Mysql",
            "Sqlite",
            "PostgreSQL"});
            this.comboBox_list.Location = new System.Drawing.Point(211, 40);
            this.comboBox_list.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_list.Name = "comboBox_list";
            this.comboBox_list.Size = new System.Drawing.Size(244, 25);
            this.comboBox_list.TabIndex = 56;
            this.comboBox_list.SelectedIndexChanged += new System.EventHandler(this.comboBox_list_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 55;
            this.label7.Text = "数据库配置集：";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(477, 33);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(55, 37);
            this.button_add.TabIndex = 58;
            this.button_add.Text = "新增";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(540, 33);
            this.button_del.Margin = new System.Windows.Forms.Padding(4);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(55, 37);
            this.button_del.TabIndex = 59;
            this.button_del.Text = "删除";
            this.button_del.UseVisualStyleBackColor = true;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // AddDataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 521);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.comboBox_list);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.load);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.SelectDataBase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataBaseType);
            this.Controls.Add(this.label19);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddDataBaseForm";
            this.Text = "数据库配置信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DataBaseType;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SelectDataBase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox PassWord;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button load;
        private ComboBox comboBox_list;
        private Label label7;
        private Button button_add;
        private Button button_del;
    }
}