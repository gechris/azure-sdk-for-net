// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.FormRecognizer.Custom
{
    internal static class TrainingStatusExtensions
    {
        public static string ToSerialString(this TrainingStatus value) => value switch
        {
            TrainingStatus.Succeeded => "succeeded",
            TrainingStatus.PartiallySucceeded => "partiallySucceeded",
            TrainingStatus.Failed => "failed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TrainingStatus value.")
        };

        public static TrainingStatus ToTrainingStatus(this string value)
        {
            if (string.Equals(value, "succeeded", StringComparison.InvariantCultureIgnoreCase)) return TrainingStatus.Succeeded;
            if (string.Equals(value, "partiallySucceeded", StringComparison.InvariantCultureIgnoreCase)) return TrainingStatus.PartiallySucceeded;
            if (string.Equals(value, "failed", StringComparison.InvariantCultureIgnoreCase)) return TrainingStatus.Failed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown TrainingStatus value.");
        }
    }
}
