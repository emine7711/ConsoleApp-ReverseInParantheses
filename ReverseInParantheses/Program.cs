using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInParantheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "a(b(kl)(mno))c";
            List<char> list = a.ToList();

            while (list.Contains('(') || list.Contains(')'))
            {
                int openIndex = 0;
                int closeIndex = 0;
                for (int i = 0; i < list.Count; i++)//Son açılan parantezi bulur
                {
                    if (list[i] == '(')
                    {
                        openIndex = i;
                    }
                }
                for (int i = openIndex; i < list.Count; i++)//İlk kapanan parantezi bulur
                {
                    if (list[i] == ')')
                    {
                        closeIndex = i;
                        break;
                    }
                }
                List<char> tempList = new List<char>();
                for (int i = 1; i < closeIndex - openIndex; i++)//bulunan parantez indexleri arasındaki char ları geçici bir liste atar
                {
                    tempList.Add(list[openIndex + i]);
                }
                tempList.Reverse();//geçici listi ters çevirir
                for (int i = 1; i < closeIndex - openIndex; i++)//ters çevrilen listi asıl listteki ilgili alana yerleştirir
                {
                    list[openIndex + i] = tempList[i - 1];
                }
                list.RemoveRange(openIndex, 1);
                list.RemoveRange(closeIndex - 1, 1);
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
            }
            Console.ReadLine();
        }
    }
}
