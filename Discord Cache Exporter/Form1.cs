using System;
using System.IO;
using System.Windows.Forms;
using FileTypeChecker.Abstracts;
using FileTypeChecker;

namespace Discord_Cache_Exporter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximumSize = Size;
            MinimumSize = Size;
        }

        string sourcePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\discord\Cache";
        string destFolder = "";

        private void loadFunctions(object sender, EventArgs e)
        {
            if (Directory.Exists(sourcePath))
                sourcetxt.Text = sourcePath;
            else
                MessageBox.Show("Discord cache folder wasn't found in it's default path , select it manually.");
        }


        private void sourceButton(object sender, EventArgs e)
        {
            DialogResult srcResult = source.ShowDialog();
            if (srcResult == DialogResult.OK && !string.IsNullOrWhiteSpace(source.SelectedPath) && Directory.Exists(source.SelectedPath))
            {
                sourcetxt.Text = source.SelectedPath;
                sourcePath = source.SelectedPath;
            }
        }

        private void destButton(object sender, EventArgs e)
        {
            DialogResult dstResult = destination.ShowDialog();
            if (dstResult == DialogResult.OK && !string.IsNullOrWhiteSpace(destination.SelectedPath) && Directory.Exists(destination.SelectedPath))
            {
                desttxt.Text = destination.SelectedPath;
                destFolder = destination.SelectedPath + "\\";
            }
        }

        private void exportCache(object sender, EventArgs e)
        {
            logger.Clear();
            int validCounter = 0;
            foreach (string s in Directory.GetFiles(sourcePath))
            {
                if (!IsFileLocked(new FileInfo(s)))
                {
                    using (var fileStream = File.OpenRead(s))
                    {
                        var isRecognizableType = FileTypeValidator.IsTypeRecognizable(fileStream);

                        if (isRecognizableType)
                        {
                            IFileType fileType = FileTypeValidator.GetFileType(fileStream);
                            string destPath = destFolder + Path.GetFileNameWithoutExtension(s) + "." + fileType.Extension;
                            logger.AppendText(string.Format("Exporting cache file [{0}] to destination path: [{1}]\n", Path.GetFileNameWithoutExtension(s), destPath));
                            if (File.Exists(destPath))
                                File.Delete(destPath);
                            File.Copy(s, destPath);
                            validCounter++;
                        }
                    }

                }
            }

            MessageBox.Show($"Se han exportado {validCounter.ToString()} archivos desde la caché a la carpeta {destFolder}.");
        }


        protected virtual bool IsFileLocked(FileInfo file)
        {
            try
            {
                using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                return true;
            }

            return false;
        }

    }
}
