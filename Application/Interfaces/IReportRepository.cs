namespace Application.Interfaces
{
    public interface IReportRepository
    {
        byte[] GenerateReportAsync(string reportName);
    }
}