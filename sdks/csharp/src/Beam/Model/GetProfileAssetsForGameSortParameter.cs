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
    /// GetProfileAssetsForGameSortParameter
    /// </summary>
    public partial class GetProfileAssetsForGameSortParameter : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProfileAssetsForGameSortParameter" /> class.
        /// </summary>
        /// <param name="createdAt">createdAt</param>
        /// <param name="end">end</param>
        /// <param name="endPriceNumber">endPriceNumber</param>
        /// <param name="fixedPriceNumber">fixedPriceNumber</param>
        /// <param name="rarityScore">rarityScore</param>
        /// <param name="start">start</param>
        /// <param name="startPriceNumber">startPriceNumber</param>
        [JsonConstructor]
        public GetProfileAssetsForGameSortParameter(CreatedAtEnum? createdAt = default, EndEnum? end = default, EndPriceNumberEnum? endPriceNumber = default, FixedPriceNumberEnum? fixedPriceNumber = default, RarityScoreEnum? rarityScore = default, StartEnum? start = default, StartPriceNumberEnum? startPriceNumber = default)
        {
            CreatedAt = createdAt;
            End = end;
            EndPriceNumber = endPriceNumber;
            FixedPriceNumber = fixedPriceNumber;
            RarityScore = rarityScore;
            Start = start;
            StartPriceNumber = startPriceNumber;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines CreatedAt
        /// </summary>
        public enum CreatedAtEnum
        {
            /// <summary>
            /// Enum ASC for value: ASC
            /// </summary>
            ASC = 1,

            /// <summary>
            /// Enum DESC for value: DESC
            /// </summary>
            DESC = 2
        }

        /// <summary>
        /// Returns a <see cref="CreatedAtEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static CreatedAtEnum CreatedAtEnumFromString(string value)
        {
            if (value.Equals("ASC"))
                return CreatedAtEnum.ASC;

            if (value.Equals("DESC"))
                return CreatedAtEnum.DESC;

            throw new NotImplementedException($"Could not convert value to type CreatedAtEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="CreatedAtEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CreatedAtEnum? CreatedAtEnumFromStringOrDefault(string value)
        {
            if (value.Equals("ASC"))
                return CreatedAtEnum.ASC;

            if (value.Equals("DESC"))
                return CreatedAtEnum.DESC;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="CreatedAtEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string? CreatedAtEnumToJsonValue(CreatedAtEnum? value)
        {
            if (value == null)
                return null;

            if (value == CreatedAtEnum.ASC)
                return "ASC";

            if (value == CreatedAtEnum.DESC)
                return "DESC";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [JsonPropertyName("createdAt")]
        public CreatedAtEnum? CreatedAt { get; set; }

        /// <summary>
        /// Defines End
        /// </summary>
        public enum EndEnum
        {
            /// <summary>
            /// Enum ASC for value: ASC
            /// </summary>
            ASC = 1,

            /// <summary>
            /// Enum DESC for value: DESC
            /// </summary>
            DESC = 2
        }

        /// <summary>
        /// Returns a <see cref="EndEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static EndEnum EndEnumFromString(string value)
        {
            if (value.Equals("ASC"))
                return EndEnum.ASC;

            if (value.Equals("DESC"))
                return EndEnum.DESC;

            throw new NotImplementedException($"Could not convert value to type EndEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="EndEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EndEnum? EndEnumFromStringOrDefault(string value)
        {
            if (value.Equals("ASC"))
                return EndEnum.ASC;

            if (value.Equals("DESC"))
                return EndEnum.DESC;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="EndEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string? EndEnumToJsonValue(EndEnum? value)
        {
            if (value == null)
                return null;

            if (value == EndEnum.ASC)
                return "ASC";

            if (value == EndEnum.DESC)
                return "DESC";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets End
        /// </summary>
        [JsonPropertyName("end")]
        public EndEnum? End { get; set; }

        /// <summary>
        /// Defines EndPriceNumber
        /// </summary>
        public enum EndPriceNumberEnum
        {
            /// <summary>
            /// Enum ASC for value: ASC
            /// </summary>
            ASC = 1,

            /// <summary>
            /// Enum DESC for value: DESC
            /// </summary>
            DESC = 2
        }

        /// <summary>
        /// Returns a <see cref="EndPriceNumberEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static EndPriceNumberEnum EndPriceNumberEnumFromString(string value)
        {
            if (value.Equals("ASC"))
                return EndPriceNumberEnum.ASC;

            if (value.Equals("DESC"))
                return EndPriceNumberEnum.DESC;

            throw new NotImplementedException($"Could not convert value to type EndPriceNumberEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="EndPriceNumberEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static EndPriceNumberEnum? EndPriceNumberEnumFromStringOrDefault(string value)
        {
            if (value.Equals("ASC"))
                return EndPriceNumberEnum.ASC;

            if (value.Equals("DESC"))
                return EndPriceNumberEnum.DESC;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="EndPriceNumberEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string? EndPriceNumberEnumToJsonValue(EndPriceNumberEnum? value)
        {
            if (value == null)
                return null;

            if (value == EndPriceNumberEnum.ASC)
                return "ASC";

            if (value == EndPriceNumberEnum.DESC)
                return "DESC";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets EndPriceNumber
        /// </summary>
        [JsonPropertyName("endPriceNumber")]
        public EndPriceNumberEnum? EndPriceNumber { get; set; }

        /// <summary>
        /// Defines FixedPriceNumber
        /// </summary>
        public enum FixedPriceNumberEnum
        {
            /// <summary>
            /// Enum ASC for value: ASC
            /// </summary>
            ASC = 1,

            /// <summary>
            /// Enum DESC for value: DESC
            /// </summary>
            DESC = 2
        }

        /// <summary>
        /// Returns a <see cref="FixedPriceNumberEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static FixedPriceNumberEnum FixedPriceNumberEnumFromString(string value)
        {
            if (value.Equals("ASC"))
                return FixedPriceNumberEnum.ASC;

            if (value.Equals("DESC"))
                return FixedPriceNumberEnum.DESC;

            throw new NotImplementedException($"Could not convert value to type FixedPriceNumberEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="FixedPriceNumberEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static FixedPriceNumberEnum? FixedPriceNumberEnumFromStringOrDefault(string value)
        {
            if (value.Equals("ASC"))
                return FixedPriceNumberEnum.ASC;

            if (value.Equals("DESC"))
                return FixedPriceNumberEnum.DESC;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="FixedPriceNumberEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string? FixedPriceNumberEnumToJsonValue(FixedPriceNumberEnum? value)
        {
            if (value == null)
                return null;

            if (value == FixedPriceNumberEnum.ASC)
                return "ASC";

            if (value == FixedPriceNumberEnum.DESC)
                return "DESC";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets FixedPriceNumber
        /// </summary>
        [JsonPropertyName("fixedPriceNumber")]
        public FixedPriceNumberEnum? FixedPriceNumber { get; set; }

        /// <summary>
        /// Defines RarityScore
        /// </summary>
        public enum RarityScoreEnum
        {
            /// <summary>
            /// Enum ASC for value: ASC
            /// </summary>
            ASC = 1,

            /// <summary>
            /// Enum DESC for value: DESC
            /// </summary>
            DESC = 2
        }

        /// <summary>
        /// Returns a <see cref="RarityScoreEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static RarityScoreEnum RarityScoreEnumFromString(string value)
        {
            if (value.Equals("ASC"))
                return RarityScoreEnum.ASC;

            if (value.Equals("DESC"))
                return RarityScoreEnum.DESC;

            throw new NotImplementedException($"Could not convert value to type RarityScoreEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="RarityScoreEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RarityScoreEnum? RarityScoreEnumFromStringOrDefault(string value)
        {
            if (value.Equals("ASC"))
                return RarityScoreEnum.ASC;

            if (value.Equals("DESC"))
                return RarityScoreEnum.DESC;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="RarityScoreEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string? RarityScoreEnumToJsonValue(RarityScoreEnum? value)
        {
            if (value == null)
                return null;

            if (value == RarityScoreEnum.ASC)
                return "ASC";

            if (value == RarityScoreEnum.DESC)
                return "DESC";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets RarityScore
        /// </summary>
        [JsonPropertyName("rarityScore")]
        public RarityScoreEnum? RarityScore { get; set; }

        /// <summary>
        /// Defines Start
        /// </summary>
        public enum StartEnum
        {
            /// <summary>
            /// Enum ASC for value: ASC
            /// </summary>
            ASC = 1,

            /// <summary>
            /// Enum DESC for value: DESC
            /// </summary>
            DESC = 2
        }

        /// <summary>
        /// Returns a <see cref="StartEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static StartEnum StartEnumFromString(string value)
        {
            if (value.Equals("ASC"))
                return StartEnum.ASC;

            if (value.Equals("DESC"))
                return StartEnum.DESC;

            throw new NotImplementedException($"Could not convert value to type StartEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="StartEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StartEnum? StartEnumFromStringOrDefault(string value)
        {
            if (value.Equals("ASC"))
                return StartEnum.ASC;

            if (value.Equals("DESC"))
                return StartEnum.DESC;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="StartEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string? StartEnumToJsonValue(StartEnum? value)
        {
            if (value == null)
                return null;

            if (value == StartEnum.ASC)
                return "ASC";

            if (value == StartEnum.DESC)
                return "DESC";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [JsonPropertyName("start")]
        public StartEnum? Start { get; set; }

        /// <summary>
        /// Defines StartPriceNumber
        /// </summary>
        public enum StartPriceNumberEnum
        {
            /// <summary>
            /// Enum ASC for value: ASC
            /// </summary>
            ASC = 1,

            /// <summary>
            /// Enum DESC for value: DESC
            /// </summary>
            DESC = 2
        }

        /// <summary>
        /// Returns a <see cref="StartPriceNumberEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static StartPriceNumberEnum StartPriceNumberEnumFromString(string value)
        {
            if (value.Equals("ASC"))
                return StartPriceNumberEnum.ASC;

            if (value.Equals("DESC"))
                return StartPriceNumberEnum.DESC;

            throw new NotImplementedException($"Could not convert value to type StartPriceNumberEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="StartPriceNumberEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StartPriceNumberEnum? StartPriceNumberEnumFromStringOrDefault(string value)
        {
            if (value.Equals("ASC"))
                return StartPriceNumberEnum.ASC;

            if (value.Equals("DESC"))
                return StartPriceNumberEnum.DESC;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="StartPriceNumberEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string? StartPriceNumberEnumToJsonValue(StartPriceNumberEnum? value)
        {
            if (value == null)
                return null;

            if (value == StartPriceNumberEnum.ASC)
                return "ASC";

            if (value == StartPriceNumberEnum.DESC)
                return "DESC";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Gets or Sets StartPriceNumber
        /// </summary>
        [JsonPropertyName("startPriceNumber")]
        public StartPriceNumberEnum? StartPriceNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetProfileAssetsForGameSortParameter {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  EndPriceNumber: ").Append(EndPriceNumber).Append("\n");
            sb.Append("  FixedPriceNumber: ").Append(FixedPriceNumber).Append("\n");
            sb.Append("  RarityScore: ").Append(RarityScore).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  StartPriceNumber: ").Append(StartPriceNumber).Append("\n");
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
    /// A Json converter for type <see cref="GetProfileAssetsForGameSortParameter" />
    /// </summary>
    public class GetProfileAssetsForGameSortParameterJsonConverter : JsonConverter<GetProfileAssetsForGameSortParameter>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetProfileAssetsForGameSortParameter" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetProfileAssetsForGameSortParameter Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            GetProfileAssetsForGameSortParameter.CreatedAtEnum? createdAt = default;
            GetProfileAssetsForGameSortParameter.EndEnum? end = default;
            GetProfileAssetsForGameSortParameter.EndPriceNumberEnum? endPriceNumber = default;
            GetProfileAssetsForGameSortParameter.FixedPriceNumberEnum? fixedPriceNumber = default;
            GetProfileAssetsForGameSortParameter.RarityScoreEnum? rarityScore = default;
            GetProfileAssetsForGameSortParameter.StartEnum? start = default;
            GetProfileAssetsForGameSortParameter.StartPriceNumberEnum? startPriceNumber = default;

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
                        case "createdAt":
                            string createdAtRawValue = utf8JsonReader.GetString();
                            createdAt = createdAtRawValue == null
                                ? null
                                : GetProfileAssetsForGameSortParameter.CreatedAtEnumFromStringOrDefault(createdAtRawValue);
                            break;
                        case "end":
                            string endRawValue = utf8JsonReader.GetString();
                            end = endRawValue == null
                                ? null
                                : GetProfileAssetsForGameSortParameter.EndEnumFromStringOrDefault(endRawValue);
                            break;
                        case "endPriceNumber":
                            string endPriceNumberRawValue = utf8JsonReader.GetString();
                            endPriceNumber = endPriceNumberRawValue == null
                                ? null
                                : GetProfileAssetsForGameSortParameter.EndPriceNumberEnumFromStringOrDefault(endPriceNumberRawValue);
                            break;
                        case "fixedPriceNumber":
                            string fixedPriceNumberRawValue = utf8JsonReader.GetString();
                            fixedPriceNumber = fixedPriceNumberRawValue == null
                                ? null
                                : GetProfileAssetsForGameSortParameter.FixedPriceNumberEnumFromStringOrDefault(fixedPriceNumberRawValue);
                            break;
                        case "rarityScore":
                            string rarityScoreRawValue = utf8JsonReader.GetString();
                            rarityScore = rarityScoreRawValue == null
                                ? null
                                : GetProfileAssetsForGameSortParameter.RarityScoreEnumFromStringOrDefault(rarityScoreRawValue);
                            break;
                        case "start":
                            string startRawValue = utf8JsonReader.GetString();
                            start = startRawValue == null
                                ? null
                                : GetProfileAssetsForGameSortParameter.StartEnumFromStringOrDefault(startRawValue);
                            break;
                        case "startPriceNumber":
                            string startPriceNumberRawValue = utf8JsonReader.GetString();
                            startPriceNumber = startPriceNumberRawValue == null
                                ? null
                                : GetProfileAssetsForGameSortParameter.StartPriceNumberEnumFromStringOrDefault(startPriceNumberRawValue);
                            break;
                        default:
                            break;
                    }
                }
            }

            return new GetProfileAssetsForGameSortParameter(createdAt, end, endPriceNumber, fixedPriceNumber, rarityScore, start, startPriceNumber);
        }

        /// <summary>
        /// Serializes a <see cref="GetProfileAssetsForGameSortParameter" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getProfileAssetsForGameSortParameter"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetProfileAssetsForGameSortParameter getProfileAssetsForGameSortParameter, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getProfileAssetsForGameSortParameter, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetProfileAssetsForGameSortParameter" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getProfileAssetsForGameSortParameter"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetProfileAssetsForGameSortParameter getProfileAssetsForGameSortParameter, JsonSerializerOptions jsonSerializerOptions)
        {

            var createdAtRawValue = GetProfileAssetsForGameSortParameter.CreatedAtEnumToJsonValue(getProfileAssetsForGameSortParameter.CreatedAt);
            if (createdAtRawValue != null)
                writer.WriteString("createdAt", createdAtRawValue);
            else
                writer.WriteNull("createdAt");

            var endRawValue = GetProfileAssetsForGameSortParameter.EndEnumToJsonValue(getProfileAssetsForGameSortParameter.End);
            if (endRawValue != null)
                writer.WriteString("end", endRawValue);
            else
                writer.WriteNull("end");

            var endPriceNumberRawValue = GetProfileAssetsForGameSortParameter.EndPriceNumberEnumToJsonValue(getProfileAssetsForGameSortParameter.EndPriceNumber);
            if (endPriceNumberRawValue != null)
                writer.WriteString("endPriceNumber", endPriceNumberRawValue);
            else
                writer.WriteNull("endPriceNumber");

            var fixedPriceNumberRawValue = GetProfileAssetsForGameSortParameter.FixedPriceNumberEnumToJsonValue(getProfileAssetsForGameSortParameter.FixedPriceNumber);
            if (fixedPriceNumberRawValue != null)
                writer.WriteString("fixedPriceNumber", fixedPriceNumberRawValue);
            else
                writer.WriteNull("fixedPriceNumber");

            var rarityScoreRawValue = GetProfileAssetsForGameSortParameter.RarityScoreEnumToJsonValue(getProfileAssetsForGameSortParameter.RarityScore);
            if (rarityScoreRawValue != null)
                writer.WriteString("rarityScore", rarityScoreRawValue);
            else
                writer.WriteNull("rarityScore");

            var startRawValue = GetProfileAssetsForGameSortParameter.StartEnumToJsonValue(getProfileAssetsForGameSortParameter.Start);
            if (startRawValue != null)
                writer.WriteString("start", startRawValue);
            else
                writer.WriteNull("start");

            var startPriceNumberRawValue = GetProfileAssetsForGameSortParameter.StartPriceNumberEnumToJsonValue(getProfileAssetsForGameSortParameter.StartPriceNumber);
            if (startPriceNumberRawValue != null)
                writer.WriteString("startPriceNumber", startPriceNumberRawValue);
            else
                writer.WriteNull("startPriceNumber");
        }
    }
}
