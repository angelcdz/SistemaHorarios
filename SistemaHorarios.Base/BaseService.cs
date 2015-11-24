using System.Runtime.CompilerServices;
namespace SistemaHorarios.Base
{
    public abstract class BaseService
    {
        protected ResponseType ExecuteBusiness<RequestType, ResponseType>(BaseBL<RequestType, ResponseType> bl, RequestType request, [CallerMemberNameAttribute] string callerMethodName = "")
            where RequestType : BaseRequest
            where ResponseType : BaseResponse, new()
        {
            try
            {
                return bl.Execute(request);
            }
            catch (System.Exception ex)
            {
                return new ResponseType() { ErrorMessage = ex.Message, Status = ExecutionStatus.TechnicalError };
            }
        }
    }
}
