﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XamTrack.Core.Services
{
    public interface IAppConfigService
    {
        string IotHubConnectionString { get; }
        string DpsIdScope { get; }  
    }
}
