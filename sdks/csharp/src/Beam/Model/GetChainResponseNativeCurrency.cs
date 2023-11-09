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
    /// GetChainResponseNativeCurrency
    /// </summary>
    public partial class GetChainResponseNativeCurrency : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetChainResponseNativeCurrency" /> class.
        /// </summary>
        /// <param name="decimals">decimals</param>
        /// <param name="name">name</param>
        /// <param name="symbol">symbol</param>
        [JsonConstructor]
        public GetChainResponseNativeCurrency(decimal decimals, string name, string symbol)
        {
            Decimals = decimals;
            Name = name;
            Symbol = symbol;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Decimals
        /// </summary>
        [JsonPropertyName("decimals")]
        public decimal Decimals { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetChainResponseNativeCurrency {\n");
            sb.Append("  Decimals: ").Append(Decimals).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
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
    /// A Json converter for type <see cref="GetChainResponseNativeCurrency" />
    /// </summary>
    public class GetChainResponseNativeCurrencyJsonConverter : JsonConverter<GetChainResponseNativeCurrency>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetChainResponseNativeCurrency" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetChainResponseNativeCurrency Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            decimal? decimals = default;
            string name = default;
            string symbol = default;

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
                        case "decimals":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                decimals = utf8JsonReader.GetDecimal();
                            break;
                        case "name":
                            name = utf8JsonReader.GetString();
                            break;
                        case "symbol":
                            symbol = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (decimals == null)
                throw new ArgumentNullException(nameof(decimals), "Property is required for class GetChainResponseNativeCurrency.");

            if (name == null)
                throw new ArgumentNullException(nameof(name), "Property is required for class GetChainResponseNativeCurrency.");

            if (symbol == null)
                throw new ArgumentNullException(nameof(symbol), "Property is required for class GetChainResponseNativeCurrency.");

            return new GetChainResponseNativeCurrency(decimals.Value, name, symbol);
        }

        /// <summary>
        /// Serializes a <see cref="GetChainResponseNativeCurrency" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getChainResponseNativeCurrency"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetChainResponseNativeCurrency getChainResponseNativeCurrency, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getChainResponseNativeCurrency, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetChainResponseNativeCurrency" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getChainResponseNativeCurrency"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetChainResponseNativeCurrency getChainResponseNativeCurrency, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteNumber("decimals", getChainResponseNativeCurrency.Decimals);
            writer.WriteString("name", getChainResponseNativeCurrency.Name);
            writer.WriteString("symbol", getChainResponseNativeCurrency.Symbol);
        }
    }
}
