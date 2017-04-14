#region License
// Copyright (c) Jeremy Skinner (http://www.jeremyskinner.co.uk)
// 
// Licensed under the Apache License, Version 2.0 (the "License"); 
// you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at 
// 
// http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS, 
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// See the License for the specific language governing permissions and 
// limitations under the License.
// 
// The latest version of this file can be found at http://fluentvalidation.codeplex.com
#endregion

namespace FluentValidation.Resources {
	using Validators;

	public class SwedishLanguage : Language {
		public override string Name => "sv";

		public SwedishLanguage() {
			Translate<EmailValidator>("\"{PropertyName}\" är inte en giltig e-postadress.");
			Translate<GreaterThanOrEqualValidator>("\"{PropertyName}\" måste vara större än eller lika med {ComparisonValue}.");
			Translate<GreaterThanValidator>("\"{PropertyName}\" måste vara större än {ComparisonValue}.");
			Translate<LengthValidator>("\"{PropertyName}\" måste vara mellan {MinLength} och {MaxLength} tecken långt. Du angav {TotalLength} tecken.");
			Translate<MinimumLengthValidator>("\"{PropertyName}\" måste vara mellan {MinLength} och {MaxLength} tecken långt. Du angav {TotalLength} tecken.");
			Translate<MaximumLengthValidator>("\"{PropertyName}\" måste vara mellan {MinLength} och {MaxLength} tecken långt. Du angav {TotalLength} tecken.");
			Translate<LessThanOrEqualValidator>("\"{PropertyName}\" måste vara mindre än eller lika med {ComparisonValue}.");
			Translate<LessThanValidator>("\"{PropertyName}\" måste vara mindre än {ComparisonValue}.");
			Translate<NotEmptyValidator>("\"{PropertyName}\" måste anges.");
			Translate<NotEqualValidator>("\"{PropertyName}\" får inte vara lika med \"{CompairsonValue}\".");
			Translate<NotNullValidator>("\"{PropertyName}\" måste anges.");
			Translate<PredicateValidator>("Det angivna villkoret uppfylldes inte för \"{PropertyName}\".");
			Translate<AsyncPredicateValidator>("Det angivna villkoret uppfylldes inte för \"{PropertyName}\".");
			Translate<RegularExpressionValidator>("\"{PropertyName}\" har inte ett korrekt format.");
			Translate<EqualValidator>("\"{PropertyName}\" måste vara lika med \"{ComparisonValue}\".");
			Translate<ExactLengthValidator>("\"{PropertyName}\" måste vara {MaxLength} tecken långt. Du angav {TotalLength} tecken.");
			Translate<InclusiveBetweenValidator>("\"{PropertyName}\" måste vara mellan {From} och {To}. Du angav {Value}.");
			Translate<ExclusiveBetweenValidator>("\"{PropertyName}\" måste vara mellan {From} och {To} (gränsvärdena exkluderade). Du angav {Value}.");

		}
	}
}