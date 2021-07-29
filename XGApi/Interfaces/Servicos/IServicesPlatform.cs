using System;
using System.Collections.Generic;
using System.Text;
using XGApi.Arguments.Platform;

namespace XGApi.Interfaces.Servicos
{
    public interface IServicesPlatform
    {
        AdicionarPlatformResponse AdicionarPlatform(AdicionarPlatformRequest request);
    }
}
