﻿using MyEverNote.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyEverNote.Common.Init
{
   public class WebCommon:ICommon
    {
        public string GetCurrentUserName()
        {
            if (HttpContext.Current.Session["Login"]!=null)
            {
                EverNoteUser user = HttpContext.Current.Session["logim"] as EverNoteUser;
                return user.Username;
            }
            return "system";
        }
    }
}
