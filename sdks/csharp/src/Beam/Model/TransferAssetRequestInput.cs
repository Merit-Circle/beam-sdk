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
    /// TransferAssetRequestInput
    /// </summary>
    public partial class TransferAssetRequestInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferAssetRequestInput" /> class.
        /// </summary>
        /// <param name="assets">assets</param>
        /// <param name="chainId">chainId (default to 13337M)</param>
        /// <param name="optimistic">optimistic (default to false)</param>
        /// <param name="policyId">policyId</param>
        /// <param name="sponsor">sponsor (default to true)</param>
        [JsonConstructor]
        public TransferAssetRequestInput(List<TransferAssetRequestInputAssetsInner> assets, Option<decimal?> chainId = default, Option<bool?> optimistic = default, Option<string> policyId = default, Option<bool?> sponsor = default)
        {
            Assets = assets;
            ChainIdOption = chainId;
            OptimisticOption = optimistic;
            PolicyIdOption = policyId;
            SponsorOption = sponsor;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Assets
        /// </summary>
        [JsonPropertyName("assets")]
        public List<TransferAssetRequestInputAssetsInner> Assets { get; set; }

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
        public Option<string> PolicyIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets PolicyId
        /// </summary>
        [JsonPropertyName("policyId")]
        public string PolicyId { get { return this. PolicyIdOption; } set { this.PolicyIdOption = new(value); } }

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
            sb.Append("class TransferAssetRequestInput {\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Optimistic: ").Append(Optimistic).Append("\n");
            sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
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
    /// A Json converter for type <see cref="TransferAssetRequestInput" />
    /// </summary>
    public class TransferAssetRequestInputJsonConverter : JsonConverter<TransferAssetRequestInput>
    {
        /// <summary>
        /// Deserializes json to <see cref="TransferAssetRequestInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TransferAssetRequestInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<TransferAssetRequestInputAssetsInner>> assets = default;
            Option<decimal?> chainId = default;
            Option<bool?> optimistic = default;
            Option<string> policyId = default;
            Option<bool?> sponsor = default;

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
                        case "assets":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                assets = new Option<List<TransferAssetRequestInputAssetsInner>>(JsonSerializer.Deserialize<List<TransferAssetRequestInputAssetsInner>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "optimistic":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                optimistic = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "policyId":
                            policyId = new Option<string>(utf8JsonReader.GetString());
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

            if (!assets.IsSet)
                throw new ArgumentException("Property is required for class TransferAssetRequestInput.", nameof(assets));

            if (assets.IsSet && assets.Value == null)
                throw new ArgumentNullException(nameof(assets), "Property is not nullable for class TransferAssetRequestInput.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class TransferAssetRequestInput.");

            if (optimistic.IsSet && optimistic.Value == null)
                throw new ArgumentNullException(nameof(optimistic), "Property is not nullable for class TransferAssetRequestInput.");

            if (sponsor.IsSet && sponsor.Value == null)
                throw new ArgumentNullException(nameof(sponsor), "Property is not nullable for class TransferAssetRequestInput.");

            return new TransferAssetRequestInput(assets.Value, chainId, optimistic, policyId, sponsor);
        }

        /// <summary>
        /// Serializes a <see cref="TransferAssetRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="transferAssetRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TransferAssetRequestInput transferAssetRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, transferAssetRequestInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TransferAssetRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="transferAssetRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, TransferAssetRequestInput transferAssetRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            if (transferAssetRequestInput.Assets == null)
                throw new ArgumentNullException(nameof(transferAssetRequestInput.Assets), "Property is required for class TransferAssetRequestInput.");

            writer.WritePropertyName("assets");
            JsonSerializer.Serialize(writer, transferAssetRequestInput.Assets, jsonSerializerOptions);
            if (transferAssetRequestInput.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", transferAssetRequestInput.ChainIdOption.Value.Value);

            if (transferAssetRequestInput.OptimisticOption.IsSet)
                writer.WriteBoolean("optimistic", transferAssetRequestInput.OptimisticOption.Value.Value);

            if (transferAssetRequestInput.PolicyIdOption.IsSet)
                if (transferAssetRequestInput.PolicyIdOption.Value != null)
                    writer.WriteString("policyId", transferAssetRequestInput.PolicyId);
                else
                    writer.WriteNull("policyId");

            if (transferAssetRequestInput.SponsorOption.IsSet)
                writer.WriteBoolean("sponsor", transferAssetRequestInput.SponsorOption.Value.Value);
        }
    }
}
