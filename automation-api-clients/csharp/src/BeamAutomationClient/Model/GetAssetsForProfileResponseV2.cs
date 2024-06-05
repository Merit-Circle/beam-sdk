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
    /// GetAssetsForProfileResponseV2
    /// </summary>
    public partial class GetAssetsForProfileResponseV2 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetsForProfileResponseV2" /> class.
        /// </summary>
        /// <param name="data">data</param>
        /// <param name="continuation">continuation</param>
        [JsonConstructor]
        public GetAssetsForProfileResponseV2(List<GetAssetsForProfileResponseV2DataInner> data, Option<string?> continuation = default)
        {
            Data = data;
            ContinuationOption = continuation;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [JsonPropertyName("data")]
        public List<GetAssetsForProfileResponseV2DataInner> Data { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAssetsForProfileResponseV2 {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Continuation: ").Append(Continuation).Append("\n");
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
    /// A Json converter for type <see cref="GetAssetsForProfileResponseV2" />
    /// </summary>
    public class GetAssetsForProfileResponseV2JsonConverter : JsonConverter<GetAssetsForProfileResponseV2>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetAssetsForProfileResponseV2" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetAssetsForProfileResponseV2 Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<GetAssetsForProfileResponseV2DataInner>?> data = default;
            Option<string?> continuation = default;

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
                        case "data":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                data = new Option<List<GetAssetsForProfileResponseV2DataInner>?>(JsonSerializer.Deserialize<List<GetAssetsForProfileResponseV2DataInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "continuation":
                            continuation = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!data.IsSet)
                throw new ArgumentException("Property is required for class GetAssetsForProfileResponseV2.", nameof(data));

            if (data.IsSet && data.Value == null)
                throw new ArgumentNullException(nameof(data), "Property is not nullable for class GetAssetsForProfileResponseV2.");

            return new GetAssetsForProfileResponseV2(data.Value!, continuation);
        }

        /// <summary>
        /// Serializes a <see cref="GetAssetsForProfileResponseV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAssetsForProfileResponseV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetAssetsForProfileResponseV2 getAssetsForProfileResponseV2, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getAssetsForProfileResponseV2, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetAssetsForProfileResponseV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAssetsForProfileResponseV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetAssetsForProfileResponseV2 getAssetsForProfileResponseV2, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getAssetsForProfileResponseV2.Data == null)
                throw new ArgumentNullException(nameof(getAssetsForProfileResponseV2.Data), "Property is required for class GetAssetsForProfileResponseV2.");

            writer.WritePropertyName("data");
            JsonSerializer.Serialize(writer, getAssetsForProfileResponseV2.Data, jsonSerializerOptions);
            if (getAssetsForProfileResponseV2.ContinuationOption.IsSet)
                if (getAssetsForProfileResponseV2.ContinuationOption.Value != null)
                    writer.WriteString("continuation", getAssetsForProfileResponseV2.Continuation);
                else
                    writer.WriteNull("continuation");
        }
    }
}