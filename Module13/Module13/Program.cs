using System;

namespace Module13
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static (string Name, string LastName, byte Age, string HasPet) GetUserData()
        {
            (string Name, string LastName, byte Age, string HasPet) UserData;
            UserData.Age = 1;
            UserData.Name = "ss";
            UserData.LastName = "w";
            UserData.HasPet = "Да";
            return UserData;
        }
    }   
}
