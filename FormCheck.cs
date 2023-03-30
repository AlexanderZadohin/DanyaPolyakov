using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DanyaPolyakov
{
    public class FormCheck
    {
        public bool FullName(string fullName)
        {
            if (fullName.Length > 0 && fullName.Length <= 20)
            {
                string[] subs = fullName.Split(' ');

                for (int i = 0; i < subs.Length; i++)
                {
                    string pattern_nm = @"\b[А-Я,A-Z]\w*";

                    if (Regex.IsMatch(fullName, pattern_nm))
                    {
                        return true;
                    }

                    return false;
                }
            }
            return false;
        }

        public bool AgeInput(string Ages)
        {
            string pattern = @"[0-9]";
            if (Ages.Length == 2 && Regex.IsMatch(Ages,pattern))
            {
                return true;
            }
            return false;
        }

        public bool EmailInput(string email)
        {
            string pattern_em = @"\w+@\w+.\w+";
            if (email.Length > 0 && email.Length <= 30 && (Regex.IsMatch(email, pattern_em)))
            {
                return true;
            }
            return false;
        }

        public bool TelephoneNumInput(string number)
        {
            string pattern = @"\W+[0-9]*\b";
            string pattern2 = @"[0-9]";
            if (number.Length > 14 && number.Length <= 17 && Regex.IsMatch(number, pattern))
            {
                return true;
            }
            else if (number.Length > 5 && number.Length <= 13 && Regex.IsMatch(number, pattern2)) 
            {
                return true;
            }
            return false;
        }
        public bool HobbysInput(string hobbys)
        {
            if (hobbys.Length <= 1024)
            {
                return true;
            }
            return false;
        }
        public bool LearninObject(string lrnObj)
        {
            if (lrnObj == "Прохожу курсы" || lrnObj == "Читаю книги" || lrnObj == "Смотрю видео")
            {
                return true;
            }
            return false;
        }

        public bool WhatUWant(string likes)
        {
            if (likes == "Бэкэнд" || likes == "Фронтэнд")
            {
                return true;
            }
            return false;
        }
    }
}
