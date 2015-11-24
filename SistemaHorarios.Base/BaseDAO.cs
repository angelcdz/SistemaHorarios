using System.Runtime.Serialization;
namespace SistemaHorarios.Base
{
    public abstract class BaseDAO<RequestType, ResponseType>
        where RequestType : BaseRequest
        where ResponseType : BaseResponse, new()
    {
        protected abstract ResponseType GetData(RequestType request);

        public ResponseType Execute(RequestType request)
        {
            try
            {
                return this.GetData(request);
            }
            catch (System.Exception ex)
            {
                return new ResponseType() { ErrorMessage = ex.Message, Status = ExecutionStatus.TechnicalError };
            }
        }

        protected string UppercaseWords(string value)
        {
            char[] array = value.ToLower().ToCharArray();
            if (array.Length >= 1)
                if (char.IsLower(array[0]))
                    array[0] = char.ToUpper(array[0]);

            for (int i = 1; i < array.Length; i++)
                if (array[i - 1] == ' ' || char.ToLower(array[i - 1]) == array[i])
                    array[i] = char.ToUpper(array[i]);
            return new string(array);
        }
    }    
}
