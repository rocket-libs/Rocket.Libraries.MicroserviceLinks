﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rocket.Libraries.MicroServiceChannels
{
    public interface IMicroServiceChannel
    {
        Task<TResponse> CallAsync<TResponse>(string microService, string relativePath, Dictionary<string, string> headers, System.Net.Http.HttpMethod method, object payload);
    }
}