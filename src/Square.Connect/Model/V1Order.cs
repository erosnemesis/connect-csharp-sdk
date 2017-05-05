/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
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

namespace Square.Connect.Model
{
    /// <summary>
    /// V1Order
    /// </summary>
    [DataContract]
    public partial class V1Order :  IEquatable<V1Order>, IValidatableObject
    {
        /// <summary>
        /// Whether the tax is an ADDITIVE tax or an INCLUSIVE tax.
        /// </summary>
        /// <value>Whether the tax is an ADDITIVE tax or an INCLUSIVE tax.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum PENDING for "PENDING"
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING,
            
            /// <summary>
            /// Enum OPEN for "OPEN"
            /// </summary>
            [EnumMember(Value = "OPEN")]
            OPEN,
            
            /// <summary>
            /// Enum COMPLETED for "COMPLETED"
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            COMPLETED,
            
            /// <summary>
            /// Enum CANCELED for "CANCELED"
            /// </summary>
            [EnumMember(Value = "CANCELED")]
            CANCELED,
            
            /// <summary>
            /// Enum REFUNDED for "REFUNDED"
            /// </summary>
            [EnumMember(Value = "REFUNDED")]
            REFUNDED,
            
            /// <summary>
            /// Enum REJECTED for "REJECTED"
            /// </summary>
            [EnumMember(Value = "REJECTED")]
            REJECTED
        }

        /// <summary>
        /// Whether the tax is an ADDITIVE tax or an INCLUSIVE tax.
        /// </summary>
        /// <value>Whether the tax is an ADDITIVE tax or an INCLUSIVE tax.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1Order" /> class.
        /// </summary>
        /// <param name="Errors">Any errors that occurred during the request..</param>
        /// <param name="Id">The order&#39;s unique identifier..</param>
        /// <param name="BuyerEmail">The email address of the order&#39;s buyer..</param>
        /// <param name="RecipientName">The name of the order&#39;s buyer..</param>
        /// <param name="RecipientPhoneNumber">The phone number to use for the order&#39;s delivery..</param>
        /// <param name="State">Whether the tax is an ADDITIVE tax or an INCLUSIVE tax..</param>
        /// <param name="ShippingAddress">The address to ship the order to..</param>
        /// <param name="SubtotalMoney">The amount of all items purchased in the order, before taxes and shipping..</param>
        /// <param name="TotalShippingMoney">The shipping cost for the order..</param>
        /// <param name="TotalTaxMoney">The total of all taxes applied to the order..</param>
        /// <param name="TotalPriceMoney">The total cost of the order..</param>
        /// <param name="TotalDiscountMoney">The total of all discounts applied to the order..</param>
        /// <param name="CreatedAt">The time when the order was created, in ISO 8601 format..</param>
        /// <param name="UpdatedAt">The time when the order was last modified, in ISO 8601 format..</param>
        /// <param name="ExpiresAt">The time when the order expires if no action is taken, in ISO 8601 format..</param>
        /// <param name="PaymentId">The unique identifier of the payment associated with the order..</param>
        /// <param name="BuyerNote">A note provided by the buyer when the order was created, if any..</param>
        /// <param name="CompletedNote">A note provided by the merchant when the order&#39;s state was set to COMPLETED, if any.</param>
        /// <param name="RefundedNote">A note provided by the merchant when the order&#39;s state was set to REFUNDED, if any..</param>
        /// <param name="CanceledNote">A note provided by the merchant when the order&#39;s state was set to CANCELED, if any..</param>
        /// <param name="Tender">The tender used to pay for the order..</param>
        /// <param name="OrderHistory">The history of actions associated with the order..</param>
        /// <param name="PromoCode">The promo code provided by the buyer, if any..</param>
        /// <param name="BtcReceiveAddress">For Bitcoin transactions, the address that the buyer sent Bitcoin to..</param>
        /// <param name="BtcPriceSatoshi">For Bitcoin transactions, the price of the buyer&#39;s order in satoshi (100 million satoshi equals 1 BTC)..</param>
        public V1Order(List<Error> Errors = default(List<Error>), string Id = default(string), string BuyerEmail = default(string), string RecipientName = default(string), string RecipientPhoneNumber = default(string), StateEnum? State = default(StateEnum?), Address ShippingAddress = default(Address), V1Money SubtotalMoney = default(V1Money), V1Money TotalShippingMoney = default(V1Money), V1Money TotalTaxMoney = default(V1Money), V1Money TotalPriceMoney = default(V1Money), V1Money TotalDiscountMoney = default(V1Money), string CreatedAt = default(string), string UpdatedAt = default(string), string ExpiresAt = default(string), string PaymentId = default(string), string BuyerNote = default(string), string CompletedNote = default(string), string RefundedNote = default(string), string CanceledNote = default(string), V1Tender Tender = default(V1Tender), List<V1OrderHistoryEntry> OrderHistory = default(List<V1OrderHistoryEntry>), string PromoCode = default(string), string BtcReceiveAddress = default(string), decimal? BtcPriceSatoshi = default(decimal?))
        {
            this.Errors = Errors;
            this.Id = Id;
            this.BuyerEmail = BuyerEmail;
            this.RecipientName = RecipientName;
            this.RecipientPhoneNumber = RecipientPhoneNumber;
            this.State = State;
            this.ShippingAddress = ShippingAddress;
            this.SubtotalMoney = SubtotalMoney;
            this.TotalShippingMoney = TotalShippingMoney;
            this.TotalTaxMoney = TotalTaxMoney;
            this.TotalPriceMoney = TotalPriceMoney;
            this.TotalDiscountMoney = TotalDiscountMoney;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
            this.ExpiresAt = ExpiresAt;
            this.PaymentId = PaymentId;
            this.BuyerNote = BuyerNote;
            this.CompletedNote = CompletedNote;
            this.RefundedNote = RefundedNote;
            this.CanceledNote = CanceledNote;
            this.Tender = Tender;
            this.OrderHistory = OrderHistory;
            this.PromoCode = PromoCode;
            this.BtcReceiveAddress = BtcReceiveAddress;
            this.BtcPriceSatoshi = BtcPriceSatoshi;
        }
        
        /// <summary>
        /// Any errors that occurred during the request.
        /// </summary>
        /// <value>Any errors that occurred during the request.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<Error> Errors { get; set; }
        /// <summary>
        /// The order&#39;s unique identifier.
        /// </summary>
        /// <value>The order&#39;s unique identifier.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The email address of the order&#39;s buyer.
        /// </summary>
        /// <value>The email address of the order&#39;s buyer.</value>
        [DataMember(Name="buyer_email", EmitDefaultValue=false)]
        public string BuyerEmail { get; set; }
        /// <summary>
        /// The name of the order&#39;s buyer.
        /// </summary>
        /// <value>The name of the order&#39;s buyer.</value>
        [DataMember(Name="recipient_name", EmitDefaultValue=false)]
        public string RecipientName { get; set; }
        /// <summary>
        /// The phone number to use for the order&#39;s delivery.
        /// </summary>
        /// <value>The phone number to use for the order&#39;s delivery.</value>
        [DataMember(Name="recipient_phone_number", EmitDefaultValue=false)]
        public string RecipientPhoneNumber { get; set; }
        /// <summary>
        /// The address to ship the order to.
        /// </summary>
        /// <value>The address to ship the order to.</value>
        [DataMember(Name="shipping_address", EmitDefaultValue=false)]
        public Address ShippingAddress { get; set; }
        /// <summary>
        /// The amount of all items purchased in the order, before taxes and shipping.
        /// </summary>
        /// <value>The amount of all items purchased in the order, before taxes and shipping.</value>
        [DataMember(Name="subtotal_money", EmitDefaultValue=false)]
        public V1Money SubtotalMoney { get; set; }
        /// <summary>
        /// The shipping cost for the order.
        /// </summary>
        /// <value>The shipping cost for the order.</value>
        [DataMember(Name="total_shipping_money", EmitDefaultValue=false)]
        public V1Money TotalShippingMoney { get; set; }
        /// <summary>
        /// The total of all taxes applied to the order.
        /// </summary>
        /// <value>The total of all taxes applied to the order.</value>
        [DataMember(Name="total_tax_money", EmitDefaultValue=false)]
        public V1Money TotalTaxMoney { get; set; }
        /// <summary>
        /// The total cost of the order.
        /// </summary>
        /// <value>The total cost of the order.</value>
        [DataMember(Name="total_price_money", EmitDefaultValue=false)]
        public V1Money TotalPriceMoney { get; set; }
        /// <summary>
        /// The total of all discounts applied to the order.
        /// </summary>
        /// <value>The total of all discounts applied to the order.</value>
        [DataMember(Name="total_discount_money", EmitDefaultValue=false)]
        public V1Money TotalDiscountMoney { get; set; }
        /// <summary>
        /// The time when the order was created, in ISO 8601 format.
        /// </summary>
        /// <value>The time when the order was created, in ISO 8601 format.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
        /// <summary>
        /// The time when the order was last modified, in ISO 8601 format.
        /// </summary>
        /// <value>The time when the order was last modified, in ISO 8601 format.</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }
        /// <summary>
        /// The time when the order expires if no action is taken, in ISO 8601 format.
        /// </summary>
        /// <value>The time when the order expires if no action is taken, in ISO 8601 format.</value>
        [DataMember(Name="expires_at", EmitDefaultValue=false)]
        public string ExpiresAt { get; set; }
        /// <summary>
        /// The unique identifier of the payment associated with the order.
        /// </summary>
        /// <value>The unique identifier of the payment associated with the order.</value>
        [DataMember(Name="payment_id", EmitDefaultValue=false)]
        public string PaymentId { get; set; }
        /// <summary>
        /// A note provided by the buyer when the order was created, if any.
        /// </summary>
        /// <value>A note provided by the buyer when the order was created, if any.</value>
        [DataMember(Name="buyer_note", EmitDefaultValue=false)]
        public string BuyerNote { get; set; }
        /// <summary>
        /// A note provided by the merchant when the order&#39;s state was set to COMPLETED, if any
        /// </summary>
        /// <value>A note provided by the merchant when the order&#39;s state was set to COMPLETED, if any</value>
        [DataMember(Name="completed_note", EmitDefaultValue=false)]
        public string CompletedNote { get; set; }
        /// <summary>
        /// A note provided by the merchant when the order&#39;s state was set to REFUNDED, if any.
        /// </summary>
        /// <value>A note provided by the merchant when the order&#39;s state was set to REFUNDED, if any.</value>
        [DataMember(Name="refunded_note", EmitDefaultValue=false)]
        public string RefundedNote { get; set; }
        /// <summary>
        /// A note provided by the merchant when the order&#39;s state was set to CANCELED, if any.
        /// </summary>
        /// <value>A note provided by the merchant when the order&#39;s state was set to CANCELED, if any.</value>
        [DataMember(Name="canceled_note", EmitDefaultValue=false)]
        public string CanceledNote { get; set; }
        /// <summary>
        /// The tender used to pay for the order.
        /// </summary>
        /// <value>The tender used to pay for the order.</value>
        [DataMember(Name="tender", EmitDefaultValue=false)]
        public V1Tender Tender { get; set; }
        /// <summary>
        /// The history of actions associated with the order.
        /// </summary>
        /// <value>The history of actions associated with the order.</value>
        [DataMember(Name="order_history", EmitDefaultValue=false)]
        public List<V1OrderHistoryEntry> OrderHistory { get; set; }
        /// <summary>
        /// The promo code provided by the buyer, if any.
        /// </summary>
        /// <value>The promo code provided by the buyer, if any.</value>
        [DataMember(Name="promo_code", EmitDefaultValue=false)]
        public string PromoCode { get; set; }
        /// <summary>
        /// For Bitcoin transactions, the address that the buyer sent Bitcoin to.
        /// </summary>
        /// <value>For Bitcoin transactions, the address that the buyer sent Bitcoin to.</value>
        [DataMember(Name="btc_receive_address", EmitDefaultValue=false)]
        public string BtcReceiveAddress { get; set; }
        /// <summary>
        /// For Bitcoin transactions, the price of the buyer&#39;s order in satoshi (100 million satoshi equals 1 BTC).
        /// </summary>
        /// <value>For Bitcoin transactions, the price of the buyer&#39;s order in satoshi (100 million satoshi equals 1 BTC).</value>
        [DataMember(Name="btc_price_satoshi", EmitDefaultValue=false)]
        public decimal? BtcPriceSatoshi { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1Order {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BuyerEmail: ").Append(BuyerEmail).Append("\n");
            sb.Append("  RecipientName: ").Append(RecipientName).Append("\n");
            sb.Append("  RecipientPhoneNumber: ").Append(RecipientPhoneNumber).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  SubtotalMoney: ").Append(SubtotalMoney).Append("\n");
            sb.Append("  TotalShippingMoney: ").Append(TotalShippingMoney).Append("\n");
            sb.Append("  TotalTaxMoney: ").Append(TotalTaxMoney).Append("\n");
            sb.Append("  TotalPriceMoney: ").Append(TotalPriceMoney).Append("\n");
            sb.Append("  TotalDiscountMoney: ").Append(TotalDiscountMoney).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
            sb.Append("  BuyerNote: ").Append(BuyerNote).Append("\n");
            sb.Append("  CompletedNote: ").Append(CompletedNote).Append("\n");
            sb.Append("  RefundedNote: ").Append(RefundedNote).Append("\n");
            sb.Append("  CanceledNote: ").Append(CanceledNote).Append("\n");
            sb.Append("  Tender: ").Append(Tender).Append("\n");
            sb.Append("  OrderHistory: ").Append(OrderHistory).Append("\n");
            sb.Append("  PromoCode: ").Append(PromoCode).Append("\n");
            sb.Append("  BtcReceiveAddress: ").Append(BtcReceiveAddress).Append("\n");
            sb.Append("  BtcPriceSatoshi: ").Append(BtcPriceSatoshi).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as V1Order);
        }

        /// <summary>
        /// Returns true if V1Order instances are equal
        /// </summary>
        /// <param name="other">Instance of V1Order to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1Order other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.BuyerEmail == other.BuyerEmail ||
                    this.BuyerEmail != null &&
                    this.BuyerEmail.Equals(other.BuyerEmail)
                ) && 
                (
                    this.RecipientName == other.RecipientName ||
                    this.RecipientName != null &&
                    this.RecipientName.Equals(other.RecipientName)
                ) && 
                (
                    this.RecipientPhoneNumber == other.RecipientPhoneNumber ||
                    this.RecipientPhoneNumber != null &&
                    this.RecipientPhoneNumber.Equals(other.RecipientPhoneNumber)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.ShippingAddress == other.ShippingAddress ||
                    this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(other.ShippingAddress)
                ) && 
                (
                    this.SubtotalMoney == other.SubtotalMoney ||
                    this.SubtotalMoney != null &&
                    this.SubtotalMoney.Equals(other.SubtotalMoney)
                ) && 
                (
                    this.TotalShippingMoney == other.TotalShippingMoney ||
                    this.TotalShippingMoney != null &&
                    this.TotalShippingMoney.Equals(other.TotalShippingMoney)
                ) && 
                (
                    this.TotalTaxMoney == other.TotalTaxMoney ||
                    this.TotalTaxMoney != null &&
                    this.TotalTaxMoney.Equals(other.TotalTaxMoney)
                ) && 
                (
                    this.TotalPriceMoney == other.TotalPriceMoney ||
                    this.TotalPriceMoney != null &&
                    this.TotalPriceMoney.Equals(other.TotalPriceMoney)
                ) && 
                (
                    this.TotalDiscountMoney == other.TotalDiscountMoney ||
                    this.TotalDiscountMoney != null &&
                    this.TotalDiscountMoney.Equals(other.TotalDiscountMoney)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    this.ExpiresAt == other.ExpiresAt ||
                    this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(other.ExpiresAt)
                ) && 
                (
                    this.PaymentId == other.PaymentId ||
                    this.PaymentId != null &&
                    this.PaymentId.Equals(other.PaymentId)
                ) && 
                (
                    this.BuyerNote == other.BuyerNote ||
                    this.BuyerNote != null &&
                    this.BuyerNote.Equals(other.BuyerNote)
                ) && 
                (
                    this.CompletedNote == other.CompletedNote ||
                    this.CompletedNote != null &&
                    this.CompletedNote.Equals(other.CompletedNote)
                ) && 
                (
                    this.RefundedNote == other.RefundedNote ||
                    this.RefundedNote != null &&
                    this.RefundedNote.Equals(other.RefundedNote)
                ) && 
                (
                    this.CanceledNote == other.CanceledNote ||
                    this.CanceledNote != null &&
                    this.CanceledNote.Equals(other.CanceledNote)
                ) && 
                (
                    this.Tender == other.Tender ||
                    this.Tender != null &&
                    this.Tender.Equals(other.Tender)
                ) && 
                (
                    this.OrderHistory == other.OrderHistory ||
                    this.OrderHistory != null &&
                    this.OrderHistory.SequenceEqual(other.OrderHistory)
                ) && 
                (
                    this.PromoCode == other.PromoCode ||
                    this.PromoCode != null &&
                    this.PromoCode.Equals(other.PromoCode)
                ) && 
                (
                    this.BtcReceiveAddress == other.BtcReceiveAddress ||
                    this.BtcReceiveAddress != null &&
                    this.BtcReceiveAddress.Equals(other.BtcReceiveAddress)
                ) && 
                (
                    this.BtcPriceSatoshi == other.BtcPriceSatoshi ||
                    this.BtcPriceSatoshi != null &&
                    this.BtcPriceSatoshi.Equals(other.BtcPriceSatoshi)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.BuyerEmail != null)
                    hash = hash * 59 + this.BuyerEmail.GetHashCode();
                if (this.RecipientName != null)
                    hash = hash * 59 + this.RecipientName.GetHashCode();
                if (this.RecipientPhoneNumber != null)
                    hash = hash * 59 + this.RecipientPhoneNumber.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.ShippingAddress != null)
                    hash = hash * 59 + this.ShippingAddress.GetHashCode();
                if (this.SubtotalMoney != null)
                    hash = hash * 59 + this.SubtotalMoney.GetHashCode();
                if (this.TotalShippingMoney != null)
                    hash = hash * 59 + this.TotalShippingMoney.GetHashCode();
                if (this.TotalTaxMoney != null)
                    hash = hash * 59 + this.TotalTaxMoney.GetHashCode();
                if (this.TotalPriceMoney != null)
                    hash = hash * 59 + this.TotalPriceMoney.GetHashCode();
                if (this.TotalDiscountMoney != null)
                    hash = hash * 59 + this.TotalDiscountMoney.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                if (this.ExpiresAt != null)
                    hash = hash * 59 + this.ExpiresAt.GetHashCode();
                if (this.PaymentId != null)
                    hash = hash * 59 + this.PaymentId.GetHashCode();
                if (this.BuyerNote != null)
                    hash = hash * 59 + this.BuyerNote.GetHashCode();
                if (this.CompletedNote != null)
                    hash = hash * 59 + this.CompletedNote.GetHashCode();
                if (this.RefundedNote != null)
                    hash = hash * 59 + this.RefundedNote.GetHashCode();
                if (this.CanceledNote != null)
                    hash = hash * 59 + this.CanceledNote.GetHashCode();
                if (this.Tender != null)
                    hash = hash * 59 + this.Tender.GetHashCode();
                if (this.OrderHistory != null)
                    hash = hash * 59 + this.OrderHistory.GetHashCode();
                if (this.PromoCode != null)
                    hash = hash * 59 + this.PromoCode.GetHashCode();
                if (this.BtcReceiveAddress != null)
                    hash = hash * 59 + this.BtcReceiveAddress.GetHashCode();
                if (this.BtcPriceSatoshi != null)
                    hash = hash * 59 + this.BtcPriceSatoshi.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}