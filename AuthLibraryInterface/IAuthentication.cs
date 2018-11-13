namespace AuthLibraryInterface
{
    public interface IAuthentication
    {
        bool Authenticate(string userName, string password);
    }
}
