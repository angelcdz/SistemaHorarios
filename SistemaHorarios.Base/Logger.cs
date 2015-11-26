using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHorarios.Base
{
    public class Logger
    {
        public static void LogWcfResponse(Guid transaction, string operation, string status, string message)
        {
            try
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["SistemaHorariosEntitiesLogger"].ConnectionString))
                {
                    con.Open();
                    var command = new SqlCommand(string.Concat(@"INSERT INTO LOG_EVENTS(TRANSACTION_ID, OPERATION_NAME, TRANSACTION_STATUS, ERROR_MESSAGE, TRANSACTION_DATE)
                                                            VALUES (@TRANSACTION_ID, @OPERATION_NAME, @TRANSACTION_STATUS, @ERROR_MESSAGE, GETDATE())"), con);
                    command.Parameters.Add(new SqlParameter("@TRANSACTION_ID", transaction.ToString()));
                    command.Parameters.Add(new SqlParameter("@OPERATION_NAME", operation));
                    command.Parameters.Add(new SqlParameter("@TRANSACTION_STATUS", status));
                    command.Parameters.Add(new SqlParameter("@ERROR_MESSAGE", message == null ? string.Empty : message));
                    command.ExecuteNonQuery();
                    con.Close();
                };
            }
            catch (Exception) { }
        }

        public static void LogWcfRequest<RequestType>(RequestType request) where RequestType : BaseRequest
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["SistemaHorariosEntitiesLogger"].ConnectionString))
            {
                con.Open();
                var tran = con.BeginTransaction();
                try
                {
                    foreach (var prop in request.GetType().GetProperties())
                    {
                        var command = new SqlCommand(@"INSERT INTO LOG_DETAILS(TRANSACTION_ID, REQUEST_PARAMETER_NAME, REQUEST_PARAMETER_VALUE)
                                                    VALUES(@TRANSACTION_ID, @REQUEST_PARAMETER_NAME, @REQUEST_PARAMETER_VALUE)", con, tran);
                        command.Parameters.Add(new SqlParameter("@TRANSACTION_ID", request.TransactionId.ToString()));
                        command.Parameters.Add(new SqlParameter("@REQUEST_PARAMETER_VALUE", prop.GetValue(request) == null ? string.Empty : prop.GetValue(request).ToString()));
                        command.Parameters.Add(new SqlParameter("@REQUEST_PARAMETER_NAME", prop.Name));
                        command.ExecuteNonQuery();
                    }
                    tran.Commit();
                }
                catch (Exception) { tran.Rollback(); }
            };
        }
    }
}
