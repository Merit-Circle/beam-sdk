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
    /// GetAllGasUsageResponseDataInner
    /// </summary>
    public partial class GetAllGasUsageResponseDataInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllGasUsageResponseDataInner" /> class.
        /// </summary>
        /// <param name="data">data</param>
        /// <param name="summary">summary</param>
        [JsonConstructor]
        public GetAllGasUsageResponseDataInner(List<GetAllGasUsageResponseDataInnerDataInner> data, GetAllGasUsageResponseDataInnerSummary summary)
        {
            Data = data;
            Summary = summary;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [JsonPropertyName("data")]
        public List<GetAllGasUsageResponseDataInnerDataInner> Data { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [JsonPropertyName("summary")]
        public GetAllGasUsageResponseDataInnerSummary Summary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAllGasUsageResponseDataInner {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
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
    /// A Json converter for type <see cref="GetAllGasUsageResponseDataInner" />
    /// </summary>
    public class GetAllGasUsageResponseDataInnerJsonConverter : JsonConverter<GetAllGasUsageResponseDataInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetAllGasUsageResponseDataInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetAllGasUsageResponseDataInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<GetAllGasUsageResponseDataInnerDataInner>> data = default;
            Option<GetAllGasUsageResponseDataInnerSummary> summary = default;

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
                        case "data":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                data = new Option<List<GetAllGasUsageResponseDataInnerDataInner>>(JsonSerializer.Deserialize<List<GetAllGasUsageResponseDataInnerDataInner>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "summary":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                summary = new Option<GetAllGasUsageResponseDataInnerSummary>(JsonSerializer.Deserialize<GetAllGasUsageResponseDataInnerSummary>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!data.IsSet)
                throw new ArgumentException("Property is required for class GetAllGasUsageResponseDataInner.", nameof(data));

            if (!summary.IsSet)
                throw new ArgumentException("Property is required for class GetAllGasUsageResponseDataInner.", nameof(summary));

            if (data.IsSet && data.Value == null)
                throw new ArgumentNullException(nameof(data), "Property is not nullable for class GetAllGasUsageResponseDataInner.");

            if (summary.IsSet && summary.Value == null)
                throw new ArgumentNullException(nameof(summary), "Property is not nullable for class GetAllGasUsageResponseDataInner.");

            return new GetAllGasUsageResponseDataInner(data.Value, summary.Value);
        }

        /// <summary>
        /// Serializes a <see cref="GetAllGasUsageResponseDataInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAllGasUsageResponseDataInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetAllGasUsageResponseDataInner getAllGasUsageResponseDataInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getAllGasUsageResponseDataInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetAllGasUsageResponseDataInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAllGasUsageResponseDataInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetAllGasUsageResponseDataInner getAllGasUsageResponseDataInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getAllGasUsageResponseDataInner.Data == null)
                throw new ArgumentNullException(nameof(getAllGasUsageResponseDataInner.Data), "Property is required for class GetAllGasUsageResponseDataInner.");

            if (getAllGasUsageResponseDataInner.Summary == null)
                throw new ArgumentNullException(nameof(getAllGasUsageResponseDataInner.Summary), "Property is required for class GetAllGasUsageResponseDataInner.");

            writer.WritePropertyName("data");
            JsonSerializer.Serialize(writer, getAllGasUsageResponseDataInner.Data, jsonSerializerOptions);
            writer.WritePropertyName("summary");
            JsonSerializer.Serialize(writer, getAllGasUsageResponseDataInner.Summary, jsonSerializerOptions);
        }
    }
}
