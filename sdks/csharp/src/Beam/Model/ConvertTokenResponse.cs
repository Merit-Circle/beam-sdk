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
    /// ConvertTokenResponse
    /// </summary>
    public partial class ConvertTokenResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertTokenResponse" /> class.
        /// </summary>
        /// <param name="status">status</param>
        /// <param name="type">type</param>
        /// <param name="explorerUrl">explorerUrl</param>
        /// <param name="transactionHash">transactionHash</param>
        [JsonConstructor]
        public ConvertTokenResponse(StatusEnum status, TypeEnum type, Option<string> explorerUrl = default, Option<string> transactionHash = default)
        {
            Status = status;
            Type = type;
            ExplorerUrlOption = explorerUrl;
            TransactionHashOption = transactionHash;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Status
        /// </summary>
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            Pending = 1,

            /// <summary>
            /// Enum Success for value: success
            /// </summary>
            Success = 2
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static StatusEnum StatusEnumFromString(string value)
        {
            if (value.Equals("pending"))
                return StatusEnum.Pending;

            if (value.Equals("success"))
                return StatusEnum.Success;

            throw new NotImplementedException($"Could not convert value to type StatusEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StatusEnum? StatusEnumFromStringOrDefault(string value)
        {
            if (value.Equals("pending"))
                return StatusEnum.Pending;

            if (value.Equals("success"))
                return StatusEnum.Success;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="StatusEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string StatusEnumToJsonValue(StatusEnum value)
        {
            if (value == StatusEnum.Pending)
                return "pending";

            if (value == StatusEnum.Success)
                return "success";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonPropertyName("status")]
        public StatusEnum Status { get; set; }

        /// <summary>
        /// Defines Type
        /// </summary>
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Custodial for value: custodial
            /// </summary>
            Custodial = 1,

            /// <summary>
            /// Enum SelfCustodial for value: self-custodial
            /// </summary>
            SelfCustodial = 2
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static TypeEnum TypeEnumFromString(string value)
        {
            if (value.Equals("custodial"))
                return TypeEnum.Custodial;

            if (value.Equals("self-custodial"))
                return TypeEnum.SelfCustodial;

            throw new NotImplementedException($"Could not convert value to type TypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeEnum? TypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("custodial"))
                return TypeEnum.Custodial;

            if (value.Equals("self-custodial"))
                return TypeEnum.SelfCustodial;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="TypeEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string TypeEnumToJsonValue(TypeEnum value)
        {
            if (value == TypeEnum.Custodial)
                return "custodial";

            if (value == TypeEnum.SelfCustodial)
                return "self-custodial";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public TypeEnum Type { get; set; }

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
            sb.Append("class ConvertTokenResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
    /// A Json converter for type <see cref="ConvertTokenResponse" />
    /// </summary>
    public class ConvertTokenResponseJsonConverter : JsonConverter<ConvertTokenResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="ConvertTokenResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ConvertTokenResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<ConvertTokenResponse.StatusEnum?> status = default;
            Option<ConvertTokenResponse.TypeEnum?> type = default;
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
                        case "status":
                            string statusRawValue = utf8JsonReader.GetString();
                            if (statusRawValue != null)
                                status = new Option<ConvertTokenResponse.StatusEnum?>(ConvertTokenResponse.StatusEnumFromStringOrDefault(statusRawValue));
                            break;
                        case "type":
                            string typeRawValue = utf8JsonReader.GetString();
                            if (typeRawValue != null)
                                type = new Option<ConvertTokenResponse.TypeEnum?>(ConvertTokenResponse.TypeEnumFromStringOrDefault(typeRawValue));
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

            if (!status.IsSet)
                throw new ArgumentException("Property is required for class ConvertTokenResponse.", nameof(status));

            if (!type.IsSet)
                throw new ArgumentException("Property is required for class ConvertTokenResponse.", nameof(type));

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class ConvertTokenResponse.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class ConvertTokenResponse.");

            if (explorerUrl.IsSet && explorerUrl.Value == null)
                throw new ArgumentNullException(nameof(explorerUrl), "Property is not nullable for class ConvertTokenResponse.");

            if (transactionHash.IsSet && transactionHash.Value == null)
                throw new ArgumentNullException(nameof(transactionHash), "Property is not nullable for class ConvertTokenResponse.");

            return new ConvertTokenResponse(status.Value.Value, type.Value.Value, explorerUrl, transactionHash);
        }

        /// <summary>
        /// Serializes a <see cref="ConvertTokenResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="convertTokenResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ConvertTokenResponse convertTokenResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, convertTokenResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ConvertTokenResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="convertTokenResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, ConvertTokenResponse convertTokenResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (convertTokenResponse.ExplorerUrlOption.IsSet && convertTokenResponse.ExplorerUrl == null)
                throw new ArgumentNullException(nameof(convertTokenResponse.ExplorerUrl), "Property is required for class ConvertTokenResponse.");

            if (convertTokenResponse.TransactionHashOption.IsSet && convertTokenResponse.TransactionHash == null)
                throw new ArgumentNullException(nameof(convertTokenResponse.TransactionHash), "Property is required for class ConvertTokenResponse.");

            var statusRawValue = ConvertTokenResponse.StatusEnumToJsonValue(convertTokenResponse.Status);
            if (statusRawValue != null)
                writer.WriteString("status", statusRawValue);
            else
                writer.WriteNull("status");

            var typeRawValue = ConvertTokenResponse.TypeEnumToJsonValue(convertTokenResponse.Type);
            if (typeRawValue != null)
                writer.WriteString("type", typeRawValue);
            else
                writer.WriteNull("type");

            if (convertTokenResponse.ExplorerUrlOption.IsSet)
                writer.WriteString("explorerUrl", convertTokenResponse.ExplorerUrl);

            if (convertTokenResponse.TransactionHashOption.IsSet)
                writer.WriteString("transactionHash", convertTokenResponse.TransactionHash);
        }
    }
}
