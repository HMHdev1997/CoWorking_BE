using System;
using System.Collections.Generic;
using System.Text;

namespace CoWorking.Biz
{
    public interface IReponsitoryWapper
    {
        CategoryOffice.IReponsitory CategoryOffice { get; }
        Office.IReponsitory Office { get; }
        Area.IReponsitory Area { get; }
        Customer.IReponsitory Customer { get; }
    }
}
