static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => knightIsAwake == false;    

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => knightIsAwake || archerIsAwake ||  prisonerIsAwake;

    
    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => !archerIsAwake && prisonerIsAwake;

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        bool freePresoner = false;

        if(petDogIsPresent && !archerIsAwake)
        {
            freePresoner = true;
        }
        if(!petDogIsPresent && prisonerIsAwake && !(knightIsAwake || archerIsAwake))
        {
            freePresoner = true;
        }

        return freePresoner;
    }


}


