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
    /// GetTransactionsResponseDataInnerInteractionsInner
    /// </summary>
    public partial class GetTransactionsResponseDataInnerInteractionsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTransactionsResponseDataInnerInteractionsInner" /> class.
        /// </summary>
        /// <param name="contract">contract</param>
        /// <param name="functionArgs">functionArgs</param>
        /// <param name="functionName">functionName</param>
        /// <param name="to">to</param>
        /// <param name="value">value</param>
        [JsonConstructor]
        public GetTransactionsResponseDataInnerInteractionsInner(Option<string> contract = default, Option<List<Object>> functionArgs = default, Option<string> functionName = default, Option<string> to = default, Option<string> value = default)
        {
            ContractOption = contract;
            FunctionArgsOption = functionArgs;
            FunctionNameOption = functionName;
            ToOption = to;
            ValueOption = value;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Contract
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ContractOption { get; private set; }

        /// <summary>
        /// Gets or Sets Contract
        /// </summary>
        [JsonPropertyName("contract")]
        public string Contract { get { return this. ContractOption; } set { this.ContractOption = new(value); } }

        /// <summary>
        /// Used to track the state of FunctionArgs
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<Object>> FunctionArgsOption { get; private set; }

        /// <summary>
        /// Gets or Sets FunctionArgs
        /// </summary>
        [JsonPropertyName("functionArgs")]
        public List<Object> FunctionArgs { get { return this. FunctionArgsOption; } set { this.FunctionArgsOption = new(value); } }

        /// <summary>
        /// Used to track the state of FunctionName
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> FunctionNameOption { get; private set; }

        /// <summary>
        /// Gets or Sets FunctionName
        /// </summary>
        [JsonPropertyName("functionName")]
        public string FunctionName { get { return this. FunctionNameOption; } set { this.FunctionNameOption = new(value); } }

        /// <summary>
        /// Used to track the state of To
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ToOption { get; private set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [JsonPropertyName("to")]
        public string To { get { return this. ToOption; } set { this.ToOption = new(value); } }

        /// <summary>
        /// Used to track the state of Value
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ValueOption { get; private set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get { return this. ValueOption; } set { this.ValueOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTransactionsResponseDataInnerInteractionsInner {\n");
            sb.Append("  Contract: ").Append(Contract).Append("\n");
            sb.Append("  FunctionArgs: ").Append(FunctionArgs).Append("\n");
            sb.Append("  FunctionName: ").Append(FunctionName).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
    /// A Json converter for type <see cref="GetTransactionsResponseDataInnerInteractionsInner" />
    /// </summary>
    public class GetTransactionsResponseDataInnerInteractionsInnerJsonConverter : JsonConverter<GetTransactionsResponseDataInnerInteractionsInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetTransactionsResponseDataInnerInteractionsInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetTransactionsResponseDataInnerInteractionsInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> contract = default;
            Option<List<Object>> functionArgs = default;
            Option<string> functionName = default;
            Option<string> to = default;
            Option<string> value = default;

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
                        case "contract":
                            contract = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "functionArgs":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                functionArgs = new Option<List<Object>>(JsonSerializer.Deserialize<List<Object>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "functionName":
                            functionName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "to":
                            to = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "value":
                            value = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (contract.IsSet && contract.Value == null)
                throw new ArgumentNullException(nameof(contract), "Property is not nullable for class GetTransactionsResponseDataInnerInteractionsInner.");

            if (functionArgs.IsSet && functionArgs.Value == null)
                throw new ArgumentNullException(nameof(functionArgs), "Property is not nullable for class GetTransactionsResponseDataInnerInteractionsInner.");

            if (functionName.IsSet && functionName.Value == null)
                throw new ArgumentNullException(nameof(functionName), "Property is not nullable for class GetTransactionsResponseDataInnerInteractionsInner.");

            if (to.IsSet && to.Value == null)
                throw new ArgumentNullException(nameof(to), "Property is not nullable for class GetTransactionsResponseDataInnerInteractionsInner.");

            if (value.IsSet && value.Value == null)
                throw new ArgumentNullException(nameof(value), "Property is not nullable for class GetTransactionsResponseDataInnerInteractionsInner.");

            return new GetTransactionsResponseDataInnerInteractionsInner(contract, functionArgs, functionName, to, value);
        }

        /// <summary>
        /// Serializes a <see cref="GetTransactionsResponseDataInnerInteractionsInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getTransactionsResponseDataInnerInteractionsInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetTransactionsResponseDataInnerInteractionsInner getTransactionsResponseDataInnerInteractionsInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getTransactionsResponseDataInnerInteractionsInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetTransactionsResponseDataInnerInteractionsInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getTransactionsResponseDataInnerInteractionsInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetTransactionsResponseDataInnerInteractionsInner getTransactionsResponseDataInnerInteractionsInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getTransactionsResponseDataInnerInteractionsInner.ContractOption.IsSet && getTransactionsResponseDataInnerInteractionsInner.Contract == null)
                throw new ArgumentNullException(nameof(getTransactionsResponseDataInnerInteractionsInner.Contract), "Property is required for class GetTransactionsResponseDataInnerInteractionsInner.");

            if (getTransactionsResponseDataInnerInteractionsInner.FunctionArgsOption.IsSet && getTransactionsResponseDataInnerInteractionsInner.FunctionArgs == null)
                throw new ArgumentNullException(nameof(getTransactionsResponseDataInnerInteractionsInner.FunctionArgs), "Property is required for class GetTransactionsResponseDataInnerInteractionsInner.");

            if (getTransactionsResponseDataInnerInteractionsInner.FunctionNameOption.IsSet && getTransactionsResponseDataInnerInteractionsInner.FunctionName == null)
                throw new ArgumentNullException(nameof(getTransactionsResponseDataInnerInteractionsInner.FunctionName), "Property is required for class GetTransactionsResponseDataInnerInteractionsInner.");

            if (getTransactionsResponseDataInnerInteractionsInner.ToOption.IsSet && getTransactionsResponseDataInnerInteractionsInner.To == null)
                throw new ArgumentNullException(nameof(getTransactionsResponseDataInnerInteractionsInner.To), "Property is required for class GetTransactionsResponseDataInnerInteractionsInner.");

            if (getTransactionsResponseDataInnerInteractionsInner.ValueOption.IsSet && getTransactionsResponseDataInnerInteractionsInner.Value == null)
                throw new ArgumentNullException(nameof(getTransactionsResponseDataInnerInteractionsInner.Value), "Property is required for class GetTransactionsResponseDataInnerInteractionsInner.");

            if (getTransactionsResponseDataInnerInteractionsInner.ContractOption.IsSet)
                writer.WriteString("contract", getTransactionsResponseDataInnerInteractionsInner.Contract);

            if (getTransactionsResponseDataInnerInteractionsInner.FunctionArgsOption.IsSet)
            {
                writer.WritePropertyName("functionArgs");
                JsonSerializer.Serialize(writer, getTransactionsResponseDataInnerInteractionsInner.FunctionArgs, jsonSerializerOptions);
            }
            if (getTransactionsResponseDataInnerInteractionsInner.FunctionNameOption.IsSet)
                writer.WriteString("functionName", getTransactionsResponseDataInnerInteractionsInner.FunctionName);

            if (getTransactionsResponseDataInnerInteractionsInner.ToOption.IsSet)
                writer.WriteString("to", getTransactionsResponseDataInnerInteractionsInner.To);

            if (getTransactionsResponseDataInnerInteractionsInner.ValueOption.IsSet)
                writer.WriteString("value", getTransactionsResponseDataInnerInteractionsInner.Value);
        }
    }
}
