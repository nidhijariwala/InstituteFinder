using InstituteFinderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InstituteFinderAPI.Controllers
{
    //GET api/Institute List
    public class InstituteController : ApiController
    {
        public List<Institute> GetAllStudents()
        {
            return InstituteData.getInstance().getAllInstituteData();
        }
    }
}
