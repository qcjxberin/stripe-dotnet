namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CustomerUpdateOptions : BaseOptions
    {
        [JsonProperty("account_balance")]
        public long? AccountBalance { get; set; }

        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("default_source")]
        public string DefaultSource { get; set; }

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

        [JsonProperty("shipping")]
        public ShippingOptions Shipping { get; set; }

        /// <summary>
        /// A Token’s or a Source’s ID, as returned by
        /// <a href="https://stripe.com/docs/elements">Elements</a>. Passing <c>source</c> will
        /// create a new source object, make it the new customer default source, and delete the old\
        /// customer default if one exists. If you want to add additional sources instead of
        /// replacing the existing default, use
        /// <see cref="CardService.Create(string, CardCreateOptions, RequestOptions)"/>. Whenever
        /// you attach a card to a customer, Stripe will automatically validate the card.
        /// </summary>
        [JsonProperty("source")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<string, CardCreateNestedOptions> Source { get; set; }

        [JsonProperty("tax_info")]
        public CustomerTaxInfoOptions TaxInfo { get; set; }

        [JsonProperty("validate")]
        public bool? Validate { get; set; }
    }
}
