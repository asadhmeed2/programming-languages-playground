class Lasagna
{
     private int minutesInOven = 40;


     private int layerPreparingTime = 2;

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

    public int PreparationTimeInMinutes(int numberOfLayers)
    {
	if(numberOfLayers <= 0)
	{
		return 0;
	}
	
	return 	numberOfLayers * this.layerPreparingTime;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method

    public int ElapsedTimeInMinutes(int numberOfLayers, int ovenTimeInMinutes)
    {
	    if(numberOfLayers <= 0 || ovenTimeInMinutes <= 0)
	    {
		return 0;		
	    }

	    int preparationTime = this.PreparationTimeInMinutes(numberOfLayers);

	    return ovenTimeInMinutes + preparationTime; 
    }
}
