﻿// Copyright (c) 2023-2025, Payetools Foundation.
//
// Payetools Foundation licenses this file to you under the following license(s):
//
//   * The MIT License, see https://opensource.org/license/mit/

using Payetools.ReferenceData;
using Payetools.Testing.Utils;

namespace Payetools.NationalInsurance.Tests;

public class NiCalculatorFactoryDataFixture : CalculatorFactoryDataFixture<INiCalculatorFactory>
{
    protected override INiCalculatorFactory MakeFactory(IHmrcReferenceDataProvider provider) =>
        new NiCalculatorFactory(provider);
}
