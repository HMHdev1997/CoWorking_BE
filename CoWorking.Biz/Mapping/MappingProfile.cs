using AutoMapper;

namespace CoWorking.Biz.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Data.Model.CategoryOffice, Model.CategoryOffice.Edit>().ReverseMap();
            CreateMap<Data.Model.CategoryOffice, Model.CategoryOffice.List>().ReverseMap();
            CreateMap<Data.Model.CategoryOffice, Model.CategoryOffice.New>().ReverseMap();
            CreateMap<Data.Model.CategoryOffice, Model.CategoryOffice.View>().ReverseMap();

            CreateMap<Data.Model.Office, Model.Office.View>().ReverseMap();
            CreateMap<Data.Model.Office, Model.Office.List>().ReverseMap();
            CreateMap<Data.Model.Office, Model.Office.New>().ReverseMap();
            CreateMap<Data.Model.Office, Model.Office.Edit>().ReverseMap();

            CreateMap<Data.Model.Area, Model.Area.New>().ReverseMap();
            CreateMap<Data.Model.Area, Model.Area.View>().ReverseMap();

            CreateMap<Data.Model.Customer, Model.Customer.New>().ReverseMap();
            CreateMap<Data.Model.Customer, Model.Customer.View>().ReverseMap();
            CreateMap<Data.Model.Customer, Model.Customer.Edit>().ReverseMap();
        }
    }
}