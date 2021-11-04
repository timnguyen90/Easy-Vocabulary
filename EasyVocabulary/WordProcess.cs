using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace EasyVocabulary
{
    class WordProcess:SqlDataProvider
    {
        //Constructor
        public WordProcess()
        {
            this.ConnectionString = Program.ConnectString;
        }
        #region Method
        public DataTable SelectAllByIdChild(string Id)
        {
            Sqltr = "select * from VocaWord where ID_Group_Child=" + Id + " ORDER BY Dem DESC";
            return Getdatatable();
        }
        public DataTable GetGroupWord(string Id="1")
        {
            Sqltr = "select Group_Main.Id as IdMain,Group_Main.Name as NameMain,Group_Child.Id as IdChild,Group_Child.Name as NameChild from Group_Main,Group_Child where Group_Main.Id=Group_Child.ID_Group_Man and Group_Main.ID =" + Id;
            return Getdatatable();
        }
        #endregion
    }
}
