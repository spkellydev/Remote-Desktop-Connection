using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Text;

namespace ArdiFin.CommandLib.ActiveDirectory
{
    public class UserModule : Command
    {   
        public static UserPrincipal CreateUser(PrincipalContext pc, string username)
        {
            return new UserPrincipal(pc)
            {
                SamAccountName = username
            };
        }

        public static Stack<UserPrincipal> GetADUsers(ContextType context, string domain = "")
        {
            var userStack = new Stack<UserPrincipal>();
            using (var prinCtx = new PrincipalContext(context, domain))
            {
                var userPrin = new UserPrincipal(prinCtx);
                using (var searcher = new PrincipalSearcher(userPrin))
                {
                    searcher.QueryFilter = userPrin;
                    var results = searcher.FindAll();
                    foreach(var foundUser in results)
                    {
                        UserPrincipal user = foundUser.GetUnderlyingObject() as UserPrincipal;
                        userStack.Push(user);
                    }
                }
            }
            return userStack;
        }

        public static void AddUserToActiveDirectory(UserPrincipal user)
        {
            if  (!VerifyUserInformation(user))
            {
                throw new Exception($"User {user.SamAccountName} is not allowed.");    
            }
            try
            {
                user.Save();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        private static bool VerifyUserInformation(UserPrincipal user)
        {
            if (user.SamAccountName == "admin" || user.SamAccountName == "administrator")
            {
                return false;
            }
            return true;
        }
    }
}
