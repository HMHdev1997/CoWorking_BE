using AutoMapper;
using CoWorking.Biz.CategoryOffice;
using CoWorking.Data.Access;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoWorking.Biz
{
    public class ReponsitoryWapper : IReponsitoryWapper
    {
        private readonly DomainDbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public ReponsitoryWapper (DomainDbContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        private CategoryOffice.IReponsitory _categoryOffice;
        public CategoryOffice.IReponsitory CategoryOffice => _categoryOffice ??= new CategoryOffice.Reponsitory(_context,_mapper,_configuration) ;

        private Office.IReponsitory _office;
        public Office.IReponsitory Office => _office ??= new Office.Reponsitory(_context, _mapper, _configuration);

        private Area.IReponsitory _area;
        public Area.IReponsitory Area => _area ??= new Area.Reponsitory(_context, _mapper, _configuration);

        private Customer.IReponsitory _customer;
        public Customer.IReponsitory Customer => _customer??= new Customer.Reponsitory(_mapper, _context, _configuration);
    }
}
