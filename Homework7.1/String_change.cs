using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7._1
{
    class String_change
    {
        private string input_string;
        public string Input_string
        {
            set
            {
                try
                {
                    input_string = value;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            get
            {
                return input_string;
            }
        }

        public Dictionary<string, string> word_dictionary = new Dictionary<string, string>();
            


        private string output_string;
        public string Output_string
        {
            get
            {
                return output_string;
            }
        }

        String_change()
        {
            input_string = " ";
            output_string = " ";
            word_dictionary = new Dictionary<string, string>()
            {
                { "I", "Boy" },
                { "go", "run" },
                {"to", "to " },
                { "school", "cinema" },
            };

        }

        public String_change(string str)
        {
            input_string = str;
            word_dictionary = new Dictionary<string, string>()
            {
                { "I", "Boy" },
                { "go", "run" },
                {"to", "to " },
                { "school", "cinema" },
            };
        }



        public void translate_method()
        {
            string[] out_str = input_string.Split(' ');
            string tmp;
            for(int i = 0; i < out_str.Length; i++)
            {
                if (word_dictionary.ContainsKey(out_str[i]))
                {
                    tmp = out_str[i];
                    out_str[i] = word_dictionary[tmp];  
                }
                else
                {
                    Console.WriteLine($"Your word {out_str[i]} isnt in dictionary\n please add word in dictionary");
                    word_dictionary.Add(out_str[i], Console.ReadLine());
                    i -= 1;
                }
            }
            output_string = String.Join(" ", out_str);



        }
     
    
    
    }
}
