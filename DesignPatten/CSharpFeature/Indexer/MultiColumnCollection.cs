// Administrator
// Joezhouman.DesignPatten
// CSharpFeature
// 2021-03-24-11:10
// *Author*    : Joe, Zhou Man
// *Email*     : man.man.man.man.a@gmail.com
// *Email*     : joe_zhouman@foxmail.com
// *QQ*        : 1592020915
// *Weibo*     : @zhouman_LFC
// *Twitter*   : @zhouman_LFC
// *Website*   : www.joezhouman.com
// *Github*    : https://github.com/Joe-zhouman
// *LeetCode*  : https://leetcode-cn.com/u/joe_zm/

using System.Data;

namespace Joezhouman.DesignPattern.CSharpFeature.Indexer {
    public class MultiColumnCollection {
        public MultiColumnCollection() {
            Data.Tables.Add("Data");
            Data.Tables[0].Columns.Add("name");
            Data.Tables[0].Columns["name"].DataType = typeof(string);
            Data.Tables[0].Columns.Add("gender");
            Data.Tables[0].Columns["gender"].DataType = typeof(string);
        }

        public void AddRow(string name, string gender) {
            Data.Tables[0].Rows.Add(name, gender);
        }
        public static DataSet Data { get; } = new DataSet();
    }
}