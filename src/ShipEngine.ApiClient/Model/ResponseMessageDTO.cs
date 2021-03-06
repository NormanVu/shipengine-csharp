/* 
 * ShipEngine
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = ShipEngine.ApiClient.Client.SwaggerDateConverter;

namespace ShipEngine.ApiClient.Model
{
    /// <summary>
    /// ResponseMessageDTO
    /// </summary>
    [DataContract]
    public partial class ResponseMessageDTO :  IEquatable<ResponseMessageDTO>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            
            /// <summary>
            /// Enum A1000 for "a1000"
            /// </summary>
            [EnumMember(Value = "a1000")]
            A1000 = 1,
            
            /// <summary>
            /// Enum A1001 for "a1001"
            /// </summary>
            [EnumMember(Value = "a1001")]
            A1001 = 2,
            
            /// <summary>
            /// Enum A1002 for "a1002"
            /// </summary>
            [EnumMember(Value = "a1002")]
            A1002 = 3,
            
            /// <summary>
            /// Enum A1003 for "a1003"
            /// </summary>
            [EnumMember(Value = "a1003")]
            A1003 = 4,
            
            /// <summary>
            /// Enum A1004 for "a1004"
            /// </summary>
            [EnumMember(Value = "a1004")]
            A1004 = 5,
            
            /// <summary>
            /// Enum A1005 for "a1005"
            /// </summary>
            [EnumMember(Value = "a1005")]
            A1005 = 6,
            
            /// <summary>
            /// Enum A1006 for "a1006"
            /// </summary>
            [EnumMember(Value = "a1006")]
            A1006 = 7,
            
            /// <summary>
            /// Enum R1000 for "r1000"
            /// </summary>
            [EnumMember(Value = "r1000")]
            R1000 = 8,
            
            /// <summary>
            /// Enum R1001 for "r1001"
            /// </summary>
            [EnumMember(Value = "r1001")]
            R1001 = 9,
            
            /// <summary>
            /// Enum R1002 for "r1002"
            /// </summary>
            [EnumMember(Value = "r1002")]
            R1002 = 10,
            
            /// <summary>
            /// Enum R1003 for "r1003"
            /// </summary>
            [EnumMember(Value = "r1003")]
            R1003 = 11
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public CodeEnum? Code { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Error for "error"
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 1,
            
            /// <summary>
            /// Enum Warning for "warning"
            /// </summary>
            [EnumMember(Value = "warning")]
            Warning = 2,
            
            /// <summary>
            /// Enum Info for "info"
            /// </summary>
            [EnumMember(Value = "info")]
            Info = 3
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMessageDTO" /> class.
        /// </summary>
        /// <param name="Code">Code.</param>
        /// <param name="Message">Message.</param>
        /// <param name="Type">Type.</param>
        public ResponseMessageDTO(CodeEnum? Code = default(CodeEnum?), string Message = default(string), TypeEnum? Type = default(TypeEnum?))
        {
            this.Code = Code;
            this.Message = Message;
            this.Type = Type;
        }
        

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseMessageDTO {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResponseMessageDTO);
        }

        /// <summary>
        /// Returns true if ResponseMessageDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseMessageDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseMessageDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
