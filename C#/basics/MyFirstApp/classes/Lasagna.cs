class Lasagna
{
     private int minutesInOven = 40;


     public int ExpectedMinutesInOven() => this.minutesInOven;

    public float RemainingMinutesInOven(float currentTime) 
    {
	if(currentTime < 0 || currentTime > this.minutesInOven)
	{
		return 0;
	}
	return this.minutesInOven - currentTime;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method

    // TODO: define the 'ElapsedTimeInMinutes()' method
}
