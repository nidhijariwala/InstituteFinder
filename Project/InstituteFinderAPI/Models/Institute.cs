using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//This class contains all the properties for the institues
namespace InstituteFinderAPI.Models
{
    public class Institute
    {
        //This prorperty used to store institute name
        String i_name;

        public String I_Name
        {
            get { return i_name; }
            set { i_name = value; }
        }

        //This property is used to store the total number of courses in institute
        int i_course;

        public int I_Course
        {
            get { return i_course; }
            set { i_course = value; }
        }


    }
}