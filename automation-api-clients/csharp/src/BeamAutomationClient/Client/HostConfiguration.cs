/*
 * Automation API
 *
 * The Automation API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using BeamAutomationClient.Api;
using BeamAutomationClient.Model;

namespace BeamAutomationClient.Client
{
    /// <summary>
    /// Provides hosting configuration for BeamAutomationClient
    /// </summary>
    public class HostConfiguration
    {
        private readonly IServiceCollection _services;
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions();

        internal bool HttpClientsAdded { get; private set; }

        /// <summary>
        /// Instantiates the class 
        /// </summary>
        /// <param name="services"></param>
        public HostConfiguration(IServiceCollection services)
        {
            _services = services;
            _jsonOptions.Converters.Add(new JsonStringEnumConverter());
            _jsonOptions.Converters.Add(new DateTimeJsonConverter());
            _jsonOptions.Converters.Add(new DateTimeNullableJsonConverter());
            _jsonOptions.Converters.Add(new AcceptAssetOfferRequestInputV2JsonConverter());
            _jsonOptions.Converters.Add(new AcceptOfferResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new AddContractRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new AddContractResponseJsonConverter());
            _jsonOptions.Converters.Add(new BuyAssetRequestInputV2JsonConverter());
            _jsonOptions.Converters.Add(new BuyAssetResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new CancelAssetListingRequestInputV2JsonConverter());
            _jsonOptions.Converters.Add(new CancelAssetListingResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new CancelAssetOfferRequestInputV2JsonConverter());
            _jsonOptions.Converters.Add(new CancelOfferResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new Check200ResponseJsonConverter());
            _jsonOptions.Converters.Add(new Check200ResponseInfoValueJsonConverter());
            _jsonOptions.Converters.Add(new Check503ResponseJsonConverter());
            _jsonOptions.Converters.Add(new CommonAddPolicyRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new CommonAddPolicyResponseJsonConverter());
            _jsonOptions.Converters.Add(new CommonGetPoliciesResponseJsonConverter());
            _jsonOptions.Converters.Add(new CommonGetPoliciesResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new CommonRemovePolicyResponseJsonConverter());
            _jsonOptions.Converters.Add(new ConvertTokenRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new ConvertTokenResponseJsonConverter());
            _jsonOptions.Converters.Add(new CreateAssetOfferRequestInputV2JsonConverter());
            _jsonOptions.Converters.Add(new CreateOfferResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new CreateProfileRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new CreateProfileResponseJsonConverter());
            _jsonOptions.Converters.Add(new CreateProfileResponseWalletsInnerJsonConverter());
            _jsonOptions.Converters.Add(new CreateTransactionRequestInputV2JsonConverter());
            _jsonOptions.Converters.Add(new CreateTransactionRequestInputV2InteractionsInnerJsonConverter());
            _jsonOptions.Converters.Add(new CreateTransactionResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new CreateWebhookForGameJsonConverter());
            _jsonOptions.Converters.Add(new GenerateLinkCodeRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new GenerateLinkCodeResponseJsonConverter());
            _jsonOptions.Converters.Add(new GenerateSignInCodeRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new GenerateSignInCodeResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetAllGasUsageResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetAllGasUsageResponseChainsInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetAllGasUsageResponseChainsInnerPoliciesInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetAllGasUsageResponseChainsInnerPoliciesInnerPeriodsInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetAllGasUsageResponseChainsInnerPoliciesInnerPolicyJsonConverter());
            _jsonOptions.Converters.Add(new GetAllGasUsageResponseChainsInnerSummaryJsonConverter());
            _jsonOptions.Converters.Add(new GetAllProfilesResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetAllProfilesResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetAllProfilesResponsePaginationJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetListingsResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new GetAssetListingsResponseV2DataInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetListingsResponseV2DataInnerPriceJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetListingsResponseV2DataInnerPriceAmountJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetListingsResponseV2DataInnerPriceCurrencyJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new GetAssetResponseV2OwnersInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetsForContractBodyInputV2JsonConverter());
            _jsonOptions.Converters.Add(new GetAssetsForContractBodyInputV2AttributesInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetsForContractResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new GetAssetsForContractResponseV2DataInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetsForProfileBodyInputV2JsonConverter());
            _jsonOptions.Converters.Add(new GetAssetsForProfileResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new GetAssetsForProfileResponseV2DataInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetsForProfileResponseV2DataInnerAttributesInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetChainCurrenciesResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new GetChainCurrenciesResponseV2DataInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetChainResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetChainResponseNativeCurrencyJsonConverter());
            _jsonOptions.Converters.Add(new GetEstimateResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetGameResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetGameResponseContractsInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetGameResponseDepositorJsonConverter());
            _jsonOptions.Converters.Add(new GetGameResponseDevelopersInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetGameResponseDevelopersInnerDeveloperJsonConverter());
            _jsonOptions.Converters.Add(new GetGameResponsePoliciesInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetGasUsageResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetListedAssetsBodyInputV2JsonConverter());
            _jsonOptions.Converters.Add(new GetPolicyUsageResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetProfileCurrenciesResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new GetProfileCurrenciesResponseV2DataInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetProfileNativeCurrencyResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new GetProfileNativeCurrencyResponseV2NativeTokenBalanceJsonConverter());
            _jsonOptions.Converters.Add(new GetProfileResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetQuoteResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetTransactionResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new GetTransactionResponseV2PolicyJsonConverter());
            _jsonOptions.Converters.Add(new GetTransactionResponseV2ProfileJsonConverter());
            _jsonOptions.Converters.Add(new GetTransactionResponseV2ProfileWalletJsonConverter());
            _jsonOptions.Converters.Add(new GetTransactionsResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new GetTransactionsResponseV2DataInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetTransactionsResponseV2DataInnerIntentJsonConverter());
            _jsonOptions.Converters.Add(new GetTransactionsResponseV2DataInnerIntentInteractionsInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetTransactionsResponseV2DataInnerTransactionJsonConverter());
            _jsonOptions.Converters.Add(new GetTransactionsResponseV2DataInnerTransactionLogsInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetWebhooksForGameResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetWebhooksForGameResponseWebhooksInnerJsonConverter());
            _jsonOptions.Converters.Add(new RegenerateGameApiKeysResponseJsonConverter());
            _jsonOptions.Converters.Add(new RegenerateGameApiKeysResponseApiKeysInnerJsonConverter());
            _jsonOptions.Converters.Add(new RemoveContractResponseJsonConverter());
            _jsonOptions.Converters.Add(new SellAssetRequestInputV2JsonConverter());
            _jsonOptions.Converters.Add(new SellAssetResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new TradeTokensRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new TradeTokensRequestInputInitiatorJsonConverter());
            _jsonOptions.Converters.Add(new TradeTokensRequestInputInitiatorTokensInnerJsonConverter());
            _jsonOptions.Converters.Add(new TradeTokensResponseJsonConverter());
            _jsonOptions.Converters.Add(new TransferAssetRequestInputV2JsonConverter());
            _jsonOptions.Converters.Add(new TransferAssetRequestInputV2AssetsInnerJsonConverter());
            _jsonOptions.Converters.Add(new TransferAssetResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new TransferNativeTokenRequestInputV2JsonConverter());
            _jsonOptions.Converters.Add(new TransferTokenRequestInputV2JsonConverter());
            _jsonOptions.Converters.Add(new TransferTokenResponseV2JsonConverter());
            _jsonOptions.Converters.Add(new UpdateGameRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new UpdateGameResponseJsonConverter());
            _jsonOptions.Converters.Add(new UpdateGameResponsePoliciesInnerJsonConverter());
            _jsonOptions.Converters.Add(new UpdateProfileRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new UpdateProfileResponseJsonConverter());
            _jsonOptions.Converters.Add(new WebhookForGameResponseJsonConverter());
            JsonSerializerOptionsProvider jsonSerializerOptionsProvider = new(_jsonOptions);
            _services.AddSingleton(jsonSerializerOptionsProvider);
            _services.AddSingleton<IApiFactory, ApiFactory>();
            _services.AddSingleton<AssetsV2ApiEvents>();
            _services.AddTransient<IAssetsV2Api, AssetsV2Api>();
            _services.AddSingleton<ChainApiEvents>();
            _services.AddTransient<IChainApi, ChainApi>();
            _services.AddSingleton<ExchangeApiEvents>();
            _services.AddTransient<IExchangeApi, ExchangeApi>();
            _services.AddSingleton<GameApiEvents>();
            _services.AddTransient<IGameApi, GameApi>();
            _services.AddSingleton<HealthApiEvents>();
            _services.AddTransient<IHealthApi, HealthApi>();
            _services.AddSingleton<MarketplaceV2ApiEvents>();
            _services.AddTransient<IMarketplaceV2Api, MarketplaceV2Api>();
            _services.AddSingleton<PolicyApiEvents>();
            _services.AddTransient<IPolicyApi, PolicyApi>();
            _services.AddSingleton<ProfilesApiEvents>();
            _services.AddTransient<IProfilesApi, ProfilesApi>();
            _services.AddSingleton<ReportingApiEvents>();
            _services.AddTransient<IReportingApi, ReportingApi>();
            _services.AddSingleton<TradingApiEvents>();
            _services.AddTransient<ITradingApi, TradingApi>();
            _services.AddSingleton<TransactionsV2ApiEvents>();
            _services.AddTransient<ITransactionsV2Api, TransactionsV2Api>();
            _services.AddSingleton<WebhooksApiEvents>();
            _services.AddTransient<IWebhooksApi, WebhooksApi>();
        }

        /// <summary>
        /// Configures the HttpClients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        public HostConfiguration AddBeamAutomationApiHttpClients
        (
            Action<HttpClient>? client = null, Action<IHttpClientBuilder>? builder = null)
        {
            if (client == null)
                client = c => c.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS);

            List<IHttpClientBuilder> builders = new List<IHttpClientBuilder>();

            builders.Add(_services.AddHttpClient<IAssetsV2Api, AssetsV2Api>(client));
            builders.Add(_services.AddHttpClient<IChainApi, ChainApi>(client));
            builders.Add(_services.AddHttpClient<IExchangeApi, ExchangeApi>(client));
            builders.Add(_services.AddHttpClient<IGameApi, GameApi>(client));
            builders.Add(_services.AddHttpClient<IHealthApi, HealthApi>(client));
            builders.Add(_services.AddHttpClient<IMarketplaceV2Api, MarketplaceV2Api>(client));
            builders.Add(_services.AddHttpClient<IPolicyApi, PolicyApi>(client));
            builders.Add(_services.AddHttpClient<IProfilesApi, ProfilesApi>(client));
            builders.Add(_services.AddHttpClient<IReportingApi, ReportingApi>(client));
            builders.Add(_services.AddHttpClient<ITradingApi, TradingApi>(client));
            builders.Add(_services.AddHttpClient<ITransactionsV2Api, TransactionsV2Api>(client));
            builders.Add(_services.AddHttpClient<IWebhooksApi, WebhooksApi>(client));
            
            if (builder != null)
                foreach (IHttpClientBuilder instance in builders)
                    builder(instance);

            HttpClientsAdded = true;

            return this;
        }

        /// <summary>
        /// Configures the JsonSerializerSettings
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public HostConfiguration ConfigureJsonOptions(Action<JsonSerializerOptions> options)
        {
            options(_jsonOptions);

            return this;
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="token"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(TTokenBase token) where TTokenBase : TokenBase
        {
            return AddTokens(new TTokenBase[]{ token });
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(IEnumerable<TTokenBase> tokens) where TTokenBase : TokenBase
        {
            TokenContainer<TTokenBase> container = new TokenContainer<TTokenBase>(tokens);
            _services.AddSingleton(services => container);

            return this;
        }

        /// <summary>
        /// Adds a token provider to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenProvider"></typeparam>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <returns></returns>
        public HostConfiguration UseProvider<TTokenProvider, TTokenBase>() 
            where TTokenProvider : TokenProvider<TTokenBase>
            where TTokenBase : TokenBase
        {
            _services.AddSingleton<TTokenProvider>();
            _services.AddSingleton<TokenProvider<TTokenBase>>(services => services.GetRequiredService<TTokenProvider>());

            return this;
        }
    }
}
