namespace AuthLibrary.LDAP
{
    using AuthLibraryInterface;
    using System.DirectoryServices.Protocols;

    public class LDAPAuthentication : IAuthentication
    {
        public bool Authenticate(string userName, string password)
        {
            var serverId = new LdapDirectoryIdentifier("localhost", 12001);
            /*
            var credentials = new NetworkCredential("CN=Administrator,CN=Users,DC=company,DC=com", "password");
            using (var conn = new LdapConnection(serverId, credentials))
            {
            }
            */
            return true;
        }
    }
}
