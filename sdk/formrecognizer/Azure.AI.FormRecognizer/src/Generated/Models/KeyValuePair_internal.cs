// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Information about the extracted key-value pair. </summary>
    internal partial class KeyValuePair_internal
    {
        /// <summary> Initializes a new instance of KeyValuePair_internal. </summary>
        /// <param name="key"> Information about the extracted key in a key-value pair. </param>
        /// <param name="value"> Information about the extracted value in a key-value pair. </param>
        /// <param name="confidence"> Confidence value. </param>
        internal KeyValuePair_internal(KeyValueElement_internal key, KeyValueElement_internal value, float confidence)
        {
            Key = key;
            Value = value;
            Confidence = confidence;
        }

        /// <summary> Initializes a new instance of KeyValuePair_internal. </summary>
        /// <param name="label"> A user defined label for the key/value pair entry. </param>
        /// <param name="key"> Information about the extracted key in a key-value pair. </param>
        /// <param name="value"> Information about the extracted value in a key-value pair. </param>
        /// <param name="confidence"> Confidence value. </param>
        internal KeyValuePair_internal(string label, KeyValueElement_internal key, KeyValueElement_internal value, float confidence)
        {
            Label = label;
            Key = key;
            Value = value;
            Confidence = confidence;
        }

        /// <summary> A user defined label for the key/value pair entry. </summary>
        public string Label { get; }
        /// <summary> Information about the extracted key in a key-value pair. </summary>
        public KeyValueElement_internal Key { get; }
        /// <summary> Information about the extracted value in a key-value pair. </summary>
        public KeyValueElement_internal Value { get; }
        /// <summary> Confidence value. </summary>
        public float Confidence { get; }
    }
}
