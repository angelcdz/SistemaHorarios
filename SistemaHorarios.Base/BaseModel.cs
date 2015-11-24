using System;
namespace SistemaHorarios.Base
{
    public abstract class BaseModel<RequestType, ResponseType>
        where RequestType : BaseRequest
        where ResponseType : BaseResponse, new()
    {
        public ResponseType Response { get; private set; }
        public RequestType Request { get; set; }

        public string ErrorMessage { get; protected set; }
        public string ErrorCode { get; protected set; }

        protected abstract Func<RequestType, ResponseType> GetServiceMethod();

        public void Execute(RequestType request)
        {
            try
            {
                var service = this.GetServiceMethod(); 
                this.Response = service(request);
            }
            catch (Exception ex)
            {
                this.Response = new ResponseType() { Status = ExecutionStatus.TechnicalError, ErrorMessage = ex.Message };
            }
        }
    }
}
