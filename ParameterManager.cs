using Dapper;
using System.Collections.Generic;
using Wickers.Data.Dapper.Model;

namespace Wickers.Data.Dapper.Dapper
{
    public class ParameterManager
    {
        public static DynamicParameters CreateParameters(List<ParameterModel> Parameters = null)
        {
            DynamicParameters parameters = new DynamicParameters();

            if (Parameters != null)
            {
                foreach (ParameterModel param in Parameters)
                {
                    parameters.Add($"@{param.Name}", param.Value, param.DataType, param.Direction, param.Size);
                }
            }
            
            return parameters;

        }
        

        public static T GetOutPutParameterValue<T>(DynamicParameters Parameters, string ParameterName)
        {
            return Parameters.Get<T>(ParameterName);
        }
    }
}
