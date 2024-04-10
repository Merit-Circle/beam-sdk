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
    /// GetAllGasUsageResponseChainsInnerSummary
    /// </summary>
    public partial class GetAllGasUsageResponseChainsInnerSummary : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllGasUsageResponseChainsInnerSummary" /> class.
        /// </summary>
        /// <param name="averageTransactionFee">averageTransactionFee</param>
        /// <param name="totalTransactionFee">totalTransactionFee</param>
        /// <param name="totalTransactionFeeInUSD">totalTransactionFeeInUSD</param>
        /// <param name="transactionCount">transactionCount</param>
        /// <param name="chainId">chainId (default to 13337M)</param>
        [JsonConstructor]
        public GetAllGasUsageResponseChainsInnerSummary(string averageTransactionFee, string totalTransactionFee, string totalTransactionFeeInUSD, decimal transactionCount, Option<decimal?> chainId = default)
        {
            AverageTransactionFee = averageTransactionFee;
            TotalTransactionFee = totalTransactionFee;
            TotalTransactionFeeInUSD = totalTransactionFeeInUSD;
            TransactionCount = transactionCount;
            ChainIdOption = chainId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets AverageTransactionFee
        /// </summary>
        [JsonPropertyName("averageTransactionFee")]
        public string AverageTransactionFee { get; set; }

        /// <summary>
        /// Gets or Sets TotalTransactionFee
        /// </summary>
        [JsonPropertyName("totalTransactionFee")]
        public string TotalTransactionFee { get; set; }

        /// <summary>
        /// Gets or Sets TotalTransactionFeeInUSD
        /// </summary>
        [JsonPropertyName("totalTransactionFeeInUSD")]
        public string TotalTransactionFeeInUSD { get; set; }

        /// <summary>
        /// Gets or Sets TransactionCount
        /// </summary>
        [JsonPropertyName("transactionCount")]
        public decimal TransactionCount { get; set; }

        /// <summary>
        /// Used to track the state of ChainId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> ChainIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public decimal? ChainId { get { return this. ChainIdOption; } set { this.ChainIdOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetAllGasUsageResponseChainsInnerSummary {\n");
            sb.Append("  AverageTransactionFee: ").Append(AverageTransactionFee).Append("\n");
            sb.Append("  TotalTransactionFee: ").Append(TotalTransactionFee).Append("\n");
            sb.Append("  TotalTransactionFeeInUSD: ").Append(TotalTransactionFeeInUSD).Append("\n");
            sb.Append("  TransactionCount: ").Append(TransactionCount).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
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
    /// A Json converter for type <see cref="GetAllGasUsageResponseChainsInnerSummary" />
    /// </summary>
    public class GetAllGasUsageResponseChainsInnerSummaryJsonConverter : JsonConverter<GetAllGasUsageResponseChainsInnerSummary>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetAllGasUsageResponseChainsInnerSummary" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetAllGasUsageResponseChainsInnerSummary Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> averageTransactionFee = default;
            Option<string?> totalTransactionFee = default;
            Option<string?> totalTransactionFeeInUSD = default;
            Option<decimal?> transactionCount = default;
            Option<decimal?> chainId = default;

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
                        case "averageTransactionFee":
                            averageTransactionFee = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "totalTransactionFee":
                            totalTransactionFee = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "totalTransactionFeeInUSD":
                            totalTransactionFeeInUSD = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "transactionCount":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                transactionCount = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!averageTransactionFee.IsSet)
                throw new ArgumentException("Property is required for class GetAllGasUsageResponseChainsInnerSummary.", nameof(averageTransactionFee));

            if (!totalTransactionFee.IsSet)
                throw new ArgumentException("Property is required for class GetAllGasUsageResponseChainsInnerSummary.", nameof(totalTransactionFee));

            if (!totalTransactionFeeInUSD.IsSet)
                throw new ArgumentException("Property is required for class GetAllGasUsageResponseChainsInnerSummary.", nameof(totalTransactionFeeInUSD));

            if (!transactionCount.IsSet)
                throw new ArgumentException("Property is required for class GetAllGasUsageResponseChainsInnerSummary.", nameof(transactionCount));

            if (averageTransactionFee.IsSet && averageTransactionFee.Value == null)
                throw new ArgumentNullException(nameof(averageTransactionFee), "Property is not nullable for class GetAllGasUsageResponseChainsInnerSummary.");

            if (totalTransactionFee.IsSet && totalTransactionFee.Value == null)
                throw new ArgumentNullException(nameof(totalTransactionFee), "Property is not nullable for class GetAllGasUsageResponseChainsInnerSummary.");

            if (totalTransactionFeeInUSD.IsSet && totalTransactionFeeInUSD.Value == null)
                throw new ArgumentNullException(nameof(totalTransactionFeeInUSD), "Property is not nullable for class GetAllGasUsageResponseChainsInnerSummary.");

            if (transactionCount.IsSet && transactionCount.Value == null)
                throw new ArgumentNullException(nameof(transactionCount), "Property is not nullable for class GetAllGasUsageResponseChainsInnerSummary.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class GetAllGasUsageResponseChainsInnerSummary.");

            return new GetAllGasUsageResponseChainsInnerSummary(averageTransactionFee.Value!, totalTransactionFee.Value!, totalTransactionFeeInUSD.Value!, transactionCount.Value!.Value!, chainId);
        }

        /// <summary>
        /// Serializes a <see cref="GetAllGasUsageResponseChainsInnerSummary" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAllGasUsageResponseChainsInnerSummary"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetAllGasUsageResponseChainsInnerSummary getAllGasUsageResponseChainsInnerSummary, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getAllGasUsageResponseChainsInnerSummary, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetAllGasUsageResponseChainsInnerSummary" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAllGasUsageResponseChainsInnerSummary"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetAllGasUsageResponseChainsInnerSummary getAllGasUsageResponseChainsInnerSummary, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getAllGasUsageResponseChainsInnerSummary.AverageTransactionFee == null)
                throw new ArgumentNullException(nameof(getAllGasUsageResponseChainsInnerSummary.AverageTransactionFee), "Property is required for class GetAllGasUsageResponseChainsInnerSummary.");

            if (getAllGasUsageResponseChainsInnerSummary.TotalTransactionFee == null)
                throw new ArgumentNullException(nameof(getAllGasUsageResponseChainsInnerSummary.TotalTransactionFee), "Property is required for class GetAllGasUsageResponseChainsInnerSummary.");

            if (getAllGasUsageResponseChainsInnerSummary.TotalTransactionFeeInUSD == null)
                throw new ArgumentNullException(nameof(getAllGasUsageResponseChainsInnerSummary.TotalTransactionFeeInUSD), "Property is required for class GetAllGasUsageResponseChainsInnerSummary.");

            writer.WriteString("averageTransactionFee", getAllGasUsageResponseChainsInnerSummary.AverageTransactionFee);

            writer.WriteString("totalTransactionFee", getAllGasUsageResponseChainsInnerSummary.TotalTransactionFee);

            writer.WriteString("totalTransactionFeeInUSD", getAllGasUsageResponseChainsInnerSummary.TotalTransactionFeeInUSD);

            writer.WriteNumber("transactionCount", getAllGasUsageResponseChainsInnerSummary.TransactionCount);

            if (getAllGasUsageResponseChainsInnerSummary.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", getAllGasUsageResponseChainsInnerSummary.ChainIdOption.Value!.Value);
        }
    }
}