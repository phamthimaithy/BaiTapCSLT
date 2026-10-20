/*
 * Bài: Buoi01_B3 - Sửa lỗi chương trình cho sẵn
 * Sinh viên: Phạm Thị Mai Thy
 * MSSV: 31251023976
 * Ngày: 18/10/2026
 */
namespace Buoi01_B3
{ // sửa: thêm ngoặc nhọn mở của namespace
    internal class program
    {
        // sửa: xóa bớt một dấu ngoặc nhọn { bị dư ở đây
        static void Main(string[] args) // sửa: đổi 'main' thành 'Main' (viết hoa)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // sửa: thêm dấu chấm phẩy (;) ở cuối
            Console.WriteLine("Chương trình có lỗi"); // sửa: đổi 'console' thành 'Console' và thêm nháy kép (") đóng chuỗi
            Console.WriteLine(@"Đường dẫn: C:\Temp\new"); // sửa: đổi 'Writeline' thành 'WriteLine'. Sửa lỗi logic: thêm ký tự @ ở đầu để in đúng dấu \ mà không bị nhầm thành \T (tab) và \n (xuống dòng).
            Console.WriteLine("Kết thúc"); // sửa: đổi nháy đơn (' ') thành nháy kép (" ") cho chuỗi
        }
    }
} // sửa: thêm ngoặc nhọn đóng của namespace ở cuối file