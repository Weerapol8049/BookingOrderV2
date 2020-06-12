using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookingOrderV2.Models
{
    public class SoDaily
    {
        [JsonProperty(PropertyName = "No")]
        public int No { get; set; }

        [JsonProperty(PropertyName = "UserName")]
        public string UserName { get; set; }

        [JsonProperty(PropertyName = "Password")]
        public string Password { get; set; }


        [JsonProperty(PropertyName = "RecId")]
        public string RecId { get; set; }

        [JsonProperty(PropertyName = "SalesId")]
        public string SalesId { get; set; }

        [JsonProperty(PropertyName = "PurchId")]
        public string PurchId { get; set; }

        [JsonProperty(PropertyName = "StoreId")]
        public string StoreId { get; set; }

        [JsonProperty(PropertyName = "CustName")]
        public string CustName { get; set; }

        [JsonProperty(PropertyName = "Pool")]
        public string Pool { get; set; }

        [JsonProperty(PropertyName = "Qty")]
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public double Qty { get; set; }

        [JsonProperty(PropertyName = "Amount")]
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public double Amount { get; set; }

        [JsonProperty(PropertyName = "Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "DueDate")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DueDate { get; set; }

        [JsonProperty(PropertyName = "ConfirmDate")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ConfirmDate { get; set; }
    }
}