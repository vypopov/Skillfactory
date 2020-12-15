using System;

namespace Module13
{
    class Program
    {
        static void Main(string[] args)
        {
            var UserData = GetUserData();
            ShowUserData(UserData);
        }
        static (string Name, string LastName, int Age, string HasPet,int PetCnt, string[] PetNames ,string HasFavCol, int FavcolorCnt, string[] Favcolors) GetUserData()
        {
            (string Name, string LastName, int Age, string HasPet, int PetCnt, string[] PetNames, string HasFavCol, int FavcolorCnt, string[] Favcolors) UserData;
            Console.WriteLine("Введите имя");
            UserData.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            UserData.LastName = Console.ReadLine();

            string age;
            do
            {
                Console.WriteLine("Введите возвраст цифрами");
                age = Console.ReadLine();
            }
            while (CheckNum(age, out UserData.Age) ^ true);

            string petcnt;
            Console.WriteLine("У Вас есть питомцы? (Да\\Нет)");
            UserData.HasPet = Console.ReadLine();
            var empty = new string[0];

            if (UserData.HasPet.ToUpper() == "ДА")
            {
                do
                {
                    Console.WriteLine("Введите число питомцев цифрами");
                    petcnt = Console.ReadLine();
                    
                } while (CheckNum(petcnt, out UserData.PetCnt) ^ true);
                UserData.PetNames = GetPetName(UserData.PetCnt);
            }
            else
            {
                UserData.PetCnt = 0;
                UserData.PetNames = empty;
            }
            string favclrcnt;
            Console.WriteLine("У Вас есть любимый цвет? (Да\\Нет)");
            UserData.HasFavCol = Console.ReadLine();

            if (UserData.HasFavCol.ToUpper() == "ДА")
            {
                do
                {
                    Console.WriteLine("Введите число любимых цветов цифрами");
                    favclrcnt = Console.ReadLine();
                } while (CheckNum(favclrcnt, out UserData.FavcolorCnt) ^ true);
                UserData.Favcolors = GetColorName(UserData.FavcolorCnt);
            }
            else
            {
                UserData.FavcolorCnt = 0;
                UserData.Favcolors = empty;
            }
            Console.Clear();
            return UserData;

        }
        static string[] GetPetName(int num)
        {
            var result = new string[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите имя питомца №{0}", i + 1);
                result[i] = Console.ReadLine();
            }
            return result;
        }
        static string[] GetColorName(int num)
        {
            var result = new string[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите название цвета №{0}", i + 1);
                result[i] = Console.ReadLine();
            }
            return result;
        }
        static bool CheckNum(string number,out int corrnumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return true;
                }
            }
            {
                corrnumber = 0;
                return false;
            }
        }
        static void ShowUserData((string Name, string LastName, int Age, string HasPet, int PetCnt, string[] PetNames, string HasFavCol, int FavcolorCnt, string[] Favcolors) UserData)
        {
       
            Console.WriteLine("Ваше имя: {0}\nВаша фамилия: {1}\nВаш возвраст: {2}",UserData.Name,UserData.LastName,UserData.Age);
            if (UserData.HasPet.ToUpper() == "ДА")
            {
                Console.WriteLine("У Вас есть питомцы.(В кол-ве: {0})", UserData.PetCnt);
                Console.WriteLine("Их зовут так:");
                for (int i = 0; i < UserData.PetNames.Length; i++)
                {
                    Console.WriteLine("\t\t{0}", UserData.PetNames[i]); 
                }
            }
            else
            {
                Console.WriteLine("У Вас нет питомцев.");
            }
            if (UserData.HasFavCol.ToUpper() == "ДА")
            {
                Console.WriteLine("У Вас есть любимый цвет.({0} шт.)",UserData.FavcolorCnt);
                Console.WriteLine("Любимые цвета:");
                for (int i = 0; i < UserData.Favcolors.Length; i++)
                {
                    Console.WriteLine("\t\t{0}", UserData.Favcolors[i]);
                }
            }
            else
            {
                Console.WriteLine("У Вас нет любимых цветов.");
            }

            Console.ReadKey();

        }
    }   
}
