using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoWorking.Biz.Customer
{
    public interface IReponsitory
    {
        Task<Model.Customer.View> CreateAync(Model.Customer.New model);
        Task<Model.Customer.View> UpdateAync(Model.Customer.Edit model);

    }
}
