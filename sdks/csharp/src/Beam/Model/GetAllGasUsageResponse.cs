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
    /// GetAllGasUsageResponse
    /// </summary>
    public partial class GetAllGasUsageResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllGasUsageResponse" /> class.
        /// </summary>
        /// <param name="data">data</param>
        [JsonConstructor]
        public GetAllGasUsageResponse(List<GetAllGasUsageResponseDataInner> data)
        {
            Data = data;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [JsonPropertyName("data")]
        public List<GetAllGasUsageResponseDataInner> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAllGasUsageResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
    /// A Json converter for type <see cref="GetAllGasUsageResponse" />
    /// </summary>
    public class GetAllGasUsageResponseJsonConverter : JsonConverter<GetAllGasUsageResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetAllGasUsageResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetAllGasUsageResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<GetAllGasUsageResponseDataInner>> data = default;

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
                                data = new Option<List<GetAllGasUsageResponseDataInner>>(JsonSerializer.Deserialize<List<GetAllGasUsageResponseDataInner>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!data.IsSet)
                throw new ArgumentException("Property is required for class GetAllGasUsageResponse.", nameof(data));

            if (data.IsSet && data.Value == null)
                throw new ArgumentNullException(nameof(data), "Property is not nullable for class GetAllGasUsageResponse.");

            return new GetAllGasUsageResponse(data.Value);
        }

        /// <summary>
        /// Serializes a <see cref="GetAllGasUsageResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAllGasUsageResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetAllGasUsageResponse getAllGasUsageResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getAllGasUsageResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetAllGasUsageResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAllGasUsageResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetAllGasUsageResponse getAllGasUsageResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getAllGasUsageResponse.Data == null)
                throw new ArgumentNullException(nameof(getAllGasUsageResponse.Data), "Property is required for class GetAllGasUsageResponse.");

            writer.WritePropertyName("data");
            JsonSerializer.Serialize(writer, getAllGasUsageResponse.Data, jsonSerializerOptions);
        }
    }
}
