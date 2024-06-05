// <auto-generated>
/*
 * Player API
 *
 * The Player API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = BeamPlayerClient.Client.ClientUtils;
using BeamPlayerClient.Client;

namespace BeamPlayerClient.Model
{
    /// <summary>
    /// GetUserNativeCurrencyResponseNativeTokenBalance
    /// </summary>
    public partial class GetUserNativeCurrencyResponseNativeTokenBalance : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserNativeCurrencyResponseNativeTokenBalance" /> class.
        /// </summary>
        /// <param name="balance">balance</param>
        /// <param name="chainId">chainId</param>
        /// <param name="decimals">decimals</param>
        /// <param name="name">name</param>
        /// <param name="symbol">symbol</param>
        /// <param name="logoUri">logoUri</param>
        [JsonConstructor]
        public GetUserNativeCurrencyResponseNativeTokenBalance(string balance, decimal chainId, decimal decimals, string name, string symbol, Option<string?> logoUri = default)
        {
            Balance = balance;
            ChainId = chainId;
            Decimals = decimals;
            Name = name;
            Symbol = symbol;
            LogoUriOption = logoUri;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [JsonPropertyName("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public decimal ChainId { get; set; }

        /// <summary>
        /// Gets or Sets Decimals
        /// </summary>
        [JsonPropertyName("decimals")]
        public decimal Decimals { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Used to track the state of LogoUri
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> LogoUriOption { get; private set; }

        /// <summary>
        /// Gets or Sets LogoUri
        /// </summary>
        [JsonPropertyName("logoUri")]
        public string? LogoUri { get { return this. LogoUriOption; } set { this.LogoUriOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetUserNativeCurrencyResponseNativeTokenBalance {\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Decimals: ").Append(Decimals).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  LogoUri: ").Append(LogoUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="GetUserNativeCurrencyResponseNativeTokenBalance" />
    /// </summary>
    public class GetUserNativeCurrencyResponseNativeTokenBalanceJsonConverter : JsonConverter<GetUserNativeCurrencyResponseNativeTokenBalance>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetUserNativeCurrencyResponseNativeTokenBalance" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetUserNativeCurrencyResponseNativeTokenBalance Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> balance = default;
            Option<decimal?> chainId = default;
            Option<decimal?> decimals = default;
            Option<string?> name = default;
            Option<string?> symbol = default;
            Option<string?> logoUri = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "balance":
                            balance = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "decimals":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                decimals = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "symbol":
                            symbol = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "logoUri":
                            logoUri = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!balance.IsSet)
                throw new ArgumentException("Property is required for class GetUserNativeCurrencyResponseNativeTokenBalance.", nameof(balance));

            if (!chainId.IsSet)
                throw new ArgumentException("Property is required for class GetUserNativeCurrencyResponseNativeTokenBalance.", nameof(chainId));

            if (!decimals.IsSet)
                throw new ArgumentException("Property is required for class GetUserNativeCurrencyResponseNativeTokenBalance.", nameof(decimals));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class GetUserNativeCurrencyResponseNativeTokenBalance.", nameof(name));

            if (!symbol.IsSet)
                throw new ArgumentException("Property is required for class GetUserNativeCurrencyResponseNativeTokenBalance.", nameof(symbol));

            if (balance.IsSet && balance.Value == null)
                throw new ArgumentNullException(nameof(balance), "Property is not nullable for class GetUserNativeCurrencyResponseNativeTokenBalance.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class GetUserNativeCurrencyResponseNativeTokenBalance.");

            if (decimals.IsSet && decimals.Value == null)
                throw new ArgumentNullException(nameof(decimals), "Property is not nullable for class GetUserNativeCurrencyResponseNativeTokenBalance.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class GetUserNativeCurrencyResponseNativeTokenBalance.");

            if (symbol.IsSet && symbol.Value == null)
                throw new ArgumentNullException(nameof(symbol), "Property is not nullable for class GetUserNativeCurrencyResponseNativeTokenBalance.");

            if (logoUri.IsSet && logoUri.Value == null)
                throw new ArgumentNullException(nameof(logoUri), "Property is not nullable for class GetUserNativeCurrencyResponseNativeTokenBalance.");

            return new GetUserNativeCurrencyResponseNativeTokenBalance(balance.Value!, chainId.Value!.Value!, decimals.Value!.Value!, name.Value!, symbol.Value!, logoUri);
        }

        /// <summary>
        /// Serializes a <see cref="GetUserNativeCurrencyResponseNativeTokenBalance" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getUserNativeCurrencyResponseNativeTokenBalance"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetUserNativeCurrencyResponseNativeTokenBalance getUserNativeCurrencyResponseNativeTokenBalance, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getUserNativeCurrencyResponseNativeTokenBalance, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetUserNativeCurrencyResponseNativeTokenBalance" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getUserNativeCurrencyResponseNativeTokenBalance"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetUserNativeCurrencyResponseNativeTokenBalance getUserNativeCurrencyResponseNativeTokenBalance, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getUserNativeCurrencyResponseNativeTokenBalance.Balance == null)
                throw new ArgumentNullException(nameof(getUserNativeCurrencyResponseNativeTokenBalance.Balance), "Property is required for class GetUserNativeCurrencyResponseNativeTokenBalance.");

            if (getUserNativeCurrencyResponseNativeTokenBalance.Name == null)
                throw new ArgumentNullException(nameof(getUserNativeCurrencyResponseNativeTokenBalance.Name), "Property is required for class GetUserNativeCurrencyResponseNativeTokenBalance.");

            if (getUserNativeCurrencyResponseNativeTokenBalance.Symbol == null)
                throw new ArgumentNullException(nameof(getUserNativeCurrencyResponseNativeTokenBalance.Symbol), "Property is required for class GetUserNativeCurrencyResponseNativeTokenBalance.");

            if (getUserNativeCurrencyResponseNativeTokenBalance.LogoUriOption.IsSet && getUserNativeCurrencyResponseNativeTokenBalance.LogoUri == null)
                throw new ArgumentNullException(nameof(getUserNativeCurrencyResponseNativeTokenBalance.LogoUri), "Property is required for class GetUserNativeCurrencyResponseNativeTokenBalance.");

            writer.WriteString("balance", getUserNativeCurrencyResponseNativeTokenBalance.Balance);

            writer.WriteNumber("chainId", getUserNativeCurrencyResponseNativeTokenBalance.ChainId);

            writer.WriteNumber("decimals", getUserNativeCurrencyResponseNativeTokenBalance.Decimals);

            writer.WriteString("name", getUserNativeCurrencyResponseNativeTokenBalance.Name);

            writer.WriteString("symbol", getUserNativeCurrencyResponseNativeTokenBalance.Symbol);

            if (getUserNativeCurrencyResponseNativeTokenBalance.LogoUriOption.IsSet)
                writer.WriteString("logoUri", getUserNativeCurrencyResponseNativeTokenBalance.LogoUri);
        }
    }
}