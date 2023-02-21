﻿// Copyright (c) 2022-2023 Paytools Ltd
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

namespace Paytools.Pensions;

public readonly struct PensionContributionCalculationResult : IPensionContributionCalculationResult
{
    public decimal PensionableSalaryInPeriod { get; init; }
    public EarningsBasis EarningsBasis { get; init; }
    public decimal? EmployeeContributionPercentage { get; init; }
    public decimal? EmployeeContributionFixedAmount { get; init; }
    public decimal EmployerContributionPercentage { get; init; }
    public bool SalaryExchangeApplied { get; init; }
    public decimal? EmployersNiReinvestmentPercentage { get; init; }
    public decimal? EmployerNiSavings { get; init; }
    public decimal? EmployerContributionAmountBeforeSalaryExchange { get; init; }
    public decimal? SalaryExchangedAmount { get; init; }
    public decimal? EmployeeAvcAmount { get; init; }
    public decimal? BandedEarnings { get; init; }
    public PensionTaxTreatment TaxTreatment { get; init; }

    /// <summary>
    /// Gets the employee contribution amount resulting from the calculation.  Will be zero if SalaryExchangeApplied
    /// is true.
    /// </summary>
    public decimal EmployeeContributionAmount { get; init; }

    /// <summary>
    /// Gets the employer contribution amount resulting from the calculation.  If SalaryExchangeApplied is true,
    /// includes both calculated amounts for employer and employee contributions and any NI reinvestment to be
    /// applied (based on the value of EmployersNiReinvestmentPercentage).
    /// </summary>
    public decimal EmployerContributionAmount { get; init; }
}