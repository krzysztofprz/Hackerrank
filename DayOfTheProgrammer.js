function dayOfProgrammer(year) {
		var february;

		if (year < 1918) {
			february = dayOfProgrammerJulian(year) + 31;
		}
		else if (year == 1918) {
			february = 46;
		}
		else {
			february = dayOfProgrammerGregorian(year) + 31;
		}

		const days = february + 31 + 30 + 31 + 30 + 31 + 31;
		const programmerDay = 256 - days;


		function dayOfProgrammerJulian(year) {
			if (year % 4 !== 0) {
				return 28;
			}
			else {
				return 29;
			}
		}

		function dayOfProgrammerGregorian(year) {
			if (year % 400 === 0 || (year % 4 === 0 && year % 100 !== 0)) {
				return 29;
			}
			else {
				return 28;
			}
		}

		return programmerDay + '.09.' + year;
	}
