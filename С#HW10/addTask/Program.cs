using System;
using static System.Console;

Clear();

bool StringComparer (string str1, string str2){
    for (int i = 0; i < str1.Length; i++){
        if (str2.Length != 0){
            for (int j = 0; j < str2.Length; j++){
                if (str1[i] == str2[j]) {
                    str1 = str1.Remove(i,1);
                    str2 = str2.Remove(j,1);
                    break;
                } else if (j == str2.Length-1){
                    return false;
                }
            }
        } else if (str1.Length != 0){
            return false;
        }
        i--;
    }
    return true;
}

string StrConverter (string str){
    str = str.ToLower();
    str = str.Replace(" ","");
    WriteLine(str);
    return str;
}

void Comparer (bool result){
    if (result == true){
        WriteLine("Ответ: Да");
    } else {
        WriteLine("Ответ: Нет");
    }
}

string str1 = "Tom Marvolo Riddle";
string str2 = "I am Lord Voldemort";
str1 = StrConverter(str1);
str2 = StrConverter(str2);
Comparer(StringComparer(str1, str2));
