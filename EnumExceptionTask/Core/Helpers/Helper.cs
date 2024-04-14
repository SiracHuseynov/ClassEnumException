using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers
{
    public static class Helper
    {
        public static bool CheckName(string name)
        {
            bool f = true;
            bool k = false;
            if(name.Length >= 3)
            {
                if (name[0].ToString() == name[0].ToString().ToUpper() && name.Length > 3)
                {
                    k = true;
                }
                for (int i = 1; i < name.Length; i++)
                {
                    if (name[i] == ' ')
                    {
                        f = false;
                        break;
                    }
                }
            }

            if (f && k)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool CheckSurname(string surname)
        {
            bool f = true;
            bool k = false;
            if(surname.Length >= 3)
            {
                if (surname[0].ToString() == surname[0].ToString().ToUpper() && surname.Length > 3)
                {
                    k = true;
                }
                for (int i = 1; i < surname.Length; i++)
                {
                    if (surname[i] == ' ')
                    {
                        f = false;
                        break;
                    }
                }
            }

            if (f && k)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool CheckClassroom(string classroom) 
        {

            bool checkLetter = false;
            bool checkDigit = false;

            if (classroom.Length == 5)
            {
                for (int i = 0; i < classroom.Length - 3; i++)
                {
                    if (char.IsUpper(classroom[i]) && char.IsLetter(classroom[i]))
                    {
                        checkLetter = true;
                    }
                    else
                    {
                        checkLetter = false;
                        break;
                    }
                }

                for (int i = classroom.Length - 3; i < classroom.Length; i++)
                {
                    if (char.IsDigit(classroom[i]))
                    {
                        checkDigit = true;
                    }
                    else
                    {
                        checkDigit = false;
                        break;
                    }
                }

                if (checkLetter && checkDigit)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
    }
}
