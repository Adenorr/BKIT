using System;

namespace lab5
{
    public class LevenshteinDistance
    {

        public static int StrContains(string firstText, string secondText)
        {
            int Distance = 0;
            if (firstText == secondText) Distance = 0;
            else
            if (firstText.Contains(secondText)) Distance = Math.Abs(firstText.Length - secondText.Length);
            else Distance = 100;
            return Distance;
        }

        static int Minimum(int a, int b) => a < b ? a : b;

        static int Minimum(int a, int b, int c) => (a = a < b ? a : b) < c ? a : c;

        public static int WagnerFisher(string firstText, string secondText)
        {
            
            var d = new int[100,100];
            
            int i, j; 
            int tracker;

            int str1_len = firstText.Length;
            int str2_len = secondText.Length;
            for (i = 0; i <= str2_len; i++)
                d[0,i] = i;
            for (j = 0; j <= str1_len; j++)
                d[j,0] = j;
            for (j = 1; j <= str1_len; j++)
            {
                for (i = 1; i <= str2_len; i++)
                {
                    if (secondText[i - 1] == firstText[j - 1])
                    {
                        tracker = 0;
                    }
                    else
                    {
                        tracker = 1;
                    }
                    int temp = Minimum((d[j - 1,i] + 1), (d[j,i - 1] + 1));
                    d[j,i] = Minimum(temp, (d[j - 1,i - 1] + tracker));
                }
            }

            int Distance = d[str1_len, str2_len];

            return Distance;
        }


        public static int DamerauLevenshtein(string firstText, string secondText)
        {
           
            // случай-где они равны
            if (firstText.Equals(secondText))
                return 0;

            // случай-где один пуст
            if (String.IsNullOrEmpty(firstText) || String.IsNullOrEmpty(secondText))
                return (firstText ?? "").Length + (secondText ?? "").Length;

            // firstText длинней secondText
            if (firstText.Length > secondText.Length)
            {
                var tmp = firstText;
                firstText = secondText;
                secondText = tmp;
            }

            if (secondText.Contains(firstText))
                return secondText.Length - firstText.Length;  

            
            var fl = firstText.Length + 1;
            var sl = secondText.Length + 1;
            
            var arrayD = new int[fl, sl];
            
            
            
                for (var ii = 0; ii < fl; ii++)
                {
                    arrayD[ii, 0] = ii;
                   
                }

                for (var jj = 0; jj < sl; jj++)
                {
                    arrayD[0, jj] = jj;
                   
                }

                for (var ii = 1; ii < fl; ii++)
                {
                    for (var jj = 1; jj < sl; jj++)
                    {
                        
                        
                            
                        var cost =  firstText[ii - 1] == secondText[jj - 1] ? 0 : 1;
                        if (ii > 1 && jj > 1
                            && firstText[ii - 1] == secondText[jj - 2]
                            && firstText[ii - 2] == secondText[jj - 1])
                        
                             // перестановка
                            arrayD[ii, jj] = Minimum(arrayD[ii, jj],
                                                     arrayD[ii - 2, jj - 2] + cost); 
                            
                        
                        else  if (arrayD[ii,jj - 1] < arrayD[ii - 1,jj] && arrayD[ii,jj - 1] < arrayD[ii - 1,jj - 1] + cost)
                        {
                             //Вставка
                             arrayD[ii,jj] = arrayD[ii,jj - 1] + 1;
                        }
                        else if (arrayD[ii - 1,jj] < arrayD[ii - 1,jj - 1] + cost)
                        {
                             //Удаление
                             arrayD[ii,jj] = arrayD[ii - 1,jj] + 1;
                        }
                        else
                        {
                             //Замена или отсутствие операции
                             arrayD[ii,jj] = arrayD[ii - 1,jj - 1] + cost;
                        }
                        
                   
                    }


                }
           
            return arrayD[fl - 1, sl - 1];
         }
      
    }

}
