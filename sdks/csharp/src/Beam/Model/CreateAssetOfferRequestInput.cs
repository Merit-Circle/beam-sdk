// <auto-generated>
/*
 * Beam game development API
 *
 * The Beam game development API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

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

namespace Beam.Model
{
    /// <summary>
    /// CreateAssetOfferRequestInput
    /// </summary>
    public partial class CreateAssetOfferRequestInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetOfferRequestInput" /> class.
        /// </summary>
        /// <param name="endTime">endTime</param>
        /// <param name="marketplaceId">marketplaceId</param>
        /// <param name="price">price</param>
        /// <param name="quantity">quantity</param>
        /// <param name="startTime">startTime</param>
        /// <param name="chainId">chainId (default to 13337M)</param>
        /// <param name="currency">currency (default to CurrencyEnum.Beam)</param>
        [JsonConstructor]
        public CreateAssetOfferRequestInput(string endTime, string marketplaceId, string price, decimal quantity, string startTime, decimal chainId = 13337M, CurrencyEnum currency = CurrencyEnum.Beam)
        {
            EndTime = endTime;
            MarketplaceId = marketplaceId;
            Price = price;
            Quantity = quantity;
            StartTime = startTime;
            ChainId = chainId;
            Currency = currency;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Currency
        /// </summary>
        public enum CurrencyEnum
        {
            /// <summary>
            /// Enum Avax for value: Avax
            /// </summary>
            Avax = 1,

            /// <summary>
            /// Enum Beam for value: Beam
            /// </summary>
            Beam = 2,

            /// <summary>
            /// Enum Eth for value: Eth
            /// </summary>
            Eth = 3,

            /// <summary>
            /// Enum Matic for value: Matic
            /// </summary>
            Matic = 4,

            /// <summary>
            /// Enum Mc for value: Mc
            /// </summary>
            Mc = 5,

            /// <summary>
            /// Enum Usdc for value: Usdc
            /// </summary>
            Usdc = 6,

            /// <summary>
            /// Enum Usdt for value: Usdt
            /// </summary>
            Usdt = 7,

            /// <summary>
            /// Enum Wavax for value: Wavax
            /// </summary>
            Wavax = 8,

            /// <summary>
            /// Enum Wbeam for value: Wbeam
            /// </summary>
            Wbeam = 9,

            /// <summary>
            /// Enum Weth for value: Weth
            /// </summary>
            Weth = 10,

            /// <summary>
            /// Enum Wmatic for value: Wmatic
            /// </summary>
            Wmatic = 11,

            /// <summary>
            /// Enum Wmc for value: Wmc
            /// </summary>
            Wmc = 12
        }

        /// <summary>
        /// Returns a <see cref="CurrencyEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static CurrencyEnum CurrencyEnumFromString(string value)
        {
            if (value.Equals("Avax"))
                return CurrencyEnum.Avax;

            if (value.Equals("Beam"))
                return CurrencyEnum.Beam;

            if (value.Equals("Eth"))
                return CurrencyEnum.Eth;

            if (value.Equals("Matic"))
                return CurrencyEnum.Matic;

            if (value.Equals("Mc"))
                return CurrencyEnum.Mc;

            if (value.Equals("Usdc"))
                return CurrencyEnum.Usdc;

            if (value.Equals("Usdt"))
                return CurrencyEnum.Usdt;

            if (value.Equals("Wavax"))
                return CurrencyEnum.Wavax;

            if (value.Equals("Wbeam"))
                return CurrencyEnum.Wbeam;

            if (value.Equals("Weth"))
                return CurrencyEnum.Weth;

            if (value.Equals("Wmatic"))
                return CurrencyEnum.Wmatic;

            if (value.Equals("Wmc"))
                return CurrencyEnum.Wmc;

            throw new NotImplementedException($"Could not convert value to type CurrencyEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="CurrencyEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CurrencyEnum? CurrencyEnumFromStringOrDefault(string value)
        {
            if (value.Equals("Avax"))
                return CurrencyEnum.Avax;

            if (value.Equals("Beam"))
                return CurrencyEnum.Beam;

            if (value.Equals("Eth"))
                return CurrencyEnum.Eth;

            if (value.Equals("Matic"))
                return CurrencyEnum.Matic;

            if (value.Equals("Mc"))
                return CurrencyEnum.Mc;

            if (value.Equals("Usdc"))
                return CurrencyEnum.Usdc;

            if (value.Equals("Usdt"))
                return CurrencyEnum.Usdt;

            if (value.Equals("Wavax"))
                return CurrencyEnum.Wavax;

            if (value.Equals("Wbeam"))
                return CurrencyEnum.Wbeam;

            if (value.Equals("Weth"))
                return CurrencyEnum.Weth;

            if (value.Equals("Wmatic"))
                return CurrencyEnum.Wmatic;

            if (value.Equals("Wmc"))
                return CurrencyEnum.Wmc;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="CurrencyEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string CurrencyEnumToJsonValue(CurrencyEnum value)
        {

            if (value == CurrencyEnum.Avax)
                return "Avax";

            if (value == CurrencyEnum.Beam)
                return "Beam";

            if (value == CurrencyEnum.Eth)
                return "Eth";

            if (value == CurrencyEnum.Matic)
                return "Matic";

            if (value == CurrencyEnum.Mc)
                return "Mc";

            if (value == CurrencyEnum.Usdc)
                return "Usdc";

            if (value == CurrencyEnum.Usdt)
                return "Usdt";

            if (value == CurrencyEnum.Wavax)
                return "Wavax";

            if (value == CurrencyEnum.Wbeam)
                return "Wbeam";

            if (value == CurrencyEnum.Weth)
                return "Weth";

            if (value == CurrencyEnum.Wmatic)
                return "Wmatic";

            if (value == CurrencyEnum.Wmc)
                return "Wmc";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [JsonPropertyName("currency")]
        public CurrencyEnum Currency { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [JsonPropertyName("endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or Sets MarketplaceId
        /// </summary>
        [JsonPropertyName("marketplaceId")]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [JsonPropertyName("quantity")]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [JsonPropertyName("startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public decimal ChainId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateAssetOfferRequestInput {\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
    /// A Json converter for type <see cref="CreateAssetOfferRequestInput" />
    /// </summary>
    public class CreateAssetOfferRequestInputJsonConverter : JsonConverter<CreateAssetOfferRequestInput>
    {
        /// <summary>
        /// Deserializes json to <see cref="CreateAssetOfferRequestInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CreateAssetOfferRequestInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string endTime = default;
            string marketplaceId = default;
            string price = default;
            decimal? quantity = default;
            string startTime = default;
            decimal? chainId = default;
            CreateAssetOfferRequestInput.CurrencyEnum? currency = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "endTime":
                            endTime = utf8JsonReader.GetString();
                            break;
                        case "marketplaceId":
                            marketplaceId = utf8JsonReader.GetString();
                            break;
                        case "price":
                            price = utf8JsonReader.GetString();
                            break;
                        case "quantity":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                quantity = utf8JsonReader.GetDecimal();
                            break;
                        case "startTime":
                            startTime = utf8JsonReader.GetString();
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = utf8JsonReader.GetDecimal();
                            break;
                        case "currency":
                            string currencyRawValue = utf8JsonReader.GetString();
                            currency = currencyRawValue == null
                                ? null
                                : CreateAssetOfferRequestInput.CurrencyEnumFromStringOrDefault(currencyRawValue);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (endTime == null)
                throw new ArgumentNullException(nameof(endTime), "Property is required for class CreateAssetOfferRequestInput.");

            if (marketplaceId == null)
                throw new ArgumentNullException(nameof(marketplaceId), "Property is required for class CreateAssetOfferRequestInput.");

            if (price == null)
                throw new ArgumentNullException(nameof(price), "Property is required for class CreateAssetOfferRequestInput.");

            if (quantity == null)
                throw new ArgumentNullException(nameof(quantity), "Property is required for class CreateAssetOfferRequestInput.");

            if (startTime == null)
                throw new ArgumentNullException(nameof(startTime), "Property is required for class CreateAssetOfferRequestInput.");

            if (chainId == null)
                throw new ArgumentNullException(nameof(chainId), "Property is required for class CreateAssetOfferRequestInput.");

            if (currency == null)
                throw new ArgumentNullException(nameof(currency), "Property is required for class CreateAssetOfferRequestInput.");

            return new CreateAssetOfferRequestInput(endTime, marketplaceId, price, quantity.Value, startTime, chainId.Value, currency.Value);
        }

        /// <summary>
        /// Serializes a <see cref="CreateAssetOfferRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createAssetOfferRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CreateAssetOfferRequestInput createAssetOfferRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, createAssetOfferRequestInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CreateAssetOfferRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createAssetOfferRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, CreateAssetOfferRequestInput createAssetOfferRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteString("endTime", createAssetOfferRequestInput.EndTime);
            writer.WriteString("marketplaceId", createAssetOfferRequestInput.MarketplaceId);
            writer.WriteString("price", createAssetOfferRequestInput.Price);
            writer.WriteNumber("quantity", createAssetOfferRequestInput.Quantity);
            writer.WriteString("startTime", createAssetOfferRequestInput.StartTime);
            writer.WriteNumber("chainId", createAssetOfferRequestInput.ChainId);

            var currencyRawValue = CreateAssetOfferRequestInput.CurrencyEnumToJsonValue(createAssetOfferRequestInput.Currency);
            if (currencyRawValue != null)
                writer.WriteString("currency", currencyRawValue);
            else
                writer.WriteNull("currency");
        }
    }
}
