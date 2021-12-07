namespace EmployManamegent.Common.ResultModels
{
   public interface IResult
    {
         bool IsSucces { get; set; }
         string Message { get; set; }
    }
}
