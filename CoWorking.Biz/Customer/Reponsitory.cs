using AutoMapper;
using CoWorking.Biz.Model.Customer;
using CoWorking.Data.Access;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoWorking.Biz.Customer
{
    public class Reponsitory : IReponsitory
    {
        private readonly IMapper _mapper;
        private readonly DomainDbContext _context;
        private readonly IConfiguration _configuration;

        public Reponsitory(IMapper mapper, DomainDbContext context, IConfiguration configuration)
        {
            _mapper = mapper;
            _context = context;
            _configuration = configuration;
        }

        public async Task<View> CreateAync(New model)
        {
            var Item = _mapper.Map<New,Data.Model.Customer >(model);
            await _context.Customers.AddAsync(Item);
            await  _context.SaveChangesAsync();
            return _mapper.Map<Data.Model.Customer, View>(Item);
        }

        public Task<View> UpdateAync(Edit model)
        {
            throw new NotImplementedException();
        }
    }
}
