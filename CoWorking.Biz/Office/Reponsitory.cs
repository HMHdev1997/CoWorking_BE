using AutoMapper;
using CoWorking.Biz.Model.Office;
using CoWorking.Data.Access;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using CMC.TS.Biz.Helper;

namespace CoWorking.Biz.Office
{
    public class Reponsitory : IReponsitory

    {
        private readonly DomainDbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public Reponsitory(DomainDbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<View> CreateAync(New model)
        {
            var item =  _mapper.Map<New, Data.Model.Office>(model);
             _context.Offices.AddRange(item);
            await _context.SaveChangesAsync();
            return _mapper.Map<Data.Model.Office, View>(item);
        }

        public async Task Delete(int id)
        {
            var item = new Data.Model.Office() { ID = id };
            _context.Offices.RemoveRange(item);
            await _context.SaveChangesAsync();
        }

     

        public async Task<View> GetById(int id)
        {
            var item =await _context.Offices.FirstOrDefaultAsync(x => x.ID == id);
            return _mapper.Map<Data.Model.Office, View>(item);
        }

        public async Task<PagedResult<List>> GetPageAync(int page , int pageSize )
        {
            return await _context.Offices.GetPagedAsync<Data.Model.Office, List>(_mapper, page, pageSize);
        }

        public async Task<List<List>> GetSearch(string search)
        {
            var searchOffice = await _context.Offices.AsQueryable().ToListAsync();
            if (!string.IsNullOrEmpty(search))
            {
                searchOffice.Where(x => x.NameOffice.Contains(search));
            }
            return  _mapper.Map<List<Data.Model.Office>, List<List>>(searchOffice);
        }

        public async Task<View> UpdateAync(Edit model)
        {
            var oldOffice = _context.Offices.Find(model.ID);
            var item = _mapper.Map(model, oldOffice);
            _context.Offices.Update(item);
            await _context.SaveChangesAsync();
            return _mapper.Map<Data.Model.Office, View>(item);


        }


    }
}
