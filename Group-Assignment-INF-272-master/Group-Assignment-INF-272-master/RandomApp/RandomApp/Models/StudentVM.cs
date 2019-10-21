using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RandomApp.Models
{
    public class StudentVM
    {

        public int? Id;
        public List<STUDENT> students;
        public UserVM UserViewModel;
    }
}