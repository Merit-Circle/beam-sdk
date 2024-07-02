// <auto-generated>
/*
 * Player API
 *
 * The Player API is a service to integrate your game with Beam
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
using OpenAPIClientUtils = BeamPlayerClient.Client.ClientUtils;
using BeamPlayerClient.Client;

namespace BeamPlayerClient.Model
{
    /// <summary>
    /// CommonOperationResponseTransactionsInner
    /// </summary>
    public partial class CommonOperationResponseTransactionsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonOperationResponseTransactionsInner" /> class.
        /// </summary>
        /// <param name="hash">hash</param>
        /// <param name="id">id</param>
        /// <param name="status">status</param>
        /// <param name="type">type</param>
        /// <param name="data">data</param>
        /// <param name="externalId">externalId</param>
        /// <param name="operationId">operationId</param>
        /// <param name="signature">signature</param>
        /// <param name="transactionHash">transactionHash</param>
        [JsonConstructor]
        public CommonOperationResponseTransactionsInner(string hash, string id, StatusEnum status, TypeEnum type, Option<Object?> data = default, string? externalId = default, string? operationId = default, string? signature = default, string? transactionHash = default)
        {
            Hash = hash;
            Id = id;
            Status = status;
            Type = type;
            DataOption = data;
            ExternalId = externalId;
            OperationId = operationId;
            Signature = signature;
            TransactionHash = transactionHash;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Status
        /// </summary>
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Pending for value: Pending
            /// </summary>
            Pending = 1,

            /// <summary>
            /// Enum Signed for value: Signed
            /// </summary>
            Signed = 2,

            /// <summary>
            /// Enum Rejected for value: Rejected
            /// </summary>
            Rejected = 3,

            /// <summary>
            /// Enum Executed for value: Executed
            /// </summary>
            Executed = 4,

            /// <summary>
            /// Enum Error for value: Error
            /// </summary>
            Error = 5
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static StatusEnum StatusEnumFromString(string value)
        {
            if (value.Equals("Pending"))
                return StatusEnum.Pending;

            if (value.Equals("Signed"))
                return StatusEnum.Signed;

            if (value.Equals("Rejected"))
                return StatusEnum.Rejected;

            if (value.Equals("Executed"))
                return StatusEnum.Executed;

            if (value.Equals("Error"))
                return StatusEnum.Error;

            throw new NotImplementedException($"Could not convert value to type StatusEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StatusEnum? StatusEnumFromStringOrDefault(string value)
        {
            if (value.Equals("Pending"))
                return StatusEnum.Pending;

            if (value.Equals("Signed"))
                return StatusEnum.Signed;

            if (value.Equals("Rejected"))
                return StatusEnum.Rejected;

            if (value.Equals("Executed"))
                return StatusEnum.Executed;

            if (value.Equals("Error"))
                return StatusEnum.Error;

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
                return "Pending";

            if (value == StatusEnum.Signed)
                return "Signed";

            if (value == StatusEnum.Rejected)
                return "Rejected";

            if (value == StatusEnum.Executed)
                return "Executed";

            if (value == StatusEnum.Error)
                return "Error";

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
            /// Enum OpenfortTransaction for value: OpenfortTransaction
            /// </summary>
            OpenfortTransaction = 1,

            /// <summary>
            /// Enum OpenfortReservoirOrder for value: OpenfortReservoirOrder
            /// </summary>
            OpenfortReservoirOrder = 2,

            /// <summary>
            /// Enum OpenfortRevokeSession for value: OpenfortRevokeSession
            /// </summary>
            OpenfortRevokeSession = 3
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static TypeEnum TypeEnumFromString(string value)
        {
            if (value.Equals("OpenfortTransaction"))
                return TypeEnum.OpenfortTransaction;

            if (value.Equals("OpenfortReservoirOrder"))
                return TypeEnum.OpenfortReservoirOrder;

            if (value.Equals("OpenfortRevokeSession"))
                return TypeEnum.OpenfortRevokeSession;

            throw new NotImplementedException($"Could not convert value to type TypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="TypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TypeEnum? TypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("OpenfortTransaction"))
                return TypeEnum.OpenfortTransaction;

            if (value.Equals("OpenfortReservoirOrder"))
                return TypeEnum.OpenfortReservoirOrder;

            if (value.Equals("OpenfortRevokeSession"))
                return TypeEnum.OpenfortRevokeSession;

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
            if (value == TypeEnum.OpenfortTransaction)
                return "OpenfortTransaction";

            if (value == TypeEnum.OpenfortReservoirOrder)
                return "OpenfortReservoirOrder";

            if (value == TypeEnum.OpenfortRevokeSession)
                return "OpenfortRevokeSession";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Used to track the state of Data
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> DataOption { get; private set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [JsonPropertyName("data")]
        public Object? Data { get { return this. DataOption; } set { this.DataOption = new(value); } }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [JsonPropertyName("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets OperationId
        /// </summary>
        [JsonPropertyName("operationId")]
        public string? OperationId { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// Gets or Sets TransactionHash
        /// </summary>
        [JsonPropertyName("transactionHash")]
        public string? TransactionHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CommonOperationResponseTransactionsInner {\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
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
    /// A Json converter for type <see cref="CommonOperationResponseTransactionsInner" />
    /// </summary>
    public class CommonOperationResponseTransactionsInnerJsonConverter : JsonConverter<CommonOperationResponseTransactionsInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="CommonOperationResponseTransactionsInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CommonOperationResponseTransactionsInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> hash = default;
            Option<string?> id = default;
            Option<CommonOperationResponseTransactionsInner.StatusEnum?> status = default;
            Option<CommonOperationResponseTransactionsInner.TypeEnum?> type = default;
            Option<Object?> data = default;
            Option<string?> externalId = default;
            Option<string?> operationId = default;
            Option<string?> signature = default;
            Option<string?> transactionHash = default;

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
                        case "hash":
                            hash = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "status":
                            string? statusRawValue = utf8JsonReader.GetString();
                            if (statusRawValue != null)
                                status = new Option<CommonOperationResponseTransactionsInner.StatusEnum?>(CommonOperationResponseTransactionsInner.StatusEnumFromStringOrDefault(statusRawValue));
                            break;
                        case "type":
                            string? typeRawValue = utf8JsonReader.GetString();
                            if (typeRawValue != null)
                                type = new Option<CommonOperationResponseTransactionsInner.TypeEnum?>(CommonOperationResponseTransactionsInner.TypeEnumFromStringOrDefault(typeRawValue));
                            break;
                        case "data":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                data = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "externalId":
                            externalId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "operationId":
                            operationId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "signature":
                            signature = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "transactionHash":
                            transactionHash = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!hash.IsSet)
                throw new ArgumentException("Property is required for class CommonOperationResponseTransactionsInner.", nameof(hash));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class CommonOperationResponseTransactionsInner.", nameof(id));

            if (!status.IsSet)
                throw new ArgumentException("Property is required for class CommonOperationResponseTransactionsInner.", nameof(status));

            if (!type.IsSet)
                throw new ArgumentException("Property is required for class CommonOperationResponseTransactionsInner.", nameof(type));

            if (!externalId.IsSet)
                throw new ArgumentException("Property is required for class CommonOperationResponseTransactionsInner.", nameof(externalId));

            if (!operationId.IsSet)
                throw new ArgumentException("Property is required for class CommonOperationResponseTransactionsInner.", nameof(operationId));

            if (!signature.IsSet)
                throw new ArgumentException("Property is required for class CommonOperationResponseTransactionsInner.", nameof(signature));

            if (!transactionHash.IsSet)
                throw new ArgumentException("Property is required for class CommonOperationResponseTransactionsInner.", nameof(transactionHash));

            if (hash.IsSet && hash.Value == null)
                throw new ArgumentNullException(nameof(hash), "Property is not nullable for class CommonOperationResponseTransactionsInner.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class CommonOperationResponseTransactionsInner.");

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class CommonOperationResponseTransactionsInner.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class CommonOperationResponseTransactionsInner.");

            return new CommonOperationResponseTransactionsInner(hash.Value!, id.Value!, status.Value!.Value!, type.Value!.Value!, data, externalId.Value!, operationId.Value!, signature.Value!, transactionHash.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="CommonOperationResponseTransactionsInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="commonOperationResponseTransactionsInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CommonOperationResponseTransactionsInner commonOperationResponseTransactionsInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, commonOperationResponseTransactionsInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CommonOperationResponseTransactionsInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="commonOperationResponseTransactionsInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, CommonOperationResponseTransactionsInner commonOperationResponseTransactionsInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (commonOperationResponseTransactionsInner.Hash == null)
                throw new ArgumentNullException(nameof(commonOperationResponseTransactionsInner.Hash), "Property is required for class CommonOperationResponseTransactionsInner.");

            if (commonOperationResponseTransactionsInner.Id == null)
                throw new ArgumentNullException(nameof(commonOperationResponseTransactionsInner.Id), "Property is required for class CommonOperationResponseTransactionsInner.");

            writer.WriteString("hash", commonOperationResponseTransactionsInner.Hash);

            writer.WriteString("id", commonOperationResponseTransactionsInner.Id);

            var statusRawValue = CommonOperationResponseTransactionsInner.StatusEnumToJsonValue(commonOperationResponseTransactionsInner.Status);
            writer.WriteString("status", statusRawValue);
            var typeRawValue = CommonOperationResponseTransactionsInner.TypeEnumToJsonValue(commonOperationResponseTransactionsInner.Type);
            writer.WriteString("type", typeRawValue);
            if (commonOperationResponseTransactionsInner.DataOption.IsSet)
                if (commonOperationResponseTransactionsInner.DataOption.Value != null)
                {
                    writer.WritePropertyName("data");
                    JsonSerializer.Serialize(writer, commonOperationResponseTransactionsInner.Data, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("data");
            if (commonOperationResponseTransactionsInner.ExternalId != null)
                writer.WriteString("externalId", commonOperationResponseTransactionsInner.ExternalId);
            else
                writer.WriteNull("externalId");

            if (commonOperationResponseTransactionsInner.OperationId != null)
                writer.WriteString("operationId", commonOperationResponseTransactionsInner.OperationId);
            else
                writer.WriteNull("operationId");

            if (commonOperationResponseTransactionsInner.Signature != null)
                writer.WriteString("signature", commonOperationResponseTransactionsInner.Signature);
            else
                writer.WriteNull("signature");

            if (commonOperationResponseTransactionsInner.TransactionHash != null)
                writer.WriteString("transactionHash", commonOperationResponseTransactionsInner.TransactionHash);
            else
                writer.WriteNull("transactionHash");
        }
    }
}