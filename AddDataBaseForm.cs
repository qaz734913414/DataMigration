using System.Data;
using System.Data.Common;
using XCode.DataAccessLayer;

namespace DataMigration
{
    public partial class AddDataBaseForm : Form
    {
        private DataBaseConfig dbConfig = null;
        //private SqlSugarDBHelper db = null;
        private bool isUpdate = true;
        public AddDataBaseForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            DataBaseType.SelectedIndex = 0;
            type.SelectedIndex = 0;
            //isUpdate = false;
            loadData();
        }

        public void loadData()
        {
            var dbs = DataBaseConfig.FindAll();
            comboBox_list.Items.Clear();
            foreach (var dbsItem in dbs)
            {
                comboBox_list.Items.Add(dbsItem.Name);
            }
            if (comboBox_list.Items.Count > 0)
            {
                comboBox_list.SelectedIndex = 0;
                isUpdate = true;
            }
            else
            {
                isUpdate = false;
                Title.Enabled = true;
            }
        }

        private void comboBox_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;
            var dbConfig = DataBaseConfig.Find(DataBaseConfig._.Name == comboBox.Text);
            if (dbConfig != null)
            {
                if (isUpdate)
                { 
                    Title.Enabled = false;
                }
                try
                {
                    this.StartPosition = FormStartPosition.CenterScreen;
                    DataBaseType.SelectedIndex = 0;
                    type.SelectedIndex = 0;
                    dbConfig.ConnectionStrings = "";
                    Title.Text = dbConfig.Name;
                    switch ((DatabaseType)dbConfig.DataType)
                    {
                        case DatabaseType.SqlServer:
                            DataBaseType.SelectedIndex = 0;
                            break;
                        case DatabaseType.Oracle:
                            DataBaseType.SelectedIndex = 1;
                            break;
                        case DatabaseType.MySql:
                            DataBaseType.SelectedIndex = 2;
                            break;
                        case DatabaseType.SQLite:
                            DataBaseType.SelectedIndex = 3;
                            break;
                        case DatabaseType.PostgreSQL:
                            DataBaseType.SelectedIndex = 4;
                            break;
                    }
                    if (dbConfig.UserName == null || dbConfig.UserPass == null ||
                            (dbConfig.UserName.Equals("") && dbConfig.UserPass.Equals("")))
                    {
                        type.SelectedIndex = 0;
                        UserName.Enabled = false;
                        PassWord.Enabled = false;
                    }
                    else
                    {
                        type.SelectedIndex = 1;
                        UserName.Enabled = true;
                        PassWord.Enabled = true;
                    }
                    if (dbConfig.ServerIP != null)
                        Host.Text = dbConfig.ServerIP;
                    if (dbConfig.UserName != null)
                        UserName.Text = dbConfig.UserName;
                    if (dbConfig.UserPass != null)
                        PassWord.Text = dbConfig.UserPass;
                    SelectDataBase.Items.Clear();
                    if (dbConfig.DataBaseName != null)
                    {
                        SelectDataBase.Items.Add(dbConfig.DataBaseName);
                        SelectDataBase.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Title.Enabled = true;
            DataBaseType.SelectedIndex = 0;
            type.SelectedIndex = 0;
            isUpdate = false;
            dbConfig = null;
            SelectDataBase.Text = "";
            Title.Text = "";
            Host.Text = "";
            UserName.Text = "";
            PassWord.Text = "";
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.Text.Trim().Equals("Windows 身份认证") && DataBaseType.SelectedIndex == 0)
            {
                UserName.Enabled = false;
                PassWord.Enabled = false;
                Host.Text = ".";
                Host.Enabled = false;
            }
            else
            {
                UserName.Enabled = true;
                PassWord.Enabled = true;
                Host.Enabled = true;
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (Host.Text.Trim().Equals(""))
                {
                    MessageBox.Show("主机地址不能为空");
                    return;
                }

                if (!type.Text.Trim().Equals("Windows 身份认证") &&
                    (UserName.Text.Trim().Equals("") || PassWord.Text.Trim().Equals("")))
                {
                    MessageBox.Show("用户名和密码不能为空");
                    return;
                }

                if (Title.Text.Trim().Equals(""))
                {
                    MessageBox.Show("配置名称不能为空");
                    return;
                }
                if (SelectDataBase.Text.Trim().Equals("") && !DataBaseType.Text.Trim().Equals("Sqlite"))
                {
                    MessageBox.Show("数据库名称不能为空");
                    return;
                }
                if (dbConfig == null)
                    dbConfig = new DataBaseConfig();
                dbConfig.ConnectionStrings = "";

                switch (DataBaseType.Text.Trim())
                {
                    case "SqlServer":
                        dbConfig.DataType = (long)DatabaseType.SqlServer;
                        break;
                    case "Oracle":
                        dbConfig.DataType = (long)DatabaseType.Oracle;
                        break;
                    case "MySql":
                        dbConfig.DataType = (long)DatabaseType.MySql;
                        break;
                    case "Sqlite":
                        dbConfig.DataType = (long)DatabaseType.SQLite;
                        break;
                    case "PostgreSQL":
                        dbConfig.DataType = (long)DatabaseType.PostgreSQL;
                        break;
                }
                dbConfig.DataBaseName = SelectDataBase.Text.Trim();
                dbConfig.Name = Title.Text.Trim();
                dbConfig.ServerIP = Host.Text.Trim();
                dbConfig.UserName = UserName.Text.Trim();
                dbConfig.UserPass = PassWord.Text.Trim();
                
                if (isUpdate)
                {
                    var dbconfig_t = DataBaseConfig.Find(DataBaseConfig._.Name == dbConfig.Name);
                    dbconfig_t.Delete();
                    dbConfig.Insert();
                    dbConfig = null;
                    SelectDataBase.Text = "";
                    Title.Text = "";
                    Host.Text = "";
                    UserName.Text = "";
                    PassWord.Text = "";
                    loadData();
                    MessageBox.Show("修改成功");
                }
                else
                {
                    var db = DataBaseConfig.Find(DataBaseConfig._.Name == dbConfig.Name);
                    if (db != null)
                    {
                        MessageBox.Show("配置名称已存在");
                        return;
                    }
                    else
                    {
                        dbConfig.Insert();
                        dbConfig = null;
                        SelectDataBase.Text = "";
                        Title.Text = "";
                        Host.Text = "";
                        UserName.Text = "";
                        PassWord.Text = "";
                        SelectDataBase.Text = "";
                        loadData();
                        MessageBox.Show("保存成功");
                    }
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            try
            {
                if (Title.Text.Trim().Equals(""))
                {
                    MessageBox.Show("配置名称不能为空");
                    return;
                }
                if (Host.Text.Trim().Equals(""))
                {
                    MessageBox.Show("主机地址不能为空");
                    return;
                }

                if (!type.Text.Trim().Equals("Windows 身份认证") &&
                    (UserName.Text.Trim().Equals("") || PassWord.Text.Trim().Equals("")))
                {
                    MessageBox.Show("用户名和密码不能为空");
                    return;
                }
                if (dbConfig == null)
                {
                    dbConfig = new DataBaseConfig();
                }
                dbConfig.ConnectionStrings = "";

                switch (DataBaseType.Text.Trim())
                {
                    case "SqlServer":
                        dbConfig.DataType = (long)DatabaseType.SqlServer;
                        break;
                    case "Oracle":
                        dbConfig.DataType = (long)DatabaseType.Oracle;
                        break;
                    case "MySql":
                        dbConfig.DataType = (long)DatabaseType.MySql;
                        break;
                    case "Sqlite":
                        dbConfig.DataType = (long)DatabaseType.SQLite;
                        break;
                    case "PostgreSQL":
                        dbConfig.DataType = (long)DatabaseType.PostgreSQL;
                        break;
                }
                if (dbConfig.DataType == (long)DatabaseType.SqlServer)
                {
                    dbConfig.Name = Title.Text.Trim();
                    dbConfig.ServerIP = Host.Text.Trim();
                    dbConfig.UserName = UserName.Text.Trim();
                    dbConfig.UserPass = PassWord.Text.Trim();
                    dbConfig.DataBaseName = "master";
                    var providerName = DbHelper.CheckDBConfig(dbConfig);
                    DAL.AddConnStr(dbConfig.Name + "_temp", dbConfig.ConnectionStrings, null, providerName);
                    var dal = DAL.Create(dbConfig.Name + "_temp");
                    DataTable dt = new DataTable();

                    // 列出所有数据库

                    if (dal.Db.CreateMetaData().MetaDataCollections.Contains("Databases"))
                    {
                        dt = dal.Db.CreateSession().GetSchema(null, "Databases", null);
                    }

                    DAL.ConnStrs.Remove(dbConfig.Name + "_temp");
                    // 统计库名
                    var names = new List<String>();
                    if (dt.Rows.Count > 0)
                    {
                        var dbprovider = dal.DbType.ToString();
                        var builder = new DbConnectionStringBuilder
                        {
                            ConnectionString = dal.ConnStr
                        };


                        var sysdbnames = new String[] { "master", "tempdb", "model", "msdb" };
                        foreach (DataRow dr in dt.Rows)
                        {
                            var dbname = dr[0].ToString();
                            if (Array.IndexOf(sysdbnames, dbname) >= 0) continue;

                            builder["Database"] = dbname;

                            try
                            {
                                var ver = dal.Db.ServerVersion;
                                names.Add(dbname);
                            }
                            catch
                            {

                            }
                        }
                    }

                    SelectDataBase.Items.Clear();
                    foreach (string dbStr in names)
                    {
                        SelectDataBase.Items.Add(dbStr);
                    }
                    if (SelectDataBase.Items.Count > 0)
                    {
                        SelectDataBase.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

                
        }

        private void DataBaseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataBaseType.Text.Trim().Equals("SqlServer"))
            {
                load.Enabled = true;
                type.Enabled = true;
                SelectDataBase.Enabled = true;
                if (type.Text.Trim().Equals("Windows 身份认证"))
                {
                    UserName.Enabled = false;
                    PassWord.Enabled = false;
                    Host.Text = ".";
                    Host.Enabled = false;
                }
                else
                {
                    UserName.Enabled = true;
                    PassWord.Enabled = true;
                    Host.Enabled = true;
                }
            }
            else
            {
                load.Enabled = false;
                type.Enabled = false;
                if (DataBaseType.Text.Trim().Equals("Sqlite"))
                {
                    
                    UserName.Enabled = false;
                    PassWord.Enabled = false;
                    SelectDataBase.Enabled = false;
                    Host.Enabled = true;
                }
                else
                {
                    UserName.Enabled = true;
                    PassWord.Enabled = true;
                    SelectDataBase.Enabled = true;
                    Host.Enabled = true;
                }
                
            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Title.Text.Trim()))
            {
                try
                {
                    var dbconfig_t = DataBaseConfig.Find(DataBaseConfig._.Name == Title.Text.Trim());
                    dbconfig_t.Delete();
                    dbConfig = null;
                    SelectDataBase.Text = "";
                    Title.Text = "";
                    Host.Text = "";
                    UserName.Text = "";
                    PassWord.Text = "";
                    SelectDataBase.Text = "";
                    loadData();
                    MessageBox.Show("删除成功");
                }
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
