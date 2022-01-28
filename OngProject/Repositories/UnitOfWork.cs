﻿using OngProject.DataAccess;
using OngProject.Entities;
using OngProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Constructor and Context
        private readonly AppDbContext _dbContext;
        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion

        #region Repositories
        private readonly IRepository<Activities> _activitiesRepository;
        private readonly IRepository<New> _newsRepository;
        private readonly IRepository<Testimonials> _testimonialsRepository;
        private readonly IRepository<User> _userrepository;
        private readonly IRepository<Member> _memberRepository;
        private readonly IRepository<Organization> _organizationRepository;
        private readonly IRepository<Category> _categoryRepository;
        private readonly IRepository<Rol> _rolRepository;


        public IRepository<Activities> ActivitiesRepository => _activitiesRepository ?? new Repository<Activities>(_dbContext);
        public IRepository<New> NewsRepository => _newsRepository ?? new Repository<New>(_dbContext);
        public IRepository<Testimonials> TestimonialsRepository => _testimonialsRepository ?? new Repository<Testimonials>(_dbContext);
        public IRepository<User> UserRepository => _userrepository ?? new Repository<User>(_dbContext);
        public IRepository<Member> MemberRepository => _memberRepository ?? new Repository<Member>(_dbContext);
        public IRepository<Organization> OrganizationRepository => _organizationRepository ?? new Repository<Organization>(_dbContext);
        public IRepository<Category> CategoryRepository => _categoryRepository ?? new Repository<Category>(_dbContext);
        public IRepository<Rol> RolRepository => _rolRepository ?? new Repository<Rol>(_dbContext);
        #endregion

        #region Methods
        public void Dispose()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }
        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
        #endregion
    }
}
