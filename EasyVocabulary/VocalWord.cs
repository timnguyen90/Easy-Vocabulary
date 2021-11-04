using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace EasyVocabulary
{
    class VocalWord:SqlDataProvider
    {
        //Contructor
        public VocalWord()
        {
            this.ConnectionString = Program.ConnectString;
        }
        #region Variable
        public int Id { get; set; }
        public int IdGroupChild { get; set; }
        public string Vocabulary { get; set; }
        public string Mean { get; set; }
        public string Picture { get; set; }
        public string Audio { get; set; }
        public string Extend { get; set; }
        public string EngMean { get; set; }
        public int Dem { get; set; }
        #endregion
        #region Method
        public DataTable SelectAllVocaWord()
        {
            Sqltr = "select * from VocaWord";
            return Getdatatable();
        }
        public DataTable SelectWordByIdChild(string Id)
        {
            Sqltr = "select * from VocaWord where ID_Group_Child=" + Id;
            return Getdatatable();
        }
        public int Insert()
        {
            Open();
            CommandText = "insert into VocaWord(ID_Group_Child,Vocabulary,Mean,Picture,Audio,Extend,EngMean)values(@ID_Group_Child,@Vocabulary,@Mean,@Picture,@Audio,@Extend,@EngMean)";
            CommandType = CommandType.Text;
            ParameterColection = new string[7] { "@ID_Group_Child", " @Vocabulary", " @Mean", "@Picture", "@Audio", "@Extend", "@EngMean" };
            ValueColection = new object[7] { IdGroupChild,Vocabulary,Mean,Picture,Audio,Extend,EngMean };
            return Execute();
        }
        public int Update()
        {
            CommandText = @"Update VocaWord 
                                Set 
                                    ID_Group_Child = @ID_Group_Child, 
                                    Vocabulary = @Vocabulary,
                                    Mean=@Mean,
                                    EngMean=@EngMean,
                                    Picture=@Picture,
                                    Audio=@Audio,
                                    Extend=@Extend 
                                Where ID=@ID";
            CommandType = CommandType.Text;
            ParameterColection = new string[8] { "@ID_Group_Child", " @Vocabulary", " @Mean","@EngMean", "@Picture", "@Audio", "@Extend", "@ID", };
            ValueColection = new object[8] { IdGroupChild, Vocabulary, Mean,EngMean, Picture, Audio, Extend ,Id};
            return Execute();
        }
        public int UpdateLevel()
        {
            CommandText = @"Update VocaWord  Set Dem = @Dem Where ID = @Id";
            CommandType = CommandType.Text;
            ParameterColection = new string[2] { "@Dem", "@Id"};
            ValueColection = new object[2] {Dem,Id };
            return Execute();
        }
        #endregion
    }
}
