using System;
using System.Collections.Generic;
using System.Text;

namespace S85S.Core.Models
{
    public class EditableKeyValuePair<KEY, VALUE>
    {
        public KEY Key { get; set; }
        public VALUE Value { get; set; }

        public EditableKeyValuePair()
        {
            Key = default;
            Value = default;
        }

        public EditableKeyValuePair(KEY key, VALUE value)
        {
            Key = key;
            Value = value;
        }
    }
}
