using System;

public class captcha_generator
{
	public string GenerateCaptcha(int n)
    {
        string alphanum= "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        string captcha = "";
        Random r = new Random();
        for(int i=0;i<n;i++)
        {
            int ind= r.Next(alphanum.Length);
            captcha+= alphanum[ind];
        }
        return captcha;
    }
    public static void Main(string[] args)
    {
        int n = 6;
        captcha_generator c = new captcha_generator();
        Console.WriteLine(c.GenerateCaptcha(n));
    }
}
