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
    /// AddPolicyRequestInput
    /// </summary>
    public partial class AddPolicyRequestInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddPolicyRequestInput" /> class.
        /// </summary>
        /// <param name="amount">amount</param>
        /// <param name="rateType">rateType</param>
        /// <param name="tokenAddress">tokenAddress</param>
        /// <param name="chainId">chainId (default to 13337M)</param>
        [JsonConstructor]
        public AddPolicyRequestInput(decimal amount, RateTypeEnum rateType, string tokenAddress, Option<decimal?> chainId = default)
        {
            Amount = amount;
            RateType = rateType;
            TokenAddress = tokenAddress;
            ChainIdOption = chainId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines RateType
        /// </summary>
        public enum RateTypeEnum
        {
            /// <summary>
            /// Enum Fixed for value: Fixed
            /// </summary>
            Fixed = 1,

            /// <summary>
            /// Enum Dynamic for value: Dynamic
            /// </summary>
            Dynamic = 2
        }

        /// <summary>
        /// Returns a <see cref="RateTypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static RateTypeEnum RateTypeEnumFromString(string value)
        {
            if (value.Equals("Fixed"))
                return RateTypeEnum.Fixed;

            if (value.Equals("Dynamic"))
                return RateTypeEnum.Dynamic;

            throw new NotImplementedException($"Could not convert value to type RateTypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="RateTypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RateTypeEnum? RateTypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("Fixed"))
                return RateTypeEnum.Fixed;

            if (value.Equals("Dynamic"))
                return RateTypeEnum.Dynamic;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="RateTypeEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string RateTypeEnumToJsonValue(RateTypeEnum value)
        {
            if (value == RateTypeEnum.Fixed)
                return "Fixed";

            if (value == RateTypeEnum.Dynamic)
                return "Dynamic";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets RateType
        /// </summary>
        [JsonPropertyName("rateType")]
        public RateTypeEnum RateType { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or Sets TokenAddress
        /// </summary>
        [JsonPropertyName("tokenAddress")]
        public string TokenAddress { get; set; }

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
            sb.Append("class AddPolicyRequestInput {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  RateType: ").Append(RateType).Append("\n");
            sb.Append("  TokenAddress: ").Append(TokenAddress).Append("\n");
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
            // Amount (decimal) minimum
            if (this.Amount < (decimal)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must be a value greater than or equal to 1.", new [] { "Amount" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="AddPolicyRequestInput" />
    /// </summary>
    public class AddPolicyRequestInputJsonConverter : JsonConverter<AddPolicyRequestInput>
    {
        /// <summary>
        /// Deserializes json to <see cref="AddPolicyRequestInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AddPolicyRequestInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<decimal?> amount = default;
            Option<AddPolicyRequestInput.RateTypeEnum?> rateType = default;
            Option<string?> tokenAddress = default;
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
                        case "amount":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                amount = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "rateType":
                            string? rateTypeRawValue = utf8JsonReader.GetString();
                            if (rateTypeRawValue != null)
                                rateType = new Option<AddPolicyRequestInput.RateTypeEnum?>(AddPolicyRequestInput.RateTypeEnumFromStringOrDefault(rateTypeRawValue));
                            break;
                        case "tokenAddress":
                            tokenAddress = new Option<string?>(utf8JsonReader.GetString()!);
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

            if (!amount.IsSet)
                throw new ArgumentException("Property is required for class AddPolicyRequestInput.", nameof(amount));

            if (!rateType.IsSet)
                throw new ArgumentException("Property is required for class AddPolicyRequestInput.", nameof(rateType));

            if (!tokenAddress.IsSet)
                throw new ArgumentException("Property is required for class AddPolicyRequestInput.", nameof(tokenAddress));

            if (amount.IsSet && amount.Value == null)
                throw new ArgumentNullException(nameof(amount), "Property is not nullable for class AddPolicyRequestInput.");

            if (rateType.IsSet && rateType.Value == null)
                throw new ArgumentNullException(nameof(rateType), "Property is not nullable for class AddPolicyRequestInput.");

            if (tokenAddress.IsSet && tokenAddress.Value == null)
                throw new ArgumentNullException(nameof(tokenAddress), "Property is not nullable for class AddPolicyRequestInput.");

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class AddPolicyRequestInput.");

            return new AddPolicyRequestInput(amount.Value!.Value!, rateType.Value!.Value!, tokenAddress.Value!, chainId);
        }

        /// <summary>
        /// Serializes a <see cref="AddPolicyRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="addPolicyRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AddPolicyRequestInput addPolicyRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, addPolicyRequestInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AddPolicyRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="addPolicyRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, AddPolicyRequestInput addPolicyRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            if (addPolicyRequestInput.TokenAddress == null)
                throw new ArgumentNullException(nameof(addPolicyRequestInput.TokenAddress), "Property is required for class AddPolicyRequestInput.");

            writer.WriteNumber("amount", addPolicyRequestInput.Amount);

            var rateTypeRawValue = AddPolicyRequestInput.RateTypeEnumToJsonValue(addPolicyRequestInput.RateType);
            writer.WriteString("rateType", rateTypeRawValue);
            writer.WriteString("tokenAddress", addPolicyRequestInput.TokenAddress);

            if (addPolicyRequestInput.ChainIdOption.IsSet)
                writer.WriteNumber("chainId", addPolicyRequestInput.ChainIdOption.Value!.Value);
        }
    }
}