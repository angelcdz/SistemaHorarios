namespace SistemaHorarios.Base
{
    public abstract class BaseBL<RequestType, ResponseType>
        where RequestType : BaseRequest
        where ResponseType : BaseResponse
    {
        public abstract ResponseType Execute(RequestType request);
    }
}
