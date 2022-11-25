using CMC.TS.Biz.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoWorking.Biz.Office
{
    public interface IReponsitory
    {
        Task<PagedResult<Model.Office.List>> GetPageAync(int page, int pageSize);
        Task<Model.Office.View> GetById(int id);
        Task<Model.Office.View> CreateAync(Model.Office.New model);
        Task<Model.Office.View> UpdateAync(Model.Office.Edit model);
        Task Delete(int id);
        Task<List<Model.Office.List>> GetSearch(string search);
    }
}
