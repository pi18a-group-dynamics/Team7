using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ГР
{
    class Class1
    {
        //символы русской азбуки
        const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя"+
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"+",./()?!"+"123456789";

        public string CodeEncode(string text, int k)
        {
            //добавляем в алфавит маленькие буквы
            int letterQty = alfabet.Length;
            string retVal = "";
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                int index = alfabet.IndexOf(c);
                if (index < 0)
                {
                    //если символ не найден, то добавляем его в неизменном виде
                    retVal += c.ToString();
                }
                else
                {
                    int codeIndex = (letterQty + index + k) % letterQty;
                    retVal += alfabet[codeIndex];
                }
            }

            return retVal;
        }

    }
}
