using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingOrderV2.Models
{
    public class Events
    {
        public string title { set; get; }
        public string start { set; get; }
        public bool allDay { set; get; }
        public string date { set; get; }
        public string dueDate { set; get; }
        public string confirmDate { set; get; }
        public List<EventDetail> detail { set; get; }
    }
    public class EventDetail
    {
        public string SalesId { set; get; }
        public string POBONumber { set; get; }
        public string SalesName { set; get; }
        public string Pool { set; get; }
        public string CustomerName { set; get; }
        public string SHIPPINGDATECONFIRMED { set; get; }
        public string Qty { set; get; }
    }
}