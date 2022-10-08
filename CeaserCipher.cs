using System;
using System.Collections;
using System.Text.RegularExpressions;

String usertext, cipher_text = "", deceiphered_text = "", key2;
int key;
//1.PlainText input
Console.WriteLine("Enter the text to be ciphered. It will be converted to upper-case");
usertext = Console.ReadLine();

usertext = Regex.Replace(usertext, @"\d", String.Empty).ToUpper();
//2.Print plaintext
Console.WriteLine(usertext);

//3.Ask for key input
Console.WriteLine("Enter the key. Limit to 1 to 26");
key2 = Console.ReadLine();
key2 = Regex.Replace(key2, @"[A-Za-z]", String.Empty);
key = Convert.ToInt32(key2);

//4. Print the Key
Console.WriteLine("Key: " + key);

//5.Encryption Method
for (int i = 0; i < usertext.Length; i++)
{
    char c = usertext[i];

    if (c >= 'A' && c <= 'Z')
    {
        c = (char)(c + key);
        if (c > 'Z')
        {
            c = (char)(c - 'Z' + 'A' - 1);
        }
        cipher_text += c;
    }
    else
    {
        cipher_text += c;
    }
}


//6.Decryption Method
for (int i = 0; i < cipher_text.Length; i++)
{
    char c = cipher_text[i];

    if (c >= 'A' && c <= 'Z')
    {
        c = (char)(c - key);
        if (c < 'A')
        {
            c = (char)(c + 'Z' - 'A' + 1);
        }
        deceiphered_text += c;
    }
    else
    {
        deceiphered_text += c;
    }
}
//7. Cipher Text
Console.WriteLine("Ciphered text is " + cipher_text);
//8. Deciphered Text
Console.WriteLine("Deceiphered text is " + deceiphered_text);




