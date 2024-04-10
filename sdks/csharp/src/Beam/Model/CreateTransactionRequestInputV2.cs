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
    /// CreateTransactionRequestInputV2
    /// </summary>
    public partial class CreateTransactionRequestInputV2 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransactionRequestInputV2" /> class.
        /// </summary>
        /// <param name="interactions">interactions</param>
        /// <param name="chainId">chainId (default to 13337M)</param>
        /// <param name="optimistic">optimistic (default to false)</param>
        /// <param name="policyId">policyId</param>
        /// <param name="sponsor">sponsor (default to true)</param>
        [JsonConstructor]
        public CreateTransactionRequestInputV2(List<CreateTransactionRequestInputV2InteractionsInner> interactions, Option<decimal?> chainId = default, Option<bool?> optimistic = default, Option<string?> policyId = default, Option<bool?> sponsor = default)
        {
            Interactions = interactions;
            ChainIdOption = chainId;
            OptimisticOption = optimistic;
            PolicyIdOption = policyId;
            SponsorOption = sponsor;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Interactions
        /// </summary>
        [JsonPropertyName("interactions")]
        public List<CreateTransactionRequestInputV2InteractionsInner> Interactions { get; set; }

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
        public Option<string?> PolicyIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets PolicyId
        /// </summary>
        [JsonPropertyName("policyId")]
        public string? PolicyId { get { return this. PolicyIdOption; } set { this.PolicyIdOption = new(value); } }

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
            sb.Append("class CreateTransactionRequestInputV2 {\n");
            sb.Append("  Interactions: ").Append(Interactions).Append("\n");
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
    /// A Json converter for type <see cref="CreateTransactionRequestInputV2" />
    /// </summary>
    public class CreateTransactionRequestInputV2JsonConverter : JsonConverter<CreateTransactionRequestInputV2>
    {
        /// <summary>
        /// Deserializes json to <see cref="CreateTransactionRequestInputV2" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CreateTransactionRequestInputV2 Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<CreateTransactionRequestInputV2InteractionsInner>?> interactions = default;
            Option<decimal?> chainId = default;
            Option<bool?> optimistic = default;
            Option<string?> policyId = default;
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
                        case "interactions":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                interactions = new Option<List<CreateTransactionRequestInputV2InteractionsInner>?>(JsonSerializer.Deserialize<List<CreateTransactionRequestInputV2InteractionsInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
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
                            policyId = new Option<string?>(utf8JsonReader.GetString());
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

            if (!interactions.IsSet)
                throw new ArgumentException("Property is required for class CreateTransactionRequestInputV2.", nameof(interactions));

            if (interactions.IsSet && interactions.Value == null)
                throw new ArgumentNullException(nameof(interactions), "Property is not nullable for class CreateTransactionRequestInputV2.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class CreateTransactionRequestInputV2.");

            if (optimistic.IsSet && optimistic.Value == null)
                throw new ArgumentNullException(nameof(optimistic), "Property is not nullable for class CreateTransactionRequestInputV2.");

            if (sponsor.IsSet && sponsor.Value == null)
                throw new ArgumentNullException(nameof(sponsor), "Property is not nullable for class CreateTransactionRequestInputV2.");

            return new CreateTransactionRequestInputV2(interactions.Value!, chainId, optimistic, policyId, sponsor);
        }

        /// <summary>
        /// Serializes a <see cref="CreateTransactionRequestInputV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createTransactionRequestInputV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CreateTransactionRequestInputV2 createTransactionRequestInputV2, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, createTransactionRequestInputV2, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CreateTransactionRequestInputV2" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createTransactionRequestInputV2"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, CreateTransactionRequestInputV2 createTransactionRequestInputV2, JsonSerializerOptions jsonSerializerOptions)
        {
            if (createTransactionRequestInputV2.Interactions == null)
                throw new ArgumentNullException(nameof(createTransactionRequestInputV2.Interactions), "Property is required for class CreateTransactionRequestInputV2.");

            writer.WritePropertyName("interactions");
            JsonSerializer.Serialize(writer, createTransactionRequestInputV2.Interactions, jsonSerializerOptions);
            if (createTransactionRequestInputV2.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", createTransactionRequestInputV2.ChainIdOption.Value!.Value);

            if (createTransactionRequestInputV2.OptimisticOption.IsSet)
                writer.WriteBoolean("optimistic", createTransactionRequestInputV2.OptimisticOption.Value!.Value);

            if (createTransactionRequestInputV2.PolicyIdOption.IsSet)
                if (createTransactionRequestInputV2.PolicyIdOption.Value != null)
                    writer.WriteString("policyId", createTransactionRequestInputV2.PolicyId);
                else
                    writer.WriteNull("policyId");

            if (createTransactionRequestInputV2.SponsorOption.IsSet)
                writer.WriteBoolean("sponsor", createTransactionRequestInputV2.SponsorOption.Value!.Value);
        }
    }
}