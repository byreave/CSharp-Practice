using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace StaffManager
{
    public class UserInfo
    {
        public static DataSet getUserInfo()
        {
            string sql = "SELECT ID, Name, Gender, DepartmentID, Class, Birthday FROM user";
            return dbHelper.GetDataSet(sql);
        }

        public static void addStaff(string n, string gen, string dID, string cl, string bir)
        {
            string sql = "INSERT INTO user (Name, Gender, DepartmentID, Class, Birthday) VALUES ('"+n+"', '"+gen+"', '"+dID+"', '"+cl+"', '"+bir+"')";
            dbHelper.ExecuteCommand(sql);
        }

        public static void deleteStaff(string id)
        {
            string sql = "DELETE FROM user WHERE ID = '" + id + "'";
            dbHelper.ExecuteCommand(sql);
        }

        public static void editStaff(string id, string n, string gen, string dID, string cl, string bir)
        {
            string sql = "UPDATE user SET Name = '" + n + "', Gender = '" + gen + "', DepartmentID = " + dID + ", Class = '" + cl + "', Birthday = '" + bir + "' WHERE ID = "+id+"";
            dbHelper.ExecuteCommand(sql);
        }

        public static DataSet getDataBySearch(string str, string type)
        {
            string sql = "";
            switch(type)
            {
                case "Name":
                    sql = "SELECT ID, Name, Gender, DepartmentID, Class, Birthday FROM user WHERE Name LIKE '%"+str+"%'";
                    break;
                case "Department":
                    string d_sql = "SELECT DepartmentID FROM department WHERE Name = '" + str + "'";
                    sql = "SELECT ID, Name, Gender, DepartmentID, Class, Birthday FROM user WHERE DepartmentID in (" + d_sql + ")";
                    break;
                default:
                    break;
            }
            return dbHelper.GetDataSet(sql);
        }

        public static DataSet getDepartmentInfo()
        {
            string sql = "SELECT * FROM department";
            return dbHelper.GetDataSet(sql);
        }
    }
}
