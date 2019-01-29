namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CustomerCreateOptions : BaseOptions
    {
        [JsonProperty("account_balance")]
        public long? AccountBalance { get; set; }

        [JsonProperty("coupon")]
        public string CouponId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("invoice_prefix")]
        public string InvoicePrefix { get; set; }

        [JsonProperty("invoice_settings")]
        public CustomerInvoiceSettingsOptions InvoiceSettings { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("plan")]
        public string PlanId { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("shipping")]
        public ShippingOptions Shipping { get; set; }

        /// <summary>
        /// The source can either be a Token or a Source, as returned by
        /// <a href="https://stripe.com/docs/elements">Elements</a>, or a
        /// <see cref="CardCreateNestedOptions"/> containing a user’s credit card details. You must
        /// provide a source if the customer does not already have a valid source attached, and you
        /// are subscribing the customer to be charged automatically for a plan that is not free.
        /// Passing <c>source</c> will create a new source object, make it the customer default
        /// source, and delete the old customer default if one exists. If you want to add an
        /// additional source, instead use
        /// <see cref="CardService.Create(string, CardCreateOptions, RequestOptions)"/> to add the
        /// card and then <see cref="CustomerService.Update(string, CustomerUpdateOptions, RequestOptions)"/>
        /// to set it as the default. Whenever you attach a card to a customer, Stripe will
        /// automatically validate the card.
        /// </summary>
        [JsonProperty("source")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, CardCreateNestedOptions> Source { get; set; }

        [JsonProperty("tax_info")]
        public CustomerTaxInfoOptions TaxInfo { get; set; }

        [JsonProperty("tax_percent")]
        public decimal? TaxPercent { get; set; }

        [JsonProperty("trial_end")]
        public AnyOf<DateTime?, SubscriptionTrialEnd?> TrialEnd { get; set; }

        [JsonProperty("validate")]
        public bool? Validate { get; set; }
    }
}
