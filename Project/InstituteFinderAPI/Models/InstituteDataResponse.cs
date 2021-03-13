using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//This class contains the properties colleges name, number of courses and status of data set for SET API
namespace InstituteFinderAPI.Models
{
    public class InstituteDataResponse
    {
        //This prorperty used to store institute name
        String CollegeName;

        public String C_Name
        {
            get { return CollegeName; }
            set { CollegeName = value; }
        }

        //This property is used to store Institute Id
        int CollegeID;

        public int c_Id
        {
            get { return CollegeID; }
            set { CollegeID = value; }
        }

        //This property is used to store Institute Address
        String Address;

        public String c_address
        {
            get { return Address; }
            set { Address = value; }
        }

        //This property is used to store Institute City
        String City;

        public String c_city
        {
            get { return City; }
            set { City = value; }
        }

        //This property is used to store Institute Province
        String Province;

        public String c_province
        {
            get { return Province; }
            set { Province = value; }
        }

        //This property is used to store Institute Postal Code
        String PostalCode;

        public String c_postalcode
        {
            get { return PostalCode; }
            set { PostalCode = value; }
        }

        //This property is used to store Institute Contact Details
        String ContactDetails;

        public String c_contact
        {
            get { return ContactDetails; }
            set { ContactDetails = value; }
        }

        //This property is used to store total number of courses for Institute
        String NumOfCourses;

        public String no_courses
        {
            get { return NumOfCourses; }
            set { NumOfCourses = value; }
        }

        //This property is used to store total number of campuses for Institute
        String NumOfCampus;

        public String no_campus
        {
            get { return NumOfCampus; }
            set { NumOfCampus = value; }
        }

        //This property is used to store Course ID
        String CourseID;
        public String courseId
        {
            get { return CourseID; }
            set { CourseID = value; }
        }

        //This property is used to store Course Name
        String CourseName;
        public String courseName
        {
            get { return CourseName; }
            set { CourseName = value; }
        }

        //This property is used to store Institute Name
        String CollgeName;
        public String collegeName
        {
            get { return CollgeName; }
            set { CollgeName = value; }
        }

        //This property is used to store Course Legnth
        String CourseLength;
        public String courseLength
        {
            get { return CourseLength; }
            set { CourseLength = value; }
        }

        //This property is used to store number of leves for Course
        String NumOfLevels;
        public String noOfLevels
        {
            get { return NumOfLevels; }
            set { NumOfLevels = value; }
        }

        //This property is used to store CampusOffering for Course
        String CampusOffering;
        public String campusOffering
        {
            get { return CampusOffering; }
            set { CampusOffering = value; }
        }

        //This property is used to store Institute DLI number
        String DLINumber;
        public String dliNumber
        {
            get { return DLINumber; }
            set { DLINumber = value; }
        }

        //This prorperty used to store status of data
        string status;

        public String Status
        {
            get { return status; }
            set { status = value; }
        }

    }

}