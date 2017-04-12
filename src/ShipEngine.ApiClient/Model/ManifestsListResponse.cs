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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace ShipEngine.ApiClient.Model
{
    /// <summary>
    ///     ManifestsListResponse
    /// </summary>
    [DataContract]
    public class ManifestsListResponse : IEquatable<ManifestsListResponse>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ManifestsListResponse" /> class.
        /// </summary>
        /// <param name="manifests">Manifests.</param>
        /// <param name="total">Total.</param>
        /// <param name="page">Page.</param>
        /// <param name="pages">Pages.</param>
        /// <param name="links">Links.</param>
        public ManifestsListResponse(List<Manifest> manifests = default(List<Manifest>), int? total = default(int?),
            int? page = default(int?), int? pages = default(int?), PaginationLinkDTO links = default(PaginationLinkDTO))
        {
            Manifests = manifests;
            Total = total;
            Page = page;
            Pages = pages;
            Links = links;
        }

        /// <summary>
        ///     Gets or Sets Manifests
        /// </summary>
        [DataMember(Name = "manifests", EmitDefaultValue = false)]
        public List<Manifest> Manifests { get; set; }

        /// <summary>
        ///     Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int? Total { get; set; }

        /// <summary>
        ///     Gets or Sets Page
        /// </summary>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public int? Page { get; set; }

        /// <summary>
        ///     Gets or Sets Pages
        /// </summary>
        [DataMember(Name = "pages", EmitDefaultValue = false)]
        public int? Pages { get; set; }

        /// <summary>
        ///     Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public PaginationLinkDTO Links { get; set; }

        /// <summary>
        ///     Returns true if ManifestsListResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ManifestsListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManifestsListResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
            {
                return false;
            }

            return
                (
                    Manifests == other.Manifests ||
                    Manifests != null &&
                    Manifests.SequenceEqual(other.Manifests)
                ) &&
                (
                    Total == other.Total ||
                    Total != null &&
                    Total.Equals(other.Total)
                ) &&
                (
                    Page == other.Page ||
                    Page != null &&
                    Page.Equals(other.Page)
                ) &&
                (
                    Pages == other.Pages ||
                    Pages != null &&
                    Pages.Equals(other.Pages)
                ) &&
                (
                    Equals(Links, other.Links) ||
                    Links != null &&
                    Links.Equals(other.Links)
                );
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManifestsListResponse {\n");
            sb.Append("  Manifests: ").Append(Manifests).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Pages: ").Append(Pages).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return Equals(obj as ManifestsListResponse);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                var hash = 41;
                // Suitable nullity checks etc, of course :)
                if (Manifests != null)
                {
                    hash = hash * 59 + Manifests.GetHashCode();
                }
                if (Total != null)
                {
                    hash = hash * 59 + Total.GetHashCode();
                }
                if (Page != null)
                {
                    hash = hash * 59 + Page.GetHashCode();
                }
                if (Pages != null)
                {
                    hash = hash * 59 + Pages.GetHashCode();
                }
                if (Links != null)
                {
                    hash = hash * 59 + Links.GetHashCode();
                }
                return hash;
            }
        }
    }
}