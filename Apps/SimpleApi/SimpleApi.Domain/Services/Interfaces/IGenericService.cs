using System;
namespace SimpleApi.Domain.Services.Interfaces
{
	public interface IGenericService
	{
        void LogRequestResponse(string methodname, string Request, string Response);
    }
}

