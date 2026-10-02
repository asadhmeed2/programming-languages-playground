using System.Collections.Generic;

public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    // TODO: implement equality and GetHashCode() methods

    public bool Equal(FacialFeatures instance)
    {
        if (instance.EyeColor == this.EyeColor && instance.PhiltrumWidth == this.PhiltrumWidth)
        {
            return true;
        }
        return false;


    }
}


public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    // TODO: implement equality and GetHashCode() methods
    //
    public bool Equal(Identity identity)
    {
        if(this.Email == identity.Email && this.FacialFeatures.Equal(identity.FacialFeatures))
        {
            return true;
        }
        return false;
    }
}

public class Authenticator
{
    private Dictionary<string,Identity> identityEmail2Identity = new Dictionary<string,Identity>{};

    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)=>faceA.Equal(faceB);

    public bool IsAdmin(Identity identity) => identity.Email == "admin@exerc.ism" && identity.FacialFeatures.Equal(new FacialFeatures("green",0.9m));

    public bool Register(Identity identity)
    {
        if(this.identityEmail2Identity.TryGetValue(identity.Email, out var existsIdentity))
        {
            return false;
        }
        this.identityEmail2Identity[identity.Email] = identity;
        return true;
    }

    public bool IsRegistered(Identity identity)
    {
        throw new NotImplementedException("Please implement the Authenticator.IsRegistered() method");
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        throw new NotImplementedException("Please implement the Authenticator.AreSameObject() method");
    }
}

