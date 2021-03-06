﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace slack.Domain.ExternalServices.Models
{
    public class Field
    {
        /// <summary>
        /// Shown as a bold heading above the value text. It cannot contain markup and will be escaped for you.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string title { get; set; }

        /// <summary>
        /// The text value of the field. It may contain standard message markup 
        /// and must be escaped as normal. May be multi-line.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// An optional flag indicating whether the value is short enough to be 
        /// displayed side-by-side with other values.
        /// </summary>
        [JsonProperty(PropertyName = "short")]
        public bool Short { get; set; }
    }
}
