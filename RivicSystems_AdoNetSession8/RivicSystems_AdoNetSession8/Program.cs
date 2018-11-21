using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RivicSystems_AdoNetSession8
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestConnection();
            //TestConnectionUsing();
            //TestSqlCommands();
            //TestSqlDataAdapter();
            
            TestSqlDataAdapterUpdateData(Convert.ToInt32(args[0]),args[1],args[2]);

        }

        private static void TestSqlDataAdapterUpdateData(int id, string name,string address)
        {
            string ConnString = "Server=(local);database=RivicTrainingDemo;UID=RivicDemo;Password=Password1; integrated security=SSPI";
            //Step1. - Open Connection
            SqlConnection con = new SqlConnection(ConnString);
            try
            {
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from student", con);
                string strupdateCommand = "Update Student set StudentName = @pName, StudentAddress=@pAddress where studentId = @pId";

                SqlCommand sqlUpdateCommand = new SqlCommand(strupdateCommand, con);

                SqlParameter param1 = new SqlParameter("@pName", SqlDbType.NVarChar, 50, "StudentName");
                param1.Value = name;
                sqlUpdateCommand.Parameters.Add(param1);


                SqlParameter param2 = new SqlParameter("@pAddress", SqlDbType.NVarChar, 100, "StudentAddress");
                param2.Value = address;
                sqlUpdateCommand.Parameters.Add(param2);

                SqlParameter param3 = new SqlParameter("@pId", SqlDbType.Int, 0, "StudentId");
                param3.Value = id;
                sqlUpdateCommand.Parameters.Add(param3);

                dataAdapter.UpdateCommand = sqlUpdateCommand;
                int count = dataAdapter.UpdateCommand.ExecuteNonQuery();
                Console.WriteLine("Records {0} Updated", count);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }
            finally
            {

                con.Close();
                Console.ReadLine();
            }



        }

        private static void TestSqlDataAdapter()
        {
            string ConnString = "Server=(local);database=RivicTrainingDemo;UID=RivicDemo;Password=Password1; integrated security=SSPI";
            //Step1. - Open Connection
            SqlConnection con = new SqlConnection(ConnString);
            try
            {
                con.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from student", con);
                DataSet ds = new DataSet();

                dataAdapter.Fill(ds);

                DataRow dr = ds.Tables[0].NewRow();
                dr["StudentId"] = 106;
                dr["StudentName"] = "Ramesh";
                dr["StudentAddress"] = "ABCStreet";
                ds.Tables[0].Rows.Add(dr);
              

              
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(ds);

                Console.WriteLine("New Record Added");
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error");
            }
            finally
            {
                
                con.Close();
                Console.ReadLine();
            }

            

        }

        private static void TestSqlCommands()
        {
            string ConnString = ConfigurationManager.ConnectionStrings["RivicDBConnString"].ConnectionString;
            //Step1. - Open Connection

            using (SqlConnection con = new SqlConnection(ConnString))
            {
                //Step2.
                SqlCommand cmd = new SqlCommand("select count(*) from student", con);

                //Step3.
                con.Open();

                int val = (int)cmd.ExecuteScalar();
                Console.WriteLine("Count : {0}", val);

                SqlCommand cmd1 = new SqlCommand("INSERT INTO STUDENT VALUES(105,'Sachin','Oklahama')", con);
                int recordsAffected = cmd1.ExecuteNonQuery();
                Console.WriteLine("Records Inserted : {0}", recordsAffected);


            }

            Console.ReadLine();
        }

        private static void TestConnection()
        {
            string ConnString = "Server=(local);database=RivicTrainingDemo;UID=RivicDemo;Password=Password1; integrated security=SSPI";
            //Step1. - Open Connection
            SqlConnection con = new SqlConnection(ConnString);

            try
            {
                //Step2.
                SqlCommand cmd = new SqlCommand("select * from student", con);

                //Step3.
                con.Open();

                //step4
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr.GetInt32(0));
                    Console.WriteLine(rdr.GetString(1));
                }

                //rdr.NextResult()
            }

            catch(Exception ex)
            {
                Console.WriteLine("Exception while connecting to database");
            }

            finally
            {
                con.Close();
            }

            Console.ReadLine();

           

        }

        private static void TestConnectionUsing()
        {
            string ConnString = ConfigurationManager.ConnectionStrings["RivicDBConnString"].ConnectionString;
            //Step1. - Open Connection

            using (SqlConnection con = new SqlConnection(ConnString))
            {
                //Step2.
                SqlCommand cmd = new SqlCommand("select * from student", con);

                //Step3.
                con.Open();

                //step4
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr.GetInt32(0));
                    Console.WriteLine(rdr.GetString(1));
                }
            }
            Console.ReadLine();
            
        }

    }
}
