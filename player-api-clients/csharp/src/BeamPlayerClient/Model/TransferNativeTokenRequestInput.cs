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
    /// TransferNativeTokenRequestInput
    /// </summary>
    public partial class TransferNativeTokenRequestInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferNativeTokenRequestInput" /> class.
        /// </summary>
        /// <param name="amountToTransfer">amountToTransfer</param>
        /// <param name="chainId">chainId (default to 13337M)</param>
        /// <param name="operationId">operationId</param>
        /// <param name="operationProcessing">operationProcessing (default to OperationProcessingEnum.Execute)</param>
        /// <param name="optimistic">optimistic (default to false)</param>
        /// <param name="policyId">policyId</param>
        /// <param name="receiverEntityId">receiverEntityId</param>
        /// <param name="receiverWalletAddress">receiverWalletAddress</param>
        /// <param name="sponsor">sponsor (default to true)</param>
        [JsonConstructor]
        public TransferNativeTokenRequestInput(string amountToTransfer, Option<decimal?> chainId = default, Option<string?> operationId = default, Option<OperationProcessingEnum?> operationProcessing = default, Option<bool?> optimistic = default, Option<string?> policyId = default, Option<string?> receiverEntityId = default, Option<string?> receiverWalletAddress = default, Option<bool?> sponsor = default)
        {
            AmountToTransfer = amountToTransfer;
            ChainIdOption = chainId;
            OperationIdOption = operationId;
            OperationProcessingOption = operationProcessing;
            OptimisticOption = optimistic;
            PolicyIdOption = policyId;
            ReceiverEntityIdOption = receiverEntityId;
            ReceiverWalletAddressOption = receiverWalletAddress;
            SponsorOption = sponsor;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines OperationProcessing
        /// </summary>
        public enum OperationProcessingEnum
        {
            /// <summary>
            /// Enum SignOnly for value: SignOnly
            /// </summary>
            SignOnly = 1,

            /// <summary>
            /// Enum Execute for value: Execute
            /// </summary>
            Execute = 2
        }

        /// <summary>
        /// Returns a <see cref="OperationProcessingEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static OperationProcessingEnum OperationProcessingEnumFromString(string value)
        {
            if (value.Equals("SignOnly"))
                return OperationProcessingEnum.SignOnly;

            if (value.Equals("Execute"))
                return OperationProcessingEnum.Execute;

            throw new NotImplementedException($"Could not convert value to type OperationProcessingEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="OperationProcessingEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static OperationProcessingEnum? OperationProcessingEnumFromStringOrDefault(string value)
        {
            if (value.Equals("SignOnly"))
                return OperationProcessingEnum.SignOnly;

            if (value.Equals("Execute"))
                return OperationProcessingEnum.Execute;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="OperationProcessingEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string OperationProcessingEnumToJsonValue(OperationProcessingEnum? value)
        {
            if (value == OperationProcessingEnum.SignOnly)
                return "SignOnly";

            if (value == OperationProcessingEnum.Execute)
                return "Execute";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Used to track the state of OperationProcessing
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<OperationProcessingEnum?> OperationProcessingOption { get; private set; }

        /// <summary>
        /// Gets or Sets OperationProcessing
        /// </summary>
        [JsonPropertyName("operationProcessing")]
        public OperationProcessingEnum? OperationProcessing { get { return this.OperationProcessingOption; } set { this.OperationProcessingOption = new(value); } }

        /// <summary>
        /// Gets or Sets AmountToTransfer
        /// </summary>
        [JsonPropertyName("amountToTransfer")]
        public string AmountToTransfer { get; set; }

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
        /// Used to track the state of OperationId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> OperationIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets OperationId
        /// </summary>
        [JsonPropertyName("operationId")]
        public string? OperationId { get { return this. OperationIdOption; } set { this.OperationIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of Optimistic
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> OptimisticOption { get; private set; }

        /// <summary>
        /// Gets or Sets Optimistic
        /// </summary>
        [JsonPropertyName("optimistic")]
        public bool? Optimistic { get { return this. OptimisticOption; } set { this.OptimisticOption = new(value); } }

        /// <summary>
        /// Used to track the state of PolicyId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PolicyIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets PolicyId
        /// </summary>
        [JsonPropertyName("policyId")]
        public string? PolicyId { get { return this. PolicyIdOption; } set { this.PolicyIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of ReceiverEntityId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ReceiverEntityIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets ReceiverEntityId
        /// </summary>
        [JsonPropertyName("receiverEntityId")]
        public string? ReceiverEntityId { get { return this. ReceiverEntityIdOption; } set { this.ReceiverEntityIdOption = new(value); } }

        /// <summary>
        /// Used to track the state of ReceiverWalletAddress
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ReceiverWalletAddressOption { get; private set; }

        /// <summary>
        /// Gets or Sets ReceiverWalletAddress
        /// </summary>
        [JsonPropertyName("receiverWalletAddress")]
        public string? ReceiverWalletAddress { get { return this. ReceiverWalletAddressOption; } set { this.ReceiverWalletAddressOption = new(value); } }

        /// <summary>
        /// Used to track the state of Sponsor
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> SponsorOption { get; private set; }

        /// <summary>
        /// Gets or Sets Sponsor
        /// </summary>
        [JsonPropertyName("sponsor")]
        public bool? Sponsor { get { return this. SponsorOption; } set { this.SponsorOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferNativeTokenRequestInput {\n");
            sb.Append("  AmountToTransfer: ").Append(AmountToTransfer).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  OperationProcessing: ").Append(OperationProcessing).Append("\n");
            sb.Append("  Optimistic: ").Append(Optimistic).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
            sb.Append("  ReceiverEntityId: ").Append(ReceiverEntityId).Append("\n");
            sb.Append("  ReceiverWalletAddress: ").Append(ReceiverWalletAddress).Append("\n");
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
    /// A Json converter for type <see cref="TransferNativeTokenRequestInput" />
    /// </summary>
    public class TransferNativeTokenRequestInputJsonConverter : JsonConverter<TransferNativeTokenRequestInput>
    {
        /// <summary>
        /// Deserializes json to <see cref="TransferNativeTokenRequestInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TransferNativeTokenRequestInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> amountToTransfer = default;
            Option<decimal?> chainId = default;
            Option<string?> operationId = default;
            Option<TransferNativeTokenRequestInput.OperationProcessingEnum?> operationProcessing = default;
            Option<bool?> optimistic = default;
            Option<string?> policyId = default;
            Option<string?> receiverEntityId = default;
            Option<string?> receiverWalletAddress = default;
            Option<bool?> sponsor = default;

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
                        case "amountToTransfer":
                            amountToTransfer = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "operationId":
                            operationId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "operationProcessing":
                            string? operationProcessingRawValue = utf8JsonReader.GetString();
                            if (operationProcessingRawValue != null)
                                operationProcessing = new Option<TransferNativeTokenRequestInput.OperationProcessingEnum?>(TransferNativeTokenRequestInput.OperationProcessingEnumFromStringOrDefault(operationProcessingRawValue));
                            break;
                        case "optimistic":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                optimistic = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "policyId":
                            policyId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "receiverEntityId":
                            receiverEntityId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "receiverWalletAddress":
                            receiverWalletAddress = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "sponsor":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                sponsor = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!amountToTransfer.IsSet)
                throw new ArgumentException("Property is required for class TransferNativeTokenRequestInput.", nameof(amountToTransfer));

            if (amountToTransfer.IsSet && amountToTransfer.Value == null)
                throw new ArgumentNullException(nameof(amountToTransfer), "Property is not nullable for class TransferNativeTokenRequestInput.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class TransferNativeTokenRequestInput.");

            if (operationProcessing.IsSet && operationProcessing.Value == null)
                throw new ArgumentNullException(nameof(operationProcessing), "Property is not nullable for class TransferNativeTokenRequestInput.");

            if (optimistic.IsSet && optimistic.Value == null)
                throw new ArgumentNullException(nameof(optimistic), "Property is not nullable for class TransferNativeTokenRequestInput.");

            if (receiverEntityId.IsSet && receiverEntityId.Value == null)
                throw new ArgumentNullException(nameof(receiverEntityId), "Property is not nullable for class TransferNativeTokenRequestInput.");

            if (receiverWalletAddress.IsSet && receiverWalletAddress.Value == null)
                throw new ArgumentNullException(nameof(receiverWalletAddress), "Property is not nullable for class TransferNativeTokenRequestInput.");

            if (sponsor.IsSet && sponsor.Value == null)
                throw new ArgumentNullException(nameof(sponsor), "Property is not nullable for class TransferNativeTokenRequestInput.");

            return new TransferNativeTokenRequestInput(amountToTransfer.Value!, chainId, operationId, operationProcessing, optimistic, policyId, receiverEntityId, receiverWalletAddress, sponsor);
        }

        /// <summary>
        /// Serializes a <see cref="TransferNativeTokenRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="transferNativeTokenRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TransferNativeTokenRequestInput transferNativeTokenRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, transferNativeTokenRequestInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TransferNativeTokenRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="transferNativeTokenRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, TransferNativeTokenRequestInput transferNativeTokenRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            if (transferNativeTokenRequestInput.AmountToTransfer == null)
                throw new ArgumentNullException(nameof(transferNativeTokenRequestInput.AmountToTransfer), "Property is required for class TransferNativeTokenRequestInput.");

            if (transferNativeTokenRequestInput.ReceiverEntityIdOption.IsSet && transferNativeTokenRequestInput.ReceiverEntityId == null)
                throw new ArgumentNullException(nameof(transferNativeTokenRequestInput.ReceiverEntityId), "Property is required for class TransferNativeTokenRequestInput.");

            if (transferNativeTokenRequestInput.ReceiverWalletAddressOption.IsSet && transferNativeTokenRequestInput.ReceiverWalletAddress == null)
                throw new ArgumentNullException(nameof(transferNativeTokenRequestInput.ReceiverWalletAddress), "Property is required for class TransferNativeTokenRequestInput.");

            writer.WriteString("amountToTransfer", transferNativeTokenRequestInput.AmountToTransfer);

            if (transferNativeTokenRequestInput.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", transferNativeTokenRequestInput.ChainIdOption.Value!.Value);

            if (transferNativeTokenRequestInput.OperationIdOption.IsSet)
                if (transferNativeTokenRequestInput.OperationIdOption.Value != null)
                    writer.WriteString("operationId", transferNativeTokenRequestInput.OperationId);
                else
                    writer.WriteNull("operationId");

            var operationProcessingRawValue = TransferNativeTokenRequestInput.OperationProcessingEnumToJsonValue(transferNativeTokenRequestInput.OperationProcessingOption.Value!.Value);
            writer.WriteString("operationProcessing", operationProcessingRawValue);
            if (transferNativeTokenRequestInput.OptimisticOption.IsSet)
                writer.WriteBoolean("optimistic", transferNativeTokenRequestInput.OptimisticOption.Value!.Value);

            if (transferNativeTokenRequestInput.PolicyIdOption.IsSet)
                if (transferNativeTokenRequestInput.PolicyIdOption.Value != null)
                    writer.WriteString("policyId", transferNativeTokenRequestInput.PolicyId);
                else
                    writer.WriteNull("policyId");

            if (transferNativeTokenRequestInput.ReceiverEntityIdOption.IsSet)
                writer.WriteString("receiverEntityId", transferNativeTokenRequestInput.ReceiverEntityId);

            if (transferNativeTokenRequestInput.ReceiverWalletAddressOption.IsSet)
                writer.WriteString("receiverWalletAddress", transferNativeTokenRequestInput.ReceiverWalletAddress);

            if (transferNativeTokenRequestInput.SponsorOption.IsSet)
                writer.WriteBoolean("sponsor", transferNativeTokenRequestInput.SponsorOption.Value!.Value);
        }
    }
}