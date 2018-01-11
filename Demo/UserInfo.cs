﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiClient;

namespace Demo
{
    public class UserInfo
    {
        public string Account { get; set; }

        public string Password { get; set; }

        [DateTimeFormat("yyyy-MM-dd")]
        public DateTime? BirthDay { get; set; }

        public override string ToString()
        {
            return string.Format("{{Account:{0}, Password:{1}, BirthDay:{2}}}", this.Account, this.Password, this.BirthDay);
        }
    }
}
