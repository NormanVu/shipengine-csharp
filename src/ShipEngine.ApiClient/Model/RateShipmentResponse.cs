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
    /// RateShipmentResponse
    /// </summary>
    [DataContract]
    public partial class RateShipmentResponse :  IEquatable<RateShipmentResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ShipmentStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShipmentStatusEnum
        {
            
            /// <summary>
            /// Enum Pending for "pending"
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending,
            
            /// <summary>
            /// Enum Processing for "processing"
            /// </summary>
            [EnumMember(Value = "processing")]
            Processing,
            
            /// <summary>
            /// Enum Labelpurchased for "label_purchased"
            /// </summary>
            [EnumMember(Value = "label_purchased")]
            Labelpurchased,
            
            /// <summary>
            /// Enum Cancelled for "cancelled"
            /// </summary>
            [EnumMember(Value = "cancelled")]
            Cancelled
        }

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
            None,
            
            /// <summary>
            /// Enum Delivery for "delivery"
            /// </summary>
            [EnumMember(Value = "delivery")]
            Delivery,
            
            /// <summary>
            /// Enum Signature for "signature"
            /// </summary>
            [EnumMember(Value = "signature")]
            Signature,
            
            /// <summary>
            /// Enum Adultsignature for "adult_signature"
            /// </summary>
            [EnumMember(Value = "adult_signature")]
            Adultsignature,
            
            /// <summary>
            /// Enum Directsignature for "direct_signature"
            /// </summary>
            [EnumMember(Value = "direct_signature")]
            Directsignature
        }

        /// <summary>
        /// Gets or Sets InsuranceProvider
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InsuranceProviderEnum
        {
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None,
            
            /// <summary>
            /// Enum Shipsurance for "shipsurance"
            /// </summary>
            [EnumMember(Value = "shipsurance")]
            Shipsurance,
            
            /// <summary>
            /// Enum Carrier for "carrier"
            /// </summary>
            [EnumMember(Value = "carrier")]
            Carrier
        }

        /// <summary>
        /// Gets or Sets ShipmentStatus
        /// </summary>
        [DataMember(Name="shipment_status", EmitDefaultValue=false)]
        public ShipmentStatusEnum? ShipmentStatus { get; set; }
        /// <summary>
        /// Gets or Sets Confirmation
        /// </summary>
        [DataMember(Name="confirmation", EmitDefaultValue=false)]
        public ConfirmationEnum? Confirmation { get; set; }
        /// <summary>
        /// Gets or Sets InsuranceProvider
        /// </summary>
        [DataMember(Name="insurance_provider", EmitDefaultValue=false)]
        public InsuranceProviderEnum? InsuranceProvider { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RateShipmentResponse" /> class.
        /// </summary>
        /// <param name="RateResponse">RateResponse.</param>
        /// <param name="ShipmentId">ShipmentId.</param>
        /// <param name="CarrierId">CarrierId.</param>
        /// <param name="ServiceCode">ServiceCode.</param>
        /// <param name="ExternalShipmentId">ExternalShipmentId.</param>
        /// <param name="ShipDate">ShipDate.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="ModifiedAt">ModifiedAt.</param>
        /// <param name="ShipmentStatus">ShipmentStatus.</param>
        /// <param name="ShipTo">ShipTo.</param>
        /// <param name="ShipFrom">ShipFrom.</param>
        /// <param name="WarehouseId">WarehouseId.</param>
        /// <param name="ReturnTo">ReturnTo.</param>
        /// <param name="Confirmation">Confirmation.</param>
        /// <param name="Customs">Customs.</param>
        /// <param name="AdvancedOptions">AdvancedOptions.</param>
        /// <param name="InsuranceProvider">InsuranceProvider.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="TotalWeight">TotalWeight.</param>
        /// <param name="Packages">Packages.</param>
        public RateShipmentResponse(RateResponse RateResponse = default(RateResponse), string ShipmentId = default(string), string CarrierId = default(string), string ServiceCode = default(string), string ExternalShipmentId = default(string), DateTime? ShipDate = default(DateTime?), DateTime? CreatedAt = default(DateTime?), DateTime? ModifiedAt = default(DateTime?), ShipmentStatusEnum? ShipmentStatus = default(ShipmentStatusEnum?), AddressDTO ShipTo = default(AddressDTO), AddressDTO ShipFrom = default(AddressDTO), string WarehouseId = default(string), AddressDTO ReturnTo = default(AddressDTO), ConfirmationEnum? Confirmation = default(ConfirmationEnum?), InternationalOptions Customs = default(InternationalOptions), Dictionary<string, Object> AdvancedOptions = default(Dictionary<string, Object>), InsuranceProviderEnum? InsuranceProvider = default(InsuranceProviderEnum?), List<TagResponse> Tags = default(List<TagResponse>), Weight TotalWeight = default(Weight), List<ShipmentPackage> Packages = default(List<ShipmentPackage>))
        {
            this.RateResponse = RateResponse;
            this.ShipmentId = ShipmentId;
            this.CarrierId = CarrierId;
            this.ServiceCode = ServiceCode;
            this.ExternalShipmentId = ExternalShipmentId;
            this.ShipDate = ShipDate;
            this.CreatedAt = CreatedAt;
            this.ModifiedAt = ModifiedAt;
            this.ShipmentStatus = ShipmentStatus;
            this.ShipTo = ShipTo;
            this.ShipFrom = ShipFrom;
            this.WarehouseId = WarehouseId;
            this.ReturnTo = ReturnTo;
            this.Confirmation = Confirmation;
            this.Customs = Customs;
            this.AdvancedOptions = AdvancedOptions;
            this.InsuranceProvider = InsuranceProvider;
            this.Tags = Tags;
            this.TotalWeight = TotalWeight;
            this.Packages = Packages;
        }
        
        /// <summary>
        /// Gets or Sets RateResponse
        /// </summary>
        [DataMember(Name="rate_response", EmitDefaultValue=false)]
        public RateResponse RateResponse { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentId
        /// </summary>
        [DataMember(Name="shipment_id", EmitDefaultValue=false)]
        public string ShipmentId { get; set; }

        /// <summary>
        /// Gets or Sets CarrierId
        /// </summary>
        [DataMember(Name="carrier_id", EmitDefaultValue=false)]
        public string CarrierId { get; set; }

        /// <summary>
        /// Gets or Sets ServiceCode
        /// </summary>
        [DataMember(Name="service_code", EmitDefaultValue=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// Gets or Sets ExternalShipmentId
        /// </summary>
        [DataMember(Name="external_shipment_id", EmitDefaultValue=false)]
        public string ExternalShipmentId { get; set; }

        /// <summary>
        /// Gets or Sets ShipDate
        /// </summary>
        [DataMember(Name="ship_date", EmitDefaultValue=false)]
        public DateTime? ShipDate { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedAt
        /// </summary>
        [DataMember(Name="modified_at", EmitDefaultValue=false)]
        public DateTime? ModifiedAt { get; set; }


        /// <summary>
        /// Gets or Sets ShipTo
        /// </summary>
        [DataMember(Name="ship_to", EmitDefaultValue=false)]
        public AddressDTO ShipTo { get; set; }

        /// <summary>
        /// Gets or Sets ShipFrom
        /// </summary>
        [DataMember(Name="ship_from", EmitDefaultValue=false)]
        public AddressDTO ShipFrom { get; set; }

        /// <summary>
        /// Gets or Sets WarehouseId
        /// </summary>
        [DataMember(Name="warehouse_id", EmitDefaultValue=false)]
        public string WarehouseId { get; set; }

        /// <summary>
        /// Gets or Sets ReturnTo
        /// </summary>
        [DataMember(Name="return_to", EmitDefaultValue=false)]
        public AddressDTO ReturnTo { get; set; }


        /// <summary>
        /// Gets or Sets Customs
        /// </summary>
        [DataMember(Name="customs", EmitDefaultValue=false)]
        public InternationalOptions Customs { get; set; }

        /// <summary>
        /// Gets or Sets AdvancedOptions
        /// </summary>
        [DataMember(Name="advanced_options", EmitDefaultValue=false)]
        public Dictionary<string, Object> AdvancedOptions { get; set; }


        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<TagResponse> Tags { get; set; }

        /// <summary>
        /// Gets or Sets TotalWeight
        /// </summary>
        [DataMember(Name="total_weight", EmitDefaultValue=false)]
        public Weight TotalWeight { get; set; }

        /// <summary>
        /// Gets or Sets Packages
        /// </summary>
        [DataMember(Name="packages", EmitDefaultValue=false)]
        public List<ShipmentPackage> Packages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RateShipmentResponse {\n");
            sb.Append("  RateResponse: ").Append(RateResponse).Append("\n");
            sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
            sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
            sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
            sb.Append("  ExternalShipmentId: ").Append(ExternalShipmentId).Append("\n");
            sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  ShipmentStatus: ").Append(ShipmentStatus).Append("\n");
            sb.Append("  ShipTo: ").Append(ShipTo).Append("\n");
            sb.Append("  ShipFrom: ").Append(ShipFrom).Append("\n");
            sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
            sb.Append("  ReturnTo: ").Append(ReturnTo).Append("\n");
            sb.Append("  Confirmation: ").Append(Confirmation).Append("\n");
            sb.Append("  Customs: ").Append(Customs).Append("\n");
            sb.Append("  AdvancedOptions: ").Append(AdvancedOptions).Append("\n");
            sb.Append("  InsuranceProvider: ").Append(InsuranceProvider).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  TotalWeight: ").Append(TotalWeight).Append("\n");
            sb.Append("  Packages: ").Append(Packages).Append("\n");
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
            return this.Equals(input as RateShipmentResponse);
        }

        /// <summary>
        /// Returns true if RateShipmentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RateShipmentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RateShipmentResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RateResponse == input.RateResponse ||
                    (this.RateResponse != null &&
                    this.RateResponse.Equals(input.RateResponse))
                ) && 
                (
                    this.ShipmentId == input.ShipmentId ||
                    (this.ShipmentId != null &&
                    this.ShipmentId.Equals(input.ShipmentId))
                ) && 
                (
                    this.CarrierId == input.CarrierId ||
                    (this.CarrierId != null &&
                    this.CarrierId.Equals(input.CarrierId))
                ) && 
                (
                    this.ServiceCode == input.ServiceCode ||
                    (this.ServiceCode != null &&
                    this.ServiceCode.Equals(input.ServiceCode))
                ) && 
                (
                    this.ExternalShipmentId == input.ExternalShipmentId ||
                    (this.ExternalShipmentId != null &&
                    this.ExternalShipmentId.Equals(input.ExternalShipmentId))
                ) && 
                (
                    this.ShipDate == input.ShipDate ||
                    (this.ShipDate != null &&
                    this.ShipDate.Equals(input.ShipDate))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ModifiedAt == input.ModifiedAt ||
                    (this.ModifiedAt != null &&
                    this.ModifiedAt.Equals(input.ModifiedAt))
                ) && 
                (
                    this.ShipmentStatus == input.ShipmentStatus ||
                    (this.ShipmentStatus != null &&
                    this.ShipmentStatus.Equals(input.ShipmentStatus))
                ) && 
                (
                    this.ShipTo == input.ShipTo ||
                    (this.ShipTo != null &&
                    this.ShipTo.Equals(input.ShipTo))
                ) && 
                (
                    this.ShipFrom == input.ShipFrom ||
                    (this.ShipFrom != null &&
                    this.ShipFrom.Equals(input.ShipFrom))
                ) && 
                (
                    this.WarehouseId == input.WarehouseId ||
                    (this.WarehouseId != null &&
                    this.WarehouseId.Equals(input.WarehouseId))
                ) && 
                (
                    this.ReturnTo == input.ReturnTo ||
                    (this.ReturnTo != null &&
                    this.ReturnTo.Equals(input.ReturnTo))
                ) && 
                (
                    this.Confirmation == input.Confirmation ||
                    (this.Confirmation != null &&
                    this.Confirmation.Equals(input.Confirmation))
                ) && 
                (
                    this.Customs == input.Customs ||
                    (this.Customs != null &&
                    this.Customs.Equals(input.Customs))
                ) && 
                (
                    this.AdvancedOptions == input.AdvancedOptions ||
                    (this.AdvancedOptions != null &&
                    this.AdvancedOptions.SequenceEqual(input.AdvancedOptions))
                ) && 
                (
                    this.InsuranceProvider == input.InsuranceProvider ||
                    (this.InsuranceProvider != null &&
                    this.InsuranceProvider.Equals(input.InsuranceProvider))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags))
                ) && 
                (
                    this.TotalWeight == input.TotalWeight ||
                    (this.TotalWeight != null &&
                    this.TotalWeight.Equals(input.TotalWeight))
                ) && 
                (
                    this.Packages == input.Packages ||
                    (this.Packages != null &&
                    this.Packages.SequenceEqual(input.Packages))
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
                if (this.RateResponse != null)
                    hashCode = hashCode * 59 + this.RateResponse.GetHashCode();
                if (this.ShipmentId != null)
                    hashCode = hashCode * 59 + this.ShipmentId.GetHashCode();
                if (this.CarrierId != null)
                    hashCode = hashCode * 59 + this.CarrierId.GetHashCode();
                if (this.ServiceCode != null)
                    hashCode = hashCode * 59 + this.ServiceCode.GetHashCode();
                if (this.ExternalShipmentId != null)
                    hashCode = hashCode * 59 + this.ExternalShipmentId.GetHashCode();
                if (this.ShipDate != null)
                    hashCode = hashCode * 59 + this.ShipDate.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ModifiedAt != null)
                    hashCode = hashCode * 59 + this.ModifiedAt.GetHashCode();
                if (this.ShipmentStatus != null)
                    hashCode = hashCode * 59 + this.ShipmentStatus.GetHashCode();
                if (this.ShipTo != null)
                    hashCode = hashCode * 59 + this.ShipTo.GetHashCode();
                if (this.ShipFrom != null)
                    hashCode = hashCode * 59 + this.ShipFrom.GetHashCode();
                if (this.WarehouseId != null)
                    hashCode = hashCode * 59 + this.WarehouseId.GetHashCode();
                if (this.ReturnTo != null)
                    hashCode = hashCode * 59 + this.ReturnTo.GetHashCode();
                if (this.Confirmation != null)
                    hashCode = hashCode * 59 + this.Confirmation.GetHashCode();
                if (this.Customs != null)
                    hashCode = hashCode * 59 + this.Customs.GetHashCode();
                if (this.AdvancedOptions != null)
                    hashCode = hashCode * 59 + this.AdvancedOptions.GetHashCode();
                if (this.InsuranceProvider != null)
                    hashCode = hashCode * 59 + this.InsuranceProvider.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TotalWeight != null)
                    hashCode = hashCode * 59 + this.TotalWeight.GetHashCode();
                if (this.Packages != null)
                    hashCode = hashCode * 59 + this.Packages.GetHashCode();
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
