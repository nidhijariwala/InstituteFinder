using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//This class contains the list of properties from Institue class to GET API
namespace InstituteFinderAPI.Models
{
    public class InstituteData
    {
        List<Institute> InstituteList;
        static InstituteData idata = null;

        private InstituteData()
        {
            InstituteList = new List<Institute>();
        }

        public static InstituteData getInstance()
        {
            if (idata == null)
            {
                idata = new InstituteData();
                return idata;
            }
            else
            {
                return idata;
            }
        }

        public void Add(Institute objei)
        {
            InstituteList.Add(objei);
        }

        

        public List<Institute> getAllInstituteData()
        {
            return InstituteList;
        }

        #region Refernce method for update and delete data for Institute

        //public String Remove(String registrationNumber)
        //{
        //    for (int i = 0; i < studentList.Count; i++)
        //    {
        //        Student stdn = studentList.ElementAt(i);
        //        if (stdn.RegistrationNumber.Equals(registrationNumber))
        //        {
        //            studentList.RemoveAt(i);//update the new record
        //            return "Delete successful";
        //        }
        //    }

        //    return "Delete un-successful";
        //}

        //public String UpdateStudent(Student std)
        //{
        //    for (int i = 0; i < studentList.Count; i++)
        //    {
        //        Student stdn = studentList.ElementAt(i);
        //        if (stdn.RegistrationNumber.Equals(std.RegistrationNumber))
        //        {
        //            studentList[i] = std;//update the new record
        //            return "Update successful";
        //        }
        //    }

        //    return "Update un-successful";
        //}

        #endregion
    }
}