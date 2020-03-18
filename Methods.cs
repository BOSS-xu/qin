

namespace _2_5
{
    class Methods
    {
        public static void tro(string str)
        {
            int i = 0;
            String s;
            int b;
            char[] ch = new char[str.Length];
            try
            {

                foreach (char c in str)
                {
                    if (c >= 48 && c <= 58)
                    {
                        ch[i] = c;
                        i++;
                    }
                    else
                    {
                        s = new String(ch);
                        b = int.Parse(s);
                        Console.WriteLine(b);
                        ch = null;
                        continue;
                    }
                }
            }
            catch { }
        
        }
    }
}
