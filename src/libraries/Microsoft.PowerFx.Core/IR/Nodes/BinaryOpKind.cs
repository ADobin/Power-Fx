﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

namespace Microsoft.PowerFx.Core.IR.Nodes
{
    internal enum BinaryOpKind
    {
        Invalid,

        InText,
        ExactInText,
        InScalarTable,
        ExactInScalarTable,
        InRecordTable,

        AddNumbers,
        AddDateAndTime, // Date + Time
        AddDateAndDay, // Date + Number (Days)
        AddDateTimeAndDay,
        AddTimeAndNumber, // Time + Number (typically fraction of a day)
        AddTimeAndTime, // Time + Time ==> Time

        AddDecimals,

        DateDifference,
        TimeDifference,

        SubtractDateAndTime,
        SubtractNumberAndDate,
        SubtractNumberAndDateTime,
        SubtractNumberAndTime,

        MulNumbers,
        MulDecimals,

        DivNumbers,
        DivDecimals,

        EqNumbers,
        EqBoolean,
        EqText,
        EqDate,
        EqTime,
        EqDateTime,
        EqHyperlink,
        EqCurrency,
        EqImage,
        EqColor,
        EqMedia,
        EqBlob,
        EqGuid,
        EqOptionSetValue,
        EqViewValue,
        EqNamedValue,
        EqNull,
        EqDecimals,
        EqNullUntyped,
        EqPolymorphic,

        NeqNumbers,
        NeqBoolean,
        NeqText,
        NeqDate,
        NeqTime,
        NeqDateTime,
        NeqHyperlink,
        NeqCurrency,
        NeqImage,
        NeqColor,
        NeqMedia,
        NeqBlob,
        NeqGuid,
        NeqOptionSetValue,
        NeqViewValue,
        NeqNamedValue,
        NeqNull,
        NeqDecimals,
        NeqNullUntyped,
        NeqPolymorphic,

        LtNumbers,
        LeqNumbers,
        GtNumbers,
        GeqNumbers,

        LtDecimals,
        LeqDecimals,
        GtDecimals,
        GeqDecimals,

        LtDateTime,
        LeqDateTime,
        GtDateTime,
        GeqDateTime,

        LtDate,
        LeqDate,
        GtDate,
        GeqDate,

        LtTime,
        LeqTime,
        GtTime,
        GeqTime,
        DynamicGetField,

        // And, Or, Pow, Concatenate get represented as FunctionNodes with lambdas to handle short-circuiting
        // Included here to make the matrix cleaner, should not be generated in IR.
        Power,
        Concatenate,
        And,
        Or,

        // These are reversed versions of earlier ops, added to make the matrix cleaner
        AddTimeAndDate,
        AddDayAndDate,
        AddNumberAndTime,
        AddDayAndDateTime,

        LtNull,
        LeqNull,
        GtNull,
        GeqNull,
    }
}
