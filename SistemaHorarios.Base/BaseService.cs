using System.Data.SqlClient;
using System.Diagnostics;
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
                Logger.LogWcfRequest(request);
                var response = bl.Execute(request);
                Logger.LogWcfResponse(request.TransactionId, callerMethodName, response.Status.ToString(), response.ErrorMessage);
                return response;
            }
            catch (System.Exception ex)
            {
                Logger.LogWcfResponse(request.TransactionId, callerMethodName, ExecutionStatus.TechnicalError.ToString(), ex.Message);
                return new ResponseType() { ErrorMessage = ex.Message, Status = ExecutionStatus.TechnicalError };
            }
        }
    }
}