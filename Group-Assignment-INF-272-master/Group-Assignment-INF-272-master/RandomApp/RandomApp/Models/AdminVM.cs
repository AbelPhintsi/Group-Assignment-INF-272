using RandomApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RandomApp.Models
{
    public class AdminVM
    {
        public int? Id;
        public List<ADMINISTRATOR> administrators;
        public UserVM UserViewModel;

    }
}