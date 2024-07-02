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
        /// <param name="intent">intent</param>
        /// <param name="updatedAt">updatedAt</param>
        /// <param name="transaction">transaction</param>
        [JsonConstructor]
        public GetTransactionsResponseDataInner(decimal chainId, DateTime createdAt, string id, GetTransactionsResponseDataInnerIntent intent, DateTime updatedAt, Option<GetTransactionsResponseDataInnerTransaction?> transaction = default)
        {
            ChainId = chainId;
            CreatedAt = createdAt;
            Id = id;
            Intent = intent;
            UpdatedAt = updatedAt;
            TransactionOption = transaction;
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
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Intent
        /// </summary>
        [JsonPropertyName("intent")]
        public GetTransactionsResponseDataInnerIntent Intent { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Used to track the state of Transaction
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<GetTransactionsResponseDataInnerTransaction?> TransactionOption { get; private set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [JsonPropertyName("transaction")]
        public GetTransactionsResponseDataInnerTransaction? Transaction { get { return this. TransactionOption; } set { this.TransactionOption = new(value); } }

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
            sb.Append("  Intent: ").Append(Intent).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
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
        /// The format to use to serialize CreatedAt
        /// </summary>
        public static string CreatedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize UpdatedAt
        /// </summary>
        public static string UpdatedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

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

            Option<decimal?> chainId = default;
            Option<DateTime?> createdAt = default;
            Option<string?> id = default;
            Option<GetTransactionsResponseDataInnerIntent?> intent = default;
            Option<DateTime?> updatedAt = default;
            Option<GetTransactionsResponseDataInnerTransaction?> transaction = default;

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
                        case "chainId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                chainId = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "createdAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "intent":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                intent = new Option<GetTransactionsResponseDataInnerIntent?>(JsonSerializer.Deserialize<GetTransactionsResponseDataInnerIntent>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "updatedAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                updatedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "transaction":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                transaction = new Option<GetTransactionsResponseDataInnerTransaction?>(JsonSerializer.Deserialize<GetTransactionsResponseDataInnerTransaction>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!chainId.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionsResponseDataInner.", nameof(chainId));

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionsResponseDataInner.", nameof(createdAt));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionsResponseDataInner.", nameof(id));

            if (!intent.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionsResponseDataInner.", nameof(intent));

            if (!updatedAt.IsSet)
                throw new ArgumentException("Property is required for class GetTransactionsResponseDataInner.", nameof(updatedAt));

            if (chainId.IsSet && chainId.Value == null)
                throw new ArgumentNullException(nameof(chainId), "Property is not nullable for class GetTransactionsResponseDataInner.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class GetTransactionsResponseDataInner.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class GetTransactionsResponseDataInner.");

            if (intent.IsSet && intent.Value == null)
                throw new ArgumentNullException(nameof(intent), "Property is not nullable for class GetTransactionsResponseDataInner.");

            if (updatedAt.IsSet && updatedAt.Value == null)
                throw new ArgumentNullException(nameof(updatedAt), "Property is not nullable for class GetTransactionsResponseDataInner.");

            return new GetTransactionsResponseDataInner(chainId.Value!.Value!, createdAt.Value!.Value!, id.Value!, intent.Value!, updatedAt.Value!.Value!, transaction);
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
            if (getTransactionsResponseDataInner.Id == null)
                throw new ArgumentNullException(nameof(getTransactionsResponseDataInner.Id), "Property is required for class GetTransactionsResponseDataInner.");

            if (getTransactionsResponseDataInner.Intent == null)
                throw new ArgumentNullException(nameof(getTransactionsResponseDataInner.Intent), "Property is required for class GetTransactionsResponseDataInner.");

            writer.WriteNumber("chainId", getTransactionsResponseDataInner.ChainId);

            writer.WriteString("createdAt", getTransactionsResponseDataInner.CreatedAt.ToString(CreatedAtFormat));

            writer.WriteString("id", getTransactionsResponseDataInner.Id);

            writer.WritePropertyName("intent");
            JsonSerializer.Serialize(writer, getTransactionsResponseDataInner.Intent, jsonSerializerOptions);
            writer.WriteString("updatedAt", getTransactionsResponseDataInner.UpdatedAt.ToString(UpdatedAtFormat));

            if (getTransactionsResponseDataInner.TransactionOption.IsSet)
                if (getTransactionsResponseDataInner.TransactionOption.Value != null)
                {
                    writer.WritePropertyName("transaction");
                    JsonSerializer.Serialize(writer, getTransactionsResponseDataInner.Transaction, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("transaction");
        }
    }
}