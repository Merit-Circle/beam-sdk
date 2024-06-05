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
    /// CreateOfferResponseV2
    /// </summary>
    public partial class CreateOfferResponseV2 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOfferResponseV2" /> class.
        /// </summary>
        /// <param name="offerId">offerId</param>
        [JsonConstructor]
        public CreateOfferResponseV2(string offerId)
        {
            OfferId = offerId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets OfferId
        /// </summary>
        [JsonPropertyName("offerId")]
        public string OfferId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateOfferResponseV2 {\n");
            sb.Append("  OfferId: ").Append(OfferId).Append("\n");
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
    /// A Json converter for type <see cref="CreateOfferResponseV2" />
    /// </summary>
    public class CreateOfferResponseV2JsonConverter : JsonConverter<CreateOfferResponseV2>
    {
        /// <summary>
        /// Deserializes json to <see cref="CreateOfferResponseV2" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CreateOfferResponseV2 Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> offerId = default;

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
                        case "offerId":
                            offerId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!offerId.IsSet)
                throw new ArgumentException("Property is required for class CreateOfferResponseV2.", nameof(offerId));

            if (offerId.IsSet && offerId.Value == null)
                throw new ArgumentNullException(nameof(offerId), "Property is not nullable for class CreateOfferResponseV2.");

            return new CreateOfferResponseV2(offerId.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="CreateOfferResponseV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createOfferResponseV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CreateOfferResponseV2 createOfferResponseV2, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, createOfferResponseV2, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CreateOfferResponseV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createOfferResponseV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, CreateOfferResponseV2 createOfferResponseV2, JsonSerializerOptions jsonSerializerOptions)
        {
            if (createOfferResponseV2.OfferId == null)
                throw new ArgumentNullException(nameof(createOfferResponseV2.OfferId), "Property is required for class CreateOfferResponseV2.");

            writer.WriteString("offerId", createOfferResponseV2.OfferId);
        }
    }
}