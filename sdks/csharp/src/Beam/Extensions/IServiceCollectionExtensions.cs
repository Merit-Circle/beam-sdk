/*
 * Beam game development API
 *
 * The Beam game development API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Beam.Client;

namespace Beam.Extensions
{
    /// <summary>
    /// Extension methods for IServiceCollection
    /// </summary>
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Add the api to your host builder.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="options"></param>
        [Obsolete("Use AddBeamApi")]
        public static void AddApi(this IServiceCollection services, Action<HostConfiguration> options)
        {
            HostConfiguration config = new(services);
            options(config);
            AddApi(services, config);
        }

        /// <summary>
        /// Add the api to your host builder.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="options"></param>
        public static void AddBeamApi(this IServiceCollection services, Action<HostConfiguration> options)
        {
            HostConfiguration config = new(services);
            options(config);
            AddApi(services, config);
        }

        internal static void AddApi(IServiceCollection services, HostConfiguration host)
        {
            if (!host.HttpClientsAdded)
                host.AddApiHttpClients();

            services.AddSingleton<CookieContainer>();

            services.AddSingleton<SimpleApiKeyTokenProvider<ApiKeyToken>>();
            services.AddTransient(typeof(TokenProvider<>).MakeGenericType(typeof(ApiKeyToken)),
                        s => s.GetRequiredService(typeof(SimpleApiKeyTokenProvider<>).MakeGenericType(typeof(ApiKeyToken))));
        }
    }
}