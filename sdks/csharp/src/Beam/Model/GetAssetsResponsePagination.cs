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
    /// GetAssetsResponsePagination
    /// </summary>
    public partial class GetAssetsResponsePagination : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetsResponsePagination" /> class.
        /// </summary>
        /// <param name="count">count</param>
        /// <param name="limit">limit (default to 10M)</param>
        /// <param name="offset">offset (default to 0M)</param>
        [JsonConstructor]
        public GetAssetsResponsePagination(decimal count, Option<decimal?> limit = default, Option<decimal?> offset = default)
        {
            Count = count;
            LimitOption = limit;
            OffsetOption = offset;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [JsonPropertyName("count")]
        public decimal Count { get; set; }

        /// <summary>
        /// Used to track the state of Limit
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> LimitOption { get; private set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [JsonPropertyName("limit")]
        public decimal? Limit { get { return this. LimitOption; } set { this.LimitOption = new(value); } }

        /// <summary>
        /// Used to track the state of Offset
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> OffsetOption { get; private set; }

        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        [JsonPropertyName("offset")]
        public decimal? Offset { get { return this. OffsetOption; } set { this.OffsetOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAssetsResponsePagination {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
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
    /// A Json converter for type <see cref="GetAssetsResponsePagination" />
    /// </summary>
    public class GetAssetsResponsePaginationJsonConverter : JsonConverter<GetAssetsResponsePagination>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetAssetsResponsePagination" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetAssetsResponsePagination Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<decimal?> count = default;
            Option<decimal?> limit = default;
            Option<decimal?> offset = default;

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
                        case "count":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                count = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "limit":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                limit = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "offset":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                offset = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!count.IsSet)
                throw new ArgumentException("Property is required for class GetAssetsResponsePagination.", nameof(count));

            if (count.IsSet && count.Value == null)
                throw new ArgumentNullException(nameof(count), "Property is not nullable for class GetAssetsResponsePagination.");

            if (limit.IsSet && limit.Value == null)
                throw new ArgumentNullException(nameof(limit), "Property is not nullable for class GetAssetsResponsePagination.");

            if (offset.IsSet && offset.Value == null)
                throw new ArgumentNullException(nameof(offset), "Property is not nullable for class GetAssetsResponsePagination.");

            return new GetAssetsResponsePagination(count.Value.Value, limit, offset);
        }

        /// <summary>
        /// Serializes a <see cref="GetAssetsResponsePagination" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAssetsResponsePagination"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetAssetsResponsePagination getAssetsResponsePagination, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getAssetsResponsePagination, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetAssetsResponsePagination" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAssetsResponsePagination"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetAssetsResponsePagination getAssetsResponsePagination, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteNumber("count", getAssetsResponsePagination.Count);

            if (getAssetsResponsePagination.LimitOption.IsSet)
                writer.WriteNumber("limit", getAssetsResponsePagination.LimitOption.Value.Value);

            if (getAssetsResponsePagination.OffsetOption.IsSet)
                writer.WriteNumber("offset", getAssetsResponsePagination.OffsetOption.Value.Value);
        }
    }
}
