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
    /// GetAssetResponseContractHeader
    /// </summary>
    public partial class GetAssetResponseContractHeader : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetResponseContractHeader" /> class.
        /// </summary>
        /// <param name="background">background</param>
        [JsonConstructor]
        public GetAssetResponseContractHeader(Option<GetAssetResponseContractHeaderBackground> background = default)
        {
            BackgroundOption = background;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Background
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<GetAssetResponseContractHeaderBackground> BackgroundOption { get; private set; }

        /// <summary>
        /// Gets or Sets Background
        /// </summary>
        [JsonPropertyName("background")]
        public GetAssetResponseContractHeaderBackground Background { get { return this. BackgroundOption; } set { this.BackgroundOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAssetResponseContractHeader {\n");
            sb.Append("  Background: ").Append(Background).Append("\n");
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
    /// A Json converter for type <see cref="GetAssetResponseContractHeader" />
    /// </summary>
    public class GetAssetResponseContractHeaderJsonConverter : JsonConverter<GetAssetResponseContractHeader>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetAssetResponseContractHeader" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetAssetResponseContractHeader Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<GetAssetResponseContractHeaderBackground> background = default;

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
                        case "background":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                background = new Option<GetAssetResponseContractHeaderBackground>(JsonSerializer.Deserialize<GetAssetResponseContractHeaderBackground>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            return new GetAssetResponseContractHeader(background);
        }

        /// <summary>
        /// Serializes a <see cref="GetAssetResponseContractHeader" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAssetResponseContractHeader"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetAssetResponseContractHeader getAssetResponseContractHeader, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getAssetResponseContractHeader, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetAssetResponseContractHeader" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAssetResponseContractHeader"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetAssetResponseContractHeader getAssetResponseContractHeader, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getAssetResponseContractHeader.BackgroundOption.IsSet)
                if (getAssetResponseContractHeader.BackgroundOption.Value != null)
                {
                    writer.WritePropertyName("background");
                    JsonSerializer.Serialize(writer, getAssetResponseContractHeader.Background, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("background");
        }
    }
}
