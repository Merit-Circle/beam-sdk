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
    /// AcceptOfferResponse
    /// </summary>
    public partial class AcceptOfferResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptOfferResponse" /> class.
        /// </summary>
        /// <param name="success">success</param>
        /// <param name="explorerUrl">explorerUrl</param>
        /// <param name="transactionHash">transactionHash</param>
        [JsonConstructor]
        public AcceptOfferResponse(bool success, Option<string> explorerUrl = default, Option<string> transactionHash = default)
        {
            Success = success;
            ExplorerUrlOption = explorerUrl;
            TransactionHashOption = transactionHash;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// Used to track the state of ExplorerUrl
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ExplorerUrlOption { get; private set; }

        /// <summary>
        /// Gets or Sets ExplorerUrl
        /// </summary>
        [JsonPropertyName("explorerUrl")]
        public string ExplorerUrl { get { return this. ExplorerUrlOption; } set { this.ExplorerUrlOption = new(value); } }

        /// <summary>
        /// Used to track the state of TransactionHash
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> TransactionHashOption { get; private set; }

        /// <summary>
        /// Gets or Sets TransactionHash
        /// </summary>
        [JsonPropertyName("transactionHash")]
        public string TransactionHash { get { return this. TransactionHashOption; } set { this.TransactionHashOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AcceptOfferResponse {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  ExplorerUrl: ").Append(ExplorerUrl).Append("\n");
            sb.Append("  TransactionHash: ").Append(TransactionHash).Append("\n");
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
    /// A Json converter for type <see cref="AcceptOfferResponse" />
    /// </summary>
    public class AcceptOfferResponseJsonConverter : JsonConverter<AcceptOfferResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="AcceptOfferResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AcceptOfferResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<bool?> success = default;
            Option<string> explorerUrl = default;
            Option<string> transactionHash = default;

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
                        case "success":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                success = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "explorerUrl":
                            explorerUrl = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "transactionHash":
                            transactionHash = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!success.IsSet)
                throw new ArgumentException("Property is required for class AcceptOfferResponse.", nameof(success));

            if (success.IsSet && success.Value == null)
                throw new ArgumentNullException(nameof(success), "Property is not nullable for class AcceptOfferResponse.");

            if (explorerUrl.IsSet && explorerUrl.Value == null)
                throw new ArgumentNullException(nameof(explorerUrl), "Property is not nullable for class AcceptOfferResponse.");

            if (transactionHash.IsSet && transactionHash.Value == null)
                throw new ArgumentNullException(nameof(transactionHash), "Property is not nullable for class AcceptOfferResponse.");

            return new AcceptOfferResponse(success.Value.Value, explorerUrl, transactionHash);
        }

        /// <summary>
        /// Serializes a <see cref="AcceptOfferResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="acceptOfferResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AcceptOfferResponse acceptOfferResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, acceptOfferResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AcceptOfferResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="acceptOfferResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, AcceptOfferResponse acceptOfferResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (acceptOfferResponse.ExplorerUrlOption.IsSet && acceptOfferResponse.ExplorerUrl == null)
                throw new ArgumentNullException(nameof(acceptOfferResponse.ExplorerUrl), "Property is required for class AcceptOfferResponse.");

            if (acceptOfferResponse.TransactionHashOption.IsSet && acceptOfferResponse.TransactionHash == null)
                throw new ArgumentNullException(nameof(acceptOfferResponse.TransactionHash), "Property is required for class AcceptOfferResponse.");

            writer.WriteBoolean("success", acceptOfferResponse.Success);

            if (acceptOfferResponse.ExplorerUrlOption.IsSet)
                writer.WriteString("explorerUrl", acceptOfferResponse.ExplorerUrl);

            if (acceptOfferResponse.TransactionHashOption.IsSet)
                writer.WriteString("transactionHash", acceptOfferResponse.TransactionHash);
        }
    }
}
