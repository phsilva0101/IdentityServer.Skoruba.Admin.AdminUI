﻿using Skoruba.IdentityServer4.Shared.Configuration.Configuration.Identity;

namespace IdentityServer.Skoruba.Admin.STS.Identity.Configuration.Interfaces
{
    public interface IRootConfiguration
    {
        AdminConfiguration AdminConfiguration { get; }

        RegisterConfiguration RegisterConfiguration { get; }
    }
}







