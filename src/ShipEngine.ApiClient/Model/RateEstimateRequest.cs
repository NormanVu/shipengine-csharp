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
    /// RateEstimateRequest
    /// </summary>
    [DataContract]
    public partial class RateEstimateRequest :  IEquatable<RateEstimateRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Confirmation
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConfirmationEnum
        {
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None = 1,
            
            /// <summary>
            /// Enum Delivery for "delivery"
            /// </summary>
            [EnumMember(Value = "delivery")]
            Delivery = 2,
            
            /// <summary>
            /// Enum Signature for "signature"
            /// </summary>
            [EnumMember(Value = "signature")]
            Signature = 3,
            
            /// <summary>
            /// Enum Adultsignature for "adult_signature"
            /// </summary>
            [EnumMember(Value = "adult_signature")]
            Adultsignature = 4,
            
            /// <summary>
            /// Enum Directsignature for "direct_signature"
            /// </summary>
            [EnumMember(Value = "direct_signature")]
            Directsignature = 5
        }

        /// <summary>
        /// Gets or Sets Confirmation
        /// </summary>
        [DataMember(Name="confirmation", EmitDefaultValue=false)]
        public ConfirmationEnum? Confirmation { get; set; }
        /// <summary>
        /// Gets or Sets AddressResidentialIndicator
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AddressResidentialIndicatorEnum
        {
            
            /// <summary>
            /// Enum Unknown for "unknown"
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 1,
            
            /// <summary>
            /// Enum Yes for "yes"
            /// </summary>
            [EnumMember(Value = "yes")]
            Yes = 2,
            
            /// <summary>
            /// Enum No for "no"
            /// </summary>
            [EnumMember(Value = "no")]
            No = 3
        }

        /// <summary>
        /// Gets or Sets AddressResidentialIndicator
        /// </summary>
        [DataMember(Name="address_residential_indicator", EmitDefaultValue=false)]
        public AddressResidentialIndicatorEnum? AddressResidentialIndicator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RateEstimateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RateEstimateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RateEstimateRequest" /> class.
        /// </summary>
        /// <param name="CarrierId">CarrierId (required).</param>
        /// <param name="FromCountryCode">FromCountryCode.</param>
        /// <param name="FromPostalCode">FromPostalCode.</param>
        /// <param name="ToCountryCode">ToCountryCode.</param>
        /// <param name="ToPostalCode">ToPostalCode.</param>
        /// <param name="ToCityLocality">ToCityLocality.</param>
        /// <param name="ToStateProvince">ToStateProvince.</param>
        /// <param name="Weight">Weight.</param>
        /// <param name="Dimensions">Dimensions.</param>
        /// <param name="Confirmation">Confirmation.</param>
        /// <param name="AddressResidentialIndicator">AddressResidentialIndicator.</param>
        /// <param name="ShipDate">ShipDate.</param>
        public RateEstimateRequest(string CarrierId = default(string), string FromCountryCode = default(string), string FromPostalCode = default(string), string ToCountryCode = default(string), string ToPostalCode = default(string), string ToCityLocality = default(string), string ToStateProvince = default(string), Weight Weight = default(Weight), Dimensions Dimensions = default(Dimensions), ConfirmationEnum? Confirmation = default(ConfirmationEnum?), AddressResidentialIndicatorEnum? AddressResidentialIndicator = default(AddressResidentialIndicatorEnum?), DateTime? ShipDate = default(DateTime?))
        {
            // to ensure "CarrierId" is required (not null)
            if (CarrierId == null)
            {
                throw new InvalidDataException("CarrierId is a required property for RateEstimateRequest and cannot be null");
            }
            else
            {
                this.CarrierId = CarrierId;
            }
            this.FromCountryCode = FromCountryCode;
            this.FromPostalCode = FromPostalCode;
            this.ToCountryCode = ToCountryCode;
            this.ToPostalCode = ToPostalCode;
            this.ToCityLocality = ToCityLocality;
            this.ToStateProvince = ToStateProvince;
            this.Weight = Weight;
            this.Dimensions = Dimensions;
            this.Confirmation = Confirmation;
            this.AddressResidentialIndicator = AddressResidentialIndicator;
            this.ShipDate = ShipDate;
        }
        
        /// <summary>
        /// Gets or Sets CarrierId
        /// </summary>
        [DataMember(Name="carrier_id", EmitDefaultValue=false)]
        public string CarrierId { get; set; }

        /// <summary>
        /// Gets or Sets FromCountryCode
        /// </summary>
        [DataMember(Name="from_country_code", EmitDefaultValue=false)]
        public string FromCountryCode { get; set; }

        /// <summary>
        /// Gets or Sets FromPostalCode
        /// </summary>
        [DataMember(Name="from_postal_code", EmitDefaultValue=false)]
        public string FromPostalCode { get; set; }

        /// <summary>
        /// Gets or Sets ToCountryCode
        /// </summary>
        [DataMember(Name="to_country_code", EmitDefaultValue=false)]
        public string ToCountryCode { get; set; }

        /// <summary>
        /// Gets or Sets ToPostalCode
        /// </summary>
        [DataMember(Name="to_postal_code", EmitDefaultValue=false)]
        public string ToPostalCode { get; set; }

        /// <summary>
        /// Gets or Sets ToCityLocality
        /// </summary>
        [DataMember(Name="to_city_locality", EmitDefaultValue=false)]
        public string ToCityLocality { get; set; }

        /// <summary>
        /// Gets or Sets ToStateProvince
        /// </summary>
        [DataMember(Name="to_state_province", EmitDefaultValue=false)]
        public string ToStateProvince { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public Weight Weight { get; set; }

        /// <summary>
        /// Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name="dimensions", EmitDefaultValue=false)]
        public Dimensions Dimensions { get; set; }



        /// <summary>
        /// Gets or Sets ShipDate
        /// </summary>
        [DataMember(Name="ship_date", EmitDefaultValue=false)]
        public DateTime? ShipDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RateEstimateRequest {\n");
            sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
            sb.Append("  FromCountryCode: ").Append(FromCountryCode).Append("\n");
            sb.Append("  FromPostalCode: ").Append(FromPostalCode).Append("\n");
            sb.Append("  ToCountryCode: ").Append(ToCountryCode).Append("\n");
            sb.Append("  ToPostalCode: ").Append(ToPostalCode).Append("\n");
            sb.Append("  ToCityLocality: ").Append(ToCityLocality).Append("\n");
            sb.Append("  ToStateProvince: ").Append(ToStateProvince).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("  Confirmation: ").Append(Confirmation).Append("\n");
            sb.Append("  AddressResidentialIndicator: ").Append(AddressResidentialIndicator).Append("\n");
            sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
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
            return this.Equals(input as RateEstimateRequest);
        }

        /// <summary>
        /// Returns true if RateEstimateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RateEstimateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RateEstimateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CarrierId == input.CarrierId ||
                    (this.CarrierId != null &&
                    this.CarrierId.Equals(input.CarrierId))
                ) && 
                (
                    this.FromCountryCode == input.FromCountryCode ||
                    (this.FromCountryCode != null &&
                    this.FromCountryCode.Equals(input.FromCountryCode))
                ) && 
                (
                    this.FromPostalCode == input.FromPostalCode ||
                    (this.FromPostalCode != null &&
                    this.FromPostalCode.Equals(input.FromPostalCode))
                ) && 
                (
                    this.ToCountryCode == input.ToCountryCode ||
                    (this.ToCountryCode != null &&
                    this.ToCountryCode.Equals(input.ToCountryCode))
                ) && 
                (
                    this.ToPostalCode == input.ToPostalCode ||
                    (this.ToPostalCode != null &&
                    this.ToPostalCode.Equals(input.ToPostalCode))
                ) && 
                (
                    this.ToCityLocality == input.ToCityLocality ||
                    (this.ToCityLocality != null &&
                    this.ToCityLocality.Equals(input.ToCityLocality))
                ) && 
                (
                    this.ToStateProvince == input.ToStateProvince ||
                    (this.ToStateProvince != null &&
                    this.ToStateProvince.Equals(input.ToStateProvince))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.Dimensions == input.Dimensions ||
                    (this.Dimensions != null &&
                    this.Dimensions.Equals(input.Dimensions))
                ) && 
                (
                    this.Confirmation == input.Confirmation ||
                    (this.Confirmation != null &&
                    this.Confirmation.Equals(input.Confirmation))
                ) && 
                (
                    this.AddressResidentialIndicator == input.AddressResidentialIndicator ||
                    (this.AddressResidentialIndicator != null &&
                    this.AddressResidentialIndicator.Equals(input.AddressResidentialIndicator))
                ) && 
                (
                    this.ShipDate == input.ShipDate ||
                    (this.ShipDate != null &&
                    this.ShipDate.Equals(input.ShipDate))
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
                if (this.CarrierId != null)
                    hashCode = hashCode * 59 + this.CarrierId.GetHashCode();
                if (this.FromCountryCode != null)
                    hashCode = hashCode * 59 + this.FromCountryCode.GetHashCode();
                if (this.FromPostalCode != null)
                    hashCode = hashCode * 59 + this.FromPostalCode.GetHashCode();
                if (this.ToCountryCode != null)
                    hashCode = hashCode * 59 + this.ToCountryCode.GetHashCode();
                if (this.ToPostalCode != null)
                    hashCode = hashCode * 59 + this.ToPostalCode.GetHashCode();
                if (this.ToCityLocality != null)
                    hashCode = hashCode * 59 + this.ToCityLocality.GetHashCode();
                if (this.ToStateProvince != null)
                    hashCode = hashCode * 59 + this.ToStateProvince.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.Dimensions != null)
                    hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                if (this.Confirmation != null)
                    hashCode = hashCode * 59 + this.Confirmation.GetHashCode();
                if (this.AddressResidentialIndicator != null)
                    hashCode = hashCode * 59 + this.AddressResidentialIndicator.GetHashCode();
                if (this.ShipDate != null)
                    hashCode = hashCode * 59 + this.ShipDate.GetHashCode();
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
