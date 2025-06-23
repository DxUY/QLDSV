using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLDSV.Be.Utils
{
    internal class Validation
    {
        public static bool IsValidYearRange(string input, int minYear = 1900, int maxYear = 2100, int maxSpan = 5)
        {
            var match = Regex.Match(input, @"^(\d{4})-(\d{4})$");
            if (!match.Success)
                return false;

            int startYear = int.Parse(match.Groups[1].Value);
            int endYear = int.Parse(match.Groups[2].Value);

            if (startYear < minYear || endYear > maxYear)
                return false;

            if (endYear < startYear || (endYear - startYear > maxSpan))
                return false;

            return true;
        }

        public static bool IsValidDate(string dateString)
        {
            DateTime birthDate;
            bool isValidFormat = DateTime.TryParseExact(dateString, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out birthDate);

            if (!isValidFormat)
                return false;

            DateTime today = DateTime.Today;

            if (birthDate >= today)
                return false;

            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age)) age--;

            return age >= 18 && age <= 120;
        }

        public static bool TryValidatePositiveInt(string input, string fieldName, out int result)
        {
            result = 0;

            if (!int.TryParse(input?.Trim(), out result) || result <= 0)
            {
                MessageBox.Show($"{fieldName} phải là số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool ValidateScore(object value, out float result)
        {
            result = 0;

            if (value == null) return false;

            string input = value.ToString()?.Trim();
            if (string.IsNullOrWhiteSpace(input)) return false;

            if (float.TryParse(input, out float val))
            {
                if (val >= 0 && val <= 10)
                {
                    result = val;
                    return true;
                }
            }

            MessageBox.Show("The score is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        public static bool IsInputComplete(Dictionary<string, string> data)
        {
            foreach (var value in data.Values)
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                    return false;
                }
            }
            return true;
        }

        public static bool IsDuplicateInBindingSource(BindingSource source, string value, string field, DataRowView except = null)
        {
            foreach (DataRowView row in source)
            {
                if (row == except) continue;
                if (row[field].ToString().Trim() == value.Trim())
                    return true;
            }
            return false;
        }
    }
}
