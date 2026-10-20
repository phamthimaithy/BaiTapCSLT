/*
 * Bài: Buoi01_B2 - Thiệp chúc mừng có khung
 * Sinh viên: Phạm Thị Mai Thy
 * MSSV: 31251023976
 * Ngày: 18/10/2026
 */
namespace Buoi01_B2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // In thiệp với chiều rộng cố định 40 ký tự
            Console.WriteLine("****************************************");
            Console.WriteLine("*                                      *");
            Console.WriteLine("*      CHÚC MỪNG NGÀY NHÀ GIÁO VN      *");
            Console.WriteLine("*                20/11                 *");
            Console.WriteLine("*                                      *");

            // Dùng \" để in được dấu nháy kép ra màn hình
            Console.WriteLine("*  Học trò kính chúc:                   *");
            Console.WriteLine("* \"Thầy cô luôn mạnh khỏe!\"            *");
            Console.WriteLine("*                                      *");
            Console.WriteLine("****************************************");
        }
    }
}
