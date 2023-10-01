class Lasagna
{
	const int TotalMinutesInOven = 40;

    public int ExpectedMinutesInOven() {
		return TotalMinutesInOven;
	}

    public int RemainingMinutesInOven(int timePassed) {
		return TotalMinutesInOven - timePassed;
	}

    public int PreparationTimeInMinutes(int layers) {
		return 2 * layers;
	}

    public int ElapsedTimeInMinutes(int layers, int minutesInTheOven) {
		return this.PreparationTimeInMinutes(layers) + minutesInTheOven;
	}
}
