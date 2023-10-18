using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*using Npgsql;
*/namespace TASK_APP
{
    public class DB
    {
        /*        public static string DBLocation = "postgresql://noor:R73vJ5uuGrizBoN7a6e3Nw@taskappcluster-10547.8nj.cockroachlabs.cloud:26257/task_app_database?sslmode=verify-full";
        */
        public static string DBLocation = "Host=taskappcluster-10547.8nj.cockroachlabs.cloud;Port=26257;Database=task_app_database;Username=noor;Password=R73vJ5uuGrizBoN7a6e3Nw;SSL Mode=VerifyFull";

    }
}
