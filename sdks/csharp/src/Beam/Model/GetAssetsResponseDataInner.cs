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
    /// GetAssetsResponseDataInner
    /// </summary>
    public partial class GetAssetsResponseDataInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetsResponseDataInner" /> class.
        /// </summary>
        /// <param name="assetAddress">assetAddress</param>
        /// <param name="assetId">assetId</param>
        /// <param name="assetType">assetType</param>
        /// <param name="marketplaceId">marketplaceId</param>
        /// <param name="name">name</param>
        /// <param name="owners">owners</param>
        /// <param name="quantity">quantity</param>
        /// <param name="attributes">attributes</param>
        /// <param name="chainId">chainId (default to 13337M)</param>
        /// <param name="imageUrl">imageUrl</param>
        /// <param name="rarity">rarity</param>
        /// <param name="rarityScore">rarityScore</param>
        [JsonConstructor]
        public GetAssetsResponseDataInner(string assetAddress, string assetId, string assetType, string marketplaceId, string name, List<GetAssetsResponseDataInnerOwnersInner> owners, decimal quantity, Option<List<GetAssetsResponseDataInnerAttributesInner>> attributes = default, Option<decimal?> chainId = default, string imageUrl = default, Option<RarityEnum?> rarity = default, Option<decimal?> rarityScore = default)
        {
            AssetAddress = assetAddress;
            AssetId = assetId;
            AssetType = assetType;
            MarketplaceId = marketplaceId;
            Name = name;
            Owners = owners;
            Quantity = quantity;
            AttributesOption = attributes;
            ChainIdOption = chainId;
            ImageUrl = imageUrl;
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
        /// Returns a <see cref="RarityEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static RarityEnum RarityEnumFromString(string value)
        {
            if (value.Equals("Common"))
                return RarityEnum.Common;

            if (value.Equals("ExtremelyRare"))
                return RarityEnum.ExtremelyRare;

            if (value.Equals("Rare"))
                return RarityEnum.Rare;

            if (value.Equals("Uncommon"))
                return RarityEnum.Uncommon;

            if (value.Equals("VeryRare"))
                return RarityEnum.VeryRare;

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

            if (value.Equals("ExtremelyRare"))
                return RarityEnum.ExtremelyRare;

            if (value.Equals("Rare"))
                return RarityEnum.Rare;

            if (value.Equals("Uncommon"))
                return RarityEnum.Uncommon;

            if (value.Equals("VeryRare"))
                return RarityEnum.VeryRare;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="RarityEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string RarityEnumToJsonValue(RarityEnum? value)
        {
            if (value == null)
                return null;

            if (value == RarityEnum.Common)
                return "Common";

            if (value == RarityEnum.ExtremelyRare)
                return "ExtremelyRare";

            if (value == RarityEnum.Rare)
                return "Rare";

            if (value == RarityEnum.Uncommon)
                return "Uncommon";

            if (value == RarityEnum.VeryRare)
                return "VeryRare";

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
        /// Gets or Sets MarketplaceId
        /// </summary>
        [JsonPropertyName("marketplaceId")]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Owners
        /// </summary>
        [JsonPropertyName("owners")]
        public List<GetAssetsResponseDataInnerOwnersInner> Owners { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [JsonPropertyName("quantity")]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Used to track the state of Attributes
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<GetAssetsResponseDataInnerAttributesInner>> AttributesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [JsonPropertyName("attributes")]
        public List<GetAssetsResponseDataInnerAttributesInner> Attributes { get { return this. AttributesOption; } set { this.AttributesOption = new(value); } }

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
        /// Gets or Sets ImageUrl
        /// </summary>
        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }

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
            sb.Append("class GetAssetsResponseDataInner {\n");
            sb.Append("  AssetAddress: ").Append(AssetAddress).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  AssetType: ").Append(AssetType).Append("\n");
            sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
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
    /// A Json converter for type <see cref="GetAssetsResponseDataInner" />
    /// </summary>
    public class GetAssetsResponseDataInnerJsonConverter : JsonConverter<GetAssetsResponseDataInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetAssetsResponseDataInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetAssetsResponseDataInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> assetAddress = default;
            Option<string> assetId = default;
            Option<string> assetType = default;
            Option<string> marketplaceId = default;
            Option<string> name = default;
            Option<List<GetAssetsResponseDataInnerOwnersInner>> owners = default;
            Option<decimal?> quantity = default;
            Option<List<GetAssetsResponseDataInnerAttributesInner>> attributes = default;
            Option<decimal?> chainId = default;
            Option<string> imageUrl = default;
            Option<GetAssetsResponseDataInner.RarityEnum?> rarity = default;
            Option<decimal?> rarityScore = default;

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
                        case "assetType":
                            assetType = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "marketplaceId":
                            marketplaceId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "name":
                            name = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "owners":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                owners = new Option<List<GetAssetsResponseDataInnerOwnersInner>>(JsonSerializer.Deserialize<List<GetAssetsResponseDataInnerOwnersInner>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "quantity":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                quantity = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "attributes":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                attributes = new Option<List<GetAssetsResponseDataInnerAttributesInner>>(JsonSerializer.Deserialize<List<GetAssetsResponseDataInnerAttributesInner>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "imageUrl":
                            imageUrl = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "rarity":
                            string rarityRawValue = utf8JsonReader.GetString();
                            if (rarityRawValue != null)
                                rarity = new Option<GetAssetsResponseDataInner.RarityEnum?>(GetAssetsResponseDataInner.RarityEnumFromStringOrDefault(rarityRawValue));
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
                throw new ArgumentException("Property is required for class GetAssetsResponseDataInner.", nameof(assetAddress));

            if (!assetId.IsSet)
                throw new ArgumentException("Property is required for class GetAssetsResponseDataInner.", nameof(assetId));

            if (!assetType.IsSet)
                throw new ArgumentException("Property is required for class GetAssetsResponseDataInner.", nameof(assetType));

            if (!marketplaceId.IsSet)
                throw new ArgumentException("Property is required for class GetAssetsResponseDataInner.", nameof(marketplaceId));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class GetAssetsResponseDataInner.", nameof(name));

            if (!owners.IsSet)
                throw new ArgumentException("Property is required for class GetAssetsResponseDataInner.", nameof(owners));

            if (!quantity.IsSet)
                throw new ArgumentException("Property is required for class GetAssetsResponseDataInner.", nameof(quantity));

            if (!imageUrl.IsSet)
                throw new ArgumentException("Property is required for class GetAssetsResponseDataInner.", nameof(imageUrl));

            if (assetAddress.IsSet && assetAddress.Value == null)
                throw new ArgumentNullException(nameof(assetAddress), "Property is not nullable for class GetAssetsResponseDataInner.");

            if (assetId.IsSet && assetId.Value == null)
                throw new ArgumentNullException(nameof(assetId), "Property is not nullable for class GetAssetsResponseDataInner.");

            if (assetType.IsSet && assetType.Value == null)
                throw new ArgumentNullException(nameof(assetType), "Property is not nullable for class GetAssetsResponseDataInner.");

            if (marketplaceId.IsSet && marketplaceId.Value == null)
                throw new ArgumentNullException(nameof(marketplaceId), "Property is not nullable for class GetAssetsResponseDataInner.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class GetAssetsResponseDataInner.");

            if (owners.IsSet && owners.Value == null)
                throw new ArgumentNullException(nameof(owners), "Property is not nullable for class GetAssetsResponseDataInner.");

            if (quantity.IsSet && quantity.Value == null)
                throw new ArgumentNullException(nameof(quantity), "Property is not nullable for class GetAssetsResponseDataInner.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class GetAssetsResponseDataInner.");

            return new GetAssetsResponseDataInner(assetAddress.Value, assetId.Value, assetType.Value, marketplaceId.Value, name.Value, owners.Value, quantity.Value.Value, attributes, chainId, imageUrl.Value, rarity, rarityScore);
        }

        /// <summary>
        /// Serializes a <see cref="GetAssetsResponseDataInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAssetsResponseDataInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetAssetsResponseDataInner getAssetsResponseDataInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getAssetsResponseDataInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetAssetsResponseDataInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAssetsResponseDataInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetAssetsResponseDataInner getAssetsResponseDataInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getAssetsResponseDataInner.AssetAddress == null)
                throw new ArgumentNullException(nameof(getAssetsResponseDataInner.AssetAddress), "Property is required for class GetAssetsResponseDataInner.");

            if (getAssetsResponseDataInner.AssetId == null)
                throw new ArgumentNullException(nameof(getAssetsResponseDataInner.AssetId), "Property is required for class GetAssetsResponseDataInner.");

            if (getAssetsResponseDataInner.AssetType == null)
                throw new ArgumentNullException(nameof(getAssetsResponseDataInner.AssetType), "Property is required for class GetAssetsResponseDataInner.");

            if (getAssetsResponseDataInner.MarketplaceId == null)
                throw new ArgumentNullException(nameof(getAssetsResponseDataInner.MarketplaceId), "Property is required for class GetAssetsResponseDataInner.");

            if (getAssetsResponseDataInner.Name == null)
                throw new ArgumentNullException(nameof(getAssetsResponseDataInner.Name), "Property is required for class GetAssetsResponseDataInner.");

            if (getAssetsResponseDataInner.Owners == null)
                throw new ArgumentNullException(nameof(getAssetsResponseDataInner.Owners), "Property is required for class GetAssetsResponseDataInner.");

            writer.WriteString("assetAddress", getAssetsResponseDataInner.AssetAddress);

            writer.WriteString("assetId", getAssetsResponseDataInner.AssetId);

            writer.WriteString("assetType", getAssetsResponseDataInner.AssetType);

            writer.WriteString("marketplaceId", getAssetsResponseDataInner.MarketplaceId);

            writer.WriteString("name", getAssetsResponseDataInner.Name);

            writer.WritePropertyName("owners");
            JsonSerializer.Serialize(writer, getAssetsResponseDataInner.Owners, jsonSerializerOptions);
            writer.WriteNumber("quantity", getAssetsResponseDataInner.Quantity);

            if (getAssetsResponseDataInner.AttributesOption.IsSet)
                if (getAssetsResponseDataInner.AttributesOption.Value != null)
                {
                    writer.WritePropertyName("attributes");
                    JsonSerializer.Serialize(writer, getAssetsResponseDataInner.Attributes, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("attributes");
            if (getAssetsResponseDataInner.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", getAssetsResponseDataInner.ChainIdOption.Value.Value);

            if (getAssetsResponseDataInner.ImageUrl != null)
                writer.WriteString("imageUrl", getAssetsResponseDataInner.ImageUrl);
            else
                writer.WriteNull("imageUrl");

            var rarityRawValue = GetAssetsResponseDataInner.RarityEnumToJsonValue(getAssetsResponseDataInner.RarityOption.Value.Value);
            if (rarityRawValue != null)
                writer.WriteString("rarity", rarityRawValue);
            else
                writer.WriteNull("rarity");

            if (getAssetsResponseDataInner.RarityScoreOption.IsSet)
                if (getAssetsResponseDataInner.RarityScoreOption.Value != null)
                    writer.WriteNumber("rarityScore", getAssetsResponseDataInner.RarityScoreOption.Value.Value);
                else
                    writer.WriteNull("rarityScore");
        }
    }
}
