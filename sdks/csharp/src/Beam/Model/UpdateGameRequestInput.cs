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
    /// UpdateGameRequestInput
    /// </summary>
    public partial class UpdateGameRequestInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGameRequestInput" /> class.
        /// </summary>
        /// <param name="coverImageUrl">coverImageUrl</param>
        /// <param name="description">description</param>
        /// <param name="logoImageUrl">logoImageUrl</param>
        /// <param name="name">name</param>
        /// <param name="pegiContent">pegiContent</param>
        /// <param name="pegiRating">pegiRating</param>
        [JsonConstructor]
        public UpdateGameRequestInput(Option<string> coverImageUrl = default, Option<string> description = default, Option<string> logoImageUrl = default, Option<string> name = default, Option<List<UpdateGameRequestInput.PegiContentEnum>> pegiContent = default, Option<PegiRatingEnum?> pegiRating = default)
        {
            CoverImageUrlOption = coverImageUrl;
            DescriptionOption = description;
            LogoImageUrlOption = logoImageUrl;
            NameOption = name;
            PegiContentOption = pegiContent;
            PegiRatingOption = pegiRating;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines PegiContent
        /// </summary>
        public enum PegiContentEnum
        {
            /// <summary>
            /// Enum BadLanguage for value: BadLanguage
            /// </summary>
            BadLanguage = 1,

            /// <summary>
            /// Enum Discrimination for value: Discrimination
            /// </summary>
            Discrimination = 2,

            /// <summary>
            /// Enum Drugs for value: Drugs
            /// </summary>
            Drugs = 3,

            /// <summary>
            /// Enum Fear for value: Fear
            /// </summary>
            Fear = 4,

            /// <summary>
            /// Enum Gambling for value: Gambling
            /// </summary>
            Gambling = 5,

            /// <summary>
            /// Enum Sex for value: Sex
            /// </summary>
            Sex = 6,

            /// <summary>
            /// Enum Violence for value: Violence
            /// </summary>
            Violence = 7,

            /// <summary>
            /// Enum InGamePurchases for value: InGamePurchases
            /// </summary>
            InGamePurchases = 8
        }

        /// <summary>
        /// Returns a <see cref="PegiContentEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static PegiContentEnum PegiContentEnumFromString(string value)
        {
            if (value.Equals("BadLanguage"))
                return PegiContentEnum.BadLanguage;

            if (value.Equals("Discrimination"))
                return PegiContentEnum.Discrimination;

            if (value.Equals("Drugs"))
                return PegiContentEnum.Drugs;

            if (value.Equals("Fear"))
                return PegiContentEnum.Fear;

            if (value.Equals("Gambling"))
                return PegiContentEnum.Gambling;

            if (value.Equals("Sex"))
                return PegiContentEnum.Sex;

            if (value.Equals("Violence"))
                return PegiContentEnum.Violence;

            if (value.Equals("InGamePurchases"))
                return PegiContentEnum.InGamePurchases;

            throw new NotImplementedException($"Could not convert value to type PegiContentEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="PegiContentEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static PegiContentEnum? PegiContentEnumFromStringOrDefault(string value)
        {
            if (value.Equals("BadLanguage"))
                return PegiContentEnum.BadLanguage;

            if (value.Equals("Discrimination"))
                return PegiContentEnum.Discrimination;

            if (value.Equals("Drugs"))
                return PegiContentEnum.Drugs;

            if (value.Equals("Fear"))
                return PegiContentEnum.Fear;

            if (value.Equals("Gambling"))
                return PegiContentEnum.Gambling;

            if (value.Equals("Sex"))
                return PegiContentEnum.Sex;

            if (value.Equals("Violence"))
                return PegiContentEnum.Violence;

            if (value.Equals("InGamePurchases"))
                return PegiContentEnum.InGamePurchases;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="PegiContentEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string PegiContentEnumToJsonValue(PegiContentEnum value)
        {
            if (value == PegiContentEnum.BadLanguage)
                return "BadLanguage";

            if (value == PegiContentEnum.Discrimination)
                return "Discrimination";

            if (value == PegiContentEnum.Drugs)
                return "Drugs";

            if (value == PegiContentEnum.Fear)
                return "Fear";

            if (value == PegiContentEnum.Gambling)
                return "Gambling";

            if (value == PegiContentEnum.Sex)
                return "Sex";

            if (value == PegiContentEnum.Violence)
                return "Violence";

            if (value == PegiContentEnum.InGamePurchases)
                return "InGamePurchases";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Defines PegiRating
        /// </summary>
        public enum PegiRatingEnum
        {
            /// <summary>
            /// Enum Three for value: Three
            /// </summary>
            Three = 1,

            /// <summary>
            /// Enum Seven for value: Seven
            /// </summary>
            Seven = 2,

            /// <summary>
            /// Enum Twelve for value: Twelve
            /// </summary>
            Twelve = 3,

            /// <summary>
            /// Enum Sixteen for value: Sixteen
            /// </summary>
            Sixteen = 4,

            /// <summary>
            /// Enum Eighteen for value: Eighteen
            /// </summary>
            Eighteen = 5
        }

        /// <summary>
        /// Returns a <see cref="PegiRatingEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static PegiRatingEnum PegiRatingEnumFromString(string value)
        {
            if (value.Equals("Three"))
                return PegiRatingEnum.Three;

            if (value.Equals("Seven"))
                return PegiRatingEnum.Seven;

            if (value.Equals("Twelve"))
                return PegiRatingEnum.Twelve;

            if (value.Equals("Sixteen"))
                return PegiRatingEnum.Sixteen;

            if (value.Equals("Eighteen"))
                return PegiRatingEnum.Eighteen;

            throw new NotImplementedException($"Could not convert value to type PegiRatingEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="PegiRatingEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static PegiRatingEnum? PegiRatingEnumFromStringOrDefault(string value)
        {
            if (value.Equals("Three"))
                return PegiRatingEnum.Three;

            if (value.Equals("Seven"))
                return PegiRatingEnum.Seven;

            if (value.Equals("Twelve"))
                return PegiRatingEnum.Twelve;

            if (value.Equals("Sixteen"))
                return PegiRatingEnum.Sixteen;

            if (value.Equals("Eighteen"))
                return PegiRatingEnum.Eighteen;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="PegiRatingEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string PegiRatingEnumToJsonValue(PegiRatingEnum? value)
        {
            if (value == null)
                return null;

            if (value == PegiRatingEnum.Three)
                return "Three";

            if (value == PegiRatingEnum.Seven)
                return "Seven";

            if (value == PegiRatingEnum.Twelve)
                return "Twelve";

            if (value == PegiRatingEnum.Sixteen)
                return "Sixteen";

            if (value == PegiRatingEnum.Eighteen)
                return "Eighteen";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Used to track the state of PegiRating
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<PegiRatingEnum?> PegiRatingOption { get; private set; }

        /// <summary>
        /// Gets or Sets PegiRating
        /// </summary>
        [JsonPropertyName("pegiRating")]
        public PegiRatingEnum? PegiRating { get { return this.PegiRatingOption; } set { this.PegiRatingOption = new(value); } }

        /// <summary>
        /// Used to track the state of CoverImageUrl
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> CoverImageUrlOption { get; private set; }

        /// <summary>
        /// Gets or Sets CoverImageUrl
        /// </summary>
        [JsonPropertyName("coverImageUrl")]
        public string CoverImageUrl { get { return this. CoverImageUrlOption; } set { this.CoverImageUrlOption = new(value); } }

        /// <summary>
        /// Used to track the state of Description
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> DescriptionOption { get; private set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get { return this. DescriptionOption; } set { this.DescriptionOption = new(value); } }

        /// <summary>
        /// Used to track the state of LogoImageUrl
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> LogoImageUrlOption { get; private set; }

        /// <summary>
        /// Gets or Sets LogoImageUrl
        /// </summary>
        [JsonPropertyName("logoImageUrl")]
        public string LogoImageUrl { get { return this. LogoImageUrlOption; } set { this.LogoImageUrlOption = new(value); } }

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> NameOption { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get { return this. NameOption; } set { this.NameOption = new(value); } }

        /// <summary>
        /// Used to track the state of PegiContent
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<UpdateGameRequestInput.PegiContentEnum>> PegiContentOption { get; private set; }

        /// <summary>
        /// Gets or Sets PegiContent
        /// </summary>
        [JsonPropertyName("pegiContent")]
        public List<UpdateGameRequestInput.PegiContentEnum> PegiContent { get { return this. PegiContentOption; } set { this.PegiContentOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateGameRequestInput {\n");
            sb.Append("  CoverImageUrl: ").Append(CoverImageUrl).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LogoImageUrl: ").Append(LogoImageUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PegiContent: ").Append(PegiContent).Append("\n");
            sb.Append("  PegiRating: ").Append(PegiRating).Append("\n");
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
    /// A Json converter for type <see cref="UpdateGameRequestInput" />
    /// </summary>
    public class UpdateGameRequestInputJsonConverter : JsonConverter<UpdateGameRequestInput>
    {
        /// <summary>
        /// Deserializes json to <see cref="UpdateGameRequestInput" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UpdateGameRequestInput Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> coverImageUrl = default;
            Option<string> description = default;
            Option<string> logoImageUrl = default;
            Option<string> name = default;
            Option<List<UpdateGameRequestInput.PegiContentEnum>> pegiContent = default;
            Option<UpdateGameRequestInput.PegiRatingEnum?> pegiRating = default;

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
                        case "coverImageUrl":
                            coverImageUrl = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "description":
                            description = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "logoImageUrl":
                            logoImageUrl = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "name":
                            name = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "pegiContent":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                pegiContent = new Option<List<UpdateGameRequestInput.PegiContentEnum>>(JsonSerializer.Deserialize<List<UpdateGameRequestInput.PegiContentEnum>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "pegiRating":
                            string pegiRatingRawValue = utf8JsonReader.GetString();
                            if (pegiRatingRawValue != null)
                                pegiRating = new Option<UpdateGameRequestInput.PegiRatingEnum?>(UpdateGameRequestInput.PegiRatingEnumFromStringOrDefault(pegiRatingRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class UpdateGameRequestInput.");

            if (pegiContent.IsSet && pegiContent.Value == null)
                throw new ArgumentNullException(nameof(pegiContent), "Property is not nullable for class UpdateGameRequestInput.");

            return new UpdateGameRequestInput(coverImageUrl, description, logoImageUrl, name, pegiContent, pegiRating);
        }

        /// <summary>
        /// Serializes a <see cref="UpdateGameRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="updateGameRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UpdateGameRequestInput updateGameRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, updateGameRequestInput, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UpdateGameRequestInput" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="updateGameRequestInput"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, UpdateGameRequestInput updateGameRequestInput, JsonSerializerOptions jsonSerializerOptions)
        {
            if (updateGameRequestInput.NameOption.IsSet && updateGameRequestInput.Name == null)
                throw new ArgumentNullException(nameof(updateGameRequestInput.Name), "Property is required for class UpdateGameRequestInput.");

            if (updateGameRequestInput.PegiContentOption.IsSet && updateGameRequestInput.PegiContent == null)
                throw new ArgumentNullException(nameof(updateGameRequestInput.PegiContent), "Property is required for class UpdateGameRequestInput.");

            if (updateGameRequestInput.CoverImageUrlOption.IsSet)
                if (updateGameRequestInput.CoverImageUrlOption.Value != null)
                    writer.WriteString("coverImageUrl", updateGameRequestInput.CoverImageUrl);
                else
                    writer.WriteNull("coverImageUrl");

            if (updateGameRequestInput.DescriptionOption.IsSet)
                if (updateGameRequestInput.DescriptionOption.Value != null)
                    writer.WriteString("description", updateGameRequestInput.Description);
                else
                    writer.WriteNull("description");

            if (updateGameRequestInput.LogoImageUrlOption.IsSet)
                if (updateGameRequestInput.LogoImageUrlOption.Value != null)
                    writer.WriteString("logoImageUrl", updateGameRequestInput.LogoImageUrl);
                else
                    writer.WriteNull("logoImageUrl");

            if (updateGameRequestInput.NameOption.IsSet)
                writer.WriteString("name", updateGameRequestInput.Name);

            if (updateGameRequestInput.PegiContentOption.IsSet)
            {
                writer.WritePropertyName("pegiContent");
                JsonSerializer.Serialize(writer, updateGameRequestInput.PegiContent, jsonSerializerOptions);
            }
            var pegiRatingRawValue = UpdateGameRequestInput.PegiRatingEnumToJsonValue(updateGameRequestInput.PegiRatingOption.Value.Value);
            if (pegiRatingRawValue != null)
                writer.WriteString("pegiRating", pegiRatingRawValue);
            else
                writer.WriteNull("pegiRating");
        }
    }
}
