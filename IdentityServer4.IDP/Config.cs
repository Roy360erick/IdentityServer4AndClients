// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer4.IDP
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.Profile(),
                new IdentityResources.OpenId()
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            { };

        public static IEnumerable<Client> Clients =>
            new Client[] 
            {
                new Client
                {
                    ClientName = "adminClient",
                    ClientId = "adminclient",
                    AllowedGrantTypes = GrantTypes.Code,
                    RedirectUris = new List<string>{ "https://localhost:26941/signin-oidc"},
                    AllowedScopes = {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile
                    },
                    ClientSecrets = { new Secret("123456".Sha512())},
                    RequireConsent = true,
                    RequirePkce = false
                }
            };

        public static IEnumerable<ApiResource> ApiResources =>
            new ApiResource[]
            { };

    }
}