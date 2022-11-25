using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoWorking.Biz.CategoryOffice
{
    public interface IReponsitory
    {
        Task<Model.CategoryOffice.View> GetById(int id);
        Task<Model.CategoryOffice.View> CreateAync(Model.CategoryOffice.New model);
        Task<Model.CategoryOffice.View> UpdateAync(Model.CategoryOffice.Edit model);
        Task Delete(int id);
    }
}
