using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBaiBaoKHCN.BienTapVien;
using QuanLyBaiBaoKHCN.TongBienTap;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.IO;

namespace QuanLyBaiBaoKHCN
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Properties.Settings.Default.Save();
            string connectionString = Properties.Settings.Default.STRConn;

            // Kiểm tra kết nối cơ sở dữ liệu
            if (connectionString.Contains("Initial Catalog=QL_TCKHCN"))
            {
                // Gọi hàm backup ngay khi chương trình bắt đầu
                Task.Run(() => StartBackupScheduler());
                Application.Run(new Login());
            }
            else
            {
                Application.Run(new FConfig());
            }
        }

        private static void StartBackupScheduler()
        {
            // Lịch trình các thời gian backup
            var scheduleTimes = new[]
            {
                new ScheduleTime(DayOfWeek.Sunday, new TimeSpan(3, 0, 0), "full"),        // 03:00 AM Chủ Nhật - Full backup
                new ScheduleTime(DayOfWeek.Wednesday, new TimeSpan(3, 0, 0), "differential"), // 03:00 AM Thứ Tư - Differential backup
                new ScheduleTime(null, new TimeSpan(4, 0, 0), "log"),         // 04:00 AM - Log backup
                new ScheduleTime(null, new TimeSpan(10, 0, 0), "log"),        // 10:00 AM - Log backup
                new ScheduleTime(null, new TimeSpan(16, 0, 0), "log"),        // 04:00 PM - Log backup
                new ScheduleTime(null, new TimeSpan(23, 59, 0), "log")        // 11:59 PM - Log backup
            };

            // Gọi hàm kiểm tra và backup
            CheckTimeToBackup(scheduleTimes);
        }

        private static void CheckTimeToBackup(ScheduleTime[] scheduleTimes)
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            DayOfWeek currentDay = DateTime.Now.DayOfWeek;

            Console.WriteLine($"Current time: {currentTime}, Current day: {currentDay}"); // Debug statement

            foreach (var schedule in scheduleTimes)
            {
                // Kiểm tra xem có phải là ngày backup full và differential không
                if (schedule.DayOfWeek.HasValue && currentDay == schedule.DayOfWeek.Value &&
                    currentTime >= schedule.Time && currentTime < schedule.Time.Add(TimeSpan.FromMinutes(1)))
                {
                    Console.WriteLine($"Scheduled time reached: {schedule.Time} on {schedule.DayOfWeek}. Initiating {schedule.Type} backup.");
                    PerformBackup(schedule.Type);
                }

                // Kiểm tra cho các backup log không phụ thuộc vào ngày
                if (!schedule.DayOfWeek.HasValue &&
                    currentTime >= schedule.Time && currentTime < schedule.Time.Add(TimeSpan.FromMinutes(1)))
                {
                    Console.WriteLine($"Scheduled time reached: {schedule.Time}. Initiating {schedule.Type} backup.");
                    PerformBackup(schedule.Type);
                }
            }
        }
        private static void PerformBackup(string backupType)
        {
            string backupDirectory = @"D:\Backup_TapChiKhoaHoc";
            string backupFileName;


            // Đảm bảo thư mục backup tồn tại
            if (!Directory.Exists(backupDirectory))
            {
                Directory.CreateDirectory(backupDirectory);
            }

            // Tạo đối tượng Backup
            Backup bkpDB = new Backup
            {
                Database = "QL_TCKHCN"
            };

            switch (backupType.ToLower())
            {
                case "full":
                    bkpDB.Action = BackupActionType.Database;
                    backupFileName = $"QL_TCKHCN_Full_{DateTime.Now:yyyyMMddHHmmss}.bak";
                    break;
                case "differential":
                    bkpDB.Action = BackupActionType.Database;
                    bkpDB.Incremental = true;
                    backupFileName = $"QL_TCKHCN_Diff_{DateTime.Now:yyyyMMddHHmmss}.bak";
                    break;
                case "log":
                    bkpDB.Action = BackupActionType.Log;
                    backupFileName = $"QL_TCKHCN_Log_{DateTime.Now:yyyyMMddHHmmss}.trn";
                    break;
                default:
                    Console.WriteLine("Invalid backup type specified. Use Full, Differential, or Log.");
                    return;
            }

            // Kết hợp đường dẫn thư mục hiện tại với tên file backup
            string backupPath = Path.Combine(backupDirectory, backupFileName);

            // Thêm thiết bị backup
            bkpDB.Devices.AddDevice(backupPath, DeviceType.File);

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(Properties.Settings.Default.STRConn);
            string serverName = builder.DataSource;

            // Tạo đối tượng Server với ServerConnection
            Server myServer = new Server(new ServerConnection(serverName, "sa", "123"));

            // Thực hiện backup
            try
            {
                bkpDB.SqlBackup(myServer);
                Console.WriteLine("Backup completed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Backup failed: {ex.Message}");
            }
        }

    }

    class ScheduleTime
    {
        public DayOfWeek? DayOfWeek { get; }
        public TimeSpan Time { get; }
        public string Type { get; }

        public ScheduleTime(DayOfWeek? dayOfWeek, TimeSpan time, string type)
        {
            DayOfWeek = dayOfWeek;
            Time = time;
            Type = type;
        }
    }
}
