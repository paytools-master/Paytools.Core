﻿// Copyright (c) 2023-2024, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

namespace Payetools.Statutory.AttachmentOfEarnings;

/// <summary>
/// Entity that represents the results of an attachment of earnings calculation.
/// </summary>
public readonly struct AttachmentOfEarningsCalculationResult : IAttachmentOfEarningsCalculationResult
{
    /// <summary>
    /// Gets the total deduction applicable as a result of any attachment of earnings orders.
    /// </summary>
    public decimal TotalDeduction => throw new NotImplementedException();
}
