using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Application.Service
{
    public class BackupService
    {
        private readonly string _dbPath;

        public BackupService()
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            _dbPath = Path.Combine(folder, "FlowerShopManager", "FlowerShop.db");
        }

        public void Backup(string destinationPath)
        {
            try
            {
                File.Copy(_dbPath, destinationPath, true);
            }
            catch (IOException)
            {
                throw new Exception("Backup failed: destination path is not accessible.");
            }
        }

        public void Restore(string sourcePath)
        {
            // Validate SQLite magic bytes: "SQLite format 3\000"
            byte[] magic = Encoding.ASCII.GetBytes("SQLite format 3\0");
            byte[] header = new byte[16];
            using (var fs = File.OpenRead(sourcePath))
            {
                int read = fs.Read(header, 0, 16);
                if (read < 16 || !header.SequenceEqual(magic))
                    throw new Exception("Restore failed: the selected file is not a valid database backup.");
            }
            File.Copy(sourcePath, _dbPath, true);
        }

        public void AutoBackup()
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var backupsDir = Path.Combine(folder, "FlowerShopManager", "Backups");
            Directory.CreateDirectory(backupsDir);

            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string dest = Path.Combine(backupsDir, $"FlowerShop_{timestamp}.db");
            File.Copy(_dbPath, dest, true);

            // Prune: keep only the 3 most recent
            var files = Directory.GetFiles(backupsDir, "FlowerShop_*.db")
                .Select(f => new FileInfo(f))
                .OrderByDescending(f => f.CreationTime)
                .ToList();

            foreach (var file in files.Skip(3))
            {
                file.Delete();
            }
        }
    }
}
