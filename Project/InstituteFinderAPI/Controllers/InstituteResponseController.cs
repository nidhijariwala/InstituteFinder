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
            instdataresp.I_Name = objinst.I_Name;
            instdataresp.I_Course = objinst.I_Course;
            instdataresp.Status = "Sucess";
            return instdataresp;
        }
    }
}
