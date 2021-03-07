using InstituteFinderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//This class will set the value for college name and number of courses 
namespace InstituteFinderAPI.Controllers
{
    public class InstituteResponseController : ApiController
    {
        public InstituteDataResponse AddInstitute(Institute objinst)
        {
             InstituteDataResponse instdataresp = new InstituteDataResponse();
            InstituteData.getInstance().Add(objinst);
            instdataresp.C_Name = objinst.C_Name;
            instdataresp.c_Id = objinst.c_Id;
            instdataresp.DLI_No = objinst.DLI_No;
            instdataresp.c_address = objinst.c_address;
            instdataresp.c_city = objinst.c_city;
            instdataresp.c_province = objinst.c_province;
            instdataresp.c_postalcode = objinst.c_province;
            instdataresp.c_contact = objinst.c_contact;
            instdataresp.no_courses = objinst.no_courses;
            instdataresp.no_campus = objinst.no_campus;
            instdataresp.Status = "Sucess";
            return instdataresp;
        }
    }
}
