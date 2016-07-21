using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalInformationSystem
{
    public class Utility
    {
        public static IEnumerable<SelectListItem> GetGender()
        {
            return new SelectList(new[]
            {

                new {Id="1",Value="Male"},
                new {Id="2",Value="Female"},
                


            }, "value", "Value");
        }
    }
}