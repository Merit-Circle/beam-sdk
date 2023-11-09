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

namespace Beam.Model
{
    /// <summary>
    /// CancelAssetListingRequestInput
    /// </summary>
    public partial class CancelAssetListingRequestInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelAssetListingRequestInput" /> class.
        /// </summary>
        /// <param name="policyId">policyId</param>
        /// <param name="optimistic">optimistic (default to false)</param>
        /// <param name="sponsor">sponsor (default to true)</param>
        [JsonConstructor]
        public CancelAssetListingRequestInput(string policyId, bool optimistic = false, bool sponsor = true)
        {
            PolicyId = policyId;
            Optimistic = optimistic;
            Sponsor = sponsor;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets PolicyId
        /// </summary>
        [JsonPropertyName("policyId")]
        public string PolicyId { get; set; }

        /// <summary>
        /// Gets or Sets Optimistic
        /// </summary>
        [JsonPropertyName("optimistic")]
        public bool Optimistic { get; set; }

        /// <summary>
        /// Gets or Sets Sponsor
        /// </summary>
        [JsonPropertyName("sponsor")]
        public bool Sponsor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CancelAssetListingRequestInput {\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
            sb.Append("  Optimistic: ").Append(Optimistic).Append("\n");
            sb.Append("  Sponsor: ").Append(Sponsor).Append("\n");
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
    /// A Json converter for type <see cref="CancelAssetListingRequestInput" />
    /// </summary>
    public class CancelAssetListingRequestInputJsonConverter : JsonConverter<CancelAssetListingRequestInput>
    {
        /// <summary>
        /// Deserializes json to <see cref="CancelAssetListingRequestInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CancelAssetListingRequestInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string policyId = default;
            bool? optimistic = default;
            bool? sponsor = default;

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
                        case "policyId":
                            policyId = utf8JsonReader.GetString();
                            break;
                        case "optimistic":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                optimistic = utf8JsonReader.GetBoolean();
                            break;
                        case "sponsor":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                sponsor = utf8JsonReader.GetBoolean();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (policyId == null)
                throw new ArgumentNullException(nameof(policyId), "Property is required for class CancelAssetListingRequestInput.");

            if (optimistic == null)
                throw new ArgumentNullException(nameof(optimistic), "Property is required for class CancelAssetListingRequestInput.");

            if (sponsor == null)
                throw new ArgumentNullException(nameof(sponsor), "Property is required for class CancelAssetListingRequestInput.");

            return new CancelAssetListingRequestInput(policyId, optimistic.Value, sponsor.Value);
        }

        /// <summary>
        /// Serializes a <see cref="CancelAssetListingRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="cancelAssetListingRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CancelAssetListingRequestInput cancelAssetListingRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, cancelAssetListingRequestInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CancelAssetListingRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="cancelAssetListingRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, CancelAssetListingRequestInput cancelAssetListingRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteString("policyId", cancelAssetListingRequestInput.PolicyId);
            writer.WriteBoolean("optimistic", cancelAssetListingRequestInput.Optimistic);
            writer.WriteBoolean("sponsor", cancelAssetListingRequestInput.Sponsor);
        }
    }
}
