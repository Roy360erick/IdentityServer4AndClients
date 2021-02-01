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
                    //RequirePkce = false
                    PostLogoutRedirectUris = new List<string>{ "https://localhost:26941/signout-callback-oidc" }
                },
                new Client
                {
                    ClientName = "Angular-Client",
                    ClientId = "angular-client",
                    AllowedGrantTypes = GrantTypes.Code,
                    RedirectUris = new List<string>{ "http://localhost:4200/signin-callback", "http://localhost:4200/assets/silent-callback.html" },
                    RequirePkce = true,
                    AllowAccessTokensViaBrowser = true,
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile
                    },
                    AllowedCorsOrigins = { "http://localhost:4200" },
                    RequireClientSecret = false,
                    PostLogoutRedirectUris = new List<string> { "http://localhost:4200/signout-callback" },
                    RequireConsent = false,
                    AccessTokenLifetime = 600
                }
            };

        public static IEnumerable<ApiResource> ApiResources =>
            new ApiResource[]
            { };

    }
}