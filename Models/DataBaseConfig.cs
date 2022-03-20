using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace DataMigration
{
    /// <summary></summary>
    [Serializable]
    [DataObject]
    [BindTable("DataBaseConfig", Description = "", ConnName = "DataBaseConfig", DbType = DatabaseType.SQLite)]
    public partial class DataBaseConfig
    {
        #region 属性
        private String _Name;
        /// <summary></summary>
        [DisplayName("Name")]
        [DataObjectField(false, false, false, 255)]
        [BindColumn("Name", "", "varchar(255)", Master = true)]
        public String Name { get => _Name; set { if (OnPropertyChanging("Name", value)) { _Name = value; OnPropertyChanged("Name"); } } }

        private Int64 _DataType;
        /// <summary></summary>
        [DisplayName("DataType")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("DataType", "", "integer")]
        public Int64 DataType { get => _DataType; set { if (OnPropertyChanging("DataType", value)) { _DataType = value; OnPropertyChanged("DataType"); } } }

        private String _ServerIP;
        /// <summary></summary>
        [DisplayName("ServerIP")]
        [DataObjectField(false, false, false, 255)]
        [BindColumn("ServerIP", "", "varchar(255)")]
        public String ServerIP { get => _ServerIP; set { if (OnPropertyChanging("ServerIP", value)) { _ServerIP = value; OnPropertyChanged("ServerIP"); } } }

        private Int64 _Port;
        /// <summary></summary>
        [DisplayName("Port")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Port", "", "integer")]
        public Int64 Port { get => _Port; set { if (OnPropertyChanging("Port", value)) { _Port = value; OnPropertyChanged("Port"); } } }

        private String _DataBaseName;
        /// <summary></summary>
        [DisplayName("DataBaseName")]
        [DataObjectField(false, false, false, 255)]
        [BindColumn("DataBaseName", "", "varchar(255)")]
        public String DataBaseName { get => _DataBaseName; set { if (OnPropertyChanging("DataBaseName", value)) { _DataBaseName = value; OnPropertyChanged("DataBaseName"); } } }

        private String _UserName;
        /// <summary></summary>
        [DisplayName("UserName")]
        [DataObjectField(false, false, false, 255)]
        [BindColumn("UserName", "", "varchar(255)")]
        public String UserName { get => _UserName; set { if (OnPropertyChanging("UserName", value)) { _UserName = value; OnPropertyChanged("UserName"); } } }

        private String _UserPass;
        /// <summary></summary>
        [DisplayName("UserPass")]
        [DataObjectField(false, false, false, 255)]
        [BindColumn("UserPass", "", "varchar(255)")]
        public String UserPass { get => _UserPass; set { if (OnPropertyChanging("UserPass", value)) { _UserPass = value; OnPropertyChanged("UserPass"); } } }

        private String _ConnectionStrings;
        /// <summary></summary>
        [DisplayName("ConnectionStrings")]
        [DataObjectField(false, false, false, 255)]
        [BindColumn("ConnectionStrings", "", "varchar(255)")]
        public String ConnectionStrings { get => _ConnectionStrings; set { if (OnPropertyChanging("ConnectionStrings", value)) { _ConnectionStrings = value; OnPropertyChanged("ConnectionStrings"); } } }

        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case "Name": return _Name;
                    case "DataType": return _DataType;
                    case "ServerIP": return _ServerIP;
                    case "Port": return _Port;
                    case "DataBaseName": return _DataBaseName;
                    case "UserName": return _UserName;
                    case "UserPass": return _UserPass;
                    case "ConnectionStrings": return _ConnectionStrings;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "Name": _Name = Convert.ToString(value); break;
                    case "DataType": _DataType = value.ToLong(); break;
                    case "ServerIP": _ServerIP = Convert.ToString(value); break;
                    case "Port": _Port = value.ToLong(); break;
                    case "DataBaseName": _DataBaseName = Convert.ToString(value); break;
                    case "UserName": _UserName = Convert.ToString(value); break;
                    case "UserPass": _UserPass = Convert.ToString(value); break;
                    case "ConnectionStrings": _ConnectionStrings = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得DataBaseConfig字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary></summary>
            public static readonly Field Name = FindByName("Name");

            /// <summary></summary>
            public static readonly Field DataType = FindByName("DataType");

            /// <summary></summary>
            public static readonly Field ServerIP = FindByName("ServerIP");

            /// <summary></summary>
            public static readonly Field Port = FindByName("Port");

            /// <summary></summary>
            public static readonly Field DataBaseName = FindByName("DataBaseName");

            /// <summary></summary>
            public static readonly Field UserName = FindByName("UserName");

            /// <summary></summary>
            public static readonly Field UserPass = FindByName("UserPass");

            /// <summary></summary>
            public static readonly Field ConnectionStrings = FindByName("ConnectionStrings");

            /// <summary></summary>
            public static readonly Field Primary = FindByName("Primary");

            static Field FindByName(String name) => Meta.Table.FindByName(name);
        }

        /// <summary>取得DataBaseConfig字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary></summary>
            public const String Name = "Name";

            /// <summary></summary>
            public const String DataType = "DataType";

            /// <summary></summary>
            public const String ServerIP = "ServerIP";

            /// <summary></summary>
            public const String Port = "Port";

            /// <summary></summary>
            public const String DataBaseName = "DataBaseName";

            /// <summary></summary>
            public const String UserName = "UserName";

            /// <summary></summary>
            public const String UserPass = "UserPass";

            /// <summary></summary>
            public const String ConnectionStrings = "ConnectionStrings";

            /// <summary></summary>
            public const String Primary = "Primary";
        }
        #endregion
    }
}