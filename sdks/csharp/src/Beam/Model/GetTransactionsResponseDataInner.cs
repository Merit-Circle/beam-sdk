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
    /// GetTransactionsResponseDataInner
    /// </summary>
    public partial class GetTransactionsResponseDataInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionsResponseDataInner" /> class.
        /// </summary>
        /// <param name="chainId">chainId</param>
        /// <param name="createdAt">createdAt</param>
        /// <param name="id">id</param>
        /// <param name="interactions">interactions</param>
        /// <param name="response">response</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="userOperationHash">userOperationHash</param>
        /// <param name="userOperation">userOperation</param>
        [JsonConstructor]
        public GetTransactionsResponseDataInner(decimal chainId, decimal createdAt, string id, List<GetTransactionsResponseDataInnerInteractionsInner> interactions, GetTransactionsResponseDataInnerResponse response, decimal updatedAt, string userOperationHash, Object userOperation = default)
        {
            ChainId = chainId;
            CreatedAt = createdAt;
            Id = id;
            Interactions = interactions;
            Response = response;
            UpdatedAt = updatedAt;
            UserOperationHash = userOperationHash;
            UserOperation = userOperation;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets ChainId
        /// </summary>
        [JsonPropertyName("chainId")]
        public decimal ChainId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [JsonPropertyName("createdAt")]
        public decimal CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Interactions
        /// </summary>
        [JsonPropertyName("interactions")]
        public List<GetTransactionsResponseDataInnerInteractionsInner> Interactions { get; set; }

        /// <summary>
        /// Gets or Sets Response
        /// </summary>
        [JsonPropertyName("response")]
        public GetTransactionsResponseDataInnerResponse Response { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public decimal UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UserOperationHash
        /// </summary>
        [JsonPropertyName("userOperationHash")]
        public string UserOperationHash { get; set; }

        /// <summary>
        /// Gets or Sets UserOperation
        /// </summary>
        [JsonPropertyName("userOperation")]
        public Object UserOperation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTransactionsResponseDataInner {\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Interactions: ").Append(Interactions).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  UserOperationHash: ").Append(UserOperationHash).Append("\n");
            sb.Append("  UserOperation: ").Append(UserOperation).Append("\n");
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
    /// A Json converter for type <see cref="GetTransactionsResponseDataInner" />
    /// </summary>
    public class GetTransactionsResponseDataInnerJsonConverter : JsonConverter<GetTransactionsResponseDataInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetTransactionsResponseDataInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetTransactionsResponseDataInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            decimal? chainId = default;
            decimal? createdAt = default;
            string id = default;
            List<GetTransactionsResponseDataInnerInteractionsInner> interactions = default;
            GetTransactionsResponseDataInnerResponse response = default;
            decimal? updatedAt = default;
            string userOperationHash = default;
            Object userOperation = default;

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
                                chainId = utf8JsonReader.GetDecimal();
                            break;
                        case "createdAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdAt = utf8JsonReader.GetDecimal();
                            break;
                        case "id":
                            id = utf8JsonReader.GetString();
                            break;
                        case "interactions":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                interactions = JsonSerializer.Deserialize<List<GetTransactionsResponseDataInnerInteractionsInner>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "response":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                response = JsonSerializer.Deserialize<GetTransactionsResponseDataInnerResponse>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "updatedAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                updatedAt = utf8JsonReader.GetDecimal();
                            break;
                        case "userOperationHash":
                            userOperationHash = utf8JsonReader.GetString();
                            break;
                        case "userOperation":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                userOperation = JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (chainId == null)
                throw new ArgumentNullException(nameof(chainId), "Property is required for class GetTransactionsResponseDataInner.");

            if (createdAt == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is required for class GetTransactionsResponseDataInner.");

            if (id == null)
                throw new ArgumentNullException(nameof(id), "Property is required for class GetTransactionsResponseDataInner.");

            if (interactions == null)
                throw new ArgumentNullException(nameof(interactions), "Property is required for class GetTransactionsResponseDataInner.");

            if (response == null)
                throw new ArgumentNullException(nameof(response), "Property is required for class GetTransactionsResponseDataInner.");

            if (updatedAt == null)
                throw new ArgumentNullException(nameof(updatedAt), "Property is required for class GetTransactionsResponseDataInner.");

            if (userOperationHash == null)
                throw new ArgumentNullException(nameof(userOperationHash), "Property is required for class GetTransactionsResponseDataInner.");

            return new GetTransactionsResponseDataInner(chainId.Value, createdAt.Value, id, interactions, response, updatedAt.Value, userOperationHash, userOperation);
        }

        /// <summary>
        /// Serializes a <see cref="GetTransactionsResponseDataInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getTransactionsResponseDataInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetTransactionsResponseDataInner getTransactionsResponseDataInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getTransactionsResponseDataInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetTransactionsResponseDataInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getTransactionsResponseDataInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetTransactionsResponseDataInner getTransactionsResponseDataInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteNumber("chainId", getTransactionsResponseDataInner.ChainId);
            writer.WriteNumber("createdAt", getTransactionsResponseDataInner.CreatedAt);
            writer.WriteString("id", getTransactionsResponseDataInner.Id);
            writer.WritePropertyName("interactions");
            JsonSerializer.Serialize(writer, getTransactionsResponseDataInner.Interactions, jsonSerializerOptions);
            writer.WritePropertyName("response");
            JsonSerializer.Serialize(writer, getTransactionsResponseDataInner.Response, jsonSerializerOptions);
            writer.WriteNumber("updatedAt", getTransactionsResponseDataInner.UpdatedAt);
            writer.WriteString("userOperationHash", getTransactionsResponseDataInner.UserOperationHash);
            writer.WritePropertyName("userOperation");
            JsonSerializer.Serialize(writer, getTransactionsResponseDataInner.UserOperation, jsonSerializerOptions);
        }
    }
}
