using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskClient
{
    public static class Globals
    {
        public static string taskServiceUrl = "https://aadb2cplayground.azurewebsites.net";
        public static string aadInstance = "https://login.microsoftonline.com/";
        public static string redirectUri = "urn:ietf:wg:oauth:2.0:oob";

        // TODO: Replace these five default with your own configuration values
        public static string tenant = "fabrikamb2c.onmicrosoft.com";
        public static string clientId = "90c0fe63-bcf2-44d5-8fb7-b8bbc0b29dc6";
        public static string signInPolicy = "b2c_1_sign_in";
        public static string signUpPolicy = "b2c_1_sign_up";
        public static string editProfilePolicy = "b2c_1_edit_profile";

        public static string authority = string.Concat(aadInstance, tenant);

    }
}
