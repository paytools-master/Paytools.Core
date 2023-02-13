﻿// Copyright (c) 2023 Paytools Foundation
//
// Licensed under the Apache License, Version 2.0 (the "License")~
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Paytools.IncomeTax;

public enum TaxTreatment
{
    Unspecified,
    NT,
    BR,
    D0,
    D1,
    D2,
    _0T,
    K,
    L,
    M,
    N
}

public static class TaxTreatmentExtensions
{
    public static int GetBandIndex(this TaxTreatment taxTreatment)
    {
        return taxTreatment switch
        {
            TaxTreatment.BR => 0,
            TaxTreatment.D0 => 1,
            TaxTreatment.D1 => 2,
            TaxTreatment.D2 => 3,
            _ => throw new ArgumentException($"Band index not valid for tax treatment {taxTreatment}", nameof(taxTreatment))
        };
    }
}