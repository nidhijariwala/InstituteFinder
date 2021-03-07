using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//This class contains all the properties for get the institute name and number of courses
namespace InstituteFinderAPI.Models
{
    public class Institute
    {
        //This prorperty used to store institute name
        String collegeName;

        public String C_Name
        {
            get { return collegeName; }
            set { collegeName = value; }
        }

        //This property is used to store the total number of courses in institute
        int collegeId;

        public int c_Id
        {
            get { return collegeId; }
            set { collegeId = value; }
        }

        String DLINo;

        public String DLI_No
        {
            get { return DLINo; }
            set { DLINo = value; }
        }


        String collegeAdress;

        public String c_address
        {
            get { return collegeAdress; }
            set { collegeAdress = value; }
        }

        String collegeCity;

        public String c_city
        {
            get { return collegeCity; }
            set { collegeCity = value; }
        }

        String collegeProvince;

        public String c_province
        {
            get { return collegeProvince; }
            set { collegeProvince = value; }
        }

        String collegePostalCode;

        public String c_postalcode
        {
            get { return collegePostalCode; }
            set { collegePostalCode = value; }
        }

        String collegeContact;

        public String c_contact
        {
            get { return collegeContact; }
            set { collegeContact = value; }
        }

        String noOfCourses;

        public String no_courses
        {
            get { return noOfCourses; }
            set { noOfCourses = value; }
        }

        String noOfCampus;

        public String no_campus
        {
            get { return noOfCampus; }
            set { noOfCampus = value; }
        }
    }
}