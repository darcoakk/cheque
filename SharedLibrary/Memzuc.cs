using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Memzuc
{

    [XmlRoot(ElementName = "MemzucEntResponse")]
    public class MemzucEntResponse
    {
        [XmlElement(ElementName = "bankasayisi")]
        public int BankaSayisi { get; set; }

        [XmlElement(ElementName = "errors")]
        public Errors Errors { get; set; }

        [XmlElement(ElementName = "data")]
        public Data Data { get; set; }

        [XmlElement(ElementName = "AutomaticallyResult")]
        public string AutomaticallyResult { get; set; }  // Adjusted based on actual use case
    }

    public class Errors
    {
        [XmlElement(ElementName = "error")]
        public string Error { get; set; }

        [XmlElement(ElementName = "errorText")]
        public string ErrorText { get; set; }
    }

    public class Data
    {
        [XmlElement(ElementName = "MemzucEntResult")]
        public List<MemzucEntResult> MemzucEntResults { get; set; }
    }

    public class MemzucEntResult
    {

        [XmlElement(ElementName = "period")]
        public string Period { get; set; }

        [XmlIgnore]
        public DateTime? PeriodDate { get; set; }

        [XmlElement(ElementName = "riskkod")]
        public string RiskKod { get; set; }

        [XmlElement(ElementName = "limit")]
        public long Limit { get; set; }

        [XmlElement(ElementName = "toplamrisk")]
        public long ToplamRisk { get; set; }

        [XmlElement(ElementName = "kisavade")]
        public long KisaVade { get; set; }

        [XmlElement(ElementName = "ortavade")]
        public long OrtaVade { get; set; }

        [XmlElement(ElementName = "uzunvade")]
        public long UzunVade { get; set; }

        [XmlElement(ElementName = "faizrees")]
        public long FaizRees { get; set; }

        [XmlElement(ElementName = "faiztah")]
        public long FaizTah { get; set; }

        public void SetPeriodDate()
    {
        if (!string.IsNullOrEmpty(Period))
        {
            PeriodDate = DateTime.ParseExact(Period, "yyyyMM", CultureInfo.InvariantCulture);
        }
    }

        /* Does not work with XmlSerializer
        [OnDeserialized]
        internal void OnDeserializedMethod(StreamingContext context)
        {
            if (!string.IsNullOrEmpty(Period))
            {
                _periodDate = DateTime.ParseExact(Period, "yyyyMM", CultureInfo.InvariantCulture);
            }
        }
        */
    }

}