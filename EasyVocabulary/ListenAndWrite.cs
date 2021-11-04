using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace EasyVocabulary
{
    class ListenAndWrite:SqlDataProvider
    {
        public ListenAndWrite() {
            this.ConnectionString = Program.ConnectString;
        }
        
        #region Variable
        public int Id { get; set; }
        public string Name { get; set; }
        public string Transcript { get; set; }
        public string Translate { get; set; }
        public string Video { get; set; }
        #endregion
        
        #region Method
       
        public DataTable SelectAll()
        {
            Sqltr = "select * from ListenAndWrite";
            return Getdatatable();
        }
        
        public int Insert()
        {
            Open();
            CommandText = "Insert into ListenAndWrite([Name],[TranScript],[Translate],[Video])values(@Name,@TranScript,@Translate,@Video)";
            CommandType = CommandType.Text;
            ParameterColection = new string[4] {"@Name", "@TranScript", "@Translate", "@Video", };
            ValueColection = new object[4] {Name,Transcript,Translate,Video};
            return Execute();
        }

        public int Update()
        {
            CommandText = @"Update ListenAndWrite 
                                Set 
                                    Name=@Name,
                                    TranScript-@TranScript,
                                    Translate=@Translate,
                                    Video=@Video
                                Where ID=@ID";
            CommandType = CommandType.Text;
            ParameterColection = new string[5] { "@Name", "@TranScript", "@Translate", "@Video","@ID"};
            ValueColection = new object[5] {Name,Transcript,Translate ,Video,Id };
            return Execute();
        }
        #endregion
    }
}
