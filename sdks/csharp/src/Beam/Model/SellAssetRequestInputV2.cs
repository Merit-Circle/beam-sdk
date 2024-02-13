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
    /// SellAssetRequestInputV2
    /// </summary>
    public partial class SellAssetRequestInputV2 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SellAssetRequestInputV2" /> class.
        /// </summary>
        /// <param name="assetAddress">assetAddress</param>
        /// <param name="assetId">assetId</param>
        /// <param name="price">price</param>
        /// <param name="quantity">quantity</param>
        /// <param name="sellType">sellType</param>
        /// <param name="chainId">chainId (default to 13337M)</param>
        /// <param name="currency">currency (default to CurrencyEnum.BEAM)</param>
        /// <param name="endTime">Date time string with YYYY-MM-DDTHH:mm:ss.sssZ format or Unix timestamp in milliseconds</param>
        /// <param name="policyId">policyId</param>
        /// <param name="sponsor">sponsor (default to true)</param>
        /// <param name="startTime">Date time string with YYYY-MM-DDTHH:mm:ss.sssZ format or Unix timestamp in milliseconds</param>
        [JsonConstructor]
        public SellAssetRequestInputV2(string assetAddress, string assetId, string price, decimal quantity, SellTypeEnum sellType, Option<decimal?> chainId = default, Option<CurrencyEnum?> currency = default, Option<string> endTime = default, Option<string> policyId = default, Option<bool?> sponsor = default, Option<string> startTime = default)
        {
            AssetAddress = assetAddress;
            AssetId = assetId;
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
            /// Enum BEAM for value: BEAM
            /// </summary>
            BEAM = 1,

            /// <summary>
            /// Enum WBEAM for value: WBEAM
            /// </summary>
            WBEAM = 2,

            /// <summary>
            /// Enum USDC for value: USDC
            /// </summary>
            USDC = 3,

            /// <summary>
            /// Enum USDT for value: USDT
            /// </summary>
            USDT = 4,

            /// <summary>
            /// Enum IMX for value: IMX
            /// </summary>
            IMX = 5
        }

        /// <summary>
        /// Returns a <see cref="CurrencyEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static CurrencyEnum CurrencyEnumFromString(string value)
        {
            if (value.Equals("BEAM"))
                return CurrencyEnum.BEAM;

            if (value.Equals("WBEAM"))
                return CurrencyEnum.WBEAM;

            if (value.Equals("USDC"))
                return CurrencyEnum.USDC;

            if (value.Equals("USDT"))
                return CurrencyEnum.USDT;

            if (value.Equals("IMX"))
                return CurrencyEnum.IMX;

            throw new NotImplementedException($"Could not convert value to type CurrencyEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="CurrencyEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CurrencyEnum? CurrencyEnumFromStringOrDefault(string value)
        {
            if (value.Equals("BEAM"))
                return CurrencyEnum.BEAM;

            if (value.Equals("WBEAM"))
                return CurrencyEnum.WBEAM;

            if (value.Equals("USDC"))
                return CurrencyEnum.USDC;

            if (value.Equals("USDT"))
                return CurrencyEnum.USDT;

            if (value.Equals("IMX"))
                return CurrencyEnum.IMX;

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
            if (value == CurrencyEnum.BEAM)
                return "BEAM";

            if (value == CurrencyEnum.WBEAM)
                return "WBEAM";

            if (value == CurrencyEnum.USDC)
                return "USDC";

            if (value == CurrencyEnum.USDT)
                return "USDT";

            if (value == CurrencyEnum.IMX)
                return "IMX";

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
        /// Gets or Sets AssetAddress
        /// </summary>
        [JsonPropertyName("assetAddress")]
        public string AssetAddress { get; set; }

        /// <summary>
        /// Gets or Sets AssetId
        /// </summary>
        [JsonPropertyName("assetId")]
        public string AssetId { get; set; }

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
        /// Date time string with YYYY-MM-DDTHH:mm:ss.sssZ format or Unix timestamp in milliseconds
        /// </summary>
        /// <value>Date time string with YYYY-MM-DDTHH:mm:ss.sssZ format or Unix timestamp in milliseconds</value>
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
        /// Date time string with YYYY-MM-DDTHH:mm:ss.sssZ format or Unix timestamp in milliseconds
        /// </summary>
        /// <value>Date time string with YYYY-MM-DDTHH:mm:ss.sssZ format or Unix timestamp in milliseconds</value>
        [JsonPropertyName("startTime")]
        public string StartTime { get { return this. StartTimeOption; } set { this.StartTimeOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SellAssetRequestInputV2 {\n");
            sb.Append("  AssetAddress: ").Append(AssetAddress).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
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
    /// A Json converter for type <see cref="SellAssetRequestInputV2" />
    /// </summary>
    public class SellAssetRequestInputV2JsonConverter : JsonConverter<SellAssetRequestInputV2>
    {
        /// <summary>
        /// Deserializes json to <see cref="SellAssetRequestInputV2" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override SellAssetRequestInputV2 Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> assetAddress = default;
            Option<string> assetId = default;
            Option<string> price = default;
            Option<decimal?> quantity = default;
            Option<SellAssetRequestInputV2.SellTypeEnum?> sellType = default;
            Option<decimal?> chainId = default;
            Option<SellAssetRequestInputV2.CurrencyEnum?> currency = default;
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
                        case "assetAddress":
                            assetAddress = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "assetId":
                            assetId = new Option<string>(utf8JsonReader.GetString());
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
                                sellType = new Option<SellAssetRequestInputV2.SellTypeEnum?>(SellAssetRequestInputV2.SellTypeEnumFromStringOrDefault(sellTypeRawValue));
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "currency":
                            string currencyRawValue = utf8JsonReader.GetString();
                            if (currencyRawValue != null)
                                currency = new Option<SellAssetRequestInputV2.CurrencyEnum?>(SellAssetRequestInputV2.CurrencyEnumFromStringOrDefault(currencyRawValue));
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

            if (!assetAddress.IsSet)
                throw new ArgumentException("Property is required for class SellAssetRequestInputV2.", nameof(assetAddress));

            if (!assetId.IsSet)
                throw new ArgumentException("Property is required for class SellAssetRequestInputV2.", nameof(assetId));

            if (!price.IsSet)
                throw new ArgumentException("Property is required for class SellAssetRequestInputV2.", nameof(price));

            if (!quantity.IsSet)
                throw new ArgumentException("Property is required for class SellAssetRequestInputV2.", nameof(quantity));

            if (!sellType.IsSet)
                throw new ArgumentException("Property is required for class SellAssetRequestInputV2.", nameof(sellType));

            if (assetAddress.IsSet && assetAddress.Value == null)
                throw new ArgumentNullException(nameof(assetAddress), "Property is not nullable for class SellAssetRequestInputV2.");

            if (assetId.IsSet && assetId.Value == null)
                throw new ArgumentNullException(nameof(assetId), "Property is not nullable for class SellAssetRequestInputV2.");

            if (price.IsSet && price.Value == null)
                throw new ArgumentNullException(nameof(price), "Property is not nullable for class SellAssetRequestInputV2.");

            if (quantity.IsSet && quantity.Value == null)
                throw new ArgumentNullException(nameof(quantity), "Property is not nullable for class SellAssetRequestInputV2.");

            if (sellType.IsSet && sellType.Value == null)
                throw new ArgumentNullException(nameof(sellType), "Property is not nullable for class SellAssetRequestInputV2.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class SellAssetRequestInputV2.");

            if (currency.IsSet && currency.Value == null)
                throw new ArgumentNullException(nameof(currency), "Property is not nullable for class SellAssetRequestInputV2.");

            if (sponsor.IsSet && sponsor.Value == null)
                throw new ArgumentNullException(nameof(sponsor), "Property is not nullable for class SellAssetRequestInputV2.");

            return new SellAssetRequestInputV2(assetAddress.Value, assetId.Value, price.Value, quantity.Value.Value, sellType.Value.Value, chainId, currency, endTime, policyId, sponsor, startTime);
        }

        /// <summary>
        /// Serializes a <see cref="SellAssetRequestInputV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="sellAssetRequestInputV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, SellAssetRequestInputV2 sellAssetRequestInputV2, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, sellAssetRequestInputV2, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="SellAssetRequestInputV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="sellAssetRequestInputV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, SellAssetRequestInputV2 sellAssetRequestInputV2, JsonSerializerOptions jsonSerializerOptions)
        {
            if (sellAssetRequestInputV2.AssetAddress == null)
                throw new ArgumentNullException(nameof(sellAssetRequestInputV2.AssetAddress), "Property is required for class SellAssetRequestInputV2.");

            if (sellAssetRequestInputV2.AssetId == null)
                throw new ArgumentNullException(nameof(sellAssetRequestInputV2.AssetId), "Property is required for class SellAssetRequestInputV2.");

            if (sellAssetRequestInputV2.Price == null)
                throw new ArgumentNullException(nameof(sellAssetRequestInputV2.Price), "Property is required for class SellAssetRequestInputV2.");

            writer.WriteString("assetAddress", sellAssetRequestInputV2.AssetAddress);

            writer.WriteString("assetId", sellAssetRequestInputV2.AssetId);

            writer.WriteString("price", sellAssetRequestInputV2.Price);

            writer.WriteNumber("quantity", sellAssetRequestInputV2.Quantity);

            var sellTypeRawValue = SellAssetRequestInputV2.SellTypeEnumToJsonValue(sellAssetRequestInputV2.SellType);
            writer.WriteString("sellType", sellTypeRawValue);
            if (sellAssetRequestInputV2.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", sellAssetRequestInputV2.ChainIdOption.Value.Value);

            var currencyRawValue = SellAssetRequestInputV2.CurrencyEnumToJsonValue(sellAssetRequestInputV2.CurrencyOption.Value.Value);
            writer.WriteString("currency", currencyRawValue);
            if (sellAssetRequestInputV2.EndTimeOption.IsSet)
                if (sellAssetRequestInputV2.EndTimeOption.Value != null)
                    writer.WriteString("endTime", sellAssetRequestInputV2.EndTime);
                else
                    writer.WriteNull("endTime");

            if (sellAssetRequestInputV2.PolicyIdOption.IsSet)
                if (sellAssetRequestInputV2.PolicyIdOption.Value != null)
                    writer.WriteString("policyId", sellAssetRequestInputV2.PolicyId);
                else
                    writer.WriteNull("policyId");

            if (sellAssetRequestInputV2.SponsorOption.IsSet)
                writer.WriteBoolean("sponsor", sellAssetRequestInputV2.SponsorOption.Value.Value);

            if (sellAssetRequestInputV2.StartTimeOption.IsSet)
                if (sellAssetRequestInputV2.StartTimeOption.Value != null)
                    writer.WriteString("startTime", sellAssetRequestInputV2.StartTime);
                else
                    writer.WriteNull("startTime");
        }
    }
}
