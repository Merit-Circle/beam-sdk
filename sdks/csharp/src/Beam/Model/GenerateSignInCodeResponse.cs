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
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Beam.Client.FileParameter;
using OpenAPIDateConverter = Beam.Client.OpenAPIDateConverter;

namespace Beam.Model
{
    /// <summary>
    /// GenerateSignInCodeResponse
    /// </summary>
    [DataContract(Name = "GenerateSignInCodeResponse")]
    public partial class GenerateSignInCodeResponse : IEquatable<GenerateSignInCodeResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSignInCodeResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GenerateSignInCodeResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSignInCodeResponse" /> class.
        /// </summary>
        /// <param name="challenge">challenge (required).</param>
        public GenerateSignInCodeResponse(string challenge = default(string))
        {
            // to ensure "challenge" is required (not null)
            if (challenge == null)
            {
                throw new ArgumentNullException("challenge is a required property for GenerateSignInCodeResponse and cannot be null");
            }
            this.Challenge = challenge;
        }

        /// <summary>
        /// Gets or Sets Challenge
        /// </summary>
        [DataMember(Name = "challenge", IsRequired = true, EmitDefaultValue = true)]
        public string Challenge { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GenerateSignInCodeResponse {\n");
            sb.Append("  Challenge: ").Append(Challenge).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GenerateSignInCodeResponse);
        }

        /// <summary>
        /// Returns true if GenerateSignInCodeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GenerateSignInCodeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateSignInCodeResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Challenge == input.Challenge ||
                    (this.Challenge != null &&
                    this.Challenge.Equals(input.Challenge))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Challenge != null)
                {
                    hashCode = (hashCode * 59) + this.Challenge.GetHashCode();
                }
                return hashCode;
            }
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

}
