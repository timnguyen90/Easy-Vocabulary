using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace EasyVocabulary
{
    class GroupMain:SqlDataProvider
    {
        //Destructor
        public GroupMain()
        {
            this.ConnectionString = Program.ConnectString;
        }
        #region Variable
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdUser { get; set; }
        #endregion
        #region Method
        public int Insert()
        {
             Open();
            CommandText = "insert into Group_Main(Name,IdUser)values(@Name, @IdUser)";
            CommandType = CommandType.Text;
            ParameterColection = new string[2] { "@Name", "@IdUser" };
            ValueColection = new object[2] { Name, IdUser };
            return Execute();
        }
        public int Update()
        {
            CommandText = "Update Group_Main set Name = @Name, IdUser = @IdUser where Id = @Id";
            CommandType = CommandType.Text;
            ParameterColection = new string[3] { "@Name", "@IdUser", "@Id"};
            ValueColection = new object[3] {Name,IdUser,Id};
            return Execute();
        }
        public DataTable SelectAllGroupMain()
        {
            Sqltr = "select * from Group_Main";
            return Getdatatable();
        }
        #endregion
    }
   
}
