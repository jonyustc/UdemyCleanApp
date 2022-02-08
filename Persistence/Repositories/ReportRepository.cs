using System.Reflection;
using System.Text;
using Application.Interfaces;
using AspNetCore.Reporting;

namespace Persistence.Repositories
{
    public class ReportRepository : IReportRepository
    {
        public byte[] GenerateReportAsync(string reportName)
        {
            //string fileDirPath = Assembly.GetExecutingAssembly().Location.Replace("ReportViewer.dll", string.Empty);
            string fileDirPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string rdlcFilePath = string.Format("{0}\\ReportFiles\\{1}.rdlc", fileDirPath, reportName);
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding.GetEncoding("windows-1252");
            LocalReport report = new LocalReport(rdlcFilePath);

            List<ReportUserDto> userList = new List<ReportUserDto>();
            userList.Add(new ReportUserDto
            {
               FirstName = "Alex",
               LastName = "Smith",
               Email = "alex.smith@gmail.com",
            });

            //userList.Add(new ReportUserDto
            //{
            //    FirstName = "John",
            //    LastName = "Legend",
            //    Email = "john.legend@gmail.com",
            //    Phone = "5633435334"
            //});

            //userList.Add(new ReportUserDto
            //{
            //    FirstName = "Stuart",
            //    LastName = "Jones",
            //    Email = "stuart.jones@gmail.com",
            //    Phone = "3575328535"
            //});

           // var data = userList.Where(x => x.Id == id);

            

           
            

            report.AddDataSource("DataSet1", userList);
            
           



            var result = report.Execute(GetRenderType("pdf"),1);
            
            return result.MainStream;
        }

        private RenderType GetRenderType(string reportType)
        {
            var renderType = RenderType.Pdf;
            switch (reportType.ToLower())
            {
                default:
                case "pdf":
                    renderType = RenderType.Pdf;
                    break;
                case "word":
                    renderType = RenderType.Word;
                    break;
                case "excel":
                    renderType = RenderType.Excel;
                    break;
            }

            return renderType;
        }

        public class ReportUserDto
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
        }
    }
}