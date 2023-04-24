﻿using BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IVolunteerService : IService<VolunteerModel>
    {
        Task<List<ValidationResult>> AddAsync(Guid userId, VolunteerCreationModel model);

        Task<List<ValidationResult>> AcceptVolunteer(Guid userId, Guid volunteerId);

        Task<IEnumerable<VolunteerViewModel>> GetAllAsync(string language);

        Task<IEnumerable<VolunteerViewModel>> GetListInProcessingByUserId(Guid userId, string language);

        Task<List<ValidationResult>> RejectVolunteer(Guid userId, Guid volunteerId);
    }
}
