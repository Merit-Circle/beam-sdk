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
    /// SellAssetRequestInput
    /// </summary>
    public partial class SellAssetRequestInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SellAssetRequestInput" /> class.
        /// </summary>
        /// <param name="marketplaceId">marketplaceId</param>
        /// <param name="price">price</param>
        /// <param name="quantity">quantity</param>
        /// <param name="sellType">sellType</param>
        /// <param name="chainId">chainId (default to 13337M)</param>
        /// <param name="currency">currency (default to CurrencyEnum.Beam)</param>
        /// <param name="endTime">endTime</param>
        /// <param name="policyId">policyId</param>
        /// <param name="sponsor">sponsor (default to true)</param>
        /// <param name="startTime">startTime</param>
        [JsonConstructor]
        public SellAssetRequestInput(string marketplaceId, string price, decimal quantity, SellTypeEnum sellType, Option<decimal?> chainId = default, Option<CurrencyEnum?> currency = default, Option<string> endTime = default, Option<string> policyId = default, Option<bool?> sponsor = default, Option<string> startTime = default)
        {
            MarketplaceId = marketplaceId;
            Price = price;
            Quantity = quantity;
            SellType = sellType;
            ChainIdOption = chainId;
            CurrencyOption = currency;
            EndTimeOption = endTime;
            PolicyIdOption = policyId;
            SponsorOption = sponsor;
            StartTimeOption = startTime;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines SellType
        /// </summary>
        public enum SellTypeEnum
        {
            /// <summary>
            /// Enum FixedPrice for value: FixedPrice
            /// </summary>
            FixedPrice = 1,

            /// <summary>
            /// Enum DescendingAuction for value: DescendingAuction
            /// </summary>
            DescendingAuction = 2,

            /// <summary>
            /// Enum AscendingAuction for value: AscendingAuction
            /// </summary>
            AscendingAuction = 3,

            /// <summary>
            /// Enum NotForSale for value: NotForSale
            /// </summary>
            NotForSale = 4
        }

        /// <summary>
        /// Returns a <see cref="SellTypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static SellTypeEnum SellTypeEnumFromString(string value)
        {
            if (value.Equals("FixedPrice"))
                return SellTypeEnum.FixedPrice;

            if (value.Equals("DescendingAuction"))
                return SellTypeEnum.DescendingAuction;

            if (value.Equals("AscendingAuction"))
                return SellTypeEnum.AscendingAuction;

            if (value.Equals("NotForSale"))
                return SellTypeEnum.NotForSale;

            throw new NotImplementedException($"Could not convert value to type SellTypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="SellTypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static SellTypeEnum? SellTypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("FixedPrice"))
                return SellTypeEnum.FixedPrice;

            if (value.Equals("DescendingAuction"))
                return SellTypeEnum.DescendingAuction;

            if (value.Equals("AscendingAuction"))
                return SellTypeEnum.AscendingAuction;

            if (value.Equals("NotForSale"))
                return SellTypeEnum.NotForSale;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="SellTypeEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string SellTypeEnumToJsonValue(SellTypeEnum value)
        {
            if (value == SellTypeEnum.FixedPrice)
                return "FixedPrice";

            if (value == SellTypeEnum.DescendingAuction)
                return "DescendingAuction";

            if (value == SellTypeEnum.AscendingAuction)
                return "AscendingAuction";

            if (value == SellTypeEnum.NotForSale)
                return "NotForSale";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets SellType
        /// </summary>
        [JsonPropertyName("sellType")]
        public SellTypeEnum SellType { get; set; }

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
        /// Used to track the state of PolicyId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> PolicyIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets PolicyId
        /// </summary>
        [JsonPropertyName("policyId")]
        public string PolicyId { get { return this. PolicyIdOption; } set { this.PolicyIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of Sponsor
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> SponsorOption { get; private set; }

        /// <summary>
        /// Gets or Sets Sponsor
        /// </summary>
        [JsonPropertyName("sponsor")]
        public bool? Sponsor { get { return this. SponsorOption; } set { this.SponsorOption = new(value); } }

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
            sb.Append("class SellAssetRequestInput {\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  SellType: ").Append(SellType).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
            sb.Append("  Sponsor: ").Append(Sponsor).Append("\n");
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
    /// A Json converter for type <see cref="SellAssetRequestInput" />
    /// </summary>
    public class SellAssetRequestInputJsonConverter : JsonConverter<SellAssetRequestInput>
    {
        /// <summary>
        /// Deserializes json to <see cref="SellAssetRequestInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override SellAssetRequestInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> marketplaceId = default;
            Option<string> price = default;
            Option<decimal?> quantity = default;
            Option<SellAssetRequestInput.SellTypeEnum?> sellType = default;
            Option<decimal?> chainId = default;
            Option<SellAssetRequestInput.CurrencyEnum?> currency = default;
            Option<string> endTime = default;
            Option<string> policyId = default;
            Option<bool?> sponsor = default;
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
                        case "sellType":
                            string sellTypeRawValue = utf8JsonReader.GetString();
                            if (sellTypeRawValue != null)
                                sellType = new Option<SellAssetRequestInput.SellTypeEnum?>(SellAssetRequestInput.SellTypeEnumFromStringOrDefault(sellTypeRawValue));
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "currency":
                            string currencyRawValue = utf8JsonReader.GetString();
                            if (currencyRawValue != null)
                                currency = new Option<SellAssetRequestInput.CurrencyEnum?>(SellAssetRequestInput.CurrencyEnumFromStringOrDefault(currencyRawValue));
                            break;
                        case "endTime":
                            endTime = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "policyId":
                            policyId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "sponsor":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                sponsor = new Option<bool?>(utf8JsonReader.GetBoolean());
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
                throw new ArgumentException("Property is required for class SellAssetRequestInput.", nameof(marketplaceId));

            if (!price.IsSet)
                throw new ArgumentException("Property is required for class SellAssetRequestInput.", nameof(price));

            if (!quantity.IsSet)
                throw new ArgumentException("Property is required for class SellAssetRequestInput.", nameof(quantity));

            if (!sellType.IsSet)
                throw new ArgumentException("Property is required for class SellAssetRequestInput.", nameof(sellType));

            if (marketplaceId.IsSet && marketplaceId.Value == null)
                throw new ArgumentNullException(nameof(marketplaceId), "Property is not nullable for class SellAssetRequestInput.");

            if (price.IsSet && price.Value == null)
                throw new ArgumentNullException(nameof(price), "Property is not nullable for class SellAssetRequestInput.");

            if (quantity.IsSet && quantity.Value == null)
                throw new ArgumentNullException(nameof(quantity), "Property is not nullable for class SellAssetRequestInput.");

            if (sellType.IsSet && sellType.Value == null)
                throw new ArgumentNullException(nameof(sellType), "Property is not nullable for class SellAssetRequestInput.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class SellAssetRequestInput.");

            if (currency.IsSet && currency.Value == null)
                throw new ArgumentNullException(nameof(currency), "Property is not nullable for class SellAssetRequestInput.");

            if (endTime.IsSet && endTime.Value == null)
                throw new ArgumentNullException(nameof(endTime), "Property is not nullable for class SellAssetRequestInput.");

            if (sponsor.IsSet && sponsor.Value == null)
                throw new ArgumentNullException(nameof(sponsor), "Property is not nullable for class SellAssetRequestInput.");

            if (startTime.IsSet && startTime.Value == null)
                throw new ArgumentNullException(nameof(startTime), "Property is not nullable for class SellAssetRequestInput.");

            return new SellAssetRequestInput(marketplaceId.Value, price.Value, quantity.Value.Value, sellType.Value.Value, chainId, currency, endTime, policyId, sponsor, startTime);
        }

        /// <summary>
        /// Serializes a <see cref="SellAssetRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="sellAssetRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, SellAssetRequestInput sellAssetRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, sellAssetRequestInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="SellAssetRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="sellAssetRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, SellAssetRequestInput sellAssetRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            if (sellAssetRequestInput.MarketplaceId == null)
                throw new ArgumentNullException(nameof(sellAssetRequestInput.MarketplaceId), "Property is required for class SellAssetRequestInput.");

            if (sellAssetRequestInput.Price == null)
                throw new ArgumentNullException(nameof(sellAssetRequestInput.Price), "Property is required for class SellAssetRequestInput.");

            if (sellAssetRequestInput.EndTimeOption.IsSet && sellAssetRequestInput.EndTime == null)
                throw new ArgumentNullException(nameof(sellAssetRequestInput.EndTime), "Property is required for class SellAssetRequestInput.");

            if (sellAssetRequestInput.StartTimeOption.IsSet && sellAssetRequestInput.StartTime == null)
                throw new ArgumentNullException(nameof(sellAssetRequestInput.StartTime), "Property is required for class SellAssetRequestInput.");

            writer.WriteString("marketplaceId", sellAssetRequestInput.MarketplaceId);

            writer.WriteString("price", sellAssetRequestInput.Price);

            writer.WriteNumber("quantity", sellAssetRequestInput.Quantity);

            var sellTypeRawValue = SellAssetRequestInput.SellTypeEnumToJsonValue(sellAssetRequestInput.SellType);
            writer.WriteString("sellType", sellTypeRawValue);
            if (sellAssetRequestInput.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", sellAssetRequestInput.ChainIdOption.Value.Value);

            var currencyRawValue = SellAssetRequestInput.CurrencyEnumToJsonValue(sellAssetRequestInput.CurrencyOption.Value.Value);
            writer.WriteString("currency", currencyRawValue);
            if (sellAssetRequestInput.EndTimeOption.IsSet)
                writer.WriteString("endTime", sellAssetRequestInput.EndTime);

            if (sellAssetRequestInput.PolicyIdOption.IsSet)
                if (sellAssetRequestInput.PolicyIdOption.Value != null)
                    writer.WriteString("policyId", sellAssetRequestInput.PolicyId);
                else
                    writer.WriteNull("policyId");

            if (sellAssetRequestInput.SponsorOption.IsSet)
                writer.WriteBoolean("sponsor", sellAssetRequestInput.SponsorOption.Value.Value);

            if (sellAssetRequestInput.StartTimeOption.IsSet)
                writer.WriteString("startTime", sellAssetRequestInput.StartTime);
        }
    }
}
