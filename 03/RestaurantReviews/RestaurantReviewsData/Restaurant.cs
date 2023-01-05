﻿using System.Text.RegularExpressions;
namespace RestaurantReviewsData;
public class Restaurant
{
    public Restaurant()
    {
        Id = 1;
        Name = "Taco Bell";
        OpenTime = "7:00";
        CloseTime = "21:00";
        Email = "contactus@tacobell.in";
        phone = "9876543210";
        Website = "https://tacobell.in";
        ZipCode = "600130";
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string OpenTime { get; set; }
    public string CloseTime { get; set; }
    string phone;
    public string Phone
    {
        get
        {
            return phone;
        }

        set
        {
            string pattern = @"[6-9]\d{9}";
            var IsPhoneCorrect = Regex.IsMatch(phone, pattern, RegexOptions.IgnorePatternWhitespace);
            if (IsPhoneCorrect)
                phone = value;
            else
                throw new InvalidDataException("Please add a valid mobile phone with 10 digits only");
        }
    }
    public string Email { get; set; }
    public string Website { get; set; }
    public string ZipCode { get; set; }
}
