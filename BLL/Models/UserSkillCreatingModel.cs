﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class UserSkillCreatingModel
    {
        public Guid SkillId { get; set; }

        public IFormFile? Document { get; set; }
    }
}
