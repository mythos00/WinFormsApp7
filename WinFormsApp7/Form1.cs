namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        private string selectedFolder = "";
        private string selectedFile = "";

        public Form1()
        {
            InitializeComponent();


            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;

            toolStripStatusLabel1.Text = "Status: Hazır";
            toolStripStatusLabel2.Text = "Fayl sayı: 0";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string FormatSize(long bytes)
        {
            if (bytes < 1024)
                return bytes + " bayt";

            if (bytes < 1024 * 1024)
                return (bytes / 1024.0).ToString("0.##") + " KB";

            if (bytes < 1024L * 1024 * 1024)
                return (bytes / (1024.0 * 1024)).ToString("0.##") + " MB";

            return (bytes / (1024.0 * 1024 * 1024)).ToString("0.##") + " GB";
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
        }
        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Qovluq seçin";

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFolder = folderDialog.SelectedPath;

                    textBox1.Text = selectedFolder;

                    listBox1.Items.Clear();
                    richTextBox1.Clear();

                    selectedFile = "";

                    string[] files = Directory.GetFiles(selectedFolder);

                    foreach (string file in files)
                    {
                        listBox1.Items.Add(Path.GetFileName(file));
                    }

                    toolStripStatusLabel2.Text =
                        "Fayl sayı: " + listBox1.Items.Count;

                    toolStripStatusLabel1.Text = "Qovluq seçildi";

                    if (files.Length == 0)
                    {
                        MessageBox.Show(
                            "Seçilmiş qovluqda fayl yoxdur.",
                            "Məlumat",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show(
                    "Zəhmət olmasa, açmaq üçün fayl seçin!",
                    "Xəta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            selectedFile = Path.Combine(
                selectedFolder,
                listBox1.SelectedItem.ToString()
            );

            try
            {
                richTextBox1.Text = File.ReadAllText(selectedFile);

                FileInfo fileInfo = new FileInfo(selectedFile);

                label6.Text = "Ad: " + fileInfo.Name;
                label7.Text = "Ölçü: " + FormatSize(fileInfo.Length);
                label8.Text = "Yaranma tarixi: " +
                              fileInfo.CreationTime.ToString("dd.MM.yyyy HH:mm");

                textBox1.Text = selectedFile;

                toolStripStatusLabel1.Text = "Fayl açıldı";

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Faylı açmaq mümkün olmadı!\n" + ex.Message,
                    "Xəta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Title = "Faylı yadda saxla";
                saveDialog.Filter =
                    "Mətn faylları (*.txt)|*.txt|Bütün fayllar (*.*)|*.*";

                if (!string.IsNullOrEmpty(selectedFolder))
                {
                    saveDialog.InitialDirectory = selectedFolder;
                }

                saveDialog.FileName = "YeniFayl.txt";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(
                            saveDialog.FileName,
                            richTextBox1.Text
                        );

                        selectedFolder =
                            Path.GetDirectoryName(saveDialog.FileName);

                        selectedFile = saveDialog.FileName;

                        // Yeni yaradılmış faylı siyahıya əlavə et
                        string fileName = Path.GetFileName(selectedFile);

                        if (!listBox1.Items.Contains(fileName) &&
                            Path.GetDirectoryName(selectedFile) == selectedFolder)
                        {
                            listBox1.Items.Add(fileName);
                        }

                        textBox1.Text = selectedFile;

                        FileInfo fileInfo = new FileInfo(selectedFile);

                        label6.Text = "Ad: " + fileInfo.Name;
                        label7.Text = "Ölçü: " + FormatSize(fileInfo.Length);
                        label8.Text = "Yaranma tarixi: " +
                                      fileInfo.CreationTime.ToString("dd.MM.yyyy HH:mm");

                        toolStripStatusLabel2.Text =
                            "Fayl sayı: " + listBox1.Items.Count;

                        toolStripStatusLabel1.Text = "Fayl yadda saxlanıldı";

                        MessageBox.Show(
                            "Fayl uğurla yadda saxlanıldı!",
                            "Məlumat",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Faylı yadda saxlamaq mümkün olmadı!\n" + ex.Message,
                            "Xəta",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show(
                    "Silmək üçün fayl seçilməyib!",
                    "Xəta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string fileToDelete = Path.Combine(
                selectedFolder,
                listBox1.SelectedItem.ToString()
            );

            DialogResult result = MessageBox.Show(
                "Seçilmiş faylı silmək istəyirsiniz?\n" +
                Path.GetFileName(fileToDelete),
                "Faylın silinməsi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    File.Delete(fileToDelete);

                    listBox1.Items.Remove(listBox1.SelectedItem);

                    richTextBox1.Clear();

                    selectedFile = "";

                    label6.Text = "Ad:";
                    label7.Text = "Ölçü:";
                    label8.Text = "Yaranma tarixi:";

                    textBox1.Text = selectedFolder;

                    toolStripStatusLabel2.Text =
                        "Fayl sayı: " + listBox1.Items.Count;

                    toolStripStatusLabel1.Text = "Fayl silindi";

                    MessageBox.Show(
                        "Fayl uğurla silindi!",
                        "Məlumat",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Faylı silmək mümkün olmadı!\n" + ex.Message,
                        "Xəta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null ||
            string.IsNullOrEmpty(selectedFolder))
            {
                return;
            }

            selectedFile = Path.Combine(
                selectedFolder,
                listBox1.SelectedItem.ToString()
            );

            if (File.Exists(selectedFile))
            {
                FileInfo fileInfo = new FileInfo(selectedFile);

                label6.Text = "Ad: " + fileInfo.Name;
                label7.Text = "Ölçü: " + FormatSize(fileInfo.Length);
                label8.Text = "Yaranma tarixi: " +
                              fileInfo.CreationTime.ToString("dd.MM.yyyy HH:mm");

                textBox1.Text = selectedFile;

                toolStripStatusLabel1.Text = "Fayl seçildi";
            }
        }
    }
}
