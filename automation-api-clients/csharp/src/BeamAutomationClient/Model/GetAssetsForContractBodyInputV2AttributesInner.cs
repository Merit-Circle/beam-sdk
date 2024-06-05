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
    /// GetAssetsForContractBodyInputV2AttributesInner
    /// </summary>
    public partial class GetAssetsForContractBodyInputV2AttributesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetsForContractBodyInputV2AttributesInner" /> class.
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        [JsonConstructor]
        public GetAssetsForContractBodyInputV2AttributesInner(string key, string value)
        {
            Key = key;
            Value = value;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAssetsForContractBodyInputV2AttributesInner {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
    /// A Json converter for type <see cref="GetAssetsForContractBodyInputV2AttributesInner" />
    /// </summary>
    public class GetAssetsForContractBodyInputV2AttributesInnerJsonConverter : JsonConverter<GetAssetsForContractBodyInputV2AttributesInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetAssetsForContractBodyInputV2AttributesInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetAssetsForContractBodyInputV2AttributesInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> key = default;
            Option<string?> value = default;

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
                        case "key":
                            key = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "value":
                            value = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!key.IsSet)
                throw new ArgumentException("Property is required for class GetAssetsForContractBodyInputV2AttributesInner.", nameof(key));

            if (!value.IsSet)
                throw new ArgumentException("Property is required for class GetAssetsForContractBodyInputV2AttributesInner.", nameof(value));

            if (key.IsSet && key.Value == null)
                throw new ArgumentNullException(nameof(key), "Property is not nullable for class GetAssetsForContractBodyInputV2AttributesInner.");

            if (value.IsSet && value.Value == null)
                throw new ArgumentNullException(nameof(value), "Property is not nullable for class GetAssetsForContractBodyInputV2AttributesInner.");

            return new GetAssetsForContractBodyInputV2AttributesInner(key.Value!, value.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="GetAssetsForContractBodyInputV2AttributesInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAssetsForContractBodyInputV2AttributesInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetAssetsForContractBodyInputV2AttributesInner getAssetsForContractBodyInputV2AttributesInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getAssetsForContractBodyInputV2AttributesInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetAssetsForContractBodyInputV2AttributesInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAssetsForContractBodyInputV2AttributesInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetAssetsForContractBodyInputV2AttributesInner getAssetsForContractBodyInputV2AttributesInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getAssetsForContractBodyInputV2AttributesInner.Key == null)
                throw new ArgumentNullException(nameof(getAssetsForContractBodyInputV2AttributesInner.Key), "Property is required for class GetAssetsForContractBodyInputV2AttributesInner.");

            if (getAssetsForContractBodyInputV2AttributesInner.Value == null)
                throw new ArgumentNullException(nameof(getAssetsForContractBodyInputV2AttributesInner.Value), "Property is required for class GetAssetsForContractBodyInputV2AttributesInner.");

            writer.WriteString("key", getAssetsForContractBodyInputV2AttributesInner.Key);

            writer.WriteString("value", getAssetsForContractBodyInputV2AttributesInner.Value);
        }
    }
}