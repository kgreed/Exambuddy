namespace Exambuddy2.Module.BusinessObjects.NonPersistent
{
    public interface IReportResult
    {
        object DataSource(object[] paramObjects);

        // List<SPReportParameter> ParameterPrompts { get; }
    }
}