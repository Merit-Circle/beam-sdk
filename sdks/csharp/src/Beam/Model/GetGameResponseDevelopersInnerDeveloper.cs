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
    /// GetGameResponseDevelopersInnerDeveloper
    /// </summary>
    public partial class GetGameResponseDevelopersInnerDeveloper : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetGameResponseDevelopersInnerDeveloper" /> class.
        /// </summary>
        /// <param name="email">email</param>
        /// <param name="id">id</param>
        /// <param name="createdAt">createdAt</param>
        /// <param name="externalId">externalId</param>
        /// <param name="lastSeenAt">lastSeenAt</param>
        /// <param name="name">name</param>
        [JsonConstructor]
        public GetGameResponseDevelopersInnerDeveloper(string email, string id, Object createdAt = default, string externalId = default, Object lastSeenAt = default, string name = default)
        {
            Email = email;
            Id = id;
            CreatedAt = createdAt;
            ExternalId = externalId;
            LastSeenAt = lastSeenAt;
            Name = name;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [JsonPropertyName("createdAt")]
        public Object CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ExternalId
        /// </summary>
        [JsonPropertyName("externalId")]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets LastSeenAt
        /// </summary>
        [JsonPropertyName("lastSeenAt")]
        public Object LastSeenAt { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetGameResponseDevelopersInnerDeveloper {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  LastSeenAt: ").Append(LastSeenAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
    /// A Json converter for type <see cref="GetGameResponseDevelopersInnerDeveloper" />
    /// </summary>
    public class GetGameResponseDevelopersInnerDeveloperJsonConverter : JsonConverter<GetGameResponseDevelopersInnerDeveloper>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetGameResponseDevelopersInnerDeveloper" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetGameResponseDevelopersInnerDeveloper Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> email = default;
            Option<string> id = default;
            Option<Object> createdAt = default;
            Option<string> externalId = default;
            Option<Object> lastSeenAt = default;
            Option<string> name = default;

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
                        case "email":
                            email = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "id":
                            id = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "createdAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdAt = new Option<Object>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "externalId":
                            externalId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "lastSeenAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lastSeenAt = new Option<Object>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "name":
                            name = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!email.IsSet)
                throw new ArgumentException("Property is required for class GetGameResponseDevelopersInnerDeveloper.", nameof(email));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class GetGameResponseDevelopersInnerDeveloper.", nameof(id));

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class GetGameResponseDevelopersInnerDeveloper.", nameof(createdAt));

            if (!externalId.IsSet)
                throw new ArgumentException("Property is required for class GetGameResponseDevelopersInnerDeveloper.", nameof(externalId));

            if (!lastSeenAt.IsSet)
                throw new ArgumentException("Property is required for class GetGameResponseDevelopersInnerDeveloper.", nameof(lastSeenAt));

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class GetGameResponseDevelopersInnerDeveloper.", nameof(name));

            if (email.IsSet && email.Value == null)
                throw new ArgumentNullException(nameof(email), "Property is not nullable for class GetGameResponseDevelopersInnerDeveloper.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class GetGameResponseDevelopersInnerDeveloper.");

            return new GetGameResponseDevelopersInnerDeveloper(email.Value, id.Value, createdAt.Value, externalId.Value, lastSeenAt.Value, name.Value);
        }

        /// <summary>
        /// Serializes a <see cref="GetGameResponseDevelopersInnerDeveloper" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getGameResponseDevelopersInnerDeveloper"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetGameResponseDevelopersInnerDeveloper getGameResponseDevelopersInnerDeveloper, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getGameResponseDevelopersInnerDeveloper, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetGameResponseDevelopersInnerDeveloper" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getGameResponseDevelopersInnerDeveloper"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetGameResponseDevelopersInnerDeveloper getGameResponseDevelopersInnerDeveloper, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getGameResponseDevelopersInnerDeveloper.Email == null)
                throw new ArgumentNullException(nameof(getGameResponseDevelopersInnerDeveloper.Email), "Property is required for class GetGameResponseDevelopersInnerDeveloper.");

            if (getGameResponseDevelopersInnerDeveloper.Id == null)
                throw new ArgumentNullException(nameof(getGameResponseDevelopersInnerDeveloper.Id), "Property is required for class GetGameResponseDevelopersInnerDeveloper.");

            writer.WriteString("email", getGameResponseDevelopersInnerDeveloper.Email);

            writer.WriteString("id", getGameResponseDevelopersInnerDeveloper.Id);

            if (getGameResponseDevelopersInnerDeveloper.CreatedAt != null)
            {
                writer.WritePropertyName("createdAt");
                JsonSerializer.Serialize(writer, getGameResponseDevelopersInnerDeveloper.CreatedAt, jsonSerializerOptions);
            }
            else
                writer.WriteNull("createdAt");
            if (getGameResponseDevelopersInnerDeveloper.ExternalId != null)
                writer.WriteString("externalId", getGameResponseDevelopersInnerDeveloper.ExternalId);
            else
                writer.WriteNull("externalId");

            if (getGameResponseDevelopersInnerDeveloper.LastSeenAt != null)
            {
                writer.WritePropertyName("lastSeenAt");
                JsonSerializer.Serialize(writer, getGameResponseDevelopersInnerDeveloper.LastSeenAt, jsonSerializerOptions);
            }
            else
                writer.WriteNull("lastSeenAt");
            if (getGameResponseDevelopersInnerDeveloper.Name != null)
                writer.WriteString("name", getGameResponseDevelopersInnerDeveloper.Name);
            else
                writer.WriteNull("name");
        }
    }
}
