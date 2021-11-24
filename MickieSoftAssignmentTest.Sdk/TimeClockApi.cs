using MickieSoftAssignmentTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MickieSoftAssignmentTest.Sdk
{
    public class TimeClockApi
    { 
        private readonly IHttpClientFactory _httpClientFactory;

        public TimeClockApi(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        
    }
}
