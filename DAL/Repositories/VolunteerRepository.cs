﻿using DAL.Data;
using DAL.DefaultData;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class VolunteerRepository : IVolunteerRepository
    {
        VolunteerNetServerDBContext _context;

        public VolunteerRepository(VolunteerNetServerDBContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Volunteer entity)
        {
            _context.Volunteers.Add(entity);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(Volunteer entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Volunteer>> GetAllAsync()
        {
            List<Volunteer> volunteers = await _context.Volunteers.Include("User").Include("Application").AsNoTracking().ToListAsync();
            return volunteers;
        }

        public async Task<List<Volunteer>> GetListInProcessingByUserId(Guid userId)
        {
            List<Volunteer> volunteers = await _context.Volunteers.Include("User").Include("Application")
                .Where(x => x.Application.UserId == userId && x.Status == (int)VolunteerStatuses.Status.Processing).AsNoTracking().ToListAsync();
            return volunteers;
        }

        public Task<Volunteer?> GetByIdAsync(Guid id)
        {
            Volunteer? volunteer = _context.Volunteers.AsNoTracking()
                .Where(r => r.Id == id).Include("User").Include("Application").FirstOrDefault();
            return Task.FromResult(volunteer);
        }

        public Task<Volunteer?> GetByUserIdApplicationId(Guid userId, Guid applicationId)
        {
            Volunteer? volunteer = _context.Volunteers.AsNoTracking()
                .Include("User").Include("Application")
                .Where(r => r.UserId == userId && r.ApplicationId == applicationId).FirstOrDefault();
            return Task.FromResult(volunteer);
        }

        public async Task Update(Volunteer entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}