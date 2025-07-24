using AlignTech.CSharp.Day7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlignTech.CSharp.Day7
{
    public class DictionaryExample
    {
        public Dictionary<string, int> scores = new();
        public Dictionary<string, UserProfile> userProfiles = new();

        public void AddScores()
        {
            //scores[key]=value //Collection Initializer
            scores["Aravind"] = 500;
            scores.Add("Priya", 550);
            scores["Jameel"] = 600;

            //KeyValuePair<TKey, TValue>
            foreach (var score in scores)
            {
                Console.WriteLine($"Player Name :{score.Key}, Score :{score.Value}");
            }
        }

        public void AddUserProfiles()
        {
            userProfiles["john123"] = new UserProfile { UserId = "john123", EmailId = "john@gmail.com", MobileNo = "50000055" };
            userProfiles["alice123"] = new UserProfile { UserId = "alice123", EmailId = "alice@gmail.com", MobileNo = "88889999" };
            userProfiles["kumar123"] = new UserProfile { UserId = "kumar123", EmailId = "kumar@gmail.com", MobileNo = "66660000" };

            userProfiles.Remove("alice123");

            foreach(var profile in userProfiles)
            {
                Console.WriteLine($"Key :{profile.Key}");
                Console.WriteLine($"Email Id :{profile.Value.EmailId}, Mobile No :{profile.Value.MobileNo}");
            }
        }
    }
}
