using InstituteFinderAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using static System.Net.Mime.MediaTypeNames;

//This class will connect with database and make call to insert the data in database
namespace InstituteFinderAPI.Views.Database
{
    public class Database
    {
            public void connectDB(List<Institute> data)
            {
                try
                {

                    SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=InstituteFinderDB;Integrated Security=True");
                    conn.Open();

                    string stmt = "INSERT INTO College (CollegeID, CollegeName, DLINumber, Address, City, Province, PostalCode, ContactDetails, NumOfCourses, NumOfCampus) VALUES ( @CollegeID, @CollegeName, @DLINumber, @Address, @City, @Province, @PostalCode, @ContactDetails, @NumOfCourses, @NumOfCampus)";
       
                    SqlCommand cmd = new SqlCommand(stmt, conn);

                    cmd.Parameters.Add("@CollegeID", SqlDbType.Int);
                    cmd.Parameters["@CollegeID"].Value = 1;

                    cmd.Parameters.Add("@CollegeName", SqlDbType.VarChar);
                    cmd.Parameters["@CollegeName"].Value =  data[0].collegeName;

                    cmd.Parameters.Add("@DLINumber", SqlDbType.VarChar);
                    cmd.Parameters["@DLINumber"].Value = data[0].dliNumber;

                    cmd.Parameters.Add("@Address", SqlDbType.VarChar);
                    cmd.Parameters["@Address"].Value = data[0].c_address;

                    cmd.Parameters.Add("@City", SqlDbType.VarChar);
                    cmd.Parameters["@City"].Value = data[0].c_city;

                    cmd.Parameters.Add("@Province", SqlDbType.VarChar);
                    cmd.Parameters["@Province"].Value = data[0].c_province;

                    cmd.Parameters.Add("@PostalCode", SqlDbType.VarChar);
                    cmd.Parameters["@PostalCode"].Value = data[0].c_postalcode;

                    cmd.Parameters.Add("@ContactDetails", SqlDbType.VarChar);
                    cmd.Parameters["@ContactDetails"].Value = data[0].c_contact;

                    cmd.Parameters.Add("@NumOfCourses", SqlDbType.Int);
                    cmd.Parameters["@NumOfCourses"].Value = Convert.ToInt32(data[0].no_courses);

                    cmd.Parameters.Add("@NumOfCampus", SqlDbType.Int);
                    cmd.Parameters["@NumOfCampus"].Value = Convert.ToInt32(data[0].no_campus);
                 

                    cmd.ExecuteNonQuery();

                    stmt = "INSERT INTO Courses (CourseID , CourseName ,  CollegeName , CourseLength, NumofLevels, CampusOffering, DLINumber) VALUES ( @CourseID, @CourseName, @CollegeName, @CourseLength, @NumofLevels, @CampusOffering, @DLINumber)";

                    cmd = new SqlCommand(stmt, conn);

                    cmd.Parameters.Add("@CourseID", SqlDbType.Int);
                    cmd.Parameters["@CourseID"].Value = Convert.ToInt32(data[0].courseId);

                    cmd.Parameters.Add("@CourseName", SqlDbType.VarChar);
                    cmd.Parameters["@CourseName"].Value = data[0].courseName;

                    cmd.Parameters.Add("@CollegeName", SqlDbType.VarChar);
                    cmd.Parameters["@CollegeName"].Value = data[0].collegeName;

                    cmd.Parameters.Add("@CourseLength", SqlDbType.VarChar);
                    cmd.Parameters["@CourseLength"].Value = data[0].courseLength;

                    cmd.Parameters.Add("@NumofLevels", SqlDbType.VarChar);
                    cmd.Parameters["@NumofLevels"].Value = data[0].noOfLevels;

                    cmd.Parameters.Add("@CampusOffering", SqlDbType.VarChar);
                    cmd.Parameters["@CampusOffering"].Value = data[0].campusOffering;

                    cmd.Parameters.Add("@DLINumber", SqlDbType.VarChar);
                    cmd.Parameters["@DLINumber"].Value = data[0].dliNumber;


                cmd.ExecuteNonQuery();


                conn.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
    }
}