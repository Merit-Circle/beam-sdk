// <auto-generated>
/*
 * Beam game development API
 *
 * The Beam game development API is a service to integrate your game with Beam
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
using OpenAPIClientUtils = Beam.Client.ClientUtils;
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
        /// <param name="chains">chains</param>
        [JsonConstructor]
        public GetAllGasUsageResponse(List<GetAllGasUsageResponseChainsInner> chains)
        {
            Chains = chains;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Chains
        /// </summary>
        [JsonPropertyName("chains")]
        public List<GetAllGasUsageResponseChainsInner> Chains { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAllGasUsageResponse {\n");
            sb.Append("  Chains: ").Append(Chains).Append("\n");
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

            Option<List<GetAllGasUsageResponseChainsInner>?> chains = default;

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
                        case "chains":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chains = new Option<List<GetAllGasUsageResponseChainsInner>?>(JsonSerializer.Deserialize<List<GetAllGasUsageResponseChainsInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!chains.IsSet)
                throw new ArgumentException("Property is required for class GetAllGasUsageResponse.", nameof(chains));

            if (chains.IsSet && chains.Value == null)
                throw new ArgumentNullException(nameof(chains), "Property is not nullable for class GetAllGasUsageResponse.");

            return new GetAllGasUsageResponse(chains.Value!);
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
            if (getAllGasUsageResponse.Chains == null)
                throw new ArgumentNullException(nameof(getAllGasUsageResponse.Chains), "Property is required for class GetAllGasUsageResponse.");

            writer.WritePropertyName("chains");
            JsonSerializer.Serialize(writer, getAllGasUsageResponse.Chains, jsonSerializerOptions);
        }
    }
}