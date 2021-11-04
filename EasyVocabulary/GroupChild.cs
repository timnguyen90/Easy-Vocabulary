using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace EasyVocabulary
{
    class GroupChild:SqlDataProvider
    {
        //Contructor
        public GroupChild()
        {
            this.ConnectionString = Program.ConnectString;
        }
        #region Variable
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdGroupMain { get; set; }
        #endregion
        #region Method
        public int Insert()
        {
            Open();
            CommandText = "insert into Group_Child(Name,ID_Group_Man)values(@Name, @ID_Group_Man)";
            CommandType = CommandType.Text;
            ParameterColection = new string[2] { "@Name", "@ID_Group_Man" };
            ValueColection = new object[2] { Name, IdGroupMain };
            return Execute();
        }
        public int Update()
        {
            CommandText = "Update Group_Child set Name = @Name, ID_Group_Man = @ID_Group_Man where Id = @Id";
            CommandType = CommandType.Text;
            ParameterColection = new string[3] { "@Name", "@ID_Group_Man", "@Id" };
            ValueColection = new object[3] { Name, IdGroupMain, Id };
            return Execute();
        }
        public DataTable SelectAllGroupChild()
        {
            Sqltr = "select * from Group_Child";
            return Getdatatable();
        }
        public DataTable SelectAllGroupChildByIdMain(int Id)
        {
            Sqltr = "select * from Group_Child where ID_Group_Man=" + Id.ToString() ;
            return Getdatatable();
        }
        #endregion

    }
}
