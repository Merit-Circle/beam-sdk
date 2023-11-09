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
    /// AddPolicyResponse
    /// </summary>
    public partial class AddPolicyResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddPolicyResponse" /> class.
        /// </summary>
        /// <param name="chainId">chainId</param>
        /// <param name="id">id</param>
        /// <param name="amount">amount</param>
        /// <param name="rateType">rateType</param>
        /// <param name="token">token</param>
        [JsonConstructor]
        public AddPolicyResponse(int chainId, string id, string amount = default, RateTypeEnum? rateType = default, string token = default)
        {
            ChainId = chainId;
            Id = id;
            Amount = amount;
            RateType = rateType;
            Token = token;
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
        public static string? RateTypeEnumToJsonValue(RateTypeEnum? value)
        {
            if (value == null)
                return null;

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
        public RateTypeEnum? RateType { get; set; }

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public int ChainId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddPolicyResponse {\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  RateType: ").Append(RateType).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
    /// A Json converter for type <see cref="AddPolicyResponse" />
    /// </summary>
    public class AddPolicyResponseJsonConverter : JsonConverter<AddPolicyResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="AddPolicyResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AddPolicyResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            int? chainId = default;
            string id = default;
            string amount = default;
            AddPolicyResponse.RateTypeEnum? rateType = default;
            string token = default;

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
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = utf8JsonReader.GetInt32();
                            break;
                        case "id":
                            id = utf8JsonReader.GetString();
                            break;
                        case "amount":
                            amount = utf8JsonReader.GetString();
                            break;
                        case "rateType":
                            string rateTypeRawValue = utf8JsonReader.GetString();
                            rateType = rateTypeRawValue == null
                                ? null
                                : AddPolicyResponse.RateTypeEnumFromStringOrDefault(rateTypeRawValue);
                            break;
                        case "token":
                            token = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (chainId == null)
                throw new ArgumentNullException(nameof(chainId), "Property is required for class AddPolicyResponse.");

            if (id == null)
                throw new ArgumentNullException(nameof(id), "Property is required for class AddPolicyResponse.");

            return new AddPolicyResponse(chainId.Value, id, amount, rateType, token);
        }

        /// <summary>
        /// Serializes a <see cref="AddPolicyResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="addPolicyResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AddPolicyResponse addPolicyResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, addPolicyResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AddPolicyResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="addPolicyResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, AddPolicyResponse addPolicyResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteNumber("chainId", addPolicyResponse.ChainId);
            writer.WriteString("id", addPolicyResponse.Id);
            writer.WriteString("amount", addPolicyResponse.Amount);

            var rateTypeRawValue = AddPolicyResponse.RateTypeEnumToJsonValue(addPolicyResponse.RateType);
            if (rateTypeRawValue != null)
                writer.WriteString("rateType", rateTypeRawValue);
            else
                writer.WriteNull("rateType");

            writer.WriteString("token", addPolicyResponse.Token);
        }
    }
}
