/*
 * Bài: Buoi02_A1 - Khảo sát giới hạn các kiểu số
 * Sinh viên: Phạm Thị Mai Thy
 * MSSV: 31251023976
 * Ngày: 22/10/2026
 */
using System.Globalization;

namespace Buoi02_A1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập chuẩn theo tài liệu Buổi 2
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            // In phạm vi giá trị và kích thước các kiểu dữ liệu
            Console.WriteLine($"byte   : {byte.MinValue} .. {byte.MaxValue} ({sizeof(byte)} byte)");
            Console.WriteLine($"short  : {short.MinValue} .. {short.MaxValue} ({sizeof(short)} byte)");
            Console.WriteLine($"int    : {int.MinValue} .. {int.MaxValue} ({sizeof(int)} byte)");
            Console.WriteLine($"long   : {long.MinValue} .. {long.MaxValue} ({sizeof(long)} byte)");
            Console.WriteLine($"double : {double.MinValue} .. {double.MaxValue} ({sizeof(double)} byte)");
            Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal.MaxValue} ({sizeof(decimal)} byte)");

            // Quan sát hiện tượng tràn số
            int m = int.MaxValue;
            m = m + 1;
            Console.WriteLine($"int.MaxValue + 1 = {m}");

            // Khai báo số lớn dùng long
            long danSo = 8_100_000_000;
            Console.WriteLine($"Dân số thế giới (long): {danSo:N0}");
        }
    }
}