using EFInheritance.MSSQL;
using EFInheritance.PostgresSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /**************************MS SQL*********************************
             Please use below code to test the inheritance in ef models
             */

            //SqlRepository repoGetStudents = new SqlRepository();
            //var sqlStudents = repoGetStudents.getData();

            //SqlRepository repoInsertStudents = new SqlRepository();
            //repoInsertStudents.insertData();


            //*************************************************************//


            /***************************POSTGRES SQL********************************
            
            */

            //PGRepository repoGetStudents = new PGRepository();
            //var sqlStudents = repoGetStudents.getData();

            //PGRepository repoInsertStudents = new PGRepository();
            //repoInsertStudents.insertData();


            //*************************************************************//



        }
    }
}
