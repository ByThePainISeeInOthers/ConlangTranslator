using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Word
    {
        //свойства
        private string word { get; set; }
        private string root { get; set; }
        private string[] preffixes { get; set; }
        private string[] suffixes { get; set; }
        private string ending { get; set; }
        private string eng_word { get; set; }
        private string eng_root { get; set; }
        private string[] eng_preffixes { get; set; }
        private string[] eng_suffixes { get; set; }
        private string eng_ending { get; set; }
        //конструкторы
        public Word() //конструктор по умолчанию
        {
            word = "";
            root = "";
            preffixes[0] = "";
            suffixes[0] = "";
            ending = "";
            eng_word = "";
            eng_root = "";
            eng_preffixes[0] = "";
            eng_suffixes[0] = "";
            eng_ending = "";
        }
        public Word(string _word, string _root, string[] _preffixes, string[] _suffixes, string _ending, string _eng_word, string _eng_root, string[] _eng_preffixes, string[] _eng_suffixes, string _eng_ending)
        {
            word = _word;
            root = _root;
            preffixes = _preffixes;
            preffixes = _suffixes;
            ending = _ending;
            eng_word = _eng_word;
            eng_root = _eng_root;
            preffixes = _eng_preffixes;
            preffixes = _eng_suffixes;
            ending = _eng_ending;
        }
        //методы
        public string Glossing() { return "0"; }
        public string Deglossing() { return "0"; }
    }
}
