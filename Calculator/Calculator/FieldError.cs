using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow.Assist.Attributes;

namespace Calculator
{
    class FieldError
    {
        [TableAliases("Field")]
        public List<string> Field { get; set; }
        [TableAliases("Value")]
        public List<string> Value { get; set; }
    }
}
