

namespace BlApi;

public static class Factory
{
    public static IBl GetBl()
    {
        return new BlImplementation.Bl();
    }
}
