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
    /// TransferNativeTokenRequestInput
    /// </summary>
    public partial class TransferNativeTokenRequestInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferNativeTokenRequestInput" /> class.
        /// </summary>
        /// <param name="amountToTransfer">amountToTransfer</param>
        /// <param name="policyId">policyId</param>
        /// <param name="receiverEntityId">receiverEntityId</param>
        /// <param name="receiverWalletAddress">receiverWalletAddress</param>
        /// <param name="chainId">chainId (default to 13337M)</param>
        /// <param name="optimistic">optimistic (default to false)</param>
        /// <param name="sponsor">sponsor (default to true)</param>
        [JsonConstructor]
        public TransferNativeTokenRequestInput(string amountToTransfer, string policyId, string receiverEntityId, string receiverWalletAddress, decimal chainId = 13337M, bool optimistic = false, bool sponsor = true)
        {
            AmountToTransfer = amountToTransfer;
            PolicyId = policyId;
            ReceiverEntityId = receiverEntityId;
            ReceiverWalletAddress = receiverWalletAddress;
            ChainId = chainId;
            Optimistic = optimistic;
            Sponsor = sponsor;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets AmountToTransfer
        /// </summary>
        [JsonPropertyName("amountToTransfer")]
        public string AmountToTransfer { get; set; }

        /// <summary>
        /// Gets or Sets PolicyId
        /// </summary>
        [JsonPropertyName("policyId")]
        public string PolicyId { get; set; }

        /// <summary>
        /// Gets or Sets ReceiverEntityId
        /// </summary>
        [JsonPropertyName("receiverEntityId")]
        public string ReceiverEntityId { get; set; }

        /// <summary>
        /// Gets or Sets ReceiverWalletAddress
        /// </summary>
        [JsonPropertyName("receiverWalletAddress")]
        public string ReceiverWalletAddress { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public decimal ChainId { get; set; }

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
            sb.Append("class TransferNativeTokenRequestInput {\n");
            sb.Append("  AmountToTransfer: ").Append(AmountToTransfer).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
            sb.Append("  ReceiverEntityId: ").Append(ReceiverEntityId).Append("\n");
            sb.Append("  ReceiverWalletAddress: ").Append(ReceiverWalletAddress).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
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

            string amountToTransfer = default;
            string policyId = default;
            string receiverEntityId = default;
            string receiverWalletAddress = default;
            decimal? chainId = default;
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
                        case "amountToTransfer":
                            amountToTransfer = utf8JsonReader.GetString();
                            break;
                        case "policyId":
                            policyId = utf8JsonReader.GetString();
                            break;
                        case "receiverEntityId":
                            receiverEntityId = utf8JsonReader.GetString();
                            break;
                        case "receiverWalletAddress":
                            receiverWalletAddress = utf8JsonReader.GetString();
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = utf8JsonReader.GetDecimal();
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

            if (amountToTransfer == null)
                throw new ArgumentNullException(nameof(amountToTransfer), "Property is required for class TransferNativeTokenRequestInput.");

            if (policyId == null)
                throw new ArgumentNullException(nameof(policyId), "Property is required for class TransferNativeTokenRequestInput.");

            if (receiverEntityId == null)
                throw new ArgumentNullException(nameof(receiverEntityId), "Property is required for class TransferNativeTokenRequestInput.");

            if (receiverWalletAddress == null)
                throw new ArgumentNullException(nameof(receiverWalletAddress), "Property is required for class TransferNativeTokenRequestInput.");

            if (chainId == null)
                throw new ArgumentNullException(nameof(chainId), "Property is required for class TransferNativeTokenRequestInput.");

            if (optimistic == null)
                throw new ArgumentNullException(nameof(optimistic), "Property is required for class TransferNativeTokenRequestInput.");

            if (sponsor == null)
                throw new ArgumentNullException(nameof(sponsor), "Property is required for class TransferNativeTokenRequestInput.");

            return new TransferNativeTokenRequestInput(amountToTransfer, policyId, receiverEntityId, receiverWalletAddress, chainId.Value, optimistic.Value, sponsor.Value);
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
            writer.WriteString("amountToTransfer", transferNativeTokenRequestInput.AmountToTransfer);
            writer.WriteString("policyId", transferNativeTokenRequestInput.PolicyId);
            writer.WriteString("receiverEntityId", transferNativeTokenRequestInput.ReceiverEntityId);
            writer.WriteString("receiverWalletAddress", transferNativeTokenRequestInput.ReceiverWalletAddress);
            writer.WriteNumber("chainId", transferNativeTokenRequestInput.ChainId);
            writer.WriteBoolean("optimistic", transferNativeTokenRequestInput.Optimistic);
            writer.WriteBoolean("sponsor", transferNativeTokenRequestInput.Sponsor);
        }
    }
}
