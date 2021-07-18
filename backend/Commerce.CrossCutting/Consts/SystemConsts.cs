using System;

namespace Commerce.CrossCutting.Consts
{
    public static class SystemConsts
    {
        public static string DbConnectionString { get => @"Data Source=C:\desafio.db;"; }

        public static string TokenSecurityValue { get => Environment.GetEnvironmentVariable("APP_JWT_KEY"); }

        public static string TokenAudienceId { get => Environment.GetEnvironmentVariable("APP_JWT_AUDIENCE"); }

        public static string TokenIssuer { get => Environment.GetEnvironmentVariable("APP_JWT_ISSUER"); }
    }
}
