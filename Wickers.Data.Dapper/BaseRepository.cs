using System;

namespace Wickers.Data.Dapper.Dapper
{
    public class BaseRepository
    {
        private readonly Action<Exception> _callBack;
        
        protected BaseRepository(Action<Exception> CallBack)
        {
            _callBack = CallBack;
        }

        protected void ProcessException(Exception e)
        {
            _callBack?.Invoke(e);
        }

    }
}
