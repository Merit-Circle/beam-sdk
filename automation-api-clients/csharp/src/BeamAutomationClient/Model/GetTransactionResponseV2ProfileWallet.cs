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
    /// GetTransactionResponseV2ProfileWallet
    /// </summary>
    public partial class GetTransactionResponseV2ProfileWallet : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionResponseV2ProfileWallet" /> class.
        /// </summary>
        /// <param name="address">address</param>
        [JsonConstructor]
        public GetTransactionResponseV2ProfileWallet(string address)
        {
            Address = address;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTransactionResponseV2ProfileWallet {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
    /// A Json converter for type <see cref="GetTransactionResponseV2ProfileWallet" />
    /// </summary>
    public class GetTransactionResponseV2ProfileWalletJsonConverter : JsonConverter<GetTransactionResponseV2ProfileWallet>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetTransactionResponseV2ProfileWallet" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetTransactionResponseV2ProfileWallet Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> address = default;

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
                        case "address":
                            address = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!address.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionResponseV2ProfileWallet.", nameof(address));

            if (address.IsSet && address.Value == null)
                throw new ArgumentNullException(nameof(address), "Property is not nullable for class GetTransactionResponseV2ProfileWallet.");

            return new GetTransactionResponseV2ProfileWallet(address.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="GetTransactionResponseV2ProfileWallet" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getTransactionResponseV2ProfileWallet"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetTransactionResponseV2ProfileWallet getTransactionResponseV2ProfileWallet, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getTransactionResponseV2ProfileWallet, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetTransactionResponseV2ProfileWallet" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getTransactionResponseV2ProfileWallet"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetTransactionResponseV2ProfileWallet getTransactionResponseV2ProfileWallet, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getTransactionResponseV2ProfileWallet.Address == null)
                throw new ArgumentNullException(nameof(getTransactionResponseV2ProfileWallet.Address), "Property is required for class GetTransactionResponseV2ProfileWallet.");

            writer.WriteString("address", getTransactionResponseV2ProfileWallet.Address);
        }
    }
}