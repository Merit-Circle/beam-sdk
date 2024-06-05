// <auto-generated>
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
using OpenAPIClientUtils = BeamAutomationClient.Client.ClientUtils;
using BeamAutomationClient.Client;

namespace BeamAutomationClient.Model
{
    /// <summary>
    /// GetAssetsForProfileResponseV2DataInner
    /// </summary>
    public partial class GetAssetsForProfileResponseV2DataInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetsForProfileResponseV2DataInner" /> class.
        /// </summary>
        /// <param name="assetAddress">assetAddress</param>
        /// <param name="assetId">assetId</param>
        /// <param name="assetType">assetType</param>
        /// <param name="imageUrl">imageUrl</param>
        /// <param name="name">name</param>
        /// <param name="ownedQuantity">ownedQuantity</param>
        /// <param name="supply">supply</param>
        /// <param name="attributes">attributes</param>
        /// <param name="chainId">chainId (default to 13337M)</param>
        /// <param name="rarity">rarity</param>
        /// <param name="rarityScore">rarityScore</param>
        [JsonConstructor]
        public GetAssetsForProfileResponseV2DataInner(string assetAddress, string assetId, string assetType, string imageUrl, string name, decimal ownedQuantity, decimal supply, Option<List<GetAssetsForProfileResponseV2DataInnerAttributesInner>?> attributes = default, Option<decimal?> chainId = default, Option<RarityEnum?> rarity = default, Option<decimal?> rarityScore = default)
        {
            AssetAddress = assetAddress;
            AssetId = assetId;
            AssetType = assetType;
            ImageUrl = imageUrl;
            Name = name;
            OwnedQuantity = ownedQuantity;
            Supply = supply;
            AttributesOption = attributes;
            ChainIdOption = chainId;
            RarityOption = rarity;
            RarityScoreOption = rarityScore;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Rarity
        /// </summary>
        public enum RarityEnum
        {
            /// <summary>
            /// Enum Common for value: Common
            /// </summary>
            Common = 1,

            /// <summary>
            /// Enum Uncommon for value: Uncommon
            /// </summary>
            Uncommon = 2,

            /// <summary>
            /// Enum Rare for value: Rare
            /// </summary>
            Rare = 3,

            /// <summary>
            /// Enum VeryRare for value: VeryRare
            /// </summary>
            VeryRare = 4,

            /// <summary>
            /// Enum ExtremelyRare for value: ExtremelyRare
            /// </summary>
            ExtremelyRare = 5
        }

        /// <summary>
        /// Returns a <see cref="RarityEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static RarityEnum RarityEnumFromString(string value)
        {
            if (value.Equals("Common"))
                return RarityEnum.Common;

            if (value.Equals("Uncommon"))
                return RarityEnum.Uncommon;

            if (value.Equals("Rare"))
                return RarityEnum.Rare;

            if (value.Equals("VeryRare"))
                return RarityEnum.VeryRare;

            if (value.Equals("ExtremelyRare"))
                return RarityEnum.ExtremelyRare;

            throw new NotImplementedException($"Could not convert value to type RarityEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="RarityEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RarityEnum? RarityEnumFromStringOrDefault(string value)
        {
            if (value.Equals("Common"))
                return RarityEnum.Common;

            if (value.Equals("Uncommon"))
                return RarityEnum.Uncommon;

            if (value.Equals("Rare"))
                return RarityEnum.Rare;

            if (value.Equals("VeryRare"))
                return RarityEnum.VeryRare;

            if (value.Equals("ExtremelyRare"))
                return RarityEnum.ExtremelyRare;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="RarityEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string? RarityEnumToJsonValue(RarityEnum? value)
        {
            if (value == null)
                return null;

            if (value == RarityEnum.Common)
                return "Common";

            if (value == RarityEnum.Uncommon)
                return "Uncommon";

            if (value == RarityEnum.Rare)
                return "Rare";

            if (value == RarityEnum.VeryRare)
                return "VeryRare";

            if (value == RarityEnum.ExtremelyRare)
                return "ExtremelyRare";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Used to track the state of Rarity
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<RarityEnum?> RarityOption { get; private set; }

        /// <summary>
        /// Gets or Sets Rarity
        /// </summary>
        [JsonPropertyName("rarity")]
        public RarityEnum? Rarity { get { return this.RarityOption; } set { this.RarityOption = new(value); } }

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
        /// Gets or Sets AssetType
        /// </summary>
        [JsonPropertyName("assetType")]
        public string AssetType { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OwnedQuantity
        /// </summary>
        [JsonPropertyName("ownedQuantity")]
        public decimal OwnedQuantity { get; set; }

        /// <summary>
        /// Gets or Sets Supply
        /// </summary>
        [JsonPropertyName("supply")]
        public decimal Supply { get; set; }

        /// <summary>
        /// Used to track the state of Attributes
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<GetAssetsForProfileResponseV2DataInnerAttributesInner>?> AttributesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [JsonPropertyName("attributes")]
        public List<GetAssetsForProfileResponseV2DataInnerAttributesInner>? Attributes { get { return this. AttributesOption; } set { this.AttributesOption = new(value); } }

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
        /// Used to track the state of RarityScore
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> RarityScoreOption { get; private set; }

        /// <summary>
        /// Gets or Sets RarityScore
        /// </summary>
        [JsonPropertyName("rarityScore")]
        public decimal? RarityScore { get { return this. RarityScoreOption; } set { this.RarityScoreOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAssetsForProfileResponseV2DataInner {\n");
            sb.Append("  AssetAddress: ").Append(AssetAddress).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  AssetType: ").Append(AssetType).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OwnedQuantity: ").Append(OwnedQuantity).Append("\n");
            sb.Append("  Supply: ").Append(Supply).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Rarity: ").Append(Rarity).Append("\n");
            sb.Append("  RarityScore: ").Append(RarityScore).Append("\n");
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
    /// A Json converter for type <see cref="GetAssetsForProfileResponseV2DataInner" />
    /// </summary>
    public class GetAssetsForProfileResponseV2DataInnerJsonConverter : JsonConverter<GetAssetsForProfileResponseV2DataInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetAssetsForProfileResponseV2DataInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetAssetsForProfileResponseV2DataInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> assetAddress = default;
            Option<string?> assetId = default;
            Option<string?> assetType = default;
            Option<string?> imageUrl = default;
            Option<string?> name = default;
            Option<decimal?> ownedQuantity = default;
            Option<decimal?> supply = default;
            Option<List<GetAssetsForProfileResponseV2DataInnerAttributesInner>?> attributes = default;
            Option<decimal?> chainId = default;
            Option<GetAssetsForProfileResponseV2DataInner.RarityEnum?> rarity = default;
            Option<decimal?> rarityScore = default;

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
                        case "assetAddress":
                            assetAddress = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "assetId":
                            assetId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "assetType":
                            assetType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "imageUrl":
                            imageUrl = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "ownedQuantity":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                ownedQuantity = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "supply":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                supply = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "attributes":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                attributes = new Option<List<GetAssetsForProfileResponseV2DataInnerAttributesInner>?>(JsonSerializer.Deserialize<List<GetAssetsForProfileResponseV2DataInnerAttributesInner>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "rarity":
                            string? rarityRawValue = utf8JsonReader.GetString();
                            if (rarityRawValue != null)
                                rarity = new Option<GetAssetsForProfileResponseV2DataInner.RarityEnum?>(GetAssetsForProfileResponseV2DataInner.RarityEnumFromStringOrDefault(rarityRawValue));
                            break;
                        case "rarityScore":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                rarityScore = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!assetAddress.IsSet)
                throw new ArgumentException("Property is required for class GetAssetsForProfileResponseV2DataInner.", nameof(assetAddress));

            if (!assetId.IsSet)
                throw new ArgumentException("Property is required for class GetAssetsForProfileResponseV2DataInner.", nameof(assetId));

            if (!assetType.IsSet)
                throw new ArgumentException("Property is required for class GetAssetsForProfileResponseV2DataInner.", nameof(assetType));

            if (!imageUrl.IsSet)
                throw new ArgumentException("Property is required for class GetAssetsForProfileResponseV2DataInner.", nameof(imageUrl));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class GetAssetsForProfileResponseV2DataInner.", nameof(name));

            if (!ownedQuantity.IsSet)
                throw new ArgumentException("Property is required for class GetAssetsForProfileResponseV2DataInner.", nameof(ownedQuantity));

            if (!supply.IsSet)
                throw new ArgumentException("Property is required for class GetAssetsForProfileResponseV2DataInner.", nameof(supply));

            if (assetAddress.IsSet && assetAddress.Value == null)
                throw new ArgumentNullException(nameof(assetAddress), "Property is not nullable for class GetAssetsForProfileResponseV2DataInner.");

            if (assetId.IsSet && assetId.Value == null)
                throw new ArgumentNullException(nameof(assetId), "Property is not nullable for class GetAssetsForProfileResponseV2DataInner.");

            if (assetType.IsSet && assetType.Value == null)
                throw new ArgumentNullException(nameof(assetType), "Property is not nullable for class GetAssetsForProfileResponseV2DataInner.");

            if (imageUrl.IsSet && imageUrl.Value == null)
                throw new ArgumentNullException(nameof(imageUrl), "Property is not nullable for class GetAssetsForProfileResponseV2DataInner.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class GetAssetsForProfileResponseV2DataInner.");

            if (ownedQuantity.IsSet && ownedQuantity.Value == null)
                throw new ArgumentNullException(nameof(ownedQuantity), "Property is not nullable for class GetAssetsForProfileResponseV2DataInner.");

            if (supply.IsSet && supply.Value == null)
                throw new ArgumentNullException(nameof(supply), "Property is not nullable for class GetAssetsForProfileResponseV2DataInner.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class GetAssetsForProfileResponseV2DataInner.");

            return new GetAssetsForProfileResponseV2DataInner(assetAddress.Value!, assetId.Value!, assetType.Value!, imageUrl.Value!, name.Value!, ownedQuantity.Value!.Value!, supply.Value!.Value!, attributes, chainId, rarity, rarityScore);
        }

        /// <summary>
        /// Serializes a <see cref="GetAssetsForProfileResponseV2DataInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAssetsForProfileResponseV2DataInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetAssetsForProfileResponseV2DataInner getAssetsForProfileResponseV2DataInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getAssetsForProfileResponseV2DataInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetAssetsForProfileResponseV2DataInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAssetsForProfileResponseV2DataInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetAssetsForProfileResponseV2DataInner getAssetsForProfileResponseV2DataInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getAssetsForProfileResponseV2DataInner.AssetAddress == null)
                throw new ArgumentNullException(nameof(getAssetsForProfileResponseV2DataInner.AssetAddress), "Property is required for class GetAssetsForProfileResponseV2DataInner.");

            if (getAssetsForProfileResponseV2DataInner.AssetId == null)
                throw new ArgumentNullException(nameof(getAssetsForProfileResponseV2DataInner.AssetId), "Property is required for class GetAssetsForProfileResponseV2DataInner.");

            if (getAssetsForProfileResponseV2DataInner.AssetType == null)
                throw new ArgumentNullException(nameof(getAssetsForProfileResponseV2DataInner.AssetType), "Property is required for class GetAssetsForProfileResponseV2DataInner.");

            if (getAssetsForProfileResponseV2DataInner.ImageUrl == null)
                throw new ArgumentNullException(nameof(getAssetsForProfileResponseV2DataInner.ImageUrl), "Property is required for class GetAssetsForProfileResponseV2DataInner.");

            if (getAssetsForProfileResponseV2DataInner.Name == null)
                throw new ArgumentNullException(nameof(getAssetsForProfileResponseV2DataInner.Name), "Property is required for class GetAssetsForProfileResponseV2DataInner.");

            writer.WriteString("assetAddress", getAssetsForProfileResponseV2DataInner.AssetAddress);

            writer.WriteString("assetId", getAssetsForProfileResponseV2DataInner.AssetId);

            writer.WriteString("assetType", getAssetsForProfileResponseV2DataInner.AssetType);

            writer.WriteString("imageUrl", getAssetsForProfileResponseV2DataInner.ImageUrl);

            writer.WriteString("name", getAssetsForProfileResponseV2DataInner.Name);

            writer.WriteNumber("ownedQuantity", getAssetsForProfileResponseV2DataInner.OwnedQuantity);

            writer.WriteNumber("supply", getAssetsForProfileResponseV2DataInner.Supply);

            if (getAssetsForProfileResponseV2DataInner.AttributesOption.IsSet)
                if (getAssetsForProfileResponseV2DataInner.AttributesOption.Value != null)
                {
                    writer.WritePropertyName("attributes");
                    JsonSerializer.Serialize(writer, getAssetsForProfileResponseV2DataInner.Attributes, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("attributes");
            if (getAssetsForProfileResponseV2DataInner.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", getAssetsForProfileResponseV2DataInner.ChainIdOption.Value!.Value);

            var rarityRawValue = GetAssetsForProfileResponseV2DataInner.RarityEnumToJsonValue(getAssetsForProfileResponseV2DataInner.RarityOption.Value!.Value);
            if (rarityRawValue != null)
                writer.WriteString("rarity", rarityRawValue);
            else
                writer.WriteNull("rarity");

            if (getAssetsForProfileResponseV2DataInner.RarityScoreOption.IsSet)
                if (getAssetsForProfileResponseV2DataInner.RarityScoreOption.Value != null)
                    writer.WriteNumber("rarityScore", getAssetsForProfileResponseV2DataInner.RarityScoreOption.Value!.Value);
                else
                    writer.WriteNull("rarityScore");
        }
    }
}