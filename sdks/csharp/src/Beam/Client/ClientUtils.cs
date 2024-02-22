/*
 * Beam game development API
 *
 * The Beam game development API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using Beam.Model;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Beam.Test")]

namespace Beam.Client
{
    /// <summary>
    /// Utility functions providing some benefit to API client consumers.
    /// </summary>
    public static class ClientUtils
    {

        /// <summary>
        /// A delegate for events.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public delegate void EventHandler<T>(object sender, T e) where T : EventArgs;

        /// <summary>
        /// Returns true when deserialization succeeds.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <param name="options"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool TryDeserialize<T>(string json, JsonSerializerOptions options, [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T result)
        {
            try
            {
                result = JsonSerializer.Deserialize<T>(json, options);
                return result != null;
            }
            catch (Exception)
            {
                result = default;
                return false;
            }
        }

        /// <summary>
        /// Returns true when deserialization succeeds.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <param name="options"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool TryDeserialize<T>(ref Utf8JsonReader reader, JsonSerializerOptions options, [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T result)
        {
            try
            {
                result = JsonSerializer.Deserialize<T>(ref reader, options);
                return result != null;
            }
            catch (Exception)
            {
                result = default;
                return false;
            }
        }

        /// <summary>
        /// Sanitize filename by removing the path
        /// </summary>
        /// <param name="filename">Filename</param>
        /// <returns>Filename</returns>
        public static string SanitizeFilename(string filename)
        {
            Match match = Regex.Match(filename, @".*[/\\](.*)$");
            return match.Success ? match.Groups[1].Value : filename;
        }

        /// <summary>
        /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
        /// If parameter is a list, join the list with ",".
        /// Otherwise just return the string.
        /// </summary>
        /// <param name="obj">The parameter (header, path, query, form).</param>
        /// <param name="format">The DateTime serialization format.</param>
        /// <returns>Formatted string.</returns>
        public static string ParameterToString(object obj, string format = ISO8601_DATETIME_FORMAT)
        {
            if (obj is DateTime dateTime)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return dateTime.ToString(format);
            if (obj is DateTimeOffset dateTimeOffset)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return dateTimeOffset.ToString(format);
            if (obj is bool boolean)
                return boolean
                    ? "true"
                    : "false";
            if (obj is AddContractRequestInput.TypeEnum addContractRequestInputTypeEnum)
                return AddContractRequestInput.TypeEnumToJsonValue(addContractRequestInputTypeEnum);
            if (obj is AddContractResponse.TypeEnum addContractResponseTypeEnum)
                return AddContractResponse.TypeEnumToJsonValue(addContractResponseTypeEnum);
            if (obj is AddPolicyRequestInput.RateTypeEnum addPolicyRequestInputRateTypeEnum)
                return AddPolicyRequestInput.RateTypeEnumToJsonValue(addPolicyRequestInputRateTypeEnum);
            if (obj is AddPolicyResponse.RateTypeEnum addPolicyResponseRateTypeEnum)
                return AddPolicyResponse.RateTypeEnumToJsonValue(addPolicyResponseRateTypeEnum);
            if (obj is ConvertTokenResponse.StatusEnum convertTokenResponseStatusEnum)
                return ConvertTokenResponse.StatusEnumToJsonValue(convertTokenResponseStatusEnum);
            if (obj is ConvertTokenResponse.TypeEnum convertTokenResponseTypeEnum)
                return ConvertTokenResponse.TypeEnumToJsonValue(convertTokenResponseTypeEnum);
            if (obj is CreateAssetOfferRequestInputV2.CurrencyEnum createAssetOfferRequestInputV2CurrencyEnum)
                return CreateAssetOfferRequestInputV2.CurrencyEnumToJsonValue(createAssetOfferRequestInputV2CurrencyEnum);
            if (obj is GetAllGasUsageResponseChainsInnerPoliciesInnerPolicy.ModelEnum getAllGasUsageResponseChainsInnerPoliciesInnerPolicyModelEnum)
                return GetAllGasUsageResponseChainsInnerPoliciesInnerPolicy.ModelEnumToJsonValue(getAllGasUsageResponseChainsInnerPoliciesInnerPolicyModelEnum);
            if (obj is GetAssetListingsResponseV2DataInner.StatusEnum getAssetListingsResponseV2DataInnerStatusEnum)
                return GetAssetListingsResponseV2DataInner.StatusEnumToJsonValue(getAssetListingsResponseV2DataInnerStatusEnum);
            if (obj is GetAssetListingsResponseV2DataInnerPriceCurrency.SymbolEnum getAssetListingsResponseV2DataInnerPriceCurrencySymbolEnum)
                return GetAssetListingsResponseV2DataInnerPriceCurrency.SymbolEnumToJsonValue(getAssetListingsResponseV2DataInnerPriceCurrencySymbolEnum);
            if (obj is GetAssetResponseV2.RarityEnum getAssetResponseV2RarityEnum)
                return GetAssetResponseV2.RarityEnumToJsonValue(getAssetResponseV2RarityEnum);
            if (obj is GetAssetsForContractBodyInputV2.SortByEnum getAssetsForContractBodyInputV2SortByEnum)
                return GetAssetsForContractBodyInputV2.SortByEnumToJsonValue(getAssetsForContractBodyInputV2SortByEnum);
            if (obj is GetAssetsForContractBodyInputV2.SortDirectionEnum getAssetsForContractBodyInputV2SortDirectionEnum)
                return GetAssetsForContractBodyInputV2.SortDirectionEnumToJsonValue(getAssetsForContractBodyInputV2SortDirectionEnum);
            if (obj is GetAssetsForContractResponseV2DataInner.RarityEnum getAssetsForContractResponseV2DataInnerRarityEnum)
                return GetAssetsForContractResponseV2DataInner.RarityEnumToJsonValue(getAssetsForContractResponseV2DataInnerRarityEnum);
            if (obj is GetAssetsForProfileBodyInputV2.SortByEnum getAssetsForProfileBodyInputV2SortByEnum)
                return GetAssetsForProfileBodyInputV2.SortByEnumToJsonValue(getAssetsForProfileBodyInputV2SortByEnum);
            if (obj is GetAssetsForProfileBodyInputV2.SortDirectionEnum getAssetsForProfileBodyInputV2SortDirectionEnum)
                return GetAssetsForProfileBodyInputV2.SortDirectionEnumToJsonValue(getAssetsForProfileBodyInputV2SortDirectionEnum);
            if (obj is GetAssetsForProfileResponseV2DataInner.RarityEnum getAssetsForProfileResponseV2DataInnerRarityEnum)
                return GetAssetsForProfileResponseV2DataInner.RarityEnumToJsonValue(getAssetsForProfileResponseV2DataInnerRarityEnum);
            if (obj is GetChainCurrenciesResponseV2DataInner.SymbolEnum getChainCurrenciesResponseV2DataInnerSymbolEnum)
                return GetChainCurrenciesResponseV2DataInner.SymbolEnumToJsonValue(getChainCurrenciesResponseV2DataInnerSymbolEnum);
            if (obj is GetGameResponse.PegiContentEnum getGameResponsePegiContentEnum)
                return GetGameResponse.PegiContentEnumToJsonValue(getGameResponsePegiContentEnum);
            if (obj is GetGameResponse.PegiRatingEnum getGameResponsePegiRatingEnum)
                return GetGameResponse.PegiRatingEnumToJsonValue(getGameResponsePegiRatingEnum);
            if (obj is GetGameResponseContractsInner.TypeEnum getGameResponseContractsInnerTypeEnum)
                return GetGameResponseContractsInner.TypeEnumToJsonValue(getGameResponseContractsInnerTypeEnum);
            if (obj is GetGameResponseDevelopersInner.RoleEnum getGameResponseDevelopersInnerRoleEnum)
                return GetGameResponseDevelopersInner.RoleEnumToJsonValue(getGameResponseDevelopersInnerRoleEnum);
            if (obj is GetGameResponsePoliciesInner.ModelEnum getGameResponsePoliciesInnerModelEnum)
                return GetGameResponsePoliciesInner.ModelEnumToJsonValue(getGameResponsePoliciesInnerModelEnum);
            if (obj is GetGameResponsePoliciesInner.TypeEnum getGameResponsePoliciesInnerTypeEnum)
                return GetGameResponsePoliciesInner.TypeEnumToJsonValue(getGameResponsePoliciesInnerTypeEnum);
            if (obj is GetGameResponsePoliciesInner.RateTypeEnum getGameResponsePoliciesInnerRateTypeEnum)
                return GetGameResponsePoliciesInner.RateTypeEnumToJsonValue(getGameResponsePoliciesInnerRateTypeEnum);
            if (obj is GetListedAssetsBodyInputV2.SortByEnum getListedAssetsBodyInputV2SortByEnum)
                return GetListedAssetsBodyInputV2.SortByEnumToJsonValue(getListedAssetsBodyInputV2SortByEnum);
            if (obj is GetListedAssetsBodyInputV2.SortDirectionEnum getListedAssetsBodyInputV2SortDirectionEnum)
                return GetListedAssetsBodyInputV2.SortDirectionEnumToJsonValue(getListedAssetsBodyInputV2SortDirectionEnum);
            if (obj is GetPoliciesResponseDataInner.RateTypeEnum getPoliciesResponseDataInnerRateTypeEnum)
                return GetPoliciesResponseDataInner.RateTypeEnumToJsonValue(getPoliciesResponseDataInnerRateTypeEnum);
            if (obj is RegenerateGameApiKeysResponse.PegiContentEnum regenerateGameApiKeysResponsePegiContentEnum)
                return RegenerateGameApiKeysResponse.PegiContentEnumToJsonValue(regenerateGameApiKeysResponsePegiContentEnum);
            if (obj is RegenerateGameApiKeysResponse.PegiRatingEnum regenerateGameApiKeysResponsePegiRatingEnum)
                return RegenerateGameApiKeysResponse.PegiRatingEnumToJsonValue(regenerateGameApiKeysResponsePegiRatingEnum);
            if (obj is RegenerateGameApiKeysResponseApiKeysInner.TypeEnum regenerateGameApiKeysResponseApiKeysInnerTypeEnum)
                return RegenerateGameApiKeysResponseApiKeysInner.TypeEnumToJsonValue(regenerateGameApiKeysResponseApiKeysInnerTypeEnum);
            if (obj is SellAssetRequestInputV2.SellTypeEnum sellAssetRequestInputV2SellTypeEnum)
                return SellAssetRequestInputV2.SellTypeEnumToJsonValue(sellAssetRequestInputV2SellTypeEnum);
            if (obj is SellAssetRequestInputV2.CurrencyEnum sellAssetRequestInputV2CurrencyEnum)
                return SellAssetRequestInputV2.CurrencyEnumToJsonValue(sellAssetRequestInputV2CurrencyEnum);
            if (obj is TradeTokensResponse.StatusEnum tradeTokensResponseStatusEnum)
                return TradeTokensResponse.StatusEnumToJsonValue(tradeTokensResponseStatusEnum);
            if (obj is TradeTokensResponse.TypeEnum tradeTokensResponseTypeEnum)
                return TradeTokensResponse.TypeEnumToJsonValue(tradeTokensResponseTypeEnum);
            if (obj is TransferAssetResponseV2.StatusEnum transferAssetResponseV2StatusEnum)
                return TransferAssetResponseV2.StatusEnumToJsonValue(transferAssetResponseV2StatusEnum);
            if (obj is TransferAssetResponseV2.TypeEnum transferAssetResponseV2TypeEnum)
                return TransferAssetResponseV2.TypeEnumToJsonValue(transferAssetResponseV2TypeEnum);
            if (obj is TransferTokenResponseV2.StatusEnum transferTokenResponseV2StatusEnum)
                return TransferTokenResponseV2.StatusEnumToJsonValue(transferTokenResponseV2StatusEnum);
            if (obj is TransferTokenResponseV2.TypeEnum transferTokenResponseV2TypeEnum)
                return TransferTokenResponseV2.TypeEnumToJsonValue(transferTokenResponseV2TypeEnum);
            if (obj is UpdateGameRequestInput.PegiContentEnum updateGameRequestInputPegiContentEnum)
                return UpdateGameRequestInput.PegiContentEnumToJsonValue(updateGameRequestInputPegiContentEnum);
            if (obj is UpdateGameRequestInput.PegiRatingEnum updateGameRequestInputPegiRatingEnum)
                return UpdateGameRequestInput.PegiRatingEnumToJsonValue(updateGameRequestInputPegiRatingEnum);
            if (obj is UpdateGameResponse.PegiContentEnum updateGameResponsePegiContentEnum)
                return UpdateGameResponse.PegiContentEnumToJsonValue(updateGameResponsePegiContentEnum);
            if (obj is UpdateGameResponse.PegiRatingEnum updateGameResponsePegiRatingEnum)
                return UpdateGameResponse.PegiRatingEnumToJsonValue(updateGameResponsePegiRatingEnum);
            if (obj is UpdateGameResponsePoliciesInner.ModelEnum updateGameResponsePoliciesInnerModelEnum)
                return UpdateGameResponsePoliciesInner.ModelEnumToJsonValue(updateGameResponsePoliciesInnerModelEnum);
            if (obj is UpdateGameResponsePoliciesInner.TypeEnum updateGameResponsePoliciesInnerTypeEnum)
                return UpdateGameResponsePoliciesInner.TypeEnumToJsonValue(updateGameResponsePoliciesInnerTypeEnum);
            if (obj is UpdateGameResponsePoliciesInner.RateTypeEnum updateGameResponsePoliciesInnerRateTypeEnum)
                return UpdateGameResponsePoliciesInner.RateTypeEnumToJsonValue(updateGameResponsePoliciesInnerRateTypeEnum);
            if (obj is ICollection collection)
            {
                List<string> entries = new();
                foreach (var entry in collection)
                    entries.Add(ParameterToString(entry));
                return string.Join(",", entries);
            }

            return Convert.ToString(obj, System.Globalization.CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// URL encode a string
        /// Credit/Ref: https://github.com/restsharp/RestSharp/blob/master/RestSharp/Extensions/StringExtensions.cs#L50
        /// </summary>
        /// <param name="input">string to be URL encoded</param>
        /// <returns>Byte array</returns>
        public static string UrlEncode(string input)
        {
            const int maxLength = 32766;

            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (input.Length <= maxLength)
            {
                return Uri.EscapeDataString(input);
            }

            StringBuilder sb = new StringBuilder(input.Length * 2);
            int index = 0;

            while (index < input.Length)
            {
                int length = Math.Min(input.Length - index, maxLength);
                string subString = input.Substring(index, length);

                sb.Append(Uri.EscapeDataString(subString));
                index += subString.Length;
            }

            return sb.ToString();
        }

        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">string to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string Base64Encode(string text)
        {
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(text));
        }

        /// <summary>
        /// Convert stream to byte array
        /// </summary>
        /// <param name="inputStream">Input stream to be converted</param>
        /// <returns>Byte array</returns>
        public static byte[] ReadAsBytes(Stream inputStream)
        {
            using (var ms = new MemoryStream())
            {
                inputStream.CopyTo(ms);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Select the Content-Type header's value from the given content-type array:
        /// if JSON type exists in the given array, use it;
        /// otherwise use the first one defined in 'consumes'
        /// </summary>
        /// <param name="contentTypes">The Content-Type array to select from.</param>
        /// <returns>The Content-Type header to use.</returns>
        public static string SelectHeaderContentType(string[] contentTypes)
        {
            if (contentTypes.Length == 0)
                return null;

            foreach (var contentType in contentTypes)
            {
                if (IsJsonMime(contentType))
                    return contentType;
            }

            return contentTypes[0]; // use the first content type specified in 'consumes'
        }

        /// <summary>
        /// Select the Accept header's value from the given accepts array:
        /// if JSON exists in the given array, use it;
        /// otherwise use all of them (joining into a string)
        /// </summary>
        /// <param name="accepts">The accepts array to select from.</param>
        /// <returns>The Accept header to use.</returns>
        public static string SelectHeaderAccept(string[] accepts)
        {
            if (accepts.Length == 0)
                return null;

            if (accepts.Contains("application/json", StringComparer.OrdinalIgnoreCase))
                return "application/json";

            return string.Join(",", accepts);
        }

        /// <summary>
        /// Provides a case-insensitive check that a provided content type is a known JSON-like content type.
        /// </summary>
        public static readonly Regex JsonRegex = new Regex("(?i)^(application/json|[^;/ \t]+/[^;/ \t]+[+]json)[ \t]*(;.*)?$");

        /// <summary>
        /// Check if the given MIME is a JSON MIME.
        /// JSON MIME examples:
        ///    application/json
        ///    application/json; charset=UTF8
        ///    APPLICATION/JSON
        ///    application/vnd.company+json
        /// </summary>
        /// <param name="mime">MIME</param>
        /// <returns>Returns True if MIME type is json.</returns>
        public static bool IsJsonMime(string mime)
        {
            if (string.IsNullOrWhiteSpace(mime)) return false;

            return JsonRegex.IsMatch(mime) || mime.Equals("application/json-patch+json");
        }

        /// <summary>
        /// The base path of the API
        /// </summary>
        public const string BASE_ADDRESS = "http://localhost";

        /// <summary>
        /// The scheme of the API
        /// </summary>
        public const string SCHEME = "http";

        /// <summary>
        /// The context path of the API
        /// </summary>
        public const string CONTEXT_PATH = "";

        /// <summary>
        /// The host of the API
        /// </summary>
        public const string HOST = "localhost";

        /// <summary>
        /// The format to use for DateTime serialization
        /// </summary>
        public const string ISO8601_DATETIME_FORMAT = "o";
    }
}
