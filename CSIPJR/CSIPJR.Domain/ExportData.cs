using CSIPJR.Domain.Class;
using CSIPJR.Domain.Enums;
using System.Runtime.Intrinsics.Arm;

namespace CSIPJR.Domain
{
    public class ExportData<TData> : IExportData<TData> 

    {
        private List<TData> data;

        public ExportData()
        {
            this.data = new List<TData>();
        }

        public void ExportTo(ExportType exportType, List<TData> data)
        {
            switch (exportType)
            {
                case ExportType.Pdf:
                    break;
                case ExportType.Csv:
                    break;
                case ExportType.Xml:
                    break;

                default:
                    break;
            }
        }


        //public void ExportToCsv(List<TData> data)
        //{
        //    throw new NotImplementedException();
        //}

        //public void ExportToPdf(List<TData> data)
        //{
        //    throw new NotImplementedException();
        //}

        //public void ExportToXml(List<TData> data)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
