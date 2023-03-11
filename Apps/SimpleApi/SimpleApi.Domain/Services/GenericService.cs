using System;
using Microsoft.Extensions.Logging;
using SimpleApi.Domain.Services.Interfaces;

namespace SimpleApi.Domain.Services
{
	public class GenericService : IGenericService
    {
        private readonly ILogger<GenericService> _logger;

        public GenericService(ILogger<GenericService> logger)
		{
            _logger = logger;
        }

        public void LogRequestResponse(string methodname, string Request, string Response)
        {
            try
            {
                _logger.LogInformation($"{methodname} Request: -  {Request}");
                _logger.LogInformation($"{methodname} Response: - {Response}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message + " " + ex.StackTrace);
            }
        }
    }
}

