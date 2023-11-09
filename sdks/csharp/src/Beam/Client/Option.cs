// <auto-generated>
/*
 * Beam game development API
 *
 * The Beam game development API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


namespace Beam.Client
{
    /// <summary>
    /// A wrapper for operation parameters which are not required
    /// </summary>
    public struct Option<TType>
    {
        /// <summary>
        /// The value to send to the server
        /// </summary>
        public TType Value { get; }

        /// <summary>
        /// When true the value will be sent to the server
        /// </summary>
        internal bool IsSet { get; }

        /// <summary>
        /// A wrapper for operation parameters which are not required
        /// </summary>
        /// <param name="value"></param>
        public Option(TType value)
        {
            IsSet = true;
            Value = value;
        }
    }
}