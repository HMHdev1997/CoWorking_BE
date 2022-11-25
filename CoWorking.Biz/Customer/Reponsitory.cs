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

        public Task<View> CreateAync(New model)
        {
            throw new NotImplementedException();
        }

        public Task<View> UpdateAync(Edit model)
        {
            throw new NotImplementedException();
        }
    }
}
