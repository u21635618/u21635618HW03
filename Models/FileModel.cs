﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace u21635618HW03.Models
{
    public class FileModel
    {
    
        [Display(Name = "File Name")]
        public string FileName { get; set; }
        
        [Display(Name = "Browse File")]
        public HttpPostedFileBase[] Files { get; set; }
    }
}