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
    /// TransferAssetRequestInputAssetsInner
    /// </summary>
    public partial class TransferAssetRequestInputAssetsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferAssetRequestInputAssetsInner" /> class.
        /// </summary>
        /// <param name="assetAddress">assetAddress</param>
        /// <param name="assetId">assetId</param>
        /// <param name="receiverEntityId">receiverEntityId</param>
        /// <param name="receiverWalletAddress">receiverWalletAddress</param>
        /// <param name="amountToTransfer">amountToTransfer (default to 1M)</param>
        [JsonConstructor]
        public TransferAssetRequestInputAssetsInner(string assetAddress, string assetId, string receiverEntityId, string receiverWalletAddress, decimal amountToTransfer = 1M)
        {
            AssetAddress = assetAddress;
            AssetId = assetId;
            ReceiverEntityId = receiverEntityId;
            ReceiverWalletAddress = receiverWalletAddress;
            AmountToTransfer = amountToTransfer;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets AssetAddress
        /// </summary>
        [JsonPropertyName("assetAddress")]
        public string AssetAddress { get; set; }

        /// <summary>
        /// Gets or Sets AssetId
        /// </summary>
        [JsonPropertyName("assetId")]
        public string AssetId { get; set; }

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
        /// Gets or Sets AmountToTransfer
        /// </summary>
        [JsonPropertyName("amountToTransfer")]
        public decimal AmountToTransfer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferAssetRequestInputAssetsInner {\n");
            sb.Append("  AssetAddress: ").Append(AssetAddress).Append("\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  ReceiverEntityId: ").Append(ReceiverEntityId).Append("\n");
            sb.Append("  ReceiverWalletAddress: ").Append(ReceiverWalletAddress).Append("\n");
            sb.Append("  AmountToTransfer: ").Append(AmountToTransfer).Append("\n");
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
            // AmountToTransfer (decimal) minimum
            if (this.AmountToTransfer < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AmountToTransfer, must be a value greater than or equal to 0.", new [] { "AmountToTransfer" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="TransferAssetRequestInputAssetsInner" />
    /// </summary>
    public class TransferAssetRequestInputAssetsInnerJsonConverter : JsonConverter<TransferAssetRequestInputAssetsInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="TransferAssetRequestInputAssetsInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TransferAssetRequestInputAssetsInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string assetAddress = default;
            string assetId = default;
            string receiverEntityId = default;
            string receiverWalletAddress = default;
            decimal? amountToTransfer = default;

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
                        case "assetAddress":
                            assetAddress = utf8JsonReader.GetString();
                            break;
                        case "assetId":
                            assetId = utf8JsonReader.GetString();
                            break;
                        case "receiverEntityId":
                            receiverEntityId = utf8JsonReader.GetString();
                            break;
                        case "receiverWalletAddress":
                            receiverWalletAddress = utf8JsonReader.GetString();
                            break;
                        case "amountToTransfer":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                amountToTransfer = utf8JsonReader.GetDecimal();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (assetAddress == null)
                throw new ArgumentNullException(nameof(assetAddress), "Property is required for class TransferAssetRequestInputAssetsInner.");

            if (assetId == null)
                throw new ArgumentNullException(nameof(assetId), "Property is required for class TransferAssetRequestInputAssetsInner.");

            if (receiverEntityId == null)
                throw new ArgumentNullException(nameof(receiverEntityId), "Property is required for class TransferAssetRequestInputAssetsInner.");

            if (receiverWalletAddress == null)
                throw new ArgumentNullException(nameof(receiverWalletAddress), "Property is required for class TransferAssetRequestInputAssetsInner.");

            if (amountToTransfer == null)
                throw new ArgumentNullException(nameof(amountToTransfer), "Property is required for class TransferAssetRequestInputAssetsInner.");

            return new TransferAssetRequestInputAssetsInner(assetAddress, assetId, receiverEntityId, receiverWalletAddress, amountToTransfer.Value);
        }

        /// <summary>
        /// Serializes a <see cref="TransferAssetRequestInputAssetsInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="transferAssetRequestInputAssetsInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TransferAssetRequestInputAssetsInner transferAssetRequestInputAssetsInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, transferAssetRequestInputAssetsInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TransferAssetRequestInputAssetsInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="transferAssetRequestInputAssetsInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, TransferAssetRequestInputAssetsInner transferAssetRequestInputAssetsInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteString("assetAddress", transferAssetRequestInputAssetsInner.AssetAddress);
            writer.WriteString("assetId", transferAssetRequestInputAssetsInner.AssetId);
            writer.WriteString("receiverEntityId", transferAssetRequestInputAssetsInner.ReceiverEntityId);
            writer.WriteString("receiverWalletAddress", transferAssetRequestInputAssetsInner.ReceiverWalletAddress);
            writer.WriteNumber("amountToTransfer", transferAssetRequestInputAssetsInner.AmountToTransfer);
        }
    }
}
