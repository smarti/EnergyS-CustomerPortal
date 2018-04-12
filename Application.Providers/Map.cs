using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Application.ViewModels;

namespace Application.Providers
{
    public static class Map
    {
        public static ReportViewModel ReportModelToReportViewModel(ReportModel reportModel)
        {
            ReportViewModel convertedReportModel = new ReportViewModel
            {
                Description = reportModel.Description,
                DescriptionStatus = reportModel.DescriptionStatus,
                LastUpdate = reportModel.LastUpdate
            };

            return convertedReportModel;
        }

        public static CustomerModel CustomerViewModelToCustomerModel(CustomerViewModel customer)
        {
            throw new NotImplementedException();
        }
    }
}
