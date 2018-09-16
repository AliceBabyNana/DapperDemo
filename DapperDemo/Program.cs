using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace DapperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "server=.;database=student;uid=sa;pwd=alicebaby1997;";

            IDbConnection conn = new SqlConnection(connStr);
            #region 增加
            //string sql = "INSERT INTO STUDENTINFO(NAME,AGE,SEX)VALUES(@NAME,@AGE,@SEX);";

            // int i = conn.Execute(sql, new StudentInfo { Name = "小王5", Age = 22, Sex = 'm' });
            // int b = conn.Execute(sql, new StudentInfo { Name = "小王6", Age = 33, Sex = 'f' });
            //var t=   conn.ExecuteAsync(sql, new StudentInfo { Name = "小王19", Age = 55, Sex = 'm' });

            // Console.WriteLine(i + "行受影响");
            // Console.WriteLine(b + "行受影响");
            #endregion

            #region 查询
            //string sql = "SELECT ID,NAME,AGE,SEX FROM STUDENTINFO WHERE ID=@Id;";
            // var stuList = conn.Query<StudentInfo>(sql, new { Id = 1 }).FirstOrDefault(); ;


            #endregion

            #region 更新
            //string sql = "UPDATE STUDENTINFO SET NAME=@Name,AGE=@Age,SEX=@Sex where ID=@Id";
            //conn.Execute(sql, new { Id = 5, Name = "小红", Age = 12, Sex = 'm' });
            #endregion

            #region 删除
            //string sql = "DELETE FROM STuDENTINFO WHERE ID=@Id";
            //conn.Execute(sql, new { Id = 2 });
            #endregion


            Console.WriteLine("ok");
            Console.ReadKey();
        }
    }

    class StudentInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public char Sex { get; set; }
    }
}
