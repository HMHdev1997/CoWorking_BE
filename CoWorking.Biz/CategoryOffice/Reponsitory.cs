using AutoMapper;
using CoWorking.Biz.Model.CategoryOffice;
using CoWorking.Data.Access;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoWorking.Biz.CategoryOffice
{
    public class Reponsitory :IReponsitory
    {
        private readonly DomainDbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public Reponsitory (DomainDbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<View> CreateAync(New model)
        {
            var item = _mapper.Map<New, Data.Model.CategoryOffice>(model);
            await _context.CategoryOffices.AddAsync(item);
            await _context.SaveChangesAsync();
            return _mapper.Map<Data.Model.CategoryOffice, View>(item);
        }

        public async Task Delete(int id)
        {
            var item =new Data.Model.CategoryOffice() { ID = id };
            _context.CategoryOffices.RemoveRange(item);
            await _context.SaveChangesAsync();
        }

        public async Task<View> GetById(int id)
        {
            Data.Model.CategoryOffice Category = await _context.CategoryOffices.FirstOrDefaultAsync(p => p.ID == id);
            return _mapper.Map<Data.Model.CategoryOffice, View>(Category);
        }

        public async Task<View> UpdateAync(Edit model)
        {
            var oldCategory = _context.CategoryOffices.Find(model.ID);
            var item = _mapper.Map( model , oldCategory);
            _context.CategoryOffices.Update(item);
            await _context.SaveChangesAsync();
            return _mapper.Map<Data.Model.CategoryOffice, View>(item);
        }
    }
}
