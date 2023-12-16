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
using Beam.Client;

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
        /// <param name="marketplaceId">marketplaceId</param>
        /// <param name="price">price</param>
        /// <param name="quantity">quantity</param>
        /// <param name="chainId">chainId (default to 13337M)</param>
        /// <param name="currency">currency (default to CurrencyEnum.Beam)</param>
        /// <param name="endTime">endTime</param>
        /// <param name="startTime">startTime</param>
        [JsonConstructor]
        public CreateAssetOfferRequestInput(string marketplaceId, string price, decimal quantity, Option<decimal?> chainId = default, Option<CurrencyEnum?> currency = default, Option<string> endTime = default, Option<string> startTime = default)
        {
            MarketplaceId = marketplaceId;
            Price = price;
            Quantity = quantity;
            ChainIdOption = chainId;
            CurrencyOption = currency;
            EndTimeOption = endTime;
            StartTimeOption = startTime;
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
        public static string CurrencyEnumToJsonValue(CurrencyEnum? value)
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
        /// Used to track the state of Currency
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<CurrencyEnum?> CurrencyOption { get; private set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [JsonPropertyName("currency")]
        public CurrencyEnum? Currency { get { return this.CurrencyOption; } set { this.CurrencyOption = new(value); } }

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
        /// Used to track the state of ChainId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> ChainIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public decimal? ChainId { get { return this. ChainIdOption; } set { this.ChainIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of EndTime
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> EndTimeOption { get; private set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [JsonPropertyName("endTime")]
        public string EndTime { get { return this. EndTimeOption; } set { this.EndTimeOption = new(value); } }

        /// <summary>
        /// Used to track the state of StartTime
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> StartTimeOption { get; private set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [JsonPropertyName("startTime")]
        public string StartTime { get { return this. StartTimeOption; } set { this.StartTimeOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateAssetOfferRequestInput {\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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

            Option<string> marketplaceId = default;
            Option<string> price = default;
            Option<decimal?> quantity = default;
            Option<decimal?> chainId = default;
            Option<CreateAssetOfferRequestInput.CurrencyEnum?> currency = default;
            Option<string> endTime = default;
            Option<string> startTime = default;

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
                        case "marketplaceId":
                            marketplaceId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "price":
                            price = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "quantity":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                quantity = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "currency":
                            string currencyRawValue = utf8JsonReader.GetString();
                            if (currencyRawValue != null)
                                currency = new Option<CreateAssetOfferRequestInput.CurrencyEnum?>(CreateAssetOfferRequestInput.CurrencyEnumFromStringOrDefault(currencyRawValue));
                            break;
                        case "endTime":
                            endTime = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "startTime":
                            startTime = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!marketplaceId.IsSet)
                throw new ArgumentException("Property is required for class CreateAssetOfferRequestInput.", nameof(marketplaceId));

            if (!price.IsSet)
                throw new ArgumentException("Property is required for class CreateAssetOfferRequestInput.", nameof(price));

            if (!quantity.IsSet)
                throw new ArgumentException("Property is required for class CreateAssetOfferRequestInput.", nameof(quantity));

            if (marketplaceId.IsSet && marketplaceId.Value == null)
                throw new ArgumentNullException(nameof(marketplaceId), "Property is not nullable for class CreateAssetOfferRequestInput.");

            if (price.IsSet && price.Value == null)
                throw new ArgumentNullException(nameof(price), "Property is not nullable for class CreateAssetOfferRequestInput.");

            if (quantity.IsSet && quantity.Value == null)
                throw new ArgumentNullException(nameof(quantity), "Property is not nullable for class CreateAssetOfferRequestInput.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class CreateAssetOfferRequestInput.");

            if (currency.IsSet && currency.Value == null)
                throw new ArgumentNullException(nameof(currency), "Property is not nullable for class CreateAssetOfferRequestInput.");

            if (endTime.IsSet && endTime.Value == null)
                throw new ArgumentNullException(nameof(endTime), "Property is not nullable for class CreateAssetOfferRequestInput.");

            if (startTime.IsSet && startTime.Value == null)
                throw new ArgumentNullException(nameof(startTime), "Property is not nullable for class CreateAssetOfferRequestInput.");

            return new CreateAssetOfferRequestInput(marketplaceId.Value, price.Value, quantity.Value.Value, chainId, currency, endTime, startTime);
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
            if (createAssetOfferRequestInput.MarketplaceId == null)
                throw new ArgumentNullException(nameof(createAssetOfferRequestInput.MarketplaceId), "Property is required for class CreateAssetOfferRequestInput.");

            if (createAssetOfferRequestInput.Price == null)
                throw new ArgumentNullException(nameof(createAssetOfferRequestInput.Price), "Property is required for class CreateAssetOfferRequestInput.");

            if (createAssetOfferRequestInput.EndTimeOption.IsSet && createAssetOfferRequestInput.EndTime == null)
                throw new ArgumentNullException(nameof(createAssetOfferRequestInput.EndTime), "Property is required for class CreateAssetOfferRequestInput.");

            if (createAssetOfferRequestInput.StartTimeOption.IsSet && createAssetOfferRequestInput.StartTime == null)
                throw new ArgumentNullException(nameof(createAssetOfferRequestInput.StartTime), "Property is required for class CreateAssetOfferRequestInput.");

            writer.WriteString("marketplaceId", createAssetOfferRequestInput.MarketplaceId);

            writer.WriteString("price", createAssetOfferRequestInput.Price);

            writer.WriteNumber("quantity", createAssetOfferRequestInput.Quantity);

            if (createAssetOfferRequestInput.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", createAssetOfferRequestInput.ChainIdOption.Value.Value);

            var currencyRawValue = CreateAssetOfferRequestInput.CurrencyEnumToJsonValue(createAssetOfferRequestInput.CurrencyOption.Value.Value);
            writer.WriteString("currency", currencyRawValue);
            if (createAssetOfferRequestInput.EndTimeOption.IsSet)
                writer.WriteString("endTime", createAssetOfferRequestInput.EndTime);

            if (createAssetOfferRequestInput.StartTimeOption.IsSet)
                writer.WriteString("startTime", createAssetOfferRequestInput.StartTime);
        }
    }
}
