using CSIPJR.Domain.Enums;
using System.Collections.Generic;
namespace CSIPJR.Domain.Class
{
    public interface IExportData<TData>
    {
        //public void ExportToCsv(List<TData> data);
        //public void ExportToXml(List<TData> data);

        //public void ExportToPdf(List<TData> data);

        public void ExportTo(ExportType exportType, List<TData> data);
    }
}
