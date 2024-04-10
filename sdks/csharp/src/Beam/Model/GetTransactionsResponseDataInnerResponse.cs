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
    /// GetTransactionsResponseDataInnerResponse
    /// </summary>
    public partial class GetTransactionsResponseDataInnerResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionsResponseDataInnerResponse" /> class.
        /// </summary>
        /// <param name="createdAt">createdAt</param>
        /// <param name="blockNumber">blockNumber</param>
        /// <param name="error">error</param>
        /// <param name="gasFee">gasFee</param>
        /// <param name="gasUsed">gasUsed</param>
        /// <param name="l1GasFee">l1GasFee</param>
        /// <param name="l1GasUsed">l1GasUsed</param>
        /// <param name="logs">logs</param>
        /// <param name="status">status</param>
        /// <param name="to">to</param>
        /// <param name="transactionHash">transactionHash</param>
        [JsonConstructor]
        public GetTransactionsResponseDataInnerResponse(decimal createdAt, Option<decimal?> blockNumber = default, Option<Object?> error = default, Option<string?> gasFee = default, Option<string?> gasUsed = default, Option<string?> l1GasFee = default, Option<string?> l1GasUsed = default, Option<List<GetTransactionsResponseDataInnerResponseLogsInner>?> logs = default, Option<decimal?> status = default, Option<string?> to = default, Option<string?> transactionHash = default)
        {
            CreatedAt = createdAt;
            BlockNumberOption = blockNumber;
            ErrorOption = error;
            GasFeeOption = gasFee;
            GasUsedOption = gasUsed;
            L1GasFeeOption = l1GasFee;
            L1GasUsedOption = l1GasUsed;
            LogsOption = logs;
            StatusOption = status;
            ToOption = to;
            TransactionHashOption = transactionHash;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [JsonPropertyName("createdAt")]
        public decimal CreatedAt { get; set; }

        /// <summary>
        /// Used to track the state of BlockNumber
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> BlockNumberOption { get; private set; }

        /// <summary>
        /// Gets or Sets BlockNumber
        /// </summary>
        [JsonPropertyName("blockNumber")]
        public decimal? BlockNumber { get { return this. BlockNumberOption; } set { this.BlockNumberOption = new(value); } }

        /// <summary>
        /// Used to track the state of Error
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> ErrorOption { get; private set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [JsonPropertyName("error")]
        public Object? Error { get { return this. ErrorOption; } set { this.ErrorOption = new(value); } }

        /// <summary>
        /// Used to track the state of GasFee
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> GasFeeOption { get; private set; }

        /// <summary>
        /// Gets or Sets GasFee
        /// </summary>
        [JsonPropertyName("gasFee")]
        public string? GasFee { get { return this. GasFeeOption; } set { this.GasFeeOption = new(value); } }

        /// <summary>
        /// Used to track the state of GasUsed
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> GasUsedOption { get; private set; }

        /// <summary>
        /// Gets or Sets GasUsed
        /// </summary>
        [JsonPropertyName("gasUsed")]
        public string? GasUsed { get { return this. GasUsedOption; } set { this.GasUsedOption = new(value); } }

        /// <summary>
        /// Used to track the state of L1GasFee
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> L1GasFeeOption { get; private set; }

        /// <summary>
        /// Gets or Sets L1GasFee
        /// </summary>
        [JsonPropertyName("l1GasFee")]
        public string? L1GasFee { get { return this. L1GasFeeOption; } set { this.L1GasFeeOption = new(value); } }

        /// <summary>
        /// Used to track the state of L1GasUsed
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> L1GasUsedOption { get; private set; }

        /// <summary>
        /// Gets or Sets L1GasUsed
        /// </summary>
        [JsonPropertyName("l1GasUsed")]
        public string? L1GasUsed { get { return this. L1GasUsedOption; } set { this.L1GasUsedOption = new(value); } }

        /// <summary>
        /// Used to track the state of Logs
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<GetTransactionsResponseDataInnerResponseLogsInner>?> LogsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Logs
        /// </summary>
        [JsonPropertyName("logs")]
        public List<GetTransactionsResponseDataInnerResponseLogsInner>? Logs { get { return this. LogsOption; } set { this.LogsOption = new(value); } }

        /// <summary>
        /// Used to track the state of Status
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> StatusOption { get; private set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonPropertyName("status")]
        public decimal? Status { get { return this. StatusOption; } set { this.StatusOption = new(value); } }

        /// <summary>
        /// Used to track the state of To
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ToOption { get; private set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [JsonPropertyName("to")]
        public string? To { get { return this. ToOption; } set { this.ToOption = new(value); } }

        /// <summary>
        /// Used to track the state of TransactionHash
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TransactionHashOption { get; private set; }

        /// <summary>
        /// Gets or Sets TransactionHash
        /// </summary>
        [JsonPropertyName("transactionHash")]
        public string? TransactionHash { get { return this. TransactionHashOption; } set { this.TransactionHashOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTransactionsResponseDataInnerResponse {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  BlockNumber: ").Append(BlockNumber).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  GasFee: ").Append(GasFee).Append("\n");
            sb.Append("  GasUsed: ").Append(GasUsed).Append("\n");
            sb.Append("  L1GasFee: ").Append(L1GasFee).Append("\n");
            sb.Append("  L1GasUsed: ").Append(L1GasUsed).Append("\n");
            sb.Append("  Logs: ").Append(Logs).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
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
    /// A Json converter for type <see cref="GetTransactionsResponseDataInnerResponse" />
    /// </summary>
    public class GetTransactionsResponseDataInnerResponseJsonConverter : JsonConverter<GetTransactionsResponseDataInnerResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetTransactionsResponseDataInnerResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetTransactionsResponseDataInnerResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<decimal?> createdAt = default;
            Option<decimal?> blockNumber = default;
            Option<Object?> error = default;
            Option<string?> gasFee = default;
            Option<string?> gasUsed = default;
            Option<string?> l1GasFee = default;
            Option<string?> l1GasUsed = default;
            Option<List<GetTransactionsResponseDataInnerResponseLogsInner>?> logs = default;
            Option<decimal?> status = default;
            Option<string?> to = default;
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
                        case "createdAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdAt = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "blockNumber":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                blockNumber = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "error":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                error = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "gasFee":
                            gasFee = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "gasUsed":
                            gasUsed = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "l1GasFee":
                            l1GasFee = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "l1GasUsed":
                            l1GasUsed = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "logs":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                logs = new Option<List<GetTransactionsResponseDataInnerResponseLogsInner>?>(JsonSerializer.Deserialize<List<GetTransactionsResponseDataInnerResponseLogsInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "status":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                status = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "to":
                            to = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "transactionHash":
                            transactionHash = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionsResponseDataInnerResponse.", nameof(createdAt));

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class GetTransactionsResponseDataInnerResponse.");

            if (blockNumber.IsSet && blockNumber.Value == null)
                throw new ArgumentNullException(nameof(blockNumber), "Property is not nullable for class GetTransactionsResponseDataInnerResponse.");

            if (gasFee.IsSet && gasFee.Value == null)
                throw new ArgumentNullException(nameof(gasFee), "Property is not nullable for class GetTransactionsResponseDataInnerResponse.");

            if (gasUsed.IsSet && gasUsed.Value == null)
                throw new ArgumentNullException(nameof(gasUsed), "Property is not nullable for class GetTransactionsResponseDataInnerResponse.");

            if (l1GasFee.IsSet && l1GasFee.Value == null)
                throw new ArgumentNullException(nameof(l1GasFee), "Property is not nullable for class GetTransactionsResponseDataInnerResponse.");

            if (l1GasUsed.IsSet && l1GasUsed.Value == null)
                throw new ArgumentNullException(nameof(l1GasUsed), "Property is not nullable for class GetTransactionsResponseDataInnerResponse.");

            if (logs.IsSet && logs.Value == null)
                throw new ArgumentNullException(nameof(logs), "Property is not nullable for class GetTransactionsResponseDataInnerResponse.");

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class GetTransactionsResponseDataInnerResponse.");

            if (to.IsSet && to.Value == null)
                throw new ArgumentNullException(nameof(to), "Property is not nullable for class GetTransactionsResponseDataInnerResponse.");

            if (transactionHash.IsSet && transactionHash.Value == null)
                throw new ArgumentNullException(nameof(transactionHash), "Property is not nullable for class GetTransactionsResponseDataInnerResponse.");

            return new GetTransactionsResponseDataInnerResponse(createdAt.Value!.Value!, blockNumber, error, gasFee, gasUsed, l1GasFee, l1GasUsed, logs, status, to, transactionHash);
        }

        /// <summary>
        /// Serializes a <see cref="GetTransactionsResponseDataInnerResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getTransactionsResponseDataInnerResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetTransactionsResponseDataInnerResponse getTransactionsResponseDataInnerResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getTransactionsResponseDataInnerResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetTransactionsResponseDataInnerResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getTransactionsResponseDataInnerResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetTransactionsResponseDataInnerResponse getTransactionsResponseDataInnerResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getTransactionsResponseDataInnerResponse.GasFeeOption.IsSet && getTransactionsResponseDataInnerResponse.GasFee == null)
                throw new ArgumentNullException(nameof(getTransactionsResponseDataInnerResponse.GasFee), "Property is required for class GetTransactionsResponseDataInnerResponse.");

            if (getTransactionsResponseDataInnerResponse.GasUsedOption.IsSet && getTransactionsResponseDataInnerResponse.GasUsed == null)
                throw new ArgumentNullException(nameof(getTransactionsResponseDataInnerResponse.GasUsed), "Property is required for class GetTransactionsResponseDataInnerResponse.");

            if (getTransactionsResponseDataInnerResponse.L1GasFeeOption.IsSet && getTransactionsResponseDataInnerResponse.L1GasFee == null)
                throw new ArgumentNullException(nameof(getTransactionsResponseDataInnerResponse.L1GasFee), "Property is required for class GetTransactionsResponseDataInnerResponse.");

            if (getTransactionsResponseDataInnerResponse.L1GasUsedOption.IsSet && getTransactionsResponseDataInnerResponse.L1GasUsed == null)
                throw new ArgumentNullException(nameof(getTransactionsResponseDataInnerResponse.L1GasUsed), "Property is required for class GetTransactionsResponseDataInnerResponse.");

            if (getTransactionsResponseDataInnerResponse.LogsOption.IsSet && getTransactionsResponseDataInnerResponse.Logs == null)
                throw new ArgumentNullException(nameof(getTransactionsResponseDataInnerResponse.Logs), "Property is required for class GetTransactionsResponseDataInnerResponse.");

            if (getTransactionsResponseDataInnerResponse.ToOption.IsSet && getTransactionsResponseDataInnerResponse.To == null)
                throw new ArgumentNullException(nameof(getTransactionsResponseDataInnerResponse.To), "Property is required for class GetTransactionsResponseDataInnerResponse.");

            if (getTransactionsResponseDataInnerResponse.TransactionHashOption.IsSet && getTransactionsResponseDataInnerResponse.TransactionHash == null)
                throw new ArgumentNullException(nameof(getTransactionsResponseDataInnerResponse.TransactionHash), "Property is required for class GetTransactionsResponseDataInnerResponse.");

            writer.WriteNumber("createdAt", getTransactionsResponseDataInnerResponse.CreatedAt);

            if (getTransactionsResponseDataInnerResponse.BlockNumberOption.IsSet)
                writer.WriteNumber("blockNumber", getTransactionsResponseDataInnerResponse.BlockNumberOption.Value!.Value);

            if (getTransactionsResponseDataInnerResponse.ErrorOption.IsSet)
                if (getTransactionsResponseDataInnerResponse.ErrorOption.Value != null)
                {
                    writer.WritePropertyName("error");
                    JsonSerializer.Serialize(writer, getTransactionsResponseDataInnerResponse.Error, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("error");
            if (getTransactionsResponseDataInnerResponse.GasFeeOption.IsSet)
                writer.WriteString("gasFee", getTransactionsResponseDataInnerResponse.GasFee);

            if (getTransactionsResponseDataInnerResponse.GasUsedOption.IsSet)
                writer.WriteString("gasUsed", getTransactionsResponseDataInnerResponse.GasUsed);

            if (getTransactionsResponseDataInnerResponse.L1GasFeeOption.IsSet)
                writer.WriteString("l1GasFee", getTransactionsResponseDataInnerResponse.L1GasFee);

            if (getTransactionsResponseDataInnerResponse.L1GasUsedOption.IsSet)
                writer.WriteString("l1GasUsed", getTransactionsResponseDataInnerResponse.L1GasUsed);

            if (getTransactionsResponseDataInnerResponse.LogsOption.IsSet)
            {
                writer.WritePropertyName("logs");
                JsonSerializer.Serialize(writer, getTransactionsResponseDataInnerResponse.Logs, jsonSerializerOptions);
            }
            if (getTransactionsResponseDataInnerResponse.StatusOption.IsSet)
                writer.WriteNumber("status", getTransactionsResponseDataInnerResponse.StatusOption.Value!.Value);

            if (getTransactionsResponseDataInnerResponse.ToOption.IsSet)
                writer.WriteString("to", getTransactionsResponseDataInnerResponse.To);

            if (getTransactionsResponseDataInnerResponse.TransactionHashOption.IsSet)
                writer.WriteString("transactionHash", getTransactionsResponseDataInnerResponse.TransactionHash);
        }
    }
}