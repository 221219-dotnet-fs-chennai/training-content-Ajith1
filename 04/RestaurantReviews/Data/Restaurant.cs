﻿using System.Text.RegularExpressions;

namespace Data
{
    public class Restaurant
    {
        public Restaurant()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string OpenTime { get; set; }
        public string CloseTime { get; set; }
        public string Phone { get; set; }
        /*public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                string pattern = @"[6-9]\d{9}";
                var IsPhoneCorrect = Regex.IsMatch(phone, pattern);
                if (IsPhoneCorrect)
                    phone = value;
                else
                    throw new InvalidDataException("Please add a valid mobile phone with 10 digits only");
            }
        }*/
        public string Email { get; set; }
        public string Website { get; set; }
        public string ZipCode { get; set; }
        public override string ToString()
        {
            return $"{Id} {Name} {OpenTime}-{CloseTime}, {Email}, {Phone}, {Website}, {ZipCode} ";
        }
    }
}