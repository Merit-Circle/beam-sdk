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
    /// GetListedAssetsBodyInput
    /// </summary>
    public partial class GetListedAssetsBodyInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetListedAssetsBodyInput" /> class.
        /// </summary>
        /// <param name="assetAddresses">assetAddresses</param>
        /// <param name="chainId">chainId (default to 13337M)</param>
        /// <param name="continuation">continuation</param>
        /// <param name="limit">limit (default to 50)</param>
        /// <param name="sortBy">sortBy (default to SortByEnum.CreatedAt)</param>
        /// <param name="sortDirection">If using &#x60;createdAt&#x60; for sorting, only &#x60;desc&#x60; is allowed. (default to SortDirectionEnum.Desc)</param>
        [JsonConstructor]
        public GetListedAssetsBodyInput(Option<List<string>?> assetAddresses = default, Option<decimal?> chainId = default, Option<string?> continuation = default, Option<int?> limit = default, Option<SortByEnum?> sortBy = default, Option<SortDirectionEnum?> sortDirection = default)
        {
            AssetAddressesOption = assetAddresses;
            ChainIdOption = chainId;
            ContinuationOption = continuation;
            LimitOption = limit;
            SortByOption = sortBy;
            SortDirectionOption = sortDirection;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines SortBy
        /// </summary>
        public enum SortByEnum
        {
            /// <summary>
            /// Enum CreatedAt for value: createdAt
            /// </summary>
            CreatedAt = 1,

            /// <summary>
            /// Enum UpdatedAt for value: updatedAt
            /// </summary>
            UpdatedAt = 2,

            /// <summary>
            /// Enum Price for value: price
            /// </summary>
            Price = 3
        }

        /// <summary>
        /// Returns a <see cref="SortByEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static SortByEnum SortByEnumFromString(string value)
        {
            if (value.Equals("createdAt"))
                return SortByEnum.CreatedAt;

            if (value.Equals("updatedAt"))
                return SortByEnum.UpdatedAt;

            if (value.Equals("price"))
                return SortByEnum.Price;

            throw new NotImplementedException($"Could not convert value to type SortByEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="SortByEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static SortByEnum? SortByEnumFromStringOrDefault(string value)
        {
            if (value.Equals("createdAt"))
                return SortByEnum.CreatedAt;

            if (value.Equals("updatedAt"))
                return SortByEnum.UpdatedAt;

            if (value.Equals("price"))
                return SortByEnum.Price;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="SortByEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string SortByEnumToJsonValue(SortByEnum? value)
        {
            if (value == SortByEnum.CreatedAt)
                return "createdAt";

            if (value == SortByEnum.UpdatedAt)
                return "updatedAt";

            if (value == SortByEnum.Price)
                return "price";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Used to track the state of SortBy
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<SortByEnum?> SortByOption { get; private set; }

        /// <summary>
        /// Gets or Sets SortBy
        /// </summary>
        [JsonPropertyName("sortBy")]
        public SortByEnum? SortBy { get { return this.SortByOption; } set { this.SortByOption = new(value); } }

        /// <summary>
        /// If using &#x60;createdAt&#x60; for sorting, only &#x60;desc&#x60; is allowed.
        /// </summary>
        /// <value>If using &#x60;createdAt&#x60; for sorting, only &#x60;desc&#x60; is allowed.</value>
        public enum SortDirectionEnum
        {
            /// <summary>
            /// Enum Asc for value: asc
            /// </summary>
            Asc = 1,

            /// <summary>
            /// Enum Desc for value: desc
            /// </summary>
            Desc = 2
        }

        /// <summary>
        /// Returns a <see cref="SortDirectionEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static SortDirectionEnum SortDirectionEnumFromString(string value)
        {
            if (value.Equals("asc"))
                return SortDirectionEnum.Asc;

            if (value.Equals("desc"))
                return SortDirectionEnum.Desc;

            throw new NotImplementedException($"Could not convert value to type SortDirectionEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="SortDirectionEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static SortDirectionEnum? SortDirectionEnumFromStringOrDefault(string value)
        {
            if (value.Equals("asc"))
                return SortDirectionEnum.Asc;

            if (value.Equals("desc"))
                return SortDirectionEnum.Desc;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="SortDirectionEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string SortDirectionEnumToJsonValue(SortDirectionEnum? value)
        {
            if (value == SortDirectionEnum.Asc)
                return "asc";

            if (value == SortDirectionEnum.Desc)
                return "desc";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Used to track the state of SortDirection
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<SortDirectionEnum?> SortDirectionOption { get; private set; }

        /// <summary>
        /// If using &#x60;createdAt&#x60; for sorting, only &#x60;desc&#x60; is allowed.
        /// </summary>
        /// <value>If using &#x60;createdAt&#x60; for sorting, only &#x60;desc&#x60; is allowed.</value>
        [JsonPropertyName("sortDirection")]
        public SortDirectionEnum? SortDirection { get { return this.SortDirectionOption; } set { this.SortDirectionOption = new(value); } }

        /// <summary>
        /// Used to track the state of AssetAddresses
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>?> AssetAddressesOption { get; private set; }

        /// <summary>
        /// Gets or Sets AssetAddresses
        /// </summary>
        [JsonPropertyName("assetAddresses")]
        public List<string>? AssetAddresses { get { return this. AssetAddressesOption; } set { this.AssetAddressesOption = new(value); } }

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
        /// Used to track the state of Continuation
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ContinuationOption { get; private set; }

        /// <summary>
        /// Gets or Sets Continuation
        /// </summary>
        [JsonPropertyName("continuation")]
        public string? Continuation { get { return this. ContinuationOption; } set { this.ContinuationOption = new(value); } }

        /// <summary>
        /// Used to track the state of Limit
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> LimitOption { get; private set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [JsonPropertyName("limit")]
        public int? Limit { get { return this. LimitOption; } set { this.LimitOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetListedAssetsBodyInput {\n");
            sb.Append("  AssetAddresses: ").Append(AssetAddresses).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Continuation: ").Append(Continuation).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  SortBy: ").Append(SortBy).Append("\n");
            sb.Append("  SortDirection: ").Append(SortDirection).Append("\n");
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
            // Limit (int) maximum
            if (this.LimitOption.IsSet && this.LimitOption.Value > (int)1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Limit, must be a value less than or equal to 1000.", new [] { "Limit" });
            }

            // Limit (int) minimum
            if (this.LimitOption.IsSet && this.LimitOption.Value < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Limit, must be a value greater than or equal to 1.", new [] { "Limit" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="GetListedAssetsBodyInput" />
    /// </summary>
    public class GetListedAssetsBodyInputJsonConverter : JsonConverter<GetListedAssetsBodyInput>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetListedAssetsBodyInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetListedAssetsBodyInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<string>?> assetAddresses = default;
            Option<decimal?> chainId = default;
            Option<string?> continuation = default;
            Option<int?> limit = default;
            Option<GetListedAssetsBodyInput.SortByEnum?> sortBy = default;
            Option<GetListedAssetsBodyInput.SortDirectionEnum?> sortDirection = default;

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
                        case "assetAddresses":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                assetAddresses = new Option<List<string>?>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "continuation":
                            continuation = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "limit":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                limit = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "sortBy":
                            string? sortByRawValue = utf8JsonReader.GetString();
                            if (sortByRawValue != null)
                                sortBy = new Option<GetListedAssetsBodyInput.SortByEnum?>(GetListedAssetsBodyInput.SortByEnumFromStringOrDefault(sortByRawValue));
                            break;
                        case "sortDirection":
                            string? sortDirectionRawValue = utf8JsonReader.GetString();
                            if (sortDirectionRawValue != null)
                                sortDirection = new Option<GetListedAssetsBodyInput.SortDirectionEnum?>(GetListedAssetsBodyInput.SortDirectionEnumFromStringOrDefault(sortDirectionRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class GetListedAssetsBodyInput.");

            if (limit.IsSet && limit.Value == null)
                throw new ArgumentNullException(nameof(limit), "Property is not nullable for class GetListedAssetsBodyInput.");

            if (sortBy.IsSet && sortBy.Value == null)
                throw new ArgumentNullException(nameof(sortBy), "Property is not nullable for class GetListedAssetsBodyInput.");

            if (sortDirection.IsSet && sortDirection.Value == null)
                throw new ArgumentNullException(nameof(sortDirection), "Property is not nullable for class GetListedAssetsBodyInput.");

            return new GetListedAssetsBodyInput(assetAddresses, chainId, continuation, limit, sortBy, sortDirection);
        }

        /// <summary>
        /// Serializes a <see cref="GetListedAssetsBodyInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getListedAssetsBodyInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetListedAssetsBodyInput getListedAssetsBodyInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getListedAssetsBodyInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetListedAssetsBodyInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getListedAssetsBodyInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetListedAssetsBodyInput getListedAssetsBodyInput, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getListedAssetsBodyInput.AssetAddressesOption.IsSet)
                if (getListedAssetsBodyInput.AssetAddressesOption.Value != null)
                {
                    writer.WritePropertyName("assetAddresses");
                    JsonSerializer.Serialize(writer, getListedAssetsBodyInput.AssetAddresses, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("assetAddresses");
            if (getListedAssetsBodyInput.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", getListedAssetsBodyInput.ChainIdOption.Value!.Value);

            if (getListedAssetsBodyInput.ContinuationOption.IsSet)
                if (getListedAssetsBodyInput.ContinuationOption.Value != null)
                    writer.WriteString("continuation", getListedAssetsBodyInput.Continuation);
                else
                    writer.WriteNull("continuation");

            if (getListedAssetsBodyInput.LimitOption.IsSet)
                writer.WriteNumber("limit", getListedAssetsBodyInput.LimitOption.Value!.Value);

            var sortByRawValue = GetListedAssetsBodyInput.SortByEnumToJsonValue(getListedAssetsBodyInput.SortByOption.Value!.Value);
            writer.WriteString("sortBy", sortByRawValue);
            var sortDirectionRawValue = GetListedAssetsBodyInput.SortDirectionEnumToJsonValue(getListedAssetsBodyInput.SortDirectionOption.Value!.Value);
            writer.WriteString("sortDirection", sortDirectionRawValue);
        }
    }
}