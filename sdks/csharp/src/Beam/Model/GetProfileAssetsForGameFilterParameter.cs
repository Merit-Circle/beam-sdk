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
    /// GetProfileAssetsForGameFilterParameter
    /// </summary>
    public partial class GetProfileAssetsForGameFilterParameter : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProfileAssetsForGameFilterParameter" /> class.
        /// </summary>
        /// <param name="attributes">attributes</param>
        /// <param name="currencies">currencies</param>
        /// <param name="rarities">rarities</param>
        /// <param name="sellTypes">sellTypes</param>
        [JsonConstructor]
        public GetProfileAssetsForGameFilterParameter(Option<List<GetProfileAssetsForGameFilterParameterAttributesInner>> attributes = default, Option<List<GetProfileAssetsForGameFilterParameter.CurrenciesEnum>> currencies = default, Option<List<GetProfileAssetsForGameFilterParameter.RaritiesEnum>> rarities = default, Option<List<GetProfileAssetsForGameFilterParameter.SellTypesEnum>> sellTypes = default)
        {
            AttributesOption = attributes;
            CurrenciesOption = currencies;
            RaritiesOption = rarities;
            SellTypesOption = sellTypes;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Currencies
        /// </summary>
        public enum CurrenciesEnum
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
        /// Returns a <see cref="CurrenciesEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static CurrenciesEnum CurrenciesEnumFromString(string value)
        {
            if (value.Equals("Avax"))
                return CurrenciesEnum.Avax;

            if (value.Equals("Beam"))
                return CurrenciesEnum.Beam;

            if (value.Equals("Eth"))
                return CurrenciesEnum.Eth;

            if (value.Equals("Matic"))
                return CurrenciesEnum.Matic;

            if (value.Equals("Mc"))
                return CurrenciesEnum.Mc;

            if (value.Equals("Usdc"))
                return CurrenciesEnum.Usdc;

            if (value.Equals("Usdt"))
                return CurrenciesEnum.Usdt;

            if (value.Equals("Wavax"))
                return CurrenciesEnum.Wavax;

            if (value.Equals("Wbeam"))
                return CurrenciesEnum.Wbeam;

            if (value.Equals("Weth"))
                return CurrenciesEnum.Weth;

            if (value.Equals("Wmatic"))
                return CurrenciesEnum.Wmatic;

            if (value.Equals("Wmc"))
                return CurrenciesEnum.Wmc;

            throw new NotImplementedException($"Could not convert value to type CurrenciesEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="CurrenciesEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CurrenciesEnum? CurrenciesEnumFromStringOrDefault(string value)
        {
            if (value.Equals("Avax"))
                return CurrenciesEnum.Avax;

            if (value.Equals("Beam"))
                return CurrenciesEnum.Beam;

            if (value.Equals("Eth"))
                return CurrenciesEnum.Eth;

            if (value.Equals("Matic"))
                return CurrenciesEnum.Matic;

            if (value.Equals("Mc"))
                return CurrenciesEnum.Mc;

            if (value.Equals("Usdc"))
                return CurrenciesEnum.Usdc;

            if (value.Equals("Usdt"))
                return CurrenciesEnum.Usdt;

            if (value.Equals("Wavax"))
                return CurrenciesEnum.Wavax;

            if (value.Equals("Wbeam"))
                return CurrenciesEnum.Wbeam;

            if (value.Equals("Weth"))
                return CurrenciesEnum.Weth;

            if (value.Equals("Wmatic"))
                return CurrenciesEnum.Wmatic;

            if (value.Equals("Wmc"))
                return CurrenciesEnum.Wmc;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="CurrenciesEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string CurrenciesEnumToJsonValue(CurrenciesEnum value)
        {
            if (value == CurrenciesEnum.Avax)
                return "Avax";

            if (value == CurrenciesEnum.Beam)
                return "Beam";

            if (value == CurrenciesEnum.Eth)
                return "Eth";

            if (value == CurrenciesEnum.Matic)
                return "Matic";

            if (value == CurrenciesEnum.Mc)
                return "Mc";

            if (value == CurrenciesEnum.Usdc)
                return "Usdc";

            if (value == CurrenciesEnum.Usdt)
                return "Usdt";

            if (value == CurrenciesEnum.Wavax)
                return "Wavax";

            if (value == CurrenciesEnum.Wbeam)
                return "Wbeam";

            if (value == CurrenciesEnum.Weth)
                return "Weth";

            if (value == CurrenciesEnum.Wmatic)
                return "Wmatic";

            if (value == CurrenciesEnum.Wmc)
                return "Wmc";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Defines Rarities
        /// </summary>
        public enum RaritiesEnum
        {
            /// <summary>
            /// Enum Common for value: Common
            /// </summary>
            Common = 1,

            /// <summary>
            /// Enum ExtremelyRare for value: ExtremelyRare
            /// </summary>
            ExtremelyRare = 2,

            /// <summary>
            /// Enum Rare for value: Rare
            /// </summary>
            Rare = 3,

            /// <summary>
            /// Enum Uncommon for value: Uncommon
            /// </summary>
            Uncommon = 4,

            /// <summary>
            /// Enum VeryRare for value: VeryRare
            /// </summary>
            VeryRare = 5
        }

        /// <summary>
        /// Returns a <see cref="RaritiesEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static RaritiesEnum RaritiesEnumFromString(string value)
        {
            if (value.Equals("Common"))
                return RaritiesEnum.Common;

            if (value.Equals("ExtremelyRare"))
                return RaritiesEnum.ExtremelyRare;

            if (value.Equals("Rare"))
                return RaritiesEnum.Rare;

            if (value.Equals("Uncommon"))
                return RaritiesEnum.Uncommon;

            if (value.Equals("VeryRare"))
                return RaritiesEnum.VeryRare;

            throw new NotImplementedException($"Could not convert value to type RaritiesEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="RaritiesEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RaritiesEnum? RaritiesEnumFromStringOrDefault(string value)
        {
            if (value.Equals("Common"))
                return RaritiesEnum.Common;

            if (value.Equals("ExtremelyRare"))
                return RaritiesEnum.ExtremelyRare;

            if (value.Equals("Rare"))
                return RaritiesEnum.Rare;

            if (value.Equals("Uncommon"))
                return RaritiesEnum.Uncommon;

            if (value.Equals("VeryRare"))
                return RaritiesEnum.VeryRare;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="RaritiesEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string RaritiesEnumToJsonValue(RaritiesEnum value)
        {
            if (value == RaritiesEnum.Common)
                return "Common";

            if (value == RaritiesEnum.ExtremelyRare)
                return "ExtremelyRare";

            if (value == RaritiesEnum.Rare)
                return "Rare";

            if (value == RaritiesEnum.Uncommon)
                return "Uncommon";

            if (value == RaritiesEnum.VeryRare)
                return "VeryRare";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Defines SellTypes
        /// </summary>
        public enum SellTypesEnum
        {
            /// <summary>
            /// Enum AscendingAuction for value: AscendingAuction
            /// </summary>
            AscendingAuction = 1,

            /// <summary>
            /// Enum DescendingAuction for value: DescendingAuction
            /// </summary>
            DescendingAuction = 2,

            /// <summary>
            /// Enum FixedPrice for value: FixedPrice
            /// </summary>
            FixedPrice = 3,

            /// <summary>
            /// Enum NotForSale for value: NotForSale
            /// </summary>
            NotForSale = 4
        }

        /// <summary>
        /// Returns a <see cref="SellTypesEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static SellTypesEnum SellTypesEnumFromString(string value)
        {
            if (value.Equals("AscendingAuction"))
                return SellTypesEnum.AscendingAuction;

            if (value.Equals("DescendingAuction"))
                return SellTypesEnum.DescendingAuction;

            if (value.Equals("FixedPrice"))
                return SellTypesEnum.FixedPrice;

            if (value.Equals("NotForSale"))
                return SellTypesEnum.NotForSale;

            throw new NotImplementedException($"Could not convert value to type SellTypesEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="SellTypesEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static SellTypesEnum? SellTypesEnumFromStringOrDefault(string value)
        {
            if (value.Equals("AscendingAuction"))
                return SellTypesEnum.AscendingAuction;

            if (value.Equals("DescendingAuction"))
                return SellTypesEnum.DescendingAuction;

            if (value.Equals("FixedPrice"))
                return SellTypesEnum.FixedPrice;

            if (value.Equals("NotForSale"))
                return SellTypesEnum.NotForSale;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="SellTypesEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string SellTypesEnumToJsonValue(SellTypesEnum value)
        {
            if (value == SellTypesEnum.AscendingAuction)
                return "AscendingAuction";

            if (value == SellTypesEnum.DescendingAuction)
                return "DescendingAuction";

            if (value == SellTypesEnum.FixedPrice)
                return "FixedPrice";

            if (value == SellTypesEnum.NotForSale)
                return "NotForSale";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Used to track the state of Attributes
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<GetProfileAssetsForGameFilterParameterAttributesInner>> AttributesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [JsonPropertyName("attributes")]
        public List<GetProfileAssetsForGameFilterParameterAttributesInner> Attributes { get { return this. AttributesOption; } set { this.AttributesOption = new(value); } }

        /// <summary>
        /// Used to track the state of Currencies
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<GetProfileAssetsForGameFilterParameter.CurrenciesEnum>> CurrenciesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Currencies
        /// </summary>
        [JsonPropertyName("currencies")]
        public List<GetProfileAssetsForGameFilterParameter.CurrenciesEnum> Currencies { get { return this. CurrenciesOption; } set { this.CurrenciesOption = new(value); } }

        /// <summary>
        /// Used to track the state of Rarities
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<GetProfileAssetsForGameFilterParameter.RaritiesEnum>> RaritiesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Rarities
        /// </summary>
        [JsonPropertyName("rarities")]
        public List<GetProfileAssetsForGameFilterParameter.RaritiesEnum> Rarities { get { return this. RaritiesOption; } set { this.RaritiesOption = new(value); } }

        /// <summary>
        /// Used to track the state of SellTypes
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<GetProfileAssetsForGameFilterParameter.SellTypesEnum>> SellTypesOption { get; private set; }

        /// <summary>
        /// Gets or Sets SellTypes
        /// </summary>
        [JsonPropertyName("sellTypes")]
        public List<GetProfileAssetsForGameFilterParameter.SellTypesEnum> SellTypes { get { return this. SellTypesOption; } set { this.SellTypesOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetProfileAssetsForGameFilterParameter {\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Currencies: ").Append(Currencies).Append("\n");
            sb.Append("  Rarities: ").Append(Rarities).Append("\n");
            sb.Append("  SellTypes: ").Append(SellTypes).Append("\n");
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
    /// A Json converter for type <see cref="GetProfileAssetsForGameFilterParameter" />
    /// </summary>
    public class GetProfileAssetsForGameFilterParameterJsonConverter : JsonConverter<GetProfileAssetsForGameFilterParameter>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetProfileAssetsForGameFilterParameter" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetProfileAssetsForGameFilterParameter Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<GetProfileAssetsForGameFilterParameterAttributesInner>> attributes = default;
            Option<List<GetProfileAssetsForGameFilterParameter.CurrenciesEnum>> currencies = default;
            Option<List<GetProfileAssetsForGameFilterParameter.RaritiesEnum>> rarities = default;
            Option<List<GetProfileAssetsForGameFilterParameter.SellTypesEnum>> sellTypes = default;

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
                        case "attributes":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                attributes = new Option<List<GetProfileAssetsForGameFilterParameterAttributesInner>>(JsonSerializer.Deserialize<List<GetProfileAssetsForGameFilterParameterAttributesInner>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "currencies":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                currencies = new Option<List<GetProfileAssetsForGameFilterParameter.CurrenciesEnum>>(JsonSerializer.Deserialize<List<GetProfileAssetsForGameFilterParameter.CurrenciesEnum>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "rarities":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                rarities = new Option<List<GetProfileAssetsForGameFilterParameter.RaritiesEnum>>(JsonSerializer.Deserialize<List<GetProfileAssetsForGameFilterParameter.RaritiesEnum>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "sellTypes":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                sellTypes = new Option<List<GetProfileAssetsForGameFilterParameter.SellTypesEnum>>(JsonSerializer.Deserialize<List<GetProfileAssetsForGameFilterParameter.SellTypesEnum>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            return new GetProfileAssetsForGameFilterParameter(attributes, currencies, rarities, sellTypes);
        }

        /// <summary>
        /// Serializes a <see cref="GetProfileAssetsForGameFilterParameter" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getProfileAssetsForGameFilterParameter"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetProfileAssetsForGameFilterParameter getProfileAssetsForGameFilterParameter, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getProfileAssetsForGameFilterParameter, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetProfileAssetsForGameFilterParameter" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getProfileAssetsForGameFilterParameter"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetProfileAssetsForGameFilterParameter getProfileAssetsForGameFilterParameter, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getProfileAssetsForGameFilterParameter.AttributesOption.IsSet)
                if (getProfileAssetsForGameFilterParameter.AttributesOption.Value != null)
                {
                    writer.WritePropertyName("attributes");
                    JsonSerializer.Serialize(writer, getProfileAssetsForGameFilterParameter.Attributes, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("attributes");
            if (getProfileAssetsForGameFilterParameter.CurrenciesOption.IsSet)
                if (getProfileAssetsForGameFilterParameter.CurrenciesOption.Value != null)
                {
                    writer.WritePropertyName("currencies");
                    JsonSerializer.Serialize(writer, getProfileAssetsForGameFilterParameter.Currencies, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("currencies");
            if (getProfileAssetsForGameFilterParameter.RaritiesOption.IsSet)
                if (getProfileAssetsForGameFilterParameter.RaritiesOption.Value != null)
                {
                    writer.WritePropertyName("rarities");
                    JsonSerializer.Serialize(writer, getProfileAssetsForGameFilterParameter.Rarities, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("rarities");
            if (getProfileAssetsForGameFilterParameter.SellTypesOption.IsSet)
                if (getProfileAssetsForGameFilterParameter.SellTypesOption.Value != null)
                {
                    writer.WritePropertyName("sellTypes");
                    JsonSerializer.Serialize(writer, getProfileAssetsForGameFilterParameter.SellTypes, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("sellTypes");
        }
    }
}
